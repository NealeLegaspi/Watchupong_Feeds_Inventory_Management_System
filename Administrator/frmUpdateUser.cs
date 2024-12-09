using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;

namespace Administrator
{
    public partial class frmUpdateUser : Form
    {
        private int userId;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\legas\source\repos\Watchupong_Feeds_Inventory_Management_System\Administrator\WatchupongFeedsDB.mdf;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        public frmUpdateUser()
        {
            InitializeComponent();
            LoadAccountDetails();
        }

        private void LoadAccountDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT @name, @username, @password,@role FROM Account WHERE userid = @user_id", conn);
                cmd.Parameters.AddWithValue("@user_id", userId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader["name"].ToString();
                    txtUsername.Text = reader["username"].ToString();
                    txtNewPassword.Text = reader["password"].ToString();
                    cmbRole.Text = reader["role"].ToString();
                }
            }
        }

    
        private void rbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShowPassword.Checked)
            {
                txtReEnterPassword.UseSystemPasswordChar = !rbShowPassword.Checked; // Show password
            }
            else
            {
                txtReEnterPassword.UseSystemPasswordChar = !rbShowPassword.Checked; // Hide password
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure the `user_id` is available (pass it from the parent form or DataGridView)
            if (userId <= 0)
            {
                MessageBox.Show("Invalid user selection. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connection string to the database
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\legas\source\repos\Watchupong_Feeds_Inventory_Management_System\Administrator\WatchupongFeedsDB.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to update account information based on `user_id`
                    string query = @"
                UPDATE Account 
                SET 
                    name = @name, 
                    username = @username, 
                    password = @password, 
                    role = @role 
                WHERE user_id = @user_id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Bind parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtNewPassword.Text);
                        cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                        cmd.Parameters.AddWithValue("@user_id", userId); // Ensure `selectedUserId` is passed correctly

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the edit form after success
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the account. Please check if the account exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display any errors that occur
                MessageBox.Show($"Error updating account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
