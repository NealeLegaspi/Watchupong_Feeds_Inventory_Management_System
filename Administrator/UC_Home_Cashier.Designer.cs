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
            dtgHome = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgHome).BeginInit();
            SuspendLayout();
            // 
            // dtgHome
            // 
            dtgHome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHome.Location = new Point(49, 209);
            dtgHome.Name = "dtgHome";
            dtgHome.RowHeadersWidth = 51;
            dtgHome.Size = new Size(1507, 720);
            dtgHome.TabIndex = 0;
            // 
            // UC_Home_Cashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgHome);
            Name = "UC_Home_Cashier";
            Size = new Size(1581, 953);
            ((System.ComponentModel.ISupportInitialize)dtgHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgHome;
    }
}
