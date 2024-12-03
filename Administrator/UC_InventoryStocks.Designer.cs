namespace Administrator
{
    partial class UC_InventoryStocks
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_InventoryStocks));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnStock = new Guna.UI2.WinForms.Guna2Button();
            btnProductList = new Guna.UI2.WinForms.Guna2Button();
            dtgInventory = new DataGridView();
            Product_ID = new DataGridViewTextBoxColumn();
            Product_Name = new DataGridViewTextBoxColumn();
            Grams = new DataGridViewTextBoxColumn();
            InStocks = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Stock_Status = new DataGridViewTextBoxColumn();
            Mfg_Date = new DataGridViewTextBoxColumn();
            Exp_Date = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewTextBoxColumn();
            btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            Archived = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dtgInventory).BeginInit();
            SuspendLayout();
            // 
            // btnStock
            // 
            btnStock.BorderRadius = 10;
            btnStock.CustomizableEdges = customizableEdges19;
            btnStock.DisabledState.BorderColor = Color.DarkGray;
            btnStock.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStock.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStock.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStock.FillColor = Color.Black;
            btnStock.Font = new Font("Segoe UI", 9F);
            btnStock.ForeColor = Color.White;
            btnStock.Location = new Point(18, 49);
            btnStock.Margin = new Padding(3, 2, 3, 2);
            btnStock.Name = "btnStock";
            btnStock.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnStock.Size = new Size(125, 32);
            btnStock.TabIndex = 0;
            btnStock.Text = "Stock";
            btnStock.Click += btnStock_Click;
            // 
            // btnProductList
            // 
            btnProductList.BorderRadius = 10;
            btnProductList.CustomizableEdges = customizableEdges21;
            btnProductList.DisabledState.BorderColor = Color.DarkGray;
            btnProductList.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProductList.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProductList.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProductList.FillColor = Color.Black;
            btnProductList.Font = new Font("Segoe UI", 9F);
            btnProductList.ForeColor = Color.White;
            btnProductList.Location = new Point(149, 49);
            btnProductList.Margin = new Padding(3, 2, 3, 2);
            btnProductList.Name = "btnProductList";
            btnProductList.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnProductList.Size = new Size(125, 32);
            btnProductList.TabIndex = 1;
            btnProductList.Text = "Product List";
            btnProductList.Click += btnProductList_Click;
            // 
            // dtgInventory
            // 
            dtgInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInventory.Columns.AddRange(new DataGridViewColumn[] { Product_ID, Product_Name, Grams, InStocks, Price, Stock_Status, Mfg_Date, Exp_Date, Actions });
            dtgInventory.Location = new Point(18, 85);
            dtgInventory.Margin = new Padding(3, 2, 3, 2);
            dtgInventory.Name = "dtgInventory";
            dtgInventory.RowHeadersWidth = 51;
            dtgInventory.Size = new Size(1134, 463);
            dtgInventory.TabIndex = 2;
            // 
            // Product_ID
            // 
            Product_ID.HeaderText = "Product_ID";
            Product_ID.MinimumWidth = 6;
            Product_ID.Name = "Product_ID";
            // 
            // Product_Name
            // 
            Product_Name.HeaderText = "Product_Name";
            Product_Name.MinimumWidth = 6;
            Product_Name.Name = "Product_Name";
            // 
            // Grams
            // 
            Grams.HeaderText = "Grams";
            Grams.MinimumWidth = 6;
            Grams.Name = "Grams";
            // 
            // InStocks
            // 
            InStocks.HeaderText = "InStocks";
            InStocks.MinimumWidth = 6;
            InStocks.Name = "InStocks";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Stock_Status
            // 
            Stock_Status.HeaderText = "Stock_Status";
            Stock_Status.MinimumWidth = 6;
            Stock_Status.Name = "Stock_Status";
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
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.MinimumWidth = 6;
            Actions.Name = "Actions";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BorderRadius = 10;
            btnAddProduct.CustomizableEdges = customizableEdges23;
            btnAddProduct.DisabledState.BorderColor = Color.DarkGray;
            btnAddProduct.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddProduct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddProduct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddProduct.FillColor = Color.Black;
            btnAddProduct.Font = new Font("Segoe UI", 9F);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Image = (Image)resources.GetObject("btnAddProduct.Image");
            btnAddProduct.Location = new Point(1027, 49);
            btnAddProduct.Margin = new Padding(3, 2, 3, 2);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnAddProduct.Size = new Size(125, 32);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "Add Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 16);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 4;
            label1.Text = "Inventory";
            // 
            // Archived
            // 
            Archived.BorderRadius = 10;
            Archived.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            Archived.CustomizableEdges = customizableEdges25;
            Archived.DisabledState.BorderColor = Color.DarkGray;
            Archived.DisabledState.CustomBorderColor = Color.DarkGray;
            Archived.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Archived.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Archived.FillColor = Color.LightGray;
            Archived.Font = new Font("Segoe UI", 9F);
            Archived.ForeColor = Color.Black;
            Archived.Location = new Point(1023, 617);
            Archived.Name = "Archived";
            Archived.ShadowDecoration.CustomizableEdges = customizableEdges26;
            Archived.Size = new Size(116, 32);
            Archived.TabIndex = 7;
            Archived.Text = "Archived";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            guna2Button1.CustomizableEdges = customizableEdges27;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.LightGray;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(1036, 553);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges28;
            guna2Button1.Size = new Size(116, 32);
            guna2Button1.TabIndex = 10;
            guna2Button1.Text = "Archived";
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Button1);
            Controls.Add(Archived);
            Controls.Add(label1);
            Controls.Add(btnAddProduct);
            Controls.Add(dtgInventory);
            Controls.Add(btnProductList);
            Controls.Add(btnStock);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Inventory";
            RightToLeft = RightToLeft.No;
            Size = new Size(1160, 598);
            ((System.ComponentModel.ISupportInitialize)dtgInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnStock;
        private Guna.UI2.WinForms.Guna2Button btnProductList;
        private DataGridView dtgInventory;
        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
        private DataGridViewTextBoxColumn Product_ID;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn Grams;
        private DataGridViewTextBoxColumn InStocks;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Stock_Status;
        private DataGridViewTextBoxColumn Mfg_Date;
        private DataGridViewTextBoxColumn Exp_Date;
        private DataGridViewTextBoxColumn Actions;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button Archived;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
