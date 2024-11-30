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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            textBox1 = new TextBox();
            txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            btnDeduct = new Guna.UI2.WinForms.Guna2CircleButton();
            label1 = new Label();
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
            txtProductName.CustomizableEdges = customizableEdges5;
            txtProductName.DefaultText = "";
            txtProductName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtProductName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtProductName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtProductName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtProductName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProductName.Font = new Font("Segoe UI", 9F);
            txtProductName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProductName.Location = new Point(3, 0);
            txtProductName.Name = "txtProductName";
            txtProductName.PasswordChar = '\0';
            txtProductName.PlaceholderText = "";
            txtProductName.SelectedText = "";
            txtProductName.ShadowDecoration.CustomizableEdges = customizableEdges6;
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
            btnAdd.Location = new Point(313, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges7;
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
            btnDeduct.Location = new Point(224, 12);
            btnDeduct.Name = "btnDeduct";
            btnDeduct.ShadowDecoration.CustomizableEdges = customizableEdges8;
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
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // UC_ProductAddDeduc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label1);
            Controls.Add(btnDeduct);
            Controls.Add(btnAdd);
            Controls.Add(txtProductName);
            Controls.Add(textBox1);
            Name = "UC_ProductAddDeduc";
            Size = new Size(368, 54);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private Guna.UI2.WinForms.Guna2CircleButton btnDeduct;
        private Label label1;
    }
}
