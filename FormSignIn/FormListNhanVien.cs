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
    public partial class FormListNhanVien : Form
    {
        // tao chuoi ket noi
        string conn = @"Data Source=MINH-TUNG\SQLEXPRESS05;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
        // toi doi tuong ket noi
        SqlConnection conn2 = null;// Khai báo 1 đối tượng
        public FormListNhanVien()
        {
            InitializeComponent();
        }

        private void FormListNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void FormListNhanVien_Load(object sender, EventArgs e)
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
    }
}
