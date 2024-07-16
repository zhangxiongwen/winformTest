namespace WinFormsTest
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void frmProgressBar_Load(object sender, EventArgs e)
        {
            //pbrData.MarqueeAnimationSpeed = 0;//滚动的速度
            //pbrData.Style = ProgressBarStyle.Marquee;
            pbrData.Style = ProgressBarStyle.Continuous;
            pbrData.Maximum = 100;
            pbrData.Minimum = 0;
            pbrData.Value = 0;
            pbrData.Step = 1;
        }
        double count = 0;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //pbrData.MarqueeAnimationSpeed = 1000;//滚动的速度
            pbrData.Maximum = string.IsNullOrWhiteSpace(textBox1.Text) ? 100 : Convert.ToInt16(textBox1.Text);
            label1.Visible = true;
            timer1.Interval = 1000;//计时器每秒执行一次
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 当进度条的值达到最大值时，停止定时器
            if (pbrData.Value >= pbrData.Maximum)
            {
                timer1.Enabled = false;
                MessageBox.Show("加载完毕！");
            }
            else
            {
                count += pbrData.Step;
                pbrData.PerformStep();  // 进度条增加一个步长
                label1.Text = Convert.ToString(Convert.ToInt32((count / pbrData.Maximum) * 100)) + "%";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 判断输入的字符是否为数字或控制字符（如退格键）
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // 设置Handled为true，表示事件已处理，不再继续处理该字符的输入
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
