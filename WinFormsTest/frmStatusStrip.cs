namespace WinFormsTest
{
    public partial class frmStatusStrip : Form
    {
        public frmStatusStrip()
        {
            InitializeComponent();
        }

        private void frmStatusStrip_Load(object sender, EventArgs e)
        {
            // 创建StatusStrip控件
            StatusStrip statusStrip = new StatusStrip();
            statusStrip.Dock = DockStyle.Bottom;

            // 添加账号信息
            ToolStripStatusLabel accountLabel = new ToolStripStatusLabel();
            accountLabel.Text = "账号: user1";
            statusStrip.Items.Add(accountLabel);

            // 添加角色信息
            ToolStripStatusLabel roleLabel = new ToolStripStatusLabel();
            roleLabel.Text = "角色: 管理员";
            statusStrip.Items.Add(roleLabel);

            // 添加操作位置信息
            ToolStripStatusLabel locationLabel = new ToolStripStatusLabel();
            locationLabel.Text = "操作位置: 主界面";
            statusStrip.Items.Add(locationLabel);

            // 添加进度条
            ToolStripProgressBar progressBar = new ToolStripProgressBar();
            progressBar.Value = 50;
            statusStrip.Items.Add(progressBar);

            // 添加版本信息
            ToolStripStatusLabel versionLabel = new ToolStripStatusLabel();
            versionLabel.Text = "版本: v1.0";
            statusStrip.Items.Add(versionLabel);

            // 将StatusStrip控件添加到窗口的Controls集合中
            this.Controls.Add(statusStrip);
        }
    }
}
