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
            if (string.IsNullOrWhiteSpace(txtproductname.Text) ||
                string.IsNullOrWhiteSpace(txtGrams.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!int.TryParse(txtGrams.Text, out int grams))
            {
                MessageBox.Show("Grams must be a valid integer.");
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

            DateTime manufacturingDate = dtpManufacturingDate.Value.Date;
            DateTime expirationDate = dtpExpirationDate.Value.Date;

            SqlCommand sqlcomm = new SqlCommand(
                "INSERT INTO ProductList (ProductName, Grams, Price, StockStatus, DeliveryDate, Description, Quantity, MfgDate, ExpDate) " +
                "VALUES (@ProductName, @Grams, @Price, @StockStatus, @DeliveryDate, @Description, @Quantity, @ManufacturingDate, @ExpirationDate)", conn);

            sqlcomm.Parameters.AddWithValue("@ProductName", txtproductname.Text);
            sqlcomm.Parameters.AddWithValue("@Grams", grams);
            sqlcomm.Parameters.AddWithValue("@Price", price);
            sqlcomm.Parameters.AddWithValue("@ManufacturingDate", manufacturingDate);
            sqlcomm.Parameters.AddWithValue("@ExpirationDate", expirationDate);
            sqlcomm.Parameters.AddWithValue("@DeliveryDate", DateTime.Now);
            sqlcomm.Parameters.AddWithValue("@Description", rtbDescription.Text);
            sqlcomm.Parameters.AddWithValue("@Quantity", quantity);
            sqlcomm.Parameters.AddWithValue("@StockStatus", "Good");

            try
            {
                conn.Open();
                int rowsAffected = sqlcomm.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product added successfully.");

                    // Raise the ProductAdded event
                    ProductAdded?.Invoke(this, new ProductEventArgs
                    {
                        ProductName = txtproductname.Text,
                        Price50g = price / 2,   // Assume 50g is half the price
                        Price100g = price      // Assume 100g is the full price
                    });
                }
                else
                {
                    MessageBox.Show("Failed to add the product.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        // Define the ProductEventArgs class
        public class ProductEventArgs : EventArgs
        {
            public string ProductName { get; set; }
            public decimal Price50g { get; set; }
            public decimal Price100g { get; set; }
        }
    }
}

