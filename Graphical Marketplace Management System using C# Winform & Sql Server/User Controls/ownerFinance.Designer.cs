
namespace Online_MarketPlace.User_Controls
{
    partial class ownerFinance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFinanceTitle = new System.Windows.Forms.Label();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.financePanel = new System.Windows.Forms.Panel();
            this.paySalaryTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datePickerFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datePickerTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtboxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxEmpID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxEmpBonus = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxEmpSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.salaryDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFinanceTitle
            // 
            this.lblFinanceTitle.AutoSize = true;
            this.lblFinanceTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinanceTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFinanceTitle.Location = new System.Drawing.Point(10, 9);
            this.lblFinanceTitle.Name = "lblFinanceTitle";
            this.lblFinanceTitle.Size = new System.Drawing.Size(329, 34);
            this.lblFinanceTitle.TabIndex = 6;
            this.lblFinanceTitle.Text = "Finance Management";
            // 
            // btnPay
            // 
            this.btnPay.Animated = true;
            this.btnPay.BorderRadius = 15;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.btnPay.Location = new System.Drawing.Point(22, 210);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(173, 37);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay Salary";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // financePanel
            // 
            this.financePanel.Controls.Add(this.paySalaryTimePicker);
            this.financePanel.Controls.Add(this.datePickerFrom);
            this.financePanel.Controls.Add(this.datePickerTo);
            this.financePanel.Controls.Add(this.btnSearch);
            this.financePanel.Controls.Add(this.txtboxSearch);
            this.financePanel.Controls.Add(this.txtBoxEmpID);
            this.financePanel.Controls.Add(this.txtBoxEmpBonus);
            this.financePanel.Controls.Add(this.txtBoxEmpSalary);
            this.financePanel.Controls.Add(this.btnClear);
            this.financePanel.Controls.Add(this.btnPay);
            this.financePanel.Location = new System.Drawing.Point(23, 50);
            this.financePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.financePanel.Name = "financePanel";
            this.financePanel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.financePanel.Size = new System.Drawing.Size(972, 312);
            this.financePanel.TabIndex = 8;
            this.financePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.financePanel_Paint);
            // 
            // paySalaryTimePicker
            // 
            this.paySalaryTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paySalaryTimePicker.Animated = true;
            this.paySalaryTimePicker.BorderColor = System.Drawing.Color.White;
            this.paySalaryTimePicker.BorderRadius = 15;
            this.paySalaryTimePicker.Checked = true;
            this.paySalaryTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.paySalaryTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paySalaryTimePicker.ForeColor = System.Drawing.Color.White;
            this.paySalaryTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.paySalaryTimePicker.Location = new System.Drawing.Point(22, 12);
            this.paySalaryTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paySalaryTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.paySalaryTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.paySalaryTimePicker.Name = "paySalaryTimePicker";
            this.paySalaryTimePicker.Size = new System.Drawing.Size(376, 37);
            this.paySalaryTimePicker.TabIndex = 34;
            this.paySalaryTimePicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paySalaryTimePicker.Value = new System.DateTime(2023, 11, 27, 17, 49, 48, 362);
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerFrom.Animated = true;
            this.datePickerFrom.BorderColor = System.Drawing.Color.White;
            this.datePickerFrom.BorderRadius = 15;
            this.datePickerFrom.Checked = true;
            this.datePickerFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.datePickerFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFrom.ForeColor = System.Drawing.Color.White;
            this.datePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerFrom.Location = new System.Drawing.Point(22, 262);
            this.datePickerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePickerFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(173, 37);
            this.datePickerFrom.TabIndex = 34;
            this.datePickerFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datePickerFrom.Value = new System.DateTime(2023, 11, 27, 17, 49, 48, 362);
            // 
            // datePickerTo
            // 
            this.datePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerTo.Animated = true;
            this.datePickerTo.BorderColor = System.Drawing.Color.White;
            this.datePickerTo.BorderRadius = 15;
            this.datePickerTo.Checked = true;
            this.datePickerTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.datePickerTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerTo.ForeColor = System.Drawing.Color.White;
            this.datePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerTo.Location = new System.Drawing.Point(225, 262);
            this.datePickerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePickerTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePickerTo.Name = "datePickerTo";
            this.datePickerTo.Size = new System.Drawing.Size(173, 37);
            this.datePickerTo.TabIndex = 34;
            this.datePickerTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datePickerTo.Value = new System.DateTime(2023, 11, 27, 17, 49, 48, 362);
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.btnSearch.Location = new System.Drawing.Point(812, 262);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 37);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.BorderRadius = 15;
            this.txtboxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxSearch.DefaultText = "";
            this.txtboxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtboxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxSearch.Location = new System.Drawing.Point(417, 262);
            this.txtboxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.PasswordChar = '\0';
            this.txtboxSearch.PlaceholderText = "Search by Name and Date Range";
            this.txtboxSearch.SelectedText = "";
            this.txtboxSearch.Size = new System.Drawing.Size(376, 37);
            this.txtboxSearch.TabIndex = 10;
            // 
            // txtBoxEmpID
            // 
            this.txtBoxEmpID.BorderRadius = 15;
            this.txtBoxEmpID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxEmpID.DefaultText = "";
            this.txtBoxEmpID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxEmpID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxEmpID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmpID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmpID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmpID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmpID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmpID.Location = new System.Drawing.Point(22, 61);
            this.txtBoxEmpID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmpID.Name = "txtBoxEmpID";
            this.txtBoxEmpID.PasswordChar = '\0';
            this.txtBoxEmpID.PlaceholderText = "Employee ID*";
            this.txtBoxEmpID.SelectedText = "";
            this.txtBoxEmpID.Size = new System.Drawing.Size(376, 37);
            this.txtBoxEmpID.TabIndex = 5;
            // 
            // txtBoxEmpBonus
            // 
            this.txtBoxEmpBonus.BorderRadius = 15;
            this.txtBoxEmpBonus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxEmpBonus.DefaultText = "";
            this.txtBoxEmpBonus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxEmpBonus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxEmpBonus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmpBonus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmpBonus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmpBonus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmpBonus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmpBonus.Location = new System.Drawing.Point(22, 159);
            this.txtBoxEmpBonus.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmpBonus.Name = "txtBoxEmpBonus";
            this.txtBoxEmpBonus.PasswordChar = '\0';
            this.txtBoxEmpBonus.PlaceholderText = "Enter Bonus Amount";
            this.txtBoxEmpBonus.SelectedText = "";
            this.txtBoxEmpBonus.Size = new System.Drawing.Size(376, 37);
            this.txtBoxEmpBonus.TabIndex = 5;
            // 
            // txtBoxEmpSalary
            // 
            this.txtBoxEmpSalary.BorderRadius = 15;
            this.txtBoxEmpSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxEmpSalary.DefaultText = "";
            this.txtBoxEmpSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxEmpSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxEmpSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmpSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmpSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmpSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmpSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmpSalary.Location = new System.Drawing.Point(22, 110);
            this.txtBoxEmpSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmpSalary.Name = "txtBoxEmpSalary";
            this.txtBoxEmpSalary.PasswordChar = '\0';
            this.txtBoxEmpSalary.PlaceholderText = "Enter Salary Amount*";
            this.txtBoxEmpSalary.SelectedText = "";
            this.txtBoxEmpSalary.Size = new System.Drawing.Size(376, 37);
            this.txtBoxEmpSalary.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Animated = true;
            this.btnClear.BorderRadius = 15;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.btnClear.Location = new System.Drawing.Point(225, 210);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(173, 37);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Info";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // salaryDataGridView
            // 
            this.salaryDataGridView.AllowUserToAddRows = false;
            this.salaryDataGridView.AllowUserToDeleteRows = false;
            this.salaryDataGridView.AllowUserToResizeColumns = false;
            this.salaryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salaryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.salaryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.salaryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salaryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salaryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salaryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.salaryDataGridView.ColumnHeadersHeight = 45;
            this.salaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.salaryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salaryDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.salaryDataGridView.EnableHeadersVisualStyles = false;
            this.salaryDataGridView.Location = new System.Drawing.Point(16, 371);
            this.salaryDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salaryDataGridView.Name = "salaryDataGridView";
            this.salaryDataGridView.ReadOnly = true;
            this.salaryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salaryDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.salaryDataGridView.RowHeadersVisible = false;
            this.salaryDataGridView.RowHeadersWidth = 45;
            this.salaryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.salaryDataGridView.RowTemplate.Height = 35;
            this.salaryDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.salaryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salaryDataGridView.ShowEditingIcon = false;
            this.salaryDataGridView.Size = new System.Drawing.Size(987, 330);
            this.salaryDataGridView.TabIndex = 9;
            this.salaryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salaryDataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EmployeeID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Employee_name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 135;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Employee_Username";
            this.Column3.HeaderText = "Username";
            this.Column3.MinimumWidth = 150;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Salary_Paid_Amount";
            this.Column5.HeaderText = "Salary Paid";
            this.Column5.MinimumWidth = 100;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 180;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "paidDate";
            this.Column7.HeaderText = "Date";
            this.Column7.MinimumWidth = 185;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // ownerFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.salaryDataGridView);
            this.Controls.Add(this.lblFinanceTitle);
            this.Controls.Add(this.financePanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ownerFinance";
            this.Size = new System.Drawing.Size(1018, 716);
            this.financePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFinanceTitle;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private System.Windows.Forms.Panel financePanel;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEmpID;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEmpSalary;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEmpBonus;
        private System.Windows.Forms.DataGridView salaryDataGridView;
        private Guna.UI2.WinForms.Guna2TextBox txtboxSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePickerTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePickerFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker paySalaryTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
