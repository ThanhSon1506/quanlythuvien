using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_DocGia
    {
        private DateTime ngay_sinh;
        private string ma_doc_gia;
        private string ten_doc_gia;
        private string dia_chi;
        private string cmnd;
        private string sdt;
        private bool gio_tinh;
        private bool da_xoa;

        public BEL_DocGia()
        {
            this.ngay_sinh = new DateTime();
            this.ma_doc_gia = "";
            this.Ten_doc_gia ="";
            this.dia_chi ="";
            this.cmnd = "";
            this.sdt = "";
            this.gio_tinh = true;
            this.da_xoa = false;
        }
        public BEL_DocGia(string ma,string ten,bool gio_tinh,DateTime ngaysinh,string diachi,string cmnd,string sdt,bool daxoa)
        {
            this.ma_doc_gia = ma;
            this.ngay_sinh = ngaysinh;
            this.Ten_doc_gia = ten;
            this.dia_chi = diachi;
            this.cmnd = cmnd;
            this.sdt = sdt;
            this.gio_tinh = gio_tinh;
            this.da_xoa = daxoa;
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

        public DateTime Ngay_sinh
        {
            get { return ngay_sinh; }
            set { ngay_sinh = value; }
        }

        public string Dia_chi
        {
            get { return dia_chi; }
            set { dia_chi = value; }
        }

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        
        public bool Gio_tinh
        {
            get { return gio_tinh; }
            set { gio_tinh = value; }
        }

        public string Ten_doc_gia
        {
            get { return ten_doc_gia; }
            set { ten_doc_gia = value; }
        }

        public string Ma_doc_gia
        {
            get { return ma_doc_gia; }
            set { ma_doc_gia = value; }
        }
    }
}
