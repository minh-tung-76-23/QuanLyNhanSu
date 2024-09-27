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
    public partial class FormEditStaff : Form
    {
        string conn = @"Data Source=MINH-TUNG\SQLEXPRESS05;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
        SqlConnection conn2 = null;
        public FormEditStaff()
        {
            InitializeComponent();
        }

        // Đổ dữ liệu cho các cBOX
        private void FormEditStaff_Load(object sender, EventArgs e)
        {
            //Tạo kết nối đến CSDL
            SqlConnection conn2 = new SqlConnection(conn);
            conn2.Open();

            //Lấy dữ liệu Mã TĐHV
            SqlCommand cmdTDHV = new SqlCommand("SELECT MaTDHV FROM dbo.TrinhDoHocVan", conn2);
            SqlDataReader readerTDHV = cmdTDHV.ExecuteReader();
            while (readerTDHV.Read())
            {
                txtEditMaTDHV.Items.Add(readerTDHV["MaTDHV"].ToString());
            }
            readerTDHV.Close();

            //Lấy dữ liệu Mã Phòng Ban
            SqlCommand cmdPhongBan = new SqlCommand("SELECT MaPB FROM PhongBan", conn2);
            SqlDataReader readerPhongBan = cmdPhongBan.ExecuteReader();
            while (readerPhongBan.Read())
            {
                txtEditMaPB.Items.Add(readerPhongBan["MaPB"].ToString());
            }
            readerPhongBan.Close();

            //Lấy dữ liệu Mã Chức Vụ
            SqlCommand cmdChucVu = new SqlCommand("SELECT MaCV FROM ChucVu", conn2);
            SqlDataReader readerChucVu = cmdChucVu.ExecuteReader();
            while (readerChucVu.Read())
            {
                txtEditMaChucVu.Items.Add(readerChucVu["MaCV"].ToString());
            }
            readerChucVu.Close();

            //Lấy dữ liệu Bậc Lương
            SqlCommand cmdBacLuong = new SqlCommand("SELECT BacLuong FROM Luong", conn2);
            SqlDataReader readerBacLuong = cmdBacLuong.ExecuteReader();
            while (readerBacLuong.Read())
            {
                txtEditBacLuong.Items.Add(readerBacLuong["BacLuong"].ToString());
            }
            readerBacLuong.Close();

            //Đóng kết nối
            conn2.Close();
        }

        //Khi click vào nút sửa
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường
            string maNV = txtEditMaNhanVien.Text.Trim();
            string hoTen = txtEditHoTen.Text.Trim();
            string queQuan = txtEditQueQuan.Text.Trim();
            string gioiTinh = cBEditGioiTinh.Text.Trim();
            DateTime ngaySinh = dtPEditNgaySinh.Value;
            string sdt = txtEditSdt.Text.Trim();
            string danToc = txtEditDanToc.Text.Trim();
            string maCV = txtEditMaChucVu.Text.Trim();
            int maPB = int.Parse(txtEditMaPB.Text.Trim());
            string maTDHV = txtEditMaTDHV.Text.Trim();
            int bacLuong = int.Parse(txtEditBacLuong.Text.Trim());

            if (string.IsNullOrEmpty(txtEditHoTen.Text) ||
                string.IsNullOrEmpty(txtEditBacLuong.Text) ||
                string.IsNullOrEmpty(txtEditDanToc.Text) ||
                string.IsNullOrEmpty(dtPEditNgaySinh.Text) ||
                string.IsNullOrEmpty(txtEditMaNhanVien.Text) ||
                string.IsNullOrEmpty(txtEditMaPB.Text) ||
                string.IsNullOrEmpty(txtEditMaTDHV.Text) ||
                string.IsNullOrEmpty(txtEditQueQuan.Text) ||
                string.IsNullOrEmpty(txtEditSdt.Text) ||
                string.IsNullOrEmpty(txtEditMaChucVu.Text) ||
                string.IsNullOrEmpty(cBEditGioiTinh.Text) ||
                string.IsNullOrEmpty(txtEditLoaiHD.Text) ||
                string.IsNullOrEmpty(txtEditThoiHanHD.Text) ||
                string.IsNullOrEmpty(dtNgayKy.Text) ||
                string.IsNullOrEmpty(txtEditMaHD.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo");
                return;
            }

            // Tạo kết nối
            using (SqlConnection conn2 = new SqlConnection(conn))
            {
                conn2.Open();

                // Tạo đối tượng thực thi truy vấn
                SqlCommand cmd = new SqlCommand("UPDATE dbo.NhanVien SET HoTenNV = @HoTen, QueQuan = @QueQuan, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, SDT = @SDT, DanToc = @DanToc, MaCV = @MaCV, MaPB = @MaPB, MaTDHV = @MaTDHV, BacLuong = @BacLuong WHERE MaNV = @MaNV", conn2);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@QueQuan", queQuan);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@DanToc", danToc);
                cmd.Parameters.AddWithValue("@MaCV", maCV);
                cmd.Parameters.AddWithValue("@MaPB", maPB);
                cmd.Parameters.AddWithValue("@MaTDHV", maTDHV);
                cmd.Parameters.AddWithValue("@BacLuong", bacLuong);

                //Thực Thi Truy vấn
                int rowAffected = cmd.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    string maHD = txtEditMaHD.Text.Trim();
                    string loaiHD = txtEditLoaiHD.Text.Trim();
                    string thoiHan = txtEditThoiHanHD.Text.Trim();
                    DateTime ngayKy = dtNgayKy.Value;

                    // Tạo đối tượng thực thi truy vấn
                    SqlCommand cmd2 = new SqlCommand("UPDATE dbo.HopDong SET MaHD = @MaHD, LoaiHD = @LoaiHD, ThoiHan = @ThoiHan, NgayKy = @NgayKy WHERE MaNV = @MaNV", conn2);
                    cmd2.Parameters.AddWithValue("@MaNV", maNV);
                    cmd2.Parameters.AddWithValue("@MaHD", maHD);
                    cmd2.Parameters.AddWithValue("@LoaiHD", loaiHD);
                    cmd2.Parameters.AddWithValue("@ThoiHan", thoiHan);
                    cmd2.Parameters.AddWithValue("@NgayKy", ngayKy);



                    // Thực thi truy vấn
                    int rowAffected2 = cmd2.ExecuteNonQuery();

                    if (rowAffected2 > 0)
                    {
                        MessageBox.Show("Đã thêm thông tin nhân sự!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại", "Thông báo");
                    }
                    FormHopDong fHD = (FormHopDong)Application.OpenForms["FormHopDong"];
                    fHD.LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại", "Thông báo");
                }

                // Đóng kết nối
                conn2.Close();
            }
            FormMain fMain = (FormMain)Application.OpenForms["FormMain"];
            fMain.LoadData();
            FormListNhanVien fLNhanVien = (FormListNhanVien)Application.OpenForms["FormListNhanVien"];
            fLNhanVien.LoadData();
        }

        //Đổ dữ liệu qua mã Nhân Viên
        private void txtEditMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            string maNV = txtEditMaNhanVien.Text.Trim();
            if (maNV.Length > 0 )
            {
                LoadNhanVien(maNV);
            }
            else
            {
                txtEditHoTen.Text = "";
                dtPEditNgaySinh.Text = "";
                txtEditQueQuan.Text = "";
                txtEditBacLuong.Text = "";
                cBEditGioiTinh.Text = "";
                txtEditSdt.Text = "";
                txtEditDanToc.Text = "";
                txtEditBacLuong.Text = "";
                txtEditMaPB.Text = "";
                txtEditMaTDHV.Text = "";
                txtEditMaChucVu.Text = "";
                txtEditMaHD.Text = "";
                dtNgayKy.Text = "";
                txtEditLoaiHD.Text = "";
                txtEditThoiHanHD.Text = "";
            }

        }

        private void LoadNhanVien(string maNV)
        {
            //Tao Ket noi
            SqlConnection conn2 = new SqlConnection(conn);
            conn2.Open();

            //Tạo đối tượng thực thi truy vấn
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.NhanVien nv JOIN dbo.HopDong hd ON nv.MaNV = hd.MaNV WHERE nv.MaNV = @MaNV", conn2);
            cmd.Parameters.AddWithValue("@MaNV", maNV);
            SqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                txtEditHoTen.Text = reader.GetString(reader.GetOrdinal("HoTenNV"));
                txtEditQueQuan.Text = reader.GetString(reader.GetOrdinal("QueQuan"));
                cBEditGioiTinh.Text = reader.GetString(reader.GetOrdinal("GioiTinh"));
                dtPEditNgaySinh.Value = reader.GetDateTime(reader.GetOrdinal("NgaySinh"));
                txtEditSdt.Text = reader.GetString(reader.GetOrdinal("SDT"));
                txtEditDanToc.Text = reader.GetString(reader.GetOrdinal("DanToc"));
                txtEditMaChucVu.Text = reader.GetString(reader.GetOrdinal("MaCV"));
                txtEditMaPB.Text = reader.GetInt32(reader.GetOrdinal("MaPB")).ToString();
                txtEditMaTDHV.Text = reader.GetString(reader.GetOrdinal("MaTDHV"));
                txtEditBacLuong.Text = reader.GetInt32(reader.GetOrdinal("BacLuong")).ToString();
                txtEditMaHD.Text = reader.GetInt32(reader.GetOrdinal("MaHD")).ToString();
                dtNgayKy.Value = reader.GetDateTime(reader.GetOrdinal("NgayKy"));
                txtEditLoaiHD.Text = reader.GetString(reader.GetOrdinal("LoaiHD"));
                txtEditThoiHanHD.Text = reader.GetString(reader.GetOrdinal("ThoiHan"));
            }
            reader.Close();
            conn2.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
