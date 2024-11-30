namespace Administrator
{
    partial class UC_DeliveryLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DeliveryLogs));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dtgDeliveryLogs = new DataGridView();
            Product_ID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Grams = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Mfg_Date = new DataGridViewTextBoxColumn();
            Exp_Date = new DataGridViewTextBoxColumn();
            Delivery_Date = new DataGridViewTextBoxColumn();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtDLSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            Archived = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dtgDeliveryLogs).BeginInit();
            SuspendLayout();
            // 
            // dtgDeliveryLogs
            // 
            dtgDeliveryLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDeliveryLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDeliveryLogs.Columns.AddRange(new DataGridViewColumn[] { Product_ID, ProductName, Grams, Price, Mfg_Date, Exp_Date, Delivery_Date });
            dtgDeliveryLogs.Location = new Point(19, 97);
            dtgDeliveryLogs.Margin = new Padding(3, 2, 3, 2);
            dtgDeliveryLogs.Name = "dtgDeliveryLogs";
            dtgDeliveryLogs.RowHeadersWidth = 51;
            dtgDeliveryLogs.Size = new Size(1121, 540);
            dtgDeliveryLogs.TabIndex = 0;
            // 
            // Product_ID
            // 
            Product_ID.HeaderText = "Product_ID";
            Product_ID.MinimumWidth = 6;
            Product_ID.Name = "Product_ID";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product_Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            // 
            // Grams
            // 
            Grams.HeaderText = "Grams";
            Grams.MinimumWidth = 6;
            Grams.Name = "Grams";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Mfg_Date
            // 
            Mfg_Date.HeaderText = "Mfg_Date";
            Mfg_Date.MinimumWidth = 6;
            Mfg_Date.Name = "Mfg_Date";
            // 
            // Exp_Date
            // 
            Exp_Date.HeaderText = "Exp_Date";
            Exp_Date.MinimumWidth = 6;
            Exp_Date.Name = "Exp_Date";
            // 
            // Delivery_Date
            // 
            Delivery_Date.HeaderText = "Delivery_Date";
            Delivery_Date.MinimumWidth = 6;
            Delivery_Date.Name = "Delivery_Date";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Verdana", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(19, 60);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(194, 33);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Delivery Logs";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // txtDLSearchBar
            // 
            txtDLSearchBar.BorderRadius = 10;
            txtDLSearchBar.CustomizableEdges = customizableEdges3;
            txtDLSearchBar.DefaultText = "";
            txtDLSearchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDLSearchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDLSearchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDLSearchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDLSearchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDLSearchBar.Font = new Font("Segoe UI", 9F);
            txtDLSearchBar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDLSearchBar.IconLeftSize = new Size(25, 25);
            txtDLSearchBar.IconRight = (Image)resources.GetObject("txtDLSearchBar.IconRight");
            txtDLSearchBar.Location = new Point(892, 66);
            txtDLSearchBar.Name = "txtDLSearchBar";
            txtDLSearchBar.PasswordChar = '\0';
            txtDLSearchBar.PlaceholderText = "";
            txtDLSearchBar.SelectedText = "";
            txtDLSearchBar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtDLSearchBar.Size = new Size(248, 27);
            txtDLSearchBar.TabIndex = 8;
            // 
            // Archived
            // 
            Archived.BorderRadius = 10;
            Archived.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            Archived.CustomizableEdges = customizableEdges5;
            Archived.DisabledState.BorderColor = Color.DarkGray;
            Archived.DisabledState.CustomBorderColor = Color.DarkGray;
            Archived.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Archived.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Archived.FillColor = Color.LightGray;
            Archived.Font = new Font("Segoe UI", 9F);
            Archived.ForeColor = Color.Black;
            Archived.Location = new Point(1024, 642);
            Archived.Name = "Archived";
            Archived.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Archived.Size = new Size(116, 32);
            Archived.TabIndex = 9;
            Archived.Text = "Archived";
            // 
            // UC_DeliveryLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Archived);
            Controls.Add(txtDLSearchBar);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dtgDeliveryLogs);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_DeliveryLogs";
            Size = new Size(1162, 686);
            ((System.ComponentModel.ISupportInitialize)dtgDeliveryLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDeliveryLogs;
        private DataGridViewTextBoxColumn Product_ID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Grams;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Mfg_Date;
        private DataGridViewTextBoxColumn Exp_Date;
        private DataGridViewTextBoxColumn Delivery_Date;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtDLSearchBar;
        private Guna.UI2.WinForms.Guna2Button Archived;
    }
}
