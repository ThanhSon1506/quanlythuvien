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
    public class BAL_docGia
    {
        public DataTable getAllExist()
        {
            DAL.DAL_docGia oject = new DAL.DAL_docGia();
            return oject.getAllExist();
        }

        public DataTable getAll()
        {
            DAL.DAL_docGia oject = new DAL.DAL_docGia();
            return oject.getAll();
        }

        public  bool Themdocgia(BEL.BEL_DocGia docgia) {
            DAL.DAL_docGia oject = new DAL.DAL_docGia();
            return oject.insert_docgia(docgia);
        }
        public bool Suadocgia(BEL.BEL_DocGia docgia)
        {
            DAL.DAL_docGia oject = new DAL.DAL_docGia();
            return oject.update_docgia(docgia);
        }
        public bool capnhat_tragthai(BEL.BEL_DocGia docgia) {
            DAL.DAL_docGia oject = new DAL.DAL_docGia();
            return oject.capnhattrangthai(docgia);
        }
        public DataTable searcher_docgia(string doc_gia)
        {
            DAL.DAL_docGia oject = new DAL.DAL_docGia();
            return oject.searcher_tendocgia(doc_gia);
        }
        public DataTable searcher_mdocgia(string ma_doc_gia)
        {
            DAL.DAL_docGia oject = new DAL.DAL_docGia();
            return oject.searcher_madocgia(ma_doc_gia);
        }
        public DataTable searcher_docgia_quanly(string doc_gia)
        {
            DAL.DAL_docGia oject = new DAL.DAL_docGia();
            return oject.searcher_tendocgia_quanly(doc_gia);
        }
        public DataTable searcher_mdocgia_quanly(string ma_doc_gia)
        {
            DAL.DAL_docGia oject = new DAL.DAL_docGia();
            return oject.searcher_madocgia_quanly(ma_doc_gia);
        }
        public bool capnhat_tragthai_moi(BEL.BEL_DocGia docgia)
        {
            DAL.DAL_docGia oject = new DAL.DAL_docGia();
            return oject.capnhattrangthaimoi(docgia);
        }
    }
}
