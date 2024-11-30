using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class UC_Product : UserControl
    {
        public UC_Product()
        {
            InitializeComponent();
        }

        private string ProductName;
        private decimal Price50g;
        private decimal Price100g;
        private byte[] ProductImage;

        public static event EventHandler P50g, P100g;                                               

        public string GetProductName
        {
            get { return ProductName; }
            set { ProductName = value; lblProductName.Text = value; }
        }
        public decimal GetPrice50g
        {
            get { return Price50g; }
            set { Price50g = value; lblPrice50g.Text = value.ToString(); }
        }
        public decimal GetPrice100g
        {
            get { return Price100g; }
            set { Price100g = value; lblPrice100g.Text = value.ToString(); }
        }

        public byte[] GetProductImage
        {
            get { return ProductImage; }
            set { ProductImage = value; }
        }




        private void UC_Product_Load(object sender, EventArgs e)
        {


        }

        private void btn50g_Click(object sender, EventArgs e)
        {
            P50g?.Invoke(this, e);
        }

        private void btn100g_Click(object sender, EventArgs e)
        {
            P100g?.Invoke(this, e);
        }
    }
}
