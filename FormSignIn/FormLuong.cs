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
    public partial class FormLuong : Form
    {
        string conn = @"Data Source=MINH-TUNG\SQLEXPRESS05;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
        SqlConnection conn2 = null;
        public FormLuong()
        {
            InitializeComponent();
        }

        private void FormLuong_Load(object sender, EventArgs e)
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
            cmd.CommandText = "SELECT * FROM dbo.Luong";
            cmd.Connection = conn2;

            // Thực thi truy vấn    
            SqlDataReader Dreader = cmd.ExecuteReader();
            lVLuong.Items.Clear();
            // Hiển thị dữ liệu
            while (Dreader.Read())
            {
                int BacLuong = Dreader.GetInt32(Dreader.GetOrdinal("BacLuong"));
                int LuongCoBan = Dreader.GetInt32(Dreader.GetOrdinal("LuongCoBan"));
                float HeSoLuong = (float)Dreader.GetDouble(Dreader.GetOrdinal("HeSoLuong"));
                int PhuCap = Dreader.GetInt32(Dreader.GetOrdinal("PhuCap"));

                // Định dạng số nguyên với dấu phân cách hàng nghìn
                string formattedLuongCoBan = LuongCoBan.ToString("N0");
                string formattedPhuCap = PhuCap.ToString("N0");

                // Hiển thị dữ liệu lên ListView
                ListViewItem lv = new ListViewItem(BacLuong.ToString());
                lv.SubItems.Add(formattedLuongCoBan);
                lv.SubItems.Add(HeSoLuong.ToString());
                lv.SubItems.Add(formattedPhuCap);
                lVLuong.Items.Add(lv);

            }

            // Đóng SqlDataReader
            Dreader.Close();

            // Đóng kết nối
            conn2.Close();
        }
    }
}
