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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pbProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            btn50g = new Guna.UI2.WinForms.Guna2Button();
            btn100g = new Guna.UI2.WinForms.Guna2Button();
            lblProductName = new Label();
            lblPrice50g = new Label();
            lblPrice100g = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // pbProductImage
            // 
            pbProductImage.BorderRadius = 5;
            pbProductImage.CustomizableEdges = customizableEdges1;
            pbProductImage.ImageRotate = 0F;
            pbProductImage.Location = new Point(15, 10);
            pbProductImage.Margin = new Padding(3, 2, 3, 2);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pbProductImage.Size = new Size(213, 148);
            pbProductImage.TabIndex = 0;
            pbProductImage.TabStop = false;
            // 
            // btn50g
            // 
            btn50g.BorderRadius = 10;
            btn50g.CustomizableEdges = customizableEdges3;
            btn50g.DisabledState.BorderColor = Color.DarkGray;
            btn50g.DisabledState.CustomBorderColor = Color.DarkGray;
            btn50g.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn50g.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn50g.FillColor = Color.LightGray;
            btn50g.Font = new Font("Segoe UI", 9F);
            btn50g.ForeColor = Color.Black;
            btn50g.Location = new Point(15, 224);
            btn50g.Margin = new Padding(3, 2, 3, 2);
            btn50g.Name = "btn50g";
            btn50g.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn50g.Size = new Size(103, 28);
            btn50g.TabIndex = 1;
            btn50g.Text = "50g";
            btn50g.Click += btn50g_Click;
            // 
            // btn100g
            // 
            btn100g.BorderRadius = 10;
            btn100g.CustomizableEdges = customizableEdges5;
            btn100g.DisabledState.BorderColor = Color.DarkGray;
            btn100g.DisabledState.CustomBorderColor = Color.DarkGray;
            btn100g.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn100g.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn100g.FillColor = Color.LightGray;
            btn100g.Font = new Font("Segoe UI", 9F);
            btn100g.ForeColor = Color.Black;
            btn100g.Location = new Point(132, 224);
            btn100g.Margin = new Padding(3, 2, 3, 2);
            btn100g.Name = "btn100g";
            btn100g.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn100g.Size = new Size(103, 28);
            btn100g.TabIndex = 2;
            btn100g.Text = "100g";
            btn100g.Click += btn100g_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(101, 169);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(38, 15);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "label1";
            // 
            // lblPrice50g
            // 
            lblPrice50g.AutoSize = true;
            lblPrice50g.Location = new Point(45, 254);
            lblPrice50g.Name = "lblPrice50g";
            lblPrice50g.Size = new Size(38, 15);
            lblPrice50g.TabIndex = 4;
            lblPrice50g.Text = "label2";
            // 
            // lblPrice100g
            // 
            lblPrice100g.AutoSize = true;
            lblPrice100g.Location = new Point(169, 254);
            lblPrice100g.Name = "lblPrice100g";
            lblPrice100g.Size = new Size(38, 15);
            lblPrice100g.TabIndex = 5;
            lblPrice100g.Text = "label3";
            // 
            // UC_Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPrice100g);
            Controls.Add(lblPrice50g);
            Controls.Add(lblProductName);
            Controls.Add(btn100g);
            Controls.Add(btn50g);
            Controls.Add(pbProductImage);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Product";
            Size = new Size(246, 290);
            Load += UC_Product_Load;
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbProductImage;
        private Guna.UI2.WinForms.Guna2Button btn50g;
        private Guna.UI2.WinForms.Guna2Button btn100g;
        private Label lblProductName;
        private Label lblPrice50g;
        private Label lblPrice100g;
    }
}
