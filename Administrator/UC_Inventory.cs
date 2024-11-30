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
    public partial class UC_Inventory : UserControl
    {
        public UC_Inventory()
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
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT StockID,ProductID,ProductName,Grams,Instock,Price,StockStatus,MfgDate,ExpDate*, FROM  ", sqlcon);
            SqlDataAdapter sqa = new SqlDataAdapter(sqlcom);
            Inventory.Clear();
            sqa.Fill(Inventory);
            dtgInventory.DataSource = Inventory;
            sqlcon.Close();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT ProductID, ProductName,Grams,Price,QtyStock,MfgDate, ExpDate, Status*, FROM  ", sqlcon);
            SqlDataAdapter sqa = new SqlDataAdapter(sqlcom);
            Inventory.Clear();
            sqa.Fill(Inventory);
            dtgInventory.DataSource = Inventory;
            sqlcon.Close();

        }
    }
}

