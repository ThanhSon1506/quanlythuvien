using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using BEL;
using BAL;

namespace do_an_wind
{
    public partial class FormDangNhap : Form
    {
        private static BEL_nhanvien nhanvien = new BEL_nhanvien();

        public static BEL_nhanvien Nhanvien
        {
            get { return FormDangNhap.nhanvien; }
            set { FormDangNhap.nhanvien = value; }
        }

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }

        // khai bao ma hoa MD5
        public MD5 mahoa = MD5.Create();
        //Ma hoa 
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

        public int Tragiatri(int i)
        {
            return i;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            //test code

            //******
            if (txtTaiKhoan.Text == "" || txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Không được để trống tài khoản hoặc mật khẩu !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtTaiKhoan.Text == "")
                    txtTaiKhoan.Focus();
                else if (txtTaiKhoan.Text == "")
                    txtMatKhau.Focus();
            }
            else
            {
                try
                {
                    string taikhoan = null;
                    string matkhau = null;
                    taikhoan = Mahoakitu(txtTaiKhoan.Text);
                    matkhau = Mahoakitu(txtMatKhau.Text);

                    BEL.BEL_taiKhoan account = new BEL_taiKhoan(taikhoan, matkhau);
                    DataTable data = new DataTable();
                    data = BAL.BAL_taiKhoan.getExist(account);
                    if (data.Rows.Count > 0)
                    {
                        txtTaiKhoan.Clear();
                        txtMatKhau.Clear();
                        string manv = data.Rows[0][0].ToString();
                        data = BAL.BAL_taiKhoan.getNhanVien(manv);
                        Nhanvien.Ma_nhan_vien = data.Rows[0][0].ToString();
                        Nhanvien.Ten_nhan_vien = data.Rows[0][1].ToString();
                        Nhanvien.Gioi_tinh = bool.Parse(data.Rows[0][2].ToString());
                        Nhanvien.Ngay_sinh = Convert.ToDateTime(data.Rows[0][3].ToString());
                        Nhanvien.Dia_chi = data.Rows[0][4].ToString();
                        Nhanvien.Quan_ly = bool.Parse(data.Rows[0][5].ToString());
                        Nhanvien.Sdt = data.Rows[0][6].ToString();
                        DialogResult result = MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTaiKhoan.Text = txtMatKhau.Text = "";
                        FormMenu form = new FormMenu();
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception err)
                {
                    throw;
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("bạn có thực sự muốn thoát ?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
                Application.Exit();
        }

        private void imgHienThiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                imgHienThiMatKhau.Image = do_an_wind.Properties.Resources.eye_checked;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                imgHienThiMatKhau.Image = do_an_wind.Properties.Resources.eye_unchecked;
            }
        }
    }
}
