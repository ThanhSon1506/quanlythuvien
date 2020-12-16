using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using BEL;
namespace BAL
{
    public class BAL_phieumuon
    {
        public DataTable ChuaTra()
        {
            DAL_phieumuon pm = new DAL_phieumuon();
            return pm.ChuaTra();
        }
        public DataTable GetAll()
        {
            DAL_phieumuon pm = new DAL_phieumuon();
            return pm.GetAll();
        }
        public DataTable thongtinphieu(string maphieu)
        {
            DAL_phieumuon pm = new DAL_phieumuon();
            return pm.thongtinphieu(maphieu);
        }
        public bool insert_Phieu(BEL_phieumuon phieu)
        {
            DAL_phieumuon pm = new DAL_phieumuon();
            return pm.insert_Phieu(phieu);
        }
        public bool KiemTraDocGia_tontai(string DocGia)
        {
            DAL_phieumuon pm = new DAL_phieumuon();
            return pm.KiemTraDocGia_tontai(DocGia);
        }
        public bool KiemTraDocGia_dangmuon(string DocGia)
        {
            DAL_phieumuon pm = new DAL_phieumuon();
            return pm.KiemTraDocGia_dangmuon(DocGia);
        }
        public bool xatnhantra(string maphieu)
        {
            DAL_phieumuon pm = new DAL_phieumuon();
            return pm.xatnhantra(maphieu);
        }
        public bool xoaphieu(string maphieu)
        {
            DAL_phieumuon pm = new DAL_phieumuon();
            return pm.xoaphieu(maphieu);
        }
        public bool khoiphuc(string maphieu)
        {
            DAL_phieumuon pm = new DAL_phieumuon();
            return pm.khoiphuc(maphieu);
        }
        public DataTable searcher_phiemuon(string maphieu)
        {
            DAL_phieumuon pm = new DAL_phieumuon();
            return pm.searcher_phieumuon(maphieu);
        }

    }
}
