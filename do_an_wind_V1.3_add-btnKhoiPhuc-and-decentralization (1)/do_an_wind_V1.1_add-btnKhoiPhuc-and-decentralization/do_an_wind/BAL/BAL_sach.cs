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
    public class BAL_sach
    {
        public DataTable getAll()
        {
            DAL.DAL_sach oject = new DAL.DAL_sach();
            return oject.getAll();
        }
        public DataTable getAllExist()
        {
            DAL.DAL_sach oject = new DAL.DAL_sach();
            return oject.getAllExist();
        }
        public bool Themsach(BEL.BEL_sach sach)
        {
            DAL.DAL_sach oject = new DAL.DAL_sach();
            return oject.insert_sach(sach);
        }
        public bool Suasach(BEL.BEL_sach sach)
        {
            DAL.DAL_sach oject = new DAL.DAL_sach();
            return oject.update_sach(sach);
        }
        public bool capnhat_tragthai(BEL.BEL_sach sach)
        {
            DAL.DAL_sach oject = new DAL.DAL_sach();
            return oject.capnhattrangthai(sach);
        }
        public bool capnhat_tragthai_moi(BEL.BEL_sach sach)
        {
            DAL.DAL_sach oject = new DAL.DAL_sach();
            return oject.capnhattrangthaimoi(sach);
        }
        public DataTable searcher_sach(string doc_gia)
        {
            DAL.DAL_sach oject = new DAL.DAL_sach();
            return oject.searcher_tensach(doc_gia);
        }
        public DataTable searcher_msach(string ma_sach)
        {
            DAL.DAL_sach oject = new DAL.DAL_sach();
            return oject.searcher_masach(ma_sach);
        }
        public DataTable searcher_sach_quanly(string doc_gia)
        {
            DAL.DAL_sach oject = new DAL.DAL_sach();
            return oject.searcher_tensach_quanly(doc_gia);
        }
        public DataTable searcher_msach_quanly(string ma_sach)
        {
            DAL.DAL_sach oject = new DAL.DAL_sach();
            return oject.searcher_masach_quanly(ma_sach);
        }
    }
}
