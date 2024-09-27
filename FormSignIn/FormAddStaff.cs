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
    public partial class FormAddStaff : Form
    {
        string conn = @"Data Source=MINH-TUNG\SQLEXPRESS05;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
        SqlConnection conn2 = null;
        public FormAddStaff()
        {
            InitializeComponent();
        }
        private void FormAddStaff_Load(object sender, EventArgs e)
        {
            //Tạo kết nối đến CSDL
            SqlConnection conn2 = new SqlConnection(conn);
            conn2.Open();

            //Lấy dữ liệu Mã TĐHV
            SqlCommand cmdTDHV = new SqlCommand("SELECT MaTDHV FROM dbo.TrinhDoHocVan", conn2);
            SqlDataReader readerTDHV = cmdTDHV.ExecuteReader();
            while (readerTDHV.Read())
            {
                txtAddMaTDHV.Items.Add(readerTDHV["MaTDHV"].ToString());
            }
            readerTDHV.Close();

            //Lấy dữ liệu Mã Phòng Ban
            SqlCommand cmdPhongBan = new SqlCommand("SELECT MaPB FROM PhongBan", conn2);
            SqlDataReader readerPhongBan = cmdPhongBan.ExecuteReader();
            while (readerPhongBan.Read())
            {
                txtAddMaPB.Items.Add(readerPhongBan["MaPB"].ToString());
            }
            readerPhongBan.Close();

            //Lấy dữ liệu Mã Chức Vụ
            SqlCommand cmdChucVu = new SqlCommand("SELECT MaCV FROM ChucVu", conn2);
            SqlDataReader readerChucVu = cmdChucVu.ExecuteReader();
            while (readerChucVu.Read())
            {
                txtAddMaChucVu.Items.Add(readerChucVu["MaCV"].ToString());
            }
            readerChucVu.Close();

            //Lấy dữ liệu Bậc Lương
            SqlCommand cmdBacLuong = new SqlCommand("SELECT BacLuong FROM Luong", conn2);
            SqlDataReader readerBacLuong = cmdBacLuong.ExecuteReader();
            while (readerBacLuong.Read())
            {
                txtAddBacLuong.Items.Add(readerBacLuong["BacLuong"].ToString());
            }
            readerBacLuong.Close();

            //Đóng kết nối
            conn2.Close();
        }

        //Them Nhan Vien
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if any required fields are empty
            if (string.IsNullOrEmpty(txtAddMaNhanVien.Text) ||
                string.IsNullOrEmpty(txtAddHoTen.Text) ||
                string.IsNullOrEmpty(txtAddQueQuan.Text) ||
                string.IsNullOrEmpty(cBAddGioiTinh.Text) ||
                string.IsNullOrEmpty(txtAddSdt.Text) ||
                string.IsNullOrEmpty(txtAddDanToc.Text) ||
                string.IsNullOrEmpty(txtAddMaChucVu.Text) ||
                string.IsNullOrEmpty(txtAddMaPB.Text) ||
                string.IsNullOrEmpty(txtAddMaTDHV.Text) ||
                string.IsNullOrEmpty(txtAddBacLuong.Text) ||
                string.IsNullOrEmpty(txtMaHD.Text) ||
                string.IsNullOrEmpty(txtLoaiHopDong.Text) ||
                string.IsNullOrEmpty(txtThoiHanHD.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo");
                return;
            }

            //Tao Ket noi
            SqlConnection conn2 = new SqlConnection(conn);
            conn2.Open();

            //Tạo đối tượng thực thi truy vấn
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO dbo.NhanVien (MaNV, HoTenNV, QueQuan, GioiTinh, NgaySinh, SDT, DanToc, MaCV, MaPB, MaTDHV, BacLuong) VALUES (@MaNV, @HoTenNV, @QueQuan, @GioiTinh, @NgaySinh, @SDT, @DanToc, @MaCV, @MaPB, @MaTDHV,@BacLuong)";
            cmd.Connection = conn2;

            //Thiết lập giá trị cho tham số
            cmd.Parameters.AddWithValue("@MaNV", txtAddMaNhanVien.Text);
            cmd.Parameters.AddWithValue("@HoTenNV", txtAddHoTen.Text);
            cmd.Parameters.AddWithValue("@QueQuan", txtAddQueQuan.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", cBAddGioiTinh.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dtPEditNgaySinh.Value);
            cmd.Parameters.AddWithValue("@SDT", txtAddSdt.Text);
            cmd.Parameters.AddWithValue("@DanToc", txtAddDanToc.Text);
            cmd.Parameters.AddWithValue("@MaCV", txtAddMaChucVu.Text);
            cmd.Parameters.AddWithValue("@MaPB", txtAddMaPB.Text);
            cmd.Parameters.AddWithValue("@MaTDHV", txtAddMaTDHV.Text);
            cmd.Parameters.AddWithValue("@BacLuong", txtAddBacLuong.Text);

            //Thực Thi Truy vấn
            int rowAffected = cmd.ExecuteNonQuery();

            if (rowAffected > 0)
            {
                // Lấy mã nhân viên vừa thêm
                int maNV = Convert.ToInt32(txtAddMaNhanVien.Text);

                // Tạo đối tượng thực thi truy vấn
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "INSERT INTO dbo.HopDong (MaNV, MaHD, LoaiHD, NgayKy, ThoiHan) VALUES (@MaNV, @MaHD, @LoaiHD, @NgayKy, @ThoiHan)";
                cmd2.Connection = conn2;

                // Thiết lập giá trị cho các tham số
                cmd2.Parameters.AddWithValue("@MaNV", maNV);
                cmd2.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                cmd2.Parameters.AddWithValue("@LoaiHD", txtLoaiHopDong.Text);
                cmd2.Parameters.AddWithValue("@NgayKy", dtNgayKy.Value);
                cmd2.Parameters.AddWithValue("@ThoiHan", txtThoiHanHD.Text);

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
            

            //Đóng kết nối
            conn2.Close();


            FormMain fMain = (FormMain)Application.OpenForms["FormMain"];
            fMain.LoadData();
            FormListNhanVien fLNhanVien = (FormListNhanVien)Application.OpenForms["FormListNhanVien"];
            fLNhanVien.LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAddMaPB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
