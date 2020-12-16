using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_phieumuon
    {
        string ma;
        string doc_gia;
        string nhan_vien;
        DateTime ngay_muon;
        DateTime ngay_tra;
        string tong_tien;
        bool trang_thai;
        bool da_xoa;
        List<string> dsmuon;

        public BEL_phieumuon()
        {
            ma = "";
            doc_gia = "";
            nhan_vien = "";
            ngay_muon = new DateTime();
            ngay_tra = new DateTime();
            tong_tien = "";
            trang_thai = false;
            da_xoa = false;
            dsmuon = new List<string>();
        }
        
        public void Themsach(string sach)
        {
            dsmuon.Add(sach);
        }

        public void xoasach(string sach)
        {
            dsmuon.Remove(sach);
        }

        public List<string> Dsmuon
        {
            get { return dsmuon; }
            set { dsmuon = value; }
        }

        public bool Da_xoa
        {
            get { return da_xoa; }
            set { da_xoa = value; }
        }

        public bool Trang_thai
        {
            get { return trang_thai; }
            set { trang_thai = value; }
        }

        public string Tong_tien
        {
            get { return tong_tien; }
            set { tong_tien = value; }
        }

        public DateTime Ngay_tra
        {
            get { return ngay_tra; }
            set { ngay_tra = value; }
        }

        public DateTime Ngay_muon
        {
            get { return ngay_muon; }
            set { ngay_muon = value; }
        }

        public string Nhan_vien
        {
            get { return nhan_vien; }
            set { nhan_vien = value; }
        }

        public string Doc_gia
        {
            get { return doc_gia; }
            set { doc_gia = value; }
        }
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
    }
}
