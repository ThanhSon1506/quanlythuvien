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
    public class BAL_tacgia
    {
        public DataTable getAll()
        {
            DAL_tacgia oject = new DAL_tacgia();
            return oject.getAll();
        }
        public DataTable getAllExist()
        {
            DAL_tacgia oject = new DAL_tacgia();
            return oject.getAllExist();
        }
        public bool Themtacgia(BEL.BEL_tacgia tacgia)
        {
           DAL_tacgia oject = new DAL_tacgia();
            return oject.insert_tacgia(tacgia);
        }
        public bool Suatacgia(BEL.BEL_tacgia tacgia)
        {
           DAL_tacgia oject = new DAL_tacgia();
            return oject.update_tacgia(tacgia);
        }
        public bool capnhat_tragthai(BEL.BEL_tacgia tacgia)
        {
           DAL_tacgia oject = new DAL_tacgia();
            return oject.capnhattrangthai(tacgia);
        }
        public DataTable searcher_tacgia(string doc_gia)
        {
           DAL_tacgia oject = new DAL_tacgia();
            return oject.searcher_tentacgia(doc_gia);
        }
        public DataTable searcher_mtacgia(string ma_doc_gia)
        {
           DAL_tacgia oject = new DAL_tacgia();
            return oject.searcher_matacgia(ma_doc_gia);
        }
        public DataTable searcher_tacgia_quanly(string doc_gia)
        {
            DAL_tacgia oject = new DAL_tacgia();
            return oject.searcher_tentacgia_quanly(doc_gia);
        }
        public DataTable searcher_mtacgia_quanly(string ma_doc_gia)
        {
            DAL_tacgia oject = new DAL_tacgia();
            return oject.searcher_matacgia_quanly(ma_doc_gia);
        }
        public bool capnhat_trangthai_moi(BEL.BEL_tacgia tacgia)
        {
            DAL_tacgia oject =new DAL_tacgia();
            return oject.capnhat_trangthai_xoa(tacgia);
        }
    }
}
