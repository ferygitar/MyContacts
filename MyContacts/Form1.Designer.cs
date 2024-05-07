namespace MyContacts
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btnNewContact = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnEdit = new Button();
            dgContacts = new DataGridView();
            ContactID = new DataGridViewTextBoxColumn();
            ContactName = new DataGridViewTextBoxColumn();
            Family = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Mobile = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgContacts).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNewContact, btnRefresh });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(789, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNewContact
            // 
            btnNewContact.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNewContact.Image = (Image)resources.GetObject("btnNewContact.Image");
            btnNewContact.ImageTransparentColor = Color.Magenta;
            btnNewContact.Name = "btnNewContact";
            btnNewContact.Size = new Size(106, 22);
            btnNewContact.Text = "افزودن شخص جدید";
            btnNewContact.Click += btnNewContact_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(60, 22);
            btnRefresh.Text = "بروزرسانی";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(7, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 77);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(dgContacts);
            groupBox2.Location = new Point(8, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 367);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "لیست";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(614, 336);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(695, 334);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 27);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // dgContacts
            // 
            dgContacts.AllowUserToAddRows = false;
            dgContacts.AllowUserToDeleteRows = false;
            dgContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgContacts.Columns.AddRange(new DataGridViewColumn[] { ContactID, ContactName, Family, Email, Mobile, Age });
            dgContacts.Location = new Point(6, 22);
            dgContacts.MultiSelect = false;
            dgContacts.Name = "dgContacts";
            dgContacts.ReadOnly = true;
            dgContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgContacts.Size = new Size(764, 306);
            dgContacts.TabIndex = 0;
            // 
            // ContactID
            // 
            ContactID.DataPropertyName = "ContactID";
            ContactID.HeaderText = "کد شخص";
            ContactID.Name = "ContactID";
            ContactID.ReadOnly = true;
            ContactID.Visible = false;
            // 
            // ContactName
            // 
            ContactName.DataPropertyName = "Name";
            ContactName.HeaderText = "نام";
            ContactName.Name = "ContactName";
            ContactName.ReadOnly = true;
            // 
            // Family
            // 
            Family.DataPropertyName = "Family";
            Family.HeaderText = "نام خانوادگی";
            Family.Name = "Family";
            Family.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "ایمیل";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Mobile
            // 
            Mobile.DataPropertyName = "Mobile";
            Mobile.HeaderText = "موبایل";
            Mobile.Name = "Mobile";
            Mobile.ReadOnly = true;
            // 
            // Age
            // 
            Age.DataPropertyName = "Age";
            Age.HeaderText = "سن";
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 485);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "دفترچه تلفن من";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgContacts;
        private ToolStripButton btnNewContact;
        private ToolStripButton btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridViewTextBoxColumn ContactID;
        private DataGridViewTextBoxColumn ContactName;
        private DataGridViewTextBoxColumn Family;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Mobile;
        private DataGridViewTextBoxColumn Age;
    }
}
