namespace FormSignIn
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnStrpHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStrpSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStrpQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStrpQuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStrpAddNV = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStrpEditNV = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStrpDelNV = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStrpQuanLyPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStrpAddPB = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStrpEditPB = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStrpDelPB = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStrpQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrpThogKe = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStrpListNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStrpListPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnrpHopDong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrpBangLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrpTDHV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrpChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.grBxTimKiem = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMaNhanSu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBGioiTinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lVNhanSu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grBxTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnStrpHeThong,
            this.MnStrpQuanLy,
            this.mnStrpThogKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnStrpHeThong
            // 
            this.mnStrpHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnStrpSignOut});
            this.mnStrpHeThong.Name = "mnStrpHeThong";
            this.mnStrpHeThong.Size = new System.Drawing.Size(94, 26);
            this.mnStrpHeThong.Text = "Hệ thống";
            // 
            // MnStrpSignOut
            // 
            this.MnStrpSignOut.Name = "MnStrpSignOut";
            this.MnStrpSignOut.Size = new System.Drawing.Size(172, 26);
            this.MnStrpSignOut.Text = "Đăng xuất";
            this.MnStrpSignOut.Click += new System.EventHandler(this.MnStrpSignOut_Click);
            // 
            // MnStrpQuanLy
            // 
            this.MnStrpQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnStrpQuanLyNhanVien,
            this.MnStrpQuanLyPhongBan,
            this.MnStrpQuanLyTaiKhoan});
            this.MnStrpQuanLy.Name = "MnStrpQuanLy";
            this.MnStrpQuanLy.Size = new System.Drawing.Size(86, 26);
            this.MnStrpQuanLy.Text = "Quản lý";
            this.MnStrpQuanLy.Click += new System.EventHandler(this.MnStrpQuanLy_Click);
            // 
            // MnStrpQuanLyNhanVien
            // 
            this.MnStrpQuanLyNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnStrpAddNV,
            this.MnStrpEditNV,
            this.MnStrpDelNV});
            this.MnStrpQuanLyNhanVien.Name = "MnStrpQuanLyNhanVien";
            this.MnStrpQuanLyNhanVien.Size = new System.Drawing.Size(249, 26);
            this.MnStrpQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            // 
            // MnStrpAddNV
            // 
            this.MnStrpAddNV.Name = "MnStrpAddNV";
            this.MnStrpAddNV.Size = new System.Drawing.Size(138, 26);
            this.MnStrpAddNV.Text = "Thêm";
            this.MnStrpAddNV.Click += new System.EventHandler(this.MnStrpAddNV_Click);
            // 
            // MnStrpEditNV
            // 
            this.MnStrpEditNV.Name = "MnStrpEditNV";
            this.MnStrpEditNV.Size = new System.Drawing.Size(138, 26);
            this.MnStrpEditNV.Text = "Sửa";
            this.MnStrpEditNV.Click += new System.EventHandler(this.MnStrpEditNV_Click);
            // 
            // MnStrpDelNV
            // 
            this.MnStrpDelNV.Name = "MnStrpDelNV";
            this.MnStrpDelNV.Size = new System.Drawing.Size(138, 26);
            this.MnStrpDelNV.Text = "Xóa";
            this.MnStrpDelNV.Click += new System.EventHandler(this.MnStrpDelNV_Click);
            // 
            // MnStrpQuanLyPhongBan
            // 
            this.MnStrpQuanLyPhongBan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnStrpAddPB,
            this.MnStrpEditPB,
            this.MnStrpDelPB});
            this.MnStrpQuanLyPhongBan.Name = "MnStrpQuanLyPhongBan";
            this.MnStrpQuanLyPhongBan.Size = new System.Drawing.Size(249, 26);
            this.MnStrpQuanLyPhongBan.Text = "Quản lý Phòng Ban";
            // 
            // MnStrpAddPB
            // 
            this.MnStrpAddPB.Name = "MnStrpAddPB";
            this.MnStrpAddPB.Size = new System.Drawing.Size(138, 26);
            this.MnStrpAddPB.Text = "Thêm";
            this.MnStrpAddPB.Click += new System.EventHandler(this.MnStrpAddPB_Click);
            // 
            // MnStrpEditPB
            // 
            this.MnStrpEditPB.Name = "MnStrpEditPB";
            this.MnStrpEditPB.Size = new System.Drawing.Size(138, 26);
            this.MnStrpEditPB.Text = "Sửa";
            this.MnStrpEditPB.Click += new System.EventHandler(this.MnStrpEditPB_Click);
            // 
            // MnStrpDelPB
            // 
            this.MnStrpDelPB.Name = "MnStrpDelPB";
            this.MnStrpDelPB.Size = new System.Drawing.Size(138, 26);
            this.MnStrpDelPB.Text = "Xóa";
            this.MnStrpDelPB.Click += new System.EventHandler(this.MnStrpDelPB_Click);
            // 
            // MnStrpQuanLyTaiKhoan
            // 
            this.MnStrpQuanLyTaiKhoan.Name = "MnStrpQuanLyTaiKhoan";
            this.MnStrpQuanLyTaiKhoan.Size = new System.Drawing.Size(249, 26);
            this.MnStrpQuanLyTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.MnStrpQuanLyTaiKhoan.Click += new System.EventHandler(this.MnStrpQuanLyTaiKhoan_Click);
            // 
            // mnStrpThogKe
            // 
            this.mnStrpThogKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnStrpListNhanVien,
            this.MnStrpListPhongBan,
            this.mnrpHopDong,
            this.mnStrpBangLuong,
            this.mnStrpTDHV,
            this.mnStrpChucVu});
            this.mnStrpThogKe.Name = "mnStrpThogKe";
            this.mnStrpThogKe.Size = new System.Drawing.Size(96, 26);
            this.mnStrpThogKe.Text = "Thống kê";
            // 
            // MnStrpListNhanVien
            // 
            this.MnStrpListNhanVien.Name = "MnStrpListNhanVien";
            this.MnStrpListNhanVien.Size = new System.Drawing.Size(284, 26);
            this.MnStrpListNhanVien.Text = "Danh Sách Nhân Viên";
            this.MnStrpListNhanVien.Click += new System.EventHandler(this.MnStrpListNhanVien_Click);
            // 
            // MnStrpListPhongBan
            // 
            this.MnStrpListPhongBan.Name = "MnStrpListPhongBan";
            this.MnStrpListPhongBan.Size = new System.Drawing.Size(284, 26);
            this.MnStrpListPhongBan.Text = "Danh Sách Phòng Ban";
            this.MnStrpListPhongBan.Click += new System.EventHandler(this.MnStrpListPhongBan_Click);
            // 
            // mnrpHopDong
            // 
            this.mnrpHopDong.Name = "mnrpHopDong";
            this.mnrpHopDong.Size = new System.Drawing.Size(284, 26);
            this.mnrpHopDong.Text = "Danh Sách Hợp Đồng";
            this.mnrpHopDong.Click += new System.EventHandler(this.mnrpHopDong_Click);
            // 
            // mnStrpBangLuong
            // 
            this.mnStrpBangLuong.Name = "mnStrpBangLuong";
            this.mnStrpBangLuong.Size = new System.Drawing.Size(284, 26);
            this.mnStrpBangLuong.Text = "Bảng Lương";
            this.mnStrpBangLuong.Click += new System.EventHandler(this.mnStrpBangLuong_Click);
            // 
            // mnStrpTDHV
            // 
            this.mnStrpTDHV.Name = "mnStrpTDHV";
            this.mnStrpTDHV.Size = new System.Drawing.Size(284, 26);
            this.mnStrpTDHV.Text = "Bảng Trình Độ Học Vấn";
            this.mnStrpTDHV.Click += new System.EventHandler(this.mnStrpTDHV_Click);
            // 
            // mnStrpChucVu
            // 
            this.mnStrpChucVu.Name = "mnStrpChucVu";
            this.mnStrpChucVu.Size = new System.Drawing.Size(284, 26);
            this.mnStrpChucVu.Text = "Bảng Chức Vụ";
            this.mnStrpChucVu.Click += new System.EventHandler(this.mnStrpChucVu_Click);
            // 
            // grBxTimKiem
            // 
            this.grBxTimKiem.Controls.Add(this.btnSearch);
            this.grBxTimKiem.Controls.Add(this.txtMaNhanSu);
            this.grBxTimKiem.Controls.Add(this.label4);
            this.grBxTimKiem.Controls.Add(this.txtQueQuan);
            this.grBxTimKiem.Controls.Add(this.label3);
            this.grBxTimKiem.Controls.Add(this.cBGioiTinh);
            this.grBxTimKiem.Controls.Add(this.label2);
            this.grBxTimKiem.Controls.Add(this.txtName);
            this.grBxTimKiem.Controls.Add(this.label1);
            this.grBxTimKiem.Location = new System.Drawing.Point(40, 57);
            this.grBxTimKiem.Name = "grBxTimKiem";
            this.grBxTimKiem.Size = new System.Drawing.Size(944, 187);
            this.grBxTimKiem.TabIndex = 1;
            this.grBxTimKiem.TabStop = false;
            this.grBxTimKiem.Text = "  Tìm Kiếm  ";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(389, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 43);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMaNhanSu
            // 
            this.txtMaNhanSu.Location = new System.Drawing.Point(647, 93);
            this.txtMaNhanSu.Name = "txtMaNhanSu";
            this.txtMaNhanSu.Size = new System.Drawing.Size(151, 27);
            this.txtMaNhanSu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Nhân Sự";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(108, 93);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(264, 27);
            this.txtQueQuan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quê Quán";
            // 
            // cBGioiTinh
            // 
            this.cBGioiTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBGioiTinh.FormattingEnabled = true;
            this.cBGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cBGioiTinh.Location = new System.Drawing.Point(647, 38);
            this.cBGioiTinh.Name = "cBGioiTinh";
            this.cBGioiTinh.Size = new System.Drawing.Size(151, 27);
            this.cBGioiTinh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giới Tính";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 27);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // lVNhanSu
            // 
            this.lVNhanSu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lVNhanSu.GridLines = true;
            this.lVNhanSu.HideSelection = false;
            this.lVNhanSu.Location = new System.Drawing.Point(60, 289);
            this.lVNhanSu.Name = "lVNhanSu";
            this.lVNhanSu.Size = new System.Drawing.Size(907, 302);
            this.lVNhanSu.TabIndex = 2;
            this.lVNhanSu.UseCompatibleStateImageBehavior = false;
            this.lVNhanSu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Nhân Viên";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ Tên";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quê Quán";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới Tính";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày Sinh";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sdt";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Dân Tộc";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã CV";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mã PB";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Bậc Lương";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Mã TDHV";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Danh Sách Nhân Sự";
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1036, 603);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lVNhanSu);
            this.Controls.Add(this.grBxTimKiem);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Quản Lý Nhân Sự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grBxTimKiem.ResumeLayout(false);
            this.grBxTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnStrpHeThong;
        private System.Windows.Forms.ToolStripMenuItem MnStrpSignOut;
        private System.Windows.Forms.ToolStripMenuItem MnStrpQuanLy;
        private System.Windows.Forms.ToolStripMenuItem MnStrpQuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem MnStrpQuanLyPhongBan;
        private System.Windows.Forms.ToolStripMenuItem MnStrpQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnStrpThogKe;
        private System.Windows.Forms.ToolStripMenuItem MnStrpListNhanVien;
        private System.Windows.Forms.ToolStripMenuItem MnStrpListPhongBan;
        private System.Windows.Forms.GroupBox grBxTimKiem;
        private System.Windows.Forms.ComboBox cBGioiTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMaNhanSu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lVNhanSu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem MnStrpAddNV;
        private System.Windows.Forms.ToolStripMenuItem MnStrpEditNV;
        private System.Windows.Forms.ToolStripMenuItem MnStrpDelNV;
        private System.Windows.Forms.ToolStripMenuItem MnStrpAddPB;
        private System.Windows.Forms.ToolStripMenuItem MnStrpEditPB;
        private System.Windows.Forms.ToolStripMenuItem MnStrpDelPB;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ToolStripMenuItem mnrpHopDong;
        private System.Windows.Forms.ToolStripMenuItem mnStrpBangLuong;
        private System.Windows.Forms.ToolStripMenuItem mnStrpTDHV;
        private System.Windows.Forms.ToolStripMenuItem mnStrpChucVu;
    }
}