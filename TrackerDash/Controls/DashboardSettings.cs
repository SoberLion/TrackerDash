using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TrackerHelper.DB;
using TrackerHelper.Controls;

namespace TrackerHelper
{
    public partial class DashboardSettings : UserControl
    {

        private List<DashboardPreset> _presetsList;

        public List<DashboardPreset> PresetList
        {
            get { return _presetsList; }
            set { _presetsList = value; }
        }

        public DashboardSettings()
        {
            InitializeComponent();
            
            setComboBoxItems();
        }

        private void setComboBoxItems()
        {
            PresetList = DBman.GetPresetList();
            string[] s = PresetList.Select(p => $"<{p.ID}> {p.Name}").ToList().Count > 0 ? PresetList.Select(p => $"<{p.ID}> {p.Name}").ToArray() : null;
            if (s != null)
            {
                cbPresets.Items.Clear();
                cbPresets.Items.AddRange(s);
                cbPresets.SelectedIndex = PresetList.IndexOf(PresetList.Find(p => p.isActive == true));
            }
            cbPresets.SelectedIndex = PresetList.IndexOf(PresetList.Find(p => p.isActive == true));

            DataRow[] presetCounter = DBman.OpenQuery("SELECT PresetId FROM Presets ORDER BY PresetId DESC LIMIT 1").Select("");
            if (presetCounter.Length > 0)
            {
                DashboardPreset.SetCounter(Convert.ToInt32(presetCounter[0][0]));
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DashboardSettingsInfo settingsInfo = Controls.Find("SettingsInfo", true).FirstOrDefault() as DashboardSettingsInfo;
            if (settingsInfo != null)
            {
                settingsInfo.Dispose();
            }
            DashboardPreset newPreset = new DashboardPreset();
            settingsInfo = new DashboardSettingsInfo
            {
                Parent = this.pnlSettings,
                Preset = newPreset,
                Name = "SettingsInfo"
            };
            settingsInfo.onSave += setComboBoxItems;
            settingsInfo.GetDict();           
        }

        private void btnDeletePreset_Click(object sender, EventArgs e)
        {
            string s = cbPresets.SelectedItem?.ToString();
            if (s == null)
                return;
            int presetId = Convert.ToInt32(s.Substring(1, s.IndexOf(">") - 1));

            DBman.DeletePreset(presetId);
            setComboBoxItems();
        }

        private void btnEditPreset_Click(object sender, EventArgs e)
        {
            string s = cbPresets.SelectedItem?.ToString();
            if (s == null)
                return;
            int presetId = Convert.ToInt32(s.Substring(1, s.IndexOf(">") - 1));

            DashboardSettingsInfo settingsInfo = Controls.Find("SettingsInfo", true).FirstOrDefault() as DashboardSettingsInfo;
            if (settingsInfo != null)
            {
                settingsInfo.Dispose();
            }

            settingsInfo = new DashboardSettingsInfo
            {
                Parent = this.pnlSettings,
                Preset = PresetList.Find(p => p.ID == (presetId)),
                Name = "SettingsInfo"
            };
            settingsInfo.onSave += setComboBoxItems;
            settingsInfo.GetDict();
        }

        private void cbPresets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string s = cbPresets.SelectedItem?.ToString();
            if (s == null)
                return;
            int presetId = Convert.ToInt32(s.Substring(1, s.IndexOf(">") - 1));

            DBman.OpenQuery2($"UPDATE Presets SET isActive = 0");
            DBman.OpenQuery2($"UPDATE Presets SET isActive = 1 WHERE Presetid = {presetId}");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
