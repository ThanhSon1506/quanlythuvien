using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_wind
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            labelTennv.Text = FormDangNhap.Nhanvien.Ten_nhan_vien;
            if (FormDangNhap.Nhanvien.Quan_ly == true)
                labelChucvu.Text += " Quản lý";
            else
            {
                labelChucvu.Text += " Nhân viên";
                btnNhanVien.Enabled = btnThongKe.Enabled = false;
            }
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormQLSach form = new FormQLSach();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormDocGia form = new FormDocGia();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnMuongTra_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormMuonTraSach form = new FormMuonTraSach();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormNhaXuatBan form = new FormNhaXuatBan();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormTacGia form = new FormTacGia();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormNhanVien form = new FormNhanVien();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormTheLoai form = new FormTheLoai();
            form.ShowDialog();
            this.Visible = true;
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //FormThongKe form = new FormThongKe();
      //      form.ShowDialog();
            this.Visible = true;
        }
    }
}
