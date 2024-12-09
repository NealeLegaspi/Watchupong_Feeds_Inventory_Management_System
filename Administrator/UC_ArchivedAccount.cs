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
    public partial class UC_ArchivedAccount : UserControl
    {
        public UC_ArchivedAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void ProductArchive()
        {
            WatchupongConnections.Instance.Open();

            var reader = WatchupongConnections.Instance.ExecuteReader
                ("SELECT product_id, product_name, description FROM ProductList WHERE status = 1");
            while (reader.Read()) 
            {
            }
            WatchupongConnections.Instance.Close();
        }
        public void AccountArchive()
        {
            WatchupongConnections.Instance.Open();
            var reader = WatchupongConnections.Instance.ExecuteReader
                ("SELECT user_id, name, role FROM Account WHERE archived = 1");
            while (reader.Read()) 
            {
            }
            reader.Close();
            WatchupongConnections.Instance.Close();
        }

    }
}
