
namespace Online_MarketPlace
{
    partial class OwnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.sideBarPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.owner_menu_label = new System.Windows.Forms.Label();
            this.owner_pictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.OwnershipBtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.settingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.financeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.managementBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dashboardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.upperBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.centerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ownerDashboard1 = new Online_MarketPlace.User_Controls.ownerDashboard();
            this.ownership1 = new Online_MarketPlace.User_Controls.Ownership();
            this.ownerSettings1 = new Online_MarketPlace.User_Controls.ownerSettings();
            this.ownerFinance1 = new Online_MarketPlace.User_Controls.ownerFinance();
            this.ownerManagement1 = new Online_MarketPlace.User_Controls.ownerManagement();
            this.sideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.owner_pictureBox)).BeginInit();
            this.upperBarPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.Controls.Add(this.owner_menu_label);
            this.sideBarPanel.Controls.Add(this.owner_pictureBox);
            this.sideBarPanel.Controls.Add(this.OwnershipBtn);
            this.sideBarPanel.Controls.Add(this.logoutBtn);
            this.sideBarPanel.Controls.Add(this.settingsBtn);
            this.sideBarPanel.Controls.Add(this.financeBtn);
            this.sideBarPanel.Controls.Add(this.managementBtn);
            this.sideBarPanel.Controls.Add(this.dashboardBtn);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.sideBarPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sideBarPanel.Location = new System.Drawing.Point(0, 39);
            this.sideBarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(222, 746);
            this.sideBarPanel.TabIndex = 12;
            this.sideBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBarPanel_Paint);
            // 
            // owner_menu_label
            // 
            this.owner_menu_label.BackColor = System.Drawing.Color.Transparent;
            this.owner_menu_label.Font = new System.Drawing.Font("Verdana", 11F);
            this.owner_menu_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.owner_menu_label.Location = new System.Drawing.Point(0, 91);
            this.owner_menu_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.owner_menu_label.Name = "owner_menu_label";
            this.owner_menu_label.Size = new System.Drawing.Size(222, 40);
            this.owner_menu_label.TabIndex = 15;
            this.owner_menu_label.Text = "Welcome Text";
            this.owner_menu_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.owner_menu_label.Click += new System.EventHandler(this.owner_menu_label_Click);
            // 
            // owner_pictureBox
            // 
            this.owner_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.owner_pictureBox.FillColor = System.Drawing.Color.Transparent;
            this.owner_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("owner_pictureBox.Image")));
            this.owner_pictureBox.ImageRotate = 0F;
            this.owner_pictureBox.Location = new System.Drawing.Point(68, 16);
            this.owner_pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.owner_pictureBox.Name = "owner_pictureBox";
            this.owner_pictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.owner_pictureBox.Size = new System.Drawing.Size(87, 87);
            this.owner_pictureBox.TabIndex = 14;
            this.owner_pictureBox.TabStop = false;
            this.owner_pictureBox.UseTransparentBackground = true;
            this.owner_pictureBox.Click += new System.EventHandler(this.owner_pictureBox_Click);
            // 
            // OwnershipBtn
            // 
            this.OwnershipBtn.Animated = true;
            this.OwnershipBtn.AutoRoundedCorners = true;
            this.OwnershipBtn.BackColor = System.Drawing.Color.Transparent;
            this.OwnershipBtn.BorderColor = System.Drawing.Color.Transparent;
            this.OwnershipBtn.BorderRadius = 23;
            this.OwnershipBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.OwnershipBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.OwnershipBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnershipBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.OwnershipBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.OwnershipBtn.CustomizableEdges.BottomRight = false;
            this.OwnershipBtn.CustomizableEdges.TopRight = false;
            this.OwnershipBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OwnershipBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OwnershipBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OwnershipBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OwnershipBtn.FillColor = System.Drawing.Color.Empty;
            this.OwnershipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.OwnershipBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.OwnershipBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OwnershipBtn.Image = ((System.Drawing.Image)(resources.GetObject("OwnershipBtn.Image")));
            this.OwnershipBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OwnershipBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.OwnershipBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.OwnershipBtn.Location = new System.Drawing.Point(27, 436);
            this.OwnershipBtn.Margin = new System.Windows.Forms.Padding(2);
            this.OwnershipBtn.Name = "OwnershipBtn";
            this.OwnershipBtn.Size = new System.Drawing.Size(193, 48);
            this.OwnershipBtn.TabIndex = 13;
            this.OwnershipBtn.Text = "Ownership";
            this.OwnershipBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OwnershipBtn.TextOffset = new System.Drawing.Point(4, 0);
            this.OwnershipBtn.UseTransparentBackground = true;
            this.OwnershipBtn.Click += new System.EventHandler(this.OwnershipBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Animated = true;
            this.logoutBtn.AutoRoundedCorners = true;
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BorderColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BorderRadius = 23;
            this.logoutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.logoutBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.logoutBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.logoutBtn.CustomizableEdges.BottomRight = false;
            this.logoutBtn.CustomizableEdges.TopRight = false;
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.FillColor = System.Drawing.Color.Empty;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.logoutBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.logoutBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutBtn.ImageSize = new System.Drawing.Size(45, 45);
            this.logoutBtn.Location = new System.Drawing.Point(27, 501);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(193, 48);
            this.logoutBtn.TabIndex = 13;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.logoutBtn.TextOffset = new System.Drawing.Point(-8, 0);
            this.logoutBtn.UseTransparentBackground = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Animated = true;
            this.settingsBtn.AutoRoundedCorners = true;
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.BorderColor = System.Drawing.Color.Transparent;
            this.settingsBtn.BorderRadius = 23;
            this.settingsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.settingsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.settingsBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.settingsBtn.CustomizableEdges.BottomRight = false;
            this.settingsBtn.CustomizableEdges.TopRight = false;
            this.settingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsBtn.FillColor = System.Drawing.Color.Empty;
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.settingsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.settingsBtn.Location = new System.Drawing.Point(27, 371);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(193, 48);
            this.settingsBtn.TabIndex = 13;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.settingsBtn.TextOffset = new System.Drawing.Point(-5, 0);
            this.settingsBtn.UseTransparentBackground = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // financeBtn
            // 
            this.financeBtn.Animated = true;
            this.financeBtn.AutoRoundedCorners = true;
            this.financeBtn.BackColor = System.Drawing.Color.Transparent;
            this.financeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.financeBtn.BorderRadius = 23;
            this.financeBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.financeBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.financeBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financeBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.financeBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.financeBtn.CustomizableEdges.BottomRight = false;
            this.financeBtn.CustomizableEdges.TopRight = false;
            this.financeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.financeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.financeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.financeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.financeBtn.FillColor = System.Drawing.Color.Empty;
            this.financeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.financeBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.financeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.financeBtn.Image = ((System.Drawing.Image)(resources.GetObject("financeBtn.Image")));
            this.financeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.financeBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.financeBtn.Location = new System.Drawing.Point(27, 308);
            this.financeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.financeBtn.Name = "financeBtn";
            this.financeBtn.Size = new System.Drawing.Size(193, 48);
            this.financeBtn.TabIndex = 13;
            this.financeBtn.Text = "Finance";
            this.financeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.financeBtn.TextOffset = new System.Drawing.Point(-11, 0);
            this.financeBtn.UseTransparentBackground = true;
            this.financeBtn.Click += new System.EventHandler(this.financeBtn_Click);
            // 
            // managementBtn
            // 
            this.managementBtn.Animated = true;
            this.managementBtn.AutoRoundedCorners = true;
            this.managementBtn.BackColor = System.Drawing.Color.Transparent;
            this.managementBtn.BorderColor = System.Drawing.Color.Transparent;
            this.managementBtn.BorderRadius = 23;
            this.managementBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.managementBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.managementBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.managementBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.managementBtn.CustomizableEdges.BottomRight = false;
            this.managementBtn.CustomizableEdges.TopRight = false;
            this.managementBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.managementBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.managementBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.managementBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.managementBtn.FillColor = System.Drawing.Color.Empty;
            this.managementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.managementBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.managementBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.managementBtn.Image = ((System.Drawing.Image)(resources.GetObject("managementBtn.Image")));
            this.managementBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.managementBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.managementBtn.Location = new System.Drawing.Point(27, 245);
            this.managementBtn.Margin = new System.Windows.Forms.Padding(2);
            this.managementBtn.Name = "managementBtn";
            this.managementBtn.Size = new System.Drawing.Size(193, 48);
            this.managementBtn.TabIndex = 13;
            this.managementBtn.Text = "Management";
            this.managementBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.managementBtn.TextOffset = new System.Drawing.Point(7, 0);
            this.managementBtn.UseTransparentBackground = true;
            this.managementBtn.Click += new System.EventHandler(this.managementBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Animated = true;
            this.dashboardBtn.AutoRoundedCorners = true;
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.BorderColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.BorderRadius = 23;
            this.dashboardBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.dashboardBtn.Checked = true;
            this.dashboardBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.dashboardBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.dashboardBtn.CustomizableEdges.BottomRight = false;
            this.dashboardBtn.CustomizableEdges.TopRight = false;
            this.dashboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboardBtn.FillColor = System.Drawing.Color.Empty;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dashboardBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dashboardBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboardBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.dashboardBtn.Location = new System.Drawing.Point(27, 183);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(193, 48);
            this.dashboardBtn.TabIndex = 13;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dashboardBtn.UseTransparentBackground = true;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // upperBarPanel
            // 
            this.upperBarPanel.Controls.Add(this.BtnMinimize);
            this.upperBarPanel.Controls.Add(this.BtnExit);
            this.upperBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperBarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(52)))), ((int)(((byte)(201)))));
            this.upperBarPanel.Location = new System.Drawing.Point(0, 0);
            this.upperBarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.upperBarPanel.Name = "upperBarPanel";
            this.upperBarPanel.Size = new System.Drawing.Size(1173, 39);
            this.upperBarPanel.TabIndex = 13;
            this.upperBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.upperBarPanel_Paint);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMinimize.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Image")));
            this.BtnMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMinimize.ImageRotate = 0F;
            this.BtnMinimize.ImageSize = new System.Drawing.Size(37, 37);
            this.BtnMinimize.Location = new System.Drawing.Point(1102, -1);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnMinimize.Size = new System.Drawing.Size(32, 39);
            this.BtnMinimize.TabIndex = 10;
            this.BtnMinimize.UseTransparentBackground = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnExit.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnExit.ImageRotate = 0F;
            this.BtnExit.ImageSize = new System.Drawing.Size(38, 38);
            this.BtnExit.Location = new System.Drawing.Point(1138, -1);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnExit.Size = new System.Drawing.Size(32, 38);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.UseTransparentBackground = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.centerPanel.Controls.Add(this.ownerDashboard1);
            this.centerPanel.Controls.Add(this.ownership1);
            this.centerPanel.Controls.Add(this.ownerSettings1);
            this.centerPanel.Controls.Add(this.ownerFinance1);
            this.centerPanel.Controls.Add(this.ownerManagement1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.centerPanel.Location = new System.Drawing.Point(219, 39);
            this.centerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(954, 746);
            this.centerPanel.TabIndex = 14;
            // 
            // ownerDashboard1
            // 
            this.ownerDashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ownerDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownerDashboard1.employeeSalary = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ownerDashboard1.Location = new System.Drawing.Point(0, 0);
            this.ownerDashboard1.Margin = new System.Windows.Forms.Padding(2);
            this.ownerDashboard1.Name = "ownerDashboard1";
            this.ownerDashboard1.productExpense = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ownerDashboard1.Size = new System.Drawing.Size(954, 746);
            this.ownerDashboard1.TabIndex = 0;
            this.ownerDashboard1.totalExpense = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ownerDashboard1.totalOrders = 0;
            this.ownerDashboard1.totalProfit = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ownerDashboard1.totalRevenue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ownerDashboard1.totalSales = 0;
            this.ownerDashboard1.Load += new System.EventHandler(this.ownerDashboard1_Load);
            // 
            // ownership1
            // 
            this.ownership1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ownership1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownership1.Location = new System.Drawing.Point(0, 0);
            this.ownership1.Margin = new System.Windows.Forms.Padding(2);
            this.ownership1.Name = "ownership1";
            this.ownership1.Size = new System.Drawing.Size(954, 746);
            this.ownership1.TabIndex = 4;
            // 
            // ownerSettings1
            // 
            this.ownerSettings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ownerSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownerSettings1.Location = new System.Drawing.Point(0, 0);
            this.ownerSettings1.Margin = new System.Windows.Forms.Padding(2);
            this.ownerSettings1.Name = "ownerSettings1";
            this.ownerSettings1.Size = new System.Drawing.Size(954, 746);
            this.ownerSettings1.TabIndex = 3;
            // 
            // ownerFinance1
            // 
            this.ownerFinance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ownerFinance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownerFinance1.Location = new System.Drawing.Point(0, 0);
            this.ownerFinance1.Margin = new System.Windows.Forms.Padding(2);
            this.ownerFinance1.Name = "ownerFinance1";
            this.ownerFinance1.Size = new System.Drawing.Size(954, 746);
            this.ownerFinance1.TabIndex = 2;
            // 
            // ownerManagement1
            // 
            this.ownerManagement1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ownerManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownerManagement1.Location = new System.Drawing.Point(0, 0);
            this.ownerManagement1.Margin = new System.Windows.Forms.Padding(2);
            this.ownerManagement1.Name = "ownerManagement1";
            this.ownerManagement1.Size = new System.Drawing.Size(954, 746);
            this.ownerManagement1.TabIndex = 1;
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1173, 785);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.sideBarPanel);
            this.Controls.Add(this.upperBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OwnerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.sideBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.owner_pictureBox)).EndInit();
            this.upperBarPanel.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel sideBarPanel;
        private Guna.UI2.WinForms.Guna2Button dashboardBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox owner_pictureBox;
        private System.Windows.Forms.Label owner_menu_label;
        private Guna.UI2.WinForms.Guna2Button OwnershipBtn;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2Button settingsBtn;
        private Guna.UI2.WinForms.Guna2Button financeBtn;
        private Guna.UI2.WinForms.Guna2Button managementBtn;
        private Guna.UI2.WinForms.Guna2Panel upperBarPanel;
        private Guna.UI2.WinForms.Guna2Panel centerPanel;
        private Guna.UI2.WinForms.Guna2ImageButton BtnExit;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMinimize;
        private User_Controls.ownerDashboard ownerDashboard1;
        private User_Controls.ownerManagement ownerManagement1;
        private User_Controls.ownerFinance ownerFinance1;
        private User_Controls.ownerSettings ownerSettings1;
        private User_Controls.Ownership ownership1;
    }
}