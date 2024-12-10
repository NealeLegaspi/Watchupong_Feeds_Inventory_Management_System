namespace Administrator
{
    partial class AddDeliveryLogs
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpMFGDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpEXPDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpDeliveryDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            cmbProductName = new Guna.UI2.WinForms.Guna2ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 57);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 57);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 145);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 2;
            label3.Text = "Manufacturing Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 145);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Expiration Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 230);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Delivery Date";
            // 
            // dtpMFGDate
            // 
            dtpMFGDate.Checked = true;
            dtpMFGDate.CustomizableEdges = customizableEdges1;
            dtpMFGDate.FillColor = Color.White;
            dtpMFGDate.Font = new Font("Segoe UI", 9F);
            dtpMFGDate.Format = DateTimePickerFormat.Long;
            dtpMFGDate.Location = new Point(24, 175);
            dtpMFGDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpMFGDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpMFGDate.Name = "dtpMFGDate";
            dtpMFGDate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtpMFGDate.Size = new Size(200, 21);
            dtpMFGDate.TabIndex = 5;
            dtpMFGDate.Value = new DateTime(2024, 12, 9, 22, 45, 16, 15);
            // 
            // dtpEXPDate
            // 
            dtpEXPDate.Checked = true;
            dtpEXPDate.CustomizableEdges = customizableEdges3;
            dtpEXPDate.FillColor = Color.White;
            dtpEXPDate.Font = new Font("Segoe UI", 9F);
            dtpEXPDate.Format = DateTimePickerFormat.Long;
            dtpEXPDate.Location = new Point(230, 175);
            dtpEXPDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpEXPDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpEXPDate.Name = "dtpEXPDate";
            dtpEXPDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpEXPDate.Size = new Size(200, 21);
            dtpEXPDate.TabIndex = 6;
            dtpEXPDate.Value = new DateTime(2024, 12, 9, 22, 45, 16, 15);
            // 
            // dtpDeliveryDate
            // 
            dtpDeliveryDate.Checked = true;
            dtpDeliveryDate.CustomizableEdges = customizableEdges5;
            dtpDeliveryDate.FillColor = Color.White;
            dtpDeliveryDate.Font = new Font("Segoe UI", 9F);
            dtpDeliveryDate.Format = DateTimePickerFormat.Long;
            dtpDeliveryDate.Location = new Point(24, 260);
            dtpDeliveryDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDeliveryDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDeliveryDate.Name = "dtpDeliveryDate";
            dtpDeliveryDate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpDeliveryDate.Size = new Size(200, 21);
            dtpDeliveryDate.TabIndex = 7;
            dtpDeliveryDate.Value = new DateTime(2024, 12, 9, 22, 45, 16, 15);
            // 
            // txtQuantity
            // 
            txtQuantity.BorderRadius = 10;
            txtQuantity.CustomizableEdges = customizableEdges7;
            txtQuantity.DefaultText = "";
            txtQuantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtQuantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtQuantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQuantity.Font = new Font("Segoe UI", 9F);
            txtQuantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQuantity.Location = new Point(238, 85);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PasswordChar = '\0';
            txtQuantity.PlaceholderText = "";
            txtQuantity.SelectedText = "";
            txtQuantity.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtQuantity.Size = new Size(99, 36);
            txtQuantity.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BorderColor = Color.Transparent;
            btnAdd.BorderRadius = 10;
            btnAdd.CustomizableEdges = customizableEdges9;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.Lime;
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(164, 320);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAdd.Size = new Size(111, 33);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Stock In";
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbProductName
            // 
            cmbProductName.BackColor = Color.Transparent;
            cmbProductName.BorderRadius = 10;
            cmbProductName.CustomizableEdges = customizableEdges11;
            cmbProductName.DrawMode = DrawMode.OwnerDrawFixed;
            cmbProductName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductName.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbProductName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbProductName.Font = new Font("Segoe UI", 10F);
            cmbProductName.ForeColor = Color.FromArgb(68, 88, 112);
            cmbProductName.ItemHeight = 30;
            cmbProductName.Location = new Point(23, 85);
            cmbProductName.Name = "cmbProductName";
            cmbProductName.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cmbProductName.Size = new Size(201, 36);
            cmbProductName.TabIndex = 11;
            // 
            // AddDeliveryLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 390);
            Controls.Add(cmbProductName);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(dtpDeliveryDate);
            Controls.Add(dtpEXPDate);
            Controls.Add(dtpMFGDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AddDeliveryLogs";
            Text = "AddDeliveryLogs";
            Load += AddDeliveryLogs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMFGDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEXPDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDeliveryDate;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProductName;
    }
}