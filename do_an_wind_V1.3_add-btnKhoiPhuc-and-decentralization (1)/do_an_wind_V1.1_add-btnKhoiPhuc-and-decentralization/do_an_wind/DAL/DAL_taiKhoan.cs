using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BEL;
namespace DAL
{
    public class DAL_taiKhoan
    {

        public DataTable getExist(BEL.BEL_taiKhoan account)
        {

            DataTable data = new DataTable(); ;
            string query = @"SELECT ma_nhan_vien from taikhoan where tai_khoan=@taikhoan and mat_khau = @matkhau and da_xoa ='0'";
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
                {
                    connect.Open();
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter para_tk = new SqlParameter();
                    para_tk.ParameterName = "@taikhoan";
                    para_tk.Value = account.taikhoan;
                    SqlParameter para_mk = new SqlParameter();
                    para_mk.ParameterName = "@matkhau";
                    para_mk.Value = account.matkhau;

                    cmd.Parameters.Add(para_tk);
                    cmd.Parameters.Add(para_mk);
                    reader = cmd.ExecuteReader();
                    //reader.Read();
                    data.Load(reader);
                    //reader.Close();
                    connect.Close();
                }
            }
            catch (Exception err)
            {
                throw;
            }
            return data;


        }
        public DataTable getNhanVien(string manv)
        {

            DataTable data = new DataTable();
            string query = "SELECT a.* from nhanvien a, taikhoan b where  b.ma_nhan_vien = a.ma_nhan_vien and b.ma_nhan_vien = @manv";
            try
            {

                using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
                {
                    connect.Open();
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter para_manv = new SqlParameter();
                    para_manv.ParameterName = "@manv";
                    para_manv.Value = manv;
                    cmd.Parameters.Add(para_manv);
                    reader = cmd.ExecuteReader();
                    data.Load(reader);
                    connect.Close();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }

            return data;
        }


    }
}
