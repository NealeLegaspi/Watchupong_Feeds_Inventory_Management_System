using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class UC_Account : UserControl
    {
        public UC_Account()
        {
            InitializeComponent();
        }

        private void dtgAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            createuser frmcreateuser = new createuser();
            frmcreateuser.ShowDialog();
            this.Hide();
        }

        private void Archived_Click(object sender, EventArgs e)
        {

        }

        private void UC_Account_Load(object sender, EventArgs e)
        {
            WatchupongConnections.Instance.Open();
            var reader = WatchupongConnections.Instance.ExecuteReader
                ("SELECT Name,Username, Email, Password, Role, Gender FROM User_Information ");
            while(reader.Read())
            {
               dtgAccount.Rows.Add(reader.GetValue(0),reader.GetValue(1),reader.GetValue(2),reader.GetValue(3),reader.GetValue(4),reader.GetValue(5),"Active","Edit");
            }
            reader.Close();
            WatchupongConnections.Instance.Close();

        }
    }
}
