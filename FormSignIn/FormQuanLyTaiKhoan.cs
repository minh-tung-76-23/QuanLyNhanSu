using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static FormSignIn.FormSignIn;

namespace FormSignIn
{
    public partial class FormQuanLyTaiKhoan : Form
    {
        List<string> listLoaiTK = new List<string>()
        {
            "Quản Lý",
            "Nhân Viên"
        };

        int index = -1;
        public FormQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        void loadListUser()
        {
            dtGVQLTK.DataSource = null;
            dtGVQLTK.DataSource = DanhSachTaiKhoan.Instance.ListTaiKhoan;
            dtGVQLTK.Refresh(); 
        }

        //Load List TK
        private void FormQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            cBUser.DataSource = listLoaiTK;
            loadListUser();
        }

        private void dtGVQLTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex; 
            
            if (index < 0)
                 return;

            txtUserName.Text = dtGVQLTK.Rows[index].Cells[0].Value.ToString();
            txtPW.Text = dtGVQLTK.Rows[index].Cells[1].Value.ToString();

            switch (DanhSachTaiKhoan.Instance.ListTaiKhoan[index].LoaiTaiKhoan) 
            {
                case true:
                    cBUser.Text = "Quản Lý";
                    break;

                case false:
                    cBUser.Text = "Nhân Viên";
                    break;
            }
        }
        //Them Tai Khoan
        private void btnAddTK_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Chưa có dữ liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userName = txtUserName.Text;
            string passWord = txtPW.Text;
            bool loaiTK = false;

            switch (cBUser.Text)
            {
                case "Quản Lý":
                    loaiTK= true;
                    break;

                case "Nhân Viên":
                    loaiTK= false;
                    break;
            }

            // Kiểm tra xem tài khoản đã tồn tại hay chưa
            if (DanhSachTaiKhoan.Instance.ListTaiKhoan.Any(tk => tk.TenTaiKhoan == userName))
            {
                MessageBox.Show("Tài khoản đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DanhSachTaiKhoan.Instance.ListTaiKhoan.Add (new TaiKhoan(userName, passWord, loaiTK));

            loadListUser(); 
        }

        //Sua Tai Khoan
        private void btnEditTK_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Chưa có dữ liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userName = txtUserName.Text;
            string passWord = txtPW.Text;
            bool loaiTK = false;

            switch (cBUser.Text)
            {
                case "Quản Lý":
                    loaiTK = true;
                    break;

                case "Nhân Viên":
                    loaiTK = false;
                    break;
            }

            DanhSachTaiKhoan.Instance.ListTaiKhoan[index].TenTaiKhoan = userName;
            DanhSachTaiKhoan.Instance.ListTaiKhoan[index].MatKhau = passWord;
            DanhSachTaiKhoan.Instance.ListTaiKhoan[index].LoaiTaiKhoan = loaiTK;

            loadListUser();
        }

        //Xoa Tai Khoan
        
        private void btnDelTK_Click(object sender, EventArgs e)
        {
            string tkDuocDung = tkDangSuDung;   
            if (index < 0 || index >= DanhSachTaiKhoan.Instance.ListTaiKhoan.Count)
            {
                MessageBox.Show("Chỉ số không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtUserName.Text == tkDuocDung)
            {
                MessageBox.Show("Không thể xóa tài khoản đang được sử dụng để đăng nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DanhSachTaiKhoan.Instance.ListTaiKhoan.RemoveAt(index);
            loadListUser();

        }
    }
}
