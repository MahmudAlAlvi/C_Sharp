using Online_MarketPlace.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_MarketPlace.Classes
{
    class Customer
    {
        public string getCustomerID(string username)
        {
            string id = null;
            try
            {
                using (var connection = DatabaseConnection.databaseConnect())
                {
                    connection.Open();

                    string query = $"select Customer_ID from Customer_Info where Customer_Username = '{username}'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            id = result.ToString();
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }

        public DataTable GetProductInfoTable()
        {
            DataTable productTable = new DataTable();

            using (var connection = DatabaseConnection.databaseConnect())
            {
                connection.Open();

                string query = "SELECT Product_ID, ProductName, SellPrice, Stock FROM Product_Info Where Stock > 0";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(productTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

            return productTable;
        }

        public bool bankBalanceUpdateAfterPurchase(string username, decimal totalCost)
        {
            bool updateSuccess = false;
            try
            {
                using (var connection = DatabaseConnection.databaseConnect())
                {
                    connection.Open();

                    string query = $"UPDATE Bank_Info SET Balance -= {totalCost} FROM Bank_Info B INNER JOIN Customer_Info C ON B.Bank_AC = C.Bank_AC WHERE C.Customer_Username = '{username}';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            updateSuccess = true;
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error while Update Bank Balance: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return updateSuccess;
        }

        public bool bankBalanceAdd(string username, decimal amount)
        {
            bool updateSuccess = false;
            try
            {
                using (var connection = DatabaseConnection.databaseConnect())
                {
                    connection.Open();

                    string query = $"UPDATE Bank_Info SET Balance += {amount} FROM Bank_Info B INNER JOIN Customer_Info C ON B.Bank_AC = C.Bank_AC WHERE C.Customer_Username = '{username}';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            updateSuccess = true;
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error while Update Bank Balance: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return updateSuccess;
        }

        public string getBankBalance(string username)
        {
            string balance = null;
            try
            {
                using (var connection = DatabaseConnection.databaseConnect())
                {
                    connection.Open();

                    string query = $"SELECT B.Balance FROM Customer_Info C INNER JOIN Bank_Info B ON C.Bank_AC = B.Bank_AC WHERE C.Customer_Username = '{username}';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            balance = result.ToString();
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error while getting Bank Balance: {ex.Message}", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return balance;
        }

        public bool customerPasswordChange(string username, string oldPassword, string newPassword)
        {
            bool check = false;

            string updateQuery = @"UPDATE Customer_Info SET Customer_password = @NewPassword WHERE Customer_Username = @Username and Customer_password = @OldPassword;
                    
                    UPDATE Login_Info SET User_password = @NewPassword WHERE Username = @Username and User_password = @OldPassword and User_Role = 'Customer';";

            var connection = DatabaseConnection.databaseConnect();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(updateQuery, connection);

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@OldPassword", oldPassword);
                command.Parameters.AddWithValue("@NewPassword", newPassword);
                if (oldPassword != newPassword)
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        check = true;
                    }
                }
                else
                {
                    check = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return check;
        }
    }

    class OrderInfo
    {
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }

        public bool InsertOrderIntoDatabase(int id, decimal totalCost)
        {
            bool insertionSuccess = false;

            try
            {
                using (var connection = DatabaseConnection.databaseConnect())
                {
                    connection.Open();

                    string query = $"insert into Order_Info (CustomerID, Total_Purchase, Paid_Status) values ({id}, {totalCost}, 'Yes');";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            insertionSuccess = true;
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Order insertion: {ex.Message}", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return insertionSuccess;
        }

        public int getLastOrderID()
        {
            int OrderId = 0;
            try
            {
                using (var connection = DatabaseConnection.databaseConnect())
                {
                    connection.Open();

                    string query = "SELECT MAX(Order_ID) FROM Order_Info";

                    using (var command = new SqlCommand(query, connection))
                    {
                        OrderId = (int)command.ExecuteScalar();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"OrderID Error: {ex.Message}","OrderID Fetch Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return OrderId;
        }
    }

    class SalesInfo
    {
        public bool InsertSalesIntoDatabase(int orderId, int productId, decimal totalCost)
        {
            bool insertionSuccess = false;

            try
            {
                using (var connection = DatabaseConnection.databaseConnect())
                {
                    connection.Open();

                    string query = $"insert into Sales_Info (OrderID, ProductID, Total_Amount) values ({orderId}, {productId}, {totalCost})";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            insertionSuccess = true;
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Sales insertion: {ex.Message}", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return insertionSuccess;
        }

        public bool UpdateProductStock(int productId, int quantity)
        {
            bool insertionSuccess = false;

            try
            {
                using (var connection = DatabaseConnection.databaseConnect())
                {
                    connection.Open();

                    string query = $"update Product_Info set Stock -= {quantity} where Product_ID = {productId};";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            insertionSuccess = true;
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Product Stock Updation: {ex.Message}", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return insertionSuccess;
        }
    }
}