using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Administrator
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security=True"; // Replace with your database connection string
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();



            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to fetch the user's role
                    string query = "SELECT role FROM Account WHERE username = @username AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    string role = (string)cmd.ExecuteScalar();

                    if (!string.IsNullOrEmpty(role))
                    {
                        MessageBox.Show($"Welcome, {role}!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redirect to the appropriate dashboard
                        if (role == "Admin")
                        {
                            Home_Dashboard adminDashboard = new Home_Dashboard();
                            adminDashboard.Show();
                        }
                        else if (role == "Cashier")
                        {
                            Cashier_Dashboard cashierDashboard = new Cashier_Dashboard();
                            cashierDashboard.Show();
                        }

                        // Close the login form
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = !rbShowPassword.Checked; // Show password
            }
            else
            {
                txtPassword.UseSystemPasswordChar = !rbShowPassword.Checked; // Hide password
            }

        }
       
    }
}
