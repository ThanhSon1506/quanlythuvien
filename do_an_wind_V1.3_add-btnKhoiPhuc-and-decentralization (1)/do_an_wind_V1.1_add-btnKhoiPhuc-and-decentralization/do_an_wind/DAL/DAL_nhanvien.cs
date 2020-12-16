using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
namespace DAL
{
    public class DAL_nhanvien
    {
        public DataTable getAll()
        {
            DataTable data = new DataTable();
            // string query = @"select * from nhanvien where da_xoa='"+0+"'";
            string query = @"select * from nhanvien";
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
        public DataTable getAllExist()
        {
            DataTable data = new DataTable();
            // string query = @"select * from nhanvien where da_xoa='"+0+"'";
            string query = @"select * from nhanvien where da_xoa=@da_xoa";
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
        public bool insert_nhanvien(BEL.BEL_nhanvien nhanvien)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "insert into nhanvien(ten_nhan_vien,gioi_tinh,ngay_sinh,dia_chi,quanly,sdt,da_xoa) values(@ten_nhan_vien,@gioi_tinh,@ngay_sinh,@dia_chi,@quanly,@SDT,@da_xoa)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    //SqlDataReader reader = null;
                    SqlParameter param_ten_nhan_vien = new SqlParameter();
                    param_ten_nhan_vien.ParameterName = "@ten_nhan_vien";
                    param_ten_nhan_vien.Value = nhanvien.Ten_nhan_vien;
                    SqlParameter param_Gio_tinh = new SqlParameter();
                    param_Gio_tinh.ParameterName = "@gioi_tinh";
                    param_Gio_tinh.Value = nhanvien.Gioi_tinh;
                    SqlParameter param_Ngay_sinh = new SqlParameter();
                    param_Ngay_sinh.ParameterName = "@ngay_sinh";
                    param_Ngay_sinh.Value = nhanvien.Ngay_sinh;
                    SqlParameter param_Dia_chi = new SqlParameter();
                    param_Dia_chi.ParameterName = "@dia_chi";
                    param_Dia_chi.Value = nhanvien.Dia_chi;
                    SqlParameter param_quan_ly = new SqlParameter();
                    param_quan_ly.ParameterName = "@quanly";
                    param_quan_ly.Value = nhanvien.Quan_ly;
                    SqlParameter param_Sdt = new SqlParameter();
                    param_Sdt.ParameterName = "@SDT";
                    param_Sdt.Value = nhanvien.Sdt;
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    // SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.Add(param_ten_nhan_vien);
                    cmd.Parameters.Add(param_Gio_tinh);
                    cmd.Parameters.Add(param_Ngay_sinh);
                    cmd.Parameters.Add(param_Dia_chi);
                    cmd.Parameters.Add(param_quan_ly);
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
        public bool insert_Taikhoan(string taikhoan, string matkhau)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connect.Open();

                    string query = @"insert into taikhoan(tai_khoan, mat_khau, da_xoa) 
                                    values(@ma_tai_khoan, @ma_mat_khau, @da_xoa)";
                    SqlCommand cmd = new SqlCommand(query, connect);

                    SqlParameter param_tai_khoan = new SqlParameter();
                    param_tai_khoan.ParameterName = "@ma_tai_khoan";
                    param_tai_khoan.Value = taikhoan;

                    SqlParameter param_mat_khau = new SqlParameter();
                    param_mat_khau.ParameterName = "@ma_mat_khau";
                    param_mat_khau.Value = matkhau;

                    SqlParameter param_da_xoa = new SqlParameter();
                    param_da_xoa.ParameterName = "@da_xoa";
                    param_da_xoa.Value = 0;

                    cmd.Parameters.Add(param_tai_khoan);
                    cmd.Parameters.Add(param_mat_khau);
                    cmd.Parameters.Add(param_da_xoa);


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

        public bool update_nhanvien(BEL.BEL_nhanvien nhanvien)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update nhanvien set ten_nhan_vien=@ten_nhan_vien,gioi_tinh=@gioi_tinh,ngay_sinh=@ngay_sinh,dia_chi=@dia_chi,quanly=@quanly,SDT=@SDT,da_xoa=@da_xoa where ma_nhan_vien=@ma_nhan_vien";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param_ten_nhan_vien = new SqlParameter();
                    param_ten_nhan_vien.ParameterName = "@ten_nhan_vien";
                    param_ten_nhan_vien.Value = nhanvien.Ten_nhan_vien;
                    SqlParameter param_Gio_tinh = new SqlParameter();
                    param_Gio_tinh.ParameterName = "@gioi_tinh";
                    param_Gio_tinh.Value = nhanvien.Gioi_tinh;
                    SqlParameter param_Ngay_sinh = new SqlParameter();
                    param_Ngay_sinh.ParameterName = "@ngay_sinh";
                    param_Ngay_sinh.Value = nhanvien.Ngay_sinh;
                    SqlParameter param_Dia_chi = new SqlParameter();
                    param_Dia_chi.ParameterName = "@dia_chi";
                    param_Dia_chi.Value = nhanvien.Dia_chi;
                    SqlParameter param_quan_ly = new SqlParameter();
                    param_quan_ly.ParameterName = "@quanly";
                    param_quan_ly.Value = nhanvien.Quan_ly;
                    SqlParameter param_Sdt = new SqlParameter();
                    param_Sdt.ParameterName = "@SDT";
                    param_Sdt.Value = nhanvien.Sdt;
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = nhanvien.Da_xoa;
                    SqlParameter param_ma_nhan_vien = new SqlParameter();
                    param_ma_nhan_vien.ParameterName = "@ma_nhan_vien";
                    param_ma_nhan_vien.Value = nhanvien.Ma_nhan_vien;
                    // SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.Add(param_ten_nhan_vien);
                    cmd.Parameters.Add(param_Gio_tinh);
                    cmd.Parameters.Add(param_Ngay_sinh);
                    cmd.Parameters.Add(param_Dia_chi);
                    cmd.Parameters.Add(param_quan_ly);
                    cmd.Parameters.Add(param_Sdt);
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_nhan_vien);
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

        public bool capnhattrangthai(BEL.BEL_nhanvien nhanvien)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update nhanvien set da_xoa=@da_xoa where ma_nhan_vien=@ma_nhan_vien";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 1;
                    SqlParameter param_ma_nhan_vien = new SqlParameter();
                    param_ma_nhan_vien.ParameterName = "@ma_nhan_vien";
                    param_ma_nhan_vien.Value = nhanvien.Ma_nhan_vien;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_nhan_vien);
                    // SqlCommand command = new SqlCommand(query, connect);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        ketqua = true;
                    }

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

        public bool capnhattrangthaimoi(BEL.BEL_nhanvien nhanvien)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "update nhanvien set da_xoa=@da_xoa where ma_nhan_vien=@ma_nhan_vien";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_nhan_vien = new SqlParameter();
                    param_ma_nhan_vien.ParameterName = "@ma_nhan_vien";
                    param_ma_nhan_vien.Value = nhanvien.Ma_nhan_vien;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_nhan_vien);
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
        public DataTable searcher_tennhanvien(string nhanvien)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "select * from nhanvien where da_xoa=@da_xoa and ten_nhan_vien=@ten_nhan_vien";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ten_nhan_vien = new SqlParameter();
                    param_ten_nhan_vien.ParameterName = "@ten_nhan_vien";
                    param_ten_nhan_vien.Value = nhanvien;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ten_nhan_vien);
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

        public DataTable searcher_tennhanvien_quanly(string nhanvien)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = "select * from nhanvien where ten_nhan_vien=@ten_nhan_vien";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param_ten_nhan_vien = new SqlParameter();
                    param_ten_nhan_vien.ParameterName = "@ten_nhan_vien";
                    param_ten_nhan_vien.Value = nhanvien;
                    cmd.Parameters.Add(param_ten_nhan_vien);
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

        public DataTable searcher_manhanvien(string manhanvien)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "select * from nhanvien where da_xoa=@da_xoa and ma_nhan_vien=@ma_nhan_vien";

                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_nhan_vien = new SqlParameter();
                    param_ma_nhan_vien.ParameterName = "@ma_nhan_vien";
                    param_ma_nhan_vien.Value = manhanvien;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_nhan_vien);
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
        public DataTable searcher_manhanvien_quanly(string manhanvien)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connect.Open();
                    string query = "select * from nhanvien where ma_nhan_vien=@ma_nhan_vien";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);                 
                    SqlParameter param_ma_nhan_vien = new SqlParameter();
                    param_ma_nhan_vien.ParameterName = "@ma_nhan_vien";
                    param_ma_nhan_vien.Value = manhanvien;
                    cmd.Parameters.Add(param_ma_nhan_vien);
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
        public string Max_nhanvien()
        {
            string ketqua = "";
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connect.Open();
                    string query = @"SELECT MAX(ma_nhan_vien) FROM nhanvien";
                    SqlDataReader reader = null;
                    DataTable data = new DataTable();
                    SqlCommand cmd = new SqlCommand(query, connect);
                    reader = cmd.ExecuteReader();
                    data.Load(reader);
                    ketqua = data.Rows[0][0].ToString();
                    connect.Close();
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
        public MD5 mahoa = MD5.Create();
        public string Mahoakitu(string s)
        {
            string str = null;
            byte[] Bytes = System.Text.Encoding.ASCII.GetBytes(s);
            byte[] DoubleBytes = mahoa.ComputeHash(Bytes);
            foreach (byte b in Bytes)
            {
                str += b.ToString();
            }
            return str;
        }
        public void add_tknv(BEL.BEL_nhanvien tknv, string mahoa_mnv)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "insert into taikhoan(ma_nhan_vien,tai_khoan,mat_khau,da_xoa) values (@manv,@tentk,@mk,@da_xoa)";

                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_nhan_vien = new SqlParameter();
                    param_ma_nhan_vien.ParameterName = "@manv";
                    param_ma_nhan_vien.Value = tknv.Ma_nhan_vien;
                    SqlParameter param_ten_tk = new SqlParameter();
                    param_ten_tk.ParameterName = "@tentk";
                    param_ten_tk.Value = mahoa_mnv;
                    SqlParameter param_mk = new SqlParameter();
                    param_mk.ParameterName = "@mk";
                    param_mk.Value = tknv.Sdt;

                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_nhan_vien);
                    cmd.Parameters.Add(param_ten_tk);
                    cmd.Parameters.Add(param_mk);
                    cmd.ExecuteNonQuery();


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
        public void delete_tknv(BEL.BEL_nhanvien tknv)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "update taikhoan set da_xoa=@da_xoa where ma_nhan_vien=@manv";

                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 1;
                    SqlParameter param_ma_nhan_vien = new SqlParameter();
                    param_ma_nhan_vien.ParameterName = "@manv";
                    param_ma_nhan_vien.Value = tknv.Ma_nhan_vien;

                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_nhan_vien);
                    cmd.ExecuteNonQuery();


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
            public void restore_tknv(BEL.BEL_nhanvien tknv)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "update taikhoan set da_xoa=@da_xoa where ma_nhan_vien=@manv";

                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_nhan_vien = new SqlParameter();
                    param_ma_nhan_vien.ParameterName = "@manv";
                    param_ma_nhan_vien.Value = tknv.Ma_nhan_vien;

                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_nhan_vien);
                    cmd.ExecuteNonQuery();


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
