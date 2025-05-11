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
    class Product
    {
        private int id;
        private decimal buyPrice, sellPrice;
        private string name, catagory;
        private DateTime addingDate;

        public int ID
        { 
            get { return id; }
            set { id = value; }
        }
        public decimal BuyPrice
        {
            get { return buyPrice; }
            set { buyPrice = value; }
        }
        public decimal SellPrice
        {
            get { return sellPrice; }
            set { sellPrice = value; }
        }
        public string ProductName
        {
            get { return name; }
            set { name = value; }
        }
        public string Catagory
        {
            get { return catagory; }
            set { catagory = value; }
        }
        public DateTime AddingDate
        {
            get { return addingDate; }
            set { addingDate = value; }
        }

        public bool AddNewCategory(string categoryName)
        {
            bool insertionSuccess = false;

            try
            {
                using (var connection = DatabaseConnection.databaseConnect())
                {
                    connection.Open();

                    string query = "INSERT INTO Catagory (Catatgory_Type) VALUES (@CategoryName)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryName", categoryName);

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
                MessageBox.Show($"Error: {ex.Message}", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return insertionSuccess;
        }

        public void LoadCategoriesToComboBox(ComboBox comboBox)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.databaseConnect())
                {
                    connection.Open();

                    string query = "SELECT Catatgory_Type FROM Catagory";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string categoryName = reader.GetString(0);
                                comboBox.Items.Add(categoryName);
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool executeQuery(string query)
        {
            bool check = false;

            using (var connection = DatabaseConnection.databaseConnect())
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand(query, connection);
                try
                {
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        check = true;
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
            return check;
        }

        public bool insertProduct_AddIntoExpense(string productName, string catagory, decimal buyPrice, decimal sellPrice, int stock, string addingDate)
        {
            string insertQuery = 
                $"insert into Product_Info (ProductName, CatagoryType, BuyPrice, SellPrice, Stock) VALUES ('{productName}', '{catagory}', {buyPrice}, {sellPrice}, {stock});" 
                +
                $"insert into Expense_Info (ProductID, stock_Restock_amount, unit_Price, issueDate) values (SCOPE_IDENTITY(), {stock}, {buyPrice}, '{addingDate}');";

            if(executeQuery(insertQuery))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateProduct(int id, string name, string category, decimal buyPrice, decimal sellPrice)
        {
            string UpdateQuery = $"UPDATE Product_Info SET ProductName = '{name}', CatagoryType = '{category}', BuyPrice = {buyPrice}, SellPrice = {sellPrice} WHERE Product_ID = {id}";

            var connection = DatabaseConnection.databaseConnect();
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(UpdateQuery, connection);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }

        public DataTable GetProductInfoTable()
        {
            DataTable productTable = new DataTable();

            using (var connection = DatabaseConnection.databaseConnect())
            {
                connection.Open();

                string query = "SELECT * FROM Product_Info";

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
    }

    class ExpenseInfo : Product
    {
        public DataTable GetProductTable()
        {
            DataTable productTable = new DataTable();

            using (var connection = DatabaseConnection.databaseConnect())
            {
                connection.Open();

                string query = "SELECT Product_ID, ProductName, BuyPrice, SellPrice, Stock FROM Product_Info";

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

        public bool RestockProduct(int productId, decimal unitPrice, int restockAmount, DateTime issueDate)
        {
            bool success = false;
            try
            {
                // Inserting data into Expense_Info table
                string insertExpenseQuery = $"INSERT INTO Expense_Info (ProductID, stock_Restock_amount, unit_Price, issueDate) VALUES ({productId}, {restockAmount}, {unitPrice}, '{issueDate.ToString("yyyy-MM-dd")}');";

                if (ExecuteQuery(insertExpenseQuery))
                {
                    // Update Product_Info table
                    string updateProductQuery = $"UPDATE Product_Info SET Stock = Stock + {restockAmount} WHERE Product_ID = {productId};";

                    success = ExecuteQuery(updateProductQuery);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return success;
        }

        private bool ExecuteQuery(string query)
        {
            bool success = false;
            try
            {
                using (SqlConnection connection = DatabaseConnection.databaseConnect())
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if(rowsAffected > 0)
                    {
                        success = true;
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return success;
        }
    }
}
