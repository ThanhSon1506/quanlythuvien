using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_sach
    {
      private  string ma_sach;
      private string ten_sach;
      private int so_luong;
      private int nam_xuat_ban;
      private string nha_xuat_ban;
      private string tac_gia;
      private string the_loai;
      private string gia_muon;
      private DateTime ngay_nhap;
      private bool da_xoa;

        public BEL_sach()
        {
            this.ma_sach = "";
            this.ten_sach = "";
            this.so_luong = 0;
            this.nam_xuat_ban = 1;
            this.nha_xuat_ban = "";
            this.tac_gia = "";
            this.the_loai = "";
            this.gia_muon = "";
            this.ngay_nhap = new DateTime();
            this.da_xoa = false;
        }
        public BEL_sach(string _ma_sach, string _ten_sach, int _so_luong, int _nam_xuat_ban,string _nha_xuat_ban, string _tac_gia, string _the_loai, string _gia_muon,DateTime _ngay_nhap, bool _da_xoa)
        {
            this.ma_sach = _ma_sach;
            this.ten_sach = _ten_sach;
            this.so_luong = _so_luong;
            this.nam_xuat_ban = _nam_xuat_ban;
            this.nha_xuat_ban = _nha_xuat_ban;
            this.tac_gia = _tac_gia;
            this.the_loai = _the_loai;
            this.gia_muon = _gia_muon;
            this.ngay_nhap = _ngay_nhap;
            this.da_xoa = _da_xoa;
        }
        public bool Da_xoa
        {
            get { return da_xoa; }
            set { da_xoa = value; }
        }

        public DateTime Ngay_nhap
        {
            get { return ngay_nhap; }
            set { ngay_nhap = value; }
        }

        public string Gia_muon
        {
            get { return gia_muon; }
            set { gia_muon = value; }
        }

        public string The_loai
        {
            get { return the_loai; }
            set { the_loai = value; }
        }

        public string Tac_gia
        {
            get { return tac_gia; }
            set { tac_gia = value; }
        }
        public int Nam_xuat_ban
        {
            get { return nam_xuat_ban; }
            set { nam_xuat_ban = value; }
        }

        public string Nha_xuat_ban
        {
            get { return nha_xuat_ban; }
            set { nha_xuat_ban = value; }
        }

        public int So_luong
        {
            get { return so_luong; }
            set { so_luong = value; }
        }

        public string Ten_sach
        {
            get { return ten_sach; }
            set { ten_sach = value; }
        }

        public string Ma_sach
        {
            get { return ma_sach; }
            set { ma_sach = value; }
        }
    }
}
