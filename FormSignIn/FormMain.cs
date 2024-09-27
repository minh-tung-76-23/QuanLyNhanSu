using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FormSignIn
{
    public partial class FormMain : Form
    {
        string conn = @"Data Source=MINH-TUNG\SQLEXPRESS05;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
        SqlConnection conn2 = null;
        public FormMain()
        {
            InitializeComponent();
        }

        public bool isThoat = true;

        //QUAN LY NHAN VIEN
        private void MnStrpAddNV_Click(object sender, EventArgs e)
        {
            FormAddStaff fASatff = new FormAddStaff();
            fASatff.Show();
        }

        private void MnStrpEditNV_Click(object sender, EventArgs e)
        {
            FormEditStaff fESatff = new FormEditStaff();
            fESatff.Show();
        }

        private void MnStrpDelNV_Click(object sender, EventArgs e)
        {
            FormDeleteStaff fDelSatff = new FormDeleteStaff();
            fDelSatff.Show();
        }

        //QUAN LY PHONG BAN
        private void MnStrpAddPB_Click(object sender, EventArgs e)
        {
            FormAddPB fAPB = new FormAddPB();
            fAPB.Show();
        }

        private void MnStrpEditPB_Click(object sender, EventArgs e)
        {
            FormEditPB fEPB = new FormEditPB();
            fEPB.Show();
        }

        private void MnStrpDelPB_Click(object sender, EventArgs e)
        {
            FormDeletePB fDelPB = new FormDeletePB();
            fDelPB.Show();

        }

        //QUAN LY TAI KHOAN
        private void MnStrpQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            FormQuanLyTaiKhoan fQLTK = new FormQuanLyTaiKhoan();
            fQLTK.ShowDialog();     
        }

        //THONG KE DANH SACH NHAN VIEN
        private void MnStrpListNhanVien_Click(object sender, EventArgs e)
        {
            FormListNhanVien fLNhanVien = new FormListNhanVien();
            fLNhanVien.Show();
        }

        //THONG KE DANH SACH PHONG BAN
        private void MnStrpListPhongBan_Click(object sender, EventArgs e)
        {
            FormListPB fLPB = new FormListPB();
            fLPB.Show();
        }

        //DANG XUAT
        public event EventHandler SignOut;
        private void MnStrpSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                List<Form> formsToClose = new List<Form>();
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this && form.GetType() != typeof(FormSignIn))
                    {
                        formsToClose.Add(form);
                    }
                }

                foreach (Form form in formsToClose)
                {
                    form.Close();
                }

                SignOut(this, new EventArgs());
            }
        }



        //THoat Chuong Trinh
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                {
                    e.Cancel = true;    
                }
            }
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isThoat)
                Application.Exit();
        }


        //Phan Quyen Nguoi Dung
        void PhanQuyen()
        {
            if (Const.LoaiTaiKhoan == false )
            {
                MnStrpQuanLyNhanVien.Enabled = false;
                MnStrpQuanLyPhongBan.Enabled = false;
                MnStrpQuanLyTaiKhoan.Enabled = false;
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            LoadData();
            
        }

        public void LoadData()
        {
            //Tao Ket noi
            conn2 = new SqlConnection(conn);
            conn2.Open();

            // Tạo đối tượng thực thi truy vấn
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM dbo.NhanVien";
            cmd.Connection = conn2;

            // Thực thi truy vấn    
            SqlDataReader Dreader = cmd.ExecuteReader();
            lVNhanSu.Items.Clear();
            // Hiển thị dữ liệu
            while (Dreader.Read())
            {
                // Lấy dữ liệu từ SqlDataReader
                int MaNV = Dreader.GetInt32(0);
                string HoTenNV = Dreader.GetString(1);
                string QueQuan = Dreader.GetString(2);
                string GioiTinh = Dreader.GetString(3);
                DateTime NgaySinh = Dreader.GetDateTime(4);
                string SDT = Dreader.GetString(5);
                string DanToc = Dreader.GetString(6);
                string MaCV = Dreader.GetString(7);
                int MaPB = Dreader.GetInt32(8);
                int BacLuong = Dreader.GetInt32(9);
                string MaTDHV = Dreader.GetString(10);

                // Hiển thị dữ liệu lên ListView
                ListViewItem lv = new ListViewItem(MaNV.ToString());
                lv.SubItems.Add(HoTenNV);
                lv.SubItems.Add(QueQuan);
                lv.SubItems.Add(GioiTinh);
                lv.SubItems.Add(NgaySinh.ToString("dd/MM/yyyy"));
                lv.SubItems.Add(SDT);
                lv.SubItems.Add(DanToc);
                lv.SubItems.Add(MaCV);
                lv.SubItems.Add(MaPB.ToString());
                lv.SubItems.Add(BacLuong.ToString());
                lv.SubItems.Add(MaTDHV);

                lVNhanSu.Items.Add(lv);
            }

            // Đóng SqlDataReader
            Dreader.Close();

            // Đóng kết nối
            conn2.Close();
        }

        private void MnStrpQuanLy_Click(object sender, EventArgs e)
        {
            if (Const.LoaiTaiKhoan == false)
            {
                MessageBox.Show("Bạn không thể sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //Tim Kiem Nhan Su
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maNv = txtMaNhanSu.Text.Trim();
            string hotenNv = txtName.Text.Trim();
            string gioiTinh = cBGioiTinh.Text.Trim();
            string queQuan = txtQueQuan.Text.Trim();

            searchNhanVien(maNv, hotenNv, gioiTinh, queQuan);           
        }

        private void searchNhanVien(string maNv, string hotenNv, string gioiTinh, string queQuan)
        {
            // Tạo kết nối
            using (SqlConnection conn2 = new SqlConnection(conn))
            {
                conn2.Open();

                // Tạo câu truy vấn SQL dựa trên thông tin tìm kiếm được nhập vào
                string sql = "SELECT * FROM NhanVien WHERE 1 = 1";
                if (!string.IsNullOrEmpty(maNv))
                {
                    sql += " AND MaNV LIKE '%" + maNv + "%'";
                }
                if (!string.IsNullOrEmpty(hotenNv))
                {
                    sql += " AND HoTenNV LIKE N'%" + hotenNv + "%'";
                }
                if (!string.IsNullOrEmpty(gioiTinh))
                {
                    sql += " AND GioiTinh LIKE N'%" + gioiTinh + "%'";
                }
                if (!string.IsNullOrEmpty(queQuan))
                {
                    sql += " AND QueQuan LIKE N'%" + queQuan + "%'";
                }

                // Tạo đối tượng Command và thực thi truy vấn
                using (SqlCommand cmd = new SqlCommand(sql, conn2))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Xóa tất cả các item trong ListView để cập nhật lại dữ liệu
                        lVNhanSu.Items.Clear();

                        // Duyệt qua từng bản ghi kết quả truy vấn
                        while (reader.Read())
                        {
                            // Tạo một ListViewItem mới và thêm các thông tin cần hiển thị vào nó
                            ListViewItem item = new ListViewItem(reader.GetInt32(0).ToString());
                            item.SubItems.Add(reader.GetString(1));
                            item.SubItems.Add(reader.GetString(2));
                            item.SubItems.Add(reader.GetString(3));
                            item.SubItems.Add(reader.GetDateTime(4).ToString());
                            item.SubItems.Add(reader.GetString(5));
                            item.SubItems.Add(reader.GetString(6));
                            item.SubItems.Add(reader.GetString(7));
                            item.SubItems.Add(reader.GetInt32(8).ToString());
                            item.SubItems.Add(reader.GetInt32(9).ToString());
                            item.SubItems.Add(reader.GetString(10));

                            // Thêm item vào ListView
                            lVNhanSu.Items.Add(item);
                        }
                    }
                }
            }
        }
        //Danh Sach Luong
        private void mnStrpBangLuong_Click(object sender, EventArgs e)
        {
            FormLuong fLuong = new FormLuong();
            fLuong.Show();
        }
        //Danh Sach Hop Dong
        private void mnrpHopDong_Click(object sender, EventArgs e)
        {
            FormHopDong fHD = new FormHopDong();
            fHD.Show();
        }

        private void mnStrpTDHV_Click(object sender, EventArgs e)
        {
            FormTDHV fTDHV = new FormTDHV();
            fTDHV.Show();
        }

        private void mnStrpChucVu_Click(object sender, EventArgs e)
        {
            FormChucVu fCV = new FormChucVu();
            fCV.Show();
        }
    }
}
