using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Online_MarketPlace.Forms;
using Online_MarketPlace.Classes;
using Online_MarketPlace.User_Controls;

namespace Online_MarketPlace
{
    public partial class LoginForm : Form
    {
        public static LoginForm lf;

        public static string loggedInUsername;

        LoginInfo obj = new LoginInfo();

        public Guna2TextBox infoForOtherForm;
        public LoginForm()
        {
            InitializeComponent();
            lf = this;
            infoForOtherForm = txtBox_idName_login;
        }

        public string GetWelcomeUserData()
        {
            return infoForOtherForm.Text;
        }

        private void login_close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void check_BoxShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Box_ShowPW.Checked)
            {
                txtBox_pw_login.UseSystemPasswordChar = false;
            }
            else
            {
                txtBox_pw_login.UseSystemPasswordChar = true;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtBox_pw_login.Text = null;
            txtBox_idName_login.Text = null;
        }

        private void txtBox_pw_login_Enter(object sender, EventArgs e)
        {
            if(check_Box_ShowPW.Checked)
            {
                txtBox_pw_login.UseSystemPasswordChar = false;
            }
            else
            {
                txtBox_pw_login.UseSystemPasswordChar = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBox_idName_login.Text;
            string password = txtBox_pw_login.Text;

            if (txtBox_idName_login.Text == null || txtBox_pw_login.Text == null)
            {
                MessageBox.Show("Fill the username/id & password field", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var sqlQueryOwner = obj.LoginAsOwner(username, password);
                var sqlQueryEmployee = obj.LoginAsEmployee(username, password);
                var sqlQueryCustomer = obj.LoginAsCustomer(username, password);

                if (obj.AuthenticateUser(sqlQueryOwner))
                {
                    OwnerForm o = new OwnerForm();
                    LoginInfo.GetUsername = username;
                    clear();
                    o.Show();
                    this.Hide();
                }
                else if (obj.AuthenticateUser(sqlQueryEmployee))
                {
                    loggedInUsername = txtBox_idName_login.Text;

                    EmployeeForm emp = new EmployeeForm();
                    clear();
                    emp.Show();
                    this.Hide();
                }
                else if (obj.AuthenticateUser(sqlQueryCustomer))
                {
                    //shop myShop = new shop();

                    loggedInUsername = txtBox_idName_login.Text;

                    CustomerForm c = new CustomerForm();
                    clear();
                    c.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please provide valid credentials.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerRegistration cr = new CustomerRegistration();
            this.Hide();
            cr.Show();
        }

        
        private void txtBox_idName_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_pw_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}