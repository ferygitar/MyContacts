namespace MyContacts
{
    partial class frmAddOrEdit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnSubmit = new Button();
            txtAge = new NumericUpDown();
            txtEmail = new TextBox();
            txtMobile = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFamily = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtMobile);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtFamily);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات فرد";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(417, 147);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(44, 23);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "ثبت";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(13, 55);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(147, 23);
            txtAge.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(13, 83);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(397, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(263, 54);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(147, 23);
            txtMobile.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(263, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(147, 23);
            txtName.TabIndex = 0;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(13, 112);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(397, 58);
            txtAddress.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 115);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 1;
            label6.Text = "آدرس :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 57);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 1;
            label4.Text = "سن :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 57);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 0;
            label5.Text = "موبایل :";
            // 
            // txtFamily
            // 
            txtFamily.Location = new Point(13, 25);
            txtFamily.Name = "txtFamily";
            txtFamily.Size = new Size(147, 23);
            txtFamily.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 86);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "ایمیل :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 28);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "نام خانوادگی :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 28);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "نام :";
            // 
            // frmAddOrEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 201);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAddOrEdit";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Load += frmAddOrEdit_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnSubmit;
        private NumericUpDown txtAge;
        private TextBox txtEmail;
        private TextBox txtMobile;
        private TextBox txtName;
        private TextBox txtAddress;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox txtFamily;
        private Label label3;
        private Label label2;
    }
}