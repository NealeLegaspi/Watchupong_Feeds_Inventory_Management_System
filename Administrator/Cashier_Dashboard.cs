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
    public partial class Cashier_Dashboard : Form
    {
        private Guna.UI2.WinForms.Guna2Button currentlySelectedButton;
        public Cashier_Dashboard()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MainPanelCashier3.Controls.Clear();
            MainPanelCashier3.Controls.Add(userControl);
            userControl.BringToFront();


        }

        private void Cashier_Dashboard_Load(object sender, EventArgs e)
        {
            UC_Home_Cashier ucHC = new UC_Home_Cashier();
            MainPanelCashier3.Controls.Clear();
            MainPanelCashier3.Controls.Add(ucHC);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeCashier_Click(object sender, EventArgs e)
        {
            UC_Home_Cashier ucH = new UC_Home_Cashier();
            addUserControl((ucH));
        }

        private void btnAccountCashier_Click(object sender, EventArgs e)
        {
            UC_Account_Cashier ucAC = new UC_Account_Cashier();
            addUserControl((ucAC));
        }

        private void btnHistoryCashier_Click(object sender, EventArgs e)
        {
            UC_OrderHistory ucOH = new UC_OrderHistory();
            addUserControl((ucOH));
        }
        private void UpdateButtonSelection(Guna.UI2.WinForms.Guna2Button clickedButton)
        {

            if (currentlySelectedButton != null)
            {
                currentlySelectedButton.FillColor = Color.Black;
            }
            clickedButton.FillColor = Color.DarkGray;
            currentlySelectedButton = clickedButton;
        }

        private void btnLogoutCashier_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            Admin_Login AL = new Admin_Login();
            AL.ShowDialog(); // Show Admin_Login as a modal dialog
            this.Show(); // Optionally, show the current form again if needed
        }

        private void btnProductCashier_Click_1(object sender, EventArgs e)
        {
            UC_Product_Cashier ucPC = new UC_Product_Cashier(); 
            MainPanelCashier3.Controls.Clear();
            MainPanelCashier3.Controls.Add(ucPC);

        }
    }

}
