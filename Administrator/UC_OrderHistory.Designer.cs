namespace Administrator
{
    partial class UC_OrderHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_OrderHistory));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dtgOrderHistory = new DataGridView();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Archived = new Guna.UI2.WinForms.Guna2Button();
            txtOHSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgOrderHistory).BeginInit();
            SuspendLayout();
            // 
            // dtgOrderHistory
            // 
            dtgOrderHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgOrderHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgOrderHistory.Location = new Point(12, 57);
            dtgOrderHistory.Margin = new Padding(3, 2, 3, 2);
            dtgOrderHistory.Name = "dtgOrderHistory";
            dtgOrderHistory.RowHeadersWidth = 51;
            dtgOrderHistory.Size = new Size(1134, 485);
            dtgOrderHistory.TabIndex = 0;
            dtgOrderHistory.CellContentClick += dtgOrderHistory_CellContentClick;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Verdana", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(12, 20);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(192, 33);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Order History";
            // 
            // Archived
            // 
            Archived.BorderRadius = 10;
            Archived.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            Archived.CustomizableEdges = customizableEdges1;
            Archived.DisabledState.BorderColor = Color.DarkGray;
            Archived.DisabledState.CustomBorderColor = Color.DarkGray;
            Archived.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Archived.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Archived.FillColor = Color.LightGray;
            Archived.Font = new Font("Segoe UI", 9F);
            Archived.ForeColor = Color.Black;
            Archived.Location = new Point(1030, 547);
            Archived.Name = "Archived";
            Archived.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Archived.Size = new Size(116, 32);
            Archived.TabIndex = 6;
            Archived.Text = "Archived";
            // 
            // txtOHSearchBar
            // 
            txtOHSearchBar.BorderRadius = 10;
            txtOHSearchBar.CustomizableEdges = customizableEdges3;
            txtOHSearchBar.DefaultText = "";
            txtOHSearchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtOHSearchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtOHSearchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtOHSearchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtOHSearchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOHSearchBar.Font = new Font("Segoe UI", 9F);
            txtOHSearchBar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOHSearchBar.IconLeftSize = new Size(25, 25);
            txtOHSearchBar.IconRight = (Image)resources.GetObject("txtOHSearchBar.IconRight");
            txtOHSearchBar.Location = new Point(898, 26);
            txtOHSearchBar.Name = "txtOHSearchBar";
            txtOHSearchBar.PasswordChar = '\0';
            txtOHSearchBar.PlaceholderText = "";
            txtOHSearchBar.SelectedText = "";
            txtOHSearchBar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtOHSearchBar.Size = new Size(248, 27);
            txtOHSearchBar.TabIndex = 7;
            // 
            // UC_OrderHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtOHSearchBar);
            Controls.Add(Archived);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dtgOrderHistory);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_OrderHistory";
            RightToLeft = RightToLeft.No;
            Size = new Size(1160, 598);
            Load += UC_OrderHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dtgOrderHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgOrderHistory;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button Archived;
        private Guna.UI2.WinForms.Guna2TextBox txtOHSearchBar;
    }
}
