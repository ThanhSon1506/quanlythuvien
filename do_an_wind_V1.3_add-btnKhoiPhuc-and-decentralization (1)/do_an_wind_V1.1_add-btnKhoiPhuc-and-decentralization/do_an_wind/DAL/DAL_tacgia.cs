using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_tacgia
    {
        public DataTable getAllExist()
        {
            DataTable data = new DataTable();
            // string query = @"select * from tacgia where da_xoa='"+0+"'";
            string query = @"select * from tacgia where da_xoa=@da_xoa";
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
            string query = "select * from tacgia";
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

        public bool insert_tacgia(BEL.BEL_tacgia tacgia)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "insert into tacgia(ten_tac_gia,tieu_su,da_xoa) values(@ten_tac_gia,@tieu_su,@da_xoa)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    //SqlDataReader reader = null;
                    SqlParameter param_ten_tac_gia = new SqlParameter();
                    param_ten_tac_gia.ParameterName = "@ten_tac_gia";
                    param_ten_tac_gia.Value = tacgia.Tentacgia;

                    SqlParameter param_tieu_su = new SqlParameter();
                    param_tieu_su.ParameterName = "@tieu_su";
                    param_tieu_su.Value = tacgia.Tieusu;

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    // SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.Add(param_ten_tac_gia);
                    cmd.Parameters.Add(param_tieu_su);
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

        public bool update_tacgia(BEL.BEL_tacgia tacgia)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update tacgia set ten_tac_gia=@ten_tac_gia,tieu_su=@tieu_su,da_xoa=@da_xoa where ma_tac_gia=@ma_tac_gia";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    //SqlDataReader reader = null;
                    SqlParameter param_ten_tac_gia = new SqlParameter();
                    param_ten_tac_gia.ParameterName = "@ten_tac_gia";
                    param_ten_tac_gia.Value = tacgia.Tentacgia;

                    SqlParameter param_tieu_su = new SqlParameter();
                    param_tieu_su.ParameterName = "@tieu_su";
                    param_tieu_su.Value = tacgia.Tentacgia;

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;

                    SqlParameter param_ma_tac_gia = new SqlParameter();
                    param_ma_tac_gia.ParameterName = "@ma_tac_gia";
                    param_ma_tac_gia.Value = tacgia.Matacgia;
                    // SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.Add(param_ten_tac_gia);
                    cmd.Parameters.Add(param_tieu_su);
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_tac_gia);
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

        public bool capnhattrangthai(BEL.BEL_tacgia tacgia)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update tacgia set da_xoa=@da_xoa where ma_tac_gia=@ma_tac_gia";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 1;
                    SqlParameter param_ma_tac_gia = new SqlParameter();
                    param_ma_tac_gia.ParameterName = "@ma_tac_gia";
                    param_ma_tac_gia.Value = tacgia.Matacgia;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_tac_gia);
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

        public bool capnhat_trangthai_xoa(BEL.BEL_tacgia tacgia)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update tacgia set da_xoa=@da_xoa where ma_tac_gia=@ma_tac_gia";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_tac_gia = new SqlParameter();
                    param_ma_tac_gia.ParameterName = "@ma_tac_gia";
                    param_ma_tac_gia.Value = tacgia.Matacgia;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_tac_gia);
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
        public DataTable searcher_tentacgia(string tacgia)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "select * from tacgia where da_xoa=@da_xoa and ten_tac_gia=@ten_tac_gia";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ten_tac_gia = new SqlParameter();
                    param_ten_tac_gia.ParameterName = "@ten_tac_gia";
                    param_ten_tac_gia.Value = tacgia;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ten_tac_gia);
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
        public DataTable searcher_tentacgia_quanly(string tacgia)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connect.Open();
                    string query = "select * from tacgia where da_xoa=@da_xoa and ten_tac_gia=@ten_tac_gia";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);                
                    SqlParameter param_ten_tac_gia = new SqlParameter();
                    param_ten_tac_gia.ParameterName = "@ten_tac_gia";
                    param_ten_tac_gia.Value = tacgia;
                    cmd.Parameters.Add(param_ten_tac_gia);
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
        public DataTable searcher_matacgia(string matacgia)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "select * from tacgia where da_xoa=@da_xoa and ma_tac_gia=@ma_tac_gia";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_tac_gia = new SqlParameter();
                    param_ma_tac_gia.ParameterName = "@ma_tac_gia";
                    param_ma_tac_gia.Value = matacgia;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_tac_gia);
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
        public DataTable searcher_matacgia_quanly(string matacgia)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "select * from tacgia where ma_tac_gia=@ma_tac_gia";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);            
                    SqlParameter param_ma_tac_gia = new SqlParameter();
                    param_ma_tac_gia.ParameterName = "@ma_tac_gia";
                    param_ma_tac_gia.Value = matacgia;
                    cmd.Parameters.Add(param_ma_tac_gia);
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
