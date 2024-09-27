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
    public partial class FormHopDong : Form
    {
        string conn = @"Data Source=MINH-TUNG\SQLEXPRESS05;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
        SqlConnection conn2 = null;
        public FormHopDong()
        {
            InitializeComponent();
        }

        private void FormHopDong_Load(object sender, EventArgs e)
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
            cmd.CommandText = "SELECT * FROM dbo.HopDong";
            cmd.Connection = conn2;

            // Thực thi truy vấn    
            SqlDataReader Dreader = cmd.ExecuteReader();
            lVHopDong.Items.Clear();
            // Hiển thị dữ liệu
            while (Dreader.Read())
            {
                // Lấy dữ liệu từ SqlDataReader
                int MaNV = Dreader.GetInt32(0);
                int MaHD = Dreader.GetInt32(1);
                string LoaiHD = Dreader.GetString(2);
                DateTime NgayKy = Dreader.GetDateTime(3);

                // Kiểm tra giá trị null cho cột ThoiHan
                string ThoiHan;
                if (!Dreader.IsDBNull(4))
                {
                    ThoiHan = Dreader.GetString(4);
                }
                else
                {
                    ThoiHan = "";
                }


                // Hiển thị dữ liệu lên ListView
                ListViewItem lv = new ListViewItem(MaNV.ToString());
                lv.SubItems.Add(MaHD.ToString());
                lv.SubItems.Add(LoaiHD);
                lv.SubItems.Add(NgayKy.ToString("dd/MM/yyyy"));
                lv.SubItems.Add(ThoiHan);
                lVHopDong.Items.Add(lv);

            }

            // Đóng SqlDataReader
            Dreader.Close();

            // Đóng kết nối
            conn2.Close();
        }
    }
}
