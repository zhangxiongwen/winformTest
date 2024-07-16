using System.Timers;

namespace WinFormsTest
{
    public partial class frmTimersTimer : Form
    {
        public frmTimersTimer()
        {
            InitializeComponent();
        }

        private void frmTimersTimer_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            //timer3.AutoReset = false;//只会引发一次，就停止了
            timer.Elapsed += Timer_Elapsed; //注册事件
            timer.Start();
        }

        int count = 0;
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // 在委托中修改 UI 元素
            Invoke((Action)(() =>
            {
                // 修改 UI 元素
                label1.Text = "当前时间是:" + DateTime.Now.ToString();
            }));

            count += 1;
            if (count > 10)
            {
                System.Timers.Timer timer = (System.Timers.Timer)sender;
                timer.Stop();
            }
        }
    }
}
