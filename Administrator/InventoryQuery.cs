using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator
{
    internal class InventoryQuery
    {
        private SqlConnection sqlConnect;
        private SqlDataAdapter sqlAdapter;
        private SqlCommand sqlCommand;
        private SqlDataReader sqlReader;

        public DataTable dataTable;
        public BindingSource bindingSource;
        string connectionString;

        public InventoryQuery()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\legas\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security=True";
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public void DisplayList()
        {
            string ViewClubMembers = "SELECT * FROM Stocks";
            sqlAdapter = new SqlDataAdapter(ViewClubMembers, connectionString);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
        }
    }
}
