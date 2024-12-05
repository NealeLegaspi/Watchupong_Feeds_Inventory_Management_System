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

namespace Administrator
{
    public partial class UC_Account : UserControl
    {
        public UC_Account()
        {
            InitializeComponent();
        }
        static AccountQuery accQuery = new AccountQuery();


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

            RefreshAccount();
        }

        public void RefreshAccount()
        {
            accQuery.DisplayList();
            dataGridView1.DataSource = accQuery.bindingSource;
        }

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
