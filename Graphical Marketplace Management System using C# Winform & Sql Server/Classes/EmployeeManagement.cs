using System;
using Online_MarketPlace.Database;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Online_MarketPlace.Classes
{
    class EmployeeManagement
    {
        private int employeeID { get; set; }
        private string employeeUsername { get; set; }
        private string employeeNickname { get; set; }
        private string employeePassword { get; set; }
        private decimal employeeSalary { get; set; }
        private DateTime employeeJoiningDate { get; set; }

        public EmployeeManagement()
        {

        }

        public bool IsNameValid(string username)
        {
            employeeNickname = username;
            foreach (char c in employeeNickname)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsInfoSame(DataGridView dataGridView, string password, string salary, DateTime date)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                string passwordFromGrid = selectedRow.Cells[3].Value?.ToString();
                string salaryFromGrid = selectedRow.Cells[4].Value?.ToString();
                string dateFromGrid = selectedRow.Cells[6].Value?.ToString();

                if (passwordFromGrid == password && salaryFromGrid == salary && dateFromGrid == date.ToString())
                {
                    return true;
                }
            }

            return false;
        }

        public bool InsertDataIntoDatabase(string nickname, string password, decimal salary, DateTime joiningDate)
        {
            bool check = false;

            this.employeeNickname = nickname;
            this.employeePassword = password;
            this.employeeSalary = salary;
            employeeJoiningDate = joiningDate;

            string joinDate = employeeJoiningDate.ToString("yyyy-MM-dd");

            string insertQuery = $"Insert into Employee_Info(Employee_name, Employee_password, Salary, Joining_date) values ('{employeeNickname}', '{employeePassword}', {employeeSalary}, '{joinDate}');" +
                $"INSERT INTO Login_Info (Username, User_password, User_Role) VALUES((SELECT Employee_Username FROM Employee_Info WHERE Employee_ID = SCOPE_IDENTITY()),(SELECT Employee_password FROM Employee_Info WHERE Employee_ID = SCOPE_IDENTITY()),'Employee')";
            
            if(executeQuery(insertQuery))
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
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand(query, connection);
                try
                {
                    int affectedRows = cmd.ExecuteNonQuery();
                    if(affectedRows > 0)
                    {
                        check = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return check;
        }
        public DataTable LoadData()
        {
            string sqlQuery = "SELECT Employee_ID, Employee_name, Employee_Username, Employee_password, Salary, Bonus, CONVERT(DATE, Joining_date) as 'Joining_date' FROM Employee_Info";

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
        public bool updateInfo(string username, string password, decimal salary, DateTime joiningDate)
        {
            bool valid = false;

            string joinDate = joiningDate.ToString("yyyy - MM - dd");

            string sqlQuery = $"update Employee_Info set Employee_password = '{password}', Salary = {salary}, Joining_date = '{joinDate}' where Employee_Username = '{username}';" +
                $"update Login_Info set User_password = '{password}' where Username = '{username}' and User_Role = 'Employee';";

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

        public bool removeEmployee(string username)
        {
            bool check = false;
            employeeUsername = username;
            string removeQuery = @"
                                delete from Employee_Salary_Track where EmployeeID = (select Employee_ID from Employee_Info where Employee_Username = @employeeUsername);
                                delete from Employee_Info where Employee_Username = @employeeUsername;
                                delete from Login_Info where Username = @employeeUsername and User_Role = 'Employee'";

            var connection = DatabaseConnection.databaseConnect();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(removeQuery, connection);

                command.Parameters.AddWithValue("@employeeUsername", employeeUsername);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    check = true;
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