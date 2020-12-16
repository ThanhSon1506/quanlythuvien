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
    public class DAL_phieumuon
    {
        public DataTable ChuaTra()
        {
            DataTable data = new DataTable();
            // string query = @"select * from nhanvien where da_xoa='"+0+"'";
            string query = @"select * from phieumuon where da_xoa = @da_xoa and trang_thai = 0";
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
                    connect.Close();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }

            return data;
        }

        public DataTable GetAll()
        {
            DataTable data = new DataTable();
            string query = @"select * from phieumuon";
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

        public DataTable thongtinphieu(string maphieu)
        {
            DataTable data = new DataTable();
            string query = @"
         SELECT       dbo.sach.ma_sach, dbo.sach.ten_sach, dbo.tacgia.ten_tac_gia, dbo.sach.gia_muon
         FROM         dbo.phieumuon INNER JOIN
                      dbo.thongtinphieumuon ON dbo.phieumuon.ma_phieu = dbo.thongtinphieumuon.ma_phieu_muon INNER JOIN
                      dbo.sach ON dbo.thongtinphieumuon.ma_sach = dbo.sach.ma_sach INNER JOIN
                      dbo.tacgia ON dbo.sach.tac_gia = dbo.tacgia.ma_tac_gia
         WHERE        dbo.thongtinphieumuon.ma_phieu_muon = @maphieu";
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
                {
                    connect.Open();
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@maphieu";
                    param.Value = int.Parse(maphieu);
                    cmd.Parameters.Add(param);
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

        public bool insert_Phieu(BEL_phieumuon phieumuon)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = @"insert into phieumuon(doc_gia, nhan_vien, ngay_muon, ngay_tra, tong_tien, trang_thai, da_xoa) 
                                    values(@doc_gia, @nhan_vien, @ngay_muon, @ngay_tra, @tong_tien, @trang_thai, @da_xoa)";
                    SqlCommand cmd = new SqlCommand(query, connect);

                    SqlParameter param_doc_gia = new SqlParameter();
                    param_doc_gia.ParameterName = "@doc_gia";
                    param_doc_gia.Value = phieumuon.Doc_gia;

                    SqlParameter param_nhan_vien = new SqlParameter();
                    param_nhan_vien.ParameterName = "@nhan_vien";
                    param_nhan_vien.Value = phieumuon.Nhan_vien;

                    SqlParameter param_ngay_muon = new SqlParameter();
                    param_ngay_muon.ParameterName = "@ngay_muon";
                    param_ngay_muon.Value = phieumuon.Ngay_muon;

                    SqlParameter param_ngay_tra = new SqlParameter();
                    param_ngay_tra.ParameterName = "@ngay_tra";
                    param_ngay_tra.Value = phieumuon.Ngay_tra;

                    SqlParameter param_tong_tien = new SqlParameter();
                    param_tong_tien.ParameterName = "@tong_tien";
                    param_tong_tien.Value = phieumuon.Tong_tien;

                    SqlParameter param_trang_thai = new SqlParameter();
                    param_trang_thai.ParameterName = "@trang_thai";
                    param_trang_thai.Value = phieumuon.Trang_thai;

                    SqlParameter param_da_xoa = new SqlParameter();
                    param_da_xoa.ParameterName = "@da_xoa";
                    param_da_xoa.Value = phieumuon.Da_xoa;

                    cmd.Parameters.Add(param_doc_gia);
                    cmd.Parameters.Add(param_nhan_vien);
                    cmd.Parameters.Add(param_ngay_muon);
                    cmd.Parameters.Add(param_ngay_tra);
                    cmd.Parameters.Add(param_tong_tien);
                    cmd.Parameters.Add(param_trang_thai);
                    cmd.Parameters.Add(param_da_xoa);

                    int size = phieumuon.Dsmuon.Count;

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        for (int i = 0; i < size; ++i)
                        {
                            if (!insert_Thongtinphieu(Max_Maphieu(), phieumuon.Dsmuon[i]))
                                return false;
                        }
                        ketqua = true;
                    }
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

        public bool insert_Thongtinphieu(string maPhieu, string masach)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connect.Open();

                    string query = @"insert into thongtinphieumuon(ma_phieu_muon, ma_sach, da_xoa) 
                                    values(@ma_phieu_muon, @ma_sach, @da_xoa)
                                    update sach set so_luong = so_luong - 1 where ma_sach = @ma_sach";
                    SqlCommand cmd1 = new SqlCommand(query, connect);

                    SqlParameter param_ma_phieu_muon = new SqlParameter();
                    param_ma_phieu_muon.ParameterName = "@ma_phieu_muon";
                    param_ma_phieu_muon.Value = maPhieu;

                    SqlParameter param_ma_phieu = new SqlParameter();
                    param_ma_phieu.ParameterName = "@ma_sach";
                    param_ma_phieu.Value = masach;

                    SqlParameter param_da_xoa = new SqlParameter();
                    param_da_xoa.ParameterName = "@da_xoa";
                    param_da_xoa.Value = 0;

                    cmd1.Parameters.Add(param_ma_phieu_muon);
                    cmd1.Parameters.Add(param_ma_phieu);
                    cmd1.Parameters.Add(param_da_xoa);


                    if (cmd1.ExecuteNonQuery() > 0)
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

        private string Max_Maphieu()
        {
            string ketqua = "";
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connect.Open();
                    string query = @"SELECT MAX(ma_phieu) FROM phieumuon";
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

        public bool KiemTraDocGia_tontai(string DocGia)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();

                    string query = @"select * from docgia where da_xoa = 0 and ma_doc_gia = @doc_gia";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataReader reader = null;
                    DataTable data = new DataTable();
                    SqlParameter param_doc_gia = new SqlParameter();
                    param_doc_gia.ParameterName = "@doc_gia";
                    param_doc_gia.Value = DocGia;

                    cmd.Parameters.Add(param_doc_gia);

                    reader = cmd.ExecuteReader();
                    data.Load(reader);
                    if (data.Rows.Count > 0)
                        ketqua = true;
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

        public bool KiemTraDocGia_dangmuon(string DocGia)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connect.Open();

                    string query = @"
SELECT     dbo.docgia.ma_doc_gia, dbo.docgia.ten_doc_gia, dbo.docgia.gioi_tinh, dbo.docgia.ngay_sinh, dbo.docgia.dia_chi, dbo.docgia.CMND, dbo.docgia.SDT, dbo.phieumuon.trang_thai, 
                      dbo.phieumuon.da_xoa
FROM         dbo.phieumuon INNER JOIN
                      dbo.docgia ON dbo.phieumuon.doc_gia = dbo.docgia.ma_doc_gia
WHERE     (dbo.docgia.ma_doc_gia = @DocGia) AND (dbo.phieumuon.trang_thai = 0) AND (dbo.phieumuon.da_xoa = 0)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataReader reader = null;
                    DataTable data = new DataTable();
                    SqlParameter param_doc_gia = new SqlParameter();
                    param_doc_gia.ParameterName = "@DocGia";
                    param_doc_gia.Value = DocGia;

                    cmd.Parameters.Add(param_doc_gia);

                    reader = cmd.ExecuteReader();
                    data.Load(reader);
                    if (data.Rows.Count > 0)
                        ketqua = true;
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

        public bool xatnhantra(string maphieu)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connect.Open();

                    string query = "update phieumuon set trang_thai = @trangthai where ma_phieu = @maphieu";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param_trangthai = new SqlParameter();
                    param_trangthai.ParameterName = "@trangthai";
                    param_trangthai.Value = 1;
                    SqlParameter param_maphieu = new SqlParameter();
                    param_maphieu.ParameterName = "@maphieu";
                    param_maphieu.Value = maphieu;
                    cmd.Parameters.Add(param_trangthai);
                    cmd.Parameters.Add(param_maphieu);
                    // SqlCommand command = new SqlCommand(query, connect);

                    if (cmd.ExecuteNonQuery() > 0)
                        ketqua = true;

                    DataTable datasach = new DataTable();
                    datasach = this.searcher_thongtinphieumuon(maphieu);

                    for (int i = 0, size = datasach.Rows.Count; i < size; ++i)
                    {
                        TraSachTrongThongTinPhieu(datasach.Rows[i][1].ToString());
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

        public bool xoaphieu(string maphieu)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connect.Open();

                    string query = "update phieumuon set da_xoa = @da_xoa where ma_phieu = @maphieu";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param_da_xoa = new SqlParameter();
                    param_da_xoa.ParameterName = "@da_xoa";
                    param_da_xoa.Value = 1;
                    SqlParameter param_maphieu = new SqlParameter();
                    param_maphieu.ParameterName = "@maphieu";
                    param_maphieu.Value = maphieu;
                    cmd.Parameters.Add(param_da_xoa);
                    cmd.Parameters.Add(param_maphieu);

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

        public void TraSachTrongThongTinPhieu(string masach)
        {
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connect.Open();

                    string query = "update sach set so_luong = so_luong + 1 where ma_sach = @masach";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param_masach = new SqlParameter();
                    param_masach.ParameterName = "@masach";
                    param_masach.Value = masach;
                    cmd.Parameters.Add(param_masach);
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
        
        public bool khoiphuc(string maphieu)
        {
            bool ketqua = false;
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connect.Open();

                    string query = "update phieumuon set da_xoa = @da_xoa where ma_phieu = @maphieu";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param_da_xoa = new SqlParameter();
                    param_da_xoa.ParameterName = "@da_xoa";
                    param_da_xoa.Value = 0;
                    SqlParameter param_maphieu = new SqlParameter();
                    param_maphieu.ParameterName = "@maphieu";
                    param_maphieu.Value = maphieu;
                    cmd.Parameters.Add(param_da_xoa);
                    cmd.Parameters.Add(param_maphieu);
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

                    string query = "select * from phieumuon where da_xoa=@da_xoa and ten_sach like @ten_sach";
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

        public DataTable searcher_phieumuon(string maphieumuon)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "select * from phieumuon where da_xoa=@da_xoa and ma_phieu=@ma_phieu";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = 0;
                    SqlParameter param_ma_phieu = new SqlParameter();
                    param_ma_phieu.ParameterName = "@ma_phieu";
                    param_ma_phieu.Value = maphieumuon;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_phieu);
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

        public DataTable searcher_thongtinphieumuon(string maphieumuon)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "select * from thongtinphieumuon where ma_phieu_muon = @ma_phieu";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param_ma_phieu = new SqlParameter();
                    param_ma_phieu.ParameterName = "@ma_phieu";
                    param_ma_phieu.Value = maphieumuon;

                    cmd.Parameters.Add(param_ma_phieu);
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
            return data;
        }

        public DataTable searcher_phieumuon(string maphieumuon, bool daxoa)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString.connectionstring))
            {
                try
                {

                    connect.Open();
                    string query = "select * from phieumuon where da_xoa=@da_xoa and ma_phieu=@ma_phieu";
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@da_xoa";
                    param.Value = daxoa;
                    SqlParameter param_ma_phieu = new SqlParameter();
                    param_ma_phieu.ParameterName = "@ma_phieu";
                    param_ma_phieu.Value = maphieumuon;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param_ma_phieu);
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
