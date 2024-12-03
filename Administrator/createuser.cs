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
            WatchupongConnections.Instance.Open();
            var query = WatchupongConnections.Instance.CreateCommand
                ("INSERT INTO User_Information values (@user,@nm,@email,@pass,@role,@gender,@status)");

            query.Parameters.AddWithValue("@user", txtuser.Text);
            query.Parameters.AddWithValue("@nm", $"{txtfirst.Text} {txtlast.Text}");
            query.Parameters.AddWithValue("@email", txtemail.Text);
            query.Parameters.AddWithValue("@pass", txtpass.Text);
            query.Parameters.AddWithValue("@role", cbrole.Text);
            query.Parameters.AddWithValue("@status", "Active");
            if (rbMale.Checked)
            {
                query.Parameters.AddWithValue("@gender", "Male");
            }
            else
            {
                query.Parameters.AddWithValue("@gender", "Female");
            }

            query.ExecuteNonQuery();

            adduser?.Invoke(this, e);

            UC_Account uC_Account = new UC_Account();
            uC_Account.Show();
            this.Hide();
        }
    }
}
