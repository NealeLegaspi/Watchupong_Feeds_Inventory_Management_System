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

namespace Administrator
{
    public partial class frmUpdateUser : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\legas\source\repos\Watchupong_Feeds_Inventory_Management_System\Administrator\WatchupongFeedsDB.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public frmUpdateUser()
        {
            InitializeComponent();
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
