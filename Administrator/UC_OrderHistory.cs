using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace Administrator
{
    public partial class UC_OrderHistory : UserControl
    {
        SqlConnection sqlcon;
        public UC_OrderHistory()
        {
            InitializeComponent();
            
        }
        

        private void dtgOrderHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void UC_OrderHistory_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security=True"))
            {
                conn.Open();

                string query = "SELECT order_id, payment_id, product_id, quantity, total_price FROM [Order]";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dtgOrderHistory.DataSource = dt; 
                reader.Close();
                conn.Close();
            }
        }
        
        
    }
    }

