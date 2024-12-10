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
    public partial class UC_Home : UserControl
    {
        SqlConnection conn;
        public UC_Home()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security = True");
        }
        static OrderHistoryQuery orderhistory = new OrderHistoryQuery();

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            RefreshOrderHistory();
            LoadLowStockData();
            LoadTopProductData();

            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security=True"))
            {
                conn.Open();

                string query = "SELECT " +
                    "order_id, " +
                    "PL.product_name, " +
                    "P.payment_method , " +
                    "O.quantity, " +
                    "O.total_price, " +
                    "P.date_time AS 'Delivery Date'" +
                    "FROM [Order] AS O\n" +
                    "INNER JOIN Payment AS P ON P.payment_id = O.payment_id \n" +
                    "INNER JOIN ProductList AS PL ON PL.product_id = O.product_id";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dtgOrderHistory.DataSource = dt;
                reader.Close();
                conn.Close();
            }
        }

        public void RefreshOrderHistory()
        {
            orderhistory.DisplayList();
            dtgOrderHistory.DataSource = orderhistory.bindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void LoadLowStockData()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT product_name, quantity FROM ProductList WHERE quantity <= 10 ORDER BY quantity ASC", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dtgLowStocks.DataSource = dataTable; // Assuming dgvLowStock is your DataGridView for Low Stock
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading low stock data: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadTopProductData()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT p.product_name, SUM(o.quantity) " +
                    "FROM Order o " +
                    "INNER JOIN ProductList p ON o.product_id = p.product_id FROM Order o " +
                    "GROUP BY p.product_name " , conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dtgTopProduct.DataSource = dataTable; // Assuming dgvTopProduct is your DataGridView for Top Products
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading top product data: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
