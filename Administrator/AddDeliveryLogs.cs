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
    public partial class AddDeliveryLogs : Form
    {
        public AddDeliveryLogs()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "" && cmbProductName.SelectedIndex != -1 && dtpEXPDate.Value > dtpMFGDate.Value)
            {
                WatchupongConnections.Instance.Open();
                var query = WatchupongConnections.Instance.CreateCommand
                    ("BEGIN \n" +
                    "   BEGIN TRANSACTION \n" +
                    "       DECLARE @dlid AS INT \n" +
                    "       SET @dlid = (SELECT COUNT(delivery_id) FROM DeliveryLogs) + 1" +
                    "       UPDATE ProductList SET quantity = quantity + @quantity WHERE product_id = @product_id \n" +
                    "       INSERT INTO DeliveryLogs \n" +
                    "       VALUES(@dlid, @product_id, @quantity, @mfg_date, @exp_date, @delivery_date)\n " +
                    "       INSERT INTO Stocks VALUES((SELECT COUNT(stocks_id) FROM Stocks) + 1,@dlid, @product_id, 'Good', @delivery_date )" +
                    "   COMMIT \n" +
                    "END");
                query.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text));
                query.Parameters.AddWithValue("@product_id", cmbProductName.Text.Split('-')[0]);
                query.Parameters.AddWithValue("@delivery_date", dtpDeliveryDate.Value);
                query.Parameters.AddWithValue("@mfg_date", dtpMFGDate.Value);
                query.Parameters.AddWithValue("@exp_date", dtpEXPDate.Value);
                query.ExecuteNonQuery();

                AuditQuery.Instance.UpdateAudit("Increase quantity product");
                WatchupongConnections.Instance.Close();
                MessageBox.Show("Added Successfully");
                txtQuantity.Clear();
                cmbProductName.SelectedIndex = -1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill up all fileds", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        public void comboProduct()
        {
            WatchupongConnections.Instance.Open();
            var reader = WatchupongConnections.Instance.ExecuteReader
                ("SELECT CONCAT(product_id, '-', product_name) FROM ProductList WHERE status = 0");
            while (reader.Read())
            {
                cmbProductName.Items.Add(reader.GetValue(0));
            }
            reader.Close();
            WatchupongConnections.Instance.Close();
        }

        private void AddDeliveryLogs_Load(object sender, EventArgs e)
        {
            comboProduct();
        }
    }
}
