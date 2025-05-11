using System;
using System.Data;
using Online_MarketPlace.Classes;
using System.Windows.Forms;
using System.Data.SqlClient;
using Online_MarketPlace.Database;
using System.Windows.Forms.DataVisualization.Charting;

namespace Online_MarketPlace.User_Controls
{
    public partial class ownerDashboard : UserControl
    {
        private Dashboard obj;

        public int employeeNumber { get; private set; }
        public int totalOrders { get; set; }
        public int totalSales { get; set; }
        public decimal totalRevenue { get; set; }
        public decimal totalExpense { get; set; }
        public decimal totalProfit { get; set; }

        public decimal employeeSalary { get; set; }
        public decimal productExpense { get; set; }

        public ownerDashboard()
        {
            InitializeComponent();
            obj = new Dashboard();

            customBtn.Checked = true;
            customStartDatePicker.Value = DateTime.Today.AddDays(-365);
            customEndDatePicker.Value = DateTime.Today;
            FetchData(DateTime.Today.AddDays(-365), DateTime.Today);
            obj.getData(DateTime.Today.AddDays(-365), DateTime.Today);

            showData(obj);
        }
        private void FetchData(DateTime startDate, DateTime endDate)
        {
            try
            {
                string chartQuery = "SELECT OrderDate, SUM(Total_Amount) 'Total_Amount' FROM Sales_Info WHERE OrderDate between @StartDate AND @EndDate group by OrderDate";
                var connection = DatabaseConnection.databaseConnect();
                using (connection)
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(chartQuery, connection);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        //revenueChart.Controls.Clear();

                        revenueChart.DataSource = dataTable;

                        revenueChart.Series["Revenue"].XValueMember = "OrderDate";
                        revenueChart.Series["Revenue"].XValueType = ChartValueType.Auto;

                        revenueChart.Series["Revenue"].YValueMembers = "Total_Amount";
                        revenueChart.Series["Revenue"].YValueType = ChartValueType.Auto;
                    }     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void todayBtn_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime now = DateTime.Now;

            customStartDatePicker.Value = DateTime.Today;
            customEndDatePicker.Value = DateTime.Now;

            FetchData(today, now);

            obj.getData(today, now);
            
            showData(obj);
        }

        private void last7daysBtn_Click(object sender, EventArgs e)
        {
            DateTime last7Days = DateTime.Today.AddDays(-7); // Go back 6 days for last 7 days including today
            
            customStartDatePicker.Value = last7Days;
            customEndDatePicker.Value = DateTime.Today.AddDays(-1);

            FetchData(last7Days, DateTime.Today);

            obj.getData(last7Days, DateTime.Today);
            
            showData(obj);
        }

        private void last30daysBtn_Click(object sender, EventArgs e)
        {
            DateTime last30Days = DateTime.Today.AddDays(-30); // Go back 30 days for last 30 days
            
            customStartDatePicker.Value = last30Days;
            customEndDatePicker.Value = DateTime.Today.AddDays(-1);

            FetchData(last30Days, DateTime.Today);

            obj.getData(last30Days, DateTime.Today);
            
            showData(obj);
        }

        private void thisMonthBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);
            customStartDatePicker.Value = startDate;
            customEndDatePicker.Value = endDate;
            FetchData(startDate, endDate);

            obj.getData(startDate, endDate);
            
            showData(obj);
        }

        private void customBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = customStartDatePicker.Value;
            DateTime endDate = customEndDatePicker.Value;
            
            if(startDate > endDate)
            {
                MessageBox.Show("Start Date must me less than the End Date");
            }
            else
            {
                FetchData(startDate, endDate);
                obj.getData(startDate, endDate);

                showData(obj);
            }
        }
        private void showData(Dashboard obj)
        {
            lblTotalOrders.Text = obj.totalOrders.ToString();
            lblTotalSales.Text = obj.totalSales.ToString();
            lblTotalEmployees.Text = obj.employeeNumber.ToString();

            lblTotalRevenue.Text = "$" + obj.totalRevenue.ToString();
            lblTotalProfit.Text = "$" + obj.totalProfit.ToString();
            lblTotalExpense.Text = "$" + obj.totalExpense.ToString();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalOrders_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalRevenue_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalProfit_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void revenueChart_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalSales_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalExpense_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalEmployees_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customStartDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void customEndDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ownerDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}