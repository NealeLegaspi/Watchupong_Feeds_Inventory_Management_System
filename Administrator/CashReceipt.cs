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
    
    public partial class CashReceipt : Form
    {
        string p;
        int Q;
        int pr;
        public CashReceipt()
        {
            InitializeComponent();
        }
        public void RecieptShow()
        {
            Reciept_txt.Text += "                              Watchupong Fish Feeds                         \n";
            Reciept_txt.Text += "---------------------------------------------------------\n";
            Reciept_txt.Text += "---------------------------------------------------------\n";
            Reciept_txt.Text += "                              Payment Successfull                                                                  \n";
            Reciept_txt.Text += "---------------------------------------------------------\n";
            Reciept_txt.Text += "---------------------------------------------------------\n";
            Reciept_txt.Text += "---------------------------------------------------------\n";
            Reciept_txt.Text += $"Cashier Name:  \n";
            Reciept_txt.Text += "";

            Reciept_txt.Text += $" ProductName                  Quantity                   Price\n";
           for (int i = 0; i < ProductListItems.Instace.getCount(); i++)
{
    WatchupongConnections.Instance.Open();
    var reader = WatchupongConnections.Instance.ExecuteReader($"SELECT product_name FROM ProductList WHERE product_id = {ProductListItems.Instace.getId(i)}");

    if (reader.Read())
    {
        string p = reader.GetString(0);
        int q = ProductListItems.Instace.getInt(ProductListItems.Instace.getId(i));
        int pr = ProductListItems.Instace.getInt(ProductListItems.Instace.getId(i));

        // Format the product information as a string
        string productLine = $"{p,20} {q,17} {pr,30}";

        Reciept_txt.Text += productLine + "\n";
    }

    reader.Close();
    WatchupongConnections.Instance.Close();
}

        }

        private void CashReceipt_Load(object sender, EventArgs e)
        {
            RecieptShow();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Reciept_txt.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Cashier_Process.Instance.ClearItems();
            Cashier_Process.Instance.ProductShow();
            ProductListItems.Instace.clearItems();
            ProductListItems.Instace.clearquan();
            ProductListItems.Instace.ClearPrice();
            this.Close();
        }
    }
}