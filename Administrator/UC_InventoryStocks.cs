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
        public UC_InventoryStocks()
        {
            InitializeComponent();
        }
        //paayos query
        static SqlConnection sqlcon = new SqlConnection();
        static SqlCommand sqlcom = new SqlCommand();
        static SqlCommand sqlcom2 = new SqlCommand();
        static DataTable Inventory = new DataTable();

        private void btnStock_Click(object sender, EventArgs e)
        {
            WatchupongConnections.Instance.Open();
            var reader = WatchupongConnections.Instance.ExecuteReader
                ("SELECT ProductID, ProductName, Grams,Price,StockStatus,Stocks,DeliveryDate,Description From Inventory");
            while (reader.Read())
            {
                dtgInventory.Rows.Add
                    (reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7));
            }
            reader.Close();
            WatchupongConnections.Instance.Close();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            WatchupongConnections.Instance.Open();
            var reader = WatchupongConnections.Instance.ExecuteReader
                ("SELECT ProductID, ProductName, Grams, QtyStock,Price,StockStatus,MfgDate,ExpDate From Inventory_Stock");
            while (reader.Read())
            {
                dtgInventory.Rows.Add
                    (reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7));
            }
            reader.Close();
            WatchupongConnections.Instance.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAddProduct = new frmAddProduct();
            frmAddProduct.ShowDialog();
            this.Hide();
        }
    }
}

