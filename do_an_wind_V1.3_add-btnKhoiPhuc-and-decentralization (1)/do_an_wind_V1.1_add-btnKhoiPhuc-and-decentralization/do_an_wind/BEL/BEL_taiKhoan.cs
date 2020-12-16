using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_taiKhoan
    {
        public string taikhoan;
        public string matkhau;

        public BEL_taiKhoan()
        {
            this.taikhoan = "";
            this.matkhau = "";
        }

        public BEL_taiKhoan(string _taikhoan, string _matkhau)
        {
            this.taikhoan = _taikhoan;
            this.matkhau = _matkhau;
        }

        public string tai_khoan
        {
            get { return this.taikhoan; }
            set { this.taikhoan = value;}
        }

        public string mat_khau
        {
            get { return this.matkhau; }
            set { this.matkhau = value;}
        }
    }
}
