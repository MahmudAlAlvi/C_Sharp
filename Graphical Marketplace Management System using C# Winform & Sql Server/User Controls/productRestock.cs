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
    public partial class productRestock : UserControl
    {
        ExpenseInfo obj = new ExpenseInfo();
        public productRestock()
        {
            InitializeComponent();
            dateTimePickerIssueDate.Value = DateTime.Today;
            productTableData();
        }

        public void productTableData()
        {
            DataTable productTable = obj.GetProductTable();

            if (productTable != null && productTable.Rows.Count > 0)
            {
                RestockDataGridView.DataSource = productTable;
            }
            else
            {
                MessageBox.Show("No data found.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RestockDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = RestockDataGridView.Rows[e.RowIndex];

                int productId = Convert.ToInt32(row.Cells[0].Value);

                txtBoxProductID.Text = productId.ToString();
            }
        }

        private void FilterDataTable(string searchTerm)
        {
            DataTable clonedDataTable = obj.GetProductTable().Clone(); // Clone the original DataTable

            foreach (DataRow row in obj.GetProductTable().Rows)
            {
                if (row[1].ToString().ToLower().Contains(searchTerm.ToLower()) ||
                    row[2].ToString().ToLower().Contains(searchTerm.ToLower()))
                {
                    clonedDataTable.ImportRow(row);
                }
            }

            RestockDataGridView.DataSource = clonedDataTable;
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtBoxSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                RestockDataGridView.DataSource = obj.GetProductTable();
            }
            else
            {
                FilterDataTable(searchTerm);
            }
        }

        private void Clear()
        {
            txtBoxProductID.Text = null;
            txtBoxBuyPrice.Text = null;
            txtBoxProductRestock.Text = null;
            dateTimePickerIssueDate.Value = DateTime.Today;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            productTableData();
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txtBoxBuyPrice.Text) || string.IsNullOrWhiteSpace(txtBoxProductRestock.Text))
                {
                    MessageBox.Show("Please select a product from the Table below and provide the unit price and the number of products you to Restock.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int id = int.Parse(txtBoxProductID.Text);
                    decimal price = decimal.Parse(txtBoxBuyPrice.Text);
                    int restockAmount = int.Parse(txtBoxProductRestock.Text);
                    DateTime issueDate = dateTimePickerIssueDate.Value;

                    if(obj.RestockProduct(id, price, restockAmount, issueDate))
                    {
                        MessageBox.Show("Congratulations!!\nProduct Restocked Successfully", "Product restocked!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        productTableData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
