namespace WinFormsTest
{
    partial class FrmUser
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
            txtName = new TextBox();
            btnCancel = new Button();
            btnOk = new Button();
            txtPassword = new TextBox();
            lblName = new Label();
            lblpassword = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(106, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 25);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(32, 118);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 32);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btn_Click;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.Location = new Point(188, 118);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 32);
            btnOk.TabIndex = 2;
            btnOk.Text = "确认";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += button2_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(106, 72);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(176, 25);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(49, 22);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 20);
            lblName.TabIndex = 4;
            lblName.Text = "账号：";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblpassword.Location = new Point(49, 75);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(51, 20);
            lblpassword.TabIndex = 5;
            lblpassword.Text = "密码：";
            // 
            // FrmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 172);
            Controls.Add(lblpassword);
            Controls.Add(lblName);
            Controls.Add(txtPassword);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(txtName);
            Name = "FrmUser";
            Text = "登录";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Button btnCancel;
        private Button btnOk;
        private TextBox txtPassword;
        private Label lblName;
        private Label lblpassword;
    }
}