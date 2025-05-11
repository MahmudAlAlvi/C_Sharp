using Online_MarketPlace.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Online_MarketPlace.Classes
{
    public class Dashboard
    { 
        public Dashboard() { }

        private decimal productExpense, employeeSalaryExpense;

        public int employeeNumber { get; set; }
        public int totalOrders { get; set; }
        public int totalSales { get; set; }
        public decimal totalRevenue { get; set; }
        public decimal totalExpense { get; set; }
        public decimal totalProfit { get; set; }

        public void getData(DateTime startDate, DateTime endDate)
        {
            string fromDate = startDate.ToString("yyyy-MM-dd");
            string toDate = endDate.ToString("yyyy-MM-dd");

            string totalOrderQuery = $"select COUNT(*) from Order_Info WHERE  FORMAT(OrderDate, 'yyyy-MM-dd') between '{fromDate}' AND '{toDate}'";

            string totalEmployeeQuery = $"select COUNT(*) 'Total Employees' from Employee_Info WHERE  FORMAT(Joining_date, 'yyyy-MM-dd') <= '{toDate}'";

            string totalSalesQuery = $"select COUNT(*) 'Total Sales' from Sales_Info WHERE  FORMAT(OrderDate, 'yyyy-MM-dd') between '{fromDate}' AND '{toDate}'";

            string totalRevenueQuery = $"select isnull(sum(Total_Amount),0) from Sales_Info where FORMAT(OrderDate, 'yyyy-MM-dd') between '{fromDate}' and '{toDate}'";

            string productExpenseQuery = $"select isnull(sum(total_Cost),0) from Expense_Info where FORMAT(issueDate, 'yyyy-MM-dd') between '{fromDate}' and '{toDate}'";

            string employeeSalaryExpenseQuery = $"select isnull(sum(Salary_Paid_Amount),0) from Employee_Salary_Track where FORMAT(paidDate, 'yyyy-MM-dd') between '{fromDate}' and '{toDate}'";

            using (var connect = DatabaseConnection.databaseConnect())
            {
                if(connect.State == ConnectionState.Closed)
                {
                    connect.Open();

                    SqlCommand cmdOrder = new SqlCommand(totalOrderQuery, connect);
                    object Orders = cmdOrder.ExecuteScalar();
                    totalOrders = Convert.ToInt32(Orders);

                    SqlCommand cmdSales = new SqlCommand(totalSalesQuery, connect);
                    object Sales = cmdSales.ExecuteScalar();
                    totalSales = Convert.ToInt32(Sales);

                    SqlCommand cmdEmployee = new SqlCommand(totalEmployeeQuery, connect);
                    object Employee = cmdEmployee.ExecuteScalar();
                    employeeNumber = Convert.ToInt32(Employee);

                    SqlCommand cmdRevenue = new SqlCommand(totalRevenueQuery, connect);
                    object Revenue = cmdRevenue.ExecuteScalar();
                    totalRevenue = Convert.ToDecimal(Revenue);

                    SqlCommand cmdProductExpense = new SqlCommand(productExpenseQuery, connect);
                    object product_Expense = cmdProductExpense.ExecuteScalar();
                    productExpense = Convert.ToDecimal(product_Expense);

                    SqlCommand cmdEmployeeSalaryExpense = new SqlCommand(employeeSalaryExpenseQuery, connect);
                    object employeSalaryExpense = cmdEmployeeSalaryExpense.ExecuteScalar();
                    employeeSalaryExpense = Convert.ToDecimal(employeSalaryExpense);

                    totalExpense = productExpense + employeeSalaryExpense;
                    totalProfit = totalRevenue - totalExpense;

                    connect.Close();
                }
            }
        }
    }
}