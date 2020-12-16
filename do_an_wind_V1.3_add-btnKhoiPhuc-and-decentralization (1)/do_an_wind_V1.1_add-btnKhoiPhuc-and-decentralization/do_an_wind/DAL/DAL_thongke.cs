using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEL;
namespace DAL
{
    public class DAL_thongke
    {
          public DataTable Docthongke()
        {
            DataTable data = new DataTable();
            try
            {
                string query = @"SELECT     dbo.thongtinphieumuon.ma_phieu_muon, dbo.thongtinphieumuon.ma_sach, dbo.sach.ten_sach, dbo.phieumuon.tong_tien, dbo.phieumuon.ngay_tra, 
                      dbo.phieumuon.ngay_muon
        FROM         dbo.phieumuon INNER JOIN
                      dbo.thongtinphieumuon ON dbo.phieumuon.ma_phieu = dbo.thongtinphieumuon.ma_phieu_muon INNER JOIN
                      dbo.sach ON dbo.thongtinphieumuon.ma_sach = dbo.sach.ma_sach and dbo.thongtinphieumuon.da_xoa=@da_xoa         
";
           
                using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataReader reader = null;
                    SqlParameter param = new SqlParameter();
                    cmd.Parameters.Add(param);
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    reader = cmd.ExecuteReader();
                    data.Load(reader);
                    // SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString.connectionstring);
                    // adapter.Fill(data);
                    connect.Close();
                }
            }
            catch (Exception err)
            {
                throw;
            }

            return data;
        }

        public DataTable thongke_count_phieumuon()
        {
            DataTable data = new DataTable();
            try
            {
                string query = @"select C.ma_phieu_muon,COUNT(C.ma_phieu_muon)as so_luong from phieumuon A,sach B, thongtinphieumuon C where A.ma_phieu=C.ma_phieu_muon and B.ma_sach =C.ma_sach and C.da_xoa=@da_xoa
                                group by C.ma_phieu_muon";

                using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataReader reader = null;
                    SqlParameter param = new SqlParameter();
                    cmd.Parameters.Add(param);
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    reader = cmd.ExecuteReader();
                    data.Load(reader);
                    // SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString.connectionstring);
                    // adapter.Fill(data);
                    connect.Close();
                }
            }
            catch (Exception err)
            {
                throw;
            }

            return data;
        }

        public DataTable thongke_count_sach()
        {
            DataTable data = new DataTable();
            try
            {
                string query = @"select C.ma_sach,COUNT(C.ma_sach)as so_luong,B.ten_sach from phieumuon A,sach B, thongtinphieumuon C where A.ma_phieu=C.ma_phieu_muon and B.ma_sach =C.ma_sach and C.da_xoa=@da_xoa
                                group by C.ma_sach,B.ten_sach";

                using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataReader reader = null;
                    SqlParameter param = new SqlParameter();
                    cmd.Parameters.Add(param);
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    reader = cmd.ExecuteReader();
                    data.Load(reader);
                    // SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString.connectionstring);
                    // adapter.Fill(data);
                    connect.Close();
                }
            }
            catch (Exception err)
            {
                throw;
            }

            return data;
        }

        public DataTable thongke_sum_tien()
        {
            DataTable data = new DataTable();
            try
            {
                string query = @"select C.ma_phieu_muon,SUM(B.gia_muon)as tien from phieumuon A,sach B, thongtinphieumuon C where A.ma_phieu=C.ma_phieu_muon and B.ma_sach =C.ma_sach and C.da_xoa=@da_xoa
                                group by C.ma_phieu_muon";

                using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataReader reader = null;
                    SqlParameter param = new SqlParameter();
                    cmd.Parameters.Add(param);
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    reader = cmd.ExecuteReader();
                    data.Load(reader);
                    // SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString.connectionstring);
                    // adapter.Fill(data);
                    connect.Close();
                }
            }
            catch (Exception err)
            {
                throw;
            }

            return data;
        }
    }
 }
