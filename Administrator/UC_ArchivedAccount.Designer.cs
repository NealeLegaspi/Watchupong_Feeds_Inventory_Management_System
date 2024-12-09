namespace Administrator
{
    partial class UC_ArchivedAccount
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            cmbArchived = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 23);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 0;
            label1.Text = "Archived";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1131, 505);
            dataGridView1.TabIndex = 1;
            // 
            // cmbArchived
            // 
            cmbArchived.BackColor = Color.Transparent;
            cmbArchived.CustomizableEdges = customizableEdges1;
            cmbArchived.DrawMode = DrawMode.OwnerDrawFixed;
            cmbArchived.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArchived.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbArchived.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbArchived.Font = new Font("Segoe UI", 10F);
            cmbArchived.ForeColor = Color.FromArgb(68, 88, 112);
            cmbArchived.ItemHeight = 30;
            cmbArchived.Location = new Point(988, 23);
            cmbArchived.Name = "cmbArchived";
            cmbArchived.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbArchived.Size = new Size(156, 36);
            cmbArchived.TabIndex = 2;
            // 
            // UC_ArchivedAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbArchived);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "UC_ArchivedAccount";
            Size = new Size(1160, 598);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbArchived;
    }
}
