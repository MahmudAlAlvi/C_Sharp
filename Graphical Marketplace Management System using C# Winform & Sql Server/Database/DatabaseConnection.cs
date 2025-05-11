using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Online_MarketPlace.Database
{
    public abstract class DatabaseConnection
    {
        const string connectionString = @"Data Source=ALVI08\SQLEXPRESS;Initial Catalog=E-Shop;Integrated Security=True;Encrypt=False";
        public static SqlConnection databaseConnect()
        {
            return new SqlConnection(connectionString);
        }
    }
}
//ALVI08\SQLEXPRESS
