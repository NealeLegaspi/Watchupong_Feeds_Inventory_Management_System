namespace Administrator
{
    partial class UC_DeliveryLogs
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
            dtgDeliveryLogs = new DataGridView();
            Product_ID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Grams = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Mfg_Date = new DataGridViewTextBoxColumn();
            Exp_Date = new DataGridViewTextBoxColumn();
            Delivery_Date = new DataGridViewTextBoxColumn();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dtgDeliveryLogs).BeginInit();
            SuspendLayout();
            // 
            // dtgDeliveryLogs
            // 
            dtgDeliveryLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDeliveryLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDeliveryLogs.Columns.AddRange(new DataGridViewColumn[] { Product_ID, ProductName, Grams, Price, Mfg_Date, Exp_Date, Delivery_Date });
            dtgDeliveryLogs.Location = new Point(22, 201);
            dtgDeliveryLogs.Name = "dtgDeliveryLogs";
            dtgDeliveryLogs.RowHeadersWidth = 51;
            dtgDeliveryLogs.Size = new Size(1507, 720);
            dtgDeliveryLogs.TabIndex = 0;
            // 
            // Product_ID
            // 
            Product_ID.HeaderText = "Product_ID";
            Product_ID.MinimumWidth = 6;
            Product_ID.Name = "Product_ID";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product_Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            // 
            // Grams
            // 
            Grams.HeaderText = "Grams";
            Grams.MinimumWidth = 6;
            Grams.Name = "Grams";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Mfg_Date
            // 
            Mfg_Date.HeaderText = "Mfg_Date";
            Mfg_Date.MinimumWidth = 6;
            Mfg_Date.Name = "Mfg_Date";
            // 
            // Exp_Date
            // 
            Exp_Date.HeaderText = "Exp_Date";
            Exp_Date.MinimumWidth = 6;
            Exp_Date.Name = "Exp_Date";
            // 
            // Delivery_Date
            // 
            Delivery_Date.HeaderText = "Delivery_Date";
            Delivery_Date.MinimumWidth = 6;
            Delivery_Date.Name = "Delivery_Date";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(22, 152);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(186, 43);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Delivery Logs";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // UC_DeliveryLogs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dtgDeliveryLogs);
            Name = "UC_DeliveryLogs";
            Size = new Size(1581, 953);
            ((System.ComponentModel.ISupportInitialize)dtgDeliveryLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDeliveryLogs;
        private DataGridViewTextBoxColumn Product_ID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Grams;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Mfg_Date;
        private DataGridViewTextBoxColumn Exp_Date;
        private DataGridViewTextBoxColumn Delivery_Date;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
