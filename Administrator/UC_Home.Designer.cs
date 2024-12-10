namespace Administrator
{
    partial class UC_Home
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
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtgLowStocks = new DataGridView();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtgTopProduct = new DataGridView();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dtgOrderHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgLowStocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgTopProduct).BeginInit();
            SuspendLayout();
            // 
            // dtgOrderHistory
            // 
            dtgOrderHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgOrderHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgOrderHistory.Location = new Point(59, 365);
            dtgOrderHistory.Margin = new Padding(3, 2, 3, 2);
            dtgOrderHistory.Name = "dtgOrderHistory";
            dtgOrderHistory.RowHeadersWidth = 51;
            dtgOrderHistory.Size = new Size(1029, 208);
            dtgOrderHistory.TabIndex = 0;
            dtgOrderHistory.CellContentClick += dataGridView1_CellContentClick;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(59, 328);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(151, 34);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Order History";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // dtgLowStocks
            // 
            dtgLowStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgLowStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLowStocks.Location = new Point(650, 103);
            dtgLowStocks.Margin = new Padding(3, 2, 3, 2);
            dtgLowStocks.Name = "dtgLowStocks";
            dtgLowStocks.RowHeadersWidth = 51;
            dtgLowStocks.Size = new Size(438, 245);
            dtgLowStocks.TabIndex = 2;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(59, 63);
            guna2HtmlLabel2.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(136, 34);
            guna2HtmlLabel2.TabIndex = 3;
            guna2HtmlLabel2.Text = "Top Product";
            guna2HtmlLabel2.Click += guna2HtmlLabel2_Click;
            // 
            // dtgTopProduct
            // 
            dtgTopProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTopProduct.Location = new Point(59, 104);
            dtgTopProduct.Margin = new Padding(3, 2, 3, 2);
            dtgTopProduct.Name = "dtgTopProduct";
            dtgTopProduct.RowHeadersWidth = 51;
            dtgTopProduct.Size = new Size(539, 208);
            dtgTopProduct.TabIndex = 4;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.Location = new Point(742, 65);
            guna2HtmlLabel3.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(114, 34);
            guna2HtmlLabel3.TabIndex = 5;
            guna2HtmlLabel3.Text = "Low Stock";
            guna2HtmlLabel3.Click += guna2HtmlLabel3_Click;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Verdana", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.Location = new Point(14, 26);
            guna2HtmlLabel4.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(84, 33);
            guna2HtmlLabel4.TabIndex = 6;
            guna2HtmlLabel4.Text = "Home";
            guna2HtmlLabel4.Click += guna2HtmlLabel4_Click;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(dtgTopProduct);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(dtgLowStocks);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dtgOrderHistory);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Home";
            Size = new Size(1160, 598);
            Load += UC_Home_Load;
            ((System.ComponentModel.ISupportInitialize)dtgOrderHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgLowStocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgTopProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgOrderHistory;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DataGridView dtgLowStocks;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private DataGridView dtgTopProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}
