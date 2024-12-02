namespace Administrator
{
    partial class UC_ActivityLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ActivityLogs));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtALSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            dtgActivityLogs = new DataGridView();
            ActivityLogs_ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Date_Time = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Archived = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dtgActivityLogs).BeginInit();
            SuspendLayout();
            // 
            // txtALSearchBar
            // 
            txtALSearchBar.BorderRadius = 10;
            txtALSearchBar.CustomizableEdges = customizableEdges1;
            txtALSearchBar.DefaultText = "";
            txtALSearchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtALSearchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtALSearchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtALSearchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtALSearchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtALSearchBar.Font = new Font("Segoe UI", 9F);
            txtALSearchBar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtALSearchBar.IconLeftSize = new Size(25, 25);
            txtALSearchBar.IconRight = (Image)resources.GetObject("txtALSearchBar.IconRight");
            txtALSearchBar.Location = new Point(906, 30);
            txtALSearchBar.Name = "txtALSearchBar";
            txtALSearchBar.PasswordChar = '\0';
            txtALSearchBar.PlaceholderText = "";
            txtALSearchBar.SelectedText = "";
            txtALSearchBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtALSearchBar.Size = new Size(248, 27);
            txtALSearchBar.TabIndex = 2;
            // 
            // dtgActivityLogs
            // 
            dtgActivityLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgActivityLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgActivityLogs.Columns.AddRange(new DataGridViewColumn[] { ActivityLogs_ID, Name, Description, Date_Time, Action });
            dtgActivityLogs.Location = new Point(20, 62);
            dtgActivityLogs.Margin = new Padding(3, 2, 3, 2);
            dtgActivityLogs.Name = "dtgActivityLogs";
            dtgActivityLogs.RowHeadersWidth = 51;
            dtgActivityLogs.Size = new Size(1134, 485);
            dtgActivityLogs.TabIndex = 3;
            dtgActivityLogs.CellContentClick += dtgActivityLogs_CellContentClick;
            // 
            // ActivityLogs_ID
            // 
            ActivityLogs_ID.HeaderText = "ActivityLogs_ID";
            ActivityLogs_ID.MinimumWidth = 6;
            ActivityLogs_ID.Name = "ActivityLogs_ID";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            // 
            // Date_Time
            // 
            Date_Time.HeaderText = "Date & Time";
            Date_Time.MinimumWidth = 6;
            Date_Time.Name = "Date_Time";
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(20, 26);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(176, 31);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Activity Logs";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
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
            Archived.Location = new Point(1038, 552);
            Archived.Name = "Archived";
            Archived.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Archived.Size = new Size(116, 32);
            Archived.TabIndex = 5;
            Archived.Text = "Archived";
            // 
            // UC_ActivityLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Archived);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dtgActivityLogs);
            Controls.Add(txtALSearchBar);
            Margin = new Padding(3, 2, 3, 2);
            Size = new Size(1160, 598);
            ((System.ComponentModel.ISupportInitialize)dtgActivityLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtALSearchBar;
        private DataGridView dtgActivityLogs;
        private DataGridViewTextBoxColumn ActivityLogs_ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Date_Time;
        private DataGridViewTextBoxColumn Action;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button Archived;
    }
}
