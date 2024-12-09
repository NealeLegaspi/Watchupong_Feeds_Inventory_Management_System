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
    public partial class GcashPayment : Form
    {
        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security = True";
        public GcashPayment()
        {
            InitializeComponent();
        }

     
        private void btnPay_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNo.Text.Trim();
            string accountName = txtAccountName.Text.Trim();

            // Validate inputs
            if (string.IsNullOrWhiteSpace(accountNumber) || string.IsNullOrWhiteSpace(accountName))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generate a unique reference number
            string referenceNumber = GenerateReferenceNumber();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO GcashPayment (reference_number, account_number, account_name) " +
                                   "VALUES (@ReferenceNumber, @AccountNumber, @AccountName)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
                        cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                        cmd.Parameters.AddWithValue("@AccountName", accountName);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Payment successful! Reference Number: {referenceNumber}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Payment failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                GcashReceipt gcashReceipt = new GcashReceipt();
                gcashReceipt.ShowDialog();
            }
        }
        private string GenerateReferenceNumber()
        {
            
            Random random = new Random();
            return "GC" + random.Next(1000000000, int.MaxValue).ToString();
        }
    }
}
