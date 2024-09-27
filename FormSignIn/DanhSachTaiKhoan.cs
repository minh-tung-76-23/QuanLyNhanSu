using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSignIn
{
    public class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;
        public static DanhSachTaiKhoan Instance 
        {
            get 
            {
                if (instance == null)
                    instance = new DanhSachTaiKhoan();
                return instance;
             }

            set => instance = value; 
        }

        List<TaiKhoan> listTaiKhoan;

        public List<TaiKhoan> ListTaiKhoan 
        { 
            get => listTaiKhoan; 
            set => listTaiKhoan = value; 
        }

        DanhSachTaiKhoan() 
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("admin","admin", true));
            listTaiKhoan.Add(new TaiKhoan("minhtung1","admin", true));
            listTaiKhoan.Add(new TaiKhoan("minhtung2","admin", false));
        }

    }
}
