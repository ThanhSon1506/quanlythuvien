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
    public class BAL_theloai
    {
        public DataTable getAll()
        {
            DAL_theloai oject = new DAL_theloai();
            return oject.getAll();
        }
        public DataTable getAllExist()
        {
            DAL_theloai oject = new DAL_theloai();
            return oject.getAllExist();
        }
        public bool Themtheloai(BEL.BEL_theloai theloai)
        {
            DAL.DAL_theloai oject = new DAL.DAL_theloai();
            return oject.insert_theloai(theloai);
        }
        public bool Suatheloai(BEL.BEL_theloai theloai)
        {
            DAL.DAL_theloai oject = new DAL.DAL_theloai();
            return oject.update_theloai(theloai);
        }
        public bool capnhat_tragthai(BEL.BEL_theloai theloai)
        {
            DAL.DAL_theloai oject = new DAL.DAL_theloai();
            return oject.capnhattrangthai(theloai);
        }
        public bool capnhat_tragthai_moi(BEL.BEL_theloai theloai)
        {
            DAL.DAL_theloai oject = new DAL.DAL_theloai();
            return oject.capnhattrangthaimoi(theloai);
        }
        public DataTable searcher_theloai(string the_loai)
        {
            DAL.DAL_theloai oject = new DAL.DAL_theloai();
            return oject.searcher_tentheloai(the_loai);
        }
        public DataTable searcher_mtheloai(string ma_the_loai)
        {
            DAL.DAL_theloai oject = new DAL.DAL_theloai();
            return oject.searcher_matheloai(ma_the_loai);
        }
        public DataTable searcher_theloai_quanly(string the_loai)
        {
            DAL.DAL_theloai oject = new DAL.DAL_theloai();
            return oject.searcher_tentheloai_quanly(the_loai);
        }
        public DataTable searcher_mtheloai_quanly(string ma_the_loai)
        {
            DAL.DAL_theloai oject = new DAL.DAL_theloai();
            return oject.searcher_matheloai_quanly(ma_the_loai);
        }
    }
}
