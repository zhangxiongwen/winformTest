namespace WinFormsTest
{
    partial class frmMenuStrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuStrip));
            menuStrip1 = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            NewFileToolStripMenuItem = new ToolStripMenuItem();
            ImportToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            PrintToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            ViewToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripTextBox1 = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, EditToolStripMenuItem, ViewToolStripMenuItem, toolStripComboBox1, toolStripTextBox1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewFileToolStripMenuItem, ImportToolStripMenuItem, exportToolStripMenuItem, PrintToolStripMenuItem });
            FileToolStripMenuItem.Image = (Image)resources.GetObject("FileToolStripMenuItem.Image");
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(76, 25);
            FileToolStripMenuItem.Text = "文件(&A)";
            // 
            // NewFileToolStripMenuItem
            // 
            NewFileToolStripMenuItem.Image = (Image)resources.GetObject("NewFileToolStripMenuItem.Image");
            NewFileToolStripMenuItem.Name = "NewFileToolStripMenuItem";
            NewFileToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.B;
            NewFileToolStripMenuItem.Size = new Size(146, 22);
            NewFileToolStripMenuItem.Text = "新建";
            // 
            // ImportToolStripMenuItem
            // 
            ImportToolStripMenuItem.Image = (Image)resources.GetObject("ImportToolStripMenuItem.Image");
            ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            ImportToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            ImportToolStripMenuItem.Size = new Size(146, 22);
            ImportToolStripMenuItem.Text = "导入";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Image = (Image)resources.GetObject("exportToolStripMenuItem.Image");
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(146, 22);
            exportToolStripMenuItem.Text = "导出";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // PrintToolStripMenuItem
            // 
            PrintToolStripMenuItem.Image = (Image)resources.GetObject("PrintToolStripMenuItem.Image");
            PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            PrintToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            PrintToolStripMenuItem.Size = new Size(146, 22);
            PrintToolStripMenuItem.Text = "打印";
            PrintToolStripMenuItem.Click += 打印ToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            EditToolStripMenuItem.Size = new Size(59, 25);
            EditToolStripMenuItem.Text = "编辑(&E)";
            // 
            // ViewToolStripMenuItem
            // 
            ViewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            ViewToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            ViewToolStripMenuItem.Size = new Size(58, 25);
            ViewToolStripMenuItem.Text = "视图(&F)";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(97, 22);
            toolStripMenuItem2.Text = "111";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(97, 22);
            toolStripMenuItem3.Text = "222";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(97, 22);
            toolStripMenuItem4.Text = "223";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 25);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 25);
            // 
            // frmMenuStrip
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMenuStrip";
            Text = "frmMenuStrip";
            Load += frmMenuStrip_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem NewFileToolStripMenuItem;
        private ToolStripMenuItem ImportToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem ViewToolStripMenuItem;
        private ToolStripMenuItem PrintToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripTextBox toolStripTextBox1;
    }
}