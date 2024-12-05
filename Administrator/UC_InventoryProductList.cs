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
    public partial class UC_InventoryProductList : UserControl
    {
        public UC_InventoryProductList()
        {
            InitializeComponent();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            WatchupongConnections.Instance.Open();
            var reader = WatchupongConnections.Instance.ExecuteReader("SELECT * From ProductList");
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2),
                                       reader.GetValue(3), reader.GetValue(4), reader.GetValue(5),
                                       reader.GetValue(6), reader.GetValue(7), reader.GetValue(8));
            }
            reader.Close();
            WatchupongConnections.Instance.Close();

            // Apply the styles again after loading the data
            SetDataGridViewStyles(dataGridView1);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void SetDataGridViewStyles(DataGridView dataGridView)
        {
            // Set the text color for default rows
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;

            // Set the text color for alternating rows
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            // Set the background color for default rows (optional)
            dataGridView.DefaultCellStyle.BackColor = Color.White;

            // Set header style (optional)
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Optional: Set the default font for cells
            dataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }


        private void UC_InventoryProductList_Load(object sender, EventArgs e)
        {

            SetDataGridViewStyles(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

