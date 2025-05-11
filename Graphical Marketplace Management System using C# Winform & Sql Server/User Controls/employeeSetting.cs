using Online_MarketPlace.Classes;
using Online_MarketPlace.Forms;
using System;
using System.Windows.Forms;

namespace Online_MarketPlace.User_Controls
{
    public partial class employeeSetting : UserControl
    {
        string employeeUsername;

        Employee obj = new Employee();
        public employeeSetting()
        {
            InitializeComponent();
            employeeUsername = LoginForm.loggedInUsername;
            txtBoxEmployeeUsername.ReadOnly = true;
            txtBoxEmployeeUsername.Text = employeeUsername;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtBoxEmployeeUsername.Text = null;
            txtBoxEmployeePassword.Text = null;
            txtBoxEmployeeNewPassword.Text = null;

            txtBoxEmployeeUsername.ReadOnly = false;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtBoxEmployeeUsername.Text) || string.IsNullOrWhiteSpace(txtBoxEmployeePassword.Text) || string.IsNullOrWhiteSpace(txtBoxEmployeeNewPassword.Text))
            {
                MessageBox.Show("Please provide all info with their valid data format\nUsername: String type\nPassword: String type", "Info format invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(employeeUsername == txtBoxEmployeeUsername.Text)
                {
                    if (obj.employeePasswordChange(txtBoxEmployeeUsername.Text, txtBoxEmployeePassword.Text, txtBoxEmployeeNewPassword.Text))
                    {
                        MessageBox.Show("Password Updated successfully...", "Password Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password, Wrong info given or both password are same..", "Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter the Username of the current logged in Username", "Different username from the logged in user!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void employeeSetting_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxGif2_Click(object sender, EventArgs e)
        {

        }
    }
}