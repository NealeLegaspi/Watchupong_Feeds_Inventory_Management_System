namespace Administrator
{
    partial class UC_Product
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pbProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            lblProductName = new Label();
            lblPrice = new Label();
            lblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // pbProductImage
            // 
            pbProductImage.BorderRadius = 5;
            pbProductImage.CustomizableEdges = customizableEdges3;
            pbProductImage.ImageRotate = 0F;
            pbProductImage.Location = new Point(15, 10);
            pbProductImage.Margin = new Padding(3, 2, 3, 2);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pbProductImage.Size = new Size(213, 148);
            pbProductImage.TabIndex = 0;
            pbProductImage.TabStop = false;
            pbProductImage.Click += pbProductImage_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(101, 171);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(38, 15);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "label1";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(101, 214);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "label2";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(101, 268);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(38, 15);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "label3";
            // 
            // UC_Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblProductName);
            Controls.Add(pbProductImage);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Product";
            Size = new Size(246, 301);
            Load += UC_Product_Load;
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbProductImage;
        private Label lblProductName;
        private Label lblPrice;
        private Label lblDescription;
    }
}
