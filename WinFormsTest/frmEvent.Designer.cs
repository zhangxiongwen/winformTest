namespace WinFormsTest
{
    partial class frmEvent
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
            btnEvent = new Button();
            SuspendLayout();
            // 
            // btnEvent
            // 
            btnEvent.Location = new Point(98, 46);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new Size(79, 37);
            btnEvent.TabIndex = 0;
            btnEvent.Text = "事件";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += btnEvent_Click;
            // 
            // frmEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 156);
            Controls.Add(btnEvent);
            Name = "frmEvent";
            Text = "frmEvent";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEvent;
    }
}