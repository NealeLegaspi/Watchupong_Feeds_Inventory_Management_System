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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            textBox1 = new TextBox();
            txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            btnDeduct = new Guna.UI2.WinForms.Guna2CircleButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            txtProductName.Location = new Point(3, 9);
            txtProductName.Name = "txtProductName";
            txtProductName.PasswordChar = '\0';
            txtProductName.PlaceholderText = "";
            txtProductName.SelectedText = "";
            txtProductName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtProductName.Size = new Size(200, 36);
            txtProductName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackgroundImageLayout = ImageLayout.Center;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = Color.White;
            btnAdd.ImageSize = new Size(35, 35);
            btnAdd.Location = new Point(275, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAdd.Size = new Size(26, 24);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "guna2CircleButton1";
            // 
            // btnDeduct
            // 
            btnDeduct.BackColor = Color.Transparent;
            btnDeduct.BackgroundImageLayout = ImageLayout.Center;
            btnDeduct.DisabledState.BorderColor = Color.DarkGray;
            btnDeduct.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeduct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeduct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeduct.FillColor = Color.White;
            btnDeduct.Font = new Font("Segoe UI", 9F);
            btnDeduct.ForeColor = Color.White;
            btnDeduct.ImageSize = new Size(35, 35);
            btnDeduct.Location = new Point(224, 15);
            btnDeduct.Name = "btnDeduct";
            btnDeduct.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDeduct.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnDeduct.Size = new Size(26, 24);
            btnDeduct.TabIndex = 3;
            btnDeduct.Text = "guna2CircleButton2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 21);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 4;
            label1.Text = "2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 21);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 5;
            label2.Text = "100g";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 21);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "200.00";
            // 
            // UC_ProductAddDeduc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeduct);
            Controls.Add(btnAdd);
            Controls.Add(txtProductName);
            Controls.Add(textBox1);
            Name = "UC_ProductAddDeduc";
            Size = new Size(423, 54);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private Guna.UI2.WinForms.Guna2CircleButton btnDeduct;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
