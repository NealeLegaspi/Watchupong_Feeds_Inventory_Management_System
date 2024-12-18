﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator
{
    internal class AccountQuery
    {

        private SqlConnection sqlConnect;
        private SqlDataAdapter sqlAdapter;
        private SqlCommand sqlCommand;
        private SqlDataReader sqlReader;

        public DataTable dataTable;
        public BindingSource bindingSource;
        string connectionString;

        public AccountQuery()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security=True"; // Replace with your database connection string
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public void DisplayList()
        {
            string ViewClubMembers = "SELECT * FROM Account";
            sqlAdapter = new SqlDataAdapter(ViewClubMembers, connectionString);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
        }
    }
}
