using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Administrator
{
    public partial class UC_Product : UserControl
    {
        private decimal price;
        private string productdescription;
        private int productid;

        public static event EventHandler Onselect;
        public string ProductName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }
        public string GetDescription
        {
            get { return productdescription; }
            set { lblDescription.Text = value; }
        }

        public decimal Getprice
        {
            get { return price; }
            set { price = value; lblPrice.Text = value.ToString(); }
        }


        public UC_Product()
        {
            InitializeComponent();
        }

        private void pbProductImage_Click(object sender, EventArgs e)
        {
            Onselect?.Invoke(this, e);
        }

        private byte[] bytesArray;

        public byte[] GetBytes
        {
            get { return bytesArray; }
            set { bytesArray = value; }
        }

        private void UC_Product_Load(object sender, EventArgs e)
        {
            if (bytesArray != null && bytesArray.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(bytesArray))
                {
                    pbProductImage.Image = Image.FromStream(ms);
                    pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                 
            }
        }
        public int getId
        {
            get { return productid; }
            set { productid = value; }
        }
    }
}


