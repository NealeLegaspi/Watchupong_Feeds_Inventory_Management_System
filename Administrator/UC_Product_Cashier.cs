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

        private void OnProductAdded(object sender, frmAddProduct.ProductEventArgs e)
        {
            // Create a new UC_Product instance and set its properties
            UC_Product ucProduct = new UC_Product
            {
                ProductName = e.ProductName,
                Price50g = e.Price50g,
                Price100g = e.Price100g
            };

            // Add to flowLayoutPanel
            flowLayoutPanel1.Invoke((MethodInvoker)delegate
            {
                flowLayoutPanel1.Controls.Add(ucProduct);
            });
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Handle painting logic, if needed
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            // Handle painting logic, if needed
        }

        private void UC_Product_Cashier_Load(object sender, EventArgs e)
        {

        }
    }
}



