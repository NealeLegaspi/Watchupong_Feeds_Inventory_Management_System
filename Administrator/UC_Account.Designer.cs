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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Account));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            Archived = new Guna.UI2.WinForms.Guna2Button();
            dtgAccount = new DataGridView();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dtgAccount).BeginInit();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.BorderRadius = 10;
            btnAddUser.CustomizableEdges = customizableEdges11;
            btnAddUser.DisabledState.BorderColor = Color.DarkGray;
            btnAddUser.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddUser.FillColor = Color.Black;
            btnAddUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Image = (Image)resources.GetObject("btnAddUser.Image");
            btnAddUser.Location = new Point(1026, 22);
            btnAddUser.Margin = new Padding(3, 2, 3, 2);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAddUser.Size = new Size(125, 32);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add User";
            btnAddUser.Click += btnAddUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(127, 31);
            label1.TabIndex = 2;
            label1.Text = "Account";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderRadius = 10;
            guna2TextBox1.CustomizableEdges = customizableEdges13;
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
            guna2TextBox1.Location = new Point(718, 27);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2TextBox1.Size = new Size(248, 27);
            guna2TextBox1.TabIndex = 4;
            // 
            // Archived
            // 
            Archived.BorderRadius = 10;
            Archived.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            Archived.CustomizableEdges = customizableEdges15;
            Archived.DisabledState.BorderColor = Color.DarkGray;
            Archived.DisabledState.CustomBorderColor = Color.DarkGray;
            Archived.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Archived.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Archived.FillColor = Color.LightGray;
            Archived.Font = new Font("Segoe UI", 9F);
            Archived.ForeColor = Color.Black;
            Archived.Location = new Point(17, 550);
            Archived.Name = "Archived";
            Archived.ShadowDecoration.CustomizableEdges = customizableEdges16;
            Archived.Size = new Size(116, 32);
            Archived.TabIndex = 7;
            Archived.Text = "Archived";
            // 
            // dtgAccount
            // 
            dtgAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAccount.Location = new Point(17, 56);
            dtgAccount.Name = "dtgAccount";
            dtgAccount.Size = new Size(1124, 474);
            dtgAccount.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 10;
            btnDelete.CustomizableEdges = customizableEdges17;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(913, 550);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnDelete.Size = new Size(106, 32);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BorderRadius = 10;
            btnEdit.CustomizableEdges = customizableEdges19;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.Lime;
            btnEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(1035, 550);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnEdit.Size = new Size(106, 32);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // UC_Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dtgAccount);
            Controls.Add(Archived);
            Controls.Add(guna2TextBox1);
            Controls.Add(label1);
            Controls.Add(btnAddUser);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Account";
            Size = new Size(1160, 598);
            Load += UC_Account_Load;
            ((System.ComponentModel.ISupportInitialize)dtgAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button Archived;
        private DataGridView dtgAccount;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
    }
}
