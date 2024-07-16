namespace WinFormsTest
{
    partial class frmListView
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
            components = new System.ComponentModel.Container();
            lvList = new ListView();
            btnLarge = new Button();
            btnSmall = new Button();
            btnList = new Button();
            btnDetail = new Button();
            btnTile = new Button();
            btnDivideOpen = new Button();
            lglLarge = new ImageList(components);
            lglSmall = new ImageList(components);
            btnDivideOff = new Button();
            SuspendLayout();
            // 
            // lvList
            // 
            lvList.Location = new Point(22, 33);
            lvList.Name = "lvList";
            lvList.Size = new Size(640, 347);
            lvList.TabIndex = 0;
            lvList.UseCompatibleStateImageBehavior = false;
            // 
            // btnLarge
            // 
            btnLarge.Location = new Point(22, 4);
            btnLarge.Name = "btnLarge";
            btnLarge.Size = new Size(75, 23);
            btnLarge.TabIndex = 1;
            btnLarge.Text = "大图标";
            btnLarge.UseVisualStyleBackColor = true;
            btnLarge.Click += btnLarge_Click;
            // 
            // btnSmall
            // 
            btnSmall.Location = new Point(120, 4);
            btnSmall.Name = "btnSmall";
            btnSmall.Size = new Size(75, 23);
            btnSmall.TabIndex = 2;
            btnSmall.Text = "小图标";
            btnSmall.UseVisualStyleBackColor = true;
            btnSmall.Click += btnSmall_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(218, 4);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 3;
            btnList.Text = "列表";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(316, 4);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(75, 23);
            btnDetail.TabIndex = 4;
            btnDetail.Text = "详细信息";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnTile
            // 
            btnTile.Location = new Point(414, 4);
            btnTile.Name = "btnTile";
            btnTile.Size = new Size(75, 23);
            btnTile.TabIndex = 5;
            btnTile.Text = "平铺";
            btnTile.UseVisualStyleBackColor = true;
            btnTile.Click += btnTile_Click;
            // 
            // btnDivideOpen
            // 
            btnDivideOpen.Location = new Point(22, 386);
            btnDivideOpen.Name = "btnDivideOpen";
            btnDivideOpen.Size = new Size(75, 23);
            btnDivideOpen.TabIndex = 6;
            btnDivideOpen.Text = "开启分组";
            btnDivideOpen.UseVisualStyleBackColor = true;
            btnDivideOpen.Click += btnDivideOpen_Click;
            // 
            // lglLarge
            // 
            lglLarge.ColorDepth = ColorDepth.Depth8Bit;
            lglLarge.ImageSize = new Size(16, 16);
            lglLarge.TransparentColor = Color.Transparent;
            // 
            // lglSmall
            // 
            lglSmall.ColorDepth = ColorDepth.Depth8Bit;
            lglSmall.ImageSize = new Size(16, 16);
            lglSmall.TransparentColor = Color.Transparent;
            // 
            // btnDivideOff
            // 
            btnDivideOff.Location = new Point(120, 386);
            btnDivideOff.Name = "btnDivideOff";
            btnDivideOff.Size = new Size(75, 23);
            btnDivideOff.TabIndex = 7;
            btnDivideOff.Text = "关闭分组";
            btnDivideOff.UseVisualStyleBackColor = true;
            btnDivideOff.Click += btnDivideOff_Click;
            // 
            // frmListView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 423);
            Controls.Add(btnDivideOff);
            Controls.Add(btnDivideOpen);
            Controls.Add(btnTile);
            Controls.Add(btnDetail);
            Controls.Add(btnList);
            Controls.Add(btnSmall);
            Controls.Add(btnLarge);
            Controls.Add(lvList);
            Name = "frmListView";
            Text = "frmListView";
            Load += frmListView_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvList;
        private Button btnLarge;
        private Button btnSmall;
        private Button btnList;
        private Button btnDetail;
        private Button btnTile;
        private Button btnDivideOpen;
        private ImageList lglLarge;
        private ImageList lglSmall;
        private Button btnDivideOff;
    }
}