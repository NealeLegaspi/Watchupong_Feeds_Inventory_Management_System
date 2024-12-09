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
using TheArtOfDevHtmlRenderer.Adapters;

namespace Administrator
{
    public partial class createuser : Form
    {
        public createuser()
        {
            InitializeComponent();
        }
        public static EventHandler adduser;
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var query = WatchupongConnections.Instance.CreateCommand
                ("INSERT INTO Account(name, username, password, role, archived) values (@name,@username,@password,@role, 0)");

            query.Parameters.AddWithValue("@name", txtName.Text);
            query.Parameters.AddWithValue("@username", txtUsername.Text);
            query.Parameters.AddWithValue("@password", txtPassword.Text);
            query.Parameters.AddWithValue("@role", cmbRole.Text);
            cmbRole.Items.Add("Cashier");
            cmbRole.Items.Add("Admin");
            WatchupongConnections.Instance.Open();
            query.ExecuteNonQuery();
            WatchupongConnections.Instance.Close();

            adduser?.Invoke(this, e);
            this.Hide();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rbShowPassword1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShowPassword1.Checked)
            {
                txtPassword.UseSystemPasswordChar = !rbShowPassword1.Checked; // Show password
            }
            else
            {
                txtPassword.UseSystemPasswordChar = !rbShowPassword1.Checked; // Hide password
            }
        }

        private void rbShowPassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShowPassword2.Checked)
            {
                txtReEnterPassword.UseSystemPasswordChar = !rbShowPassword2.Checked; // Show password
            }
            else
            {
                txtReEnterPassword.UseSystemPasswordChar = !rbShowPassword2.Checked; // Hide password
            }
        }
    }
}
