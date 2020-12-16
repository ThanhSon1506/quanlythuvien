using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
namespace BAL
{
    public class BAL_nhaxuatban
    {
        public DataTable getAll()
        {
            DAL_nhaxuatban oject = new DAL_nhaxuatban();
            return oject.getAll();
        }
        public DataTable getAllExist()
        {
            DAL_nhaxuatban oject = new DAL_nhaxuatban();
            return oject.getAllExist();
        }
        public bool Themnhaxuatban(BEL.BEL_nhaxuatban nhaxuatban)
        {
            DAL.DAL_nhaxuatban oject = new DAL.DAL_nhaxuatban();
            return oject.insert_nhaxuatban(nhaxuatban);
        }
        public bool Suanhaxuatban(BEL.BEL_nhaxuatban nhaxuatban)
        {
            DAL.DAL_nhaxuatban oject = new DAL.DAL_nhaxuatban();
            return oject.update_nhaxuatban(nhaxuatban);
        }
        public bool capnhat_tragthai(BEL.BEL_nhaxuatban nhaxuatban)
        {
            DAL.DAL_nhaxuatban oject = new DAL.DAL_nhaxuatban();
            return oject.capnhattrangthai(nhaxuatban);
        }
        public bool capnhat_tragthai_moi(BEL.BEL_nhaxuatban nhaxuatban)
        {
            DAL.DAL_nhaxuatban oject = new DAL.DAL_nhaxuatban();
            return oject.capnhattrangthaimoi(nhaxuatban);
        }
        public DataTable searcher_nhaxuatban(string nha_xuat_ban)
        {
            DAL.DAL_nhaxuatban oject = new DAL.DAL_nhaxuatban();
            return oject.searcher_tennhaxuatban(nha_xuat_ban);
        }
        public DataTable searcher_mnhaxuatban(string ma_nha_xuat_ban)
        {
            DAL.DAL_nhaxuatban oject = new DAL.DAL_nhaxuatban();
            return oject.searcher_manhaxuatban(ma_nha_xuat_ban);
        }
        public DataTable searcher_nhaxuatban_quanly(string nha_xuat_ban)
        {
            DAL.DAL_nhaxuatban oject = new DAL.DAL_nhaxuatban();
            return oject.searcher_tennhaxuatban_quanly(nha_xuat_ban);
        }
        public DataTable searcher_mnhaxuatban_quanly(string ma_nha_xuat_ban)
        {
            DAL.DAL_nhaxuatban oject = new DAL.DAL_nhaxuatban();
            return oject.searcher_manhaxuatban_quanly(ma_nha_xuat_ban);
        }
    }
}
