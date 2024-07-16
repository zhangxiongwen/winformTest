namespace WinFormsTest
{
    public partial class frmContextMenuStrip : Form
    {
        public frmContextMenuStrip()
        {
            InitializeComponent();
        }

        private void ContextMenuStrip_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser fAddStudent = new FrmUser();
            fAddStudent.MdiParent = this;//设置当前窗体的父窗体
            fAddStudent.Show();//Mdi容器不支持ShowDialog()
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
        }

        private void 改字体颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }
    }
}
