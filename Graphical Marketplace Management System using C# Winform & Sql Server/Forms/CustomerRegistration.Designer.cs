
namespace Online_MarketPlace.Forms
{
    partial class CustomerRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRegistration));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.login_close_btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtBox_name_reg = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.txtBox_pass_reg = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBox_bank_reg = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.successPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.successPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
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
            this.login_close_btn.Location = new System.Drawing.Point(599, 4);
            this.login_close_btn.Name = "login_close_btn";
            this.login_close_btn.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.login_close_btn.Size = new System.Drawing.Size(33, 31);
            this.login_close_btn.TabIndex = 10;
            this.login_close_btn.UseTransparentBackground = true;
            this.login_close_btn.Click += new System.EventHandler(this.login_close_btn_Click);
            // 
            // txtBox_name_reg
            // 
            this.txtBox_name_reg.BorderRadius = 15;
            this.txtBox_name_reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_name_reg.DefaultText = "";
            this.txtBox_name_reg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBox_name_reg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBox_name_reg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_name_reg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_name_reg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_name_reg.Font = new System.Drawing.Font("SF Mono", 12F);
            this.txtBox_name_reg.ForeColor = System.Drawing.Color.Black;
            this.txtBox_name_reg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_name_reg.Location = new System.Drawing.Point(91, 139);
            this.txtBox_name_reg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBox_name_reg.Name = "txtBox_name_reg";
            this.txtBox_name_reg.PasswordChar = '\0';
            this.txtBox_name_reg.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBox_name_reg.PlaceholderText = "Enter your nickname";
            this.txtBox_name_reg.SelectedText = "";
            this.txtBox_name_reg.Size = new System.Drawing.Size(438, 45);
            this.txtBox_name_reg.TabIndex = 11;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Animated = true;
            this.BtnCreate.AutoRoundedCorners = true;
            this.BtnCreate.BorderRadius = 23;
            this.BtnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.BtnCreate.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.BtnCreate.ForeColor = System.Drawing.Color.White;
            this.BtnCreate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.BtnCreate.Location = new System.Drawing.Point(91, 343);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(147, 49);
            this.BtnCreate.TabIndex = 12;
            this.BtnCreate.Text = "Sign Up";
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.registrationLabel.Location = new System.Drawing.Point(83, 68);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(461, 46);
            this.registrationLabel.TabIndex = 13;
            this.registrationLabel.Text = "Customer Registration";
            // 
            // txtBox_pass_reg
            // 
            this.txtBox_pass_reg.BorderRadius = 15;
            this.txtBox_pass_reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_pass_reg.DefaultText = "";
            this.txtBox_pass_reg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBox_pass_reg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBox_pass_reg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_pass_reg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_pass_reg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_pass_reg.Font = new System.Drawing.Font("SF Mono", 12F);
            this.txtBox_pass_reg.ForeColor = System.Drawing.Color.Black;
            this.txtBox_pass_reg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_pass_reg.Location = new System.Drawing.Point(91, 207);
            this.txtBox_pass_reg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBox_pass_reg.Name = "txtBox_pass_reg";
            this.txtBox_pass_reg.PasswordChar = '\0';
            this.txtBox_pass_reg.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBox_pass_reg.PlaceholderText = "Enter your password";
            this.txtBox_pass_reg.SelectedText = "";
            this.txtBox_pass_reg.Size = new System.Drawing.Size(438, 45);
            this.txtBox_pass_reg.TabIndex = 11;
            // 
            // txtBox_bank_reg
            // 
            this.txtBox_bank_reg.BorderRadius = 15;
            this.txtBox_bank_reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_bank_reg.DefaultText = "";
            this.txtBox_bank_reg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBox_bank_reg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBox_bank_reg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_bank_reg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_bank_reg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_bank_reg.Font = new System.Drawing.Font("SF Mono", 12F);
            this.txtBox_bank_reg.ForeColor = System.Drawing.Color.Black;
            this.txtBox_bank_reg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_bank_reg.Location = new System.Drawing.Point(91, 275);
            this.txtBox_bank_reg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBox_bank_reg.Name = "txtBox_bank_reg";
            this.txtBox_bank_reg.PasswordChar = '\0';
            this.txtBox_bank_reg.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBox_bank_reg.PlaceholderText = "Enter your Bank A/C";
            this.txtBox_bank_reg.SelectedText = "";
            this.txtBox_bank_reg.Size = new System.Drawing.Size(438, 45);
            this.txtBox_bank_reg.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Animated = true;
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BorderRadius = 23;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(397, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 49);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Animated = true;
            this.btnSignIn.AutoRoundedCorners = true;
            this.btnSignIn.BorderRadius = 23;
            this.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSignIn.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSignIn.Location = new System.Drawing.Point(244, 343);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(147, 49);
            this.btnSignIn.TabIndex = 12;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSuccess.Location = new System.Drawing.Point(168, 6);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(113, 38);
            this.lblSuccess.TabIndex = 14;
            this.lblSuccess.Text = "Success";
            this.lblSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // successPanel
            // 
            this.successPanel.Controls.Add(this.label1);
            this.successPanel.Controls.Add(this.lblPassword);
            this.successPanel.Controls.Add(this.lblUsername);
            this.successPanel.Controls.Add(this.lblSuccess);
            this.successPanel.Location = new System.Drawing.Point(91, 416);
            this.successPanel.Name = "successPanel";
            this.successPanel.Size = new System.Drawing.Size(438, 168);
            this.successPanel.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(58, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Note: Please store the username and password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(118, 98);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 32);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(118, 54);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(122, 32);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(636, 602);
            this.Controls.Add(this.successPanel);
            this.Controls.Add(this.txtBox_bank_reg);
            this.Controls.Add(this.txtBox_pass_reg);
            this.Controls.Add(this.txtBox_name_reg);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.login_close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerRegistration";
            this.successPanel.ResumeLayout(false);
            this.successPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton login_close_btn;
        private Guna.UI2.WinForms.Guna2TextBox txtBox_bank_reg;
        private Guna.UI2.WinForms.Guna2TextBox txtBox_pass_reg;
        private Guna.UI2.WinForms.Guna2TextBox txtBox_name_reg;
        private Guna.UI2.WinForms.Guna2Button BtnCreate;
        private System.Windows.Forms.Label registrationLabel;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Panel successPanel;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
    }
}