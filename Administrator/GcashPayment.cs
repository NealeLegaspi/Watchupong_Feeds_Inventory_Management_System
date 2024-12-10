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

        public GcashPayment()
        {
            InitializeComponent();
        }

        private decimal totalamount;

        public decimal getotalAmount
        {
            get { return totalamount; }
            set { totalamount = value; lblGcashAmount.Text = value.ToString(); }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            WatchupongConnections.Instance.Open();
            GcashReceipt2 gcashReceipt = new GcashReceipt2();
            

            if (Convert.ToDecimal(txtAmount.Text) == totalamount)
            {
                var query = WatchupongConnections.Instance.CreateCommand
                    ("BEGIN \n" +
                    "   BEGIN TRANSACTION \n" +
                    "       DECLARE @id AS INT \n" +
                    "       SET @id = (SELECT COUNT(payment_id) FROM Payment) + 1 \n" +
                    "       INSERT INTO Payment VALUES(@id, 'GCash', @change, @amount, @date) \n " +
                    "       INSERT INTO GcashPayment VALUES((SELECT COUNT(gcash_id) FROM GcashPayment) + 1, @account_name, @account_number, @reference_number" +
                    "   COMMIT \n" +
                    "END");
                query.Parameters.AddWithValue("@change", 0);
                query.Parameters.AddWithValue("@amount", totalamount);
                query.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy"));
                query.Parameters.AddWithValue("@account_name", txtAccountName.Text);
                query.Parameters.AddWithValue("@account_number", txtAccountNo.Text);
               // query.Parameters.AddWithValue("@reference_number", )
                query.ExecuteNonQuery();
                AuditQuery.Instance.InsertAudit("Insert new payment");
                InsertProductId();
                gcashReceipt.ShowDialog();


            }
            else if (Convert.ToDecimal(txtAmount.Text) > totalamount)
            {
                decimal amountItems;
                var query = WatchupongConnections.Instance.CreateCommand
                    ("BEGIN \n" +
                    "   BEGIN TRANSACTION \n" +
                    "       DECLARE @id AS INT \n" +
                    "       SET @id = (SELECT COUNT(payment_id) FROM Payment) + 1 \n" +
                    "       INSERT INTO Payment VALUES(@id, 'GCash', @change, @amount, @date) \n " +
                    "       INSERT INTO GcashPayment VALUES(@account_name, @account_number, @reference_number" +
                    "   COMMIT \n" +
                    "END");
                amountItems = Convert.ToDecimal(txtAmount.Text) - totalamount;
                query.Parameters.AddWithValue("@change", 0);
                query.Parameters.AddWithValue("@amount", amountItems);
                query.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy"));
                query.ExecuteNonQuery();
                AuditQuery.Instance.InsertAudit("Insert new payment");
                InsertProductId();
                gcashReceipt.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please input the right amount ", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            WatchupongConnections.Instance.Close();
        }
        public void InsertProductId()
        {
            for (int x = 0; x < ProductListItems.Instace.getCount(); x++)
            {
                var query = WatchupongConnections.Instance.CreateCommand
                    ("BEGIN \n" +
                    "   BEGIN TRANSACTION \n" +
                    "       DECLARE @id AS INT \n" +
                    "       DECLARE @oid AS INT \n" +
                   $"       SET @oid = (SELECT COUNT(order_id) FROM [Order]) + {1} \n" +
                    "       SET @id = (SELECT TOP 1 payment_id FROM Payment ORDER BY payment_id DESC)\n" +
                    "       INSERT INTO [Order] VALUES(@oid, @id, @pid, @quan, (@quan * @price)) \n" +
                    "       UPDATE ProductList SET quantity = quantity - @quan WHERE product_id = @pid \n" +
                    "   COMMIT \n" +
                    "END");
                query.Parameters.AddWithValue("@pid", ProductListItems.Instace.getId(x));
                query.Parameters.AddWithValue("@quan", ProductListItems.Instace.getInt(ProductListItems.Instace.getId(x)));
                query.Parameters.AddWithValue("@price", ProductListItems.Instace.getPrice(ProductListItems.Instace.getId(x)));
                query.ExecuteNonQuery();
                AuditQuery.Instance.UpdateAudit("Decrease product");
            }
        }


        private string GenerateReferenceNumber()
            {

            Random random = new Random();
            return "GC" + random.Next(1000000000, int.MaxValue).ToString();
            }   

        private void GcashPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
