namespace WinFormsTest
{
    partial class frmSubmit
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
            rdBasketball = new RadioButton();
            rdPingpang = new RadioButton();
            ckOne = new CheckBox();
            rdTennis = new RadioButton();
            ckTwo = new CheckBox();
            ckThree = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rdFont = new RadioButton();
            rdalgorithm = new RadioButton();
            rdWriter = new RadioButton();
            btnOk = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // rdBasketball
            // 
            rdBasketball.AutoSize = true;
            rdBasketball.Location = new Point(25, 32);
            rdBasketball.Name = "rdBasketball";
            rdBasketball.Size = new Size(55, 24);
            rdBasketball.TabIndex = 0;
            rdBasketball.TabStop = true;
            rdBasketball.Text = "篮球";
            rdBasketball.UseVisualStyleBackColor = true;
            // 
            // rdPingpang
            // 
            rdPingpang.AutoSize = true;
            rdPingpang.Location = new Point(157, 32);
            rdPingpang.Name = "rdPingpang";
            rdPingpang.Size = new Size(69, 24);
            rdPingpang.TabIndex = 1;
            rdPingpang.TabStop = true;
            rdPingpang.Text = "乒乓球";
            rdPingpang.UseVisualStyleBackColor = true;
            // 
            // ckOne
            // 
            ckOne.AutoSize = true;
            ckOne.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            ckOne.Location = new Point(32, 208);
            ckOne.Name = "ckOne";
            ckOne.Size = new Size(70, 24);
            ckOne.TabIndex = 2;
            ckOne.Text = "选择一";
            ckOne.UseVisualStyleBackColor = true;
            // 
            // rdTennis
            // 
            rdTennis.AutoSize = true;
            rdTennis.Location = new Point(292, 32);
            rdTennis.Name = "rdTennis";
            rdTennis.Size = new Size(55, 24);
            rdTennis.TabIndex = 3;
            rdTennis.TabStop = true;
            rdTennis.Text = "网球";
            rdTennis.UseVisualStyleBackColor = true;
            // 
            // ckTwo
            // 
            ckTwo.AutoSize = true;
            ckTwo.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            ckTwo.Location = new Point(177, 208);
            ckTwo.Name = "ckTwo";
            ckTwo.Size = new Size(70, 24);
            ckTwo.TabIndex = 4;
            ckTwo.Text = "选择二";
            ckTwo.UseVisualStyleBackColor = true;
            // 
            // ckThree
            // 
            ckThree.AutoSize = true;
            ckThree.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            ckThree.Location = new Point(333, 208);
            ckThree.Name = "ckThree";
            ckThree.Size = new Size(70, 24);
            ckThree.TabIndex = 5;
            ckThree.Text = "选择三";
            ckThree.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdTennis);
            groupBox1.Controls.Add(rdPingpang);
            groupBox1.Controls.Add(rdBasketball);
            groupBox1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(28, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 76);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "体育活动";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdFont);
            groupBox2.Controls.Add(rdalgorithm);
            groupBox2.Controls.Add(rdWriter);
            groupBox2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(28, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(415, 76);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "擅长领域";
            // 
            // rdFont
            // 
            rdFont.AutoSize = true;
            rdFont.Location = new Point(292, 32);
            rdFont.Name = "rdFont";
            rdFont.Size = new Size(55, 24);
            rdFont.TabIndex = 3;
            rdFont.TabStop = true;
            rdFont.Text = "前端";
            rdFont.UseVisualStyleBackColor = true;
            // 
            // rdalgorithm
            // 
            rdalgorithm.AutoSize = true;
            rdalgorithm.Location = new Point(157, 32);
            rdalgorithm.Name = "rdalgorithm";
            rdalgorithm.Size = new Size(55, 24);
            rdalgorithm.TabIndex = 1;
            rdalgorithm.TabStop = true;
            rdalgorithm.Text = "算法";
            rdalgorithm.UseVisualStyleBackColor = true;
            // 
            // rdWriter
            // 
            rdWriter.AutoSize = true;
            rdWriter.Location = new Point(25, 32);
            rdWriter.Name = "rdWriter";
            rdWriter.Size = new Size(55, 24);
            rdWriter.TabIndex = 0;
            rdWriter.TabStop = true;
            rdWriter.Text = "写作";
            rdWriter.UseVisualStyleBackColor = true;
            rdWriter.CheckedChanged += rdWriter_CheckedChanged;
            rdWriter.Click += rdWriter_Click;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.Location = new Point(238, 242);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 32);
            btnOk.TabIndex = 10;
            btnOk.Text = "提交";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(82, 242);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 32);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmSubmit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 286);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ckThree);
            Controls.Add(ckTwo);
            Controls.Add(ckOne);
            Name = "frmSubmit";
            Text = "选择框";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdBasketball;
        private RadioButton rdPingpang;
        private CheckBox ckOne;
        private RadioButton rdTennis;
        private CheckBox ckTwo;
        private CheckBox ckThree;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rdFont;
        private RadioButton rdalgorithm;
        private RadioButton rdWriter;
        private Button btnOk;
        private Button btnCancel;
    }
}