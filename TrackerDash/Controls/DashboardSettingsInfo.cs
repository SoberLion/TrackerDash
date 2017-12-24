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
            string Employees = "SELECT DISTINCT AssignedToId, AssignedToName FROM Issues ORDER BY AssignedToName";
            string Projects = "SELECT DISTINCT ProjectId, ProjectName FROM Issues ORDER BY ProjectName";
            string Statuses = "SELECT DISTINCT StatusId, StatusName FROM Issues ORDER BY StatusId";

            // get list of employees/projects/statuses
            DataRow[] EmplData = DBman.OpenQuery(Employees).Select("");
            List<IdName> emplList = EmplData.Select(p => new IdName { id = Convert.ToInt32(p[0]), name = p[1].ToString() }).ToList<IdName>();

            DataRow[] ProjData = DBman.OpenQuery(Projects).Select("");
            List<IdName> projList = ProjData.Select(p => new IdName { id = Convert.ToInt32(p[0]), name = p[1].ToString() }).ToList<IdName>();

            DataRow[] StatData = DBman.OpenQuery(Statuses).Select("");
            List<Status> statList = StatData.Select(p => new Status { ID = Convert.ToInt32(p[0]), Name = p[1].ToString() }).ToList<Status>();

            // intersect - with items in preset list; checked = true
            List<IdName> IntersectEmplList = emplList.Intersect(Preset.Employees, new IdNameComparer()).ToList();
            // except - items not in preset list; checked = false
            List<IdName> ExceptEmplList = emplList.Except(Preset.Employees, new IdNameComparer()).ToList();
            
            //fill checkedlist eployees with checked and unchecked items
            for (int i = 0; i < IntersectEmplList.Count; i++)
            {
                clbEmployees.Items.Add($"{IntersectEmplList[i].name} <{IntersectEmplList[i].id}>", true);
            }
            for (int i = 0; i < ExceptEmplList.Count; i++)
            {
                clbEmployees.Items.Add($"{ExceptEmplList[i].name} <{ExceptEmplList[i].id}>", false);
            }

            
            List<IdName> IntersectProjList = projList.Intersect(Preset.Projects).ToList();
            List<IdName> ExceptProjList = projList.Except(Preset.Projects).ToList();

            //fill checkedlist projects with checked and unchecked items
            for (int i = 0; i < IntersectProjList.Count; i++)
            {
                clbProjects.Items.Add($"{IntersectProjList[i].name} <{IntersectProjList[i].id}>", true);
            }
            for (int i = 0; i < ExceptProjList.Count; i++)
            {
                clbProjects.Items.Add($"{ExceptProjList[i].name} <{ExceptProjList[i].id}>", false);
            }

            
            List<Status> IntersectStatList = statList.Intersect(Preset.Statuses).ToList();
            List<Status> ExceptStatList = statList.Except(Preset.Statuses).ToList();

            //fill checkedlist status with checked and unchecked items
            for (int i = 0; i < IntersectStatList.Count; i++)
            {
                clbStatus.Items.Add($"{IntersectStatList[i].Name} <{IntersectStatList[i].ID}>", true);
            }
            for (int i = 0; i < ExceptStatList.Count; i++)
            {
                clbStatus.Items.Add($"{ExceptStatList[i].Name} <{ExceptStatList[i].ID}>", false);
            }
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
                        Preset.Statuses.Add(new Status { Name = str[0], ID = Convert.ToInt32(str[1]) });
                }
                else if (e.CurrentValue == CheckState.Checked)
                {
                    Status st = Preset.Statuses.Find(p => p.ID == Convert.ToInt32(str[1]));
                    if (st != null)
                        Preset.Statuses.RemoveAt(Preset.Statuses.IndexOf(st));
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
    }
}