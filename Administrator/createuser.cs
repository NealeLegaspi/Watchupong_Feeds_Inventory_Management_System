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
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security=True");
            WatchupongConnections.Instance.Open();
           SqlCommand sqlconn = new SqlCommand("INSERT INTO CashierAccount(Name, Username, Password, Email, Gender, Status ) values (@nm,@user,@pass,@email,@gender,@status)",conn);

            
            sqlconn.Parameters.AddWithValue("@user", txtuser.Text);
            sqlconn.Parameters.AddWithValue("@nm", $"{txtfirst.Text} {txtlast.Text}");
            sqlconn.Parameters.AddWithValue("@email", txtemail.Text);
            sqlconn.Parameters.AddWithValue("@pass", txtpass.Text);
            sqlconn.Parameters.AddWithValue("@status", "Active");
            if (rbMale.Checked)
            {
                sqlconn.Parameters.AddWithValue("@gender", "Male");
            }
            else
            {
                sqlconn.Parameters.AddWithValue("@gender", "Female");
            }

            conn.Open();
            sqlconn.ExecuteNonQuery();
            conn.Close();

            adduser?.Invoke(this, e);

            UC_Account uC_Account = new UC_Account();
            uC_Account.Show();
            this.Hide();
        }
    }
}
