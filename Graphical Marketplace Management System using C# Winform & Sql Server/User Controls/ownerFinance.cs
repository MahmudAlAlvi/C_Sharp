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
    public partial class ownerFinance : UserControl
    {
        public ownerFinance()
        {
            InitializeComponent();
            showGridDataInfo();
            datePickerFrom.Value = DateTime.Today.AddMonths(-12);
            datePickerTo.Value = DateTime.Today.AddMonths(0);
            paySalaryTimePicker.Value = DateTime.Today;
        }
        PayEmployeeSalary obj = new PayEmployeeSalary();
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtBoxEmpID.Text = null;
            txtBoxEmpSalary.Text = null;
            txtBoxEmpBonus.Text = null;
            paySalaryTimePicker.Value = DateTime.Today;
            showGridDataInfo();
        }
        private void showGridDataInfo()
        {
            salaryDataGridView.DataSource = obj.LoadData();
        }

        private void showGridDataInfoAfterSearch()
        {
            salaryDataGridView.DataSource = obj.LoadDataSearch(txtboxSearch.Text, datePickerFrom.Value, datePickerTo.Value);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int year = paySalaryTimePicker.Value.Year;
            int month = paySalaryTimePicker.Value.Month;
            string paidDate = paySalaryTimePicker.Value.ToString("yyyy-MM-dd");
            //decimal salary = decimal.Parse(txtBoxEmpSalary.Text);

            if(obj.isFieldEmpty(txtBoxEmpID.Text, txtBoxEmpSalary.Text))
            {
                MessageBox.Show("You have to fill the * marked fileds..", "Not enough info gven!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(obj.checkIDFormat(txtBoxEmpID.Text))
                {
                    int id = int.Parse(txtBoxEmpID.Text);
                    if(obj.verifyEmployee(id))
                    {
                        if(!obj.salaryBeforeJoindate(id, year, month))
                        {
                            if(!obj.isPayingAdvance(year, month))
                            {
                                if(obj.isSalaryAlreadyGiven(id, month, year))
                                {
                                    MessageBox.Show($"Salary already given\nEmployee ID: {id}\nPay Date(Year-Month): {year}-{month}", "Can't pay salary", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    if(obj.paySalary(id, txtBoxEmpSalary.Text, txtBoxEmpBonus.Text, paidDate))
                                    {
                                        MessageBox.Show($"Salary Paid Successfully..", "Salary Paid!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        showGridDataInfo();
                                        clear();
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Salary Paid Unsuccessful. Possible reasons:\n1. Salary and Bonus (if given) must be number\n2. Salary amount can't be more or less than the base salary", "Error! Something happened!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Only pay salary for past time and current time", "Can't pay advanced salary", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"You can't pay salary before the joining date of the employee..", "Can't pay salary", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show($"Invalid Employee, found no employee whose\nEmployee ID: {id}", "Invalid Employee!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ID must be a number", "Invalid ID Format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            showGridDataInfoAfterSearch();
            txtboxSearch.Text = null;
        }

        private void salaryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void financePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
