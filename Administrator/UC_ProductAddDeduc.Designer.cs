namespace Administrator
{
    partial class UC_ProductAddDeduc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ProductAddDeduc));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            textBox1 = new TextBox();
            txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            btnDeduct = new Guna.UI2.WinForms.Guna2CircleButton();
            quantity_lbl = new Label();
            ProductPrice = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 0);
            textBox1.TabIndex = 0;
            // 
            // txtProductName
            // 
            txtProductName.BorderRadius = 20;
            txtProductName.CustomizableEdges = customizableEdges1;
            txtProductName.DefaultText = "";
            txtProductName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtProductName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtProductName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtProductName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtProductName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProductName.Font = new Font("Segoe UI", 9F);
            txtProductName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProductName.Location = new Point(0, 9);
            txtProductName.Name = "txtProductName";
            txtProductName.PasswordChar = '\0';
            txtProductName.PlaceholderText = "";
            txtProductName.SelectedText = "";
            txtProductName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtProductName.Size = new Size(191, 37);
            txtProductName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageSize = new Size(15, 15);
            btnAdd.Location = new Point(261, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAdd.Size = new Size(26, 25);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "guna2CircleButton1";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDeduct
            // 
            btnDeduct.BackColor = Color.Transparent;
            btnDeduct.BackgroundImage = (Image)resources.GetObject("btnDeduct.BackgroundImage");
            btnDeduct.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeduct.DisabledState.BorderColor = Color.DarkGray;
            btnDeduct.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeduct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeduct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeduct.FillColor = Color.White;
            btnDeduct.Font = new Font("Segoe UI", 9F);
            btnDeduct.ForeColor = Color.White;
            btnDeduct.ImageSize = new Size(15, 15);
            btnDeduct.Location = new Point(210, 15);
            btnDeduct.Name = "btnDeduct";
            btnDeduct.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDeduct.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnDeduct.Size = new Size(26, 25);
            btnDeduct.TabIndex = 3;
            btnDeduct.Text = "guna2CircleButton2";
            btnDeduct.Click += btnDeduct_Click;
            // 
            // quantity_lbl
            // 
            quantity_lbl.AutoSize = true;
            quantity_lbl.Location = new Point(242, 21);
            quantity_lbl.Name = "quantity_lbl";
            quantity_lbl.Size = new Size(13, 15);
            quantity_lbl.TabIndex = 4;
            quantity_lbl.Text = "1";
            // 
            // ProductPrice
            // 
            ProductPrice.AutoSize = true;
            ProductPrice.Location = new Point(363, 21);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(49, 15);
            ProductPrice.TabIndex = 6;
            ProductPrice.Text = "<Price>";
            // 
            // UC_ProductAddDeduc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(ProductPrice);
            Controls.Add(quantity_lbl);
            Controls.Add(btnDeduct);
            Controls.Add(btnAdd);
            Controls.Add(txtProductName);
            Controls.Add(textBox1);
            Name = "UC_ProductAddDeduc";
            Size = new Size(405, 64);
            Load += UC_ProductAddDeduc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private Guna.UI2.WinForms.Guna2CircleButton btnDeduct;
        private Label quantity_lbl;
        private Label label2;
        private Label ProductPrice;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
