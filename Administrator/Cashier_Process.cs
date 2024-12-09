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
                ("SELECT product_name, quantity, price, product_image, description, product_Id FROM ProductList WHERE quantity != 0");
            while (reader.Read())
            {
                UC_Product uC_Product = new UC_Product();
                uC_Product.ProductName = reader.GetString(0);
                uC_Product.Getprice = Convert.ToDecimal(reader.GetValue(2));
                uC_Product.GetDescription = reader.GetString(4);
                uC_Product.Tag = reader.GetValue(5);
                uC_Product.getId = Convert.ToInt32(reader.GetValue(5));
                uC_Product.GetBytes = (byte[])reader.GetValue(3);
                Product.Controls.Add(uC_Product);

            }
            reader.Close();
            WatchupongConnections.Instance.Close();
            UC_Product.Onselect += ItemSelected;
        }
        public void ItemSelected(object sender, EventArgs e)
        {
            UC_Product uC_Product = (UC_Product)sender;
            UC_ProductAddDeduc uC_CART = new UC_ProductAddDeduc();
            uC_CART.GetProductName = uC_Product.ProductName;
            uC_CART.GetPrice = uC_Product.Getprice;
            Cashier_Process.Instance.AmountChangeAdd(uC_Product.Getprice);
            uC_CART.GetId = Convert.ToInt32(uC_Product.Tag);
            uC_CART.Tag = uC_Product.Tag;
            ProductListItems.Instace.AddId(uC_Product.getId);
            ProductListItems.Instace.AddInt(1);
            ProductListItems.Instace.AddPrice(Convert.ToDecimal(uC_CART.GetPrice));
            Selected.Controls.Add(uC_CART);
            for (int x = 0; x < Product.Controls.Count; x++)
            {
                Control control = Product.Controls[x];
                if (control.Tag != null && control.Tag.Equals(uC_CART.Tag))
                {
                    control.Visible = false;
                }
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
        public void ClearItems()
        {
            Product.Controls.Clear();
            Selected.Controls.Clear();
        }

    }
}
