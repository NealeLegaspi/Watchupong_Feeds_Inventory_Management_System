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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            btnGcash = new Guna.UI2.WinForms.Guna2Button();
            btnCash = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            Amount = new Label();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlDark;
            flowLayoutPanel1.Location = new Point(3, 37);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(765, 558);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ControlDark;
            flowLayoutPanel2.Location = new Point(774, 37);
            flowLayoutPanel2.Margin = new Padding(3, 3, 3, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(383, 349);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 2;
            label1.Text = "PRODUCT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(774, 4);
            label2.Name = "label2";
            label2.Size = new Size(65, 30);
            label2.TabIndex = 3;
            label2.Text = "CART";
            // 
            // btnGcash
            // 
            btnGcash.CustomizableEdges = customizableEdges1;
            btnGcash.DisabledState.BorderColor = Color.DarkGray;
            btnGcash.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGcash.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGcash.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGcash.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGcash.ForeColor = Color.White;
            btnGcash.Location = new Point(911, 508);
            btnGcash.Name = "btnGcash";
            btnGcash.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnGcash.Size = new Size(147, 47);
            btnGcash.TabIndex = 26;
            btnGcash.Text = "G-CASH";
            btnGcash.Click += btnGcash_Click;
            // 
            // btnCash
            // 
            btnCash.CustomizableEdges = customizableEdges3;
            btnCash.DisabledState.BorderColor = Color.DarkGray;
            btnCash.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCash.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCash.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCash.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCash.ForeColor = Color.White;
            btnCash.Location = new Point(911, 455);
            btnCash.Name = "btnCash";
            btnCash.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCash.Size = new Size(147, 47);
            btnCash.TabIndex = 25;
            btnCash.Text = "CASH";
            btnCash.Click += btnCash_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Amount, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Location = new Point(775, 389);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(383, 39);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // Amount
            // 
            Amount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Amount.AutoSize = true;
            Amount.Location = new Point(194, 12);
            Amount.Name = "Amount";
            Amount.Size = new Size(186, 15);
            Amount.TabIndex = 1;
            Amount.Text = "-Total Amount-";
            Amount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(185, 15);
            label3.TabIndex = 0;
            label3.Text = "Total Amount:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_Product_Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnGcash);
            Controls.Add(btnCash);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "UC_Product_Cashier";
            Size = new Size(1160, 598);
            Load += UC_Product_Cashier_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnGcash;
        private Guna.UI2.WinForms.Guna2Button btnCash;
        private TableLayoutPanel tableLayoutPanel1;
        private Label Amount;
        private Label label3;
    }
}
