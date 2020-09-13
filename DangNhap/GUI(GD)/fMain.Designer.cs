namespace DangNhap
{
    partial class fMain
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.txtGiam = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.btngiamgia = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnthanhtoan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.numSoluong = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.btnthemmon = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cboMon = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cboLoai = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvThucdon = new System.Windows.Forms.ListView();
            this.TenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cboMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoai)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGiam
            // 
            this.txtGiam.Location = new System.Drawing.Point(19, 41);
            this.txtGiam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiam.Name = "txtGiam";
            this.txtGiam.Size = new System.Drawing.Size(104, 22);
            this.txtGiam.TabIndex = 2;
            // 
            // btngiamgia
            // 
            this.btngiamgia.Location = new System.Drawing.Point(19, 4);
            this.btngiamgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btngiamgia.Name = "btngiamgia";
            this.btngiamgia.Size = new System.Drawing.Size(105, 29);
            this.btngiamgia.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btngiamgia.StateNormal.Back.Color2 = System.Drawing.Color.Aqua;
            this.btngiamgia.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btngiamgia.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiamgia.TabIndex = 1;
            this.btngiamgia.Values.Text = "Giảm giá";
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Location = new System.Drawing.Point(309, 7);
            this.btnthanhtoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(103, 56);
            this.btnthanhtoan.StateNormal.Back.Color1 = System.Drawing.Color.Yellow;
            this.btnthanhtoan.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnthanhtoan.StateNormal.Back.Image = global::DangNhap.Properties.Resources.icons8_pay_wall_30;
            this.btnthanhtoan.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.btnthanhtoan.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnthanhtoan.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnthanhtoan.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnthanhtoan.TabIndex = 0;
            this.btnthanhtoan.TabStop = false;
            this.btnthanhtoan.UseMnemonic = false;
            this.btnthanhtoan.Values.Text = "Thanh toán";
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // numSoluong
            // 
            this.numSoluong.Location = new System.Drawing.Point(294, 5);
            this.numSoluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSoluong.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoluong.Name = "numSoluong";
            this.numSoluong.Size = new System.Drawing.Size(53, 22);
            this.numSoluong.TabIndex = 3;
            this.numSoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnthemmon
            // 
            this.btnthemmon.Location = new System.Drawing.Point(294, 36);
            this.btnthemmon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthemmon.Name = "btnthemmon";
            this.btnthemmon.Size = new System.Drawing.Size(105, 29);
            this.btnthemmon.StateCommon.Back.Image = global::DangNhap.Properties.Resources.cafe;
            this.btnthemmon.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.BottomMiddle;
            this.btnthemmon.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnthemmon.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnthemmon.StateNormal.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.btnthemmon.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Blue;
            this.btnthemmon.StateNormal.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidTopLine;
            this.btnthemmon.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemmon.TabIndex = 2;
            this.btnthemmon.Values.Text = "Thêm món";
            this.btnthemmon.Click += new System.EventHandler(this.btnthemmon_Click);
            // 
            // cboMon
            // 
            this.cboMon.DropDownWidth = 121;
            this.cboMon.Location = new System.Drawing.Point(3, 41);
            this.cboMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMon.Name = "cboMon";
            this.cboMon.Size = new System.Drawing.Size(141, 21);
            this.cboMon.TabIndex = 1;
            this.cboMon.SelectedIndexChanged += new System.EventHandler(this.cboMon_SelectedIndexChanged);
            // 
            // cboLoai
            // 
            this.cboLoai.DropDownWidth = 121;
            this.cboLoai.Location = new System.Drawing.Point(5, 5);
            this.cboLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(141, 21);
            this.cboLoai.TabIndex = 0;
            this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.kryptonButton1);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.txtGiam);
            this.panel3.Controls.Add(this.btngiamgia);
            this.panel3.Controls.Add(this.btnthanhtoan);
            this.panel3.Location = new System.Drawing.Point(467, 413);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 92);
            this.panel3.TabIndex = 8;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(164, 4);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(105, 29);
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.Aqua;
            this.kryptonButton1.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonButton1.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 6;
            this.kryptonButton1.Values.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(164, 41);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(105, 22);
            this.txtTongTien.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvThucdon);
            this.panel2.Location = new System.Drawing.Point(467, 171);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 220);
            this.panel2.TabIndex = 7;
            // 
            // lsvThucdon
            // 
            this.lsvThucdon.BackColor = System.Drawing.Color.LightGray;
            this.lsvThucdon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenMon,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.lsvThucdon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvThucdon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lsvThucdon.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lsvThucdon.Location = new System.Drawing.Point(0, 0);
            this.lsvThucdon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvThucdon.Name = "lsvThucdon";
            this.lsvThucdon.Size = new System.Drawing.Size(431, 220);
            this.lsvThucdon.TabIndex = 0;
            this.lsvThucdon.UseCompatibleStateImageBehavior = false;
            this.lsvThucdon.View = System.Windows.Forms.View.Details;
            // 
            // TenMon
            // 
            this.TenMon.Text = "Tên món";
            this.TenMon.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DisplayIndex = 1;
            this.SoLuong.Text = "Số lượng";
            this.SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoLuong.Width = 120;
            // 
            // DonGia
            // 
            this.DonGia.DisplayIndex = 2;
            this.DonGia.Text = "Đơn giá";
            this.DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DonGia.Width = 140;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Thành tiền";
            this.ThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThanhTien.Width = 140;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtGia);
            this.panel4.Controls.Add(this.numSoluong);
            this.panel4.Controls.Add(this.btnthemmon);
            this.panel4.Controls.Add(this.cboMon);
            this.panel4.Controls.Add(this.cboLoai);
            this.panel4.Location = new System.Drawing.Point(467, 86);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(431, 77);
            this.panel4.TabIndex = 9;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(153, 5);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(116, 22);
            this.txtGia.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(947, 39);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.BackgroundImage = global::DangNhap.Properties.Resources.cafe;
            this.adminToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.adminToolStripMenuItem.Image = global::DangNhap.Properties.Resources.admin;
            this.adminToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(58, 35);
            this.adminToolStripMenuItem.Text = "ADMIN";
            this.adminToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.thôngTinTàiKhoảnToolStripMenuItem.Image = global::DangNhap.Properties.Resources.account;
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 86);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(411, 452);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(14, 58);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(111, 19);
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateNormal.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.kryptonLabel1.StateNormal.ShortText.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.kryptonLabel1.StateNormal.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.kryptonLabel1.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.TabStop = false;
            this.kryptonLabel1.UseMnemonic = false;
            this.kryptonLabel1.Values.Text = "DÃY BÀN CAFE";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(947, 535);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phần Mềm Quản Lí Cafe";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoai)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown txtGiam;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btngiamgia;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnthanhtoan;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numSoluong;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnthemmon;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboMon;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboLoai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ListView lsvThucdon;
        private System.Windows.Forms.ColumnHeader TenMon;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}