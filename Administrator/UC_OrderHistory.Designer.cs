namespace Administrator
{
    partial class UC_OrderHistory
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgOrderHistory = new DataGridView();
            Customer_ID = new DataGridViewTextBoxColumn();
            Product_ID = new DataGridViewTextBoxColumn();
            Payment = new DataGridViewTextBoxColumn();
            Date_Time = new DataGridViewTextBoxColumn();
            Order_Status = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dtgOrderHistory).BeginInit();
            SuspendLayout();
            // 
            // dtgOrderHistory
            // 
            dtgOrderHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgOrderHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgOrderHistory.Columns.AddRange(new DataGridViewColumn[] { Customer_ID, Product_ID, Payment, Date_Time, Order_Status, Total });
            dtgOrderHistory.Location = new Point(37, 190);
            dtgOrderHistory.Name = "dtgOrderHistory";
            dtgOrderHistory.RowHeadersWidth = 51;
            dtgOrderHistory.Size = new Size(1507, 720);
            dtgOrderHistory.TabIndex = 0;
            // 
            // Customer_ID
            // 
            Customer_ID.HeaderText = "Customer_ID";
            Customer_ID.MinimumWidth = 6;
            Customer_ID.Name = "Customer_ID";
            // 
            // Product_ID
            // 
            Product_ID.HeaderText = "Product_ID";
            Product_ID.MinimumWidth = 6;
            Product_ID.Name = "Product_ID";
            // 
            // Payment
            // 
            Payment.HeaderText = "Payment";
            Payment.MinimumWidth = 6;
            Payment.Name = "Payment";
            // 
            // Date_Time
            // 
            Date_Time.HeaderText = "Date & Time";
            Date_Time.MinimumWidth = 6;
            Date_Time.Name = "Date_Time";
            // 
            // Order_Status
            // 
            Order_Status.HeaderText = "Order_Status";
            Order_Status.MinimumWidth = 6;
            Order_Status.Name = "Order_Status";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(37, 141);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(188, 43);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Order History";
            // 
            // UC_OrderHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dtgOrderHistory);
            ForeColor = SystemColors.ControlText;
            Name = "UC_OrderHistory";
            RightToLeft = RightToLeft.No;
            Size = new Size(1581, 953);
            ((System.ComponentModel.ISupportInitialize)dtgOrderHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgOrderHistory;
        private DataGridViewTextBoxColumn Customer_ID;
        private DataGridViewTextBoxColumn Product_ID;
        private DataGridViewTextBoxColumn Payment;
        private DataGridViewTextBoxColumn Date_Time;
        private DataGridViewTextBoxColumn Order_Status;
        private DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
