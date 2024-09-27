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

namespace FormSignIn
{
    public partial class Form_SignUp : Form
    {
        public Form_SignUp()
        {
            InitializeComponent();
        }

        //Thoat Form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string pW1 = txtPW1.Text;
            string pW2 = txtPW2.Text;
            string user = cBUser.Text;
            bool loaiTk = false;

            switch (cBUser.Text)
            {
                case "Quản Lý":
                    loaiTk = true;
                    break;

                case "Nhân Viên":
                    loaiTk = false;
                    break;
            }

            // Kiểm tra xem tài khoản đã tồn tại hay chưa
            if (DanhSachTaiKhoan.Instance.ListTaiKhoan.Any(tk => tk.TenTaiKhoan == userName))
            {
                MessageBox.Show("Tài khoản đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DanhSachTaiKhoan.Instance.ListTaiKhoan.Add(new TaiKhoan(userName, pW2, loaiTk));
            }
        }

            private void txtPW2_TextChanged(object sender, EventArgs e)
        {
            string pW1 = txtPW1.Text.Trim();
            string pW2 = txtPW2.Text.Trim();

            if (pW1 != pW2)
            {
                lbError.Text = "Mật khẩu nhập lại không trùng khớp.";
                btnSignUp.Enabled = false;
            }
            else
            {
                lbError.Text = "";
                btnSignUp.Enabled = true;
            }
        }
    }
}
