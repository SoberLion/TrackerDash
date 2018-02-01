using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerHelper.Controls;
using TrackerHelper.DB;
using System.Runtime;

namespace TrackerHelper
{
    public partial class Dashboard : Form
    {
        delegate void Message(string message);

        private int SlideCounter = 0;

        DashboardPreset activePreset { get; set; }

        private List<IDashboardControlsUpdate> _dashboardList = new List<IDashboardControlsUpdate>();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public Dashboard()
        {
            InitializeComponent();
            DBman.CreateDatabase();
            GetActivePreset();
            //CreateDashboards();
            btnSlideshow_Click(btnSlideshow,EventArgs.Empty);
        }

        private void GetActivePreset()
        {
            activePreset = DBman.GetActivePreset();
            if (activePreset == null)
            {
                lblCaption.Text = "No active presets";
                activePreset = new DashboardPreset();
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
           // e.Cancel = false;
        }

        private void pnlHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void Toggle(object sender)
        {
            btnTechSupp.Check = false;
            btnTechSupp.BackColor = Color.FromArgb(41, 53, 65);
            btnNew.Check = false;
            btnNew.BackColor = Color.FromArgb(41, 53, 65);
            btnAssigned.Check = false;
            btnAssigned.BackColor = Color.FromArgb(41, 53, 65);
            btnNeedInfoEmpl.Check = false;
            btnNeedInfoEmpl.BackColor = Color.FromArgb(41, 53, 65);
            btnEscalated.Check = false;
            btnEscalated.BackColor = Color.FromArgb(41, 53, 65);
            btnSlideshow.Check = false;
            btnSlideshow.BackColor = Color.FromArgb(41, 53, 65);
            chbtn_Settings.Check = false;
            chbtn_Settings.BackColor = Color.FromArgb(41, 53, 65);


            (sender as CheckedButton).Check = true;
            (sender as CheckedButton).BackColor = Color.FromArgb(21, 33, 45);
        }

        private void btnTechSupp_Click(object sender, EventArgs e)
        {

            Toggle(sender);
            lblCaption.Text = "Main";

            getDashboardIssues()?.ControlUpdate();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblCaption.Text = "Новые";
            Toggle(sender);

            getIssuesStatus(1)?.ControlUpdate();
        }

        private void btnAssigned_Click(object sender, EventArgs e)
        {
            lblCaption.Text = "Назначена";
            Toggle(sender);

            getIssuesStatus(9)?.ControlUpdate();
        }

        private void btnNeedInfoEmpl_Click(object sender, EventArgs e)
        {
            lblCaption.Text = "Нужна информация (сотрудники)";
            Toggle(sender);

            getIssuesStatus(18)?.ControlUpdate();
        }

        private void btnEscalated_Click(object sender, EventArgs e)
        {
            lblCaption.Text = "Эскалирована";
            Toggle(sender);

            getIssuesStatus(22)?.ControlUpdate();
         }

        private void chbtn_Settings_Click(object sender, EventArgs e)
        {
            lblCaption.Text = "Настройки";
            Toggle(sender);

            DashboardSettings dash = Controls.Find("Настройки", true).FirstOrDefault() as DashboardSettings;
            if (dash != null)
            {
                dash.BringToFront();
            }
            else
            {
                DashboardSettings newDash = new DashboardSettings
                {
                    Parent = this.pnlDashboard,
                    Dock = DockStyle.Fill,
                    BackColor = Color.FromArgb(41, 53, 65),
                    Name = "Настройки",
                };
                newDash.BringToFront();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            tmrUpdate.Enabled = true;
            tmrUpdate.Interval = 300000/100;
            pbBGWork.ProgressValue = 100;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pbBGWork.ProgressValue -= 1;
            if (pbBGWork.ProgressValue == 0)
            {
                tmrUpdate.Enabled = false;
                if (bgWorker.IsBusy != true)
                {
                    bgWorker.RunWorkerAsync();
                }
            }
        }

        private void bgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Person user = new Person
            {
                ApiKey = "d0867cd6f5559eb738c48cd53c870ad9853999e3"
            };
            DBController dbController = new DBController(user);

            DBController.onProgressChange += delegate (EventProgressArgs args)
            {
                bgWorker.ReportProgress(args.Percents);
                SetLblLastUpdateText(args.Message);
            };

            dbController.UpdateIssues(3, 1);
            dbController.UpdateTimeEntries(3, 1);
            dbController.UpdateUsers(3);            
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbBGWork.ProgressValue = e.ProgressPercentage;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                tmrUpdate.Enabled = true;
            }
            else if (!(e.Error == null))
            {
                tmrUpdate.Enabled = true;
            }
            else
            {
                pbBGWork.ProgressValue = 100;
                SetLblLastUpdateText("Last update: " + DateTime.Now.ToString("HH:mm:dd"));
                tmrUpdate.Enabled = true;
            }
        }

        public void CreateDashboards()
        {
            _dashboardList.Add(getDashboardIssues());
            _dashboardList.Add(getIssuesStatus(1));
            _dashboardList.Add(getIssuesStatus(9));
            _dashboardList.Add(getIssuesStatus(18));
            _dashboardList.Add(getIssuesStatus(22));
        }

        public IDashboardControlsUpdate getIssuesStatus(int statusId)
        {
            GetActivePreset();
            DashboardIssuesStatus dash = null;
            try
            {
                dash = Controls.Find(activePreset.Statuses.Find(s => s.ID == statusId).Name, true).FirstOrDefault() as DashboardIssuesStatus;
            }
            catch { }
            if (dash != null)
            {
                //return dash;
                dash.Dispose();
            }

            dash = new DashboardIssuesStatus
            {
                Parent = this.pnlDashboard,
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(41, 53, 65),
                Name = activePreset.Statuses.Find(s => s.ID == statusId)?.Name,
                StatusIdList = new int[] { statusId },
                HoursToOverdue = activePreset.Statuses.Find(s => s.ID == statusId) !=null ? activePreset.Statuses.Find(s => s.ID == statusId).MaxHours : 0,
                UserIdList = activePreset.Employees.Select(p => p.id).ToArray(),
                ProjectIdArray = activePreset.Projects.Select(p => p.id).ToArray()
            };
             
            return dash;
        }

        public IDashboardControlsUpdate getDashboardIssues()
        {
            GetActivePreset();
            DashboardIssues dash = Controls.Find("DashboardIssues", true).FirstOrDefault() as DashboardIssues;

            if (dash != null)
            {
                //return dash;
                dash.Dispose();
            }
            dash = new DashboardIssues
            {
                Parent = this.pnlDashboard,
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(41, 53, 65),
                Name = "DashboardIssues",
                UserIdList = activePreset.Employees.Select(p => p.id).ToArray(),
                StatusIdList = activePreset.Statuses.Select(p => p.ID).ToArray(),
            };
            return dash;
        }
        private void SetLblLastUpdateText(string message)
        {
            if (lblLastUpdate.InvokeRequired)
            {
                Message lblup = new Message(SetLblLastUpdateText);
                Invoke(lblup, new object[] { message });
            }
            else
            {
                lblLastUpdate.Text = message;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tmrUpdate.Enabled = false;
            if (bgWorker.IsBusy != true)
            {
                bgWorker.RunWorkerAsync();
            }
        }

        private void tmrSlideShow_Tick(object sender, EventArgs e)
        {
            if (_dashboardList.Count == 0)
            {
                _dashboardList.Clear();
                CreateDashboards();
            }            
            tmrSlideShow.Enabled = false;
            _dashboardList[SlideCounter % _dashboardList.Count].ControlUpdate();
            SlideCounter++;
            tmrSlideShow.Enabled = true;
        }

        private void btnSlideshow_CheckedChange(object sender, EventArgs e)
        {
            if (sender is CheckedButton chb)
            {
                if (chb.Check == true)
                    tmrSlideShow.Enabled = false;
                else
                {
                    tmrSlideShow.Enabled = true;
                    tmrSlideShow_Tick(tmrSlideShow, EventArgs.Empty);
                }
            }
        }

        private void btnSlideshow_Click(object sender, EventArgs e)
        {
            Toggle(sender);
        }

        private async Task CollectGarbageAsync()
        {
            await Task.Run(() =>
            {
                GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            });
        }
    }
}
