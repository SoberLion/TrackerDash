namespace TrackerHelper.Controls
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
            this.plnLayoutRight = new System.Windows.Forms.Panel();
            this.pnlLayoutRightButtons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlEmployees.SuspendLayout();
            this.pnlProjects.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.plnLayoutRight.SuspendLayout();
            this.pnlLayoutRightButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbEmployees
            // 
            this.clbEmployees.CheckOnClick = true;
            this.clbEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbEmployees.FormattingEnabled = true;
            this.clbEmployees.Location = new System.Drawing.Point(0, 0);
            this.clbEmployees.Name = "clbEmployees";
            this.clbEmployees.Size = new System.Drawing.Size(300, 915);
            this.clbEmployees.TabIndex = 0;
            this.clbEmployees.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbEmployees_ItemCheck);
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.Controls.Add(this.clbEmployees);
            this.pnlEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEmployees.Location = new System.Drawing.Point(0, 51);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(300, 915);
            this.pnlEmployees.TabIndex = 1;
            // 
            // pnlProjects
            // 
            this.pnlProjects.Controls.Add(this.clbProjects);
            this.pnlProjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProjects.Location = new System.Drawing.Point(300, 51);
            this.pnlProjects.Name = "pnlProjects";
            this.pnlProjects.Size = new System.Drawing.Size(300, 915);
            this.pnlProjects.TabIndex = 2;
            // 
            // clbProjects
            // 
            this.clbProjects.CheckOnClick = true;
            this.clbProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbProjects.FormattingEnabled = true;
            this.clbProjects.Location = new System.Drawing.Point(0, 0);
            this.clbProjects.Name = "clbProjects";
            this.clbProjects.Size = new System.Drawing.Size(300, 915);
            this.clbProjects.TabIndex = 0;
            this.clbProjects.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbProjects_ItemCheck);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.clbStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatus.Location = new System.Drawing.Point(600, 51);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(300, 915);
            this.pnlStatus.TabIndex = 3;
            // 
            // clbStatus
            // 
            this.clbStatus.CheckOnClick = true;
            this.clbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbStatus.FormattingEnabled = true;
            this.clbStatus.Location = new System.Drawing.Point(0, 0);
            this.clbStatus.Name = "clbStatus";
            this.clbStatus.Size = new System.Drawing.Size(300, 915);
            this.clbStatus.TabIndex = 0;
            this.clbStatus.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbStatus_ItemCheck);
            // 
            // pnlStatusPreset
            // 
            this.pnlStatusPreset.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlStatusPreset.Location = new System.Drawing.Point(900, 51);
            this.pnlStatusPreset.Name = "pnlStatusPreset";
            this.pnlStatusPreset.Size = new System.Drawing.Size(816, 915);
            this.pnlStatusPreset.TabIndex = 4;
            // 
            // plnLayoutRight
            // 
            this.plnLayoutRight.Controls.Add(this.pnlLayoutRightButtons);
            this.plnLayoutRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.plnLayoutRight.Location = new System.Drawing.Point(0, 0);
            this.plnLayoutRight.Name = "plnLayoutRight";
            this.plnLayoutRight.Size = new System.Drawing.Size(1716, 51);
            this.plnLayoutRight.TabIndex = 0;
            // 
            // pnlLayoutRightButtons
            // 
            this.pnlLayoutRightButtons.Controls.Add(this.label1);
            this.pnlLayoutRightButtons.Controls.Add(this.tbName);
            this.pnlLayoutRightButtons.Controls.Add(this.btnSave);
            this.pnlLayoutRightButtons.Controls.Add(this.btnClose);
            this.pnlLayoutRightButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLayoutRightButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlLayoutRightButtons.Name = "pnlLayoutRightButtons";
            this.pnlLayoutRightButtons.Size = new System.Drawing.Size(1716, 50);
            this.pnlLayoutRightButtons.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название предустановки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbName.Location = new System.Drawing.Point(12, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(194, 13);
            this.tbName.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(215, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 50);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1616, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // DashboardSettingsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlStatusPreset);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlProjects);
            this.Controls.Add(this.pnlEmployees);
            this.Controls.Add(this.plnLayoutRight);
            this.Name = "DashboardSettingsInfo";
            this.Size = new System.Drawing.Size(1716, 966);
            this.pnlEmployees.ResumeLayout(false);
            this.pnlProjects.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.plnLayoutRight.ResumeLayout(false);
            this.pnlLayoutRightButtons.ResumeLayout(false);
            this.pnlLayoutRightButtons.PerformLayout();
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
        private System.Windows.Forms.Panel plnLayoutRight;
        private System.Windows.Forms.Panel pnlLayoutRightButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
    }
}
