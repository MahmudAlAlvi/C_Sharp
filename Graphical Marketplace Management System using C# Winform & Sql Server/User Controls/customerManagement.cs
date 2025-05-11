using Online_MarketPlace.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Online_MarketPlace.User_Controls
{
    public partial class customerManagement : UserControl
    {
        Employee obj = new Employee();
        public customerManagement()
        {
            InitializeComponent();
            showDataGridInfo();
        }

        private void showDataGridInfo()
        {
            customerDataGridView.DataSource = obj.LoadData();
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtBoxCstmrID.Text = null;
            txtBoxCstmrName.Text = null;
            txtBoxCstmrPass.Text = null;
            txtBoxCstmrUsername.Text = null;
            txtBoxCstmrBankAC.Text = null;
            radioBtnRegular.Checked = true;

            txtBoxCstmrName.ReadOnly = false;
            txtBoxCstmrBankAC.ReadOnly = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showDataGridInfo();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxCstmrName.Text) || string.IsNullOrEmpty(txtBoxCstmrPass.Text) || string.IsNullOrEmpty(txtBoxCstmrBankAC.Text))
            {
                MessageBox.Show("Must fill up the * marked fields", "Failed to provide info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (obj.IsNameFormatValid(txtBoxCstmrName.Text))
                {
                    if (obj.IsBankAC_FormatValid(txtBoxCstmrBankAC.Text))
                    {
                        long BankAC = Convert.ToInt64(txtBoxCstmrBankAC.Text);
                        if (obj.IsBankAC_Valid(BankAC) && !obj.IsBankAC_AlreadyUsed(BankAC))
                        {
                            string membership;
                            if (radioBtnRegular.Checked == true)
                            {
                                membership = radioBtnRegular.Text;
                            }
                            else if (radioBtnVip.Checked == true)
                            {
                                membership = radioBtnVip.Text;
                            }
                            else
                            {
                                membership = radioBtnPlatinum.Text;
                            }

                            if (obj.InsertDataIntoDatabase(txtBoxCstmrName.Text, txtBoxCstmrPass.Text, membership, BankAC) && obj.updateBankAC_AfterJoining(BankAC))
                            {
                                MessageBox.Show("Congratulations! Customer successfully joined", "Customer joining completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear();
                                showDataGridInfo();
                            }
                            else
                            {
                                MessageBox.Show("Error! Customer joining failed.", "Failure to adding!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Provided Bank A/C is invalid. Please provide a valid A/C", "Invalid A/C Provided!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bank Account must be Number Type", "Invalid Bank A/C Format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Name must be Letter Type (Without any space)", "Invalid name format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxCstmrBankAC.ReadOnly = true;
            txtBoxCstmrName.ReadOnly = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customerDataGridView.Rows[e.RowIndex];

                txtBoxCstmrID.Text = row.Cells[0].Value.ToString();
                txtBoxCstmrName.Text = row.Cells[1].Value.ToString();
                txtBoxCstmrUsername.Text = row.Cells[2].Value.ToString();
                txtBoxCstmrPass.Text = row.Cells[3].Value.ToString();
                txtBoxCstmrBankAC.Text = row.Cells[6].Value.ToString();

                string membership = row.Cells[4].Value.ToString();

                if(membership == "Regular")
                {
                    radioBtnRegular.Checked = true;
                }
                else if(membership == "VIP")
                {
                    radioBtnVip.Checked = true;
                }
                else if(membership == "Platinum")
                {
                    radioBtnPlatinum.Checked = true;
                }
            }
        }

        private string selectMembership(RadioButton regular, RadioButton vip, RadioButton platinum)
        {
            if(regular.Checked)
            {
                return regular.Text;
            }
            else if(vip.Checked)
            {
                return vip.Text;
            }
            else
            {
                return platinum.Text;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string membership = selectMembership(radioBtnRegular, radioBtnVip, radioBtnPlatinum);
            if(obj.IsNameFormatValid(txtBoxCstmrName.Text))
            {
                if(obj.IsInfoSame(customerDataGridView, txtBoxCstmrPass.Text, membership))
                {
                    MessageBox.Show("Nothing to Update. You haven't done anything to change.", "Nothing to update!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (obj.updateInfo(txtBoxCstmrUsername.Text, txtBoxCstmrPass.Text, membership))
                    {
                        MessageBox.Show("Successfully Updated Info..\nNote: You can't update Bank A/C and Name. It Can't be changed after registering into the Database for the first time.", "Updation Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showDataGridInfo();
                    }
                    else
                    {
                        MessageBox.Show("Error! Something occoured.", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Name can only contains Letter Type (Without Space)", "Invalid name format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBoxSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                DataTable filteredDataTable = ((DataTable)customerDataGridView.DataSource).Clone();

                foreach (DataRow row in ((DataTable)customerDataGridView.DataSource).Rows)
                {
                    bool rowContainsSearchText = false;

                    foreach (var columnValue in row.ItemArray)
                    {
                        if (columnValue != null && columnValue.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            rowContainsSearchText = true;
                            break;
                        }
                    }

                    if (rowContainsSearchText)
                    {
                        filteredDataTable.ImportRow(row);
                    }
                }

                customerDataGridView.DataSource = filteredDataTable;
            }
            else
            {
                showDataGridInfo();
            }
        }
    }
}
