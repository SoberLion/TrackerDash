﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;
using System.Text;
using LiveCharts;
using LiveCharts.Wpf;
using TrackerHelper.DB;


namespace TrackerHelper.Controls
{
    public partial class DashboardIssues : UserControl, IDashboardControlsUpdate
    {
        static string _dateFormat = "yyyy-MM-dd HH:mm:ss:fff";
        private int[] _userIdList = new int[] { 1 };
        private int[] _statusIdList = new int[] { 1 };

        public int[] UserIdList
        {
            get { return _userIdList; }
            set
            {
                if (value != null)
                    _userIdList = value;
            }
        }

        public int[] StatusIdList
        {
            get { return _statusIdList; }
            set
            {
                if (value != null)
                    _statusIdList = value;
            }
        }

        public DashboardIssues()
        {
            InitializeComponent();
            cartesianChart.DataTooltip.Background = Brushes.Gainsboro;
            cartesianChart.DataTooltip.IsEnabled = false;
            cartesianChart.DataTooltip.Visibility = System.Windows.Visibility.Hidden;
        }

        public void UpdateTSDashboard()
        {
            pnlSplash.Visible = true;
            CartesianChartStackedColumns();

            UpdateLblStatusValue(lblStatusNewValue, "1");
            UpdateLblStatusValue(lblStatusAssignedValue, "9");
            UpdateLblStatusValue(lblStatusNeedInfoEmplValue, "18");
            UpdateLblStatusValue(lblStatusEscalatedValue, "22");

            UpdateWeekLabels();
            UpdateMonthLabels();

            CreateUsersButtons();
            tmrSplash.Enabled = true;
        }

        private void CreateUsersButtons()
        {
            string UIDList = string.Join(",", UserIdList);
            pnlTopMid.Controls.Clear();
            pnlTopRight.Controls.Clear();
            
            string todayTimeQuery = $@"SELECT UserName, ROUND(sum(hours),2) AS Hours FROM TimeEntries WHERE userid IN ({UIDList}) 
                                    AND spenton LIKE '{DateTime.Now.ToString("yyyy-MM-dd")}%' 
                                    GROUP BY UserName
                                    ORDER BY UserName";

            string WeekTimeQuery = $@"SELECT UserName, ROUND(sum(hours),2) AS Hours FROM TimeEntries WHERE userid IN ({UIDList}) 
                                    AND spenton > '{getFirstDayofWeekDate(DateTime.Now).AddDays(-1).ToString("yyyy-MM-dd 23:59:59:000")}' 
                                    AND spenton < '{DateTime.Now.ToString("yyyy-MM-dd 23:59:59:000")}'
                                    GROUP BY userid
                                    ORDER BY UserName";

            string MonthTimeQuery = $@"SELECT UserName, ROUND(sum(hours),2) AS Hours FROM TimeEntries WHERE userid IN ({UIDList}) 
                                    AND spenton > '{DateTime.Now.ToString("yyyy-MM-01 00:00:00:001")}' 
                                    AND spenton < '{DateTime.Now.ToString("yyyy-MM-dd 23:59:59:000")}'
                                    GROUP BY UserName
                                    ORDER BY UserName";

            DataRow[] todayTimeRows = DBman.OpenQuery(todayTimeQuery).Select("");
            DataRow[] weekTimeRows = DBman.OpenQuery(WeekTimeQuery).Select("");
            DataRow[] monthTimeRows = DBman.OpenQuery(MonthTimeQuery).Select("");

            string query = $"SELECT DISTINCT Lastname, Firstname FROM Users WHERE Id IN ({UIDList}) ORDER BY Lastname desc";

            DataRow[] NameList = DBman.OpenQuery(query).Select("");
            for (int i = 0; i < NameList.Length; i++)
            {
                Label lblName = new Label
                {
                    Parent = pnlTopRight,
                    Text = NameList[i][0].ToString() + " " + NameList[i][1].ToString(),
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.Gainsboro,
                    AutoSize = false,
                    Dock = DockStyle.Top,
                    Height = 30
                };
                Panel pnlHours = new Panel
                {
                    Parent = pnlTopMid,
                    Dock = DockStyle.Top,
                    Height = 30
                };
                Label lblmonth = new Label
                {
                    Parent = pnlHours,
                    Text = "0.00",
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.Gainsboro,
                    AutoSize = false,
                    Width = 70,
                    Dock = DockStyle.Right
                };
                Label lblWeek = new Label
                {
                    Parent = pnlHours,
                    Text = "0.00",
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.Gainsboro,
                    AutoSize = false,
                    Width = 70,
                    Dock = DockStyle.Right
                };
                Label lblToday = new Label
                {
                    Parent = pnlHours,
                    Text = "0.00",
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.Gainsboro,
                    AutoSize = false,
                    Width = 70,
                    Dock = DockStyle.Right
                };

                for (int j = 0; j < todayTimeRows.Length; j++)
                {
                    if (todayTimeRows[j][0].ToString().Contains(NameList[i][0].ToString()))
                    {
                        lblToday.Text = todayTimeRows[j][1].ToString();
                    }
                }
                for (int j = 0; j < weekTimeRows.Length; j++)
                {
                    if (weekTimeRows[j][0].ToString().Contains(NameList[i][0].ToString()))
                    {
                        lblWeek.Text = weekTimeRows[j][1].ToString();
                    }
                }
                for (int j = 0; j < monthTimeRows.Length; j++)
                {
                    if (monthTimeRows[j][0].ToString().Contains(NameList[i][0].ToString()))
                    {
                        lblmonth.Text = monthTimeRows[j][1].ToString();
                    }
                }
            }
            Label lblNameHeader = new Label
            {
                Parent = pnlTopRight,
                Text = "ФИО",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Gainsboro,
                AutoSize = false,
                Dock = DockStyle.Top,
                Height = 30
            };
            Panel pnlHoursHeader = new Panel
            {
                Parent = pnlTopMid,
                Dock = DockStyle.Top,
                Height = 30
            };
            Label lblmonthHeader = new Label
            {
                Parent = pnlHoursHeader,
                Text = "Месяц",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Gainsboro,
                AutoSize = false,
                Width = 70,
                Dock = DockStyle.Right
            };
            Label lblWeekHeader = new Label
            {
                Parent = pnlHoursHeader,
                Text = "Неделя",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Gainsboro,
                AutoSize = false,
                Width = 70,
                Dock = DockStyle.Right
            };
            Label lblTodayHeader = new Label
            {
                Parent = pnlHoursHeader,
                Text = "День",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Gainsboro,
                AutoSize = false,
                Width = 70,
                Dock = DockStyle.Right
            };
        }

        public DateTime getFirstDayofWeekDate(DateTime Date)
        {
            while (Date.DayOfWeek != DayOfWeek.Monday)
                Date = Date.AddDays(-1);
            return Date;
        }

        private void CartesianChartStackedColumns()
        {

            string query = $@"SELECT COUNT(*) AS IssuesCount, StatusName, (u.Lastname || ' ' ||u.Firstname) AS Name
                            FROM issues i 
                            LEFT JOIN Users u ON i.AssignedToId = u.id
                            WHERE u.Id IN ({string.Join(",", UserIdList)}) 
                            AND i.statusId IN ({string.Join(",", StatusIdList)}) 
                            GROUP BY StatusName, Name 
                            ORDER BY Name, StatusName";

            DataRow[] dr = DBman.OpenQuery(query).Select("");

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
                        if (rowiterator < dr.Length - 1)
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
                Foreground = Brushes.Gainsboro,
                FontSize = 20
            };

            cartesianChart.AxisX.Clear();
            cartesianChart.AxisY.Clear();
            cartesianChart.Series.Clear();

            cartesianChart.Series = col;
            cartesianChart.AxisX.Add(ax);

            DefaultLegend dl = new DefaultLegend
            {
                Foreground = Brushes.Gainsboro,
                FontSize = 15
            };
            cartesianChart.DefaultLegend = dl;
            cartesianChart.LegendLocation = LegendLocation.Right;
        }

        public void UpdateLblStatusValue(object obj, string statusId)
        {
            string query = $"SELECT count(*) FROM Issues WHERE AssignedToId in ({string.Join(",", UserIdList)}) AND StatusId = {statusId}";
            DataTable dt = DBman.OpenQuery(query);
            (obj as Label).Text = dt.Rows[0][0].ToString() != "0" ? dt.Rows[0][0].ToString() : "";
        }

        #region  ------------------------------ Week / Month labels -------------------------------

        private void UpdateWeekLabels()
        {
            string UIDList = string.Join(",", UserIdList);
            string thisBegin = string.Empty;
            string thisEnd = string.Empty;
            string LastBegin = string.Empty;
            string LastEnd = string.Empty;

            lblWeekThisYearDates.Text = DateTime.Now.AddDays(-7).ToString("dd-MM-yyyy") + " --- " + DateTime.Now.ToString("dd-MM-yyyy");
            lblWeekLastYearDates.Text = DateTime.Now.AddYears(-1).AddDays(-7).ToString("dd-MM-yyyy") + " --- " + DateTime.Now.AddYears(-1).ToString("dd-MM-yyyy");

            thisBegin = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd 00:00:00,001");
            thisEnd = DateTime.Now.ToString(_dateFormat);

            LastBegin = DateTime.Now.AddYears(-1).AddDays(-7).ToString("yyyy-MM-dd 00:00:00,001");
            LastEnd = DateTime.Now.AddYears(-1).ToString(_dateFormat);

            string thisCreatedQuery = $"SELECT count(*) FROM Issues WHERE CreatedOn >= '{thisBegin}' AND CreatedOn < '{thisEnd}' AND AssignedToId in ({UIDList})";
            string LastCreatedQuery = $"SELECT count(*) FROM Issues WHERE CreatedOn >= '{LastBegin}' AND CreatedOn < '{LastEnd}' AND AssignedToId in ({UIDList})";
            string thisClosedQuery = $"SELECT count(*) FROM Issues WHERE ClosedOn >= '{thisBegin}' AND ClosedOn < '{thisEnd}' AND AssignedToId in ({UIDList})";
            string LastClosedQuery = $"SELECT count(*) FROM Issues WHERE ClosedOn >= '{LastBegin}' AND ClosedOn < '{LastEnd}' AND AssignedToId in ({UIDList})";

            UpdateLabel(lblCreatedWeekThisYearValue, thisCreatedQuery);
            UpdateLabel(lblClosedWeekThisYearValue, thisClosedQuery);
            UpdateLabel(lblCreatedWeekLastYearValue, LastCreatedQuery);
            UpdateLabel(lblClosedWeekLastYearValue, LastClosedQuery);
        }
        private void UpdateMonthLabels()
        {
            string UIDList = string.Join(",", UserIdList);
            string thisBegin = string.Empty;
            string thisEnd = string.Empty;
            string LastBegin = string.Empty;
            string LastEnd = string.Empty;

            lblMonthThisYearDates.Text = DateTime.Now.ToString("01-MM-yyyy") + " --- " + DateTime.Now.ToString("dd-MM-yyyy");
            lblMonthLastYearDates.Text = DateTime.Now.AddYears(-1).ToString("01-MM-yyyy") + " --- " + DateTime.Now.AddYears(-1).ToString("dd-MM-yyyy");

            thisBegin = DateTime.Now.ToString("yyyy-MM-01 00:00:00,001");
            thisEnd = DateTime.Now.ToString(_dateFormat);

            LastBegin = DateTime.Now.AddYears(-1).ToString("yyyy-MM-01 00:00:00,001");
            LastEnd = DateTime.Now.AddYears(-1).ToString(_dateFormat);

            string thisCreatedQuery = $"SELECT count(*) FROM Issues WHERE CreatedOn >= '{thisBegin}' AND CreatedOn < '{thisEnd}' AND AssignedToId in ({UIDList})";
            string LastCreatedQuery = $"SELECT count(*) FROM Issues WHERE CreatedOn >= '{LastBegin}' AND CreatedOn < '{LastEnd}' AND AssignedToId in ({UIDList})";
            string thisClosedQuery = $"SELECT count(*) FROM Issues WHERE ClosedOn >= '{thisBegin}' AND ClosedOn < '{thisEnd}' AND AssignedToId in ({UIDList})";
            string LastClosedQuery = $"SELECT count(*) FROM Issues WHERE ClosedOn >= '{LastBegin}' AND ClosedOn < '{LastEnd}' AND AssignedToId in ({UIDList})";

            UpdateLabel(lblCreatedMonthThisYearValue, thisCreatedQuery);
            UpdateLabel(lblClosedMonthThisYearValue, thisClosedQuery);
            UpdateLabel(lblCreatedMonthLastYearValue, LastCreatedQuery);
            UpdateLabel(lblClosedMonthLastYearValue, LastClosedQuery);

        }

        private void UpdateLabel(object label, string query)
        {
            if (label is Label lbl)
            {
                lbl.Text = DBman.OpenQuery(query)?.Rows[0][0].ToString();
            }
        }

        #endregion 

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
