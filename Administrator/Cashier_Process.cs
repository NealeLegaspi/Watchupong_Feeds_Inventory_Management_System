using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public class Cashier_Process
    {
        private static Cashier_Process _instance;
        FlowLayoutPanel Product, Selected;
        Label price;
        public Label priceLabel
        {
            get { return price; }
            set { price = value; }
        }

        public static Cashier_Process Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new Cashier_Process();
                }
                return _instance;
                 }
        }
        public FlowLayoutPanel ProductPnl
        {
            get { return Product; }
            set { Product = value; }
        }
        public FlowLayoutPanel SelectedPnl
        {
            get { return Selected; }
            set { Selected = value; }
        }
        public void ProductShow()
        {
            WatchupongConnections.Instance.Open();
            var reader = WatchupongConnections.Instance.ExecuteReader
                ("SELECT product_id, product_name, quantity, price, product_image, description FROM ProductList WHERE quantity != 0");
            while (reader.Read())
            {
                UC_Product uC_Product = new UC_Product();
                uC_Product.ProductName = reader.GetString(1);
                uC_Product.Getprice = Convert.ToDecimal(reader.GetValue(3));
                uC_Product.GetDescription = reader.GetString(5);
                uC_Product.Tag = reader.GetValue(0);
                if (!reader.IsDBNull(3))
                {
                    uC_Product.GetBytes = (byte[])reader.GetValue(4);
                }
                Product.Controls.Add(uC_Product);
            }
            UC_Product.Onselect += SelectedPnlShow;
        }
        public void SelectedPnlShow(object sender, EventArgs e)
        {
            UC_Product uC_Product= (UC_Product)sender;
            UC_CART uC_CART = new UC_CART();
            uC_CART.Tag = uC_Product.Tag;
            uC_CART.GetName = uC_Product.ProductName;
            uC_CART.getPrice = uC_Product.Getprice;
            ProductListItems.Instace.AddId(Convert.ToInt32(uC_Product.Tag));
            Selected.Controls.Add(uC_CART);

            foreach (Control c in Product.Controls )
            {
            }
        }
        public void revertItem(int id)
        {
            ProductListItems.Instace.DeleteItem(id);
            foreach (Control item in Product.Controls)
            {
                if (item.Tag.Equals(id))
                {
                    
                    item.Visible = true;
                }
            }
        }
        public void AmountChangeAdd(decimal Pprice)
        {
            if (price.Text != "-Total Amount-")
            {
                price.Text = (Convert.ToDecimal(price.Text) + Pprice).ToString();
            }
            else
            {
                price.Text = Pprice.ToString();
            }
            
        }
        public void AmountChangeMinus(decimal Pprice)
        {

            price.Text = (Convert.ToDecimal(price.Text) - Pprice).ToString();
        }

    }
}
