namespace Administrator
{
    partial class UC_Account
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Account));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            dtgAccount = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            E_Mail = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewTextBoxColumn();
            Archived = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dtgAccount).BeginInit();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.BorderRadius = 10;
            btnAddUser.CustomizableEdges = customizableEdges7;
            btnAddUser.DisabledState.BorderColor = Color.DarkGray;
            btnAddUser.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddUser.FillColor = Color.Black;
            btnAddUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Image = (Image)resources.GetObject("btnAddUser.Image");
            btnAddUser.Location = new Point(1026, 59);
            btnAddUser.Margin = new Padding(3, 2, 3, 2);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAddUser.Size = new Size(125, 32);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 59);
            label1.Name = "label1";
            label1.Size = new Size(257, 31);
            label1.TabIndex = 2;
            label1.Text = "User Information";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderRadius = 10;
            guna2TextBox1.CustomizableEdges = customizableEdges9;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconLeftSize = new Size(25, 25);
            guna2TextBox1.IconRight = (Image)resources.GetObject("guna2TextBox1.IconRight");
            guna2TextBox1.IconRightSize = new Size(25, 25);
            guna2TextBox1.Location = new Point(753, 64);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2TextBox1.Size = new Size(248, 27);
            guna2TextBox1.TabIndex = 4;
            // 
            // dtgAccount
            // 
            dtgAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAccount.Columns.AddRange(new DataGridViewColumn[] { Name, Username, E_Mail, Role, Status, Actions });
            dtgAccount.Location = new Point(17, 96);
            dtgAccount.Margin = new Padding(3, 2, 3, 2);
            dtgAccount.Name = "dtgAccount";
            dtgAccount.RowHeadersWidth = 51;
            dtgAccount.Size = new Size(1134, 540);
            dtgAccount.TabIndex = 5;
            dtgAccount.CellContentClick += dtgAccount_CellContentClick;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            // 
            // E_Mail
            // 
            E_Mail.HeaderText = "E-Mail";
            E_Mail.MinimumWidth = 6;
            E_Mail.Name = "E_Mail";
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.MinimumWidth = 6;
            Actions.Name = "Actions";
            // 
            // Archived
            // 
            Archived.BorderRadius = 10;
            Archived.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            Archived.CustomizableEdges = customizableEdges11;
            Archived.DisabledState.BorderColor = Color.DarkGray;
            Archived.DisabledState.CustomBorderColor = Color.DarkGray;
            Archived.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Archived.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Archived.FillColor = Color.LightGray;
            Archived.Font = new Font("Segoe UI", 9F);
            Archived.ForeColor = Color.Black;
            Archived.Location = new Point(1035, 641);
            Archived.Name = "Archived";
            Archived.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Archived.Size = new Size(116, 32);
            Archived.TabIndex = 7;
            Archived.Text = "Archived";
            // 
            // UC_Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Archived);
            Controls.Add(dtgAccount);
            Controls.Add(guna2TextBox1);
            Controls.Add(label1);
            Controls.Add(btnAddUser);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Size = new Size(1162, 684);
            ((System.ComponentModel.ISupportInitialize)dtgAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private DataGridView dtgAccount;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn E_Mail;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Actions;
        private Guna.UI2.WinForms.Guna2Button Archived;
    }
}
