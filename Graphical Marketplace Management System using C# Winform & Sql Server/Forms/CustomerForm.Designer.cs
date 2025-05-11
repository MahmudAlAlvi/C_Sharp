
namespace Online_MarketPlace.Forms
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.upperBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.sideBarPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customer_menu_label = new System.Windows.Forms.Label();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.settingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.shopBtn = new Guna.UI2.WinForms.Guna2Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.shopping1 = new Online_MarketPlace.User_Controls.Shopping();
            this.customerSetting1 = new Online_MarketPlace.User_Controls.customerSetting();
            this.upperBarPanel.SuspendLayout();
            this.sideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperBarPanel
            // 
            this.upperBarPanel.Controls.Add(this.BtnMinimize);
            this.upperBarPanel.Controls.Add(this.BtnExit);
            this.upperBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperBarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.upperBarPanel.Location = new System.Drawing.Point(0, 0);
            this.upperBarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.upperBarPanel.Name = "upperBarPanel";
            this.upperBarPanel.Size = new System.Drawing.Size(1173, 39);
            this.upperBarPanel.TabIndex = 19;
            this.upperBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.upperBarPanel_Paint);
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
            this.BtnMinimize.Location = new System.Drawing.Point(1106, -2);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.PressedState.ImageSize = new System.Drawing.Size(33, 33);
            this.BtnMinimize.Size = new System.Drawing.Size(32, 39);
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
            this.BtnExit.Location = new System.Drawing.Point(1138, -1);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.BtnExit.Size = new System.Drawing.Size(32, 38);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.UseTransparentBackground = true;
            this.BtnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.Controls.Add(this.pictureBox1);
            this.sideBarPanel.Controls.Add(this.customer_menu_label);
            this.sideBarPanel.Controls.Add(this.logoutBtn);
            this.sideBarPanel.Controls.Add(this.settingsBtn);
            this.sideBarPanel.Controls.Add(this.shopBtn);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
            this.sideBarPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.sideBarPanel.Location = new System.Drawing.Point(0, 39);
            this.sideBarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(222, 746);
            this.sideBarPanel.TabIndex = 20;
            this.sideBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBarPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // customer_menu_label
            // 
            this.customer_menu_label.BackColor = System.Drawing.Color.Transparent;
            this.customer_menu_label.Font = new System.Drawing.Font("Verdana", 11F);
            this.customer_menu_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.customer_menu_label.Location = new System.Drawing.Point(-1, 108);
            this.customer_menu_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customer_menu_label.Name = "customer_menu_label";
            this.customer_menu_label.Size = new System.Drawing.Size(222, 78);
            this.customer_menu_label.TabIndex = 15;
            this.customer_menu_label.Text = "Welcome Text";
            this.customer_menu_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customer_menu_label.Click += new System.EventHandler(this.customer_menu_label_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Animated = true;
            this.logoutBtn.AutoRoundedCorners = true;
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BorderColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BorderRadius = 23;
            this.logoutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.logoutBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.logoutBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.logoutBtn.CustomizableEdges.BottomRight = false;
            this.logoutBtn.CustomizableEdges.TopRight = false;
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.FillColor = System.Drawing.Color.Empty;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.logoutBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.logoutBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(245)))));
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutBtn.ImageOffset = new System.Drawing.Point(-5, 0);
            this.logoutBtn.ImageSize = new System.Drawing.Size(45, 45);
            this.logoutBtn.Location = new System.Drawing.Point(29, 422);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(193, 48);
            this.logoutBtn.TabIndex = 13;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.logoutBtn.TextOffset = new System.Drawing.Point(-9, 0);
            this.logoutBtn.UseTransparentBackground = true;
            this.logoutBtn.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Animated = true;
            this.settingsBtn.AutoRoundedCorners = true;
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.BorderColor = System.Drawing.Color.Transparent;
            this.settingsBtn.BorderRadius = 23;
            this.settingsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.settingsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.settingsBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.settingsBtn.CustomizableEdges.BottomRight = false;
            this.settingsBtn.CustomizableEdges.TopRight = false;
            this.settingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsBtn.FillColor = System.Drawing.Color.Empty;
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.settingsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(245)))));
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.settingsBtn.Location = new System.Drawing.Point(29, 362);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(193, 48);
            this.settingsBtn.TabIndex = 13;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.settingsBtn.UseTransparentBackground = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // shopBtn
            // 
            this.shopBtn.Animated = true;
            this.shopBtn.AutoRoundedCorners = true;
            this.shopBtn.BackColor = System.Drawing.Color.Transparent;
            this.shopBtn.BorderColor = System.Drawing.Color.Transparent;
            this.shopBtn.BorderRadius = 23;
            this.shopBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.shopBtn.Checked = true;
            this.shopBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.shopBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.shopBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.shopBtn.CustomizableEdges.BottomRight = false;
            this.shopBtn.CustomizableEdges.TopRight = false;
            this.shopBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.shopBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.shopBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.shopBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.shopBtn.FillColor = System.Drawing.Color.Empty;
            this.shopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.shopBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.shopBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(155)))), ((int)(((byte)(245)))));
            this.shopBtn.Image = ((System.Drawing.Image)(resources.GetObject("shopBtn.Image")));
            this.shopBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.shopBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.shopBtn.Location = new System.Drawing.Point(29, 300);
            this.shopBtn.Margin = new System.Windows.Forms.Padding(2);
            this.shopBtn.Name = "shopBtn";
            this.shopBtn.Size = new System.Drawing.Size(193, 48);
            this.shopBtn.TabIndex = 13;
            this.shopBtn.Text = "Shop";
            this.shopBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shopBtn.TextOffset = new System.Drawing.Point(-35, 0);
            this.shopBtn.UseTransparentBackground = true;
            this.shopBtn.Click += new System.EventHandler(this.shopBtn_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.shopping1);
            this.centerPanel.Controls.Add(this.customerSetting1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(222, 39);
            this.centerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(951, 746);
            this.centerPanel.TabIndex = 21;
            // 
            // shopping1
            // 
            this.shopping1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopping1.Location = new System.Drawing.Point(0, 0);
            this.shopping1.Margin = new System.Windows.Forms.Padding(2);
            this.shopping1.Name = "shopping1";
            this.shopping1.Size = new System.Drawing.Size(951, 746);
            this.shopping1.TabIndex = 1;
            this.shopping1.Load += new System.EventHandler(this.shopping1_Load);
            // 
            // customerSetting1
            // 
            this.customerSetting1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.customerSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerSetting1.Location = new System.Drawing.Point(0, 0);
            this.customerSetting1.Margin = new System.Windows.Forms.Padding(2);
            this.customerSetting1.Name = "customerSetting1";
            this.customerSetting1.Size = new System.Drawing.Size(951, 746);
            this.customerSetting1.TabIndex = 0;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1173, 785);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.sideBarPanel);
            this.Controls.Add(this.upperBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.upperBarPanel.ResumeLayout(false);
            this.sideBarPanel.ResumeLayout(false);
            this.sideBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.centerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel upperBarPanel;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMinimize;
        private Guna.UI2.WinForms.Guna2ImageButton BtnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel sideBarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label customer_menu_label;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2Button settingsBtn;
        private Guna.UI2.WinForms.Guna2Button shopBtn;
        private System.Windows.Forms.Panel centerPanel;
        private User_Controls.customerSetting customerSetting1;
        private User_Controls.Shopping shopping1;
    }
}