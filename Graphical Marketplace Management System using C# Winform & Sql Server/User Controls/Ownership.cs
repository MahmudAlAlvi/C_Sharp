using Online_MarketPlace.Classes;
using System;
using System.Windows.Forms;

namespace Online_MarketPlace.User_Controls
{
    public partial class Ownership : UserControl
    {
        public Ownership()
        {
            InitializeComponent();
        }
        
        OwnershipHandover obj = new OwnershipHandover();

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtBoxCurrentOwnerUsername.Text = null;
            txtBoxCurrentOwnerPassword.Text = null;
            txtBoxCurrentOwnerPasswordRewrite.Text = null;
            txtBoxNewOwnerName.Text = null;
            txtBoxNewOwnerPassword.Text = null;
        }

        private void btnHandover_Click(object sender, EventArgs e)
        {
            if(obj.isInfoEmpty(txtBoxCurrentOwnerUsername.Text, txtBoxCurrentOwnerPassword.Text, txtBoxCurrentOwnerPasswordRewrite.Text, txtBoxNewOwnerName.Text, txtBoxNewOwnerPassword.Text))
            {
                MessageBox.Show("Must fill the * marked fields..", "Not enough info given!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (obj.verifyBothPassword(txtBoxCurrentOwnerPassword.Text, txtBoxCurrentOwnerPasswordRewrite.Text))
                {
                    if (obj.verifyOldOwner(txtBoxCurrentOwnerUsername.Text, txtBoxCurrentOwnerPassword.Text))
                    {
                        if (obj.IsNameValid(txtBoxNewOwnerName.Text))
                        {
                            if (obj.Handover(txtBoxNewOwnerName.Text, txtBoxNewOwnerPassword.Text, txtBoxCurrentOwnerUsername.Text))
                            {
                                MessageBox.Show("Busingess Handovered!", "Congratulations! You have successfully handover the business.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                clear();
                            }
                            else
                            {
                                MessageBox.Show("Something wrong. Maybe invalid info given.", "Handover Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("New Owner name can contain only letters (Without Space)", "Invalid Name Format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong info of Current Owner..", "Invalid info!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Current Owner Both Password Didn't Match", "Invalid password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
