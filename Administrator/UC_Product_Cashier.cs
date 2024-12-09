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
    public partial class UC_Product_Cashier : UserControl
    {
        public UC_Product_Cashier()
        {
            InitializeComponent();

            // Subscribe to the ProductAdded event
        }
        public void ItemShow()
        {
            WatchupongConnections.Instance.Open();
            var reader = WatchupongConnections.Instance.ExecuteReader
                ("SELECT product_name, quantity, price, product_image, description, product_Id FROM ProductList WHERE quantity != 0");
            while (reader.Read())
            {
                UC_Product uC_Product = new UC_Product();
                uC_Product.ProductName = reader.GetString(0);
                uC_Product.Getprice = Convert.ToDecimal(reader.GetValue(2));
                uC_Product.GetDescription = reader.GetString(4);
                uC_Product.Tag = reader.GetValue(5);
                uC_Product.getId = Convert.ToInt32(reader.GetValue(5));
                if (!reader.IsDBNull(3))
                {
                    uC_Product.GetBytes = (byte[])reader.GetValue(3);
                }
                else
                {
                    // Handle null values appropriately, e.g., set a default image or log a warning
                    uC_Product.GetBytes = null; // Or set a default image
                }
                flowLayoutPanel1.Controls.Add(uC_Product);

            }
            reader.Close();
            WatchupongConnections.Instance.Close();
            UC_Product.Onselect += ItemSelected;
        }
        public void ItemSelected(Object sender, EventArgs e)
        {

            UC_Product uC_Product = (UC_Product)sender;
            UC_ProductAddDeduc uC_CART = new UC_ProductAddDeduc();
            uC_CART.GetProductName = uC_Product.ProductName;
            uC_CART.GetPrice = uC_Product.Getprice;
            Cashier_Process.Instance.AmountChangeAdd(uC_Product.Getprice);
            uC_CART.GetId = Convert.ToInt32(uC_Product.Tag);
            uC_CART.Tag = uC_Product.Tag;
            ProductListItems.Instace.AddId(uC_Product.getId);
            ProductListItems.Instace.AddInt(1);
            ProductListItems.Instace.AddPrice(Convert.ToDecimal(uC_CART.GetPrice));
            flowLayoutPanel2.Controls.Add(uC_CART);
            for (int x = 0; x < flowLayoutPanel1.Controls.Count; x++)
            {
                Control control = flowLayoutPanel1.Controls[x];
                if (control.Tag != null && control.Tag.Equals(uC_CART.Tag))
                {
                    control.Visible = false;
                }
            }
        }

        private void OnProductAdded(object sender, frmAddProduct.ProductEventArgs e)
        {
            // Create a new UC_Product instance and set its properties

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Handle painting logic, if needed
        }

        private void UC_Product_Cashier_Load_1(object sender, EventArgs e)
        {
            Cashier_Process.Instance.ProductPnl = flowLayoutPanel1;
            Cashier_Process.Instance.priceLabel = Amount;
            ItemShow();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            CashPayment cash = new CashPayment();
            cash.getAmount = Convert.ToDecimal(Amount.Text);
            cash.ShowDialog();

        }

        private void btnGcash_Click(object sender, EventArgs e)
        {

        }
    }
}



