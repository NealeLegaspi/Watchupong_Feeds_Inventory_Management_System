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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Administrator
{
    public partial class UC_Product : UserControl
    {
        // Add properties
        public static event EventHandler Onselect;
        public string ProductName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }

        public decimal Price50g
        {
            get { return decimal.Parse(lblPrice50g.Text.Replace("50g: ", "").Replace("$", "")); }
            set { lblPrice50g.Text = $"50g: ${value}"; }
        }

        public decimal Price100g
        {
            get { return decimal.Parse(lblPrice100g.Text.Replace("100g: ", "").Replace("$", "")); }
            set { lblPrice100g.Text = $"100g: ${value}"; }
        }

        public UC_Product()
        {
            InitializeComponent();
        }

        private void pbProductImage_Click(object sender, EventArgs e)
        {
            Onselect?.Invoke(this, e);
        }
    }
}


