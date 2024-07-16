namespace WinFormsTest
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();

            txtName.Text = "�������˻�";
            txtPassword.Text = "����������";

            txtName.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;

        }

        private void Form1_Load(object sender, EventArgs e) //sender�¼������Ķ���
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

            if (string.IsNullOrEmpty(UserName) || UserName == "�������˻�")
            {
                MessageBox.Show("�������û���!", "��¼ҳ��", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(userPwd) || UserName == "����������")
            {
                MessageBox.Show("����������!", "��¼ҳ��", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("��¼�ɹ���", "������������....", MessageBoxButtons.OK, MessageBoxIcon.Information);
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