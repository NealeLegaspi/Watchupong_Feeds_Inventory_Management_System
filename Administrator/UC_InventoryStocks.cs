using Microsoft.Data.SqlClient;
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
    public partial class UC_InventoryStocks : UserControl
    {
        private readonly SqlConnection sqlcon;

        public UC_InventoryStocks()
        {
            InitializeComponent();
            sqlcon = new SqlConnection(WatchupongConnections.Instance.ConnectionString);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase("SELECT * FROM Stocks");
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase("SELECT * FROM ProductList");
        }

        private void LoadDataFromDatabase(string query)
        {
            try
            {
                sqlcon.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlcon);
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAddProduct = new frmAddProduct();
            frmAddProduct.ShowDialog();
        }

        private void UC_InventoryStocks_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase("SELECT * FROM Stocks");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



