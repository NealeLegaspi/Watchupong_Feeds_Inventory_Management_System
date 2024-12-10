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
    public partial class GcashReceipt : Form
    {
        public string ReferenceNumber { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string Amount { get; set; }

        public GcashReceipt()
        {
            InitializeComponent();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            GcashReceipt2 receiptForm = new GcashReceipt2();
            lblRefNumber.Text = ReferenceNumber;
            receiptForm.ShowDialog();
            this.Hide();

        }

        private void GcashReceipt_Load(object sender, EventArgs e)
        {
            lblRefNumber.Text = ReferenceNumber;
            lblAccountNo.Text = AccountNumber;
            lblAccountName.Text = AccountName;
            lblAmount.Text = Amount;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
