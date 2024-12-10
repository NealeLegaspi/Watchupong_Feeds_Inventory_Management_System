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
            CheckUser();
            if (checking == true)
            {
                if (role.Equals("Admin"))
                {
                    Home_Dashboard home_Dashboard = new Home_Dashboard();
                    home_Dashboard.Show();
                    this.Hide();
                }
                else
                {
                    UC_Home_Cashier uC = new UC_Home_Cashier();
                    uC.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorect password or username");
            }
        }
        string role;
        bool checking;
        public void CheckUser()
        {
            checking = false;
            WatchupongConnections.Instance.Open();
            var reader = WatchupongConnections.Instance.ExecuteReader
                ("SELECT username, password, user_id, role FROM Account WHERE archived = 0");
            while (reader.Read())
            {
                if (txtPassword.Text.Equals(reader.GetString(1)) && txtUsername.Text.Equals(reader.GetString(0)))
                {

                    role = reader.GetString(3);
                    AuditQuery.Instance.getId = reader.GetInt32(2);
                    checking = true;
                    break;
                }
            }
            reader.Close();
            WatchupongConnections.Instance.Close();
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
