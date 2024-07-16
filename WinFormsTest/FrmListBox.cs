namespace WinFormsTest
{
    public partial class FrmListBox : Form
    {
        public FrmListBox()
        {
            InitializeComponent();
        }

        private void FrmListBox_Load(object sender, EventArgs e)
        {
            //项的清除
            listBox1.Items.Clear();
            ////避免控件闪烁的问题
            //listBox1.BeginUpdate();//闪烁
            ////for循环等加载大量的项 

            //listBox1.EndUpdate();
            ////添加项
            //listBox1.Items.Add(123);
            //listBox1.Items.Add("jason");
            //string[] list = { "adbc", "admin", "sqlserver" };
            //listBox1.Items.AddRange(list);

            //listBox1.Items.Insert(3, "micosoft");

            //int index = listBox1.Items.IndexOf("admin");//获取索引
            //bool bl = listBox1.Items.Contains("sqlserver");//存在
            //listBox1.Items.Remove("admin");
            //listBox1.Items.RemoveAt(3);

            List<UserInfo> userInfos = new List<UserInfo>();
            userInfos.Add(new UserInfo()
            {
                ID = 1,
                Name = "admin"
            });
            userInfos.Add(new UserInfo()
            {
                ID = 2,
                Name = "lycchun"
            });
            userInfos.Add(new UserInfo()
            {
                ID = 3,
                Name = "lwb"
            });
            userInfos.Add(new UserInfo()
            {
                ID = 4,
                Name = "Eleven"
            });
            userInfos.Add(new UserInfo()
            {
                ID = 5,
                Name = "Jason"
            });
            //绑定数据 项的实际值一般来说,就会指定对应显示值的编号
            listBox1.DataSource = userInfos;//选项的来源
            listBox1.DisplayMember = "Name";//项显示的文本对应属性名
            listBox1.ValueMember = "ID";//项的实际值对应的属性名


            //将对项集合的修改转换成对数据源集合的修改
            List<UserInfo> listNew = listBox1.DataSource as List<UserInfo>;
            listNew.Add(new UserInfo()
            {
                ID = 6,
                Name = "adbc"
            });
            listNew.RemoveAt(2);

            listBox1.DataSource = null;
            listBox1.DataSource = listNew;
            listBox1.DisplayMember = "Name";//项显示的文本对应属性名
            listBox1.ValueMember = "ID";//项的实际值对应的属性名

            //var indexes =listBox1.SelectedIndex;
            //var items = listBox1.SelectedItem;
            //int index = listBox1.SelectedValue;
            //var item0 =listBox1.SelectedIndices;
            //var val = listBox1.SelectedItems;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
