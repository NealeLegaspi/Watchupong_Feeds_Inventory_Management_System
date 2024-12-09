namespace Administrator
{
    partial class UC_Audit
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            dtgAudit = new DataGridView();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Archived = new Guna.UI2.WinForms.Guna2Button();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dtgAudit).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 10;
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeftSize = new Size(25, 25);
            txtSearch.Location = new Point(822, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(248, 27);
            txtSearch.TabIndex = 2;
            // 
            // dtgAudit
            // 
            dtgAudit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgAudit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAudit.Location = new Point(20, 62);
            dtgAudit.Margin = new Padding(3, 2, 3, 2);
            dtgAudit.Name = "dtgAudit";
            dtgAudit.RowHeadersWidth = 51;
            dtgAudit.Size = new Size(1119, 485);
            dtgAudit.TabIndex = 3;
            dtgAudit.CellContentClick += dtgAudit_CellContentClick;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(20, 16);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(145, 31);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Audit Logs";
            // 
            // Archived
            // 
            Archived.BorderRadius = 10;
            Archived.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            Archived.CustomizableEdges = customizableEdges3;
            Archived.DisabledState.BorderColor = Color.DarkGray;
            Archived.DisabledState.CustomBorderColor = Color.DarkGray;
            Archived.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Archived.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Archived.FillColor = Color.LightGray;
            Archived.Font = new Font("Segoe UI", 9F);
            Archived.ForeColor = Color.Black;
            Archived.Location = new Point(1023, 552);
            Archived.Name = "Archived";
            Archived.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Archived.Size = new Size(116, 32);
            Archived.TabIndex = 5;
            Archived.Text = "Archived";
            // 
            // btnSearch
            // 
            btnSearch.CustomizableEdges = customizableEdges5;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.Black;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1076, 20);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSearch.Size = new Size(63, 27);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // UC_Audit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(Archived);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dtgAudit);
            Controls.Add(txtSearch);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Audit";
            Size = new Size(1160, 598);
            Load += UC_Audit_Load;
            ((System.ComponentModel.ISupportInitialize)dtgAudit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private DataGridView dtgAudit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button Archived;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
    }
}
