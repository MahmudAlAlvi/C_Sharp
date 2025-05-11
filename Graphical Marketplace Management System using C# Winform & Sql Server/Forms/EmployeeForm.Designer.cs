
namespace Online_MarketPlace.Forms
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.employee_menu_label = new System.Windows.Forms.Label();
            this.RestockBtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.settingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.centerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.productsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.customerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.sideBarPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.upperBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.employeeSetting1 = new Online_MarketPlace.User_Controls.employeeSetting();
            this.productRestock1 = new Online_MarketPlace.User_Controls.productRestock();
            this.customerManagement1 = new Online_MarketPlace.User_Controls.customerManagement();
            this.productManagement1 = new Online_MarketPlace.User_Controls.productManagement();
            this.centerPanel.SuspendLayout();
            this.sideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.upperBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employee_menu_label
            // 
            this.employee_menu_label.BackColor = System.Drawing.Color.Transparent;
            this.employee_menu_label.Font = new System.Drawing.Font("Verdana", 11F);
            this.employee_menu_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.employee_menu_label.Location = new System.Drawing.Point(-1, 123);
            this.employee_menu_label.Name = "employee_menu_label";
            this.employee_menu_label.Size = new System.Drawing.Size(267, 48);
            this.employee_menu_label.TabIndex = 15;
            this.employee_menu_label.Text = "Welcome Text";
            this.employee_menu_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestockBtn
            // 
            this.RestockBtn.Animated = true;
            this.RestockBtn.AutoRoundedCorners = true;
            this.RestockBtn.BackColor = System.Drawing.Color.Transparent;
            this.RestockBtn.BorderColor = System.Drawing.Color.Transparent;
            this.RestockBtn.BorderRadius = 27;
            this.RestockBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.RestockBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.RestockBtn.CheckedState.Font = new System.Drawing.Font("Hack Nerd Font", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestockBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.RestockBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.RestockBtn.CustomizableEdges.BottomRight = false;
            this.RestockBtn.CustomizableEdges.TopRight = false;
            this.RestockBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RestockBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RestockBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RestockBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RestockBtn.FillColor = System.Drawing.Color.Empty;
            this.RestockBtn.Font = new System.Drawing.Font("Hack Nerd Font", 14F);
            this.RestockBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.RestockBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(245)))));
            this.RestockBtn.Image = ((System.Drawing.Image)(resources.GetObject("RestockBtn.Image")));
            this.RestockBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RestockBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.RestockBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.RestockBtn.Location = new System.Drawing.Point(32, 499);
            this.RestockBtn.Name = "RestockBtn";
            this.RestockBtn.Size = new System.Drawing.Size(232, 57);
            this.RestockBtn.TabIndex = 13;
            this.RestockBtn.Text = "Restock";
            this.RestockBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RestockBtn.UseTransparentBackground = true;
            this.RestockBtn.Click += new System.EventHandler(this.RestockBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Animated = true;
            this.logoutBtn.AutoRoundedCorners = true;
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BorderColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BorderRadius = 27;
            this.logoutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.logoutBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.logoutBtn.CheckedState.Font = new System.Drawing.Font("Hack Nerd Font", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.logoutBtn.CustomizableEdges.BottomRight = false;
            this.logoutBtn.CustomizableEdges.TopRight = false;
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.FillColor = System.Drawing.Color.Empty;
            this.logoutBtn.Font = new System.Drawing.Font("Hack Nerd Font", 14F);
            this.logoutBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.logoutBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(245)))));
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutBtn.ImageSize = new System.Drawing.Size(45, 45);
            this.logoutBtn.Location = new System.Drawing.Point(32, 574);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(232, 57);
            this.logoutBtn.TabIndex = 13;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.logoutBtn.UseTransparentBackground = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Animated = true;
            this.settingsBtn.AutoRoundedCorners = true;
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.BorderColor = System.Drawing.Color.Transparent;
            this.settingsBtn.BorderRadius = 27;
            this.settingsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.settingsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.settingsBtn.CheckedState.Font = new System.Drawing.Font("Hack Nerd Font", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.settingsBtn.CustomizableEdges.BottomRight = false;
            this.settingsBtn.CustomizableEdges.TopRight = false;
            this.settingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsBtn.FillColor = System.Drawing.Color.Empty;
            this.settingsBtn.Font = new System.Drawing.Font("Hack Nerd Font", 14F);
            this.settingsBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.settingsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(245)))));
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.settingsBtn.Location = new System.Drawing.Point(32, 424);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(232, 57);
            this.settingsBtn.TabIndex = 13;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.settingsBtn.UseTransparentBackground = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.centerPanel.Controls.Add(this.employeeSetting1);
            this.centerPanel.Controls.Add(this.productRestock1);
            this.centerPanel.Controls.Add(this.customerManagement1);
            this.centerPanel.Controls.Add(this.productManagement1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.centerPanel.Location = new System.Drawing.Point(263, 47);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1145, 895);
            this.centerPanel.TabIndex = 17;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMinimize.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.BtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Image")));
            this.BtnMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMinimize.ImageRotate = 0F;
            this.BtnMinimize.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnMinimize.Location = new System.Drawing.Point(1319, -2);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.PressedState.ImageSize = new System.Drawing.Size(33, 33);
            this.BtnMinimize.Size = new System.Drawing.Size(38, 47);
            this.BtnMinimize.TabIndex = 10;
            this.BtnMinimize.UseTransparentBackground = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnExit.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnExit.ImageRotate = 0F;
            this.BtnExit.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnExit.Location = new System.Drawing.Point(1363, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.BtnExit.Size = new System.Drawing.Size(39, 46);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.UseTransparentBackground = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.Animated = true;
            this.productsBtn.AutoRoundedCorners = true;
            this.productsBtn.BackColor = System.Drawing.Color.Transparent;
            this.productsBtn.BorderColor = System.Drawing.Color.Transparent;
            this.productsBtn.BorderRadius = 27;
            this.productsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.productsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.productsBtn.CheckedState.Font = new System.Drawing.Font("Hack Nerd Font", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.productsBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.productsBtn.CustomizableEdges.BottomRight = false;
            this.productsBtn.CustomizableEdges.TopRight = false;
            this.productsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productsBtn.FillColor = System.Drawing.Color.Empty;
            this.productsBtn.Font = new System.Drawing.Font("Hack Nerd Font", 14F);
            this.productsBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.productsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(245)))));
            this.productsBtn.Image = ((System.Drawing.Image)(resources.GetObject("productsBtn.Image")));
            this.productsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.productsBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.productsBtn.Location = new System.Drawing.Point(32, 350);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(232, 57);
            this.productsBtn.TabIndex = 13;
            this.productsBtn.Text = "Products";
            this.productsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productsBtn.UseTransparentBackground = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.Animated = true;
            this.customerBtn.AutoRoundedCorners = true;
            this.customerBtn.BackColor = System.Drawing.Color.Transparent;
            this.customerBtn.BorderColor = System.Drawing.Color.Transparent;
            this.customerBtn.BorderRadius = 27;
            this.customerBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.customerBtn.Checked = true;
            this.customerBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.customerBtn.CheckedState.Font = new System.Drawing.Font("Hack Nerd Font", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.customerBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.customerBtn.CustomizableEdges.BottomRight = false;
            this.customerBtn.CustomizableEdges.TopRight = false;
            this.customerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerBtn.FillColor = System.Drawing.Color.Empty;
            this.customerBtn.Font = new System.Drawing.Font("Hack Nerd Font", 14F);
            this.customerBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.customerBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(245)))));
            this.customerBtn.Image = ((System.Drawing.Image)(resources.GetObject("customerBtn.Image")));
            this.customerBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customerBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.customerBtn.Location = new System.Drawing.Point(32, 276);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(232, 57);
            this.customerBtn.TabIndex = 13;
            this.customerBtn.Text = "Customer";
            this.customerBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.customerBtn.UseTransparentBackground = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.Controls.Add(this.pictureBox1);
            this.sideBarPanel.Controls.Add(this.employee_menu_label);
            this.sideBarPanel.Controls.Add(this.RestockBtn);
            this.sideBarPanel.Controls.Add(this.logoutBtn);
            this.sideBarPanel.Controls.Add(this.settingsBtn);
            this.sideBarPanel.Controls.Add(this.productsBtn);
            this.sideBarPanel.Controls.Add(this.customerBtn);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
            this.sideBarPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.sideBarPanel.Location = new System.Drawing.Point(0, 47);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(266, 895);
            this.sideBarPanel.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // upperBarPanel
            // 
            this.upperBarPanel.Controls.Add(this.BtnMinimize);
            this.upperBarPanel.Controls.Add(this.BtnExit);
            this.upperBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperBarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.upperBarPanel.Location = new System.Drawing.Point(0, 0);
            this.upperBarPanel.Name = "upperBarPanel";
            this.upperBarPanel.Size = new System.Drawing.Size(1408, 47);
            this.upperBarPanel.TabIndex = 16;
            // 
            // employeeSetting1
            // 
            this.employeeSetting1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.employeeSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeSetting1.Location = new System.Drawing.Point(0, 0);
            this.employeeSetting1.Name = "employeeSetting1";
            this.employeeSetting1.Size = new System.Drawing.Size(1145, 895);
            this.employeeSetting1.TabIndex = 5;
            // 
            // productRestock1
            // 
            this.productRestock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.productRestock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productRestock1.Location = new System.Drawing.Point(0, 0);
            this.productRestock1.Name = "productRestock1";
            this.productRestock1.Size = new System.Drawing.Size(1145, 895);
            this.productRestock1.TabIndex = 4;
            // 
            // customerManagement1
            // 
            this.customerManagement1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.customerManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerManagement1.Location = new System.Drawing.Point(0, 0);
            this.customerManagement1.Name = "customerManagement1";
            this.customerManagement1.Size = new System.Drawing.Size(1145, 895);
            this.customerManagement1.TabIndex = 3;
            // 
            // productManagement1
            // 
            this.productManagement1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.productManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productManagement1.Location = new System.Drawing.Point(0, 0);
            this.productManagement1.Name = "productManagement1";
            this.productManagement1.Size = new System.Drawing.Size(1145, 895);
            this.productManagement1.TabIndex = 2;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 942);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.sideBarPanel);
            this.Controls.Add(this.upperBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.centerPanel.ResumeLayout(false);
            this.sideBarPanel.ResumeLayout(false);
            this.sideBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.upperBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label employee_menu_label;
        private Guna.UI2.WinForms.Guna2Button RestockBtn;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2Button settingsBtn;
        private Guna.UI2.WinForms.Guna2Panel centerPanel;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMinimize;
        private Guna.UI2.WinForms.Guna2ImageButton BtnExit;
        private Guna.UI2.WinForms.Guna2Button productsBtn;
        private Guna.UI2.WinForms.Guna2Button customerBtn;
        private Guna.UI2.WinForms.Guna2GradientPanel sideBarPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel upperBarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private User_Controls.productManagement productManagement1;
        private User_Controls.customerManagement customerManagement1;
        private User_Controls.productRestock productRestock1;
        private User_Controls.employeeSetting employeeSetting1;
    }
}