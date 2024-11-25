namespace Administrator
{
    partial class UC_Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Inventory));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnStock = new Guna.UI2.WinForms.Guna2Button();
            btnProductList = new Guna.UI2.WinForms.Guna2Button();
            dtgInventory = new DataGridView();
            Product_ID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Grams = new DataGridViewTextBoxColumn();
            InStocks = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            StockStatus = new DataGridViewTextBoxColumn();
            MfgDate = new DataGridViewTextBoxColumn();
            ExpDate = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewTextBoxColumn();
            btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dtgInventory).BeginInit();
            SuspendLayout();
            // 
            // btnStock
            // 
            btnStock.BorderRadius = 10;
            btnStock.CustomizableEdges = customizableEdges1;
            btnStock.DisabledState.BorderColor = Color.DarkGray;
            btnStock.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStock.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStock.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStock.FillColor = Color.Black;
            btnStock.Font = new Font("Segoe UI", 9F);
            btnStock.ForeColor = Color.White;
            btnStock.Location = new Point(35, 153);
            btnStock.Name = "btnStock";
            btnStock.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnStock.Size = new Size(201, 54);
            btnStock.TabIndex = 0;
            btnStock.Text = "Stock";
            // 
            // btnProductList
            // 
            btnProductList.BorderRadius = 10;
            btnProductList.CustomizableEdges = customizableEdges3;
            btnProductList.DisabledState.BorderColor = Color.DarkGray;
            btnProductList.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProductList.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProductList.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProductList.FillColor = Color.Black;
            btnProductList.Font = new Font("Segoe UI", 9F);
            btnProductList.ForeColor = Color.White;
            btnProductList.Location = new Point(242, 153);
            btnProductList.Name = "btnProductList";
            btnProductList.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnProductList.Size = new Size(201, 54);
            btnProductList.TabIndex = 1;
            btnProductList.Text = "Product List";
            // 
            // dtgInventory
            // 
            dtgInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInventory.Columns.AddRange(new DataGridViewColumn[] { Product_ID, ProductName, Grams, InStocks, Price, StockStatus, MfgDate, ExpDate, Actions });
            dtgInventory.Location = new Point(35, 213);
            dtgInventory.Name = "dtgInventory";
            dtgInventory.RowHeadersWidth = 51;
            dtgInventory.Size = new Size(1507, 720);
            dtgInventory.TabIndex = 2;
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
            // StockStatus
            // 
            StockStatus.HeaderText = "Stock_Status";
            StockStatus.MinimumWidth = 6;
            StockStatus.Name = "StockStatus";
            // 
            // MfgDate
            // 
            MfgDate.HeaderText = "Mfg_Date";
            MfgDate.MinimumWidth = 6;
            MfgDate.Name = "MfgDate";
            // 
            // ExpDate
            // 
            ExpDate.HeaderText = "Exp_Date";
            ExpDate.MinimumWidth = 6;
            ExpDate.Name = "ExpDate";
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
            btnAddProduct.CustomizableEdges = customizableEdges5;
            btnAddProduct.DisabledState.BorderColor = Color.DarkGray;
            btnAddProduct.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddProduct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddProduct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddProduct.FillColor = Color.Black;
            btnAddProduct.Font = new Font("Segoe UI", 9F);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Image = (Image)resources.GetObject("btnAddProduct.Image");
            btnAddProduct.Location = new Point(1372, 153);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddProduct.Size = new Size(170, 54);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "Add Product";
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddProduct);
            Controls.Add(dtgInventory);
            Controls.Add(btnProductList);
            Controls.Add(btnStock);
            Name = "UC_Inventory";
            Size = new Size(1581, 953);
            ((System.ComponentModel.ISupportInitialize)dtgInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnStock;
        private Guna.UI2.WinForms.Guna2Button btnProductList;
        private DataGridView dtgInventory;
        private DataGridViewTextBoxColumn Product_ID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Grams;
        private DataGridViewTextBoxColumn InStocks;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn StockStatus;
        private DataGridViewTextBoxColumn MfgDate;
        private DataGridViewTextBoxColumn ExpDate;
        private DataGridViewTextBoxColumn Actions;
        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
    }
}
