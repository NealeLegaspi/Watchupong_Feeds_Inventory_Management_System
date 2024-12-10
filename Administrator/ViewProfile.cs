using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Administrator
{
    public partial class ViewProfile : Form
    {
          SqlConnection conn;
          
        public ViewProfile()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\source\\repos\\Watchupong_Feeds_Inventory_Management_System\\Administrator\\WatchupongFeedsDB.mdf;Integrated Security = True");
            
        }
       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Account_Cashier uC_Account_Cashier = new UC_Account_Cashier();
            uC_Account_Cashier.Show();
            this.Close();
        }
    }
}
