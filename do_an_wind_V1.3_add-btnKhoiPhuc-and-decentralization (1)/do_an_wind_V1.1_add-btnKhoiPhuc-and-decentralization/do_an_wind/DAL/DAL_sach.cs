using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_sach
    {
        public DataTable getAllExist()
        {
            DataTable data = new DataTable();
            // string query = @"select * from sach where da_xoa='"+0+"'";
            string query = @"Select A.ma_sach, A.ten_sach,A.so_luong,A.nam_xuat_ban,B.ten_nha_xuat_ban,C.ten_tac_gia,D.the_loai,A.gia_muon,A.ngay_nhap,A.da_xoa from sach A,nhaxuatban B,tacgia C,theloai D where A.ma_nha_xuat_ban=B.ma_nha_xuat_ban and A.tac_gia=C.ma_tac_gia and A.the_loai=D.ma_the_loai and A.da_xoa=@da_xoa";
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
                {
                    connect.Open();
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    cmd.Parameters.Add(param);
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

        public DataTable getAll()
        {
            DataTable data = new DataTable();
            // string query = @"select * from sach where da_xoa='"+0+"'";
            string query = @"Select  A.ma_sach, A.ten_sach,A.so_luong,A.nam_xuat_ban,B.ten_nha_xuat_ban,C.ten_tac_gia,D.the_loai,A.gia_muon,A.ngay_nhap,A.da_xoa from sach A,nhaxuatban B,tacgia C,theloai D  where A.ma_nha_xuat_ban=B.ma_nha_xuat_ban and A.tac_gia=C.ma_tac_gia and A.the_loai=D.ma_the_loai";
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
                {
                    connect.Open();
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    reader = cmd.ExecuteReader();
                    data.Load(reader);
                    connect.Close();
                }
            }
            catch (Exception err)
            {
                throw;
            }

            return data;
        }

        public bool insert_sach(BEL.BEL_sach sach)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "insert into sach(ten_sach,so_luong,nam_xuat_ban,ma_nha_xuat_ban,tac_gia,the_loai,gia_muon,ngay_nhap,da_xoa) values(@ten_sach,@so_luong,@nam_xuat_ban,@nha_xuat_ban,@tac_gia,@the_loai,@gia_muon,@ngay_nhap,@da_xoa)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    //SqlDataReader reader = null;
                    SqlParameter param_ten_sach = new SqlParameter();
                    param_ten_sach.ParameterName = "@ten_sach";
                    param_ten_sach.Value = sach.Ten_sach;

                    SqlParameter param_so_luong = new SqlParameter();
                    param_so_luong.ParameterName = "@so_luong";
                    param_so_luong.Value = sach.So_luong;

                    SqlParameter param_nam_xuat_ban = new SqlParameter();
                    param_nam_xuat_ban.ParameterName = "@nam_xuat_ban";
                    param_nam_xuat_ban.Value = sach.Nam_xuat_ban;

                    SqlParameter param_ma_nha_xuat_ban = new SqlParameter();
                    param_ma_nha_xuat_ban.ParameterName = "@nha_xuat_ban";
                    param_ma_nha_xuat_ban.Value = sach.Nha_xuat_ban;

                    SqlParameter param_tac_gia = new SqlParameter();
                    param_tac_gia.ParameterName = "@tac_gia";
                    param_tac_gia.Value = sach.Tac_gia;

                    SqlParameter param_the_loai = new SqlParameter();
                    param_the_loai.ParameterName = "@the_loai";
                    param_the_loai.Value = sach.The_loai;

                    SqlParameter param_gia_muon = new SqlParameter();
                    param_gia_muon.ParameterName = "@gia_muon";
                    param_gia_muon.Value = sach.Gia_muon;

                    SqlParameter param_ngay_nhap = new SqlParameter();
                    param_ngay_nhap.ParameterName = "@ngay_nhap";
                    param_ngay_nhap.Value = sach.Ngay_nhap;

                    SqlParameter param_da_xoa = new SqlParameter();
                    param_da_xoa.ParameterName = "@da_xoa";
                    param_da_xoa.Value = 0;
                    // SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.Add(param_ten_sach);
                    cmd.Parameters.Add(param_so_luong);
                    cmd.Parameters.Add(param_nam_xuat_ban);
                    cmd.Parameters.Add(param_ma_nha_xuat_ban);
                    cmd.Parameters.Add(param_tac_gia);
                    cmd.Parameters.Add(param_the_loai);
                    cmd.Parameters.Add(param_gia_muon);
                    cmd.Parameters.Add(param_ngay_nhap);
                    cmd.Parameters.Add(param_da_xoa);
                    // reader = cmd.ExecuteReader();
                    // data.Load(reader);
                    //SqlCommand command = new SqlCommand(sql, connect);
                    if (cmd.ExecuteNonQuery() > 0)
                        ketqua = true;

                }
                catch (Exception err)
                {
                    throw;
                }
                finally
                {
                    connect.Close();
                }
            }
            return ketqua;
        }

        public bool update_sach(BEL.BEL_sach sach)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update sach set ten_sach=@ten_sach,so_luong=@so_luong,nam_xuat_ban=@nam_xuat_ban,ma_nha_xuat_ban=@ma_nha_xuat_ban,tac_gia=@tac_gia,the_loai=@the_loai,gia_muon=@gia_muon,ngay_nhap=@ngay_nhap,da_xoa=@da_xoa where ma_sach=@ma_sach";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    //SqlDataReader reader = null;
                    SqlParameter param_ten_sach = new SqlParameter();
                    param_ten_sach.ParameterName = "@ten_sach";
                    param_ten_sach.Value = sach.Ten_sach;

                    SqlParameter param_so_luong = new SqlParameter();
                    param_so_luong.ParameterName = "@so_luong";
                    param_so_luong.Value = sach.So_luong;

                    SqlParameter param_nam_xuat_ban = new SqlParameter();
                    param_nam_xuat_ban.ParameterName = "@nam_xuat_ban";
                    param_nam_xuat_ban.Value = sach.Nam_xuat_ban;

                    SqlParameter param_ma_nha_xuat_ban = new SqlParameter();
                    param_ma_nha_xuat_ban.ParameterName = "@ma_nha_xuat_ban";
                    param_ma_nha_xuat_ban.Value = sach.Nha_xuat_ban;

                    SqlParameter param_tac_gia = new SqlParameter();
                    param_tac_gia.ParameterName = "@tac_gia";
                    param_tac_gia.Value = sach.Tac_gia;

                    SqlParameter param_the_loai = new SqlParameter();
                    param_the_loai.ParameterName = "@the_loai";
                    param_the_loai.Value = sach.The_loai;

                    SqlParameter param_gia_muon = new SqlParameter();
                    param_gia_muon.ParameterName = "@gia_muon";
                    param_gia_muon.Value = sach.Gia_muon;

                    SqlParameter param_ngay_nhap = new SqlParameter();
                    param_ngay_nhap.ParameterName = "@ngay_nhap";
                    param_ngay_nhap.Value = sach.Ngay_nhap;

                    SqlParameter param_da_xoa = new SqlParameter();
                    param_da_xoa.ParameterName = "@da_xoa";
                    param_da_xoa.Value = 0;

                    SqlParameter param_ma_sach = new SqlParameter();
                    param_ma_sach.ParameterName = "@ma_sach";
                    param_ma_sach.Value = sach.Ma_sach;
                    // SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.Add(param_ten_sach);
                    cmd.Parameters.Add(param_so_luong);
                    cmd.Parameters.Add(param_nam_xuat_ban);
                    cmd.Parameters.Add(param_ma_nha_xuat_ban);
                    cmd.Parameters.Add(param_tac_gia);
                    cmd.Parameters.Add(param_the_loai);
                    cmd.Parameters.Add(param_gia_muon);
                    cmd.Parameters.Add(param_ngay_nhap);
                    cmd.Parameters.Add(param_da_xoa);
                    cmd.Parameters.Add(param_ma_sach);
                    if (cmd.ExecuteNonQuery() > 0)
                        ketqua = true;

                }
                catch (Exception err)
                {
                    throw;
                }
                finally
                {
                    connect.Close();
                }
            }
            return ketqua;
        }

        public bool capnhattrangthai(BEL.BEL_sach sach)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update sach set da_xoa=@da_xoa where ma_sach=@ma_sach";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 1;
                    SqlParameter param_ma_sach = new SqlParameter();
                    param_ma_sach.ParameterName = "@ma_sach";
                    param_ma_sach.Value = sach.Ma_sach;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_sach);
                    // SqlCommand command = new SqlCommand(query, connect);
                    if (cmd.ExecuteNonQuery() > 0)
                        ketqua = true;

                }
                catch (Exception err)
                {
                    throw;
                }
                finally
                {
                    connect.Close();
                }
            }
            return ketqua;
        }
        public bool capnhattrangthaimoi(BEL.BEL_sach sach)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update sach set da_xoa=@da_xoa where ma_sach=@ma_sach";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_sach = new SqlParameter();
                    param_ma_sach.ParameterName = "@ma_sach";
                    param_ma_sach.Value = sach.Ma_sach;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_sach);
                    // SqlCommand command = new SqlCommand(query, connect);
                    if (cmd.ExecuteNonQuery() > 0)
                        ketqua = true;

                }
                catch (Exception err)
                {
                    throw;
                }
                finally
                {
                    connect.Close();
                }
            }
            return ketqua;
        }
        public DataTable searcher_tensach(string sach)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "select * from sach where da_xoa=@da_xoa and ten_sach like @ten_sach";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ten_sach = new SqlParameter();
                    param_ten_sach.ParameterName = "@ten_sach";
                    param_ten_sach.Value = sach;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ten_sach);
                    reader = cmd.ExecuteReader();
                    data.Load(reader);
                    //SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString.connectionstring);
                    // adapter.Fill(data);
                    return data;

                }
                catch (Exception err)
                {
                    throw;
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public DataTable searcher_tensach_quanly(string sach)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "select * from sach where ten_sach like @ten_sach";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);               
                    SqlParameter param_ten_sach = new SqlParameter();
                    param_ten_sach.ParameterName = "@ten_sach";
                    param_ten_sach.Value = sach;
                    cmd.Parameters.Add(param_ten_sach);
                    reader = cmd.ExecuteReader();
                    data.Load(reader);
                    //SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString.connectionstring);
                    // adapter.Fill(data);
                    return data;

                }
                catch (Exception err)
                {
                    throw;
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public DataTable searcher_masach(string masach)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "select * from sach where da_xoa=@da_xoa and ma_sach=@ma_sach";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_sach = new SqlParameter();
                    param_ma_sach.ParameterName = "@ma_sach";
                    param_ma_sach.Value = masach;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_sach);
                    reader = cmd.ExecuteReader();
                    data.Load(reader);

                    //SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString.connectionstring);
                    //  adapter.Fill(data);
                    return data;

                }
                catch (Exception err)
                {
                    throw;
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public DataTable searcher_masach_quanly(string masach)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "select * from sach where ma_sach=@ma_sach";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param_ma_sach = new SqlParameter();
                    param_ma_sach.ParameterName = "@ma_sach";
                    param_ma_sach.Value = masach;
                    cmd.Parameters.Add(param_ma_sach);
                    reader = cmd.ExecuteReader();
                    data.Load(reader);
                    return data;
                }
                catch (Exception err)
                {
                    throw;
                }
                finally
                {
                    connect.Close();
                }
            }
        }
    }
}
