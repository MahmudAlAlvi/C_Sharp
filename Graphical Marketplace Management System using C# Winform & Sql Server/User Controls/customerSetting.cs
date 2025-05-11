using Online_MarketPlace.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_MarketPlace.User_Controls
{
    public partial class customerSetting : UserControl
    {
        string customerUsername;
        Customer customerObj = new Customer();
        public customerSetting()
        {
            InitializeComponent();
            customerUsername = LoginForm.loggedInUsername;
            txtBoxOwnerUsername.Text = customerUsername;
            txtBoxOwnerUsername.ReadOnly = true;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtBoxOwnerUsername.Text) || !string.IsNullOrWhiteSpace(txtBoxOwnerPassword.Text) || !string.IsNullOrWhiteSpace(txtBoxOwnerNewPassword.Text))
            {
                if (txtBoxOwnerUsername.Text == customerUsername)
                {
                    if (txtBoxOwnerPassword.Text != txtBoxOwnerNewPassword.Text)
                    {
                        if (customerObj.customerPasswordChange(txtBoxOwnerUsername.Text, txtBoxOwnerPassword.Text, txtBoxOwnerNewPassword.Text))
                        {
                            MessageBox.Show("Password Updated Successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Updation Failed. Incorrect password provided.", "Incorrect Password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Current password and New Password must be different.", "Same Password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username, Provided Username doesn't matched with your Current Account Username", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please provide the * marked fields data", "No data provided!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtBoxOwnerUsername.Text = null;
            txtBoxOwnerPassword.Text = null;
            txtBoxOwnerNewPassword.Text = null;
            txtBoxOwnerUsername.ReadOnly = false;
        }
    }
}


