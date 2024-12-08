using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator
{
    internal class loginQuery
    {
        private SqlConnection sqlConnect;
        private SqlDataAdapter sqlAdapter;
        private SqlCommand sqlCommand;
        private SqlDataReader sqlReader;

        public DataTable dataTable;
        public BindingSource bindingSource;
        string connectionString;

        public loginQuery()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\legas\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security=True";
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        
            public bool LoginValidationAdmin(string user, string password)
            {
                connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\legas\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security=True";
                
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                {
                        sqlConnect.Open();

                        using (SqlCommand sqlCommand = new SqlCommand("SELECT Username, Password FROM Account WHERE Username = @user AND Password = @password", sqlConnect))
                        {
                            sqlCommand.Parameters.AddWithValue("@user", user);
                            sqlCommand.Parameters.AddWithValue("@password", password);

                            using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                            {
                                if (sqlReader.HasRows)
                                {
                                    while (sqlReader.Read())
                                    {
                                        Home_Dashboard HD = new Home_Dashboard();
                                        HD.Show();
                                        return true;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Username or password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    return false;
                                }
                            }
                        }
                    }
                
                return false;
            }

        public bool LoginValidationCashier(string user, string password)
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\legas\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security=True";

            using (SqlConnection sqlConnect = new SqlConnection(connectionString))
            {
                sqlConnect.Open();

                using (SqlCommand sqlCommand = new SqlCommand("SELECT Username, Password FROM Cashier_Account  WHERE Username = @user AND Password = @password", sqlConnect))
                {
                    sqlCommand.Parameters.AddWithValue("@user", user);
                    sqlCommand.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                Cashier_Dashboard CD = new Cashier_Dashboard();
                                CD.Show();
                                return true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username or password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return false;
                        }
                    }
                }
            }

            return false;
        }

    }
    }
