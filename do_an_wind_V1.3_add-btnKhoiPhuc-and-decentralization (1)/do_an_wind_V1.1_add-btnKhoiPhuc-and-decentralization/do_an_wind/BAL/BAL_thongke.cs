using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BEL;
namespace BAL
{
    public class BAL_thongke
    {
        public DataTable LayDanhsachPhieumuon()
        {
            try
            {
                DAL.DAL_thongke objdal = new DAL.DAL_thongke();
                return objdal.Docthongke();

            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable LayDanhsach_count_phieumuon()
        {
            try
            {
                DAL.DAL_thongke objdal = new DAL.DAL_thongke();
                return objdal.thongke_count_phieumuon();

            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable LayDanhsach_count_sach()
        {
            try
            {
                DAL.DAL_thongke objdal = new DAL.DAL_thongke();
                return objdal.thongke_count_sach();

            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable LayDanhsach_sum_tien()
        {
            try
            {
                DAL.DAL_thongke objdal = new DAL.DAL_thongke();
                return objdal.thongke_sum_tien();

            }
            catch (Exception err)
            {
                throw;
            }
        }

    }
}
