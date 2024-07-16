namespace WinFormsTest
{
    partial class frmComboBox
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
            cobName = new ComboBox();
            SuspendLayout();
            // 
            // cobName
            // 
            cobName.FormattingEnabled = true;
            cobName.Location = new Point(109, 55);
            cobName.Name = "cobName";
            cobName.Size = new Size(121, 25);
            cobName.TabIndex = 0;
            cobName.SelectedIndexChanged += cobName_SelectedIndexChanged;
            // 
            // frmComboBox
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 255);
            Controls.Add(cobName);
            Name = "frmComboBox";
            Text = "frmComboBox";
            Load += frmComboBox_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cobName;
    }
}