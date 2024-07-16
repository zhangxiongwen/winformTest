namespace WinFormsTest
{
    partial class frmContextMenuStrip
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            BackgroundColorToolStripMenuItem = new ToolStripMenuItem();
            RedToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            LoginToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            contextMenuStrip2 = new ContextMenuStrip(components);
            改字体颜色ToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { BackgroundColorToolStripMenuItem, LoginToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(113, 48);
            // 
            // BackgroundColorToolStripMenuItem
            // 
            BackgroundColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RedToolStripMenuItem, greenToolStripMenuItem });
            BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem";
            BackgroundColorToolStripMenuItem.Size = new Size(112, 22);
            BackgroundColorToolStripMenuItem.Text = "换背景";
            // 
            // RedToolStripMenuItem
            // 
            RedToolStripMenuItem.Name = "RedToolStripMenuItem";
            RedToolStripMenuItem.Size = new Size(100, 22);
            RedToolStripMenuItem.Text = "红色";
            RedToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(100, 22);
            greenToolStripMenuItem.Text = "绿色";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // LoginToolStripMenuItem
            // 
            LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            LoginToolStripMenuItem.Size = new Size(112, 22);
            LoginToolStripMenuItem.Text = "登录";
            LoginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.ContextMenuStrip = contextMenuStrip2;
            button1.Location = new Point(273, 234);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { 改字体颜色ToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(137, 26);
            // 
            // 改字体颜色ToolStripMenuItem
            // 
            改字体颜色ToolStripMenuItem.Name = "改字体颜色ToolStripMenuItem";
            改字体颜色ToolStripMenuItem.Size = new Size(136, 22);
            改字体颜色ToolStripMenuItem.Text = "改字体颜色";
            改字体颜色ToolStripMenuItem.Click += 改字体颜色ToolStripMenuItem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(114, 234);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmContextMenuStrip
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 328);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(button2);
            Controls.Add(button1);
            IsMdiContainer = true;
            Name = "frmContextMenuStrip";
            Text = "frmContextMenuStrip";
            Load += ContextMenuStrip_Load;
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem BackgroundColorToolStripMenuItem;
        private ToolStripMenuItem LoginToolStripMenuItem;
        private ToolStripMenuItem RedToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private Button button1;
        private Button button2;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem 改字体颜色ToolStripMenuItem;
    }
}