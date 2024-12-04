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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }
        public static EventHandler addProduct;
        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            WatchupongConnections.Instance.Open();
            var query = WatchupongConnections.Instance.CreateCommand
               ("INSERT INTO Inventory values(CONCAT('F0',(SELECT COUNT(ProductID) FROM Inventory) +1 ), @Grams,@price,@StockStatus,@Stocks,@DeliveryD,@Description)");


            query.Parameters.AddWithValue("@Productname", txtproductname.Text);
            query.Parameters.AddWithValue("@Grams", Convert.ToInt32(txtGrams.Text));
            query.Parameters.AddWithValue("@price", txtPrice.Text);
            query.Parameters.AddWithValue("@StockStatus", "Good");
            query.Parameters.AddWithValue("@Stocks", 20);
            query.Parameters.AddWithValue("@DeliveryD", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
            query.Parameters.AddWithValue("@Description", rtbDescription.Text);

            query.ExecuteNonQuery();

            addProduct?.Invoke(this, e);

        }
    }
}
