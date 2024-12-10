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
     
        }

        private void dtgDeliveryLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       

        private void UC_DeliveryLogs_Load(object sender, EventArgs e)
        {
            WatchupongConnections.Instance.Open();
            var adapter = WatchupongConnections.Instance.ExecuteAdapter
                ("SELECT delivery_id, P.product_name, D.quantity, D.delivery_date FROM DeliveryLogs AS D \n" +
                "INNER JOIN ProductList AS P ON P.product_id = D.product_id");
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgDeliveryLogs.DataSource = dt;
            WatchupongConnections.Instance.Close();

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
