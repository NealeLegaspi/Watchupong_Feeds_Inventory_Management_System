using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class UC_OrderHistory : UserControl
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\Watchupong_Feeds_Inventory_Management_System\Administrator\WatchupongFeedsDB.mdf;Integrated Security=True";
        public UC_OrderHistory()
        {
            InitializeComponent();
            LoadData();
        }

        private void dtgOrderHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Customer_ID, ProductName, Payment, DateTime, Total FROM OrderHistory";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dtgOrderHistory.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }
    }
}
