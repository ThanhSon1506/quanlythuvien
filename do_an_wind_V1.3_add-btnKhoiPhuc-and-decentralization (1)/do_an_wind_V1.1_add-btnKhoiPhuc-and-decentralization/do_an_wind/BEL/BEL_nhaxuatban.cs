using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_nhaxuatban
    {
        private string ma_nha_xuat_ban;
        private string ten_nha_xuat_ban;
        private string dia_chi;
        private string sdt;
        private string email;
        private bool da_xoa;
        public BEL_nhaxuatban() {
            this.ma_nha_xuat_ban = "";
            this.ten_nha_xuat_ban = "";
            this.dia_chi = "";
            this.sdt = "";
            this.email = "";
            this.da_xoa = false;
        }
        public BEL_nhaxuatban(string manhaxuatban, string tennhaxuatban, string diachi, string dienthoai, string email, bool daxoa)
        {
            this.ma_nha_xuat_ban = manhaxuatban;
            this.ten_nha_xuat_ban = tennhaxuatban;
            this.dia_chi = diachi;
            this.sdt = dienthoai;
            this.email = email; 
            this.da_xoa = daxoa;
        }
        public string Ma_nha_xuat_ban {
            get { return ma_nha_xuat_ban; }
            set { ma_nha_xuat_ban = value; }
        }
        public string Ten_nha_xuat_ban
        {
            get { return ten_nha_xuat_ban; }
            set { ten_nha_xuat_ban = value; }
        }
        public string Dia_chi
        {
            get { return dia_chi; }
            set { dia_chi = value; }
        }
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public bool Da_xoa
        {
            get { return da_xoa; }
            set { da_xoa = value; }
        }
    }
}
