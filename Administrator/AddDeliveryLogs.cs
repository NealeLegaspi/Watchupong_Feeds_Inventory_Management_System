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
            
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\Watchupong_Feeds_Inventory_Management_System\Administrator\WatchupongFeedsDB.mdf;Integrated Security=True";


            try
            {
                // Collect data from the form fields
                string productName = cmbProductName.Text.Trim(); // Product Name from user input
                int quantity = int.Parse(txtQuantity.Text.Trim()); // Quantity from user input
                string deliveryDate = dtpDeliveryDate.Value.ToString("yyyy-MM-dd"); // Delivery Date
                string manufacturingDate = dtpMFGDate.Value.ToString("yyyy-MM-dd"); // Manufacturing Date
                string expirationDate = dtpEXPDate.Value.ToString("yyyy-MM-dd"); // Expiration Date

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Step 1: Retrieve product_id based on product_name
                        string getProductIDQuery = @"
                    SELECT product_id 
                    FROM ProductList
                    WHERE product_name = @product_name";

                        int productId;
                        using (SqlCommand cmd = new SqlCommand(getProductIDQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@product_name", productName);
                            object result = cmd.ExecuteScalar();
                            if (result == null)
                            {
                                throw new Exception("Product not found in the database.");
                            }
                            productId = (int)result;
                        }

                        // Step 2: Insert into DeliveryLogs using the retrieved product_id
                        string insertDeliveryLogQuery = @"
                    INSERT INTO DeliveryLogs (delivery_id, product_id, quantity, delivery_date, mfg_date, exp_date)
                    VALUES ((SELECT CONT(delivery_id) FROM DeliveryLogs) + 1, @product_id, @quantity, @delivery_date, @mfg_date, @exp_date)";

                        using (SqlCommand cmd = new SqlCommand(insertDeliveryLogQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@product_id", productId);
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.Parameters.AddWithValue("@delivery_date", deliveryDate);
                            cmd.Parameters.AddWithValue("@mfg_date", manufacturingDate);
                            cmd.Parameters.AddWithValue("@exp_date", expirationDate);
                            cmd.ExecuteNonQuery();
                        }

                        // Commit the transaction
                        transaction.Commit();
                        MessageBox.Show("Delivery log added successfully.");
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction on error
                        transaction.Rollback();
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }
        }
        public void comboProduct()
        {
            WatchupongConnections.Instance.Open();
            var reader = WatchupongConnections.Instance.ExecuteReader
                ("SELECT CONCAT(product_id, '-', product_name) FROM ProductList WHERE status != 0");
            while (reader.Read())
            {

            }
        }
    }
}
