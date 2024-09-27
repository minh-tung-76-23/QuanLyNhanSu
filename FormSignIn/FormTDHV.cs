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
    public partial class FormTDHV : Form
    {
        string conn = @"Data Source=MINH-TUNG\SQLEXPRESS05;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
        SqlConnection conn2 = null;
        public FormTDHV()
        {
            InitializeComponent();
        }

        private void FormTDHV_Load(object sender, EventArgs e)
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
            cmd.CommandText = "SELECT * FROM dbo.TrinhDoHocVan";
            cmd.Connection = conn2;

            // Thực thi truy vấn    
            SqlDataReader Dreader = cmd.ExecuteReader();
            lVTDHV.Items.Clear();
            // Hiển thị dữ liệu
            while (Dreader.Read())
            {
                // Lấy dữ liệu từ SqlDataReader
                string MaTDHV = Dreader.GetString(0);
                string TenTDHV = Dreader.GetString(1);
                string ChuyenNganh = Dreader.GetString(2);
                

                // Hiển thị dữ liệu lên ListView
                ListViewItem lv = new ListViewItem(MaTDHV);
                lv.SubItems.Add(TenTDHV);
                lv.SubItems.Add(ChuyenNganh);
                lVTDHV.Items.Add(lv);
            }

            // Đóng SqlDataReader
            Dreader.Close();

            // Đóng kết nối
            conn2.Close();
        }
    }
}
