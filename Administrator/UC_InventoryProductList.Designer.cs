namespace Administrator
{
    partial class UC_InventoryProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_InventoryProductList));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            dtgInventory = new DataGridView();
            Product_ID = new DataGridViewTextBoxColumn();
            Product_Name = new DataGridViewTextBoxColumn();
            Grams = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Mfg_Date = new DataGridViewTextBoxColumn();
            Exp_Date = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewTextBoxColumn();
            btnProductList = new Guna.UI2.WinForms.Guna2Button();
            btnStock = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dtgInventory).BeginInit();
            SuspendLayout();
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.LightGray;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(1031, 552);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(116, 32);
            guna2Button1.TabIndex = 16;
            guna2Button1.Text = "Archived";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 15;
            label1.Text = "Inventory";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BorderRadius = 10;
            btnAddProduct.CustomizableEdges = customizableEdges3;
            btnAddProduct.DisabledState.BorderColor = Color.DarkGray;
            btnAddProduct.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddProduct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddProduct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddProduct.FillColor = Color.Black;
            btnAddProduct.Font = new Font("Segoe UI", 9F);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Image = (Image)resources.GetObject("btnAddProduct.Image");
            btnAddProduct.Location = new Point(1022, 48);
            btnAddProduct.Margin = new Padding(3, 2, 3, 2);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddProduct.Size = new Size(125, 32);
            btnAddProduct.TabIndex = 14;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // dtgInventory
            // 
            dtgInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInventory.Columns.AddRange(new DataGridViewColumn[] { Product_ID, Product_Name, Grams, Price, Quantity, Mfg_Date, Exp_Date, Actions });
            dtgInventory.Location = new Point(13, 84);
            dtgInventory.Margin = new Padding(3, 2, 3, 2);
            dtgInventory.Name = "dtgInventory";
            dtgInventory.RowHeadersWidth = 51;
            dtgInventory.Size = new Size(1134, 463);
            dtgInventory.TabIndex = 13;
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
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantiy";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
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
            // btnProductList
            // 
            btnProductList.BorderRadius = 10;
            btnProductList.CustomizableEdges = customizableEdges5;
            btnProductList.DisabledState.BorderColor = Color.DarkGray;
            btnProductList.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProductList.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProductList.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProductList.FillColor = Color.Black;
            btnProductList.Font = new Font("Segoe UI", 9F);
            btnProductList.ForeColor = Color.White;
            btnProductList.Location = new Point(144, 48);
            btnProductList.Margin = new Padding(3, 2, 3, 2);
            btnProductList.Name = "btnProductList";
            btnProductList.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnProductList.Size = new Size(125, 32);
            btnProductList.TabIndex = 12;
            btnProductList.Text = "Product List";
            btnProductList.Click += btnProductList_Click;
            // 
            // btnStock
            // 
            btnStock.BorderRadius = 10;
            btnStock.CustomizableEdges = customizableEdges7;
            btnStock.DisabledState.BorderColor = Color.DarkGray;
            btnStock.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStock.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStock.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStock.FillColor = Color.Black;
            btnStock.Font = new Font("Segoe UI", 9F);
            btnStock.ForeColor = Color.White;
            btnStock.Location = new Point(13, 48);
            btnStock.Margin = new Padding(3, 2, 3, 2);
            btnStock.Name = "btnStock";
            btnStock.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnStock.Size = new Size(125, 32);
            btnStock.TabIndex = 11;
            btnStock.Text = "Stock";
            // 
            // UC_InventoryProductList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Button1);
            Controls.Add(label1);
            Controls.Add(btnAddProduct);
            Controls.Add(dtgInventory);
            Controls.Add(btnProductList);
            Controls.Add(btnStock);
            Name = "UC_InventoryProductList";
            Size = new Size(1160, 598);
            ((System.ComponentModel.ISupportInitialize)dtgInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
        private DataGridView dtgInventory;
        private Guna.UI2.WinForms.Guna2Button btnProductList;
        private Guna.UI2.WinForms.Guna2Button btnStock;
        private DataGridViewTextBoxColumn Product_ID;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn Grams;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Mfg_Date;
        private DataGridViewTextBoxColumn Exp_Date;
        private DataGridViewTextBoxColumn Actions;
    }
}
