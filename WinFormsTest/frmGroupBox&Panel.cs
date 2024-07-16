namespace WinFormsTest
{
    public partial class frmGroupBox_Panel : Form
    {
        public frmGroupBox_Panel()
        {
            InitializeComponent();
        }

        private void frmGroupBox_Panel_Load(object sender, EventArgs e)
        {
            // 创建一个GroupBox
            GroupBox groupBox = new GroupBox();
            groupBox.Text = "用户信息";
            groupBox.Location = new Point(10, 10);
            groupBox.Size = new Size(300, 200);
            this.Controls.Add(groupBox);

            // 在GroupBox中添加Label和TextBox
            Label nameLabel = new Label();
            nameLabel.Text = "姓名：";
            nameLabel.Location = new Point(10, 30);
            groupBox.Controls.Add(nameLabel);

            TextBox nameTextBox = new TextBox();
            nameTextBox.Location = new Point(120, 30);
            groupBox.Controls.Add(nameTextBox);

            // 创建一个Panel
            Panel panel = new Panel();
            panel.Location = new Point(320, 10);
            panel.Size = new Size(300, 200);
            this.Controls.Add(panel);

            // 在Panel中添加Label和TextBox
            Label emailLabel = new Label();
            emailLabel.Text = "邮箱：";
            emailLabel.Location = new Point(10, 30);
            panel.Controls.Add(emailLabel);

            TextBox emailTextBox = new TextBox();
            emailTextBox.Location = new Point(120, 30);
            panel.Controls.Add(emailTextBox);
        }
    }
}
