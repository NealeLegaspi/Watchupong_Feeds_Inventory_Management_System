﻿using Microsoft.Data.SqlClient;
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
    public partial class UC_OrderHistory : UserControl
    {
        
        public UC_OrderHistory()
        {
            InitializeComponent();
            
        }
        static OrderHistoryQuery orderhistory = new OrderHistoryQuery();

        private void dtgOrderHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void UC_OrderHistory_Load(object sender, EventArgs e)
        {
            RefreshOrderHistory();
        }

        public void RefreshOrderHistory()
        {
            orderhistory.DisplayList();
            dtgOrderHistory.DataSource = orderhistory.bindingSource;
        }
    }
}
