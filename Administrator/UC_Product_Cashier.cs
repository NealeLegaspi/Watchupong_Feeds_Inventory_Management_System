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
            Cashier_Process.Instance.SelectedPnl = flowLayoutPanel2;
            Cashier_Process.Instance.priceLabel = Amount;
            Cashier_Process.Instance.ProductShow();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            CashPayment cash = new CashPayment();
            cash.getAmount = Convert.ToDecimal(Amount.Text);
            cash.ShowDialog();

        }

        private void btnGcash_Click(object sender, EventArgs e)
        {
            GcashPayment gcash = new GcashPayment();
            gcash.ShowDialog();


        }
    }
}



