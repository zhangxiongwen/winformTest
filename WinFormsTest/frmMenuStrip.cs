namespace WinFormsTest
{
    public partial class frmMenuStrip : Form
    {
        public frmMenuStrip()
        {
            InitializeComponent();
        }

        private void frmMenuStrip_Load(object sender, EventArgs e)
        {
            //代码添加菜单项
            ToolStripMenuItem miStudent = new ToolStripMenuItem();
            miStudent.Name = "miStudent";
            miStudent.Text = "学生管理(&M)";
            //它下面还有子菜单 
            ToolStripMenuItem miAddStudent = new ToolStripMenuItem();
            miAddStudent.Name = "miAddStudent";
            miAddStudent.Text = "新增学生";
            miAddStudent.Click += MiAddStudent_Click;
            miStudent.DropDownItems.Add(miAddStudent);//添加子菜单

            menuStrip1.Items.Add(miStudent); //添加主菜单


            menuStrip1.Items[0].MouseHover += FrmContextMenuStrip_MouseHover; //鼠标悬停展开，不用点击


        }

        private void FrmContextMenuStrip_MouseHover(object sender, EventArgs e)
        {
            if (sender is ToolStripDropDownItem)
            {
                ToolStripDropDownItem item = sender as ToolStripDropDownItem;
                if (item.HasDropDownItems && !item.DropDown.Visible)
                {
                    item.ShowDropDown();
                }
            }
        }


        private void MiAddStudent_Click(object sender, EventArgs e)
        {
            FrmUser fAddStudent = new FrmUser();
            fAddStudent.MdiParent = this;//设置当前窗体的父窗体
            fAddStudent.Show();//Mdi容器不支持ShowDialog()
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListView fAddStudent = new frmListView();
            fAddStudent.MdiParent = this;//设置当前窗体的父窗体
            fAddStudent.Show();//Mdi容器不支持ShowDialog()
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProgressBar fAddStudent = new frmProgressBar();
            fAddStudent.MdiParent = this;//设置当前窗体的父窗体
            fAddStudent.Show();//Mdi容器不支持ShowDialog()
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
