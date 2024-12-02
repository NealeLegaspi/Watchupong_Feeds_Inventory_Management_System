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
            label1 = new Label();
            label2 = new Label();
            PanelListOfProduct = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 21);
            label1.Name = "label1";
            label1.Size = new Size(137, 31);
            label1.TabIndex = 5;
            label1.Text = "Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14F, FontStyle.Bold);
            label2.Location = new Point(1059, 29);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 6;
            label2.Text = "Cashier";
            // 
            // PanelListOfProduct
            // 
            PanelListOfProduct.BackColor = SystemColors.ActiveBorder;
            PanelListOfProduct.Location = new Point(739, 57);
            PanelListOfProduct.Margin = new Padding(3, 2, 3, 2);
            PanelListOfProduct.Name = "PanelListOfProduct";
            PanelListOfProduct.Size = new Size(423, 631);
            PanelListOfProduct.TabIndex = 1;
            // 
            // UC_Product_Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PanelListOfProduct);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Product_Cashier";
            Size = new Size(1162, 688);
            Load += UC_Product_Cashier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private FlowLayoutPanel PanelListOfProduct;
    }
}
