namespace WinFormsTest
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private void frmTimer_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "当前的时间是：" + DateTime.Now.ToString();
        }
    }
}
