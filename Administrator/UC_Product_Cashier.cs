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
        }

        private void ProductPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Product_Cashier_Load(object sender, EventArgs e)
        {
            
        }

        public void selectedClick(object sender, EventArgs e)
        {
            UC_Product ucP = (UC_Product)sender;
            UC_ProductAddDeduc ucAD = new UC_ProductAddDeduc();
            ucAD.GetProductName = ucP.GetProductName;
            ucAD.GetPrice50g = ucP.GetPrice50g;
            ucAD.GetPrice100g = ucP.GetPrice100g;
            PanelListOfProduct.Controls.Add(ucAD); 
        }
    }
}
