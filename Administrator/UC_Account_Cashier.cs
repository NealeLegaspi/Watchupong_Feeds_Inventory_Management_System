﻿using System;
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
    public partial class UC_Account_Cashier : UserControl
    {
        public UC_Account_Cashier()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ViewProfile viewProfile = new ViewProfile();  
            viewProfile.ShowDialog();

        }
    }
}
