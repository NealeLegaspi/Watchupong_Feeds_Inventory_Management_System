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
    public partial class UC_ProductAddDeduc : UserControl
    {
        public UC_ProductAddDeduc()
        {
            InitializeComponent();
        }

        private string ProductName;
        private decimal price;
        private int id;
        private int quantity = 1, stocks;
        private void UC_ProductAddDeduc_Load(object sender, EventArgs e)
        {
            txtProductName.ReadOnly = true;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            CashPayment cashPayment = new CashPayment();
            cashPayment.ShowDialog();
            this.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (quantity != stocks)
            {
                quantity++;
                quantity_lbl.Text = quantity.ToString();
                Cashier_Process.Instance.AmountChangeAdd(price);
                ProductListItems.Instace.UpdateInt(id, quantity);
            }
        }

        private void btnDeduct_Click(object sender, EventArgs e)
        {
            if (quantity != 1)
            {
                quantity--;
                quantity_lbl.Text = quantity.ToString();
                ProductListItems.Instace.UpdateInt(id, quantity);
                Cashier_Process.Instance.AmountChangeMinus(price);
            }
            else
            {
                if (MessageBox.Show("Do you want to delete this item", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cashier_Process.Instance.AmountChangeMinus(price);
                    Cashier_Process.Instance.revertItem(id);
                    ProductListItems.Instace.Removequan(id);
                    ProductListItems.Instace.RemvePrice(id);
                    ProductListItems.Instace.DeleteItem(id);
                    this.Dispose();
                }
            }
        }

        public string GetProductName
        {
            get { return ProductName; }
            set { ProductName = value; txtProductName.Text = value; }
        }
        public decimal GetPrice
        {
            get { return price; }
            set { price = value; ProductPrice.Text = value.ToString(); }
        }
        public int GetId
        {
            get { return id; }
            set { id = value; }
        }
    }
}
