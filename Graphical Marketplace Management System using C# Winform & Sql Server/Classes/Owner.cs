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
    class Owner
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private string Ownership_Status { get; set; }
    }

    class OwnerSetting : Owner
    {
        public bool updatePassword(string username, string oldPassword, string newPassword)
        {
            bool check = false;

            string updateQuery = @"
                    UPDATE Owner_Info
                    SET Owner_password = @NewPassword
                    WHERE Owner_Username = @Username;

                    UPDATE Login_Info
                    SET User_password = @NewPassword
                    WHERE Username = @Username";

            var connection = DatabaseConnection.databaseConnect();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(updateQuery, connection);

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@NewPassword", newPassword);
                if(oldPassword != newPassword)
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        check = true;
                    }
                }
                else
                {
                    MessageBox.Show("New Password and Current Password can't be same", "Error! Same Password Used", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        public bool currentUserAuthertication(int id, string username, string oldPassword)
        {
            bool isValid = false;

            string query = $"SELECT * FROM  Owner_Info WHERE Owner_Username = '{username}' AND Owner_password = '{oldPassword}' AND Ownership_Status = 'Yes' AND Owner_ID = {id}";

            var connection = DatabaseConnection.databaseConnect();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    isValid = true;
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please provide valid credentials.", "Authentication Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return isValid;
        }
    }

    class OwnershipHandover : Owner
    {
        public bool IsNameValid(string username)
        {
            foreach (char c in username)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        public bool isInfoEmpty(string username, string password, string confirmPassword, string name, string newPassword)
        {
            bool check = false;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(newPassword))
            {
                check = true;
            }
            return check;
        }
        public bool verifyBothPassword(string password, string confirmPassword)
        {
            if(password == confirmPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool verifyOldOwner(string username, string password)
        {
            bool isValid = false;

            string query = $"SELECT * FROM Login_Info li JOIN Owner_Info oi ON li.Username = oi.Owner_Username AND li.User_password = oi.Owner_password WHERE li.Username = '{username}' AND li.User_password = '{password}' AND oi.Ownership_Status = 'Yes' AND li.User_Role = 'Owner'";

            var connection = DatabaseConnection.databaseConnect();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    isValid = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return isValid;
        }

        public bool Handover(string name, string password, string oldOwnerUsername)
        {
            bool isSuccess = false;

            string query = $"INSERT INTO Owner_Info(Owner_name, Owner_password) VALUES (@Name, @Password);" +
                $"INSERT INTO Login_Info(Username, User_password, User_Role) VALUES( (SELECT Owner_Username FROM Owner_Info WHERE Owner_ID = SCOPE_IDENTITY()), (SELECT Owner_password FROM Owner_Info WHERE Owner_ID = SCOPE_IDENTITY()), 'Owner');" +
                $"UPDATE Owner_Info SET Ownership_Status = 'No' WHERE Owner_Username = @Username;";
            
            var connection = DatabaseConnection.databaseConnect();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Username", oldOwnerUsername);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isSuccess = true;
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
            return isSuccess;
        }
    }

    class PayEmployeeSalary
    {
        public DataTable LoadData()
        {
            string sqlQuery = "SELECT EST.EmployeeID, EI.Employee_name, EI.Employee_Username, EST.Salary_Paid_Amount, FORMAT( EST.paidDate, 'MMM-yyyy') as 'paidDate' FROM Employee_Info EI, Employee_Salary_Track EST WHERE EI.Employee_ID = EST.EmployeeID";

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
                }
                return dataTable;
            }
        }

        public DataTable LoadDataSearch(string name, DateTime startDate, DateTime endDate)
        {
            if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Sorry, No data found\nPlease enter the Employee name also", "Not enought info provided!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            int fromYear = startDate.Year;
            int fromMonth = startDate.Month;
            int toYear = endDate.Year;
            int toMonth = endDate.Month;

            int from = fromYear * 100 + fromMonth;
            int to = toYear * 100 + toMonth;

            string sqlQuery = $"SELECT EmployeeID, EI.Employee_name, EI.Employee_Username, Salary_Paid_Amount, FORMAT(EST.paidDate, 'MMM-yyyy') AS 'paidDate' FROM Employee_Salary_Track EST, Employee_Info EI WHERE  EI.Employee_ID = EST.EmployeeID AND EI.Employee_name COLLATE SQL_Latin1_General_CP1_CI_AI = '{name}' AND YEAR(paidDate) * 100 + MONTH(paidDate) BETWEEN {from} AND {to}";

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
                }
                return dataTable;
            }
        }

        public bool checkIDFormat(string data)
        {
            foreach (char c in data)
            {
                if (!char.IsNumber(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool isFieldEmpty(string id, string salary)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(salary))
            {
                return true;
            }
            return false;
        }

        public bool isSalaryAlreadyGiven(int id, int month, int year)
        {
            bool isExisted = false;
            string query = $"SELECT Count(*) FROM Employee_Salary_Track WHERE MONTH(paidDate) = {month} AND YEAR(paidDate) = {year} AND EmployeeID = {id}";

            var connection = DatabaseConnection.databaseConnect();
            {
                try
                {
                    if(connection.State == ConnectionState.Closed)
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand(query, connection);
                        int count = (int)cmd.ExecuteScalar();
                        if(count>0)
                        {
                            isExisted = true; 
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error Occoured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
                return isExisted;
            }
        }

        public bool verifyEmployee(int id)
        {
            string query = $"SELECT Count(*) FROM Employee_Info WHERE Employee_ID = {id}";

            var connection = DatabaseConnection.databaseConnect();
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(query, connection);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        return true;
                    }
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

        public bool salaryBeforeJoindate(int id, int year, int month)
        {
            string query = "SELECT COUNT(*) FROM Employee_Info WHERE Employee_ID = @id AND YEAR(Joining_date) * 100 + MONTH(Joining_date) <= @compareDate";

            var connection = DatabaseConnection.databaseConnect();
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@compareDate", year * 100 + month);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count < 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }


        public bool isPayingAdvance(int selectedYear, int selectedMonth)
        {
            DateTime currentDateTime = DateTime.Now;
            int currentYear = currentDateTime.Year;
            int currentMonth = currentDateTime.Month;

            if(selectedYear > currentYear || (selectedYear == currentYear && selectedMonth > currentMonth))
            {
                return true;
            }

            return false;
        }

        public bool IsSalarySameAsStored(int employeeID, decimal providedSalary)
        {
            string query = $"SELECT Salary FROM Employee_Info WHERE Employee_ID = @EmployeeID";

            var connection = DatabaseConnection.databaseConnect();
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                object result = cmd.ExecuteScalar();

                if (result != null) // && result != DBNull.Value)
                {
                    decimal storedSalary = Convert.ToDecimal(result);
                    return (providedSalary == storedSalary);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool paySalary(int id, string salary, string bonus, string paidDate)
        {
            decimal baseSalary;
            decimal bonusPay = 0.0m;
            decimal amount = 0.0m;

            try
            {
                baseSalary = Convert.ToDecimal(salary);

                if(IsSalarySameAsStored(id, baseSalary))
                {
                    if (!string.IsNullOrEmpty(bonus))
                    {
                        bonusPay = Convert.ToDecimal(bonus);
                    }
                    amount = baseSalary + bonusPay;
                }
                else
                {
                    return false;
                }

                /*if(!string.IsNullOrEmpty(bonus))
                {
                    bonusPay = Convert.ToDecimal(bonus);
                }

                amount = baseSalary + bonusPay; */
            }
            catch (Exception ex)
            {
                return false;
            }

            string query = $"INSERT INTO Employee_Salary_Track (EmployeeID, Salary_Paid_Amount, paidDate) VALUES ({id}, {amount}, '{paidDate}')";
            var connection = DatabaseConnection.databaseConnect();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
    }
}