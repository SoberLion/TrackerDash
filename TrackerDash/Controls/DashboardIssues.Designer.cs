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
            this.lblMonthThisYearDates = new System.Windows.Forms.Label();
            this.lblMonthLastYearDates = new System.Windows.Forms.Label();
            this.pnlMonthLastYear = new System.Windows.Forms.Panel();
            this.lblClosedMonthLastYearValue = new System.Windows.Forms.Label();
            this.lblClosedMonthLastYear = new System.Windows.Forms.Label();
            this.lblCreatedMonthLastYearValue = new System.Windows.Forms.Label();
            this.lblCreatedMonthLastYear = new System.Windows.Forms.Label();
            this.pnlMonthThisYear = new System.Windows.Forms.Panel();
            this.lblClosedMonthThisYearValue = new System.Windows.Forms.Label();
            this.lblClosedMonthThisYear = new System.Windows.Forms.Label();
            this.lblCreatedMonthThisYearValue = new System.Windows.Forms.Label();
            this.lblCreatedMonthThisYear = new System.Windows.Forms.Label();
            this.lblWeekLastYearDates = new System.Windows.Forms.Label();
            this.pnlWeekLastYear = new System.Windows.Forms.Panel();
            this.lblClosedWeekLastYearValue = new System.Windows.Forms.Label();
            this.lblClosedWeekLastYear = new System.Windows.Forms.Label();
            this.lblCreatedWeekLastYearValue = new System.Windows.Forms.Label();
            this.lblCreatedWeekLastYear = new System.Windows.Forms.Label();
            this.pnlWeekThisYear = new System.Windows.Forms.Panel();
            this.lblClosedWeekThisYearValue = new System.Windows.Forms.Label();
            this.lblClosedWeekThisYear = new System.Windows.Forms.Label();
            this.lblCreatedWeekThisYearValue = new System.Windows.Forms.Label();
            this.lblCreatedWeekThisYear = new System.Windows.Forms.Label();
            this.lblWeekThisYearDates = new System.Windows.Forms.Label();
            this.lblStatusAssigned = new System.Windows.Forms.Label();
            this.pnlLayoutMid = new System.Windows.Forms.Panel();
            this.pnlStatusNeedInfoEmpl = new System.Windows.Forms.Panel();
            this.lblStatusNeedInfoEmplValue = new System.Windows.Forms.Label();
            this.lblStatusNeedInfoEmpl = new System.Windows.Forms.Label();
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
            this.pnlMonthLastYear.SuspendLayout();
            this.pnlMonthThisYear.SuspendLayout();
            this.pnlWeekLastYear.SuspendLayout();
            this.pnlWeekThisYear.SuspendLayout();
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
            this.pnlLayoutBot.Controls.Add(this.lblMonthThisYearDates);
            this.pnlLayoutBot.Controls.Add(this.lblMonthLastYearDates);
            this.pnlLayoutBot.Controls.Add(this.pnlMonthLastYear);
            this.pnlLayoutBot.Controls.Add(this.pnlMonthThisYear);
            this.pnlLayoutBot.Controls.Add(this.lblWeekLastYearDates);
            this.pnlLayoutBot.Controls.Add(this.pnlWeekLastYear);
            this.pnlLayoutBot.Controls.Add(this.pnlWeekThisYear);
            this.pnlLayoutBot.Controls.Add(this.lblWeekThisYearDates);
            this.pnlLayoutBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLayoutBot.Location = new System.Drawing.Point(0, 879);
            this.pnlLayoutBot.Name = "pnlLayoutBot";
            this.pnlLayoutBot.Size = new System.Drawing.Size(1716, 147);
            this.pnlLayoutBot.TabIndex = 5;
            // 
            // lblMonthThisYearDates
            // 
            this.lblMonthThisYearDates.AutoSize = true;
            this.lblMonthThisYearDates.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthThisYearDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMonthThisYearDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblMonthThisYearDates.Location = new System.Drawing.Point(445, 12);
            this.lblMonthThisYearDates.Name = "lblMonthThisYearDates";
            this.lblMonthThisYearDates.Size = new System.Drawing.Size(0, 13);
            this.lblMonthThisYearDates.TabIndex = 18;
            // 
            // lblMonthLastYearDates
            // 
            this.lblMonthLastYearDates.AutoSize = true;
            this.lblMonthLastYearDates.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthLastYearDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMonthLastYearDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblMonthLastYearDates.Location = new System.Drawing.Point(655, 12);
            this.lblMonthLastYearDates.Name = "lblMonthLastYearDates";
            this.lblMonthLastYearDates.Size = new System.Drawing.Size(0, 13);
            this.lblMonthLastYearDates.TabIndex = 17;
            // 
            // pnlMonthLastYear
            // 
            this.pnlMonthLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlMonthLastYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMonthLastYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMonthLastYear.Controls.Add(this.lblClosedMonthLastYearValue);
            this.pnlMonthLastYear.Controls.Add(this.lblClosedMonthLastYear);
            this.pnlMonthLastYear.Controls.Add(this.lblCreatedMonthLastYearValue);
            this.pnlMonthLastYear.Controls.Add(this.lblCreatedMonthLastYear);
            this.pnlMonthLastYear.Location = new System.Drawing.Point(640, 36);
            this.pnlMonthLastYear.Name = "pnlMonthLastYear";
            this.pnlMonthLastYear.Size = new System.Drawing.Size(200, 101);
            this.pnlMonthLastYear.TabIndex = 16;
            // 
            // lblClosedMonthLastYearValue
            // 
            this.lblClosedMonthLastYearValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClosedMonthLastYearValue.AutoSize = true;
            this.lblClosedMonthLastYearValue.BackColor = System.Drawing.Color.Transparent;
            this.lblClosedMonthLastYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClosedMonthLastYearValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblClosedMonthLastYearValue.Location = new System.Drawing.Point(105, 37);
            this.lblClosedMonthLastYearValue.Name = "lblClosedMonthLastYearValue";
            this.lblClosedMonthLastYearValue.Size = new System.Drawing.Size(0, 24);
            this.lblClosedMonthLastYearValue.TabIndex = 13;
            // 
            // lblClosedMonthLastYear
            // 
            this.lblClosedMonthLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClosedMonthLastYear.AutoSize = true;
            this.lblClosedMonthLastYear.BackColor = System.Drawing.Color.Transparent;
            this.lblClosedMonthLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClosedMonthLastYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblClosedMonthLastYear.Location = new System.Drawing.Point(10, 41);
            this.lblClosedMonthLastYear.Name = "lblClosedMonthLastYear";
            this.lblClosedMonthLastYear.Size = new System.Drawing.Size(79, 20);
            this.lblClosedMonthLastYear.TabIndex = 12;
            this.lblClosedMonthLastYear.Text = "Закрыто:";
            // 
            // lblCreatedMonthLastYearValue
            // 
            this.lblCreatedMonthLastYearValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreatedMonthLastYearValue.AutoSize = true;
            this.lblCreatedMonthLastYearValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedMonthLastYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreatedMonthLastYearValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblCreatedMonthLastYearValue.Location = new System.Drawing.Point(105, 6);
            this.lblCreatedMonthLastYearValue.Name = "lblCreatedMonthLastYearValue";
            this.lblCreatedMonthLastYearValue.Size = new System.Drawing.Size(0, 24);
            this.lblCreatedMonthLastYearValue.TabIndex = 11;
            // 
            // lblCreatedMonthLastYear
            // 
            this.lblCreatedMonthLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreatedMonthLastYear.AutoSize = true;
            this.lblCreatedMonthLastYear.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedMonthLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreatedMonthLastYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblCreatedMonthLastYear.Location = new System.Drawing.Point(10, 9);
            this.lblCreatedMonthLastYear.Name = "lblCreatedMonthLastYear";
            this.lblCreatedMonthLastYear.Size = new System.Drawing.Size(79, 20);
            this.lblCreatedMonthLastYear.TabIndex = 10;
            this.lblCreatedMonthLastYear.Text = "Создано:";
            // 
            // pnlMonthThisYear
            // 
            this.pnlMonthThisYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlMonthThisYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMonthThisYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMonthThisYear.Controls.Add(this.lblClosedMonthThisYearValue);
            this.pnlMonthThisYear.Controls.Add(this.lblClosedMonthThisYear);
            this.pnlMonthThisYear.Controls.Add(this.lblCreatedMonthThisYearValue);
            this.pnlMonthThisYear.Controls.Add(this.lblCreatedMonthThisYear);
            this.pnlMonthThisYear.Location = new System.Drawing.Point(430, 36);
            this.pnlMonthThisYear.Name = "pnlMonthThisYear";
            this.pnlMonthThisYear.Size = new System.Drawing.Size(200, 101);
            this.pnlMonthThisYear.TabIndex = 16;
            // 
            // lblClosedMonthThisYearValue
            // 
            this.lblClosedMonthThisYearValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClosedMonthThisYearValue.AutoSize = true;
            this.lblClosedMonthThisYearValue.BackColor = System.Drawing.Color.Transparent;
            this.lblClosedMonthThisYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClosedMonthThisYearValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblClosedMonthThisYearValue.Location = new System.Drawing.Point(105, 37);
            this.lblClosedMonthThisYearValue.Name = "lblClosedMonthThisYearValue";
            this.lblClosedMonthThisYearValue.Size = new System.Drawing.Size(0, 24);
            this.lblClosedMonthThisYearValue.TabIndex = 13;
            // 
            // lblClosedMonthThisYear
            // 
            this.lblClosedMonthThisYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClosedMonthThisYear.AutoSize = true;
            this.lblClosedMonthThisYear.BackColor = System.Drawing.Color.Transparent;
            this.lblClosedMonthThisYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClosedMonthThisYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblClosedMonthThisYear.Location = new System.Drawing.Point(10, 41);
            this.lblClosedMonthThisYear.Name = "lblClosedMonthThisYear";
            this.lblClosedMonthThisYear.Size = new System.Drawing.Size(79, 20);
            this.lblClosedMonthThisYear.TabIndex = 12;
            this.lblClosedMonthThisYear.Text = "Закрыто:";
            // 
            // lblCreatedMonthThisYearValue
            // 
            this.lblCreatedMonthThisYearValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreatedMonthThisYearValue.AutoSize = true;
            this.lblCreatedMonthThisYearValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedMonthThisYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreatedMonthThisYearValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblCreatedMonthThisYearValue.Location = new System.Drawing.Point(105, 6);
            this.lblCreatedMonthThisYearValue.Name = "lblCreatedMonthThisYearValue";
            this.lblCreatedMonthThisYearValue.Size = new System.Drawing.Size(0, 24);
            this.lblCreatedMonthThisYearValue.TabIndex = 11;
            // 
            // lblCreatedMonthThisYear
            // 
            this.lblCreatedMonthThisYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreatedMonthThisYear.AutoSize = true;
            this.lblCreatedMonthThisYear.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedMonthThisYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreatedMonthThisYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblCreatedMonthThisYear.Location = new System.Drawing.Point(10, 9);
            this.lblCreatedMonthThisYear.Name = "lblCreatedMonthThisYear";
            this.lblCreatedMonthThisYear.Size = new System.Drawing.Size(79, 20);
            this.lblCreatedMonthThisYear.TabIndex = 10;
            this.lblCreatedMonthThisYear.Text = "Создано:";
            // 
            // lblWeekLastYearDates
            // 
            this.lblWeekLastYearDates.AutoSize = true;
            this.lblWeekLastYearDates.BackColor = System.Drawing.Color.Transparent;
            this.lblWeekLastYearDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblWeekLastYearDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblWeekLastYearDates.Location = new System.Drawing.Point(235, 12);
            this.lblWeekLastYearDates.Name = "lblWeekLastYearDates";
            this.lblWeekLastYearDates.Size = new System.Drawing.Size(0, 13);
            this.lblWeekLastYearDates.TabIndex = 15;
            // 
            // pnlWeekLastYear
            // 
            this.pnlWeekLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlWeekLastYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlWeekLastYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWeekLastYear.Controls.Add(this.lblClosedWeekLastYearValue);
            this.pnlWeekLastYear.Controls.Add(this.lblClosedWeekLastYear);
            this.pnlWeekLastYear.Controls.Add(this.lblCreatedWeekLastYearValue);
            this.pnlWeekLastYear.Controls.Add(this.lblCreatedWeekLastYear);
            this.pnlWeekLastYear.Location = new System.Drawing.Point(220, 36);
            this.pnlWeekLastYear.Name = "pnlWeekLastYear";
            this.pnlWeekLastYear.Size = new System.Drawing.Size(200, 101);
            this.pnlWeekLastYear.TabIndex = 14;
            // 
            // lblClosedWeekLastYearValue
            // 
            this.lblClosedWeekLastYearValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClosedWeekLastYearValue.AutoSize = true;
            this.lblClosedWeekLastYearValue.BackColor = System.Drawing.Color.Transparent;
            this.lblClosedWeekLastYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClosedWeekLastYearValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblClosedWeekLastYearValue.Location = new System.Drawing.Point(105, 37);
            this.lblClosedWeekLastYearValue.Name = "lblClosedWeekLastYearValue";
            this.lblClosedWeekLastYearValue.Size = new System.Drawing.Size(0, 24);
            this.lblClosedWeekLastYearValue.TabIndex = 13;
            // 
            // lblClosedWeekLastYear
            // 
            this.lblClosedWeekLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClosedWeekLastYear.AutoSize = true;
            this.lblClosedWeekLastYear.BackColor = System.Drawing.Color.Transparent;
            this.lblClosedWeekLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClosedWeekLastYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblClosedWeekLastYear.Location = new System.Drawing.Point(10, 41);
            this.lblClosedWeekLastYear.Name = "lblClosedWeekLastYear";
            this.lblClosedWeekLastYear.Size = new System.Drawing.Size(79, 20);
            this.lblClosedWeekLastYear.TabIndex = 12;
            this.lblClosedWeekLastYear.Text = "Закрыто:";
            // 
            // lblCreatedWeekLastYearValue
            // 
            this.lblCreatedWeekLastYearValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreatedWeekLastYearValue.AutoSize = true;
            this.lblCreatedWeekLastYearValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedWeekLastYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreatedWeekLastYearValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblCreatedWeekLastYearValue.Location = new System.Drawing.Point(105, 6);
            this.lblCreatedWeekLastYearValue.Name = "lblCreatedWeekLastYearValue";
            this.lblCreatedWeekLastYearValue.Size = new System.Drawing.Size(0, 24);
            this.lblCreatedWeekLastYearValue.TabIndex = 11;
            // 
            // lblCreatedWeekLastYear
            // 
            this.lblCreatedWeekLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreatedWeekLastYear.AutoSize = true;
            this.lblCreatedWeekLastYear.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedWeekLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreatedWeekLastYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblCreatedWeekLastYear.Location = new System.Drawing.Point(10, 9);
            this.lblCreatedWeekLastYear.Name = "lblCreatedWeekLastYear";
            this.lblCreatedWeekLastYear.Size = new System.Drawing.Size(79, 20);
            this.lblCreatedWeekLastYear.TabIndex = 10;
            this.lblCreatedWeekLastYear.Text = "Создано:";
            // 
            // pnlWeekThisYear
            // 
            this.pnlWeekThisYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlWeekThisYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlWeekThisYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWeekThisYear.Controls.Add(this.lblClosedWeekThisYearValue);
            this.pnlWeekThisYear.Controls.Add(this.lblClosedWeekThisYear);
            this.pnlWeekThisYear.Controls.Add(this.lblCreatedWeekThisYearValue);
            this.pnlWeekThisYear.Controls.Add(this.lblCreatedWeekThisYear);
            this.pnlWeekThisYear.Location = new System.Drawing.Point(10, 36);
            this.pnlWeekThisYear.Name = "pnlWeekThisYear";
            this.pnlWeekThisYear.Size = new System.Drawing.Size(200, 101);
            this.pnlWeekThisYear.TabIndex = 13;
            // 
            // lblClosedWeekThisYearValue
            // 
            this.lblClosedWeekThisYearValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClosedWeekThisYearValue.AutoSize = true;
            this.lblClosedWeekThisYearValue.BackColor = System.Drawing.Color.Transparent;
            this.lblClosedWeekThisYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClosedWeekThisYearValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblClosedWeekThisYearValue.Location = new System.Drawing.Point(105, 37);
            this.lblClosedWeekThisYearValue.Name = "lblClosedWeekThisYearValue";
            this.lblClosedWeekThisYearValue.Size = new System.Drawing.Size(0, 24);
            this.lblClosedWeekThisYearValue.TabIndex = 13;
            // 
            // lblClosedWeekThisYear
            // 
            this.lblClosedWeekThisYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClosedWeekThisYear.AutoSize = true;
            this.lblClosedWeekThisYear.BackColor = System.Drawing.Color.Transparent;
            this.lblClosedWeekThisYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClosedWeekThisYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblClosedWeekThisYear.Location = new System.Drawing.Point(10, 41);
            this.lblClosedWeekThisYear.Name = "lblClosedWeekThisYear";
            this.lblClosedWeekThisYear.Size = new System.Drawing.Size(79, 20);
            this.lblClosedWeekThisYear.TabIndex = 12;
            this.lblClosedWeekThisYear.Text = "Закрыто:";
            // 
            // lblCreatedWeekThisYearValue
            // 
            this.lblCreatedWeekThisYearValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreatedWeekThisYearValue.AutoSize = true;
            this.lblCreatedWeekThisYearValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedWeekThisYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreatedWeekThisYearValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblCreatedWeekThisYearValue.Location = new System.Drawing.Point(105, 6);
            this.lblCreatedWeekThisYearValue.Name = "lblCreatedWeekThisYearValue";
            this.lblCreatedWeekThisYearValue.Size = new System.Drawing.Size(0, 24);
            this.lblCreatedWeekThisYearValue.TabIndex = 11;
            // 
            // lblCreatedWeekThisYear
            // 
            this.lblCreatedWeekThisYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreatedWeekThisYear.AutoSize = true;
            this.lblCreatedWeekThisYear.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedWeekThisYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreatedWeekThisYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblCreatedWeekThisYear.Location = new System.Drawing.Point(10, 9);
            this.lblCreatedWeekThisYear.Name = "lblCreatedWeekThisYear";
            this.lblCreatedWeekThisYear.Size = new System.Drawing.Size(79, 20);
            this.lblCreatedWeekThisYear.TabIndex = 10;
            this.lblCreatedWeekThisYear.Text = "Создано:";
            // 
            // lblWeekThisYearDates
            // 
            this.lblWeekThisYearDates.AutoSize = true;
            this.lblWeekThisYearDates.BackColor = System.Drawing.Color.Transparent;
            this.lblWeekThisYearDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblWeekThisYearDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblWeekThisYearDates.Location = new System.Drawing.Point(25, 12);
            this.lblWeekThisYearDates.Name = "lblWeekThisYearDates";
            this.lblWeekThisYearDates.Size = new System.Drawing.Size(0, 13);
            this.lblWeekThisYearDates.TabIndex = 5;
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
            this.pnlLayoutMid.Controls.Add(this.pnlSplash);
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
            this.pnlStatusNeedInfoEmpl.Controls.Add(this.lblStatusNeedInfoEmpl);
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
            // lblStatusNeedInfoEmpl
            // 
            this.lblStatusNeedInfoEmpl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusNeedInfoEmpl.AutoSize = true;
            this.lblStatusNeedInfoEmpl.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusNeedInfoEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusNeedInfoEmpl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblStatusNeedInfoEmpl.Location = new System.Drawing.Point(11, 12);
            this.lblStatusNeedInfoEmpl.Name = "lblStatusNeedInfoEmpl";
            this.lblStatusNeedInfoEmpl.Size = new System.Drawing.Size(189, 16);
            this.lblStatusNeedInfoEmpl.TabIndex = 8;
            this.lblStatusNeedInfoEmpl.Text = "Нужна информация (Сотр.): ";
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
            this.cartesianChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.Controls.Add(this.pnlLayoutTop);
            this.Controls.Add(this.pnlLayoutMid);
            this.Controls.Add(this.pnlHorizDividerBot);
            this.Controls.Add(this.pnlLayoutBot);
            this.Name = "DashboardIssues";
            this.Size = new System.Drawing.Size(1716, 1026);
            this.pnlSplash.ResumeLayout(false);
            this.pnlSplash.PerformLayout();
            this.pnlLayoutBot.ResumeLayout(false);
            this.pnlLayoutBot.PerformLayout();
            this.pnlMonthLastYear.ResumeLayout(false);
            this.pnlMonthLastYear.PerformLayout();
            this.pnlMonthThisYear.ResumeLayout(false);
            this.pnlMonthThisYear.PerformLayout();
            this.pnlWeekLastYear.ResumeLayout(false);
            this.pnlWeekLastYear.PerformLayout();
            this.pnlWeekThisYear.ResumeLayout(false);
            this.pnlWeekThisYear.PerformLayout();
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
        private System.Windows.Forms.Label lblWeekThisYearDates;
        private System.Windows.Forms.Label lblStatusAssigned;
        private System.Windows.Forms.Panel pnlLayoutMid;
        private System.Windows.Forms.Panel pnlLayoutTop;
        private System.Windows.Forms.Panel pnlCartesianChart;
        public LiveCharts.WinForms.CartesianChart cartesianChart;
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
        private System.Windows.Forms.Panel pnlWeekLastYear;
        private System.Windows.Forms.Label lblClosedWeekLastYearValue;
        private System.Windows.Forms.Label lblClosedWeekLastYear;
        private System.Windows.Forms.Label lblCreatedWeekLastYearValue;
        private System.Windows.Forms.Label lblCreatedWeekLastYear;
        private System.Windows.Forms.Panel pnlWeekThisYear;
        private System.Windows.Forms.Label lblClosedWeekThisYearValue;
        private System.Windows.Forms.Label lblClosedWeekThisYear;
        private System.Windows.Forms.Label lblCreatedWeekThisYearValue;
        private System.Windows.Forms.Label lblCreatedWeekThisYear;
        private System.Windows.Forms.Label lblWeekLastYearDates;
        private System.Windows.Forms.Panel pnlStatusNeedInfoEmpl;
        private System.Windows.Forms.Label lblStatusNeedInfoEmplValue;
        private System.Windows.Forms.Label lblStatusNeedInfoEmpl;
        private System.Windows.Forms.Panel pnlSplash;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.Label lblDataLoading;
        private System.Windows.Forms.Panel pnlMonthLastYear;
        private System.Windows.Forms.Label lblClosedMonthLastYearValue;
        private System.Windows.Forms.Label lblClosedMonthLastYear;
        private System.Windows.Forms.Label lblCreatedMonthLastYearValue;
        private System.Windows.Forms.Label lblCreatedMonthLastYear;
        private System.Windows.Forms.Panel pnlMonthThisYear;
        private System.Windows.Forms.Label lblClosedMonthThisYearValue;
        private System.Windows.Forms.Label lblClosedMonthThisYear;
        private System.Windows.Forms.Label lblCreatedMonthThisYearValue;
        private System.Windows.Forms.Label lblCreatedMonthThisYear;
        private System.Windows.Forms.Label lblMonthThisYearDates;
        private System.Windows.Forms.Label lblMonthLastYearDates;
    }
}
