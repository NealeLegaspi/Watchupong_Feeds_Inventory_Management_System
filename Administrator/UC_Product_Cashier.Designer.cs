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
            PanelProduct = new FlowLayoutPanel();
            PanelListOfProduct = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // PanelProduct
            // 
            PanelProduct.Location = new Point(3, 2);
            PanelProduct.Margin = new Padding(3, 2, 3, 2);
            PanelProduct.Name = "PanelProduct";
            PanelProduct.Size = new Size(782, 684);
            PanelProduct.TabIndex = 0;
            PanelProduct.Paint += ProductPanel_Paint;
            // 
            // PanelListOfProduct
            // 
            PanelListOfProduct.Location = new Point(791, 2);
            PanelListOfProduct.Margin = new Padding(3, 2, 3, 2);
            PanelListOfProduct.Name = "PanelListOfProduct";
            PanelListOfProduct.Size = new Size(368, 684);
            PanelListOfProduct.TabIndex = 1;
            // 
            // UC_Product_Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelListOfProduct);
            Controls.Add(PanelProduct);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Product_Cashier";
            Size = new Size(1162, 688);
            Load += UC_Product_Cashier_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel PanelProduct;
        private FlowLayoutPanel PanelListOfProduct;
    }
}
