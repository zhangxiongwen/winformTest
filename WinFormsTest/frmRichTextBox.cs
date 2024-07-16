namespace WinFormsTest
{
    public partial class frmRichTextBox : Form
    {
        public frmRichTextBox()
        {
            InitializeComponent();
        }

        private void frmRichTextBox_Load(object sender, EventArgs e)
        {
            // 向 RichTextBox 中插入富文本内容
            richTextBox1.AppendText("这是一段富文本示例。\n");
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.AppendText("这是粗体蓝色文本。\n");

            // 添加一个超链接
            richTextBox1.AppendText("访问我的网站：");
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Underline);
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.AppendText("https://www.baidu.com\n");


            Clipboard.Clear(); //剪贴板清空
            Image bmp = Image.FromFile(@"C:\\Users\\24576\\Pictures\\Microsoft.Windows.Photos_8wekyb3d8bbwe!App\\111.jpg");
            Clipboard.SetImage(bmp);
            richTextBox1.Paste();//将剪贴板中的图片粘贴到控件中


        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
