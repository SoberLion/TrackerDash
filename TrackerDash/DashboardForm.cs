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

namespace TrackerHelper
{
    public partial class Dashboard : Form
    {
        delegate void Message(string message);

        DashboardPreset activePreset { get; set; }

        private List<IDashboardControlsUpdate> _dashboardList = new List<IDashboardControlsUpdate>();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);

        public Dashboard()
        {
           InitializeComponent();
           GetActivePreset();
            /*   IntPtr ptr = CreateRoundRectRgn(0, 0, this.Width, this.Height, 25, 25); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
              this.Region = Region.FromHrgn(ptr);
              DeleteObject(ptr);

              IntPtr pnlptr = CreateRoundRectRgn(0, 0, pnlLogo.Width, pnlLogo.Height, 25, 25); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
              pnlLogo.Region = Region.FromHrgn(pnlptr);
              DeleteObject(pnlptr);*/

        }

        private void GetActivePreset()
        {
            activePreset = DBman.GetActivePreset();
            if (activePreset == null)
            {
                lblCaption.Text = "No active presets";
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
            DBman.CreateDatabase();
            timer.Enabled = true;
            timer.Interval = 300000/100;
            pbBGWork.ProgressValue = 100;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pbBGWork.ProgressValue -= 1;
            if (pbBGWork.ProgressValue == 0)
            {
                timer.Enabled = false;
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
            // dbController.UpdateUsers(3);
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbBGWork.ProgressValue = e.ProgressPercentage;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                timer.Enabled = true;
            }
            else if (!(e.Error == null))
            {
            }
            else
            {
                pbBGWork.ProgressValue = 100;
                SetLblLastUpdateText("Last update: " + DateTime.Now.ToString("HH:mm:dd"));
                timer.Enabled = true;
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
            DashboardIssuesStatus dash = Controls.Find(Name, true).FirstOrDefault() as DashboardIssuesStatus;
            if (dash != null)
            {
                //return dash;
                dash.Dispose();
            }

            if (activePreset.Statuses.Find(s => s.ID == statusId).MaxHours > 0)
            {
                dash = new DashboardIssuesStatus
                {
                    Parent = this.pnlDashboard,
                    Dock = DockStyle.Fill,
                    BackColor = Color.FromArgb(41, 53, 65),
                    Name = activePreset.Statuses.Find(s => s.ID == statusId).Name,
                    StatusIdList = new int[] { statusId },
                    HoursToOverdue = activePreset.Statuses.Find(s => s.ID == statusId).MaxHours,
                    UserIdList = activePreset.Employees.Select(p => p.id).ToArray(),
                    ProjectIdArray = activePreset.Projects.Select(p => p.id).ToArray()
                };
            }
            else lblCaption.Text = "SLA не указан для данного статуса.";
             
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
            timer.Enabled = false;
            if (bgWorker.IsBusy != true)
            {
                bgWorker.RunWorkerAsync();
            }
        }
    }
}
