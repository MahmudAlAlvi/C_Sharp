using System;
using Online_MarketPlace.Classes;
using System.Windows.Forms;

namespace Online_MarketPlace.User_Controls
{
    public partial class ownerManagement : UserControl
    {
        EmployeeManagement obj = new EmployeeManagement();
        public ownerManagement()
        {
            InitializeComponent();
            joiningDateTimePicker.Value = DateTime.Today;

            showGridDataInfo();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (isInfoEmpty())
            {
                MessageBox.Show("Must fill the * marked fields..", "Information missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (obj.IsNameValid(txtBoxEmpName.Text))
                    {
                        if (obj.InsertDataIntoDatabase(txtBoxEmpName.Text, txtBoxEmpPass.Text, Convert.ToDecimal(txtBoxEmpSalary.Text), joiningDateTimePicker.Value))
                        {
                            MessageBox.Show("New Employee Recruited Successfully..", "Data Insertion Successs!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showGridDataInfo();
                        }
                        else
                        {
                            MessageBox.Show("New Employee Recruiment Failed..", "Data Insertion Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Name can only contain letters (Without Space).", "Invalid Name format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message} Salary must be a number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showGridDataInfo()
        {
            employeeDataGridView.DataSource = obj.LoadData();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }
        private bool isInfoEmpty()
        {
            bool check = false;
            if (string.IsNullOrEmpty(txtBoxEmpName.Text) || string.IsNullOrEmpty(txtBoxEmpPass.Text) || string.IsNullOrEmpty(txtBoxEmpSalary.Text))
            {
                check = true;
            }
            return check;
        }
        private void clear()
        {
            txtBoxEmpName.Text = null;
            txtBoxEmpPass.Text = null;
            txtBoxEmpSalary.Text = null;
            txtBoxEmpID.Text = null;
            txtBoxEmpUsername.Text = null;
            joiningDateTimePicker.Value = DateTime.Today;
            txtBoxEmpName.ReadOnly = false;
        }

        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxEmpName.ReadOnly = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = employeeDataGridView.Rows[e.RowIndex];

                txtBoxEmpID.Text = row.Cells[0].Value.ToString();
                txtBoxEmpName.Text = row.Cells[1].Value.ToString();
                txtBoxEmpUsername.Text = row.Cells[2].Value.ToString();
                txtBoxEmpPass.Text = row.Cells[3].Value.ToString();
                txtBoxEmpSalary.Text = row.Cells[4].Value.ToString();
                if (DateTime.TryParse(row.Cells[6].Value.ToString(), out DateTime joiningDate))
                {
                    joiningDateTimePicker.Value = joiningDate;
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (isInfoEmpty())
            {
                MessageBox.Show("Select the employee cell you want to remove.", "No Employee Selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (obj.removeEmployee(txtBoxEmpUsername.Text))
                {
                    MessageBox.Show("Employee Removed..", "Removing Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showGridDataInfo();
                }
                else
                {
                    MessageBox.Show("Employee Removing Failed. Wrong info given..", "Failed Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clear();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(isInfoEmpty())
            {
                MessageBox.Show("Select the employee cell you want to update.", "No Employee Selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (obj.IsNameValid(txtBoxEmpName.Text))
                    {
                        if(obj.IsInfoSame(employeeDataGridView, txtBoxEmpPass.Text, txtBoxEmpSalary.Text, joiningDateTimePicker.Value))
                        {
                            MessageBox.Show("Nothing to Update. You haven't done anything to change.\nNote: Changing Name doesn't allowed.", "Nothing to update!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (obj.updateInfo(txtBoxEmpUsername.Text, txtBoxEmpPass.Text, Decimal.Parse(txtBoxEmpSalary.Text), joiningDateTimePicker.Value))
                            {
                                MessageBox.Show("Employee Info Updated!!", "Information Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                showGridDataInfo();
                                clear();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name can only contain letters (Without Space)\nNote that You can't change your name..", "Invalid Name format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message} Salary must be a number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
