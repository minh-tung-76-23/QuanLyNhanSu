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
    public partial class FormAddPB : Form
    {
        string conn = @"Data Source=MINH-TUNG\SQLEXPRESS05;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
        SqlConnection conn2 = null;
        public FormAddPB()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if any required fields are empty
            if (string.IsNullOrEmpty(txtAddMaPB.Text) ||
                string.IsNullOrEmpty(txtAddTenPB.Text) ||
                string.IsNullOrEmpty(txtAddDiaChi.Text))
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
            cmd.CommandText = "INSERT INTO dbo.PhongBan (MaPB, TenPB, DiaChi) VALUES (@MaPB, @TenPB, @DiaChi)";
            cmd.Connection = conn2;

            //Thiết lập giá trị cho tham số
            cmd.Parameters.AddWithValue("@MaPB", txtAddMaPB.Text);
            cmd.Parameters.AddWithValue("@TenPB", txtAddTenPB.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtAddDiaChi.Text);

            //Thực Thi Truy vấn
            int rowAffected = cmd.ExecuteNonQuery();

            //Đóng kết nối
            conn2.Close();

            if (rowAffected > 0)
            {
                MessageBox.Show("Thêm Thành Công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại", "Thông báo");
            }

            FormListPB fLPB = (FormListPB)Application.OpenForms["FormListPB"];
            fLPB.LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
