namespace WinFormsTest
{
    partial class FrmNumericUpDown
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
            numericUpDown1 = new NumericUpDown();
            btnSubtraction = new Button();
            btnAdd = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(123, 64);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(171, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnSubtraction
            // 
            btnSubtraction.Location = new Point(85, 168);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(75, 23);
            btnSubtraction.TabIndex = 1;
            btnSubtraction.Text = "-";
            btnSubtraction.UseVisualStyleBackColor = true;
            btnSubtraction.Click += btnSubtraction_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(250, 168);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 3;
            // 
            // FrmNumericUpDown
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 271);
            Controls.Add(textBox1);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtraction);
            Controls.Add(numericUpDown1);
            Name = "FrmNumericUpDown";
            Text = "FrmNumericUpDown";
            Load += FrmNumericUpDown_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Button btnSubtraction;
        private Button btnAdd;
        private TextBox textBox1;
    }
}