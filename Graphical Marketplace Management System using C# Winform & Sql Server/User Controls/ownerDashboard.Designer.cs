
namespace Online_MarketPlace.User_Controls
{
    partial class ownerDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ownerDashboard));
            this.revenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.thisMonthBtn = new Guna.UI2.WinForms.Guna2Button();
            this.last30daysBtn = new Guna.UI2.WinForms.Guna2Button();
            this.todayBtn = new Guna.UI2.WinForms.Guna2Button();
            this.last7daysBtn = new Guna.UI2.WinForms.Guna2Button();
            this.customBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalEmployees = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.customStartDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.customEndDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.guna2Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // revenueChart
            // 
            this.revenueChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.revenueChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.BlueViolet;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.MediumPurple;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.BlueViolet;
            chartArea3.AxisY.LabelStyle.Format = "${0}";
            chartArea3.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MajorTickMark.LineWidth = 0;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            chartArea3.Name = "ChartArea1";
            this.revenueChart.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Font = new System.Drawing.Font("Verdana", 8F);
            legend3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            legend3.IsTextAutoFit = false;
            legend3.Name = "Revenue";
            this.revenueChart.Legends.Add(legend3);
            this.revenueChart.Location = new System.Drawing.Point(23, 193);
            this.revenueChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.revenueChart.Name = "revenueChart";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(178)))));
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            series3.BorderWidth = 0;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            series3.Legend = "Revenue";
            series3.MarkerColor = System.Drawing.Color.LightPink;
            series3.MarkerSize = 2;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Revenue";
            this.revenueChart.Series.Add(series3);
            this.revenueChart.Size = new System.Drawing.Size(971, 375);
            this.revenueChart.TabIndex = 31;
            this.revenueChart.Text = "chart1";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Gross Revenue";
            this.revenueChart.Titles.Add(title3);
            this.revenueChart.Click += new System.EventHandler(this.revenueChart_Click);
            // 
            // thisMonthBtn
            // 
            this.thisMonthBtn.Animated = true;
            this.thisMonthBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.thisMonthBtn.BorderRadius = 10;
            this.thisMonthBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.thisMonthBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.thisMonthBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.thisMonthBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.thisMonthBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.thisMonthBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.thisMonthBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.thisMonthBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.thisMonthBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisMonthBtn.ForeColor = System.Drawing.Color.White;
            this.thisMonthBtn.Location = new System.Drawing.Point(865, 27);
            this.thisMonthBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thisMonthBtn.Name = "thisMonthBtn";
            this.thisMonthBtn.Size = new System.Drawing.Size(129, 34);
            this.thisMonthBtn.TabIndex = 21;
            this.thisMonthBtn.Text = "This Month";
            this.thisMonthBtn.Click += new System.EventHandler(this.thisMonthBtn_Click);
            // 
            // last30daysBtn
            // 
            this.last30daysBtn.Animated = true;
            this.last30daysBtn.BorderRadius = 10;
            this.last30daysBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.last30daysBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.last30daysBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.last30daysBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.last30daysBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.last30daysBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.last30daysBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.last30daysBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.last30daysBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last30daysBtn.ForeColor = System.Drawing.Color.White;
            this.last30daysBtn.Location = new System.Drawing.Point(708, 27);
            this.last30daysBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.last30daysBtn.Name = "last30daysBtn";
            this.last30daysBtn.Size = new System.Drawing.Size(151, 34);
            this.last30daysBtn.TabIndex = 22;
            this.last30daysBtn.Text = "Last 30 days";
            this.last30daysBtn.Click += new System.EventHandler(this.last30daysBtn_Click);
            // 
            // todayBtn
            // 
            this.todayBtn.Animated = true;
            this.todayBtn.BorderRadius = 10;
            this.todayBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.todayBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.todayBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.todayBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.todayBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.todayBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.todayBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.todayBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.todayBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayBtn.ForeColor = System.Drawing.Color.White;
            this.todayBtn.Location = new System.Drawing.Point(479, 27);
            this.todayBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todayBtn.Name = "todayBtn";
            this.todayBtn.Size = new System.Drawing.Size(84, 34);
            this.todayBtn.TabIndex = 23;
            this.todayBtn.Text = "Today";
            this.todayBtn.Click += new System.EventHandler(this.todayBtn_Click);
            // 
            // last7daysBtn
            // 
            this.last7daysBtn.Animated = true;
            this.last7daysBtn.BorderRadius = 10;
            this.last7daysBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.last7daysBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.last7daysBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.last7daysBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.last7daysBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.last7daysBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.last7daysBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.last7daysBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.last7daysBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last7daysBtn.ForeColor = System.Drawing.Color.White;
            this.last7daysBtn.Location = new System.Drawing.Point(569, 27);
            this.last7daysBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.last7daysBtn.Name = "last7daysBtn";
            this.last7daysBtn.Size = new System.Drawing.Size(134, 34);
            this.last7daysBtn.TabIndex = 24;
            this.last7daysBtn.Text = "Last 7 days";
            this.last7daysBtn.Click += new System.EventHandler(this.last7daysBtn_Click);
            // 
            // customBtn
            // 
            this.customBtn.Animated = true;
            this.customBtn.BorderRadius = 10;
            this.customBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.customBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.customBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.customBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.customBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customBtn.ForeColor = System.Drawing.Color.White;
            this.customBtn.Location = new System.Drawing.Point(377, 27);
            this.customBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customBtn.Name = "customBtn";
            this.customBtn.Size = new System.Drawing.Size(97, 34);
            this.customBtn.TabIndex = 25;
            this.customBtn.Text = "Custom";
            this.customBtn.Click += new System.EventHandler(this.customBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(11, 11);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(78, 76);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(108, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Orders";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.Location = new System.Drawing.Point(94, 42);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(193, 32);
            this.lblTotalOrders.TabIndex = 2;
            this.lblTotalOrders.Text = "100000.76";
            this.lblTotalOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalOrders.Click += new System.EventHandler(this.lblTotalOrders_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 5;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.lblTotalOrders);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Location = new System.Drawing.Point(23, 80);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(301, 99);
            this.guna2Panel1.TabIndex = 30;
            this.guna2Panel1.UseTransparentBackground = true;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox5.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox5.Image")));
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(11, 15);
            this.guna2PictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(78, 76);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox5.TabIndex = 6;
            this.guna2PictureBox5.TabStop = false;
            this.guna2PictureBox5.UseTransparentBackground = true;
            this.guna2PictureBox5.Click += new System.EventHandler(this.guna2PictureBox5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(117, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total Sales";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderRadius = 15;
            this.guna2Panel5.BorderThickness = 5;
            this.guna2Panel5.Controls.Add(this.guna2PictureBox5);
            this.guna2Panel5.Controls.Add(this.label8);
            this.guna2Panel5.Controls.Add(this.lblTotalSales);
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.guna2Panel5.Location = new System.Drawing.Point(23, 582);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(301, 106);
            this.guna2Panel5.TabIndex = 26;
            this.guna2Panel5.UseTransparentBackground = true;
            this.guna2Panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel5_Paint);
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(94, 52);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(193, 33);
            this.lblTotalSales.TabIndex = 2;
            this.lblTotalSales.Text = "100700.95";
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalSales.Click += new System.EventHandler(this.lblTotalSales_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 15;
            this.guna2Panel4.BorderThickness = 5;
            this.guna2Panel4.Controls.Add(this.guna2PictureBox4);
            this.guna2Panel4.Controls.Add(this.label6);
            this.guna2Panel4.Controls.Add(this.lblTotalExpense);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.guna2Panel4.Location = new System.Drawing.Point(357, 582);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(301, 106);
            this.guna2Panel4.TabIndex = 26;
            this.guna2Panel4.UseTransparentBackground = true;
            this.guna2Panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel4_Paint);
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(11, 15);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(78, 76);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox4.TabIndex = 6;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
            this.guna2PictureBox4.Click += new System.EventHandler(this.guna2PictureBox4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(111, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Expense";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpense.Location = new System.Drawing.Point(104, 52);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(188, 33);
            this.lblTotalExpense.TabIndex = 2;
            this.lblTotalExpense.Text = "193000.95";
            this.lblTotalExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalExpense.Click += new System.EventHandler(this.lblTotalExpense_Click);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderRadius = 15;
            this.guna2Panel6.BorderThickness = 5;
            this.guna2Panel6.Controls.Add(this.guna2PictureBox6);
            this.guna2Panel6.Controls.Add(this.label10);
            this.guna2Panel6.Controls.Add(this.lblTotalEmployees);
            this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.guna2Panel6.Location = new System.Drawing.Point(692, 582);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(301, 106);
            this.guna2Panel6.TabIndex = 26;
            this.guna2Panel6.UseTransparentBackground = true;
            this.guna2Panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel6_Paint);
            // 
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox6.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox6.Image")));
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Location = new System.Drawing.Point(11, 15);
            this.guna2PictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.Size = new System.Drawing.Size(78, 76);
            this.guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox6.TabIndex = 6;
            this.guna2PictureBox6.TabStop = false;
            this.guna2PictureBox6.UseTransparentBackground = true;
            this.guna2PictureBox6.Click += new System.EventHandler(this.guna2PictureBox6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(94, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total Employees";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblTotalEmployees
            // 
            this.lblTotalEmployees.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployees.Location = new System.Drawing.Point(96, 52);
            this.lblTotalEmployees.Name = "lblTotalEmployees";
            this.lblTotalEmployees.Size = new System.Drawing.Size(188, 32);
            this.lblTotalEmployees.TabIndex = 2;
            this.lblTotalEmployees.Text = "16000.95";
            this.lblTotalEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalEmployees.Click += new System.EventHandler(this.lblTotalEmployees_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.BorderThickness = 5;
            this.guna2Panel2.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.lblTotalRevenue);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel2.Location = new System.Drawing.Point(357, 80);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(301, 99);
            this.guna2Panel2.TabIndex = 30;
            this.guna2Panel2.UseTransparentBackground = true;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(11, 11);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(78, 76);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 6;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(111, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Revenue";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(98, 42);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(195, 33);
            this.lblTotalRevenue.TabIndex = 2;
            this.lblTotalRevenue.Text = "10500.95";
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalRevenue.Click += new System.EventHandler(this.lblTotalRevenue_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.BorderThickness = 5;
            this.guna2Panel3.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.lblTotalProfit);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.guna2Panel3.Location = new System.Drawing.Point(692, 80);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(301, 99);
            this.guna2Panel3.TabIndex = 30;
            this.guna2Panel3.UseTransparentBackground = true;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(7, 11);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(78, 76);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 6;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            this.guna2PictureBox3.Click += new System.EventHandler(this.guna2PictureBox3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(108, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Profit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(90, 42);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(195, 32);
            this.lblTotalProfit.TabIndex = 2;
            this.lblTotalProfit.Text = "10000.95";
            this.lblTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalProfit.Click += new System.EventHandler(this.lblTotalProfit_Click);
            // 
            // customStartDatePicker
            // 
            this.customStartDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customStartDatePicker.Animated = true;
            this.customStartDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.customStartDatePicker.BorderColor = System.Drawing.Color.Transparent;
            this.customStartDatePicker.BorderRadius = 15;
            this.customStartDatePicker.Checked = true;
            this.customStartDatePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.customStartDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customStartDatePicker.ForeColor = System.Drawing.Color.White;
            this.customStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.customStartDatePicker.Location = new System.Drawing.Point(23, 27);
            this.customStartDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customStartDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.customStartDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.customStartDatePicker.Name = "customStartDatePicker";
            this.customStartDatePicker.Size = new System.Drawing.Size(172, 34);
            this.customStartDatePicker.TabIndex = 32;
            this.customStartDatePicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customStartDatePicker.Value = new System.DateTime(2023, 11, 27, 17, 49, 48, 362);
            this.customStartDatePicker.ValueChanged += new System.EventHandler(this.customStartDatePicker_ValueChanged);
            // 
            // customEndDatePicker
            // 
            this.customEndDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customEndDatePicker.Animated = true;
            this.customEndDatePicker.BorderColor = System.Drawing.Color.White;
            this.customEndDatePicker.BorderRadius = 15;
            this.customEndDatePicker.Checked = true;
            this.customEndDatePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.customEndDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customEndDatePicker.ForeColor = System.Drawing.Color.White;
            this.customEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.customEndDatePicker.Location = new System.Drawing.Point(200, 27);
            this.customEndDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customEndDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.customEndDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.customEndDatePicker.Name = "customEndDatePicker";
            this.customEndDatePicker.Size = new System.Drawing.Size(172, 34);
            this.customEndDatePicker.TabIndex = 33;
            this.customEndDatePicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customEndDatePicker.Value = new System.DateTime(2023, 11, 27, 17, 49, 48, 362);
            this.customEndDatePicker.ValueChanged += new System.EventHandler(this.customEndDatePicker_ValueChanged);
            // 
            // ownerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.customEndDatePicker);
            this.Controls.Add(this.customStartDatePicker);
            this.Controls.Add(this.revenueChart);
            this.Controls.Add(this.thisMonthBtn);
            this.Controls.Add(this.last30daysBtn);
            this.Controls.Add(this.todayBtn);
            this.Controls.Add(this.last7daysBtn);
            this.Controls.Add(this.customBtn);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel6);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ownerDashboard";
            this.Size = new System.Drawing.Size(1018, 716);
            this.Load += new System.EventHandler(this.ownerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart revenueChart;
        private Guna.UI2.WinForms.Guna2Button thisMonthBtn;
        private Guna.UI2.WinForms.Guna2Button last30daysBtn;
        private Guna.UI2.WinForms.Guna2Button todayBtn;
        private Guna.UI2.WinForms.Guna2Button last7daysBtn;
        private Guna.UI2.WinForms.Guna2Button customBtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalOrders;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalExpense;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalEmployees;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalRevenue;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label lblTotalSales;
        private Guna.UI2.WinForms.Guna2DateTimePicker customEndDatePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker customStartDatePicker;
    }
}
