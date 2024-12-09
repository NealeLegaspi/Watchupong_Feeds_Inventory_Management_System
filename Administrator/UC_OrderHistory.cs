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
        
        
    }
    }

