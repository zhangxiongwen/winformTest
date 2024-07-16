namespace WinFormsTest
{
    /// <summary>
    /// https://www.bilibili.com/video/BV1E14y1C7sm/?spm_id_from=333.337.search-card.all.click&vd_source=c17a6596481e29f0ffac1a21a026abff
    /// 委托有什么用？
    /// 1.将方法作为参数进行传递，有利于方法的解耦和隔离
    /// 2.声明事件并进行注册
    /// 定义委托的格式
    /// 1.声明委托类型
    /// 2.必须有一个方法包含了要执行的代码，这个方法必须符合委托类型签名
    /// 3.创建一个委托实例
    /// 4.必须调用invoke委托实例
    /// </summary>
    delegate void MyDelegate(); //定义一个委托，无参数和返回值
    delegate string MyDelegate2(int a, int b);
    public partial class frmDelegate : Form
    {
        public frmDelegate()
        {
            InitializeComponent();
            //Type type = typeof(myDelegate);
            //if (type.IsClass) MessageBox.Show("这是一个类");
            //MyDelegate myDelegate = new MyDelegate(Method1);
            ////下面两种方法都可以到委托中调用新的方法
            //MyDelegate myDelegate2 = new MyDelegate(Method2);
            //myDelegate += myDelegate2;
            ////myDelegate += Method2; //在委托中添加方法
            ////myDelegate -= Method2; //在委托中去除方法
            //myDelegate.Invoke();

            string result1 = myCal(5, 5, Add);
            string result2 = myCal(5, 5, Multiple);
            //MessageBox.Show(result1 + "..........." + result2);
        }

        void Method1()
        {
            MessageBox.Show("调用了方法1");
        }
        void Method2()
        {
            MessageBox.Show("调用了方法2");
        }

        String myCal(int a, int b, MyDelegate2 myDelegate)
        {
            return myDelegate(a, b);
        }

        //没有定义方法的修饰符时，private为默认，如果与namespace为同一级时则internal为默认
        string Add(int a, int b)
        {
            return (a + b).ToString();
        }
        string Multiple(int a, int b)
        {
            return (a * b).ToString();
        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            //C#中的两种强委托类型 Action<T1> , Func<T1,T2,T3,Tresult>
            //Action 不返回值的委托类型 ，最多输入一个参数
            Action<string> aa1 = (string a) => { MessageBox.Show(a + "强委托类型 Action<T1>，第一次"); }; //使用lambda表达式
            Action<string> aa2 = a => { MessageBox.Show(a + "强委托类型 Action<T1>,第二次"); }; //使用lambda表达式
            aa1 += aa2;
            aa1.Invoke("使用了：");


            //Func<T1,T2,T3,Tresult>
            Func<string, string> func = h => h + "强委托类型 Func<T1,T2,T3,Tresult>,第一次";//使用lambda表达式
            Func<string, string, string> func2 = (h, b) => h + "强委托类型 Func<T1,T2,T3,Tresult>" + b;//使用lambda表达式
            //func += func2; //会报错，同一种参数的委托才可以
            string funcResult1 = func.Invoke("使用了：");
            string funcResult2 = func2.Invoke("使用了：", "第二次");
            MessageBox.Show(funcResult1);
            MessageBox.Show(funcResult2);
        }

    }
}
