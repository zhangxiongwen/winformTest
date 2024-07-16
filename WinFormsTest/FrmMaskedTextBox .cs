namespace WinFormsTest
{
    public partial class FrmMaskedTextBox : Form
    {
        public FrmMaskedTextBox()
        {
            InitializeComponent();
        }

        private void FrmMaskedTextBox_Load(object sender, EventArgs e)
        {
            maskedTextBox1.BeepOnError = true;//输入错误提示音
            // 设置掩码为电话号码格式
            maskedTextBox1.Mask = "(999) 000-0000";
            // 设置 PromptChar 为一个空格，以便在用户输入时自动填充占位符
            maskedTextBox1.PromptChar = ' ';
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (e.Position < 0)
            {
                MessageBox.Show("输入不足以满足格式要求", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("无效字符位于 " + e.Position + " 位置", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
