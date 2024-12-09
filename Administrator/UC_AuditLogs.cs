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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Administrator
{
    public partial class UC_Audit : UserControl
    {
        public UC_Audit()
        {
            InitializeComponent();
            LoadAuditLogs();
        }

        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security = True";

        private void LoadAuditLogs(string searchQuery = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Basic query
                    string query = "SELECT actions, created_at FROM Audit";

                    // Add search filter if necessary
                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        query += " WHERE @user_id LIKE @search OR actions LIKE @search";
                    }

                    query += " ORDER BY created_at DESC"; // Sort by latest

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchQuery))
                        {
                            cmd.Parameters.AddWithValue("@search", $"%{searchQuery}%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dtgAudit.DataSource = dt; // Bind data to DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading audit logs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void UC_Audit_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();
            LoadAuditLogs(searchQuery);
        }

        private void dtgAudit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int id;
        public int getId
        {
            get { return id; }
            set { id = value; }
        }
    }
}

