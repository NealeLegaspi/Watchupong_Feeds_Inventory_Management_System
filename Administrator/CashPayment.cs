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
    public partial class CashPayment : Form
    {
        public CashPayment()
        {
            InitializeComponent();
        }
        private decimal totalamoubt;

        public decimal getAmount
        {
            get { return totalamoubt; }
            set { totalamoubt = value; lblTotalAmount.Text = value.ToString(); }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            WatchupongConnections.Instance.Open();
            CashReceipt cash = new CashReceipt();
            if (Convert.ToDecimal(txtAmount.Text) == totalamoubt)
            {
                var query = WatchupongConnections.Instance.CreateCommand
                    ("BEGIN \n" +
                    "   BEGIN TRANSACTION \n" +
                    "       DECLARE @id AS INT \n" +
                    "       SET @id = (SELECT COUNT(payment_id) FROM Payment) + 1 \n" +
                    "       INSERT INTO Payment VALUES(@id, 'Cash', @change, @amount, @date) \n " +
                    "   COMMIT \n" +
                    "END");
                query.Parameters.AddWithValue("@change", 0);
                query.Parameters.AddWithValue("@amount", totalamoubt);
                query.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy"));
                query.ExecuteNonQuery();
                InsertProductId();
                cash.ShowDialog();
            }
            else if(Convert.ToDecimal(txtAmount.Text) > totalamoubt)
            {
                decimal amountItems;
                var query = WatchupongConnections.Instance.CreateCommand
                    ("BEGIN \n" +
                    "   BEGIN TRANSACTION \n" +
                    "       DECLARE @id AS INT \n" +
                    "       SET @id = (SELECT COUNT(payment_id) FROM Payment) + 1 \n" +
                    "       INSERT INTO Payment VALUES(@id, 'Cash', @change, @amount, @date) \n " +
                    "   COMMIT \n" +
                    "END");
                amountItems = Convert.ToDecimal(txtAmount.Text) - totalamoubt;
                query.Parameters.AddWithValue("@change", 0);
                query.Parameters.AddWithValue("@amount", amountItems);
                query.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy"));
                query.ExecuteNonQuery();
                InsertProductId();
                cash.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please input the right amount ", "Question", MessageBoxButtons.OK , MessageBoxIcon.Question);
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
            }
        }

    }
}
