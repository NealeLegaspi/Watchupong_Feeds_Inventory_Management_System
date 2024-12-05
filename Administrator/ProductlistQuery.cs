using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator
{
    internal class ProductlistQuery
    {
        private SqlConnection sqlConnect;
        private SqlDataAdapter sqlAdapter;
        private SqlCommand sqlCommand;
        private SqlDataReader sqlReader;

        public DataTable dataTable;
        public BindingSource bindingSource;
        string connectionString;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public ProductlistQuery()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            sqlAdapter = new SqlDataAdapter();
            sqlCommand = new SqlCommand();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\legas\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security=True";
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public void DisplayListStocks()
        {
            string ViewClubMembers = "SELECT * FROM Stocks";
            sqlAdapter = new SqlDataAdapter(ViewClubMembers, connectionString);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
        }

        public void DisplayProductList()
        {
            string ViewClubMembers = "SELECT * FROM ProductList";
            sqlAdapter = new SqlDataAdapter(ViewClubMembers, connectionString);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
        }
    }
}
