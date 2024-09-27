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
using System.Text.RegularExpressions;

namespace FormSignIn
{
    public partial class FormEditPB : Form
    {
        string conn = @"Data Source=MINH-TUNG\SQLEXPRESS05;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
        SqlConnection conn2 = null;
        public FormEditPB()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string maPB = txtEditMaPB.Text.Trim();
            string tenPB = txtEditTenPB.Text.Trim();
            string diaChi = txtEditDiaChi.Text.Trim();

            // Tạo kết nối
            using (SqlConnection conn2 = new SqlConnection(conn))
            {
                conn2.Open();

                // Tạo đối tượng thực thi truy vấn
                SqlCommand cmd = new SqlCommand("UPDATE dbo.PhongBan SET TenPB = @TenPB, DiaChi = @DiaChi WHERE MaPB = @MaPB", conn2);
                cmd.Parameters.AddWithValue("@MaPB", maPB);
                cmd.Parameters.AddWithValue("@TenPB", tenPB);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                // Thực thi câu lệnh SQL
                int result = cmd.ExecuteNonQuery();

                // Đóng kết nối
                conn2.Close();

                // Kiểm tra kết quả thực thi
                if (result > 0)
                {
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    MessageBox.Show("Lưu không thành công");
                }

                FormListPB fLPB = (FormListPB)Application.OpenForms["FormListPB"];
                fLPB.LoadData(); 
            }
        }

        private void txtEditMaPB_TextChanged(object sender, EventArgs e)
        {
            string maPB = txtEditMaPB.Text.Trim();
            if (maPB.Length > 0)
            {
                LoadPB(maPB);
            }
            else
            {
                txtEditTenPB.Text = "";
                txtEditDiaChi.Text = "";
            }
        }

        private void LoadPB(string maPB)
        {
            //Tao Ket noi
            SqlConnection conn2 = new SqlConnection(conn);
            conn2.Open();

            //Tạo đối tượng thực thi truy vấn
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.PhongBan WHERE MaPB = @MaPB", conn2);
            cmd.Parameters.AddWithValue("@MaPB", maPB);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtEditTenPB.Text = reader.GetString(reader.GetOrdinal("TenPB"));
                txtEditDiaChi.Text = reader.GetString(reader.GetOrdinal("DiaChi"));
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
