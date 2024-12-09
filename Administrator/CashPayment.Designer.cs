namespace Administrator
{
    partial class CashPayment
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

        #region Windows Form Designer generated code

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
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTotalAmount = new Label();
            SuspendLayout();
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Black;
            guna2Button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(97, 380);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "Pay";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // txtAmount
            // 
            txtAmount.CustomizableEdges = customizableEdges3;
            txtAmount.DefaultText = "";
            txtAmount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAmount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAmount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAmount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAmount.Font = new Font("Segoe UI", 9F);
            txtAmount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAmount.Location = new Point(33, 271);
            txtAmount.Name = "txtAmount";
            txtAmount.PasswordChar = '\0';
            txtAmount.PlaceholderText = "";
            txtAmount.SelectedText = "";
            txtAmount.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtAmount.Size = new Size(311, 49);
            txtAmount.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 18);
            label1.Name = "label1";
            label1.Size = new Size(144, 30);
            label1.TabIndex = 2;
            label1.Text = "Cash Payment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 227);
            label2.Name = "label2";
            label2.Size = new Size(147, 30);
            label2.TabIndex = 3;
            label2.Text = "Enter Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 97);
            label3.Name = "label3";
            label3.Size = new Size(143, 30);
            label3.TabIndex = 4;
            label3.Text = "Total Amount:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(204, 97);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 30);
            lblTotalAmount.TabIndex = 5;
            // 
            // CashPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 485);
            Controls.Add(lblTotalAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAmount);
            Controls.Add(guna2Button1);
            Name = "CashPayment";
            Text = "CashPayment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTotalAmount;
    }
}