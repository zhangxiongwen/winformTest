namespace WinFormsTest
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }
        Dictionary<string, string> dicGroup = new Dictionary<string, string>();
        private void frmListView_Load(object sender, EventArgs e)
        {
            LoadImgList(); //加载图片资源到imageList中
            //对ViewList进行分组
            lvList.Groups.Clear();
            lvList.Groups.Add(new ListViewGroup("熊大小时候", HorizontalAlignment.Center));
            lvList.Groups.Add(new ListViewGroup("哆啦A梦生气", HorizontalAlignment.Center));
            lvList.Groups.Add(new ListViewGroup("哆啦A梦吹口哨", HorizontalAlignment.Center));
            lvList.Items.Clear();
            //关系存储
            dicGroup.Add("熊大小时候", "1");
            dicGroup.Add("哆啦A梦生气", "2");
            dicGroup.Add("哆啦A梦吹口哨", "3");

            lvList.ShowGroups = true;
            //创建详细信息的表头
            lvList.Columns.Add("文件名", 100, HorizontalAlignment.Left);
            lvList.Columns.Add("创建日期", 160, HorizontalAlignment.Left);
            lvList.Columns.Add("类型", 60, HorizontalAlignment.Left);
            lvList.Columns.Add("大小", 60, HorizontalAlignment.Left);
            for (int i = 0; i < dic.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.ImageIndex = i;
                listViewItem.Text = lglSmall.Images.Keys[i];
                listViewItem.SubItems.Add(File.GetCreationTime(dic[i]).ToString());//创建日期
                listViewItem.SubItems.Add(Path.GetExtension(dic[i]));//类型
                long length = new FileInfo(dic[i]).Length;//B
                listViewItem.SubItems.Add((length / 1024).ToString());//KB
                foreach (ListViewGroup lvgg in lvList.Groups)
                {
                    if (listViewItem.Text.Substring(0, 1) == dicGroup[lvgg.Header]) //Substring(0,1)获取字符串中的第一个字符
                    {
                        listViewItem.Group = lvgg;
                        break;
                    }
                }
                lvList.Items.Add(listViewItem);
            }
            lvList.View = View.LargeIcon; //制定初始的视图模式
            lvList.LargeImageList = lglLarge;
            lvList.SmallImageList = lglSmall;
        }

        Dictionary<int, string> dic = new Dictionary<int, string>();
        private void LoadImgList()
        {
            string path = @"G:\Desktop\Images";
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                if (files.Length > 0)
                {
                    lglSmall.Images.Clear();
                    lglLarge.Images.Clear();
                    int index = 0;
                    string[] fileType = { ".jpg", ".png" };
                    foreach (string file in files)
                    {
                        if (fileType.Contains(Path.GetExtension(file)))
                        {
                            Image img = Image.FromFile(file);
                            string key = Path.GetFileNameWithoutExtension(file);
                            lglLarge.Images.Add(key, img);
                            lglSmall.Images.Add(key, img);
                            dic.Add(index, file);
                            index++;
                        }
                    }
                    lglLarge.ImageSize = new Size(50, 70);
                    lglSmall.ImageSize = new Size(20, 20);
                }
            }
        }
        private void btnLarge_Click(object sender, EventArgs e)
        {
            lvList.View = View.LargeIcon;
        }
        private void btnSmall_Click(object sender, EventArgs e)
        {
            lvList.View = View.SmallIcon;
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            lvList.View = View.List;
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            lvList.View = View.Details;
            lvList.GridLines = true;// 显示网格
        }
        private void btnTile_Click(object sender, EventArgs e)
        {
            lvList.View = View.Tile; //它的图标也使用的是LargeList
        }

        private void btnDivideOpen_Click(object sender, EventArgs e)
        {
            if (lvList.ShowGroups != true)
            {
                lvList.ShowGroups = true;
            }
            //else
            //{
            //    lvList.ShowGroups = false;
            //}
        }

        private void btnDivideOff_Click(object sender, EventArgs e)
        {
            if (lvList.ShowGroups != false)
            {
                lvList.ShowGroups = false;
            }
        }
    }
}
