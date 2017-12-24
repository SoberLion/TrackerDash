using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;
using TrackerHelper.DB;
using System.Text;
using System.Threading;

namespace TrackerHelper.Controls
{
    public partial class DashboardIssues : UserControl, IDashboardControlsUpdate
    {
        /*static string cartesianAssigned = @"";
        static string cartesianNew = @"";
        static string cartesianStacked = @"";*/


        static string _dateFormat = "yyyy-MM-dd HH:mm:ss:fff";
        private string _userIdList = "2361,2374,1830,2233,1240,1383,2886,2235,1521,2232,1537,2535,551,894,3713,328,751,2270";
        private string _statusIdList = "3,5,6,19,26,27,29,30";

        public string UserIdList
        {
            get { return _userIdList; }
            set { _userIdList = value; }
        }

        public string StatusIdList
        {
            get { return _statusIdList; }
            set { _statusIdList = value; }
        }

        public DashboardIssues()
        {
            InitializeComponent();
            cartesianChart.DataTooltip.Background = Brushes.Gainsboro;
            pieChartProjects.DataTooltip.Background = Brushes.Gainsboro;
            pieChartStatus.DataTooltip.Background = Brushes.Gainsboro;
            pieChartCategory.DataTooltip.Background = Brushes.Gainsboro;

        }

        private void TSDashboard_Load(object sender, EventArgs e)
        {
            // Thread UpdateThread = new Thread(new ThreadStart(UpdateTSDashboard));
            //UpdateThread.Start(); // запускаем поток


        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            UpdateTSDashboard();
        }

        public void UpdateTSDashboard()
        {
            UpdatePieChartProjects(UserIdList);
            UpdatePieChartStatus(UserIdList);
            UpdatePieChartCategory(UserIdList);
            CartesianChartStackedColumns(UserIdList);

            FilterBtnClick(btnWeek, EventArgs.Empty);

            UpdateLblStatusValue(lblStatusNewValue, "1", UserIdList);
            UpdateLblStatusValue(lblStatusAssignedValue, "9", UserIdList);
            UpdateLblStatusValue(lblStatusNeedInfoEmplValue, "18", UserIdList);
            UpdateLblStatusValue(lblStatusEscalatedValue, "22", UserIdList);


            CheckStatusOverdue(lblStatusNewOverduedValue,pnlStatusNew, 10, 18, 5, "1", UserIdList);
            CheckStatusOverdue(lblStatusAssignedOverduedValue, pnlStatusAssigned, 10, 18, 72, "9", UserIdList);
            CheckStatusOverdue(lblStatusNeedInfoEmplOverduedValue, pnlStatusNeedInfoEmpl, 10, 18, 8, "18", UserIdList);
            CheckStatusOverdue(lblStatusEscalatedOverduedValue, pnlStatusEscalated, 10, 18, 1, "22", UserIdList);

            CreateUsersButtons();
            tmrSplash.Enabled = true;
        }

        private void CreateUsersButtons()
        {
            if (pnlTopRight.Controls.Count > 0)
                return;

            string todayTimeQuery = $@"SELECT UserId, ROUND(sum(hours),2) AS Hours FROM TimeEntries WHERE userid IN ({UserIdList}) 
                                    AND spenton LIKE '{DateTime.Now.ToString("yyyy-MM-dd")}%' GROUP BY userid";

            DataTable TimeTable = DBman.OpenQuery(todayTimeQuery);

            string query = $"SELECT DISTINCT AssignedToName, AssignedToId FROM Issues WHERE AssignedToId IN ({UserIdList}) ORDER BY AssignedToName desc";

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            for(int i = 0; i < dr.Length; i++)
            {
                string s = TimeTable.Select($"UserId={dr[i][1].ToString()}").Length > 0 ? TimeTable.Select($"UserId={dr[i][1].ToString()}")[0][1].ToString() : "0,00";
                CheckedButton btn = new CheckedButton
                {                    
                    Name = "btn" + dr[i][0].ToString(),
                    Parent = pnlTopRight,
                    Text = dr[i][0].ToString() + $" ({s})",
                    Tag = dr[i][1],
                    Dock = DockStyle.Top,
                    Height = 30,
                    ForeColor = System.Drawing.Color.FromArgb(86, 88, 86),
                    FlatStyle = FlatStyle.Flat,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold),
                    TextAlign = System.Drawing.ContentAlignment.MiddleRight
                };

                btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(65, 184, 92);
                btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(21, 33, 45);
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += btnUsers_Click;
                btn.CheckedChange += btnUsersCheckedChange;
            }
            CheckedButton AllUsers = new CheckedButton
            {
                Name = "btnAllUsers",
                Parent = pnlTopRight,
                Text = "Все",
                Tag = UserIdList,
                Dock = DockStyle.Top,
                Height = 30,
                ForeColor = System.Drawing.Color.FromArgb(86, 88, 86),
                FlatStyle = FlatStyle.Flat,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold),
                TextAlign = System.Drawing.ContentAlignment.MiddleRight
            };
            AllUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(65, 184, 92);
            AllUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(21,33,45);
            AllUsers.FlatAppearance.BorderSize = 0;
            AllUsers.Click += btnUsers_Click;
            AllUsers.CheckedChange += btnUsersCheckedChange;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (sender is CheckedButton cb)
            {
                BtnUsersToggle(sender);
                string id = cb.Tag.ToString();

                UpdatePieChartProjects(id);
                UpdatePieChartStatus(id);
                UpdateLblStatusValue(lblStatusNewValue, "1", id);
                UpdateLblStatusValue(lblStatusAssignedValue, "9", id);
                UpdateLblStatusValue(lblStatusNeedInfoEmplValue, "18", id);
                UpdateLblStatusValue(lblStatusEscalatedValue, "22", id);

                CheckStatusOverdue(lblStatusNewOverduedValue, pnlStatusNew, 10, 18, 5, "1", id);
                CheckStatusOverdue(lblStatusAssignedOverduedValue, pnlStatusAssigned, 10, 18, 72, "9", id);
                CheckStatusOverdue(lblStatusNeedInfoEmplOverduedValue, pnlStatusNeedInfoEmpl, 10, 18, 8, "18", id);
                CheckStatusOverdue(lblStatusEscalatedOverduedValue, pnlStatusEscalated, 10, 18, 1, "22", id);

                string query = $@"SELECT count (*) as StatusCount, StatusName FROM Issues WHERE AssignedToId IN ({id}) 
                            AND statusId NOT IN ({StatusIdList}) GROUP BY StatusName ORDER BY StatusCount DESC";
                CartesianChartColumns(query);
            }            
        }

        private void UpdatePieChartProjects(string userIdList)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            string query = $@"SELECT count (*) AS IssuesCount, projectName FROM Issues WHERE AssignedToId IN ({userIdList}) 
                            AND statusId NOT IN ({StatusIdList}) GROUP BY ProjectName ORDER BY IssuesCount DESC";
            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            SeriesCollection col = new SeriesCollection();
            List<string> ls = dr.Select(p => p[0].ToString()).ToList();

            int sum = ls.Sum(p => Convert.ToInt32(p));
            int otherIssuesSum = 0;
            int otherCounter = 0;
            for (int i = 0; i < dr.Length; i++)
            {
                if (Convert.ToInt32(dr[i][0]) < (sum / 100))
                {
                    otherIssuesSum += Convert.ToInt32(dr[i][0]);
                    otherCounter++;
                    continue;
                }
                PieSeries columnSeries = new PieSeries
                {
                    Title = dr[i][1].ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(dr[i][0]) },
                    LabelPoint = point => point.Y.ToString(),
                    DataLabels = true,
                };
                col.Add(columnSeries);
            }
            PieSeries otherSeries = new PieSeries
            {
                Title = "Другие проекты < 1%: " + otherCounter.ToString(),
                Values = new ChartValues<int> { otherIssuesSum },
                LabelPoint = point => point.Y.ToString(),
                DataLabels = true,
            };
            col.Add(otherSeries);

            pieChartProjects.Series = col;
        }

        private void PieChartOtherProjects(string userIdList)
        {
            string query = $@"SELECT * 
                            FROM (SELECT count (*) AS IssuesCount, projectName
                                FROM Issues
                                WHERE AssignedToId IN ({userIdList}) AND statusId NOT IN ({_statusIdList})
                                GROUP BY issues.ProjectName) GroupedIssues
                            WHERE GroupedIssues.IssuesCount < 
                                (SELECT Count(*) FROM Issues WHERE AssignedToId IN ({userIdList}) AND statusId NOT IN ({StatusIdList})) / 100 
                            ORDER BY IssuesCount DESC";

            DataTable dt = DBman.OpenQuery(query);

            SeriesCollection col = new SeriesCollection();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PieSeries columnSeries = new PieSeries
                {
                    Title = dt.Rows[i][1].ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(dt.Rows[i][0]) },
                    LabelPoint = point => point.Y.ToString(),
                    DataLabels = true,
                };
                col.Add(columnSeries);
            }

            pieChartProjects.Series = col;
        }

        private void UpdatePieChartStatus(string userIdList)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataTable dt = DBman.OpenQuery($@"SELECT count (*) as IssuesCount, StatusName FROM issues WHERE AssignedToId in 
                                           ({userIdList}) AND statusId NOT IN ({StatusIdList}) GROUP BY StatusName ORDER BY IssuesCount desc");
            DataRow[] dr = dt.Select("");
            SeriesCollection col = new SeriesCollection();
            List<string> ls = dr.Select(p => p[0].ToString()).ToList();

            int sum = ls.Sum(p => Convert.ToInt32(p));
            int otherIssuesSum = 0;
            int otherCounter = 0;
            for (int i = 0; i < dr.Length; i++)
            {
                if (Convert.ToInt32(dr[i][0]) < (sum / 100))
                {
                    otherIssuesSum += Convert.ToInt32(dr[i][0]);
                    otherCounter++;
                    continue;
                }
                PieSeries columnSeries = new PieSeries
                {
                    Title = dr[i][1].ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(dr[i][0]) },
                    LabelPoint = point => point.Y.ToString(),
                    DataLabels = true,
                };
                col.Add(columnSeries);
            }

            PieSeries otherSeries = new PieSeries
            {
                Title = "Другие статусы < 1%: " + otherCounter.ToString(),
                Values = new ChartValues<int> { otherIssuesSum },
                LabelPoint = point => point.Y.ToString(),
                DataLabels = true,
            };
            col.Add(otherSeries);

            pieChartStatus.Series = col;
        }

        private void UpdatePieChartCategory(string userIdList)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataTable dt = DBman.OpenQuery($@"SELECT count (*) as IssuesCount, CategoryName FROM issues WHERE AssignedToId in 
                                           ({userIdList}) AND statusId NOT IN ({StatusIdList}) GROUP BY CategoryName ORDER BY IssuesCount desc");
            DataRow[] dr = dt.Select("");
            SeriesCollection col = new SeriesCollection();
            List<string> ls = dr.Select(p => p[0].ToString()).ToList();

            int sum = ls.Sum(p => Convert.ToInt32(p));
            int otherIssuesSum = 0;
            int otherCounter = 0;
            for (int i = 0; i < dr.Length; i++)
            {
                if (Convert.ToInt32(dr[i][0]) < (sum / 100))
                {
                    otherIssuesSum += Convert.ToInt32(dr[i][0]);
                    otherCounter++;
                    continue;
                }
                PieSeries columnSeries = new PieSeries
                {
                    Title = dr[i][1].ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(dr[i][0]) },
                    LabelPoint = point => point.Y.ToString(),
                    DataLabels = true,
                };
                col.Add(columnSeries);
            }

            PieSeries otherSeries = new PieSeries
            {
                Title = "Другие категории < 1%: " + otherCounter.ToString(),
                Values = new ChartValues<int> { otherIssuesSum },
                LabelPoint = point => point.Y.ToString(),
                DataLabels = true,
            };
            col.Add(otherSeries);

            pieChartCategory.Series = col;
        }

        private void CartesianChartStackedColumns(string userIdList)
        {
            string query = $@"select count (*) as IssuesCount, StatusName, AssignedToName from issues where AssignedToId in ({userIdList}) and 
                            statusId not in ({StatusIdList}) group by StatusName, AssignedToName order by AssignedToName, StatusName";
            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");

            SeriesCollection col = new SeriesCollection();

            List<int> ListIssuesCount = dr.Select(p => Convert.ToInt32(p[0])).ToList();
            List<string> ListStatusName = dr.Select(p => p[1].ToString()).Distinct().ToList();
            List<string> AssignedToNameList = dr.Select(p => p[2].ToString().Split(' ')[0]).Distinct().ToList();
            ListStatusName.Sort();

            foreach (var item in ListStatusName)
            {
                StackedColumnSeries columnSeries = new StackedColumnSeries
                {
                    Title = item,
                    Values = new ChartValues<int>(),
                    LabelPoint = point => point.Y.ToString(),
                    DataLabels = true,
                };
                col.Add(columnSeries);
            }
            int rowiterator = 0;
            foreach (string Name in AssignedToNameList)
            {
                for (int i = 0; i < col.Count; i++)
                {
                    if (col[i].Title == dr[rowiterator][1].ToString())
                    {
                        col[i].Values.Add(Convert.ToInt32(dr[rowiterator][0]));
                        if (rowiterator < dr.Length -1)
                        {
                            rowiterator++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        col[i].Values.Add(0);
                    }
                }
            }

            Axis ax = new Axis
            {
                Separator = new Separator { Step = 1, IsEnabled = false },
                Labels = AssignedToNameList,
                LabelsRotation = 70,
                Foreground = Brushes.Gainsboro
            };

            cartesianChart.AxisX.Clear();
            cartesianChart.AxisY.Clear();

            cartesianChart.Series = col;
            cartesianChart.AxisX.Add(ax);
        }

        private void CartesianChartColumns(string query)
        {
           // string query = $@"SELECT count (*) as StatusCount, StatusName FROM Issues WHERE AssignedToId IN ({userIdList}) 
            //                AND statusId NOT IN ({StatusIdList}) GROUP BY StatusName ORDER BY StatusCount DESC";
            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");

            SeriesCollection col = new SeriesCollection();            

            Axis ay = new Axis { LabelFormatter = value => value.ToString(), Separator = new Separator(), MinValue = 0 };

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ColumnSeries columnSeries = new ColumnSeries
                {
                    Title = dt.Rows[i][1].ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(dt.Rows[i][0]) },
                    LabelPoint = point => point.Y.ToString(),
                    DataLabels = true,
                    Foreground = Brushes.Gainsboro
                };
                col.Add(columnSeries);
            }

            cartesianChart.AxisX.Clear();
            cartesianChart.AxisY.Clear();

            cartesianChart.Series = col;
            cartesianChart.AxisY.Add(ay);


         //   cartesianChart.DataTooltip. .SelectionMode = LiveCharts.TooltipSelectionMode.OnlySender;

        }

        /// <param name="label">Ссылка на Label</param>
        /// <param name="panel">Ссылка на Panel у которой будет заполняться Tag</param>
        /// <param name="hoursFrom">Время начала рабочего дня</param>
        /// <param name="hoursTo">Время конца рабочего дня</param>
        /// <param name="hoursToOverdue">Часы до превышения лимита</param>
        /// <param name="statusId">Id статуса</param>
        public void CheckStatusOverdue(Label label, Panel panel, int hoursFrom, int hoursTo, int hoursToOverdue, string statusId, string UserId)
        {
            string overdue;            

            overdue = DateTime.Now.AddHours(-GetHours(hoursFrom, hoursTo, hoursToOverdue)).ToString(_dateFormat);

            string query = $@"SELECT count(*) from issues WHERE statusid = {statusId} AND createdOn < '{overdue}' 
                            AND AssignedToId in ({UserId}) and projectId in (26, 220)";

            DataTable dt = DBman.OpenQuery(query);

            (label as Label).Text = dt.Rows[0][0].ToString() != "0" ? dt.Rows[0][0].ToString() : string.Empty;

            (panel as Panel).Tag = overdue + ";" + statusId + ";" + UserId;
        }

        public int GetHours(int hoursFrom, int hoursTo, int hoursToOverdue)
        {
            int hours = hoursToOverdue;
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && (DateTime.Now.Hour - hours) < hoursFrom)
            {
                hours = 24 * 3 - hoursTo + hoursFrom + hours;
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                hours = 24 * 2 - hoursTo + hoursFrom + hours;
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                hours = 24 - hoursTo + hoursFrom + hours;
            }
            if ((DateTime.Now.DayOfWeek == DayOfWeek.Tuesday ||
               DateTime.Now.DayOfWeek == DayOfWeek.Wednesday ||
               DateTime.Now.DayOfWeek == DayOfWeek.Thursday ||
               DateTime.Now.DayOfWeek == DayOfWeek.Friday) && ((DateTime.Now.Hour - hours) < hoursFrom))
            {
                hours = 24 - hoursTo + hoursFrom + hours;
            }
            return hours;
        }

        public void UpdateLblStatusValue(object obj, string statusId, string userIdList)
        {
            string query = $"SELECT count(*) FROM Issues WHERE AssignedToId in ({userIdList}) AND StatusId = {statusId}";
            DataTable dt = DBman.OpenQuery(query);
            (obj as Label).Text = dt.Rows[0][0].ToString() != "0" ? dt.Rows[0][0].ToString() : "";
        }

        #region  ------------------------------ Week / Month labels -------------------------------

        enum Filter
        {
            Week,
            Month
        }

        private void UpdateWeekMonthLabels(Filter filter)
        {
            string thisBegin = string.Empty;
            string thisEnd = string.Empty;
            string LastBegin = string.Empty;
            string LastEnd = string.Empty;


            if (filter == Filter.Week)
            {
                lblThisYearDates.Text = DateTime.Now.AddDays(-7).ToString("dd-MM-yyyy") + " --- " + DateTime.Now.ToString("dd-MM-yyyy");
                lblLastYearDates.Text = DateTime.Now.AddYears(-1).AddDays(-7).ToString("dd-MM-yyyy") + " --- " + DateTime.Now.AddYears(-1).ToString("dd-MM-yyyy");

                thisBegin = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd 00:00:00,001");
                thisEnd = DateTime.Now.ToString(_dateFormat);

                LastBegin = DateTime.Now.AddYears(-1).AddDays(-7).ToString("yyyy-MM-dd 00:00:00,001");
                LastEnd = DateTime.Now.AddYears(-1).ToString(_dateFormat);
            }
            if (filter == Filter.Month)
            {
                lblThisYearDates.Text = DateTime.Now.ToString("01-MM-yyyy") + " --- " + DateTime.Now.ToString("dd-MM-yyyy");
                lblLastYearDates.Text = DateTime.Now.AddYears(-1).ToString("01-MM-yyyy") + " --- " + DateTime.Now.AddYears(-1).ToString("dd-MM-yyyy");

                thisBegin = DateTime.Now.ToString("yyyy-MM-01 00:00:00,001");
                thisEnd = DateTime.Now.ToString(_dateFormat);

                LastBegin = DateTime.Now.AddYears(-1).ToString("yyyy-MM-01 00:00:00,001");
                LastEnd = DateTime.Now.AddYears(-1).ToString(_dateFormat);
            }
           
            string thisCreatedQuery = $"SELECT count(*) FROM Issues WHERE CreatedOn >= '{thisBegin}' AND CreatedOn < '{thisEnd}' AND AssignedToId in ({UserIdList})";
            string LastCreatedQuery = $"SELECT count(*) FROM Issues WHERE CreatedOn >= '{LastBegin}' AND CreatedOn < '{LastEnd}' AND AssignedToId in ({UserIdList})";
            string thisClosedQuery = $"SELECT count(*) FROM Issues WHERE ClosedOn >= '{thisBegin}' AND ClosedOn < '{thisEnd}' AND AssignedToId in ({UserIdList})";
            string LastClosedQuery = $"SELECT count(*) FROM Issues WHERE ClosedOn >= '{LastBegin}' AND ClosedOn < '{LastEnd}' AND AssignedToId in ({UserIdList})";


            UpdateLabel(lblCreatedThisYearValue, thisCreatedQuery);
            UpdateLabel(lblClosedThisYearValue, thisClosedQuery);
            UpdateLabel(lblCreatedLastYearValue, LastCreatedQuery);
            UpdateLabel(lblClosedLastYearValue, LastClosedQuery);

        }
        private void UpdateLabel(object label, string query)
        {
            if (label is Label lbl)
            {
                DataTable dt = DBman.OpenQuery(query);
                lbl.Text = dt?.Rows[0][0].ToString();
            }
        }

        private void FilterBtnClick(object sender, EventArgs e)
        {
            if (sender is CheckedButton cb)
            {
                if (cb.Name == "btnWeek")
                    UpdateWeekMonthLabels(Filter.Week);
                else if(cb.Name == "btnMonth")
                    UpdateWeekMonthLabels(Filter.Month);
                BtnFiltersToggle(sender);
            }
        }

        #endregion 

        private void pieChartProjects_DataClick(object sender, ChartPoint chartPoint)
        {
            PieChartOtherProjects(UserIdList);
          //  string query = $@"SELECT count (*) as ProjectCount, ProjectName FROM Issues WHERE AssignedToId IN ({UserIdList}) 
                          //  AND statusId NOT IN ({StatusIdList}) GROUP BY ProjectName ORDER BY ProjectCount";
           // CartesianChartColumns(query);
            /*
            var chart = (LiveCharts.Wpf.PieChart)chartPoint.ChartView;
            var selectedSeries = (PieSeries)chartPoint.SeriesView;  
            var chart = (LiveCharts.WinForms.PieChart)chartPoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartPoint.SeriesView;
            selectedSeries.PushOut = 8;*/
        }

        private void BtnUsersToggle(object sender)
        {
            foreach (var item in pnlTopRight.Controls)
            {
                if (item is CheckedButton cb)
                {
                    cb.Check = false;
                }
            }

            (sender as CheckedButton).Check = true;
        }

        private void btnUsersCheckedChange(object sender, EventArgs e)
        {
            if(sender is CheckedButton cb)
                cb.BackColor = cb.Check == false ? System.Drawing.Color.FromArgb(21, 33, 45) : System.Drawing.Color.FromArgb(41, 53, 65);
        }

        private void BtnFiltersToggle(object sender)
        {
            btnWeek.Check = false;
            btnWeek.BackColor = System.Drawing.Color.FromArgb(41, 53, 65);
            btnMonth.Check = false;
            btnMonth.BackColor = System.Drawing.Color.FromArgb(41, 53, 65);

            (sender as CheckedButton).Check = true;
            (sender as CheckedButton).BackColor = System.Drawing.Color.FromArgb(21, 33, 45);
        }

        private void pnlStatusNew_Click(object sender, EventArgs e)
        {
            StatusPanelClick(sender);
        }

        private void StatusPanelClick(object sender)
        {           
            string[] overdue = (sender as Panel).Tag?.ToString().Split(';');
            if (overdue == null || overdue.Length < 2)
                return;

            string query = $@"SELECT IssueId, AssignedToName from issues WHERE statusid = {overdue[1]} AND createdOn < '{overdue[0]}' 
                            AND AssignedToId in ({overdue[2]}) and projectId in (26, 220)";

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            StringBuilder sb = new StringBuilder();
            foreach (var item in dr)
            {
                sb.AppendLine($"{item[0].ToString()}: {item[1].ToString()}");
            }
            if(sb.Length > 0)
                MessageBox.Show(sb.ToString());
        }

        private void pnlStatusAssigned_Click(object sender, EventArgs e)
        {
            StatusPanelClick(sender);
        }

        private void pnlStatusNeedInfoEmpl_Click(object sender, EventArgs e)
        {
            StatusPanelClick(sender);
        }

        private void pnlStatusEscalated_Click(object sender, EventArgs e)
        {
            StatusPanelClick(sender);
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            tmrSplash.Enabled = false;
            pnlSplash.Visible = false;
        }

        public void ControlUpdate()
        {
            UpdateTSDashboard();
            BringToFront();
        }
    }
}
