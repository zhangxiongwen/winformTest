namespace WinFormsTest
{
    partial class frmDelegate
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
            btnDelegate = new Button();
            SuspendLayout();
            // 
            // btnDelegate
            // 
            btnDelegate.Location = new Point(117, 36);
            btnDelegate.Name = "btnDelegate";
            btnDelegate.Size = new Size(120, 35);
            btnDelegate.TabIndex = 0;
            btnDelegate.Text = "委托";
            btnDelegate.UseVisualStyleBackColor = true;
            btnDelegate.Click += btnDelegate_Click;
            // 
            // delegateAndevent
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 129);
            Controls.Add(btnDelegate);
            Name = "delegateAndevent";
            Text = "delegateAndevent";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDelegate;
    }
}