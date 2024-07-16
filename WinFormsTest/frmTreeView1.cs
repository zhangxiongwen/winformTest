namespace WinFormsTest
{
    public partial class frmTreeView1 : Form
    {
        public frmTreeView1()
        {
            InitializeComponent();
        }

        private void frmTreeView_Load(object sender, EventArgs e)
        {
            TreeView fileTree = new TreeView();
            // 单独设置 Width 和 Height
            fileTree.Width = 200;  // 设置宽度为200像素
            fileTree.Height = 600; // 设置高度为400像素

            // 或者使用 Size 属性同时设置宽度和高度
            fileTree.Size = new Size(200, 300); // 宽度200像素，高度400像素
            // 开始更新节点，防止在添加节点时进行重绘
            fileTree.BeginUpdate();
            TreeNode rootNode = new TreeNode("我的电脑");
            fileTree.Nodes.Add(rootNode);
            // 添加几个文件夹作为子节点
            TreeNode documentsNode = new TreeNode("文档");
            TreeNode picturesNode = new TreeNode("图片");
            TreeNode musicNode = new TreeNode("音乐");
            TreeNode videoNode = new TreeNode("视频");
            rootNode.Nodes.Add(documentsNode);
            rootNode.Nodes.Add(picturesNode);
            rootNode.Nodes.Add(musicNode);
            rootNode.Nodes.Add(videoNode);
            // 完成节点添加后，恢复控件的绘制
            fileTree.EndUpdate();
            fileTree.AfterSelect += new TreeViewEventHandler(fileTree_AfterSelect);
            this.Controls.Add(fileTree);
        }
        private void fileTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text != "我的电脑")
            {
                // 当用户选择一个节点时，显示选中节点的信息
                MessageBox.Show("选中的文件夹: " + e.Node.Text);
            }
        }
    }
}
