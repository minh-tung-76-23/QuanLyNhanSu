using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSignIn
{
    public partial class FormSignIn : Form
    {
        List<TaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;

        public static string tkDangSuDung { get; set; }
        public FormSignIn()
        {
            InitializeComponent();
            
        }

        //DANG KY
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form_SignUp fSUp = new Form_SignUp();
            fSUp.ShowDialog();
        }

        //DANG NHAP
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (kiemtraSignIn(txtUserName.Text, txtPassWord.Text))
            {
                FormMain fMain = new FormMain();
                fMain.Show(); 
                tkDangSuDung= txtUserName.Text;
                this.Hide();
                fMain.SignOut += FMain_SignOut;
            } else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Lỗi");
                txtUserName.Focus();
            }
        }

        bool kiemtraSignIn(string txtUserName, string txtPassWord)
        {
            for (int i = 0; i < listTaiKhoan.Count; i++)
            {
                if (txtUserName == listTaiKhoan[i].TenTaiKhoan && txtPassWord == listTaiKhoan[i].MatKhau)
                {
                    Const.LoaiTaiKhoan = listTaiKhoan[i].LoaiTaiKhoan;
                    return true;    
                }
            }
            return false;
        }

        //SAU KHI DANG XUAT
        private void FMain_SignOut(object sender, EventArgs e)
        {
            (sender as FormMain).isThoat= false;
            (sender as FormMain).Close();
            this.Show();
        }

        private void FormSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                e.Cancel = false;
            } else
            {
                e.Cancel = true;
            }
        }
    }
}
