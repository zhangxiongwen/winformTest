namespace WinFormsTest
{
    public partial class frmTime : Form
    {
        public frmTime()
        {
            InitializeComponent();
        }

        private void frmTime_Load(object sender, EventArgs e)
        {
            // 设置日期时间控件的显示格式为长日期
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            // 启用复选框，允许用户禁用日期时间选择
            dateTimePicker1.ShowCheckBox = true;
            // 不显示上下箭头按钮
            dateTimePicker1.ShowUpDown = false;

            // 设置每周的第一天为周一
            monthCalendar1.FirstDayOfWeek = Day.Monday;
            // 设置允许选择多个日期
            monthCalendar1.MaxSelectionCount = 10;
            // 显示每周的周数
            monthCalendar1.ShowWeekNumbers = true;
            // 突出显示当天的日期
            monthCalendar1.ShowToday = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // 当日期时间控件的值更改时，将新值显示在Label中
            label2.Text = "选择的日期时间是：" + dateTimePicker1.Value.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // 当用户选择的日期范围发生改变时，将新的日期范围显示在Label中
            label1.Text = "选择的日期范围是：" + e.Start.ToShortDateString() + " 到 " + e.End.ToShortDateString();
        }
    }
}
