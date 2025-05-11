using Online_MarketPlace.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Online_MarketPlace.Classes
{
    class Employee
    {
        private string nickname, password, memebership;
        private long bankAC;
        public string Nickname { get { return nickname; } set { nickname = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Membership { get { return memebership; } set { memebership = value; } }
        public long BankAC { get { return bankAC; } set { bankAC = value; } }

        public bool IsNameFormatValid(string username)
        {
            Nickname = username;
            foreach (char c in Nickname)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        
        public bool IsBankAC_FormatValid(string bankAC)
        {
            try
            {
                BankAC = Convert.ToInt64(bankAC);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool IsBankAC_AlreadyUsed(long account)
        {
            using (SqlConnection connection = DatabaseConnection.databaseConnect())
            {
                string query = $"select COUNT(*) from Bank_Info where Bank_AC = @Account and AC_Acquired_Status = 'Yes'";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Account", account);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error Occoured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

            return false;
        }

        public bool IsBankAC_Valid(long account)
        {
            using (SqlConnection connection = DatabaseConnection.databaseConnect())
            {
                string query = $"select COUNT(*) from Bank_Info where Bank_AC = @Account";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Account", account);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error Occoured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

            return false;
        }

        public bool updateBankAC_AfterJoining(long account)
        {
            using (SqlConnection connection = DatabaseConnection.databaseConnect())
            {
                string query = @"update Bank_Info set AC_Acquired_Status = 'Yes' where Bank_AC = @Account";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Account", account);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error Occoured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
                return false;
            }
        }

        public bool createNewBankForCustomer(long bankAC)
        {
            using (SqlConnection connection = DatabaseConnection.databaseConnect())
            {
                string query = $"SET IDENTITY_INSERT Bank_Info ON;" +
                    $"INSERT INTO Bank_Info(Bank_AC, AC_Acquired_Status) VALUES(@BankAC, 'Yes');" +
                    $"SET IDENTITY_INSERT Bank_Info OFF; ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BankAC", bankAC);

                try
                {
                    connection.Open();
                    int affectedRow =command .ExecuteNonQuery();

                    if (affectedRow > 0)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error Occoured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

            return false;
        }

        public string getNewCustomerUsername(long bankAC)
        {
            string username = null;

            using (SqlConnection connection = DatabaseConnection.databaseConnect())
            {
                string query = $"select Customer_Username from Customer_Info where Bank_AC = @BankAC";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BankAC", bankAC);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        username = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error Occoured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

            return username;
        }

        public bool InsertDataIntoDatabase(string nickname, string password, string membership, long bankAC)
        {
            bool check = false;

            this.Nickname = nickname;
            this.Password = password;
            this.Membership = membership;
            this.BankAC = bankAC;

            string insertQuery = $"Insert into Customer_Info(Customer_name, Customer_password, Membership, Bank_AC) values ('{Nickname}', '{Password}', '{Membership}', {BankAC});" +
                $"INSERT INTO Login_Info (Username, User_password, User_Role) VALUES((SELECT Customer_Username FROM Customer_Info WHERE Customer_ID = SCOPE_IDENTITY()),(SELECT Customer_password FROM Customer_Info WHERE Customer_ID = SCOPE_IDENTITY()),'Customer')";

            if (executeQuery(insertQuery))
            {
                check = true;
            }
            return check;
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
 
        public DataTable LoadData()
        {
            string sqlQuery = "SELECT CI.Customer_ID, CI.Customer_name, CI.Customer_Username, CI.Customer_password, CI.Membership, CONCAT('$', COALESCE((SELECT SUM(OI.Total_Purchase) FROM Order_Info OI WHERE OI.CustomerID = CI.Customer_ID), 0.0)) AS 'Total_Purchase', CI.Bank_AC FROM Customer_Info CI;";

            using (var connection = DatabaseConnection.databaseConnect())
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                DataTable dataTable = new DataTable();

                if (connection.State == ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();
                        var reader = cmd.ExecuteReader();
                        dataTable.Load(reader);
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
                return dataTable;
            }
        }

        public bool IsInfoSame(DataGridView dataGridView, string password, string membership)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                string passwordFromGrid = selectedRow.Cells[3].Value?.ToString();
                string membershipFromGrid = selectedRow.Cells[4].Value?.ToString();

                if (passwordFromGrid == password && membershipFromGrid == membership)
                {
                    return true;
                }
            }

            return false;
        }

        public bool updateInfo(string username, string password, string membership)
        {
            bool valid = false;

            string sqlQuery = $"update Customer_Info set Customer_password = '{password}', Membership = '{membership}' where Customer_Username = '{username}';" +
                $"update Login_Info set User_password = '{password}' where Username = '{username}' and User_Role = 'Customer';";

            var connection = DatabaseConnection.databaseConnect();
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        valid = true;
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
            return valid;
        }

        public bool employeePasswordChange(string username, string oldPassword, string newPassword)
        {
            bool check = false;

            string updateQuery = @" UPDATE Employee_Info SET Employee_password = @NewPassword WHERE Employee_Username = @Username and Employee_password = @OldPassword;
                    
                    UPDATE Login_Info SET User_password = @NewPassword WHERE Username = @Username and User_password = @OldPassword and User_Role = 'Employee';";

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
}
