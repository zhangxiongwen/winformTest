namespace WinFormsTest
{
    partial class frmCheckedListBox
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
            cklLList = new CheckedListBox();
            SuspendLayout();
            // 
            // cklLList
            // 
            cklLList.FormattingEnabled = true;
            cklLList.Location = new Point(12, 12);
            cklLList.Name = "cklLList";
            cklLList.Size = new Size(213, 94);
            cklLList.TabIndex = 0;
            cklLList.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // frmCheckedListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 198);
            Controls.Add(cklLList);
            Name = "frmCheckedListBox";
            Text = "frmCheckedListBox";
            Load += frmCheckedListBox_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox cklLList;
    }
}