﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerHelper.DB;

namespace TrackerHelper.Controls
{
    public partial class DashboardIssuesStatus : UserControl, IDashboardControlsUpdate
    {
        static string _dateFormat = "yyyy-MM-dd HH:mm:ss:fff";
        private int[] _userIdList = new int[] { 2361, 2374, 1830, 2233, 1240, 1383, 2886, 2235, 1521, 2232, 1537, 2535, 551, 894, 3713, 328, 751, 2270 };
        private int[] _statusIdList = new int[] { 1 };
        private DataTable _issuesTable = new DataTable();
        private int[] _projectId = new int[]{ 26, 220 };
        private int _hoursToOverdue = 0;


        public int[] UserIdList
        {
            get { return _userIdList; }
            set { _userIdList = value; }
        }

        public int[] StatusIdList
        {
            get { return _statusIdList; }
            set { _statusIdList = value; }
        }

        public DataTable IssuesTable
        {
            get { return _issuesTable; }
            set { _issuesTable = value; }
        }

        public int[] ProjectId
        {
            get { return _projectId; }
            set { _projectId = value; }
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

        private string ArrayToString(int[] array)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(array[0]);
            for(int i = 1; i < array.Length; i++)
            {
                sb.Append("," + array[i].ToString());
            }
            return sb.ToString();
        }

        public void GetDataTable()
        {
            //  string query = $@"SELECT IssueId as 'Номер задачи', strftime('%Y-%m-%d %H:%M',CreatedOn) as 'Создан', AssignedToName as 'Назначена',
            //       Subject as 'Тема' FROM ISSUES 
            //            WHERE StatusId IN ({ArrayToString(StatusIdList)}) AND AssignedToId in ({ArrayToString(UserIdList)}) AND ProjectId in ({ArrayToString(ProjectId)}) ORDER BY AssignedToName";
            //    IssuesTable = DBman.OpenQuery(query);

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

            dgvIssuesStatus.RowsDefaultCellStyle.BackColor = Color.FromArgb(43, 51, 65);
            dgvIssuesStatus.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(23, 31, 45);

            dgvIssuesStatus.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;          
            dgvIssuesStatus.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(43, 51, 65);
            dgvIssuesStatus.RowHeadersDefaultCellStyle.BackColor = Color.Black;

            dgvIssuesStatus.ForeColor = Color.Gainsboro;

            dgvIssuesStatus.Columns["Номер задачи"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvIssuesStatus.Columns["Создан"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvIssuesStatus.Columns["Назначена"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvIssuesStatus.Columns["Тема"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvIssuesStatus.Columns["Тема"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            using (Font font = new Font(dgvIssuesStatus.DefaultCellStyle.Font.FontFamily, 14, FontStyle.Bold))
            {
                dgvIssuesStatus.Columns["Создан"].DefaultCellStyle.Font = font;
                dgvIssuesStatus.Columns["Тема"].DefaultCellStyle.Font = font;
                dgvIssuesStatus.Columns["Номер задачи"].DefaultCellStyle.Font = font;
                dgvIssuesStatus.Columns["Назначена"].DefaultCellStyle.Font = font;
                dgvIssuesStatus.ColumnHeadersDefaultCellStyle.Font = font;
            }
        }

        /// <param name="label">Ссылка на Label</param>
        /// <param name="panel">Ссылка на Panel у которой будет заполняться Tag</param>
        /// <param name="hoursFrom">Время начала рабочего дня</param>
        /// <param name="hoursTo">Время конца рабочего дня</param>
        /// <param name="hoursToOverdue">Часы до превышения лимита</param>
        /// <param name="statusId">Id статуса</param>
        public DataTable CheckStatusOverdue(int hoursFrom, int hoursTo, int hoursToOverdue)
        {
            string overdue;

            overdue = DateTime.Now.AddHours(-GetHours(hoursFrom, hoursTo, hoursToOverdue)).ToString(_dateFormat);

            string query = $@"SELECT issueid AS 'Номер задачи'
                            , strftime('%Y-%m-%d %H:%M',CreatedOn) AS 'Создан'
                            , AssignedToName AS 'Назначена'
                            , Subject AS 'Тема'
                            FROM Issues 
                            WHERE issueId IN
	                            (SELECT IssueId FROM Journals WHERE CreatedOn < '{overdue}' AND id IN
		                            (SELECT JournalId FROM JournalDetails WHERE newValue IN ({ArrayToString(StatusIdList)})))
                            AND StatusId IN ({ArrayToString(StatusIdList)})
                            AND AssignedToId IN ({ArrayToString(UserIdList)})
                            AND ProjectId NOT IN (153)
                            GROUP BY AssignedToName, IssueId
                            ORDER BY AssignedToName";

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

        public void ControlUpdate()
        {
            GetDataTable();
            BringToFront();
        }
    }
}
