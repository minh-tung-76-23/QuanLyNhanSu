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
    public partial class FormChucVu : Form
    {
        string conn = @"Data Source=MINH-TUNG\SQLEXPRESS05;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
        SqlConnection conn2 = null;
        public FormChucVu()
        {
            InitializeComponent();
        }

        private void FormChucVu_Load(object sender, EventArgs e)
        {
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
            cmd.CommandText = "SELECT * FROM dbo.ChucVu";
            cmd.Connection = conn2;

            // Thực thi truy vấn    
            SqlDataReader Dreader = cmd.ExecuteReader();
            lVChucVu.Items.Clear();
            // Hiển thị dữ liệu
            while (Dreader.Read())
            {
                // Lấy dữ liệu từ SqlDataReader
                string MaCV = Dreader.GetString(0);
                string TenCV = Dreader.GetString(1);
                

                // Hiển thị dữ liệu lên ListView
                ListViewItem lv = new ListViewItem(MaCV);
                lv.SubItems.Add(TenCV);
                lVChucVu.Items.Add(lv);
            }

            // Đóng SqlDataReader
            Dreader.Close();

            // Đóng kết nối
            conn2.Close();
        }
    }
}
