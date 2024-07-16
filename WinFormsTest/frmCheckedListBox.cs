namespace WinFormsTest
{
    public partial class frmCheckedListBox : Form
    {
        public frmCheckedListBox()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCheckedListBox_Load(object sender, EventArgs e)
        {
            ////直接添加项
            //cklLList.Items.Clear();
            //cklLList.Items.Add(1);
            //cklLList.Items.Add("aaa");
            //cklLList.Items.AddRange(new string[] { "aaa", "bbb", "ccc" });
            //cklLList.Items.Insert(2, "ddd");
            //cklLList.Items.Remove("ddd");
            //cklLList.Items.RemoveAt(2);//移除第3项

            List<UserInfo> list = new List<UserInfo>();
            list.Add(new UserInfo()
            {
                ID = 1,
                Name = "admin"
            });
            list.Add(new UserInfo()
            {
                ID = 2,
                Name = "lycchun"
            });
            list.Add(new UserInfo()
            {
                ID = 3,
                Name = "lwb"
            });
            list.Add(new UserInfo()
            {
                ID = 4,
                Name = "Eleven"
            });
            list.Add(new UserInfo()
            {
                ID = 5,
                Name = "Jason"
            });
            //当指定 了DataSource,是不可以修改Items集合的
            cklLList.DataSource = list;
            cklLList.DisplayMember = "Name";
            cklLList.ValueMember = "Id";
            //cklLList.Items.RemoveAt(4);
            //勾选或选择项的获取
            //cklLList.CheckedIndices
            //cklLList.CheckedItems
            //cklLList.SelectedIndices
            //cklLList.SelectedItems
            //cklLList.SelectedIndex
        }
    }
}
