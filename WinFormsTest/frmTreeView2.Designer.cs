namespace WinFormsTest
{
    partial class frmTreeView2
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
            TreeNode treeNode1 = new TreeNode("节点11");
            TreeNode treeNode2 = new TreeNode("节点10", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("节点8", new TreeNode[] { treeNode2 });
            TreeNode treeNode4 = new TreeNode("节点9");
            TreeNode treeNode5 = new TreeNode("节点0", new TreeNode[] { treeNode3, treeNode4 });
            TreeNode treeNode6 = new TreeNode("节点3");
            TreeNode treeNode7 = new TreeNode("节点6");
            TreeNode treeNode8 = new TreeNode("节点7");
            TreeNode treeNode9 = new TreeNode("节点4", new TreeNode[] { treeNode7, treeNode8 });
            TreeNode treeNode10 = new TreeNode("节点5");
            TreeNode treeNode11 = new TreeNode("节点1", new TreeNode[] { treeNode6, treeNode9, treeNode10 });
            TreeNode treeNode12 = new TreeNode("节点2");
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.CheckBoxes = true;
            treeView1.Location = new Point(2, 2);
            treeView1.Name = "treeView1";
            treeNode1.Name = "节点11";
            treeNode1.Text = "节点11";
            treeNode2.Name = "节点10";
            treeNode2.Text = "节点10";
            treeNode3.Name = "节点8";
            treeNode3.Text = "节点8";
            treeNode4.Name = "节点9";
            treeNode4.Text = "节点9";
            treeNode5.Name = "节点0";
            treeNode5.Text = "节点0";
            treeNode6.Name = "节点3";
            treeNode6.Text = "节点3";
            treeNode7.Name = "节点6";
            treeNode7.Text = "节点6";
            treeNode8.Name = "节点7";
            treeNode8.Text = "节点7";
            treeNode9.Name = "节点4";
            treeNode9.Text = "节点4";
            treeNode10.Name = "节点5";
            treeNode10.Text = "节点5";
            treeNode11.Name = "节点1";
            treeNode11.Text = "节点1";
            treeNode12.Name = "节点2";
            treeNode12.Text = "节点2";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode5, treeNode11, treeNode12 });
            treeView1.ShowNodeToolTips = true;
            treeView1.Size = new Size(121, 311);
            treeView1.TabIndex = 0;
            treeView1.AfterCheck += treeView1_AfterCheck_1;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick_1;
            // 
            // frmTreeView2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 315);
            Controls.Add(treeView1);
            Name = "frmTreeView2";
            Text = "frmTreeView2";
            Load += frmTreeView2_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
    }
}