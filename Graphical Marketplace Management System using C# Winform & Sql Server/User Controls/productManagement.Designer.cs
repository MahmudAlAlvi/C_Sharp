
namespace Online_MarketPlace.User_Controls
{
    partial class productManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.customerManagementPanel = new System.Windows.Forms.Panel();
            this.dateTimePickerAddingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.comboBoxCatagory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBoxCatagory = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxProductID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxProductStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxSellPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxBuyPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnCatagory = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblManagementTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerManagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Animated = true;
            this.btnRefresh.BorderRadius = 15;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnRefresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnRefresh.Location = new System.Drawing.Point(400, 266);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 37);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // customerManagementPanel
            // 
            this.customerManagementPanel.Controls.Add(this.dateTimePickerAddingDate);
            this.customerManagementPanel.Controls.Add(this.comboBoxCatagory);
            this.customerManagementPanel.Controls.Add(this.txtBoxCatagory);
            this.customerManagementPanel.Controls.Add(this.txtBoxProductID);
            this.customerManagementPanel.Controls.Add(this.txtBoxSearch);
            this.customerManagementPanel.Controls.Add(this.txtBoxProductStock);
            this.customerManagementPanel.Controls.Add(this.txtBoxSellPrice);
            this.customerManagementPanel.Controls.Add(this.txtBoxBuyPrice);
            this.customerManagementPanel.Controls.Add(this.txtBoxProductName);
            this.customerManagementPanel.Controls.Add(this.btnRefresh);
            this.customerManagementPanel.Controls.Add(this.clearBtn);
            this.customerManagementPanel.Controls.Add(this.btnCatagory);
            this.customerManagementPanel.Controls.Add(this.updateBtn);
            this.customerManagementPanel.Controls.Add(this.addBtn);
            this.customerManagementPanel.Location = new System.Drawing.Point(15, 46);
            this.customerManagementPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerManagementPanel.Name = "customerManagementPanel";
            this.customerManagementPanel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customerManagementPanel.Size = new System.Drawing.Size(987, 313);
            this.customerManagementPanel.TabIndex = 11;
            this.customerManagementPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.customerManagementPanel_Paint);
            // 
            // dateTimePickerAddingDate
            // 
            this.dateTimePickerAddingDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dateTimePickerAddingDate.BorderRadius = 15;
            this.dateTimePickerAddingDate.BorderThickness = 1;
            this.dateTimePickerAddingDate.Checked = true;
            this.dateTimePickerAddingDate.FillColor = System.Drawing.Color.White;
            this.dateTimePickerAddingDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAddingDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePickerAddingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAddingDate.Location = new System.Drawing.Point(824, 165);
            this.dateTimePickerAddingDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerAddingDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerAddingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAddingDate.Name = "dateTimePickerAddingDate";
            this.dateTimePickerAddingDate.Size = new System.Drawing.Size(155, 37);
            this.dateTimePickerAddingDate.TabIndex = 15;
            this.dateTimePickerAddingDate.Value = new System.DateTime(2023, 12, 18, 15, 38, 0, 770);
            // 
            // comboBoxCatagory
            // 
            this.comboBoxCatagory.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxCatagory.BorderRadius = 15;
            this.comboBoxCatagory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCatagory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCatagory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCatagory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxCatagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxCatagory.ItemHeight = 30;
            this.comboBoxCatagory.Location = new System.Drawing.Point(420, 216);
            this.comboBoxCatagory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCatagory.Name = "comboBoxCatagory";
            this.comboBoxCatagory.Size = new System.Drawing.Size(376, 36);
            this.comboBoxCatagory.TabIndex = 14;
            // 
            // txtBoxCatagory
            // 
            this.txtBoxCatagory.BorderRadius = 15;
            this.txtBoxCatagory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxCatagory.DefaultText = "";
            this.txtBoxCatagory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxCatagory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxCatagory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxCatagory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxCatagory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxCatagory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCatagory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxCatagory.Location = new System.Drawing.Point(291, 7);
            this.txtBoxCatagory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCatagory.Name = "txtBoxCatagory";
            this.txtBoxCatagory.PasswordChar = '\0';
            this.txtBoxCatagory.PlaceholderText = "Enter Catagory Name";
            this.txtBoxCatagory.SelectedText = "";
            this.txtBoxCatagory.Size = new System.Drawing.Size(376, 37);
            this.txtBoxCatagory.TabIndex = 5;
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
            this.txtBoxProductID.Location = new System.Drawing.Point(11, 120);
            this.txtBoxProductID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxProductID.Name = "txtBoxProductID";
            this.txtBoxProductID.PasswordChar = '\0';
            this.txtBoxProductID.PlaceholderText = "Product ID";
            this.txtBoxProductID.ReadOnly = true;
            this.txtBoxProductID.SelectedText = "";
            this.txtBoxProductID.Size = new System.Drawing.Size(376, 37);
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
            this.txtBoxSearch.Location = new System.Drawing.Point(552, 266);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PasswordChar = '\0';
            this.txtBoxSearch.PlaceholderText = "Search product by Name or Category";
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.Size = new System.Drawing.Size(427, 37);
            this.txtBoxSearch.TabIndex = 5;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // txtBoxProductStock
            // 
            this.txtBoxProductStock.BorderRadius = 15;
            this.txtBoxProductStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxProductStock.DefaultText = "";
            this.txtBoxProductStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxProductStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxProductStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxProductStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxProductStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxProductStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBoxProductStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxProductStock.Location = new System.Drawing.Point(11, 210);
            this.txtBoxProductStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxProductStock.Name = "txtBoxProductStock";
            this.txtBoxProductStock.PasswordChar = '\0';
            this.txtBoxProductStock.PlaceholderText = "Stock Amount*";
            this.txtBoxProductStock.SelectedText = "";
            this.txtBoxProductStock.Size = new System.Drawing.Size(376, 37);
            this.txtBoxProductStock.TabIndex = 5;
            // 
            // txtBoxSellPrice
            // 
            this.txtBoxSellPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtBoxSellPrice.BorderRadius = 15;
            this.txtBoxSellPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSellPrice.DefaultText = "";
            this.txtBoxSellPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxSellPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxSellPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSellPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSellPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxSellPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSellPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxSellPrice.Location = new System.Drawing.Point(420, 165);
            this.txtBoxSellPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxSellPrice.Name = "txtBoxSellPrice";
            this.txtBoxSellPrice.PasswordChar = '\0';
            this.txtBoxSellPrice.PlaceholderText = "Enter Sell Price*";
            this.txtBoxSellPrice.SelectedText = "";
            this.txtBoxSellPrice.Size = new System.Drawing.Size(376, 37);
            this.txtBoxSellPrice.TabIndex = 5;
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
            this.txtBoxBuyPrice.Location = new System.Drawing.Point(420, 120);
            this.txtBoxBuyPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxBuyPrice.Name = "txtBoxBuyPrice";
            this.txtBoxBuyPrice.PasswordChar = '\0';
            this.txtBoxBuyPrice.PlaceholderText = "Enter Buy Price*";
            this.txtBoxBuyPrice.SelectedText = "";
            this.txtBoxBuyPrice.Size = new System.Drawing.Size(376, 37);
            this.txtBoxBuyPrice.TabIndex = 5;
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.BorderRadius = 15;
            this.txtBoxProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxProductName.DefaultText = "";
            this.txtBoxProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxProductName.Location = new System.Drawing.Point(11, 165);
            this.txtBoxProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.PasswordChar = '\0';
            this.txtBoxProductName.PlaceholderText = "Enter Product Name*";
            this.txtBoxProductName.SelectedText = "";
            this.txtBoxProductName.Size = new System.Drawing.Size(376, 37);
            this.txtBoxProductName.TabIndex = 5;
            this.txtBoxProductName.TextChanged += new System.EventHandler(this.txtBoxProductName_TextChanged);
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
            this.clearBtn.Location = new System.Drawing.Point(291, 266);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(93, 37);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // btnCatagory
            // 
            this.btnCatagory.Animated = true;
            this.btnCatagory.BorderRadius = 15;
            this.btnCatagory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCatagory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCatagory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCatagory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCatagory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.btnCatagory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatagory.ForeColor = System.Drawing.Color.White;
            this.btnCatagory.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(222)))), ((int)(((byte)(80)))));
            this.btnCatagory.Location = new System.Drawing.Point(291, 52);
            this.btnCatagory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCatagory.Name = "btnCatagory";
            this.btnCatagory.Size = new System.Drawing.Size(376, 37);
            this.btnCatagory.TabIndex = 4;
            this.btnCatagory.Text = "Add New Catagory";
            this.btnCatagory.Click += new System.EventHandler(this.btnCatagory_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Animated = true;
            this.updateBtn.BorderRadius = 15;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.updateBtn.Location = new System.Drawing.Point(111, 266);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(160, 37);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Update Info";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Animated = true;
            this.addBtn.BorderRadius = 15;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.addBtn.Location = new System.Drawing.Point(6, 266);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(84, 37);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToResizeColumns = false;
            this.productDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.productDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.productDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.productDataGridView.ColumnHeadersHeight = 45;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.productDataGridView.EnableHeadersVisualStyles = false;
            this.productDataGridView.Location = new System.Drawing.Point(15, 364);
            this.productDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.productDataGridView.RowHeadersVisible = false;
            this.productDataGridView.RowHeadersWidth = 45;
            this.productDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productDataGridView.RowTemplate.Height = 35;
            this.productDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.ShowEditingIcon = false;
            this.productDataGridView.Size = new System.Drawing.Size(987, 337);
            this.productDataGridView.TabIndex = 12;
            this.productDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Product_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 70;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 90;
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
            // Column3
            // 
            this.Column3.DataPropertyName = "CatagoryType";
            this.Column3.HeaderText = "Category";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 210;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "BuyPrice";
            this.Column4.HeaderText = "Buying Price";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 170;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SellPrice";
            this.Column5.HeaderText = "Selling Price";
            this.Column5.MinimumWidth = 110;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 170;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Stock";
            this.Column6.HeaderText = "Stock";
            this.Column6.MinimumWidth = 50;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // lblManagementTitle
            // 
            this.lblManagementTitle.AutoSize = true;
            this.lblManagementTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagementTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblManagementTitle.Location = new System.Drawing.Point(9, 10);
            this.lblManagementTitle.Name = "lblManagementTitle";
            this.lblManagementTitle.Size = new System.Drawing.Size(330, 34);
            this.lblManagementTitle.TabIndex = 10;
            this.lblManagementTitle.Text = "Product Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(15, 146);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 6);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // productManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerManagementPanel);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.lblManagementTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "productManagement";
            this.Size = new System.Drawing.Size(1018, 716);
            this.Load += new System.EventHandler(this.productManagement_Load);
            this.customerManagementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.Panel customerManagementPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxProductID;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxProductStock;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxSellPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxBuyPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxProductName;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Label lblManagementTitle;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxCatagory;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxCatagory;
        private Guna.UI2.WinForms.Guna2Button btnCatagory;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerAddingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
