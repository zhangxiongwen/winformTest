namespace WinFormsTest
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();

            txtName.Text = "请输入账户";
            txtPassword.Text = "请输入密码";

            txtName.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;

        }

        private void Form1_Load(object sender, EventArgs e) //sender事件触发的对象
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string UserName = txtName.Text.Trim();
            string userPwd = txtPassword.Text;

            if (string.IsNullOrEmpty(UserName) || UserName == "请输入账户")
            {
                MessageBox.Show("请输入用户名!", "登录页面", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(userPwd) || UserName == "请输入密码")
            {
                MessageBox.Show("请输入密码!", "登录页面", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("登录成功！", "进入主界面中....", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.ForeColor = Color.Black;

        }
    }
}