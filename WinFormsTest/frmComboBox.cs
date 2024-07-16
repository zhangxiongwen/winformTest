namespace WinFormsTest
{
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
            List<UserInfo> list = new List<UserInfo>();
            list.Add(new UserInfo
            {
                Name = "智能建造小硕",
                ID = 0
            });
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

            cobName.DataSource = list;
            cobName.ValueMember = "ID";
            cobName.DisplayMember = "Name";

            //注册事件
            cobName.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("选中了：" + (cobName.SelectedItem as UserInfo).Name, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmComboBox_Load(object sender, EventArgs e)
        {

        }

        private void cobName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
