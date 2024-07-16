namespace WinFormsTest
{
    public partial class frmPictureBox : Form
    {
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("用户单击了图像！");
        }

        private void frmPictureBox_Load(object sender, EventArgs e)
        {
            // 设置 PictureBox 控件的位置和大小
            pictureBox1.Location = new Point(50, 50);
            pictureBox1.Size = new Size(200, 150);
            // 指定要显示的图像文件的路径
            pictureBox1.ImageLocation = "C:\\Users\\24576\\Pictures\\Microsoft.Windows.Photos_8wekyb3d8bbwe!App\\111.jpg";
            // 设置图像显示模式为拉伸以填充整个 PictureBox 控件
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }
    }
}
