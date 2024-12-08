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
            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role from the Role.", "Role Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            else if (cmbRole.SelectedItem.ToString() == "Admin")
            {
                loginQuery login = new loginQuery();
                login.LoginValidationAdmin(guna2TextBox2.Text, guna2TextBox1.Text);
            }
            else if (cmbRole.SelectedItem.ToString() == "Cashier")
            {
                loginQuery login = new loginQuery();
                login.LoginValidationCashier(guna2TextBox2.Text, guna2TextBox1.Text);
            }
            this.Hide();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
