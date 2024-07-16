namespace WinFormsTest
{
    public partial class frmSplitContainer : Form
    {
        public frmSplitContainer()
        {
            InitializeComponent();
        }

        private void frmSplitContainer_Load(object sender, EventArgs e)
        {
            // 创建一个SplitContainer控件
            SplitContainer splitContainer1 = new SplitContainer();
            splitContainer1.Location = new Point(10, 10);
            splitContainer1.Size = new Size(400, 300);
            this.Controls.Add(splitContainer1);

            // 设置SplitContainer1的属性
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = false;
            splitContainer1.Orientation = Orientation.Vertical;
            splitContainer1.SplitterDistance = 150;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.SplitterIncrement = 10;

            // 在SplitContainer1的Panel1中添加一个SplitContainer控件
            SplitContainer splitContainer2 = new SplitContainer();
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Size = new Size(150, 300);
            splitContainer1.Panel1.Controls.Add(splitContainer2); // 将SplitContainer2控件添加到SplitContainer1的Panel1中

            // 设置SplitContainer2的属性
            splitContainer2.FixedPanel = FixedPanel.Panel2;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = false;
            splitContainer2.Orientation = Orientation.Horizontal;
            splitContainer2.SplitterDistance = 150;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.SplitterIncrement = 10;

            // 在SplitContainer1的Panel2中添加控件
            Label label1 = new Label();
            label1.Text = "这是右边的面板";
            label1.Location = new Point(10, 10);
            splitContainer1.Panel2.Controls.Add(label1);

            // 在SplitContainer2的Panel1中添加控件
            Label label2 = new Label();
            label2.Text = "这是左上的面板";
            label2.Location = new Point(10, 10);
            splitContainer2.Panel1.Controls.Add(label2);

            // 在SplitContainer2的Panel2中添加控件
            Label label3 = new Label();
            label3.Text = "这是左下的面板";
            label3.Location = new Point(10, 10);
            splitContainer2.Panel2.Controls.Add(label3);

            // 添加 SplitterPaint 事件处理器
            splitContainer1.Paint += (sender, e) =>
            {
                // 绘制边界框
                Rectangle rect = splitContainer1.SplitterRectangle;
                using (Pen pen = new Pen(Color.Red, 2))  // 创建一个红色的画笔，线宽为2
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            };
            // 添加 SplitterPaint 事件处理器
            splitContainer2.Paint += (sender, e) =>
            {
                // 绘制边界框
                Rectangle rect = splitContainer2.SplitterRectangle;
                using (Pen pen = new Pen(Color.Green, 2))  // 创建一个红色的画笔，线宽为2
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            };
        }
    }
}
