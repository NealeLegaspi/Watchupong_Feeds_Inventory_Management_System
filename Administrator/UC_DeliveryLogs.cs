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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Administrator
{
    public partial class UC_DeliveryLogs : UserControl
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\Watchupong_Feeds_Inventory_Management_System\Administrator\WatchupongFeedsDB.mdf;Integrated Security=True";

        public UC_DeliveryLogs()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtDLSearchBar_TextChanged(object sender, EventArgs e)
        {
            SearchData(txtSearchBar.Text);
        }

        private void dtgDeliveryLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT delivery_id , product_id AS product_name , quantity, mfg_date, exp_date ,delivery_date FROM DeliveryLogs";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dtgDeliveryLogs.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }
        private void SearchData(string searchTerm)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Inventory WHERE product_name LIKE @SearchTerm";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dtgDeliveryLogs.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching data: " + ex.Message);
                }
            }
        }

        private void UC_DeliveryLogs_Load(object sender, EventArgs e)
        {
            LoadData();
        }

    

        private void btnArchived_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Archived functionality is not implemented yet.");
        }

  

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddDeliveryLogs addDeliveryLogs = new AddDeliveryLogs();
            addDeliveryLogs.ShowDialog();
        }
    }
}
