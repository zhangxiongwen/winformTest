using System.Data;
using WinFormsTest.Helper;

namespace WinFormsTest
{
    public partial class frmDataGridView : Form
    {
        public frmDataGridView()
        {
            InitializeComponent();
        }

        private void frmDataGridView_Load(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo";
            DataTable dt = DBHelper.GetDataTable(sql, 1);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string nameUser = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (cell.FormattedValue.ToString() == "删除")
            {
                MessageBox.Show("删除了：" + nameUser);
            }
            else if (cell.FormattedValue.ToString() == "修改")
            {
                MessageBox.Show("修改了：" + nameUser);

            }
        }
    }
}
