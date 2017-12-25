namespace TrackerHelper.Controls
{
    partial class DashboardIssues
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
            this.components = new System.ComponentModel.Container();
            this.pnlSplash = new System.Windows.Forms.Panel();
            this.lblDataLoading = new System.Windows.Forms.Label();
            this.pnlLayoutBot = new System.Windows.Forms.Panel();
            this.lblLastYearDates = new System.Windows.Forms.Label();
            this.pnlBotLastYear = new System.Windows.Forms.Panel();
            this.lblClosedLastYearValue = new System.Windows.Forms.Label();
            this.lblClosedLastYear = new System.Windows.Forms.Label();
            this.lblCreatedLastYearValue = new System.Windows.Forms.Label();
            this.lblCreatedLastYear = new System.Windows.Forms.Label();
            this.pnlBotThisYear = new System.Windows.Forms.Panel();
            this.lblClosedThisYearValue = new System.Windows.Forms.Label();
            this.lblClosedThisYear = new System.Windows.Forms.Label();
            this.lblCreatedThisYearValue = new System.Windows.Forms.Label();
            this.lblCreatedThisYear = new System.Windows.Forms.Label();
            this.pnlBotRightCorner = new System.Windows.Forms.Panel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.pnlWeekFilter = new System.Windows.Forms.Panel();
            this.btnWeek = new TrackerHelper.CheckedButton();
            this.pnlMonthFilter = new System.Windows.Forms.Panel();
            this.btnMonth = new TrackerHelper.CheckedButton();
            this.pnlUpdateBtn = new System.Windows.Forms.Panel();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.lblThisYearDates = new System.Windows.Forms.Label();
            this.lblStatusAssigned = new System.Windows.Forms.Label();
            this.pnlLayoutMid = new System.Windows.Forms.Panel();
            this.pnlStatusNeedInfoEmpl = new System.Windows.Forms.Panel();
            this.lblStatusNeedInfoEmplValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPnlStatusHeader = new System.Windows.Forms.Label();
            this.pnlStatusEscalated = new System.Windows.Forms.Panel();
            this.lblStatusEscalatedValue = new System.Windows.Forms.Label();
            this.lblStatusEscalated = new System.Windows.Forms.Label();
            this.pnlStatusAssigned = new System.Windows.Forms.Panel();
            this.lblStatusAssignedValue = new System.Windows.Forms.Label();
            this.pnlStatusNew = new System.Windows.Forms.Panel();
            this.lblStatusNewValue = new System.Windows.Forms.Label();
            this.lblStatusNew = new System.Windows.Forms.Label();
            this.pnlLayoutTop = new System.Windows.Forms.Panel();
            this.pnlCartesianChart = new System.Windows.Forms.Panel();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.pnlTopMid = new System.Windows.Forms.Panel();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.pnlHorizDividerBot = new System.Windows.Forms.Panel();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.pnlSplash.SuspendLayout();
            this.pnlLayoutBot.SuspendLayout();
            this.pnlBotLastYear.SuspendLayout();
            this.pnlBotThisYear.SuspendLayout();
            this.pnlBotRightCorner.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlWeekFilter.SuspendLayout();
            this.pnlMonthFilter.SuspendLayout();
            this.pnlUpdateBtn.SuspendLayout();
            this.pnlLayoutMid.SuspendLayout();
            this.pnlStatusNeedInfoEmpl.SuspendLayout();
            this.pnlStatusEscalated.SuspendLayout();
            this.pnlStatusAssigned.SuspendLayout();
            this.pnlStatusNew.SuspendLayout();
            this.pnlLayoutTop.SuspendLayout();
            this.pnlCartesianChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSplash
            // 
            this.pnlSplash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSplash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlSplash.Controls.Add(this.lblDataLoading);
            this.pnlSplash.Location = new System.Drawing.Point(0, 0);
            this.pnlSplash.Name = "pnlSplash";
            this.pnlSplash.Size = new System.Drawing.Size(1716, 1026);
            this.pnlSplash.TabIndex = 1;
            // 
            // lblDataLoading
            // 
            this.lblDataLoading.AutoSize = true;
            this.lblDataLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDataLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblDataLoading.Location = new System.Drawing.Point(850, 500);
            this.lblDataLoading.Name = "lblDataLoading";
            this.lblDataLoading.Size = new System.Drawing.Size(144, 31);
            this.lblDataLoading.TabIndex = 0;
            this.lblDataLoading.Text = "Loading...";
            // 
            // pnlLayoutBot
            // 
            this.pnlLayoutBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlLayoutBot.Controls.Add(this.lblLastYearDates);
            this.pnlLayoutBot.Controls.Add(this.pnlBotLastYear);
            this.pnlLayoutBot.Controls.Add(this.pnlBotThisYear);
            this.pnlLayoutBot.Controls.Add(this.pnlBotRightCorner);
            this.pnlLayoutBot.Controls.Add(this.lblThisYearDates);
            this.pnlLayoutBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLayoutBot.Location = new System.Drawing.Point(0, 879);
            this.pnlLayoutBot.Name = "pnlLayoutBot";
            this.pnlLayoutBot.Size = new System.Drawing.Size(1716, 147);
            this.pnlLayoutBot.TabIndex = 5;
            // 
            // lblLastYearDates
            // 
            this.lblLastYearDates.AutoSize = true;
            this.lblLastYearDates.BackColor = System.Drawing.Color.Transparent;
            this.lblLastYearDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblLastYearDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblLastYearDates.Location = new System.Drawing.Point(235, 12);
            this.lblLastYearDates.Name = "lblLastYearDates";
            this.lblLastYearDates.Size = new System.Drawing.Size(0, 13);
            this.lblLastYearDates.TabIndex = 15;
            // 
            // pnlBotLastYear
            // 
            this.pnlBotLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlBotLastYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBotLastYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotLastYear.Controls.Add(this.lblClosedLastYearValue);
            this.pnlBotLastYear.Controls.Add(this.lblClosedLastYear);
            this.pnlBotLastYear.Controls.Add(this.lblCreatedLastYearValue);
            this.pnlBotLastYear.Controls.Add(this.lblCreatedLastYear);
            this.pnlBotLastYear.Location = new System.Drawing.Point(224, 36);
            this.pnlBotLastYear.Name = "pnlBotLastYear";
            this.pnlBotLastYear.Size = new System.Drawing.Size(200, 101);
            this.pnlBotLastYear.TabIndex = 14;
            // 
            // lblClosedLastYearValue
            // 
            this.lblClosedLastYearValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClosedLastYearValue.AutoSize = true;
            this.lblClosedLastYearValue.BackColor = System.Drawing.Color.Transparent;
            this.lblClosedLastYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClosedLastYearValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblClosedLastYearValue.Location = new System.Drawing.Point(105, 37);
            this.lblClosedLastYearValue.Name = "lblClosedLastYearValue";
            this.lblClosedLastYearValue.Size = new System.Drawing.Size(0, 24);
            this.lblClosedLastYearValue.TabIndex = 13;
            // 
            // lblClosedLastYear
            // 
            this.lblClosedLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClosedLastYear.AutoSize = true;
            this.lblClosedLastYear.BackColor = System.Drawing.Color.Transparent;
            this.lblClosedLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClosedLastYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblClosedLastYear.Location = new System.Drawing.Point(10, 41);
            this.lblClosedLastYear.Name = "lblClosedLastYear";
            this.lblClosedLastYear.Size = new System.Drawing.Size(79, 20);
            this.lblClosedLastYear.TabIndex = 12;
            this.lblClosedLastYear.Text = "Закрыто:";
            // 
            // lblCreatedLastYearValue
            // 
            this.lblCreatedLastYearValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreatedLastYearValue.AutoSize = true;
            this.lblCreatedLastYearValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedLastYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreatedLastYearValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblCreatedLastYearValue.Location = new System.Drawing.Point(105, 6);
            this.lblCreatedLastYearValue.Name = "lblCreatedLastYearValue";
            this.lblCreatedLastYearValue.Size = new System.Drawing.Size(0, 24);
            this.lblCreatedLastYearValue.TabIndex = 11;
            // 
            // lblCreatedLastYear
            // 
            this.lblCreatedLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreatedLastYear.AutoSize = true;
            this.lblCreatedLastYear.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreatedLastYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblCreatedLastYear.Location = new System.Drawing.Point(10, 9);
            this.lblCreatedLastYear.Name = "lblCreatedLastYear";
            this.lblCreatedLastYear.Size = new System.Drawing.Size(79, 20);
            this.lblCreatedLastYear.TabIndex = 10;
            this.lblCreatedLastYear.Text = "Создано:";
            // 
            // pnlBotThisYear
            // 
            this.pnlBotThisYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlBotThisYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBotThisYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotThisYear.Controls.Add(this.lblClosedThisYearValue);
            this.pnlBotThisYear.Controls.Add(this.lblClosedThisYear);
            this.pnlBotThisYear.Controls.Add(this.lblCreatedThisYearValue);
            this.pnlBotThisYear.Controls.Add(this.lblCreatedThisYear);
            this.pnlBotThisYear.Location = new System.Drawing.Point(10, 36);
            this.pnlBotThisYear.Name = "pnlBotThisYear";
            this.pnlBotThisYear.Size = new System.Drawing.Size(200, 101);
            this.pnlBotThisYear.TabIndex = 13;
            // 
            // lblClosedThisYearValue
            // 
            this.lblClosedThisYearValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClosedThisYearValue.AutoSize = true;
            this.lblClosedThisYearValue.BackColor = System.Drawing.Color.Transparent;
            this.lblClosedThisYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClosedThisYearValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblClosedThisYearValue.Location = new System.Drawing.Point(105, 37);
            this.lblClosedThisYearValue.Name = "lblClosedThisYearValue";
            this.lblClosedThisYearValue.Size = new System.Drawing.Size(0, 24);
            this.lblClosedThisYearValue.TabIndex = 13;
            // 
            // lblClosedThisYear
            // 
            this.lblClosedThisYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClosedThisYear.AutoSize = true;
            this.lblClosedThisYear.BackColor = System.Drawing.Color.Transparent;
            this.lblClosedThisYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClosedThisYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblClosedThisYear.Location = new System.Drawing.Point(10, 41);
            this.lblClosedThisYear.Name = "lblClosedThisYear";
            this.lblClosedThisYear.Size = new System.Drawing.Size(79, 20);
            this.lblClosedThisYear.TabIndex = 12;
            this.lblClosedThisYear.Text = "Закрыто:";
            // 
            // lblCreatedThisYearValue
            // 
            this.lblCreatedThisYearValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreatedThisYearValue.AutoSize = true;
            this.lblCreatedThisYearValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedThisYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreatedThisYearValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblCreatedThisYearValue.Location = new System.Drawing.Point(105, 6);
            this.lblCreatedThisYearValue.Name = "lblCreatedThisYearValue";
            this.lblCreatedThisYearValue.Size = new System.Drawing.Size(0, 24);
            this.lblCreatedThisYearValue.TabIndex = 11;
            // 
            // lblCreatedThisYear
            // 
            this.lblCreatedThisYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreatedThisYear.AutoSize = true;
            this.lblCreatedThisYear.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedThisYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreatedThisYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblCreatedThisYear.Location = new System.Drawing.Point(10, 9);
            this.lblCreatedThisYear.Name = "lblCreatedThisYear";
            this.lblCreatedThisYear.Size = new System.Drawing.Size(79, 20);
            this.lblCreatedThisYear.TabIndex = 10;
            this.lblCreatedThisYear.Text = "Создано:";
            // 
            // pnlBotRightCorner
            // 
            this.pnlBotRightCorner.Controls.Add(this.pnlFilters);
            this.pnlBotRightCorner.Controls.Add(this.pnlUpdateBtn);
            this.pnlBotRightCorner.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotRightCorner.Location = new System.Drawing.Point(1566, 0);
            this.pnlBotRightCorner.Name = "pnlBotRightCorner";
            this.pnlBotRightCorner.Size = new System.Drawing.Size(150, 147);
            this.pnlBotRightCorner.TabIndex = 7;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.pnlWeekFilter);
            this.pnlFilters.Controls.Add(this.pnlMonthFilter);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.Location = new System.Drawing.Point(0, 0);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(150, 74);
            this.pnlFilters.TabIndex = 3;
            // 
            // pnlWeekFilter
            // 
            this.pnlWeekFilter.Controls.Add(this.btnWeek);
            this.pnlWeekFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlWeekFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlWeekFilter.Name = "pnlWeekFilter";
            this.pnlWeekFilter.Size = new System.Drawing.Size(75, 74);
            this.pnlWeekFilter.TabIndex = 1;
            // 
            // btnWeek
            // 
            this.btnWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnWeek.Check = false;
            this.btnWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWeek.FlatAppearance.BorderSize = 0;
            this.btnWeek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnWeek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.btnWeek.Location = new System.Drawing.Point(0, 0);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(75, 74);
            this.btnWeek.TabIndex = 3;
            this.btnWeek.Text = "   week";
            this.btnWeek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeek.UseVisualStyleBackColor = false;
            this.btnWeek.Click += new System.EventHandler(this.FilterBtnClick);
            // 
            // pnlMonthFilter
            // 
            this.pnlMonthFilter.Controls.Add(this.btnMonth);
            this.pnlMonthFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMonthFilter.Location = new System.Drawing.Point(75, 0);
            this.pnlMonthFilter.Name = "pnlMonthFilter";
            this.pnlMonthFilter.Size = new System.Drawing.Size(75, 74);
            this.pnlMonthFilter.TabIndex = 0;
            // 
            // btnMonth
            // 
            this.btnMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnMonth.Check = false;
            this.btnMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMonth.FlatAppearance.BorderSize = 0;
            this.btnMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.btnMonth.Location = new System.Drawing.Point(0, 0);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(75, 74);
            this.btnMonth.TabIndex = 2;
            this.btnMonth.Text = " month";
            this.btnMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonth.UseVisualStyleBackColor = false;
            this.btnMonth.Click += new System.EventHandler(this.FilterBtnClick);
            // 
            // pnlUpdateBtn
            // 
            this.pnlUpdateBtn.Controls.Add(this.btnUpdateData);
            this.pnlUpdateBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpdateBtn.Location = new System.Drawing.Point(0, 74);
            this.pnlUpdateBtn.Name = "pnlUpdateBtn";
            this.pnlUpdateBtn.Size = new System.Drawing.Size(150, 73);
            this.pnlUpdateBtn.TabIndex = 2;
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnUpdateData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateData.FlatAppearance.BorderSize = 0;
            this.btnUpdateData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnUpdateData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.btnUpdateData.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(150, 73);
            this.btnUpdateData.TabIndex = 1;
            this.btnUpdateData.Text = "   UPDATE";
            this.btnUpdateData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateData.UseVisualStyleBackColor = false;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // lblThisYearDates
            // 
            this.lblThisYearDates.AutoSize = true;
            this.lblThisYearDates.BackColor = System.Drawing.Color.Transparent;
            this.lblThisYearDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblThisYearDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblThisYearDates.Location = new System.Drawing.Point(20, 12);
            this.lblThisYearDates.Name = "lblThisYearDates";
            this.lblThisYearDates.Size = new System.Drawing.Size(0, 13);
            this.lblThisYearDates.TabIndex = 5;
            // 
            // lblStatusAssigned
            // 
            this.lblStatusAssigned.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusAssigned.AutoSize = true;
            this.lblStatusAssigned.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusAssigned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblStatusAssigned.Location = new System.Drawing.Point(10, 10);
            this.lblStatusAssigned.Name = "lblStatusAssigned";
            this.lblStatusAssigned.Size = new System.Drawing.Size(100, 20);
            this.lblStatusAssigned.TabIndex = 8;
            this.lblStatusAssigned.Text = "Назначена: ";
            // 
            // pnlLayoutMid
            // 
            this.pnlLayoutMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlLayoutMid.Controls.Add(this.pnlStatusNeedInfoEmpl);
            this.pnlLayoutMid.Controls.Add(this.lblPnlStatusHeader);
            this.pnlLayoutMid.Controls.Add(this.pnlStatusEscalated);
            this.pnlLayoutMid.Controls.Add(this.pnlStatusAssigned);
            this.pnlLayoutMid.Controls.Add(this.pnlStatusNew);
            this.pnlLayoutMid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLayoutMid.Location = new System.Drawing.Point(0, 728);
            this.pnlLayoutMid.Name = "pnlLayoutMid";
            this.pnlLayoutMid.Size = new System.Drawing.Size(1716, 147);
            this.pnlLayoutMid.TabIndex = 6;
            // 
            // pnlStatusNeedInfoEmpl
            // 
            this.pnlStatusNeedInfoEmpl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlStatusNeedInfoEmpl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlStatusNeedInfoEmpl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pnlStatusNeedInfoEmpl.Controls.Add(this.lblStatusNeedInfoEmplValue);
            this.pnlStatusNeedInfoEmpl.Controls.Add(this.label2);
            this.pnlStatusNeedInfoEmpl.Location = new System.Drawing.Point(640, 34);
            this.pnlStatusNeedInfoEmpl.Name = "pnlStatusNeedInfoEmpl";
            this.pnlStatusNeedInfoEmpl.Size = new System.Drawing.Size(200, 101);
            this.pnlStatusNeedInfoEmpl.TabIndex = 14;
            // 
            // lblStatusNeedInfoEmplValue
            // 
            this.lblStatusNeedInfoEmplValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusNeedInfoEmplValue.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusNeedInfoEmplValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusNeedInfoEmplValue.ForeColor = System.Drawing.Color.Black;
            this.lblStatusNeedInfoEmplValue.Location = new System.Drawing.Point(0, 40);
            this.lblStatusNeedInfoEmplValue.Name = "lblStatusNeedInfoEmplValue";
            this.lblStatusNeedInfoEmplValue.Size = new System.Drawing.Size(200, 35);
            this.lblStatusNeedInfoEmplValue.TabIndex = 10;
            this.lblStatusNeedInfoEmplValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Нужна информация (Сотр.): ";
            // 
            // lblPnlStatusHeader
            // 
            this.lblPnlStatusHeader.AutoSize = true;
            this.lblPnlStatusHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblPnlStatusHeader.Location = new System.Drawing.Point(13, 7);
            this.lblPnlStatusHeader.Name = "lblPnlStatusHeader";
            this.lblPnlStatusHeader.Size = new System.Drawing.Size(81, 13);
            this.lblPnlStatusHeader.TabIndex = 14;
            this.lblPnlStatusHeader.Text = "Статусы задач";
            // 
            // pnlStatusEscalated
            // 
            this.pnlStatusEscalated.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlStatusEscalated.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlStatusEscalated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(182)))), ((int)(((byte)(131)))));
            this.pnlStatusEscalated.Controls.Add(this.lblStatusEscalatedValue);
            this.pnlStatusEscalated.Controls.Add(this.lblStatusEscalated);
            this.pnlStatusEscalated.Location = new System.Drawing.Point(430, 34);
            this.pnlStatusEscalated.Name = "pnlStatusEscalated";
            this.pnlStatusEscalated.Size = new System.Drawing.Size(200, 101);
            this.pnlStatusEscalated.TabIndex = 13;
            // 
            // lblStatusEscalatedValue
            // 
            this.lblStatusEscalatedValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusEscalatedValue.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusEscalatedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusEscalatedValue.ForeColor = System.Drawing.Color.Black;
            this.lblStatusEscalatedValue.Location = new System.Drawing.Point(0, 40);
            this.lblStatusEscalatedValue.Name = "lblStatusEscalatedValue";
            this.lblStatusEscalatedValue.Size = new System.Drawing.Size(200, 35);
            this.lblStatusEscalatedValue.TabIndex = 10;
            this.lblStatusEscalatedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusEscalated
            // 
            this.lblStatusEscalated.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusEscalated.AutoSize = true;
            this.lblStatusEscalated.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusEscalated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusEscalated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblStatusEscalated.Location = new System.Drawing.Point(10, 10);
            this.lblStatusEscalated.Name = "lblStatusEscalated";
            this.lblStatusEscalated.Size = new System.Drawing.Size(127, 20);
            this.lblStatusEscalated.TabIndex = 8;
            this.lblStatusEscalated.Text = "Эскалирована: ";
            // 
            // pnlStatusAssigned
            // 
            this.pnlStatusAssigned.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlStatusAssigned.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlStatusAssigned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.pnlStatusAssigned.Controls.Add(this.lblStatusAssignedValue);
            this.pnlStatusAssigned.Controls.Add(this.lblStatusAssigned);
            this.pnlStatusAssigned.Location = new System.Drawing.Point(220, 34);
            this.pnlStatusAssigned.Name = "pnlStatusAssigned";
            this.pnlStatusAssigned.Size = new System.Drawing.Size(200, 101);
            this.pnlStatusAssigned.TabIndex = 12;
            // 
            // lblStatusAssignedValue
            // 
            this.lblStatusAssignedValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusAssignedValue.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusAssignedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusAssignedValue.ForeColor = System.Drawing.Color.Black;
            this.lblStatusAssignedValue.Location = new System.Drawing.Point(0, 40);
            this.lblStatusAssignedValue.Name = "lblStatusAssignedValue";
            this.lblStatusAssignedValue.Size = new System.Drawing.Size(200, 35);
            this.lblStatusAssignedValue.TabIndex = 10;
            this.lblStatusAssignedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStatusNew
            // 
            this.pnlStatusNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlStatusNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlStatusNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.pnlStatusNew.Controls.Add(this.lblStatusNewValue);
            this.pnlStatusNew.Controls.Add(this.lblStatusNew);
            this.pnlStatusNew.Location = new System.Drawing.Point(10, 34);
            this.pnlStatusNew.Name = "pnlStatusNew";
            this.pnlStatusNew.Size = new System.Drawing.Size(200, 101);
            this.pnlStatusNew.TabIndex = 11;
            // 
            // lblStatusNewValue
            // 
            this.lblStatusNewValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusNewValue.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusNewValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusNewValue.ForeColor = System.Drawing.Color.Black;
            this.lblStatusNewValue.Location = new System.Drawing.Point(0, 40);
            this.lblStatusNewValue.Name = "lblStatusNewValue";
            this.lblStatusNewValue.Size = new System.Drawing.Size(200, 35);
            this.lblStatusNewValue.TabIndex = 11;
            this.lblStatusNewValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusNew
            // 
            this.lblStatusNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusNew.AutoSize = true;
            this.lblStatusNew.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblStatusNew.Location = new System.Drawing.Point(10, 10);
            this.lblStatusNew.Name = "lblStatusNew";
            this.lblStatusNew.Size = new System.Drawing.Size(65, 20);
            this.lblStatusNew.TabIndex = 10;
            this.lblStatusNew.Text = "Новая: ";
            // 
            // pnlLayoutTop
            // 
            this.pnlLayoutTop.Controls.Add(this.pnlCartesianChart);
            this.pnlLayoutTop.Controls.Add(this.pnlTopMid);
            this.pnlLayoutTop.Controls.Add(this.pnlTopRight);
            this.pnlLayoutTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayoutTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLayoutTop.Name = "pnlLayoutTop";
            this.pnlLayoutTop.Size = new System.Drawing.Size(1716, 728);
            this.pnlLayoutTop.TabIndex = 7;
            // 
            // pnlCartesianChart
            // 
            this.pnlCartesianChart.Controls.Add(this.cartesianChart);
            this.pnlCartesianChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCartesianChart.Location = new System.Drawing.Point(0, 0);
            this.pnlCartesianChart.Name = "pnlCartesianChart";
            this.pnlCartesianChart.Size = new System.Drawing.Size(1240, 728);
            this.pnlCartesianChart.TabIndex = 3;
            // 
            // cartesianChart
            // 
            this.cartesianChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartesianChart.ForeColor = System.Drawing.SystemColors.Control;
            this.cartesianChart.Location = new System.Drawing.Point(10, 3);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Padding = new System.Windows.Forms.Padding(3);
            this.cartesianChart.Size = new System.Drawing.Size(1220, 719);
            this.cartesianChart.TabIndex = 0;
            this.cartesianChart.TabStop = false;
            // 
            // pnlTopMid
            // 
            this.pnlTopMid.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopMid.Location = new System.Drawing.Point(1240, 0);
            this.pnlTopMid.Name = "pnlTopMid";
            this.pnlTopMid.Size = new System.Drawing.Size(210, 728);
            this.pnlTopMid.TabIndex = 6;
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopRight.Location = new System.Drawing.Point(1450, 0);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(266, 728);
            this.pnlTopRight.TabIndex = 4;
            // 
            // pnlHorizDividerBot
            // 
            this.pnlHorizDividerBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.pnlHorizDividerBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHorizDividerBot.Location = new System.Drawing.Point(0, 875);
            this.pnlHorizDividerBot.Name = "pnlHorizDividerBot";
            this.pnlHorizDividerBot.Size = new System.Drawing.Size(1716, 4);
            this.pnlHorizDividerBot.TabIndex = 9;
            // 
            // tmrSplash
            // 
            this.tmrSplash.Interval = 1000;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // DashboardIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.pnlSplash);
            this.Controls.Add(this.pnlLayoutTop);
            this.Controls.Add(this.pnlLayoutMid);
            this.Controls.Add(this.pnlHorizDividerBot);
            this.Controls.Add(this.pnlLayoutBot);
            this.Name = "DashboardIssues";
            this.Size = new System.Drawing.Size(1716, 1026);
            this.Load += new System.EventHandler(this.TSDashboard_Load);
            this.pnlSplash.ResumeLayout(false);
            this.pnlSplash.PerformLayout();
            this.pnlLayoutBot.ResumeLayout(false);
            this.pnlLayoutBot.PerformLayout();
            this.pnlBotLastYear.ResumeLayout(false);
            this.pnlBotLastYear.PerformLayout();
            this.pnlBotThisYear.ResumeLayout(false);
            this.pnlBotThisYear.PerformLayout();
            this.pnlBotRightCorner.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlWeekFilter.ResumeLayout(false);
            this.pnlMonthFilter.ResumeLayout(false);
            this.pnlUpdateBtn.ResumeLayout(false);
            this.pnlLayoutMid.ResumeLayout(false);
            this.pnlLayoutMid.PerformLayout();
            this.pnlStatusNeedInfoEmpl.ResumeLayout(false);
            this.pnlStatusNeedInfoEmpl.PerformLayout();
            this.pnlStatusEscalated.ResumeLayout(false);
            this.pnlStatusEscalated.PerformLayout();
            this.pnlStatusAssigned.ResumeLayout(false);
            this.pnlStatusAssigned.PerformLayout();
            this.pnlStatusNew.ResumeLayout(false);
            this.pnlStatusNew.PerformLayout();
            this.pnlLayoutTop.ResumeLayout(false);
            this.pnlCartesianChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLayoutBot;
        private System.Windows.Forms.Label lblThisYearDates;
        private System.Windows.Forms.Label lblStatusAssigned;
        private System.Windows.Forms.Panel pnlLayoutMid;
        private System.Windows.Forms.Panel pnlLayoutTop;
        private System.Windows.Forms.Panel pnlCartesianChart;
        public LiveCharts.WinForms.CartesianChart cartesianChart;
        private System.Windows.Forms.Panel pnlBotRightCorner;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Panel pnlUpdateBtn;
        private System.Windows.Forms.Panel pnlWeekFilter;
        private TrackerHelper.CheckedButton btnWeek;
        private System.Windows.Forms.Panel pnlMonthFilter;
        private TrackerHelper.CheckedButton btnMonth;
        private System.Windows.Forms.Panel pnlTopRight;
        private System.Windows.Forms.Panel pnlHorizDividerBot;
        private System.Windows.Forms.Label lblStatusNew;
        private System.Windows.Forms.Panel pnlStatusNew;
        private System.Windows.Forms.Label lblStatusNewValue;
        private System.Windows.Forms.Panel pnlStatusAssigned;
        private System.Windows.Forms.Label lblStatusAssignedValue;
        private System.Windows.Forms.Panel pnlStatusEscalated;
        private System.Windows.Forms.Label lblStatusEscalatedValue;
        private System.Windows.Forms.Label lblStatusEscalated;
        private System.Windows.Forms.Label lblPnlStatusHeader;
        private System.Windows.Forms.Panel pnlTopMid;
        private System.Windows.Forms.Panel pnlBotLastYear;
        private System.Windows.Forms.Label lblClosedLastYearValue;
        private System.Windows.Forms.Label lblClosedLastYear;
        private System.Windows.Forms.Label lblCreatedLastYearValue;
        private System.Windows.Forms.Label lblCreatedLastYear;
        private System.Windows.Forms.Panel pnlBotThisYear;
        private System.Windows.Forms.Label lblClosedThisYearValue;
        private System.Windows.Forms.Label lblClosedThisYear;
        private System.Windows.Forms.Label lblCreatedThisYearValue;
        private System.Windows.Forms.Label lblCreatedThisYear;
        private System.Windows.Forms.Label lblLastYearDates;
        private System.Windows.Forms.Panel pnlStatusNeedInfoEmpl;
        private System.Windows.Forms.Label lblStatusNeedInfoEmplValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlSplash;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.Label lblDataLoading;
    }
}
