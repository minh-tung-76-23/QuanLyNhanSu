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
    public partial class FormListPB : Form
    {
        // tao chuoi ket noi
        string conn = @"Data Source=MINH-TUNG\SQLEXPRESS05;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
        // toi doi tuong ket noi
        SqlConnection conn2 = null;// Khai báo 1 đối tượng

        public FormListPB()
        {
            InitializeComponent();
        }

        private void FormListPB_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result != DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
        }

        private void FormListPB_Load(object sender, EventArgs e)
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
            cmd.CommandText = "SELECT * FROM dbo.PhongBan";
            cmd.Connection = conn2;

            // Thực thi truy vấn    
            SqlDataReader Dreader = cmd.ExecuteReader();

            lVPhongBan.Items.Clear();
            // Hiển thị dữ liệu
            while (Dreader.Read())
            {
                // Lấy dữ liệu từ SqlDataReader
                int MaPB = Dreader.GetInt32(0);
                string TenPB = Dreader.GetString(1);
                string DiaChi = Dreader.GetString(2);

                // Hiển thị dữ liệu lên ListView
                ListViewItem lv = new ListViewItem(MaPB.ToString());
                lv.SubItems.Add(TenPB);
                lv.SubItems.Add(DiaChi);
                
                lVPhongBan.Items.Add(lv);
            }

            // Đóng SqlDataReader
            Dreader.Close();

            // Đóng kết nối
            conn2.Close();
        }

    }
}
