namespace TrackerHelper
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlLayoutLeft = new System.Windows.Forms.Panel();
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.chbtn_Settings = new TrackerHelper.CheckedButton();
            this.btnEscalated = new TrackerHelper.CheckedButton();
            this.btnNeedInfoEmpl = new TrackerHelper.CheckedButton();
            this.btnAssigned = new TrackerHelper.CheckedButton();
            this.btnNew = new TrackerHelper.CheckedButton();
            this.btnTechSupp = new TrackerHelper.CheckedButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbBGWork = new TrackerHelper.customProgressBar();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlVertDivider = new System.Windows.Forms.Panel();
            this.pnlLayoutRight = new System.Windows.Forms.Panel();
            this.pnlHorizDivider = new System.Windows.Forms.Panel();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlLayoutLeft.SuspendLayout();
            this.pnlBtns.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlLayoutRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLayoutLeft
            // 
            this.pnlLayoutLeft.Controls.Add(this.pnlBtns);
            this.pnlLayoutLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLayoutLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLayoutLeft.Name = "pnlLayoutLeft";
            this.pnlLayoutLeft.Size = new System.Drawing.Size(200, 672);
            this.pnlLayoutLeft.TabIndex = 1;
            // 
            // pnlBtns
            // 
            this.pnlBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlBtns.Controls.Add(this.chbtn_Settings);
            this.pnlBtns.Controls.Add(this.btnEscalated);
            this.pnlBtns.Controls.Add(this.btnNeedInfoEmpl);
            this.pnlBtns.Controls.Add(this.btnAssigned);
            this.pnlBtns.Controls.Add(this.btnNew);
            this.pnlBtns.Controls.Add(this.btnTechSupp);
            this.pnlBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBtns.Location = new System.Drawing.Point(0, 0);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(200, 672);
            this.pnlBtns.TabIndex = 1;
            // 
            // chbtn_Settings
            // 
            this.chbtn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.chbtn_Settings.Check = false;
            this.chbtn_Settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chbtn_Settings.FlatAppearance.BorderSize = 0;
            this.chbtn_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.chbtn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.chbtn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbtn_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbtn_Settings.ForeColor = System.Drawing.Color.White;
            this.chbtn_Settings.Location = new System.Drawing.Point(0, 626);
            this.chbtn_Settings.Name = "chbtn_Settings";
            this.chbtn_Settings.Size = new System.Drawing.Size(200, 46);
            this.chbtn_Settings.TabIndex = 5;
            this.chbtn_Settings.Text = "      Настройки";
            this.chbtn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chbtn_Settings.UseVisualStyleBackColor = false;
            this.chbtn_Settings.Click += new System.EventHandler(this.chbtn_Settings_Click);
            // 
            // btnEscalated
            // 
            this.btnEscalated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnEscalated.Check = false;
            this.btnEscalated.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEscalated.FlatAppearance.BorderSize = 0;
            this.btnEscalated.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnEscalated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscalated.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEscalated.ForeColor = System.Drawing.Color.White;
            this.btnEscalated.Location = new System.Drawing.Point(0, 184);
            this.btnEscalated.Name = "btnEscalated";
            this.btnEscalated.Size = new System.Drawing.Size(200, 46);
            this.btnEscalated.TabIndex = 4;
            this.btnEscalated.Text = "         Эскалирована";
            this.btnEscalated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEscalated.UseVisualStyleBackColor = false;
            this.btnEscalated.Click += new System.EventHandler(this.btnEscalated_Click);
            // 
            // btnNeedInfoEmpl
            // 
            this.btnNeedInfoEmpl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNeedInfoEmpl.Check = false;
            this.btnNeedInfoEmpl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNeedInfoEmpl.FlatAppearance.BorderSize = 0;
            this.btnNeedInfoEmpl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnNeedInfoEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeedInfoEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNeedInfoEmpl.ForeColor = System.Drawing.Color.White;
            this.btnNeedInfoEmpl.Location = new System.Drawing.Point(0, 138);
            this.btnNeedInfoEmpl.Name = "btnNeedInfoEmpl";
            this.btnNeedInfoEmpl.Size = new System.Drawing.Size(200, 46);
            this.btnNeedInfoEmpl.TabIndex = 3;
            this.btnNeedInfoEmpl.Text = "         Нужна инф. сотр.";
            this.btnNeedInfoEmpl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNeedInfoEmpl.UseVisualStyleBackColor = false;
            this.btnNeedInfoEmpl.Click += new System.EventHandler(this.btnNeedInfoEmpl_Click);
            // 
            // btnAssigned
            // 
            this.btnAssigned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnAssigned.Check = false;
            this.btnAssigned.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssigned.FlatAppearance.BorderSize = 0;
            this.btnAssigned.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnAssigned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAssigned.ForeColor = System.Drawing.Color.White;
            this.btnAssigned.Location = new System.Drawing.Point(0, 92);
            this.btnAssigned.Name = "btnAssigned";
            this.btnAssigned.Size = new System.Drawing.Size(200, 46);
            this.btnAssigned.TabIndex = 2;
            this.btnAssigned.Text = "         Назначена";
            this.btnAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssigned.UseVisualStyleBackColor = false;
            this.btnAssigned.Click += new System.EventHandler(this.btnAssigned_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNew.Check = false;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(0, 46);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(200, 46);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "         Новая";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnTechSupp
            // 
            this.btnTechSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTechSupp.Check = false;
            this.btnTechSupp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTechSupp.FlatAppearance.BorderSize = 0;
            this.btnTechSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnTechSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnTechSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTechSupp.ForeColor = System.Drawing.Color.White;
            this.btnTechSupp.Location = new System.Drawing.Point(0, 0);
            this.btnTechSupp.Name = "btnTechSupp";
            this.btnTechSupp.Size = new System.Drawing.Size(200, 46);
            this.btnTechSupp.TabIndex = 0;
            this.btnTechSupp.Text = "      Main";
            this.btnTechSupp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTechSupp.UseVisualStyleBackColor = false;
            this.btnTechSupp.Click += new System.EventHandler(this.btnTechSupp_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlHeader.Controls.Add(this.lblLastUpdate);
            this.pnlHeader.Controls.Add(this.lblCaption);
            this.pnlHeader.Controls.Add(this.btnUpdate);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.pbBGWork);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(4, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1030, 50);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDoubleClick);
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblLastUpdate.Location = new System.Drawing.Point(537, 12);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(400, 24);
            this.lblLastUpdate.TabIndex = 4;
            this.lblLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(65, 17);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(0, 16);
            this.lblCaption.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(12, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(25, 25);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.btnClose.Location = new System.Drawing.Point(943, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 49);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbBGWork
            // 
            this.pbBGWork.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbBGWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pbBGWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.pbBGWork.Location = new System.Drawing.Point(0, 49);
            this.pbBGWork.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.pbBGWork.Name = "pbBGWork";
            this.pbBGWork.ProgressColor = System.Drawing.Color.Gainsboro;
            this.pbBGWork.ProgressText = "";
            this.pbBGWork.ProgressValue = 0;
            this.pbBGWork.Size = new System.Drawing.Size(1030, 1);
            this.pbBGWork.TabIndex = 3;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(4, 50);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1030, 622);
            this.pnlDashboard.TabIndex = 2;
            // 
            // pnlVertDivider
            // 
            this.pnlVertDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.pnlVertDivider.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVertDivider.Location = new System.Drawing.Point(0, 0);
            this.pnlVertDivider.Name = "pnlVertDivider";
            this.pnlVertDivider.Size = new System.Drawing.Size(4, 672);
            this.pnlVertDivider.TabIndex = 3;
            // 
            // pnlLayoutRight
            // 
            this.pnlLayoutRight.Controls.Add(this.pnlHorizDivider);
            this.pnlLayoutRight.Controls.Add(this.pnlDashboard);
            this.pnlLayoutRight.Controls.Add(this.pnlHeader);
            this.pnlLayoutRight.Controls.Add(this.pnlVertDivider);
            this.pnlLayoutRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayoutRight.Location = new System.Drawing.Point(200, 0);
            this.pnlLayoutRight.Name = "pnlLayoutRight";
            this.pnlLayoutRight.Size = new System.Drawing.Size(1034, 672);
            this.pnlLayoutRight.TabIndex = 4;
            // 
            // pnlHorizDivider
            // 
            this.pnlHorizDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.pnlHorizDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHorizDivider.Location = new System.Drawing.Point(4, 50);
            this.pnlHorizDivider.Name = "pnlHorizDivider";
            this.pnlHorizDivider.Size = new System.Drawing.Size(1030, 4);
            this.pnlHorizDivider.TabIndex = 4;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // timer
            // 
            this.timer.Interval = 300000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 672);
            this.Controls.Add(this.pnlLayoutRight);
            this.Controls.Add(this.pnlLayoutLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlLayoutLeft.ResumeLayout(false);
            this.pnlBtns.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLayoutRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLayoutLeft;
        private System.Windows.Forms.Panel pnlBtns;
        private TrackerHelper.CheckedButton btnTechSupp;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private TrackerHelper.CheckedButton btnEscalated;
        private TrackerHelper.CheckedButton btnNeedInfoEmpl;
        private TrackerHelper.CheckedButton btnAssigned;
        private TrackerHelper.CheckedButton btnNew;
        private System.Windows.Forms.Panel pnlVertDivider;
        private System.Windows.Forms.Panel pnlHorizDivider;
        private System.Windows.Forms.Panel pnlLayoutRight;
        private System.Windows.Forms.Label lblCaption;
        private CheckedButton chbtn_Settings;
        private customProgressBar pbBGWork;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblLastUpdate;
    }
}