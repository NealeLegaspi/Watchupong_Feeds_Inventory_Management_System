using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Administrator
{
    public partial class UC_Account : UserControl
    {
        public UC_Account()
        {
            InitializeComponent();
        }
        static AccountQuery accQuery = new AccountQuery();

        private void LoadAccounts()
        {
            var adapter = WatchupongConnections.Instance.ExecuteAdapter
                ("SELECT * FROM Account WHERE archived = 0");
            DataTable table = new DataTable();
            adapter.Fill(table);
            dtgAccount.DataSource = table;

        }



        private void btnAddUser_Click(object sender, EventArgs e)
        {

            createuser AddUser = new createuser();
            AddUser.ShowDialog();

        }



        private void UC_Account_Load(object sender, EventArgs e)
        {

            LoadAccounts();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgAccount.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the value of the "user_id" column from the selected row
                    int selectedAccountId = Convert.ToInt32(dtgAccount.SelectedRows[0].Cells["user_id"].Value);

                    // Confirm deletion
                    DialogResult confirmDelete = MessageBox.Show(
                        "Are you sure you want to delete this account?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmDelete == DialogResult.Yes)
                    {
                        // Perform the deletion in the database
                        WatchupongConnections.Instance.Open();
                        var query = "UPDATE Account SET archived = 1 WHERE user_id = @user_id";
                        var command = WatchupongConnections.Instance.CreateCommand(query);
                        command.Parameters.AddWithValue("@user_id", selectedAccountId);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dtgAccount.Rows.RemoveAt(dtgAccount.SelectedRows[0].Index);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    WatchupongConnections.Instance.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an account to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {

            frmUpdateUser editForm = new frmUpdateUser();
            editForm.ShowDialog();
            LoadAccounts();

        }

        private void dtgAccount_CellContentChange(object sender, DataGridViewCellEventArgs e)
        {
            
                    
                
            
        }
    }
}
