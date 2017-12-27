using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TrackerHelper.DB;
using TrackerHelper.RedmineEntities;

namespace TrackerHelper.Controls
{
    public partial class DashboardSettingsInfo : UserControl
    {

        public delegate void save();
        public event save onSave;

        private DashboardPreset _preset;

        public DashboardPreset Preset
        {
            get { return _preset; }
            set { _preset = value; }
        }

        public DashboardSettingsInfo()
        {
            InitializeComponent();
        }

        public void GetDict()
        {
            string Employees = @"SELECT ID, (Lastname || ' ' || FirstName) as Name
                                FROM Users
                                WHERE CompanyName in ('Компания UCS', 'UCS-Москва')
                                ORDER BY Name";
            string Projects = "SELECT DISTINCT ProjectId, ProjectName FROM Issues ORDER BY ProjectName";
            string Statuses = "SELECT DISTINCT StatusId, StatusName FROM Issues ORDER BY StatusId";

            // get list of employees/projects/statuses
            DataRow[] EmplData = DBman.OpenQuery(Employees).Select("");
            List<IdName> emplList = EmplData.Select(p => new IdName { id = Convert.ToInt32(p[0]), name = p[1].ToString() }).ToList<IdName>();

            DataRow[] ProjData = DBman.OpenQuery(Projects).Select("");
            List<IdName> projList = ProjData.Select(p => new IdName { id = Convert.ToInt32(p[0]), name = p[1].ToString() }).ToList<IdName>();

            DataRow[] StatData = DBman.OpenQuery(Statuses).Select("");
            List<Status> statList = StatData.Select(p => new Status { ID = Convert.ToInt32(p[0]), Name = p[1].ToString() }).ToList<Status>();

            // except - items not in preset list; checked = false
            List<IdName> ExceptEmplList = emplList.Except(Preset.Employees, new IdNameComparer()).ToList();

            //fill checkedlist epmloyees with checked and unchecked items
            for (int i = 0; i < Preset.Employees.Count; i++)
                clbEmployees.Items.Add($"{Preset.Employees[i].name} <{Preset.Employees[i].id}>", true);
           
            for (int i = 0; i < ExceptEmplList.Count; i++)            
                clbEmployees.Items.Add($"{ExceptEmplList[i].name} <{ExceptEmplList[i].id}>", false);
            

            List<IdName> ExceptProjList = projList.Except(Preset.Projects, new IdNameComparer()).ToList();

            //fill checkedlist projects with checked and unchecked items
            for (int i = 0; i < Preset.Projects.Count; i++)            
                clbProjects.Items.Add($"{Preset.Projects[i].name} <{Preset.Projects[i].id}>", true);
            
            for (int i = 0; i < ExceptProjList.Count; i++)            
                clbProjects.Items.Add($"{ExceptProjList[i].name} <{ExceptProjList[i].id}>", false);            


            List<Status> ExceptStatList = statList.Except(Preset.Statuses, new StatusComparer()).ToList();

            //fill checkedlist status with checked and unchecked items
            for (int i = 0; i < Preset.Statuses.Count; i++)
            {
                clbStatus.Items.Add($"{Preset.Statuses[i].Name} <{Preset.Statuses[i].ID}>", true);
                CreateStatusHoursTextBox(Preset.Statuses[i]);
            }
            for (int i = 0; i < ExceptStatList.Count; i++)
            {
                clbStatus.Items.Add($"{ExceptStatList[i].Name} <{ExceptStatList[i].ID}>", false);
            }

            tbName.Text = Preset.Name;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string emptytext = "Name must not be empty";
            if (tbName.Text.Length > 0 && !tbName.Text.Equals(emptytext))
            {
                foreach (char c in tbName.Text)
                {
                    if (!char.IsLetterOrDigit(c) && !Char.IsWhiteSpace(c))
                    {
                        tbName.Text = $"{c.ToString()} isnt a letter or digit";
                        return;
                    }
                }

                Preset.Name = tbName.Text;
                DBman.DeletePreset(Preset.ID);
                DBman.InsertPreset(Preset);
                onSave?.Invoke();
            }
            else
            {
                tbName.Text = emptytext;
                return;
            }
        }
        private void clbStatus_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string[] str = clbStatus.Items[e.Index].ToString().Split('<');
            str[0] = str[0].Trim();
            str[1] = str[1].Replace(">", "").Trim();
            if (str.Length > 1)
            {
                if (e.CurrentValue == CheckState.Unchecked)
                {
                    Status st = Preset.Statuses.Find(p => p.ID == Convert.ToInt32(str[1]));
                    if (st == null)
                    {
                        st = new Status { Name = str[0], ID = Convert.ToInt32(str[1]) };
                        Preset.Statuses.Add(st);
                        CreateStatusHoursTextBox(st);
                    }
                }
                else if (e.CurrentValue == CheckState.Checked)
                {
                    Status st = Preset.Statuses.Find(p => p.ID == Convert.ToInt32(str[1]));
                    if (st != null)
                    {
                        DisposeStatusHoursTextBox(st);
                        Preset.Statuses.RemoveAt(Preset.Statuses.IndexOf(st));
                    }
                }
            }
        }
        private void clbProjects_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string[] str = clbProjects.Items[e.Index].ToString().Split('<');
            str[0] = str[0].Trim();
            str[1] = str[1].Replace(">", "").Trim();
            if (str.Length > 1)
            {
                if (e.CurrentValue == CheckState.Unchecked)
                {
                    IdName st = Preset.Projects.Find(p => p.id == Convert.ToInt32(str[1]));
                    if (st == null)
                        Preset.Projects.Add(new IdName { name = str[0], id = Convert.ToInt32(str[1]) });
                }
                else if (e.CurrentValue == CheckState.Checked)
                {
                    IdName st = Preset.Projects.Find(p => p.id == Convert.ToInt32(str[1]));
                    if (st != null)
                        Preset.Projects.RemoveAt(Preset.Projects.IndexOf(st));
                }
            }
        }
        private void clbEmployees_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string[] str = clbEmployees.Items[e.Index].ToString().Split('<');
            str[0] = str[0].Trim();
            str[1] = str[1].Replace(">", "").Trim();
            if (str.Length > 1)
            {
                if (e.CurrentValue == CheckState.Unchecked)
                {
                    IdName item = Preset.Employees.Find(p => p.id == Convert.ToInt32(str[1]));
                    if (item == null)
                        Preset.Employees.Add(new IdName { name = str[0], id = Convert.ToInt32(str[1]) });                    
                }
                else if (e.CurrentValue == CheckState.Checked)
                {
                    IdName item = Preset.Employees.Find(p => p.id == Convert.ToInt32(str[1]));
                    if (item != null)
                        Preset.Employees.RemoveAt(Preset.Employees.IndexOf(item));
                }
            }
        }
        private void CreateStatusHoursTextBox(Status status)
        {
            Panel pnl = new Panel
            {
                Parent = pnlStatusHours,
                Dock = DockStyle.Top,
                Name = "pnl" + status.ID.ToString(),
                Height = 40,
                Margin = new Padding(3, 3, 3, 3),
                Padding = new Padding(5, 0, 0, 0)
            };
            TextBox tb = new TextBox
            {
                Parent = pnl,
                Dock = DockStyle.Top,
                Tag = status,
               // Text = status.MaxHours.ToString()
            };
            tb.DataBindings.Add("Text", status, "MaxHours", false, DataSourceUpdateMode.OnPropertyChanged);
            tb.TextChanged += new EventHandler(onTextBoxChanged); //onTextBoxChanged;
            Label lbl = new Label
            {
                Parent = pnl,
                Dock = DockStyle.Top,
                Text = status.Name,
                ForeColor = System.Drawing.Color.Gainsboro,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font(Label.DefaultFont.FontFamily, 9, System.Drawing.FontStyle.Bold)
            };
        }
        private void DisposeStatusHoursTextBox(Status status)
        {
            Panel pnl = Controls.Find("pnl"+status.ID, true).FirstOrDefault() as Panel;
            if (pnl != null)
                pnl.Dispose();
        }
        private void onTextBoxChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                if (tb.Text != string.Empty)
                {
                    Status st = Preset.Statuses.Find(p => p.ID == (tb.Tag as Status).ID);
                    if (st != null)
                        st.MaxHours = Convert.ToInt32(tb.Text);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void tbStatusFilter_TextChanged(object sender, EventArgs e)
        {

        }

    }
}