using Microsoft.Data.SqlClient;
using System;

using Microsoft.Data.SqlClient;
using System;

namespace Administrator
{
    internal class WatchupongConnections
    {
        private static WatchupongConnections _instance;
        private static readonly object _lock = new object();

        private SqlConnection _sqlcon;
        private SqlCommand _sqlcom;

        public readonly string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\legas\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security=True";

        private WatchupongConnections()
        {
            _sqlcon = new SqlConnection(_connectionString);
        }

        public static WatchupongConnections Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new WatchupongConnections();
                    }
                    return _instance;
                }
            }
        }

        public string ConnectionString
        {
            get { return _connectionString; }
        }

        // Method to open the SQL connection
        public void Open()
        {
            if (_sqlcon.State == System.Data.ConnectionState.Closed)
            {
                _sqlcon.Open();
            }
        }

        public void Close()
        {
            if (_sqlcon.State == System.Data.ConnectionState.Open)
            {
                _sqlcon.Close();
            }
        }
        public SqlCommand CreateCommand(string query)
        {
            Open();
            _sqlcom = new SqlCommand(query, _sqlcon);
            return _sqlcom;
        }

        public SqlDataReader ExecuteReader(string query)
        {
            Open(); 
            _sqlcom = new SqlCommand(query, _sqlcon);

     
            
                return _sqlcom.ExecuteReader();
            

        }

        public int ExecuteNonQuery(string query)
        {
            Open();
            _sqlcom = new SqlCommand(query, _sqlcon);

            try
            {
                return _sqlcom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error executing non-query: {ex.Message}", ex);
            }
        }
    }
}

