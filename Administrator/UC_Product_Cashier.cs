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
            frmAddProduct.ProductAdded += OnProductAdded;
        }
        public void ItemShow()
        {
            WatchupongConnections.Instance.Open();
            var reader = WatchupongConnections.Instance.ExecuteReader
                ("SELECT ProductName, Quantity, Price FROM ProductList WHERE StockStatus = 'Good'");
            while (reader.Read())
            {
                UC_Product uC_Product = new UC_Product();
                uC_Product.ProductName = reader.GetString(0);
                uC_Product.Price50g = Convert.ToDecimal(reader.GetValue(1));
                flowLayoutPanel1.Controls.Add(uC_Product);
                UC_Product.Onselect += ItemSelected;
            }


        }
        public void ItemSelected(Object sender, EventArgs e)
        {
            UC_Product uC_Product = (UC_Product)sender;
           UC_CART uC_CART = new UC_CART();
            uC_CART.GetName = uC_Product.ProductName;
           // uC_CART.getPrice = uC_Product.Price100g;
            flowLayoutPanel2.Controls.Add(uC_CART);
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
            ItemShow();
        }
    }
}



