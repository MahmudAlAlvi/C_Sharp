using Online_MarketPlace.Classes;
using System;
using System.Windows.Forms;

namespace Online_MarketPlace.User_Controls
{
    public partial class ownerSettings : UserControl
    {
        public ownerSettings()
        {
            InitializeComponent();
        }

        OwnerSetting obj = new OwnerSetting();

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtBoxOwnerID.Text = null;
            txtBoxOwnerUsername.Text = null;
            txtBoxOwnerPassword.Text = null;
            txtBoxOwnerNewPassword.Text = null;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxOwnerID.Text) || string.IsNullOrEmpty(txtBoxOwnerUsername.Text) ||
        string.IsNullOrEmpty(txtBoxOwnerPassword.Text) || string.IsNullOrEmpty(txtBoxOwnerNewPassword.Text))
            {
                MessageBox.Show("Required information not provided.", "Information Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string id = txtBoxOwnerID.Text;
                string username = txtBoxOwnerUsername.Text;
                string oldPassword = txtBoxOwnerPassword.Text;
                string newPassword = txtBoxOwnerNewPassword.Text;
                try
                {
                    int ownerid = int.Parse(id);
                    if(obj.currentUserAuthertication(ownerid, username, oldPassword))
                    {
                        if(obj.updatePassword(username, oldPassword, newPassword))
                        {
                            MessageBox.Show("Password updated successfully..", "Updation Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex.Message} ID must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBoxGif1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxGif2_Click(object sender, EventArgs e)
        {

        }

        private void ownerSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
