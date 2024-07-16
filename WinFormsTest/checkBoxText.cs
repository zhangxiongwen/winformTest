namespace WinFormsTest
{
    public partial class frmSubmit : Form
    {
        public frmSubmit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("提交成功！", "提交完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void rdWriter_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定切换吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // 判断用户的选择
            if (result == DialogResult.OK)
            {
                // 用户选择了 OK，执行相应的操作
                // 这里可以放置你想要执行的代码
            }
            else if (result == DialogResult.Cancel)
            {
                // 用户选择了 Cancel，可以选择不执行任何操作
                // 或者放置一些取消操作的代码
            }

        }

        private void rdWriter_Click(object sender, EventArgs e)
        {
            string bb = "0";
            bool AA = rdWriter.Checked;
            if (AA) { bb = "1"; }
            MessageBox.Show(bb, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
