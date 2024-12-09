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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DeliveryLogs));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dtgDeliveryLogs = new DataGridView();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            btnArchived = new Guna.UI2.WinForms.Guna2Button();
            btnSearch = new Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dtgDeliveryLogs).BeginInit();
            SuspendLayout();
            // 
            // dtgDeliveryLogs
            // 
            dtgDeliveryLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDeliveryLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDeliveryLogs.Location = new Point(19, 57);
            dtgDeliveryLogs.Margin = new Padding(3, 2, 3, 2);
            dtgDeliveryLogs.Name = "dtgDeliveryLogs";
            dtgDeliveryLogs.RowHeadersWidth = 51;
            dtgDeliveryLogs.Size = new Size(1134, 485);
            dtgDeliveryLogs.TabIndex = 0;
            dtgDeliveryLogs.CellContentClick += dtgDeliveryLogs_CellContentClick;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Verdana", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(19, 20);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(194, 33);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Delivery Logs";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // txtSearchBar
            // 
            txtSearchBar.BorderRadius = 10;
            txtSearchBar.CustomizableEdges = customizableEdges1;
            txtSearchBar.DefaultText = "";
            txtSearchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchBar.Font = new Font("Segoe UI", 9F);
            txtSearchBar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchBar.IconLeftSize = new Size(25, 25);
            txtSearchBar.IconRight = (Image)resources.GetObject("txtSearchBar.IconRight");
            txtSearchBar.Location = new Point(824, 26);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.PasswordChar = '\0';
            txtSearchBar.PlaceholderText = "";
            txtSearchBar.SelectedText = "";
            txtSearchBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchBar.Size = new Size(248, 27);
            txtSearchBar.TabIndex = 8;
            txtSearchBar.TextChanged += txtDLSearchBar_TextChanged;
            // 
            // btnArchived
            // 
            btnArchived.BorderRadius = 10;
            btnArchived.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            btnArchived.CustomizableEdges = customizableEdges3;
            btnArchived.DisabledState.BorderColor = Color.DarkGray;
            btnArchived.DisabledState.CustomBorderColor = Color.DarkGray;
            btnArchived.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnArchived.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnArchived.FillColor = Color.LightGray;
            btnArchived.Font = new Font("Segoe UI", 9F);
            btnArchived.ForeColor = Color.Black;
            btnArchived.Location = new Point(17, 552);
            btnArchived.Name = "btnArchived";
            btnArchived.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnArchived.Size = new Size(116, 32);
            btnArchived.TabIndex = 9;
            btnArchived.Text = "Archived";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1078, 561);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Add";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.LightGray;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(956, 561);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(116, 32);
            guna2Button1.TabIndex = 11;
            guna2Button1.Text = "Add";
            // 
            // UC_DeliveryLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Button1);
            Controls.Add(btnSearch);
            Controls.Add(btnArchived);
            Controls.Add(txtSearchBar);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dtgDeliveryLogs);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_DeliveryLogs";
            Size = new Size(1160, 598);
            Load += UC_DeliveryLogs_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDeliveryLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDeliveryLogs;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBar;
        private Guna.UI2.WinForms.Guna2Button btnArchived;
        private Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
