﻿namespace TrackerHelper.Controls
{
    partial class DashboardSettingsInfo
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.clbEmployees = new System.Windows.Forms.CheckedListBox();
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.pnlProjects = new System.Windows.Forms.Panel();
            this.clbProjects = new System.Windows.Forms.CheckedListBox();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.clbStatus = new System.Windows.Forms.CheckedListBox();
            this.pnlStatusPreset = new System.Windows.Forms.Panel();
            this.plnLayoutTop = new System.Windows.Forms.Panel();
            this.pnlLayoutTopButtons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlStatusHours = new System.Windows.Forms.Panel();
            this.pnlTextBoxFilters = new System.Windows.Forms.Panel();
            this.tbEmplFilter = new System.Windows.Forms.TextBox();
            this.tbProjFilter = new System.Windows.Forms.TextBox();
            this.tbStatusFilter = new System.Windows.Forms.TextBox();
            this.pnlEmployees.SuspendLayout();
            this.pnlProjects.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlStatusPreset.SuspendLayout();
            this.plnLayoutTop.SuspendLayout();
            this.pnlLayoutTopButtons.SuspendLayout();
            this.pnlTextBoxFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbEmployees
            // 
            this.clbEmployees.CheckOnClick = true;
            this.clbEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbEmployees.FormattingEnabled = true;
            this.clbEmployees.Location = new System.Drawing.Point(0, 0);
            this.clbEmployees.Name = "clbEmployees";
            this.clbEmployees.Size = new System.Drawing.Size(300, 885);
            this.clbEmployees.TabIndex = 0;
            this.clbEmployees.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbEmployees_ItemCheck);
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.Controls.Add(this.clbEmployees);
            this.pnlEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEmployees.Location = new System.Drawing.Point(0, 81);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(300, 885);
            this.pnlEmployees.TabIndex = 1;
            // 
            // pnlProjects
            // 
            this.pnlProjects.Controls.Add(this.clbProjects);
            this.pnlProjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProjects.Location = new System.Drawing.Point(300, 81);
            this.pnlProjects.Name = "pnlProjects";
            this.pnlProjects.Size = new System.Drawing.Size(300, 885);
            this.pnlProjects.TabIndex = 2;
            // 
            // clbProjects
            // 
            this.clbProjects.CheckOnClick = true;
            this.clbProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbProjects.FormattingEnabled = true;
            this.clbProjects.Location = new System.Drawing.Point(0, 0);
            this.clbProjects.Name = "clbProjects";
            this.clbProjects.Size = new System.Drawing.Size(300, 885);
            this.clbProjects.TabIndex = 0;
            this.clbProjects.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbProjects_ItemCheck);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.clbStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatus.Location = new System.Drawing.Point(600, 81);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(300, 885);
            this.pnlStatus.TabIndex = 3;
            // 
            // clbStatus
            // 
            this.clbStatus.CheckOnClick = true;
            this.clbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbStatus.FormattingEnabled = true;
            this.clbStatus.Location = new System.Drawing.Point(0, 0);
            this.clbStatus.Name = "clbStatus";
            this.clbStatus.Size = new System.Drawing.Size(300, 885);
            this.clbStatus.TabIndex = 0;
            this.clbStatus.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbStatus_ItemCheck);
            // 
            // pnlStatusPreset
            // 
            this.pnlStatusPreset.Controls.Add(this.pnlStatusHours);
            this.pnlStatusPreset.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlStatusPreset.Location = new System.Drawing.Point(900, 81);
            this.pnlStatusPreset.Name = "pnlStatusPreset";
            this.pnlStatusPreset.Size = new System.Drawing.Size(816, 885);
            this.pnlStatusPreset.TabIndex = 4;
            // 
            // plnLayoutTop
            // 
            this.plnLayoutTop.Controls.Add(this.pnlLayoutTopButtons);
            this.plnLayoutTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plnLayoutTop.Location = new System.Drawing.Point(0, 0);
            this.plnLayoutTop.Name = "plnLayoutTop";
            this.plnLayoutTop.Size = new System.Drawing.Size(1716, 51);
            this.plnLayoutTop.TabIndex = 0;
            // 
            // pnlLayoutTopButtons
            // 
            this.pnlLayoutTopButtons.Controls.Add(this.label1);
            this.pnlLayoutTopButtons.Controls.Add(this.tbName);
            this.pnlLayoutTopButtons.Controls.Add(this.btnSave);
            this.pnlLayoutTopButtons.Controls.Add(this.btnClose);
            this.pnlLayoutTopButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLayoutTopButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlLayoutTopButtons.Name = "pnlLayoutTopButtons";
            this.pnlLayoutTopButtons.Size = new System.Drawing.Size(1716, 50);
            this.pnlLayoutTopButtons.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название предустановки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbName.Location = new System.Drawing.Point(15, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 13);
            this.tbName.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Location = new System.Drawing.Point(200, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 50);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(281, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlStatusHours
            // 
            this.pnlStatusHours.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatusHours.Location = new System.Drawing.Point(0, 0);
            this.pnlStatusHours.Name = "pnlStatusHours";
            this.pnlStatusHours.Size = new System.Drawing.Size(200, 885);
            this.pnlStatusHours.TabIndex = 0;
            // 
            // pnlTextBoxFilters
            // 
            this.pnlTextBoxFilters.Controls.Add(this.tbStatusFilter);
            this.pnlTextBoxFilters.Controls.Add(this.tbProjFilter);
            this.pnlTextBoxFilters.Controls.Add(this.tbEmplFilter);
            this.pnlTextBoxFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTextBoxFilters.Location = new System.Drawing.Point(0, 51);
            this.pnlTextBoxFilters.Name = "pnlTextBoxFilters";
            this.pnlTextBoxFilters.Size = new System.Drawing.Size(1716, 30);
            this.pnlTextBoxFilters.TabIndex = 1;
            // 
            // tbEmplFilter
            // 
            this.tbEmplFilter.Location = new System.Drawing.Point(15, 5);
            this.tbEmplFilter.Name = "tbEmplFilter";
            this.tbEmplFilter.Size = new System.Drawing.Size(270, 20);
            this.tbEmplFilter.TabIndex = 0;
            // 
            // tbProjFilter
            // 
            this.tbProjFilter.Location = new System.Drawing.Point(315, 5);
            this.tbProjFilter.Name = "tbProjFilter";
            this.tbProjFilter.Size = new System.Drawing.Size(270, 20);
            this.tbProjFilter.TabIndex = 1;
            // 
            // tbStatusFilter
            // 
            this.tbStatusFilter.Location = new System.Drawing.Point(615, 5);
            this.tbStatusFilter.Name = "tbStatusFilter";
            this.tbStatusFilter.Size = new System.Drawing.Size(270, 20);
            this.tbStatusFilter.TabIndex = 2;
            this.tbStatusFilter.TextChanged += new System.EventHandler(this.tbStatusFilter_TextChanged);
            // 
            // DashboardSettingsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlStatusPreset);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlProjects);
            this.Controls.Add(this.pnlEmployees);
            this.Controls.Add(this.pnlTextBoxFilters);
            this.Controls.Add(this.plnLayoutTop);
            this.Name = "DashboardSettingsInfo";
            this.Size = new System.Drawing.Size(1716, 966);
            this.pnlEmployees.ResumeLayout(false);
            this.pnlProjects.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatusPreset.ResumeLayout(false);
            this.plnLayoutTop.ResumeLayout(false);
            this.pnlLayoutTopButtons.ResumeLayout(false);
            this.pnlLayoutTopButtons.PerformLayout();
            this.pnlTextBoxFilters.ResumeLayout(false);
            this.pnlTextBoxFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbEmployees;
        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.Panel pnlProjects;
        private System.Windows.Forms.CheckedListBox clbProjects;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.CheckedListBox clbStatus;
        private System.Windows.Forms.Panel pnlStatusPreset;
        private System.Windows.Forms.Panel plnLayoutTop;
        private System.Windows.Forms.Panel pnlLayoutTopButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlTextBoxFilters;
        private System.Windows.Forms.Panel pnlStatusHours;
        private System.Windows.Forms.TextBox tbEmplFilter;
        private System.Windows.Forms.TextBox tbStatusFilter;
        private System.Windows.Forms.TextBox tbProjFilter;
    }
}
