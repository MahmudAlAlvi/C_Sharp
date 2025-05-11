
namespace Online_MarketPlace.User_Controls
{
    partial class ownerManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblManagementTitle = new System.Windows.Forms.Label();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.empManagementPanel = new System.Windows.Forms.Panel();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.joiningDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtBoxEmpID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxEmpUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxEmpSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxEmpPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxEmpName = new Guna.UI2.WinForms.Guna2TextBox();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.removeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empManagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManagementTitle
            // 
            this.lblManagementTitle.AutoSize = true;
            this.lblManagementTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagementTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblManagementTitle.Location = new System.Drawing.Point(11, 11);
            this.lblManagementTitle.Name = "lblManagementTitle";
            this.lblManagementTitle.Size = new System.Drawing.Size(426, 42);
            this.lblManagementTitle.TabIndex = 1;
            this.lblManagementTitle.Text = "Employee Management";
            // 
            // addBtn
            // 
            this.addBtn.Animated = true;
            this.addBtn.BorderRadius = 15;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.addBtn.Location = new System.Drawing.Point(24, 266);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(203, 53);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add Employee";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // empManagementPanel
            // 
            this.empManagementPanel.Controls.Add(this.lblJoiningDate);
            this.empManagementPanel.Controls.Add(this.joiningDateTimePicker);
            this.empManagementPanel.Controls.Add(this.txtBoxEmpID);
            this.empManagementPanel.Controls.Add(this.txtBoxEmpUsername);
            this.empManagementPanel.Controls.Add(this.txtBoxEmpSalary);
            this.empManagementPanel.Controls.Add(this.txtBoxEmpPass);
            this.empManagementPanel.Controls.Add(this.txtBoxEmpName);
            this.empManagementPanel.Controls.Add(this.clearBtn);
            this.empManagementPanel.Controls.Add(this.removeBtn);
            this.empManagementPanel.Controls.Add(this.updateBtn);
            this.empManagementPanel.Controls.Add(this.addBtn);
            this.empManagementPanel.Location = new System.Drawing.Point(111, 83);
            this.empManagementPanel.Name = "empManagementPanel";
            this.empManagementPanel.Padding = new System.Windows.Forms.Padding(4);
            this.empManagementPanel.Size = new System.Drawing.Size(916, 345);
            this.empManagementPanel.TabIndex = 5;
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoiningDate.Location = new System.Drawing.Point(459, 163);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(193, 46);
            this.lblJoiningDate.TabIndex = 35;
            this.lblJoiningDate.Text = "Date of Joining";
            this.lblJoiningDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // joiningDateTimePicker
            // 
            this.joiningDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.joiningDateTimePicker.Animated = true;
            this.joiningDateTimePicker.BorderColor = System.Drawing.Color.Gainsboro;
            this.joiningDateTimePicker.BorderRadius = 15;
            this.joiningDateTimePicker.BorderThickness = 1;
            this.joiningDateTimePicker.Checked = true;
            this.joiningDateTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.joiningDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joiningDateTimePicker.ForeColor = System.Drawing.Color.White;
            this.joiningDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.joiningDateTimePicker.Location = new System.Drawing.Point(676, 163);
            this.joiningDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.joiningDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.joiningDateTimePicker.Name = "joiningDateTimePicker";
            this.joiningDateTimePicker.Size = new System.Drawing.Size(212, 46);
            this.joiningDateTimePicker.TabIndex = 34;
            this.joiningDateTimePicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.joiningDateTimePicker.Value = new System.DateTime(2023, 11, 27, 17, 49, 48, 362);
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
            this.txtBoxEmpID.Location = new System.Drawing.Point(465, 22);
            this.txtBoxEmpID.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxEmpID.Name = "txtBoxEmpID";
            this.txtBoxEmpID.PasswordChar = '\0';
            this.txtBoxEmpID.PlaceholderText = "Employee ID";
            this.txtBoxEmpID.ReadOnly = true;
            this.txtBoxEmpID.SelectedText = "";
            this.txtBoxEmpID.Size = new System.Drawing.Size(423, 46);
            this.txtBoxEmpID.TabIndex = 5;
            // 
            // txtBoxEmpUsername
            // 
            this.txtBoxEmpUsername.BorderRadius = 15;
            this.txtBoxEmpUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxEmpUsername.DefaultText = "";
            this.txtBoxEmpUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxEmpUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxEmpUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmpUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmpUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmpUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmpUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmpUsername.Location = new System.Drawing.Point(465, 91);
            this.txtBoxEmpUsername.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxEmpUsername.Name = "txtBoxEmpUsername";
            this.txtBoxEmpUsername.PasswordChar = '\0';
            this.txtBoxEmpUsername.PlaceholderText = "Employee Username";
            this.txtBoxEmpUsername.ReadOnly = true;
            this.txtBoxEmpUsername.SelectedText = "";
            this.txtBoxEmpUsername.Size = new System.Drawing.Size(423, 46);
            this.txtBoxEmpUsername.TabIndex = 5;
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
            this.txtBoxEmpSalary.Location = new System.Drawing.Point(24, 163);
            this.txtBoxEmpSalary.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxEmpSalary.Name = "txtBoxEmpSalary";
            this.txtBoxEmpSalary.PasswordChar = '\0';
            this.txtBoxEmpSalary.PlaceholderText = "Enter Salary Amount*";
            this.txtBoxEmpSalary.SelectedText = "";
            this.txtBoxEmpSalary.Size = new System.Drawing.Size(423, 46);
            this.txtBoxEmpSalary.TabIndex = 5;
            // 
            // txtBoxEmpPass
            // 
            this.txtBoxEmpPass.BorderRadius = 15;
            this.txtBoxEmpPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxEmpPass.DefaultText = "";
            this.txtBoxEmpPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxEmpPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxEmpPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmpPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmpPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmpPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmpPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmpPass.Location = new System.Drawing.Point(24, 91);
            this.txtBoxEmpPass.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxEmpPass.Name = "txtBoxEmpPass";
            this.txtBoxEmpPass.PasswordChar = '\0';
            this.txtBoxEmpPass.PlaceholderText = "Enter Password*";
            this.txtBoxEmpPass.SelectedText = "";
            this.txtBoxEmpPass.Size = new System.Drawing.Size(423, 46);
            this.txtBoxEmpPass.TabIndex = 5;
            // 
            // txtBoxEmpName
            // 
            this.txtBoxEmpName.BorderRadius = 15;
            this.txtBoxEmpName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxEmpName.DefaultText = "";
            this.txtBoxEmpName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxEmpName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxEmpName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmpName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmpName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmpName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmpName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmpName.Location = new System.Drawing.Point(24, 22);
            this.txtBoxEmpName.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxEmpName.Name = "txtBoxEmpName";
            this.txtBoxEmpName.PasswordChar = '\0';
            this.txtBoxEmpName.PlaceholderText = "Enter Employee Surname*";
            this.txtBoxEmpName.SelectedText = "";
            this.txtBoxEmpName.Size = new System.Drawing.Size(423, 46);
            this.txtBoxEmpName.TabIndex = 5;
            // 
            // clearBtn
            // 
            this.clearBtn.Animated = true;
            this.clearBtn.BorderRadius = 15;
            this.clearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.clearBtn.Location = new System.Drawing.Point(742, 266);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(146, 53);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Animated = true;
            this.removeBtn.BorderRadius = 15;
            this.removeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.removeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.removeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.removeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.removeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.removeBtn.Location = new System.Drawing.Point(527, 266);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(165, 53);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Remove";
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Animated = true;
            this.updateBtn.BorderRadius = 15;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.updateBtn.Location = new System.Drawing.Point(288, 266);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(185, 53);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Update Info";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToAddRows = false;
            this.employeeDataGridView.AllowUserToDeleteRows = false;
            this.employeeDataGridView.AllowUserToResizeColumns = false;
            this.employeeDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.employeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.employeeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.employeeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.employeeDataGridView.ColumnHeadersHeight = 45;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.employeeDataGridView.EnableHeadersVisualStyles = false;
            this.employeeDataGridView.Location = new System.Drawing.Point(18, 466);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.employeeDataGridView.RowHeadersVisible = false;
            this.employeeDataGridView.RowHeadersWidth = 45;
            this.employeeDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.employeeDataGridView.RowTemplate.Height = 35;
            this.employeeDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.employeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataGridView.ShowEditingIcon = false;
            this.employeeDataGridView.Size = new System.Drawing.Size(1110, 413);
            this.employeeDataGridView.TabIndex = 6;
            this.employeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Employee_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 95;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Employee_name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 75;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Employee_Username";
            this.Column3.HeaderText = "Username";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 215;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Employee_password";
            this.Column4.HeaderText = "Password";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Salary";
            this.Column5.HeaderText = "Salary";
            this.Column5.MinimumWidth = 50;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 145;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Bonus";
            this.Column6.HeaderText = "Bonus";
            this.Column6.MinimumWidth = 50;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 135;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Joining_date";
            this.Column7.HeaderText = "Joining Date";
            this.Column7.MinimumWidth = 200;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // ownerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.empManagementPanel);
            this.Controls.Add(this.lblManagementTitle);
            this.Name = "ownerManagement";
            this.Size = new System.Drawing.Size(1145, 895);
            this.empManagementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblManagementTitle;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private System.Windows.Forms.Panel empManagementPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEmpName;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEmpSalary;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEmpPass;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Guna.UI2.WinForms.Guna2Button removeBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEmpUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEmpID;
        private Guna.UI2.WinForms.Guna2DateTimePicker joiningDateTimePicker;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
