using System;
using Online_MarketPlace.User_Controls;
using System.Windows.Forms;

namespace Online_MarketPlace.Forms
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            customerManagement1.BringToFront();
            string sharedData = LoginForm.lf.GetWelcomeUserData();
            employee_menu_label.Text = $"Hello, {sharedData}";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.lf.Show();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            customerManagement1.BringToFront();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            employeeSetting1.BringToFront();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            productManagement1.BringToFront();
        }

        private void RestockBtn_Click(object sender, EventArgs e)
        {
            productRestock1.BringToFront();
        }
    }
}
