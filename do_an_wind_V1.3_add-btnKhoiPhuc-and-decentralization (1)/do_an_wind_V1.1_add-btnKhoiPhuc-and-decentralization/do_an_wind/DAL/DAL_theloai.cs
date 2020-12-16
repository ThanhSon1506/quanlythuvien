using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DAL_theloai
    {
        public DataTable getAll()
        {
            DataTable data = new DataTable();
            // string query = @"select * from theloai where da_xoa='"+0+"'";
            string query = @"select * from theloai";
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataReader reader = null;
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
        public DataTable getAllExist()
        {
            DataTable data = new DataTable();
            // string query = @"select * from theloai where da_xoa='"+0+"'";
            string query = @"select * from theloai where da_xoa = @da_xoa";
            try
            {
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
                Console.WriteLine(err);
            }

            return data;
        }
        public bool insert_theloai(BEL.BEL_theloai theloai)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "insert into theloai(the_loai,da_xoa) values(@the_loai,@da_xoa)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    //SqlDataReader reader = null;
                    SqlParameter param_the_loai = new SqlParameter();
                    param_the_loai.ParameterName = "@the_loai";
                    param_the_loai.Value = theloai.The_loai;
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    // SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.Add(param_the_loai);
                 
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

        public bool update_theloai(BEL.BEL_theloai theloai)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update theloai set the_loai=@the_loai,da_xoa=@daxoa where ma_the_loai=@matheloai";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    //SqlDataReader reader = null;
                    SqlParameter param_the_loai = new SqlParameter();
                    param_the_loai.ParameterName = "@the_loai";
                    param_the_loai.Value = theloai.The_loai;
                    
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@daxoa";
                    param.Value = 0;

                    SqlParameter param_ma_the_loai = new SqlParameter();
                    param_ma_the_loai.ParameterName = "@matheloai";
                    param_ma_the_loai.Value = theloai.Ma_the_loai;
                    // SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.Add(param_the_loai);
             
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_the_loai);
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

        public bool capnhattrangthai(BEL.BEL_theloai theloai)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update theloai set da_xoa=@da_xoa where ma_the_loai=@ma_the_loai";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 1;
                    SqlParameter param_ma_the_loai = new SqlParameter();
                    param_ma_the_loai.ParameterName = "@ma_the_loai";
                    param_ma_the_loai.Value = theloai.Ma_the_loai;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_the_loai);
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
        public bool capnhattrangthaimoi(BEL.BEL_theloai theloai)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update theloai set da_xoa=@da_xoa where ma_the_loai=@ma_the_loai";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_the_loai = new SqlParameter();
                    param_ma_the_loai.ParameterName = "@ma_the_loai";
                    param_ma_the_loai.Value = theloai.Ma_the_loai;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_the_loai);
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
        public DataTable searcher_tentheloai(string theloai)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "select * from theloai where da_xoa=@da_xoa and the_loai=@the_loai";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_the_loai = new SqlParameter();
                    param_the_loai.ParameterName = "@the_loai";
                    param_the_loai.Value = theloai;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_the_loai);
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

        public DataTable searcher_tentheloai_quanly(string theloai)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "select * from theloai where the_loai=@the_loai";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);     
                    SqlParameter param_the_loai = new SqlParameter();
                    param_the_loai.ParameterName = "@the_loai";
                    param_the_loai.Value = theloai;
                    cmd.Parameters.Add(param_the_loai);
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

        public DataTable searcher_matheloai(string matheloai)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "select * from theloai where da_xoa=@da_xoa and ma_the_loai=@ma_the_loai";

                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_the_loai = new SqlParameter();
                    param_ma_the_loai.ParameterName = "@ma_the_loai";
                    param_ma_the_loai.Value = matheloai;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_the_loai);
                    reader = cmd.ExecuteReader();
                    data.Load(reader);

                    //SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString.connectionstring);
                    //  adapter.Fill(data);
                    return data;

                }
                catch (Exception err)
                {
                    return data;
                }
                finally
                {
                    connect.Close();
                }
            }
        }
        public DataTable searcher_matheloai_quanly(string matheloai)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "select * from theloai where ma_the_loai=@ma_the_loai";

                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param_ma_the_loai = new SqlParameter();
                    param_ma_the_loai.ParameterName = "@ma_the_loai";
                    param_ma_the_loai.Value = matheloai;
                    cmd.Parameters.Add(param_ma_the_loai);
                    reader = cmd.ExecuteReader();
                    data.Load(reader);
                    return data;

                }
                catch (Exception err)
                {
                    return data;
                }
                finally
                {
                    connect.Close();
                }
            }
        }
    }
}
