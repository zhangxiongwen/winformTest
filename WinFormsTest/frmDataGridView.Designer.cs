namespace WinFormsTest
{
    partial class frmDataGridView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            IDnumber = new DataGridViewTextBoxColumn();
            nameUser = new DataGridViewTextBoxColumn();
            ageUser = new DataGridViewTextBoxColumn();
            delete = new DataGridViewLinkColumn();
            changeInfo = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDnumber, nameUser, ageUser, delete, changeInfo });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(568, 336);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IDnumber
            // 
            IDnumber.DataPropertyName = "IDnumber";
            IDnumber.HeaderText = "编号";
            IDnumber.Name = "IDnumber";
            // 
            // nameUser
            // 
            nameUser.DataPropertyName = "nameUser";
            nameUser.HeaderText = "姓名";
            nameUser.Name = "nameUser";
            // 
            // ageUser
            // 
            ageUser.DataPropertyName = "ageUser";
            ageUser.HeaderText = "年龄";
            ageUser.Name = "ageUser";
            // 
            // delete
            // 
            dataGridViewCellStyle1.NullValue = "删除";
            delete.DefaultCellStyle = dataGridViewCellStyle1;
            delete.HeaderText = "删除";
            delete.Name = "delete";
            delete.Text = "";
            // 
            // changeInfo
            // 
            dataGridViewCellStyle2.NullValue = "修改";
            changeInfo.DefaultCellStyle = dataGridViewCellStyle2;
            changeInfo.HeaderText = "修改";
            changeInfo.Name = "changeInfo";
            // 
            // frmDataGridView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 336);
            Controls.Add(dataGridView1);
            Name = "frmDataGridView";
            Text = "frmDataGridView";
            Load += frmDataGridView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDnumber;
        private DataGridViewTextBoxColumn nameUser;
        private DataGridViewTextBoxColumn ageUser;
        private DataGridViewLinkColumn delete;
        private DataGridViewLinkColumn changeInfo;
    }
}