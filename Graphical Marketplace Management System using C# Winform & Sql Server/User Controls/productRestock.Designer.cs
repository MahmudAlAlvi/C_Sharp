
namespace Online_MarketPlace.User_Controls
{
    partial class productRestock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productRestock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePickerIssueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerManagementPanel = new System.Windows.Forms.Panel();
            this.txtBoxProductID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxProductRestock = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxBuyPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnRestock = new Guna.UI2.WinForms.Guna2Button();
            this.RestockDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblManagementTitle = new System.Windows.Forms.Label();
            this.customerManagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerIssueDate
            // 
            this.dateTimePickerIssueDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dateTimePickerIssueDate.BorderRadius = 15;
            this.dateTimePickerIssueDate.BorderThickness = 1;
            this.dateTimePickerIssueDate.Checked = true;
            this.dateTimePickerIssueDate.FillColor = System.Drawing.Color.White;
            this.dateTimePickerIssueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIssueDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePickerIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIssueDate.Location = new System.Drawing.Point(576, 109);
            this.dateTimePickerIssueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerIssueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerIssueDate.Name = "dateTimePickerIssueDate";
            this.dateTimePickerIssueDate.Size = new System.Drawing.Size(278, 46);
            this.dateTimePickerIssueDate.TabIndex = 15;
            this.dateTimePickerIssueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateTimePickerIssueDate.Value = new System.DateTime(2023, 12, 18, 15, 41, 8, 589);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(17, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 8);
            this.panel1.TabIndex = 19;
            // 
            // customerManagementPanel
            // 
            this.customerManagementPanel.Controls.Add(this.dateTimePickerIssueDate);
            this.customerManagementPanel.Controls.Add(this.txtBoxProductID);
            this.customerManagementPanel.Controls.Add(this.txtBoxSearch);
            this.customerManagementPanel.Controls.Add(this.txtBoxProductRestock);
            this.customerManagementPanel.Controls.Add(this.txtBoxBuyPrice);
            this.customerManagementPanel.Controls.Add(this.btnRefresh);
            this.customerManagementPanel.Controls.Add(this.clearBtn);
            this.customerManagementPanel.Controls.Add(this.btnRestock);
            this.customerManagementPanel.Location = new System.Drawing.Point(17, 61);
            this.customerManagementPanel.Name = "customerManagementPanel";
            this.customerManagementPanel.Padding = new System.Windows.Forms.Padding(4);
            this.customerManagementPanel.Size = new System.Drawing.Size(1110, 391);
            this.customerManagementPanel.TabIndex = 17;
            // 
            // txtBoxProductID
            // 
            this.txtBoxProductID.BorderRadius = 15;
            this.txtBoxProductID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxProductID.DefaultText = "";
            this.txtBoxProductID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxProductID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxProductID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxProductID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxProductID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxProductID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProductID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxProductID.Location = new System.Drawing.Point(239, 42);
            this.txtBoxProductID.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxProductID.Name = "txtBoxProductID";
            this.txtBoxProductID.PasswordChar = '\0';
            this.txtBoxProductID.PlaceholderText = "Product ID";
            this.txtBoxProductID.ReadOnly = true;
            this.txtBoxProductID.SelectedText = "";
            this.txtBoxProductID.Size = new System.Drawing.Size(278, 46);
            this.txtBoxProductID.TabIndex = 5;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BorderRadius = 15;
            this.txtBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearch.DefaultText = "";
            this.txtBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtBoxSearch.IconRight")));
            this.txtBoxSearch.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtBoxSearch.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtBoxSearch.Location = new System.Drawing.Point(239, 323);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PasswordChar = '\0';
            this.txtBoxSearch.PlaceholderText = "Search Product";
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.Size = new System.Drawing.Size(862, 46);
            this.txtBoxSearch.TabIndex = 5;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // txtBoxProductRestock
            // 
            this.txtBoxProductRestock.BorderRadius = 15;
            this.txtBoxProductRestock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxProductRestock.DefaultText = "";
            this.txtBoxProductRestock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxProductRestock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxProductRestock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxProductRestock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxProductRestock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxProductRestock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBoxProductRestock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxProductRestock.Location = new System.Drawing.Point(576, 42);
            this.txtBoxProductRestock.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxProductRestock.Name = "txtBoxProductRestock";
            this.txtBoxProductRestock.PasswordChar = '\0';
            this.txtBoxProductRestock.PlaceholderText = "Restock Amount*";
            this.txtBoxProductRestock.SelectedText = "";
            this.txtBoxProductRestock.Size = new System.Drawing.Size(278, 46);
            this.txtBoxProductRestock.TabIndex = 5;
            // 
            // txtBoxBuyPrice
            // 
            this.txtBoxBuyPrice.BorderRadius = 15;
            this.txtBoxBuyPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxBuyPrice.DefaultText = "";
            this.txtBoxBuyPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxBuyPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxBuyPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxBuyPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxBuyPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxBuyPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBuyPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxBuyPrice.Location = new System.Drawing.Point(239, 109);
            this.txtBoxBuyPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxBuyPrice.Name = "txtBoxBuyPrice";
            this.txtBoxBuyPrice.PasswordChar = '\0';
            this.txtBoxBuyPrice.PlaceholderText = "Enter Unit Price*";
            this.txtBoxBuyPrice.SelectedText = "";
            this.txtBoxBuyPrice.Size = new System.Drawing.Size(278, 46);
            this.txtBoxBuyPrice.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Animated = true;
            this.btnRefresh.BorderRadius = 15;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.btnRefresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(222)))), ((int)(((byte)(80)))));
            this.btnRefresh.Location = new System.Drawing.Point(7, 323);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(224, 46);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh Table";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Animated = true;
            this.clearBtn.BorderRadius = 15;
            this.clearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.clearBtn.Location = new System.Drawing.Point(576, 180);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(278, 46);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear Info";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.Animated = true;
            this.btnRestock.BorderRadius = 15;
            this.btnRestock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnRestock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestock.ForeColor = System.Drawing.Color.White;
            this.btnRestock.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnRestock.Location = new System.Drawing.Point(239, 180);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(278, 46);
            this.btnRestock.TabIndex = 4;
            this.btnRestock.Text = "Re-stock Product";
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // RestockDataGridView
            // 
            this.RestockDataGridView.AllowUserToAddRows = false;
            this.RestockDataGridView.AllowUserToDeleteRows = false;
            this.RestockDataGridView.AllowUserToResizeColumns = false;
            this.RestockDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RestockDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.RestockDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RestockDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.RestockDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RestockDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RestockDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RestockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.RestockDataGridView.ColumnHeadersHeight = 45;
            this.RestockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RestockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RestockDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.RestockDataGridView.EnableHeadersVisualStyles = false;
            this.RestockDataGridView.Location = new System.Drawing.Point(17, 458);
            this.RestockDataGridView.Name = "RestockDataGridView";
            this.RestockDataGridView.ReadOnly = true;
            this.RestockDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RestockDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.RestockDataGridView.RowHeadersVisible = false;
            this.RestockDataGridView.RowHeadersWidth = 45;
            this.RestockDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RestockDataGridView.RowTemplate.Height = 35;
            this.RestockDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RestockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RestockDataGridView.ShowEditingIcon = false;
            this.RestockDataGridView.Size = new System.Drawing.Size(1110, 421);
            this.RestockDataGridView.TabIndex = 18;
            this.RestockDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RestockDataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Product_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 70;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "ProductName";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 90;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "BuyPrice";
            this.Column4.HeaderText = "Initial Buying Price";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SellPrice";
            this.Column5.HeaderText = "Selling Price";
            this.Column5.MinimumWidth = 110;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Stock";
            this.Column6.HeaderText = "Stock";
            this.Column6.MinimumWidth = 50;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 180;
            // 
            // lblManagementTitle
            // 
            this.lblManagementTitle.AutoSize = true;
            this.lblManagementTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagementTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblManagementTitle.Location = new System.Drawing.Point(14, 16);
            this.lblManagementTitle.Name = "lblManagementTitle";
            this.lblManagementTitle.Size = new System.Drawing.Size(312, 42);
            this.lblManagementTitle.TabIndex = 16;
            this.lblManagementTitle.Text = "Product Restock";
            // 
            // productRestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerManagementPanel);
            this.Controls.Add(this.RestockDataGridView);
            this.Controls.Add(this.lblManagementTitle);
            this.Name = "productRestock";
            this.Size = new System.Drawing.Size(1145, 895);
            this.customerManagementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RestockDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerIssueDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel customerManagementPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxProductID;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxProductRestock;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxBuyPrice;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Guna.UI2.WinForms.Guna2Button btnRestock;
        private System.Windows.Forms.DataGridView RestockDataGridView;
        private System.Windows.Forms.Label lblManagementTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
