namespace Administrator
{
    partial class UC_Product_Cashier
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
            ProductPanel = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // ProductPanel
            // 
            ProductPanel.Location = new Point(3, 3);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.Size = new Size(1017, 950);
            ProductPanel.TabIndex = 0;
            ProductPanel.Paint += ProductPanel_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(1026, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(552, 947);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // UC_Product_Cashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ProductPanel);
            Name = "UC_Product_Cashier";
            Size = new Size(1581, 953);
            Load += UC_Product_Cashier_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ProductPanel;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
