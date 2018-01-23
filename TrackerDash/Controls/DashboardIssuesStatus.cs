using System;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TrackerHelper.DB;

namespace TrackerHelper.Controls
{
    public partial class DashboardIssuesStatus : UserControl, IDashboardControlsUpdate
    {
        static string _dateFormat = "yyyy-MM-dd HH:mm:ss:fff";
        private int[] _userIdArray = new int[] { 1 };
        private int[] _statusIdArray = new int[] { 1 };
        private int[] _projectIdArray = new int[] { 1 };
        private int _hoursToOverdue = 0;

        public int[] UserIdList
        {
            get { return _userIdArray; }
            set
            {
                if (value != null)
                    _userIdArray = value;
            }
        }

        public int[] StatusIdList
        {
            get { return _statusIdArray; }
            set
            {
                if (value != null)
                    _statusIdArray = value;
            }
        }

        public int[] ProjectIdArray
        {
            get { return _projectIdArray; }
            set { _projectIdArray = value; }
        }

        public int HoursToOverdue
        {
            get { return _hoursToOverdue; }
            set { _hoursToOverdue = value; }
        }

        public DashboardIssuesStatus()
        {
            InitializeComponent();
        }
        
        public void GetDataTable()
        {

            dgvIssuesStatus.DataSource = CheckStatusOverdue(10, 20, HoursToOverdue);

            dgvIssuesStatus.ClearSelection();
            dgvIssuesStatus.BackgroundColor = Color.FromArgb(43, 51, 65);

            dgvIssuesStatus.AllowUserToOrderColumns = true;
            dgvIssuesStatus.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvIssuesStatus.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvIssuesStatus.AllowUserToResizeColumns = false;
            dgvIssuesStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIssuesStatus.AllowUserToResizeRows = false;
            dgvIssuesStatus.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dgvIssuesStatus.DefaultCellStyle.SelectionBackColor = Color.Transparent;

            // dgvIssuesStatus.RowsDefaultCellStyle.BackColor = Color.FromArgb(43, 51, 65);
            dgvIssuesStatus.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;//.FromArgb(23, 31, 45);

            //  dgvIssuesStatus.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //   dgvIssuesStatus.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(43, 51, 65);
            //    dgvIssuesStatus.RowHeadersDefaultCellStyle.BackColor = Color.Black;

            // dgvIssuesStatus.ForeColor = Color.Gainsboro;

            dgvIssuesStatus.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvIssuesStatus.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvIssuesStatus.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvIssuesStatus.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvIssuesStatus.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            using (Font font = new Font(dgvIssuesStatus.DefaultCellStyle.Font.FontFamily, 14, FontStyle.Bold))
            {
                dgvIssuesStatus.Columns[1].DefaultCellStyle.Font = font;
                dgvIssuesStatus.Columns[2].DefaultCellStyle.Font = font;
                dgvIssuesStatus.Columns[3].DefaultCellStyle.Font = font;

                dgvIssuesStatus.ColumnHeadersDefaultCellStyle.Font = font;
            }
            using (Font font = new Font(dgvIssuesStatus.DefaultCellStyle.Font.FontFamily, 18, FontStyle.Bold))
            {
                dgvIssuesStatus.Columns[0].DefaultCellStyle.Font = font;
                dgvIssuesStatus.Columns[0].DefaultCellStyle.ForeColor = Color.Red;
            }
            pnlSplash.Visible = false;

        }


        /// <param name="hoursFrom">Время начала рабочего дня</param>
        /// <param name="hoursTo">Время конца рабочего дня</param>
        /// <param name="hoursToOverdue">Часы до превышения лимита</param>
        public DataTable CheckStatusOverdue(int hoursFrom, int hoursTo, int hoursToOverdue)
        {
            string overdue;

            overdue = DateTime.Now.AddHours(-GetHours(hoursFrom, hoursTo, hoursToOverdue)).ToString(_dateFormat);

            string query;
            if (StatusIdList[0] != 1)
            {
                query = $@"SELECT i.issueid AS '№'
                          , i.StatusName AS 'Статус'
                          ,(u.Lastname || ' ' || u.FirstName) AS 'Назначена'
                          , i.Subject AS 'Тема'
                          FROM Issues i
                          LEFT JOIN Users u ON i.AssignedToId = u.Id
                          WHERE issueId IN
	                          (SELECT IssueId FROM Journals WHERE CreatedOn < '{overdue}' AND id IN
		                          (SELECT JournalId FROM JournalDetails WHERE newValue IN ({string.Join(",", StatusIdList)})))
                          AND i.StatusId IN ({string.Join(",", StatusIdList)})
                          AND i.AssignedToId IN ({string.Join(",", UserIdList)})
                          AND i.ProjectId IN ({string.Join(",", ProjectIdArray)})
                          GROUP BY i.AssignedToName, i.IssueId
                          ORDER BY u.Lastname";
            }
            else
            {
                query = $@"SELECT i.issueid AS '№'
                          , strftime('%Y-%m-%d %H:%M', i.CreatedOn) AS 'Создан'
                          , (u.Lastname || ' ' || u.FirstName) AS 'Назначена'
                          , i.Subject AS 'Тема'
                            FROM Issues i 
                            LEFT JOIN Users u ON i.AssignedToId = u.Id
                            WHERE i.CreatedOn < '{overdue}'
                            AND i.StatusId IN ({string.Join(",", StatusIdList)})
                            AND i.AssignedToId IN ({string.Join(",", UserIdList)})
                            AND i.ProjectId IN ({string.Join(",", ProjectIdArray)})
                            ORDER BY u.Lastname";
            }

            // joins way too long  :(
            /* 
             SELECT iss.issueid as 'Номер задачи'
                            , strftime('%Y-%m-%d %H:%M',iss.CreatedOn) as 'Создан'
                            , iss.AssignedToName as 'Назначена'
                            , iss.Subject as 'Тема'
                            FROM Issues iss 
                                LEFT JOIN Journals jou ON iss.issueId = jou.issueId 
                                LEFT JOIN JournalDetails jd ON jou.id = jd.journalId 
                            WHERE iss.StatusId in ({ArrayToString(StatusIdList)})
                                AND jd.newValue in ({ArrayToString(StatusIdList)})
                                AND jou.CreatedOn < '{overdue}' 
                                AND iss.AssignedToId in ({ArrayToString(UserIdList)})
                            GROUP BY iss.AssignedToName
                            ORDER BY iss.AssignedToName
             */
            return DBman.OpenQuery(query);
        }
        //TODO Think about this method again
        public int GetHours(int dayStartHour, int dayEndHour, int maxHours)
        {
            DateTime Now = DateTime.Now;
            int Hours = 0;
            //Кол-во полных дней
            int workDaysFull = maxHours / Math.Abs(dayEndHour - dayStartHour);
            //Остаток часов.
            int workDayPart = maxHours % Math.Abs(dayEndHour - dayStartHour);

            Hours += workDaysFull * 24;

            //Если текущий день выходной
            if (Now.DayOfWeek == DayOfWeek.Saturday)
            {// 1 - компенсация за минуты больше указанного часа.
                Hours += Now.Hour + 1;
            }
            if (Now.DayOfWeek == DayOfWeek.Sunday)
            {// 1 - 1 - компенсация за минуты больше указанного часа.
                Hours += 24 + Now.Hour + 1;
            }

            do
            {
                if (Now.AddHours(-Hours).DayOfWeek == DayOfWeek.Saturday)
                    Hours += 24;
                else if (Now.AddHours(-Hours).DayOfWeek == DayOfWeek.Sunday)
                    Hours += 48;

                if (Now.AddHours(-Hours - workDayPart).Hour < dayStartHour)
                {
                    workDayPart = workDayPart - (dayStartHour - Now.AddHours(-Hours).Hour);
                    Hours += dayStartHour + 24 - dayEndHour + dayStartHour - Now.AddHours(-Hours).Hour;
                }
                else if (Now.AddHours(-Hours - workDayPart).Hour > dayEndHour)
                { // 1 - 1 - компенсация за минуты больше указанного часа.
                    Hours += Now.AddHours(-Hours - workDayPart).Hour + 1 - dayEndHour;
                }
                else
                {
                    Hours += workDayPart;
                    workDayPart = 0;
                }
            }
            while (workDayPart > 0);
            return Hours;
            
        }

        public void ControlUpdate()
        {
            GetDataTable();
            BringToFront();
        }
    }
}
