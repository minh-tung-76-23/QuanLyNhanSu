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
    public partial class FormDeletePB : Form
    {
        string conn = @"Data Source=MINH-TUNG\SQLEXPRESS05;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
        SqlConnection conn2 = null;
        public FormDeletePB()
        {
            InitializeComponent();
        }

        private void btnDeletePB_Click(object sender, EventArgs e)
        {
            string maPB = txtDeleteMaPB.Text.Trim();
            delPB(maPB);
        }

        private void delPB (string maPB)
        {
            //Tao Ket noi
            SqlConnection conn2 = new SqlConnection(conn);
            conn2.Open();

            // Tạo đối tượng thực thi truy vấn
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM dbo.PhongBan WHERE MaPB=@maPB";
            cmd.Connection = conn2;
            cmd.Parameters.AddWithValue("@maPB", maPB);

            // Thực thi truy vấn    
            int rowAffected = cmd.ExecuteNonQuery();

            if (rowAffected > 0)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa Phòng " + maPB + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    FormListPB fLPB = (FormListPB)Application.OpenForms["FormListPB"];
                    fLPB.LoadData();
                }
                this.Close(); // Đóng form khi nhấn No hoặc đóng message box
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng nào có mã " + maPB);
            }

            // Đóng kết nối
            conn2.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
