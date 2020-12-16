using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_nhanvien
    {
        private string ma_nhan_vien;
        private string ten_nhan_vien;
        private bool gioi_tinh;
        private DateTime ngay_sinh;
        private string dia_chi;
        private bool quan_ly;
        private string sdt;
        private bool da_xoa;
        public BEL_nhanvien()
        {
            this.ma_nhan_vien = "1001";
            this.ten_nhan_vien = "";
            this.gioi_tinh = false;
            this.ngay_sinh = new DateTime();
            this.dia_chi = "";
            this.quan_ly = true;
            this.sdt = "";
            this.da_xoa = false;
        }
        public BEL_nhanvien(string manhanvien, string tennhanvien, bool gioitinh, DateTime ngaysinh, string diachi, bool quanly, string sdt, bool daxoa)
        {
            this.ma_nhan_vien = manhanvien;
            this.ten_nhan_vien = tennhanvien;
            this.gioi_tinh = gioitinh;
            this.ngay_sinh = ngaysinh;
            this.dia_chi = diachi;
            this.quan_ly = quanly;
            this.sdt = sdt;
            this.da_xoa = daxoa;
        }
        public string Ma_nhan_vien
        {
            get { return ma_nhan_vien; }
            set { ma_nhan_vien = value; }
        }
        public string Ten_nhan_vien
        {
            get { return ten_nhan_vien; }
            set { ten_nhan_vien = value; }
        }
        public bool Gioi_tinh
        {
            get { return gioi_tinh; }
            set { gioi_tinh = value; }
        }
        public DateTime Ngay_sinh {

            get { return ngay_sinh; }
            set { ngay_sinh = value; }
        }
        public string Dia_chi
        {

            get { return dia_chi; }
            set { dia_chi = value; }
        }
        public bool Quan_ly
        {

            get { return quan_ly; }
            set { quan_ly = value; }
        }
        public string Sdt
        {

            get { return sdt; }
            set { sdt = value; }
        }
        public bool Da_xoa
        {

            get { return da_xoa; }
            set { da_xoa = value; }
        }
    }
}
