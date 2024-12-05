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
    public partial class UC_CART : UserControl
    {
        
        public UC_CART()
        {
            InitializeComponent();
        }
        private string _name;
        private decimal price;

        public string GetName
        {
            get {return _name; }
            set { _name = value;
                txtProductName.ReadOnly = true;
                txtProductName.Text = value;  }
        }
        public decimal getPrice 
        {
            get { return price; }
            set { price = value;}
        }
    }
}