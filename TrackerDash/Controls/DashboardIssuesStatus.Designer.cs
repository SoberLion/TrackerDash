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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLayoutMain = new System.Windows.Forms.Panel();
            this.dgvIssuesStatus = new System.Windows.Forms.DataGridView();
            this.pnlSplash = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pnlLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuesStatus)).BeginInit();
            this.pnlSplash.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLayoutMain
            // 
            this.pnlLayoutMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlLayoutMain.Controls.Add(this.pnlSplash);
            this.pnlLayoutMain.Controls.Add(this.dgvIssuesStatus);
            this.pnlLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.pnlLayoutMain.Name = "pnlLayoutMain";
            this.pnlLayoutMain.Size = new System.Drawing.Size(1200, 800);
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
            this.dgvIssuesStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIssuesStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssuesStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIssuesStatus.Location = new System.Drawing.Point(0, 0);
            this.dgvIssuesStatus.MultiSelect = false;
            this.dgvIssuesStatus.Name = "dgvIssuesStatus";
            this.dgvIssuesStatus.ReadOnly = true;
            this.dgvIssuesStatus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIssuesStatus.RowHeadersVisible = false;
            this.dgvIssuesStatus.RowTemplate.ReadOnly = true;
            this.dgvIssuesStatus.Size = new System.Drawing.Size(1200, 800);
            this.dgvIssuesStatus.TabIndex = 0;
            // 
            // pnlSplash
            // 
            this.pnlSplash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSplash.Controls.Add(this.lblLoading);
            this.pnlSplash.Location = new System.Drawing.Point(0, 0);
            this.pnlSplash.Name = "pnlSplash";
            this.pnlSplash.Size = new System.Drawing.Size(1200, 800);
            this.pnlSplash.TabIndex = 1;
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoading.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLoading.Location = new System.Drawing.Point(528, 385);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(144, 31);
            this.lblLoading.TabIndex = 0;
            this.lblLoading.Text = "Loading...";
            // 
            // DashboardIssuesStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.pnlLayoutMain);
            this.Name = "DashboardIssuesStatus";
            this.Size = new System.Drawing.Size(1200, 800);
            this.pnlLayoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuesStatus)).EndInit();
            this.pnlSplash.ResumeLayout(false);
            this.pnlSplash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLayoutMain;
        private System.Windows.Forms.DataGridView dgvIssuesStatus;
        private System.Windows.Forms.Panel pnlSplash;
        private System.Windows.Forms.Label lblLoading;
    }
}
