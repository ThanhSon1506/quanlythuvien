using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DAL_nhaxuatban
    {
        public DataTable getAllExist()
        {
            DataTable data = new DataTable();
            // string query = @"select * from nhaxuatban where da_xoa='"+0+"'";
            string query = @"select * from nhaxuatban where da_xoa=@da_xoa";
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
            string query = @"select * from nhaxuatban";
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
        public bool insert_nhaxuatban(BEL.BEL_nhaxuatban nhaxuatban)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "insert into nhaxuatban(ten_nha_xuat_ban,dia_chi,sdt,email,da_xoa) values(@ten_nha_xuat_ban,@diachi,@SDT,@email,@da_xoa)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    //SqlDataReader reader = null;
                    SqlParameter param_ten_nha_xuat_ban = new SqlParameter();
                    param_ten_nha_xuat_ban.ParameterName = "@ten_nha_xuat_ban";
                    param_ten_nha_xuat_ban.Value = nhaxuatban.Ten_nha_xuat_ban;
                    SqlParameter param_diachi = new SqlParameter();
                    param_diachi.ParameterName = "@diachi";
                    param_diachi.Value = nhaxuatban.Dia_chi;
                    SqlParameter param_Sdt = new SqlParameter();
                    param_Sdt.ParameterName = "@SDT";
                    param_Sdt.Value = nhaxuatban.Sdt;
                    SqlParameter param_email = new SqlParameter();
                    param_email.ParameterName = "@email";
                    param_email.Value = nhaxuatban.Email;
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    // SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.Add(param_ten_nha_xuat_ban);
                    cmd.Parameters.Add(param_diachi);
                    cmd.Parameters.Add(param_Sdt);
                    cmd.Parameters.Add(param_email);
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

        public bool update_nhaxuatban(BEL.BEL_nhaxuatban nhaxuatban)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update nhaxuatban set ten_nha_xuat_ban=@ten_nha_xuat_ban,dia_chi=@diachi,sdt=@SDT,email=@email,da_xoa=@daxoa where ma_nha_xuat_ban=@manhaxuatban";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    //SqlDataReader reader = null;
                    SqlParameter param_ten_nha_xuat_ban = new SqlParameter();
                    param_ten_nha_xuat_ban.ParameterName = "@ten_nha_xuat_ban";
                    param_ten_nha_xuat_ban.Value = nhaxuatban.Ten_nha_xuat_ban;
                    SqlParameter param_diachi = new SqlParameter();
                    param_diachi.ParameterName = "@diachi";
                    param_diachi.Value = nhaxuatban.Dia_chi;
                    SqlParameter param_Sdt = new SqlParameter();
                    param_Sdt.ParameterName = "@SDT";
                    param_Sdt.Value = nhaxuatban.Sdt;
                    SqlParameter param_email = new SqlParameter();
                    param_email.ParameterName = "@email";
                    param_email.Value = nhaxuatban.Email;
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@daxoa";
                    param.Value = nhaxuatban.Da_xoa;
                    SqlParameter param_ma_nha_xuat_ban = new SqlParameter();
                    param_ma_nha_xuat_ban.ParameterName = "@manhaxuatban";
                    param_ma_nha_xuat_ban.Value = nhaxuatban.Ma_nha_xuat_ban;
                    // SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.Add(param_ten_nha_xuat_ban);
                    cmd.Parameters.Add(param_diachi);
                    cmd.Parameters.Add(param_Sdt);
                    cmd.Parameters.Add(param_email);
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_nha_xuat_ban);
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

        public bool capnhattrangthai(BEL.BEL_nhaxuatban nhaxuatban)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update nhaxuatban set da_xoa=@da_xoa where ma_nha_xuat_ban=@ma_nha_xuat_ban";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 1;
                    SqlParameter param_ma_nha_xuat_ban = new SqlParameter();
                    param_ma_nha_xuat_ban.ParameterName = "@ma_nha_xuat_ban";
                    param_ma_nha_xuat_ban.Value = nhaxuatban.Ma_nha_xuat_ban;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_nha_xuat_ban);
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

        public bool capnhattrangthaimoi(BEL.BEL_nhaxuatban nhaxuatban)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update nhaxuatban set da_xoa=@da_xoa where ma_nha_xuat_ban=@ma_nha_xuat_ban";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_nha_xuat_ban = new SqlParameter();
                    param_ma_nha_xuat_ban.ParameterName = "@ma_nha_xuat_ban";
                    param_ma_nha_xuat_ban.Value = nhaxuatban.Ma_nha_xuat_ban;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_nha_xuat_ban);
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
        public DataTable searcher_tennhaxuatban(string nhaxuatban)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "select * from nhaxuatban where da_xoa=@da_xoa and ten_nha_xuat_ban=@ten_nha_xuat_ban";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ten_nha_xuat_ban = new SqlParameter();
                    param_ten_nha_xuat_ban.ParameterName = "@ten_nha_xuat_ban";
                    param_ten_nha_xuat_ban.Value = nhaxuatban;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ten_nha_xuat_ban);
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
        public DataTable searcher_tennhaxuatban_quanly(string nhaxuatban)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "select * from nhaxuatban where ten_nha_xuat_ban=@ten_nha_xuat_ban";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);     
                    SqlParameter param_ten_nha_xuat_ban = new SqlParameter();
                    param_ten_nha_xuat_ban.ParameterName = "@ten_nha_xuat_ban";
                    param_ten_nha_xuat_ban.Value = nhaxuatban;         
                    cmd.Parameters.Add(param_ten_nha_xuat_ban);
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
        public DataTable searcher_manhaxuatban(string manhaxuatban)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "select * from nhaxuatban where da_xoa=@da_xoa and ma_nha_xuat_ban=@ma_nha_xuat_ban";

                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_nha_xuat_ban = new SqlParameter();
                    param_ma_nha_xuat_ban.ParameterName = "@ma_nha_xuat_ban";
                    param_ma_nha_xuat_ban.Value = manhaxuatban;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_nha_xuat_ban);
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

        public DataTable searcher_manhaxuatban_quanly(string manhaxuatban)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connect.Open();
                    string query = "select * from nhaxuatban where ma_nha_xuat_ban=@ma_nha_xuat_ban";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);      
                    SqlParameter param_ma_nha_xuat_ban = new SqlParameter();
                    param_ma_nha_xuat_ban.ParameterName = "@ma_nha_xuat_ban";
                    param_ma_nha_xuat_ban.Value = manhaxuatban;
                    cmd.Parameters.Add(param_ma_nha_xuat_ban);
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
