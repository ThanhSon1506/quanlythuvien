using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BEL;
using DAL;

namespace BAL
{
    public class BAL_taiKhoan
    {

        public static DataTable getExist(BEL.BEL_taiKhoan account)
        {
            DAL_taiKhoan obj = new DAL_taiKhoan();
            return obj.getExist(account);
        }
        public static DataTable getNhanVien(string manv)
        {
            DAL.DAL_taiKhoan obj = new DAL.DAL_taiKhoan();
            return obj.getNhanVien(manv);
        }
    }
}
