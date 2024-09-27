using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormSignIn
{
    public partial class FormDeleteStaff : Form
    {

        string conn = @"Data Source=MINH-TUNG\SQLEXPRESS05;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
        SqlConnection conn2 = null;
        public FormDeleteStaff()
        {
            InitializeComponent();
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            string maNv = txtDeleteMaNV.Text.Trim();
            delNhanVien(maNv);
        }

        private void delNhanVien(string maNv)
        {
            // Tạo kết nối
            using (SqlConnection conn2 = new SqlConnection(conn))
            {
                conn2.Open();

                // Xác nhận xem mã nhân viên có tồn tại trong bảng Nhân viên hay không
                using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM dbo.NhanVien WHERE MaNV=@maNV", conn2))
                {
                    checkCmd.Parameters.AddWithValue("@maNV", maNv);
                    int nvCount = (int)checkCmd.ExecuteScalar();

                    if (nvCount == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin có mã " + maNv);
                        return;
                    }
                }

                // Tạo đối tượng thực thi truy vấn xóa trong bảng Hợp đồng
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM dbo.HopDong WHERE MaNV = @MaNV";
                    cmd.Connection = conn2;
                    cmd.Parameters.AddWithValue("@maNV", maNv);

                    try
                    {
                        // Thực thi truy vấn xóa trong bảng Hợp đồng
                        int hdRowAffected = cmd.ExecuteNonQuery();

                        // Tạo đối tượng thực thi truy vấn xóa trong bảng Nhân viên
                        using (SqlCommand delNvCmd = new SqlCommand())
                        {
                            delNvCmd.CommandType = CommandType.Text;
                            delNvCmd.CommandText = "DELETE FROM dbo.NhanVien WHERE MaNV=@maNV";
                            delNvCmd.Connection = conn2;
                            delNvCmd.Parameters.AddWithValue("@maNV", maNv);

                            // Thực thi truy vấn xóa trong bảng Nhân viên
                            int nvRowAffected = delNvCmd.ExecuteNonQuery();

                            if (nvRowAffected > 0 && hdRowAffected > 0)
                            {
                                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin của mã " + maNv + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                if (result == DialogResult.Yes)
                                {
                                    // Cập nhật lại dữ liệu trên các form khác
                                    FormHopDong fHD = (FormHopDong)Application.OpenForms["FormHopDong"];
                                    fHD.LoadData();

                                    FormMain fMain = (FormMain)Application.OpenForms["FormMain"];
                                    fMain.LoadData();

                                    FormListNhanVien fLNhanVien = (FormListNhanVien)Application.OpenForms["FormListNhanVien"];
                                    fLNhanVien.LoadData();
                                }
                                this.Close();
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Xử lý lỗi khi xóa dữ liệu
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
