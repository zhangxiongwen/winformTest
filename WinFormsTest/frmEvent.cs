namespace WinFormsTest
{
    public partial class frmEvent : Form
    {
        /// <summary>
        ///事件的作用
        ///希望一个类的某些成员在发生某些变化时能够被外界观测到
        ///
        /// 什么是事件？
        /// 事件是委托的实例，限定了执行时的权限，只能在事件所在类的内部执行
        /// 事件虽然是public，但是只能在类的内部被调用，因此需要在类的内部定义事件触发的方法
        /// 
        /// 
        /// 定义事件的步骤
        /// 1.定义事件的委托类型
        /// 2.在类的内部声明事件
        /// 3.声明事件
        /// </summary>

        //定义警报委托 
        public delegate void AlarmEventHandle();
        internal class Alarm
        {
            public event AlarmEventHandle AlarmRaised; //在类的内部声明了一个事件
            public void ShowAlarm()
            {
                MessageBox.Show("1.警报响起！");
                Thread.Sleep(1000);
            }

            //定义事件触发的方法
            public void OnAlarmRaised()
            {
                //if (AlarmRaised != null)
                //{
                //    //AlarmRaised();
                //    AlarmRaised.Invoke();
                //}
                AlarmRaised?.Invoke();//上面if的写法等于这个
            }
        }

        public frmEvent()
        {
            InitializeComponent();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            Alarm alarm = new Alarm(); //事件声明，然后订阅方法
            alarm.AlarmRaised += alarm.ShowAlarm;
            alarm.AlarmRaised += new Person().processAlarm;
            alarm.AlarmRaised += () => { MessageBox.Show("3.马上处理结束...."); Thread.Sleep(1000); };
            alarm.AlarmRaised += Method1;
            //alarm.AlarmRaised -= Method1; //-=订阅移除

            alarm.OnAlarmRaised();//触发事件
        }
        void Method1()
        {
            MessageBox.Show("4.处理完成!");
            Thread.Sleep(1000);
        }

        public class Person
        {
            public void processAlarm()
            {
                MessageBox.Show("2.正在处理中.....");
                Thread.Sleep(1000);
            }
        }
    }
}
