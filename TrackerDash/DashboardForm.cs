﻿using System;
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
using Microsoft.Win32;
using TrackerHelper.DB;
using System.Runtime;


namespace TrackerHelper
{
    public partial class Dashboard : Form
    {
        delegate void Message(string message);

        private int _updateCounter = 0;
        private int _slideCounter = 0;

        DashboardPreset _activePreset { get; set; }

        public DashboardPreset ActivePreset
        {
            get { return _activePreset; }
            set { _activePreset = value; }
        }

        public int SlideCounter
        {
            get { return _slideCounter; }
            set { _slideCounter = value; }
        }

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
        }

        private void Get45or451FromRegistry()
        {
            int releaseKey = 0;
            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full\\"))
            {
                releaseKey = Convert.ToInt32(ndpKey.GetValue("Release"));
            }
            if ((releaseKey < 378675))
            {
                MessageBox.Show(".NET Framework lower than 4.5.1");
                Close();
            }
        }

        private static bool CheckFor45DotVersion(int releaseKey)
        {
            /*if (releaseKey >= 393273)
            {
                return "4.6 RC or later";
            }
            if ((releaseKey >= 379893))
            {
                return "4.5.2 or later";
            }
            if ((releaseKey >= 378675))
            {
                return "4.5.1 or later";
            }
            if ((releaseKey >= 378389))
            {
                return "4.5 or later";
            }*/

            if ((releaseKey < 378675))
            {
                MessageBox.Show(".NET Framework lower than 4.5.1");
                return false;
            }
            return true;
            }

        private void GetActivePreset()
        {
            ActivePreset = DBman.GetActivePreset();
            if (ActivePreset == null)
            {
                lblCaption.Text = "No active presets";
                ActivePreset = new DashboardPreset();
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

        private void timer_Tick(object sender, EventArgs e)
        {
            pbBGWork.ProgressValue -= 1;
            if (pbBGWork.ProgressValue == 0)
            {                
                if (bgWorker.IsBusy != true)
                {
                    tmrUpdate.Enabled = false;
                    bgWorker.RunWorkerAsync();
                }
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
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

            dbController.UpdateIssues(3, ActivePreset.UpdateDays);
            dbController.UpdateTimeEntries(3, ActivePreset.UpdateDays);

            if (_updateCounter % 20 == 0)
                dbController.UpdateUsers(3);
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) =>
            pbBGWork.ProgressValue = e.ProgressPercentage;


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
                _updateCounter++;
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
                dash = Controls.Find(ActivePreset.Statuses.Find(s => s.ID == statusId).Name, true).FirstOrDefault() as DashboardIssuesStatus;
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
                Name = ActivePreset.Statuses.Find(s => s.ID == statusId)?.Name,
                StatusIdList = new int[] { statusId },
                HoursToOverdue = ActivePreset.Statuses.Find(s => s.ID == statusId) !=null ? ActivePreset.Statuses.Find(s => s.ID == statusId).MaxHours : 0,
                UserIdList = ActivePreset.Employees.Select(p => p.id).ToArray(),
                ProjectIdArray = ActivePreset.Projects.Select(p => p.id).ToArray()
            };
            dash.onEmpty += getNextDashboard;

            return dash;
        }

        private void getNextDashboard()
        {
            SlideCounter++;
            tmrSlideShow_Tick(tmrSlideShow, EventArgs.Empty);
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
                UserIdList = ActivePreset.Employees.Select(p => p.id).ToArray(),
                StatusIdList = ActivePreset.Statuses.Select(p => p.ID).ToArray()
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
            if (bgWorker.IsBusy != true)
            {
                tmrUpdate.Enabled = false;
                GetActivePreset();
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
            GetActivePreset();
            SlideCounter = 0;
            _dashboardList.Clear();
            Toggle(sender);
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            Get45or451FromRegistry();
            DBman.CreateDatabase();
            GetActivePreset();

            tmrUpdate.Enabled = true;
            tmrUpdate.Interval = 3000;
            pbBGWork.ProgressValue = 100;

            btnSlideshow_Click(btnSlideshow, EventArgs.Empty);
        }

        /* private async Task CollectGarbageAsync()
         {
             await Task.Run(() =>
             {
                 GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
                 GC.Collect();
                 GC.WaitForPendingFinalizers();
             });
         }*/
    }
}
