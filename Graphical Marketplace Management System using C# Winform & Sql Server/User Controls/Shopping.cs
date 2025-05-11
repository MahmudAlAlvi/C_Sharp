using Online_MarketPlace.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Online_MarketPlace.User_Controls
{
    public partial class Shopping : UserControl
    {
        Customer customerObj = new Customer();

        OrderInfo order = new OrderInfo();
        SalesInfo sales = new SalesInfo();

        static string customerID;
        static string customerUsername;
        private int orderId;

        private int selectedRowIndex = -1;
        private int selectedRowForProductStock = -1;

        private List<OrderInfo> cartProducts = new List<OrderInfo>();

        public Shopping()
        {
            InitializeComponent();

            dtpOrderDate.Value = DateTime.Today;

            customerUsername = LoginForm.loggedInUsername;
            customerID = customerObj.getCustomerID(LoginForm.loggedInUsername);

            txtBoxID.Text = $"Customer ID: {customerID}";

            productDataGridView.DataSource = customerObj.GetProductInfoTable();

            showBankBalance();
        }

        private void showBankBalance()
        {
            txtBoxBankBalance.Text = $"Balance: ${customerObj.getBankBalance(customerUsername)}";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(cartDataGridView.Rows.Count > 0)
            {
                if(InsertOrderInfo())
                {
                    txtBoxTotalPurchage.Text = null;
                    cartProducts.Clear();
                    cartDataGridView.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please add products to the cart first", "No Items in Cart!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtBoxProductID.Text) | string.IsNullOrWhiteSpace(txtBoxPrice.Text) | string.IsNullOrWhiteSpace(txtBoxUnit.Text))
            {
                MessageBox.Show("Please select a product from the Products Table above and you have to atleast buy 1 unit of a product to continue.", "Select a product first!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int productId = int.Parse(txtBoxProductID.Text);
                    decimal price = decimal.Parse(txtBoxPrice.Text);
                    int quantity = int.Parse(txtBoxUnit.Text);

                    

                    bool productExistsInCart = false;

                    foreach (var product in cartProducts)
                    {
                        if (product.ProductID == productId)
                        {
                            productExistsInCart = true;
                            break;
                        }
                    }

                    if (productExistsInCart)
                    {
                        MessageBox.Show("You have already added this item to your cart. If you want to add more, please remove the selected one from the cart and continue.", "Item already in Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Clear();
                        return;
                    }

                    ///////////////////////////////////////////////////////////////////////////////////////////

                    DataGridViewRow selectedRow = productDataGridView.Rows[selectedRowForProductStock];
                    int stockAmount = Convert.ToInt32(selectedRow.Cells[3].Value); 

                    if (quantity > stockAmount)
                    {
                        MessageBox.Show("Enter a quantity less than or equal to the stock amount.\n\nNote: Please select the product row again and enter a sufficient quantity", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        Clear();
                        selectedRowForProductStock = -1;
                    }
                    else
                    {
                        OrderInfo cartProduct = new OrderInfo
                        {
                            ProductID = productId,
                            Price = price,
                            Quantity = quantity
                        };

                        cartProducts.Add(cartProduct);
                        Clear();
                        DisplayCartProducts();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Invalid Format of Product ID/Price/Quantity. Product ID and Quantity must be int type and price should be number type.", "Invalid data format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Clear()
        {
            txtBoxProductID.Text = null;
            txtBoxPrice.Text = null;
            txtBoxUnit.Text = null;
        }

        private void DisplayCartProducts()
        {
            cartDataGridView.Rows.Clear();

            decimal totalPurchase = 0;

            foreach (var product in cartProducts)
            {
                decimal totalPrice = product.Price * product.Quantity;
                totalPurchase += totalPrice;

                cartDataGridView.Rows.Add(product.ProductID, product.Price, product.Quantity, totalPrice);
            }

            txtBoxTotalPurchage.Text = totalPurchase.ToString();
        }

        private void DisplayUpdatedStockProducts()
        {
            foreach (var product in cartProducts)
            {
                sales.UpdateProductStock(product.ProductID, product.Quantity);
            }

            productDataGridView.DataSource = customerObj.GetProductInfoTable();
        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowForProductStock = e.RowIndex;

                DataGridViewRow row = productDataGridView.Rows[e.RowIndex];

                int productId = Convert.ToInt32(row.Cells[0].Value);
                decimal price = Convert.ToDecimal(row.Cells[2].Value);

                txtBoxProductID.Text = productId.ToString();
                txtBoxPrice.Text = price.ToString()
;            }
        }

        private bool InsertOrderInfo()
        {
            decimal orderTotal = decimal.Parse(txtBoxTotalPurchage.Text);

            if(orderTotal <= decimal.Parse(customerObj.getBankBalance(customerUsername)))
            {
                if (order.InsertOrderIntoDatabase(int.Parse(customerID), orderTotal))
                {
                    orderId = order.getLastOrderID();

                    if (InsertSalesInfo())
                    {
                        if (customerObj.bankBalanceUpdateAfterPurchase(customerUsername, orderTotal))
                        {
                            DisplayUpdatedStockProducts();
                            showBankBalance();
                            MessageBox.Show("Payment Received!\nProduct Ordering Successful.", "Order successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Error: Something wrong..", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Sorry, You have insufficient balance in your Bank Account to make this order.", "Insufficient Balance!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool InsertSalesInfo()
        {
            bool isSuccess = false;

            foreach (var product in cartProducts)
            {
                if(InsertProductToSales(product, orderId))
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            return isSuccess;
        }

        private bool InsertProductToSales(OrderInfo product, int orderId)
        {
            bool isSuccess = false;

            if(sales.InsertSalesIntoDatabase(orderId, product.ProductID, product.TotalPrice))
            {
                isSuccess = true;
            }

            return isSuccess;
        }

        private void cartDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < cartDataGridView.Rows.Count)
            {
                cartProducts.RemoveAt(selectedRowIndex);
                selectedRowIndex = -1;
                DisplayCartProducts();
                MessageBox.Show("Product has been Removed from your Cart", "Product removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblSettingTitle_Click(object sender, EventArgs e)
        {

        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cartDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxBankBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
