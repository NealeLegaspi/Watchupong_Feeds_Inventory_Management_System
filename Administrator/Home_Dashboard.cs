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
    public partial class Home_Dashboard : Form
    {
        private Guna.UI2.WinForms.Guna2Button currentlySelectedButton;

        public Home_Dashboard()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home ucH = new UC_Home();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(ucH);

            UpdateButtonSelection(btnHome);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Account ucA = new UC_Account();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(ucA);

            UpdateButtonSelection(btnAccount);
        }

        private void btnActivityLogs_Click(object sender, EventArgs e)
        {
            UC_Audit ucAL = new UC_Audit();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(ucAL);

            UpdateButtonSelection(btnActivityLogs);
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            UC_OrderHistory ucOH = new UC_OrderHistory();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(ucOH);

            UpdateButtonSelection(btnOrderHistory);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            UC_InventoryStocks ucI = new UC_InventoryStocks();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(ucI);

            UpdateButtonSelection(btnInventory);
        }

        private void btnDeliveryLogs_Click(object sender, EventArgs e)
        {
            UC_DeliveryLogs ucDL = new UC_DeliveryLogs();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(ucDL);

            UpdateButtonSelection(btnDeliveryLogs);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Admin_Login admin_Login = new Admin_Login();
            admin_Login.Show();
            this.Hide();

            if (currentlySelectedButton != null)
            {
                currentlySelectedButton.FillColor = Color.Black;
            }
        }

        private void Home_Dashboard_Load(object sender, EventArgs e)
        {
            UC_Home ucH = new UC_Home();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(ucH);

            UpdateButtonSelection(btnHome);
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

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
