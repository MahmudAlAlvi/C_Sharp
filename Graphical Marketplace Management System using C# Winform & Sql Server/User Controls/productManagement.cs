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
    public partial class productManagement : UserControl
    {
        Product obj = new Product();

        public productManagement()
        {
            InitializeComponent();
            obj.LoadCategoriesToComboBox(comboBoxCatagory);
        }

        private void productManagement_Load(object sender, EventArgs e)
        {
            dateTimePickerAddingDate.Value = DateTime.Today;
            LoadProductInfo();
        }

        private void btnCatagory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxCatagory.Text))
            {
                if(obj.AddNewCategory(txtBoxCatagory.Text))
                {
                    MessageBox.Show("New Catagory Inserted Successfully\nNote: Please Login again to see the update..", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxCatagory.Text = null;
                    comboBoxCatagory.Items.Clear();
                    obj.LoadCategoriesToComboBox(comboBoxCatagory);
                }
                else
                {
                    MessageBox.Show("Error: Failed to add new Catagory..", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please give a Catagory Name..", "Invalid input format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            txtBoxProductID.Text = null;
            txtBoxProductName.Text = null;
            txtBoxBuyPrice.Text = null;
            txtBoxSellPrice.Text = null;
            txtBoxCatagory.Text = null;
            txtBoxProductStock.Text = null;
            comboBoxCatagory.Text = null;
            dateTimePickerAddingDate.Value = DateTime.Today;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Clear();
            txtBoxProductStock.ReadOnly = false;
            txtBoxBuyPrice.ReadOnly = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtBoxProductName.Text) || string.IsNullOrWhiteSpace(comboBoxCatagory.Text) || string.IsNullOrWhiteSpace(txtBoxBuyPrice.Text) || string.IsNullOrWhiteSpace(txtBoxSellPrice.Text) || string.IsNullOrWhiteSpace(txtBoxProductStock.Text))
            {
                MessageBox.Show("Please give the product name, buy price (number), sell price (number), category and stock amount (int) with their valid data types.", "Info not provided!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    decimal buyPrice = decimal.Parse(txtBoxBuyPrice.Text);
                    decimal sellPrice = decimal.Parse(txtBoxSellPrice.Text);
                    int stockAmount = int.Parse(txtBoxProductStock.Text);
                    string addDate = dateTimePickerAddingDate.Value.ToString("yyyy-MM-dd");
                    string name = txtBoxProductName.Text;
                    string category = comboBoxCatagory.Text;

                    if (obj.insertProduct_AddIntoExpense(name, category, buyPrice, sellPrice, stockAmount, addDate))
                    {
                        MessageBox.Show("Product added successfully....", "Adding Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductInfo();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Product added Failed.", "Adding Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error, Something wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LoadProductInfo()
        {
            DataTable productTable = obj.GetProductInfoTable();

            if (productTable != null && productTable.Rows.Count > 0)
            {
                productDataGridView.DataSource = productTable;
            }
            else
            {
                MessageBox.Show("No data found.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProductInfo();
        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = productDataGridView.Rows[e.RowIndex];

                txtBoxProductStock.ReadOnly = true;
                txtBoxBuyPrice.ReadOnly = true;

                int productId = Convert.ToInt32(row.Cells[0].Value);
                string productName = row.Cells[1].Value.ToString();
                decimal sellPrice = Convert.ToDecimal(row.Cells[4].Value);
                decimal buyPrice = Convert.ToDecimal(row.Cells[3].Value);
                int stock = Convert.ToInt32(row.Cells[5].Value);
                string categoryType = row.Cells[2].Value.ToString();

                txtBoxProductID.Text = productId.ToString();
                txtBoxProductName.Text = productName;
                txtBoxBuyPrice.Text = buyPrice.ToString();
                txtBoxSellPrice.Text = sellPrice.ToString();
                txtBoxProductStock.Text = stock.ToString();

                if (comboBoxCatagory.Items.Contains(categoryType))
                {
                    comboBoxCatagory.SelectedItem = categoryType;
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                decimal buyPrice = decimal.Parse(txtBoxBuyPrice.Text);
                decimal sellPrice = decimal.Parse(txtBoxSellPrice.Text);
                int id = int.Parse(txtBoxProductID.Text);
                int stock = int.Parse(txtBoxProductStock.Text);
                string name = txtBoxProductName.Text;
                string category = comboBoxCatagory.Text;

                if (productDataGridView.CurrentRow.Cells[1].Value.ToString() == name && productDataGridView.CurrentRow.Cells[2].Value.ToString() == category && Convert.ToDecimal(productDataGridView.CurrentRow.Cells[4].Value) == sellPrice)
                {
                    MessageBox.Show("No data changed, Nothing updated..", "Can't update!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(obj.updateProduct(id, name, category, buyPrice, sellPrice))
                    {
                        MessageBox.Show("Product successfully updated..", "Success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        txtBoxProductStock.ReadOnly = false;
                        txtBoxBuyPrice.ReadOnly = false;
                        LoadProductInfo();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please provide valid data type.\nError: {ex.Message}", "Invalid format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterDataTable(string searchTerm)
        {
            DataTable clonedDataTable = obj.GetProductInfoTable().Clone();

            foreach (DataRow row in obj.GetProductInfoTable().Rows)
            {
                if (row[1].ToString().ToLower().Contains(searchTerm.ToLower()) ||
                    row[2].ToString().ToLower().Contains(searchTerm.ToLower()))
                {
                    clonedDataTable.ImportRow(row);
                }
            }

            productDataGridView.DataSource = clonedDataTable;
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtBoxSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                productDataGridView.DataSource = obj.GetProductInfoTable();
            }
            else
            {
                FilterDataTable(searchTerm);
            }
        }

        private void customerManagementPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBoxProductName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
