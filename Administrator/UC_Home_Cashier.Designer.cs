namespace Administrator
{
    partial class UC_Home_Cashier
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
            dtgOrderHistroyCashierDB = new DataGridView();
            dtgTopProductsCashierDB = new DataGridView();
            dtgLowStocksCashierDB = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgOrderHistroyCashierDB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgTopProductsCashierDB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgLowStocksCashierDB).BeginInit();
            SuspendLayout();
            // 
            // dtgOrderHistroyCashierDB
            // 
            dtgOrderHistroyCashierDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgOrderHistroyCashierDB.Location = new Point(46, 344);
            dtgOrderHistroyCashierDB.Margin = new Padding(3, 2, 3, 2);
            dtgOrderHistroyCashierDB.Name = "dtgOrderHistroyCashierDB";
            dtgOrderHistroyCashierDB.RowHeadersWidth = 51;
            dtgOrderHistroyCashierDB.Size = new Size(579, 236);
            dtgOrderHistroyCashierDB.TabIndex = 0;
            dtgOrderHistroyCashierDB.CellContentClick += dtgHome_CellContentClick;
            // 
            // dtgTopProductsCashierDB
            // 
            dtgTopProductsCashierDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTopProductsCashierDB.Location = new Point(674, 344);
            dtgTopProductsCashierDB.Margin = new Padding(3, 2, 3, 2);
            dtgTopProductsCashierDB.Name = "dtgTopProductsCashierDB";
            dtgTopProductsCashierDB.RowHeadersWidth = 51;
            dtgTopProductsCashierDB.Size = new Size(447, 236);
            dtgTopProductsCashierDB.TabIndex = 1;
            // 
            // dtgLowStocksCashierDB
            // 
            dtgLowStocksCashierDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLowStocksCashierDB.Location = new Point(545, 69);
            dtgLowStocksCashierDB.Margin = new Padding(3, 2, 3, 2);
            dtgLowStocksCashierDB.Name = "dtgLowStocksCashierDB";
            dtgLowStocksCashierDB.RowHeadersWidth = 51;
            dtgLowStocksCashierDB.Size = new Size(594, 222);
            dtgLowStocksCashierDB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 23);
            label1.Name = "label1";
            label1.Size = new Size(170, 30);
            label1.TabIndex = 3;
            label1.Text = "CASHIER HOME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 308);
            label2.Name = "label2";
            label2.Size = new Size(178, 30);
            label2.TabIndex = 4;
            label2.Text = "ORDER HISTORY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(545, 23);
            label3.Name = "label3";
            label3.Size = new Size(144, 30);
            label3.TabIndex = 5;
            label3.Text = "LOW STOCKS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(674, 311);
            label4.Name = "label4";
            label4.Size = new Size(169, 30);
            label4.TabIndex = 6;
            label4.Text = "TOP PRODUCTS";
            // 
            // UC_Home_Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgLowStocksCashierDB);
            Controls.Add(dtgTopProductsCashierDB);
            Controls.Add(dtgOrderHistroyCashierDB);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Home_Cashier";
            Size = new Size(1160, 598);
            Load += UC_Home_Cashier_Load;
            ((System.ComponentModel.ISupportInitialize)dtgOrderHistroyCashierDB).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgTopProductsCashierDB).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgLowStocksCashierDB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgOrderHistroyCashierDB;
        private DataGridView dtgTopProductsCashierDB;
        private DataGridView dtgLowStocksCashierDB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
