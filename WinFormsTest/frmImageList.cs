namespace WinFormsTest
{
    public partial class frmImageList : Form
    {
        public frmImageList()
        {
            InitializeComponent();
        }

        private void frmImageList_Load(object sender, EventArgs e)
        {
            string imagedirPath = @"G:\Desktop\Images\";
            if (Directory.Exists(imagedirPath))
            {
                string[] stringsPath = Directory.GetFiles(imagedirPath);
                if (stringsPath.Length > 0)
                {
                    string[] fileType = { ".jpg", ".png" };
                    foreach (string s in stringsPath)
                    {
                        if (fileType.Contains(Path.GetExtension(s)))
                        {
                            Image image = Image.FromFile(s);
                            string keyName = Path.GetFileNameWithoutExtension(s);
                            imageList1.Images.Add(keyName, image);
                        }
                    }
                    imageList1.ImageSize = new Size(40, 40);
                    //使用imageList
                    label1.ImageList = imageList1;
                    label1.ImageKey = "1";
                    button1.ImageList = imageList1;
                    button1.ImageIndex = 2;
                }
            }
        }
    }
}
