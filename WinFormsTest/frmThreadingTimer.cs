namespace WinFormsTest
{
    public partial class frmThreadingTimer : Form
    {
        public frmThreadingTimer()
        {
            InitializeComponent();
        }
        int count = 0;
        System.Threading.Timer threadTimer;
        private void frmThreadingTimer_Load(object sender, EventArgs e)
        {
            //多线程
            //period  时间间隔  0或-1 只会执行一 次，然后就停止
            //Change 可以让计时器重新启动
            //停止 period  0 -1   timer4.Dispose() 
            threadTimer = new System.Threading.Timer(new System.Threading.TimerCallback(oo =>
            {
                count += 1;
                Action<int> act = ChangeCount; //定义一个委托
                this.Invoke(act, count);
            }), null, 0, 1000);

            //threadTimer.Change(2000, 2000);//改变延迟启动时间和时间间隔
        }
        private void ChangeCount(int count)
        {
            label1.Text = count.ToString();
            label2.Text = (count * 2).ToString();
            if (count > 10)
                threadTimer.Dispose();//计算十次后自动停止
        }
    }
}
