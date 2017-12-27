namespace TrackerHelper
{
    partial class DashboardSettings
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnEditPreset = new System.Windows.Forms.Button();
            this.btnDeletePreset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cbPresets = new System.Windows.Forms.ComboBox();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnEditPreset);
            this.pnlTop.Controls.Add(this.btnDeletePreset);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnNew);
            this.pnlTop.Controls.Add(this.cbPresets);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1716, 50);
            this.pnlTop.TabIndex = 0;
            // 
            // btnEditPreset
            // 
            this.btnEditPreset.FlatAppearance.BorderSize = 0;
            this.btnEditPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPreset.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditPreset.Location = new System.Drawing.Point(280, 0);
            this.btnEditPreset.Name = "btnEditPreset";
            this.btnEditPreset.Size = new System.Drawing.Size(75, 50);
            this.btnEditPreset.TabIndex = 5;
            this.btnEditPreset.Text = "Edit";
            this.btnEditPreset.UseVisualStyleBackColor = true;
            this.btnEditPreset.Click += new System.EventHandler(this.btnEditPreset_Click);
            // 
            // btnDeletePreset
            // 
            this.btnDeletePreset.FlatAppearance.BorderSize = 0;
            this.btnDeletePreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePreset.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeletePreset.Location = new System.Drawing.Point(360, 0);
            this.btnDeletePreset.Name = "btnDeletePreset";
            this.btnDeletePreset.Size = new System.Drawing.Size(75, 50);
            this.btnDeletePreset.TabIndex = 4;
            this.btnDeletePreset.Text = "Delete";
            this.btnDeletePreset.UseVisualStyleBackColor = true;
            this.btnDeletePreset.Click += new System.EventHandler(this.btnDeletePreset_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(440, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNew.Location = new System.Drawing.Point(200, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 50);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cbPresets
            // 
            this.cbPresets.DropDownHeight = 120;
            this.cbPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPresets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPresets.FormattingEnabled = true;
            this.cbPresets.IntegralHeight = false;
            this.cbPresets.Location = new System.Drawing.Point(15, 15);
            this.cbPresets.Name = "cbPresets";
            this.cbPresets.Size = new System.Drawing.Size(170, 21);
            this.cbPresets.Sorted = true;
            this.cbPresets.TabIndex = 0;
            this.cbPresets.SelectionChangeCommitted += new System.EventHandler(this.cbPresets_SelectionChangeCommitted);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettings.Location = new System.Drawing.Point(0, 50);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(1716, 976);
            this.pnlSettings.TabIndex = 1;
            // 
            // DashboardSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlTop);
            this.Name = "DashboardSettings";
            this.Size = new System.Drawing.Size(1716, 1026);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ComboBox cbPresets;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDeletePreset;
        private System.Windows.Forms.Button btnEditPreset;
    }
}
