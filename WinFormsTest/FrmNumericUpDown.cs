namespace WinFormsTest
{
    public partial class FrmNumericUpDown : Form
    {
        public FrmNumericUpDown()
        {
            InitializeComponent();
        }

        private void FrmNumericUpDown_Load(object sender, EventArgs e)
        {
            // 设置 NumericUpDown 控件的位置和大小
            //numericUpDown1.Location = new Point(50, 50);
            //numericUpDown1.Size = new Size(120, 30);
            // 设置允许输入的最小值和最大值
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 100;
            // 设置增量值为1
            numericUpDown1.Increment = 1;
            // 设置小数点后的位数为0
            numericUpDown1.DecimalPlaces = 0;
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            numericUpDown1.DownButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            numericUpDown1.UpButton();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }
    }
}
