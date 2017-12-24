namespace TrackerHelper.Controls
{
    partial class DashboardIssuesStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLayoutBot = new System.Windows.Forms.Panel();
            this.pnlLayoutMain = new System.Windows.Forms.Panel();
            this.dgvIssuesStatus = new System.Windows.Forms.DataGridView();
            this.pnlLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuesStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLayoutBot
            // 
            this.pnlLayoutBot.BackColor = System.Drawing.Color.Transparent;
            this.pnlLayoutBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLayoutBot.Location = new System.Drawing.Point(0, 630);
            this.pnlLayoutBot.Name = "pnlLayoutBot";
            this.pnlLayoutBot.Size = new System.Drawing.Size(1200, 170);
            this.pnlLayoutBot.TabIndex = 0;
            // 
            // pnlLayoutMain
            // 
            this.pnlLayoutMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlLayoutMain.Controls.Add(this.dgvIssuesStatus);
            this.pnlLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.pnlLayoutMain.Name = "pnlLayoutMain";
            this.pnlLayoutMain.Size = new System.Drawing.Size(1200, 630);
            this.pnlLayoutMain.TabIndex = 1;
            // 
            // dgvIssuesStatus
            // 
            this.dgvIssuesStatus.AllowUserToOrderColumns = true;
            this.dgvIssuesStatus.AllowUserToResizeRows = false;
            this.dgvIssuesStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssuesStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIssuesStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIssuesStatus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvIssuesStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssuesStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssuesStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIssuesStatus.Location = new System.Drawing.Point(0, 0);
            this.dgvIssuesStatus.MultiSelect = false;
            this.dgvIssuesStatus.Name = "dgvIssuesStatus";
            this.dgvIssuesStatus.ReadOnly = true;
            this.dgvIssuesStatus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIssuesStatus.RowHeadersVisible = false;
            this.dgvIssuesStatus.RowTemplate.ReadOnly = true;
            this.dgvIssuesStatus.Size = new System.Drawing.Size(1200, 630);
            this.dgvIssuesStatus.TabIndex = 0;
            // 
            // DashboardIssuesStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.pnlLayoutMain);
            this.Controls.Add(this.pnlLayoutBot);
            this.Name = "DashboardIssuesStatus";
            this.Size = new System.Drawing.Size(1200, 800);
            this.pnlLayoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuesStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLayoutBot;
        private System.Windows.Forms.Panel pnlLayoutMain;
        private System.Windows.Forms.DataGridView dgvIssuesStatus;
    }
}
