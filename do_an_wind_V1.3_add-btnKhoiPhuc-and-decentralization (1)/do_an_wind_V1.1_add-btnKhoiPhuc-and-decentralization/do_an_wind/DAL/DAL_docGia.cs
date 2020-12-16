using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_docGia:connectionString
    {
        public DataTable getAllExist() 
        {
            DataTable data = new DataTable();
           // string query = @"select * from docgia where da_xoa='"+0+"'";
            string query = @"select * from docgia where da_xoa=@da_xoa";
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
                Console.WriteLine(err);
            }

            return data;
        }

        public DataTable getAll()
        {
            DataTable data = new DataTable();
            string query = @"select * from docgia";
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
                Console.WriteLine(err);
            }

            return data;
        }

        public bool insert_docgia(BEL.BEL_DocGia docgia) {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "insert into docgia(ten_doc_gia,gioi_tinh,ngay_sinh,dia_chi,CMND,SDT,da_xoa) values(@ten_doc_gia,@gioi_tinh,@ngay_sinh,@dia_chi,@CMND,@SDT,@da_xoa)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    //SqlDataReader reader = null;
                    SqlParameter param_ten_doc_gia = new SqlParameter();
                    param_ten_doc_gia.ParameterName = "@ten_doc_gia";
                    param_ten_doc_gia.Value = docgia.Ten_doc_gia;
                    SqlParameter param_Gio_tinh = new SqlParameter();
                    param_Gio_tinh.ParameterName = "@gioi_tinh";
                    param_Gio_tinh.Value = docgia.Gio_tinh;
                    SqlParameter param_Ngay_sinh = new SqlParameter();
                    param_Ngay_sinh.ParameterName = "@ngay_sinh";
                    param_Ngay_sinh.Value = docgia.Ngay_sinh;
                    SqlParameter param_Dia_chi = new SqlParameter();
                    param_Dia_chi.ParameterName = "@dia_chi";
                    param_Dia_chi.Value = docgia.Dia_chi;
                    SqlParameter param_Cmnd = new SqlParameter();
                    param_Cmnd.ParameterName = "@CMND";
                    param_Cmnd.Value = docgia.Cmnd;
                    SqlParameter param_Sdt = new SqlParameter();
                    param_Sdt.ParameterName = "@SDT";
                    param_Sdt.Value = docgia.Sdt;
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                   // SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.Add(param_ten_doc_gia);
                    cmd.Parameters.Add(param_Gio_tinh);
                    cmd.Parameters.Add(param_Ngay_sinh);
                    cmd.Parameters.Add(param_Dia_chi);
                    cmd.Parameters.Add(param_Cmnd);
                    cmd.Parameters.Add(param_Sdt);
                    cmd.Parameters.Add(param);
                   // reader = cmd.ExecuteReader();
                   // data.Load(reader);
                    //SqlCommand command = new SqlCommand(sql, connect);
                    if (cmd.ExecuteNonQuery() > 0)
                        ketqua = true;

                }
                catch (Exception err)
                {

                }
                finally
                {
                    connect.Close();
                }
            }
            return ketqua;
        }

        public bool update_docgia(BEL.BEL_DocGia docgia)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connect.Open();
                    string query = "update docgia set ten_doc_gia=@ten_doc_gia,gioi_tinh=@gioi_tinh,ngay_sinh=@ngay_sinh,dia_chi=@dia_chi,CMND=@CMND,SDT=@SDT,da_xoa=@da_xoa where ma_doc_gia=@ma_doc_gia";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param_ten_doc_gia = new SqlParameter();
                    param_ten_doc_gia.ParameterName = "@ten_doc_gia";
                    param_ten_doc_gia.Value = docgia.Ten_doc_gia;
                    SqlParameter param_Gio_tinh = new SqlParameter();
                    param_Gio_tinh.ParameterName = "@gioi_tinh";
                    param_Gio_tinh.Value = docgia.Gio_tinh;
                    SqlParameter param_Ngay_sinh = new SqlParameter();
                    param_Ngay_sinh.ParameterName = "@ngay_sinh";
                    param_Ngay_sinh.Value = docgia.Ngay_sinh;
                    SqlParameter param_Dia_chi = new SqlParameter();
                    param_Dia_chi.ParameterName = "@dia_chi";
                    param_Dia_chi.Value = docgia.Dia_chi;
                    SqlParameter param_Cmnd = new SqlParameter();
                    param_Cmnd.ParameterName = "@CMND";
                    param_Cmnd.Value = docgia.Cmnd;
                    SqlParameter param_Sdt = new SqlParameter();
                    param_Sdt.ParameterName = "@SDT";
                    param_Sdt.Value = docgia.Sdt;
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = docgia.Da_xoa;
                    SqlParameter param_ma_doc_gia = new SqlParameter();
                    param_ma_doc_gia.ParameterName = "@ma_doc_gia";
                    param_ma_doc_gia.Value = docgia.Ma_doc_gia;
                    // SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.Add(param_ten_doc_gia);
                    cmd.Parameters.Add(param_Gio_tinh);
                    cmd.Parameters.Add(param_Ngay_sinh);
                    cmd.Parameters.Add(param_Dia_chi);
                    cmd.Parameters.Add(param_Cmnd);
                    cmd.Parameters.Add(param_Sdt);
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_doc_gia);
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
        public bool capnhattrangthai(BEL.BEL_DocGia docgia)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update docgia set da_xoa=@da_xoa where ma_doc_gia=@ma_doc_gia";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 1;
                    SqlParameter param_ma_doc_gia = new SqlParameter();
                    param_ma_doc_gia.ParameterName = "@ma_doc_gia";
                    param_ma_doc_gia.Value = docgia.Ma_doc_gia;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_doc_gia);
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
        public bool capnhattrangthaimoi(BEL.BEL_DocGia docgia)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update docgia set da_xoa=@da_xoa where ma_doc_gia=@ma_doc_gia";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_doc_gia = new SqlParameter();
                    param_ma_doc_gia.ParameterName = "@ma_doc_gia";
                    param_ma_doc_gia.Value = docgia.Ma_doc_gia;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_doc_gia);
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
        public DataTable searcher_tendocgia(string docgia)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "select * from docgia where da_xoa=@da_xoa and ten_doc_gia=@ten_doc_gia";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ten_doc_gia = new SqlParameter();
                    param_ten_doc_gia.ParameterName = "@ten_doc_gia";
                    param_ten_doc_gia.Value = docgia;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ten_doc_gia);
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

        public DataTable searcher_tendocgia_quanly(string docgia)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "select * from docgia where ten_doc_gia=@ten_doc_gia";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    SqlParameter param_ten_doc_gia = new SqlParameter();
                    param_ten_doc_gia.ParameterName = "@ten_doc_gia";
                    param_ten_doc_gia.Value = docgia;
                    cmd.Parameters.Add(param_ten_doc_gia);
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

        public DataTable searcher_madocgia(string madocgia)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "select * from docgia where da_xoa=@da_xoa and ma_doc_gia=@ma_doc_gia";
  
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_doc_gia = new SqlParameter();
                    param_ma_doc_gia.ParameterName = "@ma_doc_gia";
                    param_ma_doc_gia.Value = madocgia;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_doc_gia);
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

        public DataTable searcher_madocgia_quanly(string madocgia)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connect.Open();
                    string query = "select * from docgia where ma_doc_gia=@ma_doc_gia";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                   
                    SqlParameter param_ma_doc_gia = new SqlParameter();
                    param_ma_doc_gia.ParameterName = "@ma_doc_gia";
                    param_ma_doc_gia.Value = madocgia;
                    cmd.Parameters.Add(param_ma_doc_gia);
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
    }
}
