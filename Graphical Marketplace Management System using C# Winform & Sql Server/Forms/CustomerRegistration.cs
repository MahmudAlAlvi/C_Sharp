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

namespace Online_MarketPlace.Forms
{
    public partial class CustomerRegistration : Form
    {
        Timer successTimer = new Timer();
        public CustomerRegistration()
        {
            InitializeComponent();

            successPanel.Visible = false;

            successTimer.Interval = 12000;
            successTimer.Tick += new EventHandler(SuccessTimer_Tick);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtBox_name_reg.Text = null;
            txtBox_pass_reg.Text = null;
            txtBox_bank_reg.Text = null;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void SuccessTimer_Tick(object sender, EventArgs e)
        {
            successTimer.Stop();
            HideSuccessPanel();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Employee obj = new Employee();
                if(string.IsNullOrWhiteSpace(txtBox_name_reg.Text) || string.IsNullOrWhiteSpace(txtBox_pass_reg.Text) || string.IsNullOrWhiteSpace(txtBox_pass_reg.Text))
                {
                    MessageBox.Show("Please provide Name, Password and a Valid Bank Account number.", "Invalid Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string name = txtBox_name_reg.Text;
                    string password = txtBox_pass_reg.Text;
                    long bankAC = Int64.Parse(txtBox_bank_reg.Text);
                    string membership = "Regular";

                    if(!obj.IsBankAC_AlreadyUsed(bankAC) && obj.createNewBankForCustomer(bankAC))
                    {
                        if (obj.InsertDataIntoDatabase(name, password, membership, bankAC))
                        {
                            lblUsername.Text = $"Username: {obj.getNewCustomerUsername(bankAC)}";
                            lblPassword.Text = $"Password: {txtBox_pass_reg.Text}";
                            successPanel.Visible = true;
                            successTimer.Start();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create new customer account.", "Account creation failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have provided invalid Bank Account Number.", "inavlid credentials!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Please provide the valid data format:\nFor name and password: string type\nBank Account: number type", "Invalid Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Clear();
            }
        }

        private void HideSuccessPanel()
        {
            successPanel.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            successTimer.Stop();
            HideSuccessPanel();
        }

        private void login_close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
