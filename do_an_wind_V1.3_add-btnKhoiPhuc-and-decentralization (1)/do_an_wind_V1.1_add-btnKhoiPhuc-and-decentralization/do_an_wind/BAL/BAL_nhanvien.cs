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
   public class BAL_nhanvien
    {
        public DataTable getAll()
        {
            DAL_nhanvien oject = new DAL_nhanvien();
            return oject.getAll();
        }
       public DataTable getAllExist(){
           DAL_nhanvien oject = new DAL_nhanvien();
            return oject.getAllExist();
       }
        
        public bool Themnhanvien(BEL.BEL_nhanvien nhanvien)
        {
            DAL.DAL_nhanvien oject = new DAL.DAL_nhanvien();
            return oject.insert_nhanvien(nhanvien);
        }
        public bool Suanhanvien(BEL.BEL_nhanvien nhanvien)
        {
            DAL.DAL_nhanvien oject = new DAL.DAL_nhanvien();
            return oject.update_nhanvien(nhanvien);
        }
        public bool capnhat_tragthai(BEL.BEL_nhanvien nhanvien)
        {
            DAL.DAL_nhanvien oject = new DAL.DAL_nhanvien();
            return oject.capnhattrangthai(nhanvien);
        }
        public bool capnhat_tragthai_moi(BEL.BEL_nhanvien nhanvien)
        {
            DAL.DAL_nhanvien oject = new DAL.DAL_nhanvien();
            return oject.capnhattrangthaimoi(nhanvien);
        }
        public DataTable searcher_nhanvien(string nhan_vien)
        {
            DAL.DAL_nhanvien oject = new DAL.DAL_nhanvien();
            return oject.searcher_tennhanvien(nhan_vien);
        }
        public DataTable searcher_mnhanvien(string ma_nhan_vien)
        {
            DAL.DAL_nhanvien oject = new DAL.DAL_nhanvien();
            return oject.searcher_manhanvien(ma_nhan_vien);
        }
        public DataTable searcher_nhanvien_quanly(string nhan_vien)
        {
            DAL.DAL_nhanvien oject = new DAL.DAL_nhanvien();
            return oject.searcher_tennhanvien_quanly(nhan_vien);
        }
        public DataTable searcher_mnhanvien_quanly(string ma_nhan_vien)
        {
            DAL.DAL_nhanvien oject = new DAL.DAL_nhanvien();
            return oject.searcher_manhanvien_quanly(ma_nhan_vien);
        }
        public string Max_nhanvien()
        {
            DAL.DAL_nhanvien oject = new DAL.DAL_nhanvien();
            return oject.Max_nhanvien();
        }
       public string Mahoakitu(string s)
        {
            DAL.DAL_nhanvien oject = new DAL.DAL_nhanvien();
            return oject.Mahoakitu(s);
        }
        public void add_tknv(BEL.BEL_nhanvien tai_khoan_nv, string mahoa_manv)
        {
            DAL.DAL_nhanvien oject = new DAL.DAL_nhanvien();
            oject.add_tknv(tai_khoan_nv, mahoa_manv);
        }
        public void delete_tknv(BEL.BEL_nhanvien tai_khoan_nv)
        {
            DAL.DAL_nhanvien oject = new DAL.DAL_nhanvien();
            oject.delete_tknv(tai_khoan_nv);
        }
        public void restore_tknv(BEL.BEL_nhanvien tai_khoan_nv)
        {
            DAL.DAL_nhanvien oject = new DAL.DAL_nhanvien();
            oject.restore_tknv(tai_khoan_nv);
        }
    }
}
