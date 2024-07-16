namespace WinFormsTest
{
    public partial class frmTabControl : Form
    {
        public frmTabControl()
        {
            InitializeComponent();
        }

        private void frmTabControl_Load(object sender, EventArgs e)
        {
            // 创建一个TabControl
            TabControl tabControl = new TabControl();
            tabControl.Location = new Point(10, 10);
            tabControl.Size = new Size(400, 300);
            this.Controls.Add(tabControl);

            // 创建第一个TabPage
            TabPage tabPage1 = new TabPage();
            tabPage1.Text = "页面1";
            tabControl.TabPages.Add(tabPage1);

            // 在第一个TabPage中添加控件
            Label label1 = new Label();
            label1.Text = "这是第一页";
            label1.Location = new Point(10, 10);
            tabPage1.Controls.Add(label1);

            // 创建第二个TabPage
            TabPage tabPage2 = new TabPage();
            tabPage2.Text = "页面2";
            tabControl.TabPages.Add(tabPage2);

            // 在第二个TabPage中添加控件
            Label label2 = new Label();
            label2.Text = "这是第二页";
            label2.Location = new Point(10, 10);
            tabPage2.Controls.Add(label2);

            // 添加选项卡切换事件
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            MessageBox.Show("切换到了" + tabControl.SelectedTab.Text);
        }
    }
}
