namespace WinFormsTest
{
    partial class frmProgressBar
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
            components = new System.ComponentModel.Container();
            labText = new Label();
            textBox1 = new TextBox();
            pbrData = new ProgressBar();
            btnLoad = new Button();
            btnPause = new Button();
            btnContinue = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // labText
            // 
            labText.AutoSize = true;
            labText.Location = new Point(73, 36);
            labText.Name = "labText";
            labText.Size = new Size(104, 17);
            labText.TabIndex = 0;
            labText.Text = "进度条最大长度：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // pbrData
            // 
            pbrData.Location = new Point(73, 95);
            pbrData.Name = "pbrData";
            pbrData.Size = new Size(237, 23);
            pbrData.Step = 1;
            pbrData.Style = ProgressBarStyle.Continuous;
            pbrData.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(41, 146);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(73, 31);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "加载";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(138, 146);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(78, 31);
            btnPause.TabIndex = 4;
            btnPause.Text = "暂停";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(251, 146);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(74, 31);
            btnContinue.TabIndex = 5;
            btnContinue.Text = "继续";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 75);
            label1.Name = "label1";
            label1.Size = new Size(26, 17);
            label1.TabIndex = 6;
            label1.Text = "0%";
            label1.Visible = false;
            // 
            // frmProgressBar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 202);
            Controls.Add(label1);
            Controls.Add(btnContinue);
            Controls.Add(btnPause);
            Controls.Add(btnLoad);
            Controls.Add(pbrData);
            Controls.Add(textBox1);
            Controls.Add(labText);
            Name = "frmProgressBar";
            Text = "frmProgressBar";
            Load += frmProgressBar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labText;
        private TextBox textBox1;
        private ProgressBar pbrData;
        private Button btnLoad;
        private Button btnPause;
        private Button btnContinue;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}