
namespace Online_MarketPlace
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtBox_idName_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GroupBox_login = new Guna.UI2.WinForms.Guna2GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.check_Box_ShowPW = new System.Windows.Forms.CheckBox();
            this.txtBox_pw_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.login_close_btn = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            this.GroupBox_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtBox_idName_login
            // 
            this.txtBox_idName_login.BorderRadius = 15;
            this.txtBox_idName_login.BorderThickness = 0;
            this.txtBox_idName_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_idName_login.DefaultText = "";
            this.txtBox_idName_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBox_idName_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBox_idName_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_idName_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_idName_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_idName_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBox_idName_login.ForeColor = System.Drawing.Color.Black;
            this.txtBox_idName_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_idName_login.Location = new System.Drawing.Point(19, 93);
            this.txtBox_idName_login.Margin = new System.Windows.Forms.Padding(5);
            this.txtBox_idName_login.Name = "txtBox_idName_login";
            this.txtBox_idName_login.PasswordChar = '\0';
            this.txtBox_idName_login.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBox_idName_login.PlaceholderText = "Enter your username";
            this.txtBox_idName_login.SelectedText = "";
            this.txtBox_idName_login.Size = new System.Drawing.Size(365, 38);
            this.txtBox_idName_login.TabIndex = 0;
            this.txtBox_idName_login.TextChanged += new System.EventHandler(this.txtBox_idName_login_TextChanged);
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("loginPictureBox.Image")));
            this.loginPictureBox.ImageRotate = 0F;
            this.loginPictureBox.Location = new System.Drawing.Point(0, 0);
            this.loginPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(463, 502);
            this.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPictureBox.TabIndex = 7;
            this.loginPictureBox.TabStop = false;
            // 
            // GroupBox_login
            // 
            this.GroupBox_login.BorderThickness = 0;
            this.GroupBox_login.Controls.Add(this.linkLabel1);
            this.GroupBox_login.Controls.Add(this.check_Box_ShowPW);
            this.GroupBox_login.Controls.Add(this.txtBox_pw_login);
            this.GroupBox_login.Controls.Add(this.txtBox_idName_login);
            this.GroupBox_login.Controls.Add(this.BtnLogin);
            this.GroupBox_login.Controls.Add(this.BtnClear);
            this.GroupBox_login.Controls.Add(this.loginLabel);
            this.GroupBox_login.CustomBorderColor = System.Drawing.Color.Empty;
            this.GroupBox_login.FillColor = System.Drawing.Color.Empty;
            this.GroupBox_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupBox_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox_login.Location = new System.Drawing.Point(483, 95);
            this.GroupBox_login.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox_login.Name = "GroupBox_login";
            this.GroupBox_login.Size = new System.Drawing.Size(408, 316);
            this.GroupBox_login.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(30, 282);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(345, 20);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "New User? Click here to Sign up as a new customer";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // check_Box_ShowPW
            // 
            this.check_Box_ShowPW.AutoSize = true;
            this.check_Box_ShowPW.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Box_ShowPW.Location = new System.Drawing.Point(21, 191);
            this.check_Box_ShowPW.Margin = new System.Windows.Forms.Padding(2);
            this.check_Box_ShowPW.Name = "check_Box_ShowPW";
            this.check_Box_ShowPW.Size = new System.Drawing.Size(149, 22);
            this.check_Box_ShowPW.TabIndex = 8;
            this.check_Box_ShowPW.Text = "Show password";
            this.check_Box_ShowPW.UseVisualStyleBackColor = true;
            this.check_Box_ShowPW.CheckedChanged += new System.EventHandler(this.check_BoxShowPW_CheckedChanged);
            // 
            // txtBox_pw_login
            // 
            this.txtBox_pw_login.BorderRadius = 15;
            this.txtBox_pw_login.BorderThickness = 0;
            this.txtBox_pw_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_pw_login.DefaultText = "";
            this.txtBox_pw_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBox_pw_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBox_pw_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_pw_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_pw_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_pw_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBox_pw_login.ForeColor = System.Drawing.Color.Black;
            this.txtBox_pw_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_pw_login.Location = new System.Drawing.Point(19, 148);
            this.txtBox_pw_login.Margin = new System.Windows.Forms.Padding(5);
            this.txtBox_pw_login.Name = "txtBox_pw_login";
            this.txtBox_pw_login.PasswordChar = '\0';
            this.txtBox_pw_login.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBox_pw_login.PlaceholderText = "Enter your password";
            this.txtBox_pw_login.SelectedText = "";
            this.txtBox_pw_login.Size = new System.Drawing.Size(365, 38);
            this.txtBox_pw_login.TabIndex = 0;
            this.txtBox_pw_login.TextChanged += new System.EventHandler(this.txtBox_pw_login_TextChanged);
            this.txtBox_pw_login.Enter += new System.EventHandler(this.txtBox_pw_login_Enter);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Animated = true;
            this.BtnLogin.AutoRoundedCorners = true;
            this.BtnLogin.BorderRadius = 19;
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.BtnLogin.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.BtnLogin.Location = new System.Drawing.Point(21, 229);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(112, 41);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "Log In";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Animated = true;
            this.BtnClear.AutoRoundedCorners = true;
            this.BtnClear.BorderRadius = 19;
            this.BtnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.BtnClear.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.BtnClear.Location = new System.Drawing.Point(272, 229);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(112, 41);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Clear";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(1, 30);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(415, 39);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "ALVIZ ONLINE MARKET";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // login_close_btn
            // 
            this.login_close_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_close_btn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.login_close_btn.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.login_close_btn.Image = ((System.Drawing.Image)(resources.GetObject("login_close_btn.Image")));
            this.login_close_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.login_close_btn.ImageRotate = 0F;
            this.login_close_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.login_close_btn.Location = new System.Drawing.Point(880, 2);
            this.login_close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.login_close_btn.Name = "login_close_btn";
            this.login_close_btn.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.login_close_btn.Size = new System.Drawing.Size(26, 28);
            this.login_close_btn.TabIndex = 9;
            this.login_close_btn.UseTransparentBackground = true;
            this.login_close_btn.Click += new System.EventHandler(this.login_close_btn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(910, 502);
            this.Controls.Add(this.login_close_btn);
            this.Controls.Add(this.GroupBox_login);
            this.Controls.Add(this.loginPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Shop Log In";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            this.GroupBox_login.ResumeLayout(false);
            this.GroupBox_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtBox_idName_login;
        private Guna.UI2.WinForms.Guna2PictureBox loginPictureBox;
        private Guna.UI2.WinForms.Guna2GroupBox GroupBox_login;
        private Guna.UI2.WinForms.Guna2ImageButton login_close_btn;
        private System.Windows.Forms.Label loginLabel;
        private Guna.UI2.WinForms.Guna2TextBox txtBox_pw_login;
        private System.Windows.Forms.CheckBox check_Box_ShowPW;
        private Guna.UI2.WinForms.Guna2Button BtnClear;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

