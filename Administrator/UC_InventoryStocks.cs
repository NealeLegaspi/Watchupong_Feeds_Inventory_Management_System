using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.Design.AxImporter;

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
            WatchupongConnections.Instance.Open();
            var adapter = WatchupongConnections.Instance.ExecuteAdapter
                ("SELECT stocks_id, P.product_name, D.quantity, D.delivery_date FROM Stocks AS S\n" +
                "INNER JOIN DeliveryLogs AS D ON D.delivery_id = S.delivery_id \n" +
                "INNER JOIN ProductList AS P ON P.product_id = D.product_id");
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
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
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



