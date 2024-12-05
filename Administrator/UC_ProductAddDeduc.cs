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
        private decimal Price50g;
        private decimal Price100g;

        private void UC_ProductAddDeduc_Load(object sender, EventArgs e)
        {

        }

        public string GetProductName
        {
            get { return ProductName; }
            set { ProductName = value; txtProductName.Text = value; }
        }
        public decimal GetPrice50g
        {
            get { return Price50g; }
            set { Price50g = value; }
        }
        public decimal GetPrice100g
        {
            get { return Price100g; }
            set { Price100g = value; }
        }
    }
}
