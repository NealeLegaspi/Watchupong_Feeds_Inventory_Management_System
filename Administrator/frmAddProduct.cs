using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

using System;

namespace Administrator
{
    public partial class frmAddProduct : Form
    {
        SqlConnection conn;

        public frmAddProduct()
        {
            InitializeComponent();
            conn = new SqlConnection(WatchupongConnections.Instance._connectionString);
        }

        // Define a custom event for product addition
        public static event EventHandler<ProductEventArgs> ProductAdded;

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtproductname.Text) &&
                string.IsNullOrWhiteSpace(txtPrice.Text) &&
                string.IsNullOrWhiteSpace(txtQuantity.Text) &&
                imagebytes != null)

            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Price must be a valid decimal number.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Quantity must be a valid integer.");
                return;
            }

            var sqlcomm = WatchupongConnections.Instance.CreateCommand(
                "INSERT INTO ProductList (product_name, quantity, price, product_image, description) " +
                "VALUES (@product_name, @quantity, @price, @product_image, @description)");

            sqlcomm.Parameters.AddWithValue("@product_name", txtproductname.Text);
            sqlcomm.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text));
            sqlcomm.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
            sqlcomm.Parameters.AddWithValue("@product_image", imagebytes);
            sqlcomm.Parameters.AddWithValue("@description", rtbDescription.Text);

            sqlcomm.ExecuteNonQuery();

         
            txtPrice.Clear();
            txtproductname.Clear();
            txtQuantity.Clear();
            pbProductImage.Image = null;
            MessageBox.Show("Product Succesfully Added!");
        }


        private Image productImage;
        private byte[] imagebytes;
        private void AddRawMaterial_picturebox_Click(object sender, EventArgs e)
        {
            pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string imagePath = ofd.FileName;
                productImage = Image.FromFile(imagePath);
                pbProductImage.Image = productImage;
                if (productImage != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        productImage.Save(ms, productImage.RawFormat);
                        imagebytes = ms.ToArray();
                    }
                }
            }

        }


        public class ProductEventArgs : EventArgs
        {
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string imagePath = ofd.FileName;
                productImage = Image.FromFile(imagePath);
                pbProductImage.Image = productImage;
                if (productImage != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        productImage.Save(ms, productImage.RawFormat);
                        imagebytes = ms.ToArray();
                    }
                }
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmAddProduct addProduct = new frmAddProduct();
            this.Close();
        }
    }
}


