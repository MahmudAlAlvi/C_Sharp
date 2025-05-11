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
    class LoginInfo
    {
        private int ID { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private string User_role {get; set;}

        public static string GetUsername { get; set; }
        public bool AuthenticateUser(string sqlQuery)
        {
            bool check = false;

            var connection = DatabaseConnection.databaseConnect();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    check = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return check;
        }
        public string LoginAsOwner(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            string sqlQuery = $"SELECT * FROM Login_Info li JOIN Owner_Info oi ON li.Username = oi.Owner_Username AND li.User_password = oi.Owner_password WHERE li.Username = '{Username}' AND li.User_password = '{Password}' AND oi.Ownership_Status = 'Yes';";
            return sqlQuery;
        }
        public string LoginAsEmployee(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            string sqlQuery = $"SELECT * FROM Login_Info WHERE Username = '{Username}' AND User_password = '{Password}' AND User_Role = 'Employee'";
            return sqlQuery;
        }
        public string LoginAsCustomer(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            string sqlQuery = $"SELECT * FROM Login_Info WHERE Username = '{Username}' AND User_password = '{Password}' AND User_Role = 'Customer'";
            return sqlQuery;
        }
    }
}
