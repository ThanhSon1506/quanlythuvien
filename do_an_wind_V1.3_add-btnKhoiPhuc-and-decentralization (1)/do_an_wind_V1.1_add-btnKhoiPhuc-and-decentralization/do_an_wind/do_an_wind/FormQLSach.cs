using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BAL;
using BEL;

namespace do_an_wind
{
    public partial class FormQLSach : Form
    {
        public int chucNang;
        private BEL_sach sach = new BEL_sach();
        public string nhaxuatban = null;
        public string tacgia = null;
        public string theloai = null;
        public FormQLSach()
        {
            InitializeComponent();
        }

        private void FormQLSach_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            txtGiaMuon.MaxLength = 20;
            txtMaSach.Enabled = false;
            txtNamPhatHanh.MaxLength = 20;
            txtTenSach.MaxLength = 20;
            txtTim.MaxLength = 20;

            hienthidanhsachnhaxuatban(cboNhaPhatHanh);
            hienthidanhsachtacgia(cboTacGia);
            hienthidanhsachtheloai(cboTheLoai); 

            dgvQuanLySach.AllowUserToAddRows = false;
            dgvQuanLySach.RowHeadersVisible = false;
            btnXatNhan.Visible = btnLamMoi.Visible = btnQuayLai.Visible = false;
            BAL_sach xulySach = new BAL_sach();
            DataTable data;
            if (FormDangNhap.Nhanvien.Quan_ly)
            {
                data = xulySach.getAll();
                dgvQuanLySach.DataSource = data;
                rowtosach(0);
                btnKhoiPhuc.Visible = sach.Da_xoa;
            }
            else
            {
                data = xulySach.getAllExist();
                dgvQuanLySach.DataSource = data;
                rowtosach(0);
                //ẩn đòng trạng thái đã xóa đi
                dgvQuanLySach.Columns[9].Visible = false;
            }
           
            foreach (DataRow row in data.Rows)
            {
                acsc.Add(row["ma_sach"].ToString());
                acsc.Add(row["ten_sach"].ToString());
            }
            txtTim.AutoCompleteCustomSource = acsc;
        }
        private void rowtosach(int id)
        {
            //Mã độc giẳ
            sach.Ma_sach =txtMaSach.Text= dgvQuanLySach.Rows[id].Cells[0].Value.ToString();
            //Tên độc giả
            sach.Ten_sach=txtTenSach.Text = dgvQuanLySach.Rows[id].Cells[1].Value.ToString();
            //sach.So_luong = numberSoLuong.Value = 10; //Convert.ToInt32(dgvQuanLySach.Rows[id].Cells[2].Value.ToString());
            //sach.
            numberSoLuong.Value = Convert.ToInt32(dgvQuanLySach.Rows[id].Cells[2].Value.ToString());
            sach.So_luong = Convert.ToInt32(numberSoLuong.Value);
            txtNamPhatHanh.Text = dgvQuanLySach.Rows[id].Cells[3].Value.ToString();
            sach.Nam_xuat_ban = Convert.ToInt32(txtNamPhatHanh.Text);
            sach.Nha_xuat_ban = dgvQuanLySach.Rows[id].Cells[4].Value.ToString();
            sach.Tac_gia = dgvQuanLySach.Rows[id].Cells[5].Value.ToString();
            sach.The_loai = dgvQuanLySach.Rows[id].Cells[6].Value.ToString();
            sach.Gia_muon =txtGiaMuon.Text= dgvQuanLySach.Rows[id].Cells[7].Value.ToString();
            sach.Ngay_nhap = Convert.ToDateTime(dgvQuanLySach.Rows[id].Cells[8].Value.ToString());
            if (Convert.ToBoolean(dgvQuanLySach.Rows[id].Cells[9].Value.ToString()) == true)
                sach.Da_xoa = true;
            else
                sach.Da_xoa = false;
        }
        private void swap_btn()
        {
            gbxThongTin.Enabled = !gbxThongTin.Enabled;
            txtTenSach.Focus();
            btnThem.Visible = btnXoa.Visible = btnSua.Visible = !btnSua.Visible;
            btnXatNhan.Visible = btnLamMoi.Visible = btnQuayLai.Visible = !btnQuayLai.Visible;
            dgvQuanLySach.Enabled = !dgvQuanLySach.Enabled;
        }
        private void sachtoText()
        {
            txtMaSach.Text = sach.Ma_sach;
            txtTenSach.Text = sach.Ten_sach;
            numberSoLuong.Value = sach.So_luong;
            dateTimeNgayDang.Value = sach.Ngay_nhap;
            txtGiaMuon.Text = sach.Gia_muon;
            nhaxuatban = sach.Nha_xuat_ban;
            tacgia = sach.Tac_gia;
            theloai = sach.The_loai;
            txtNamPhatHanh.Text = sach.Nam_xuat_ban.ToString();
        }
        private void resetText()
        {
            txtMaSach.Text = txtTenSach.Text = txtGiaMuon.Text = txtNamPhatHanh.Text = txtTim.Text = "";
            numberSoLuong.Value = 0;
            dateTimeNgayDang.ResetText();
        }
        public void hienthidanhsachnhaxuatban(ComboBox cbo)
        {
            BAL_nhaxuatban xulynhaxuatban = new BAL_nhaxuatban();
            cbo.DataSource = xulynhaxuatban.getAllExist();
            cbo.DisplayMember = "ten_nha_xuat_ban";
            cbo.ValueMember = "ma_nha_xuat_ban";
        }
        public void hienthidanhsachtacgia(ComboBox cbo)
        {
            BAL_tacgia xulytacgia = new BAL_tacgia();
            cbo.DataSource = xulytacgia.getAllExist();
            cbo.DisplayMember = "ten_tac_gia";
            cbo.ValueMember = "ma_tac_gia";
        }
        public void hienthidanhsachtheloai(ComboBox cbo)
        {
            BAL_theloai xulytheloai = new BAL_theloai();
            cbo.DataSource = xulytheloai.getAllExist();
            cbo.DisplayMember = "the_loai";
            cbo.ValueMember = "ma_the_loai";
        }

        private void dgvQuanLySach_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvQuanLySach.SelectedRows.Count < 2)
                btnThem.Enabled = true;
            if (dgvQuanLySach.SelectedRows.Count == 1)
            {
                btnThem.Enabled = btnSua.Enabled = true;
                //lấy id row đc chọn
                int id = dgvQuanLySach.SelectedRows[0].Index;
                //in data vào test box và thêm vào biến
                rowtosach(id);
                sachtoText();
                btnKhoiPhuc.Visible = sach.Da_xoa;
            }
            else
            {
                resetText();
                btnThem.Enabled = btnSua.Enabled = false;
            }
        }


        private void txtTim_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtTim.Text == "Tên sách, mã sách")
                txtTim.Text = "";
        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTim.PerformClick();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            BAL_sach xulysach = new BAL_sach();
            if (IsNumber(txtTim.Text) == true)
            {
                DataTable Table = null;
               
                if (FormDangNhap.Nhanvien.Quan_ly)
                {
                    Table = xulysach.searcher_msach_quanly(txtTim.Text);
                }
                else
                {
                    Table = xulysach.searcher_msach(txtTim.Text);
                }
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvQuanLySach.DataSource = Table;

                    dgvQuanLySach.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTim.Text))
                {
                    if (FormDangNhap.Nhanvien.Quan_ly)
                    {
                        dgvQuanLySach.DataSource = xulysach.getAll();
                        //xóa dòng cuối
                        dgvQuanLySach.AllowUserToAddRows = false;
                    }
                    else
                    {
                        dgvQuanLySach.DataSource = xulysach.getAllExist();
                        //xóa dòng cuối
                        dgvQuanLySach.AllowUserToAddRows = false;
                    }
                   
                }
                else
                {
                    MessageBox.Show("Mã này " + txtTim.Text + " chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                DataTable Table = null;

                if (FormDangNhap.Nhanvien.Quan_ly)
                {
                    Table = xulysach.searcher_sach_quanly(txtTim.Text);
                }
                else
                {
                    Table = xulysach.searcher_sach(txtTim.Text);
                }
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvQuanLySach.DataSource = Table;

                    dgvQuanLySach.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTim.Text))
                {
                    if (FormDangNhap.Nhanvien.Quan_ly)
                    {
                        dgvQuanLySach.DataSource = xulysach.getAll();
                        //xóa dòng cuối
                        dgvQuanLySach.AllowUserToAddRows = false;
                    }
                    else
                    {
                        dgvQuanLySach.DataSource = xulysach.getAllExist();
                        //xóa dòng cuối
                        dgvQuanLySach.AllowUserToAddRows = false;
                    }

                }
                else
                {
                    MessageBox.Show("Sách này " + txtTim.Text + " chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetText();
            chucNang = 1;
            swap_btn();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucNang = 2;
            swap_btn();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool ketqua = false;
            string manhaxuatban = null;
            BAL_nhaxuatban xulynhaxuatban = new BAL_nhaxuatban();
            DataTable dtnhaxuatban = new DataTable();
            dtnhaxuatban = xulynhaxuatban.searcher_nhaxuatban(cboNhaPhatHanh.Text.Trim());
            manhaxuatban = dtnhaxuatban.Rows[0]["ma_nha_xuat_ban"].ToString();
            string mantheloai = null;
            BAL_theloai xulytheloai = new BAL_theloai();
            DataTable dttheloai = new DataTable();
            dttheloai = xulytheloai.searcher_theloai(cboTheLoai.Text.Trim());
            mantheloai = dttheloai.Rows[0]["ma_the_loai"].ToString();
            string matacgia = null;
            BAL_tacgia xulytacgia = new BAL_tacgia();
            DataTable dttacgia = new DataTable();
            dttacgia = xulytacgia.searcher_tacgia(cboTacGia.Text.Trim());
            matacgia = dttacgia.Rows[0]["ma_tac_gia"].ToString();
            BEL.BEL_sach sach = new BEL.BEL_sach(txtMaSach.Text, txtTenSach.Text, Convert.ToInt32(numberSoLuong.Value), Convert.ToInt32(txtNamPhatHanh.Text), manhaxuatban, matacgia, mantheloai, txtGiaMuon.Text, dateTimeNgayDang.Value, false);
            BAL.BAL_sach xulysach = new BAL.BAL_sach();
            string[] arr = new string[dgvQuanLySach.SelectedRows.Count];
            int id = 0;
            try
            {
                foreach (DataGridViewRow rows in dgvQuanLySach.SelectedRows)
                {
                    arr[id++] = dgvQuanLySach.Rows[rows.Index].Cells[0].Value.ToString();
                }
                DialogResult res = MessageBox.Show("Xát nhận xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    if (!FormDangNhap.Nhanvien.Quan_ly)
                        foreach (DataGridViewRow item in dgvQuanLySach.SelectedRows)
                        {
                            dgvQuanLySach.Rows.RemoveAt(item.Index);
                        }
                    ketqua = xulysach.capnhat_tragthai(sach);
                    if (ketqua == false)
                    {
                        MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvQuanLySach.DataSource = xulysach.getAll();
                        //xóa dòng cuối
                        dgvQuanLySach.AllowUserToAddRows = false;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            

            if (FormDangNhap.Nhanvien.Quan_ly)
            {
                dgvQuanLySach.DataSource = xulysach.getAll();
                rowtosach(0);
                btnKhoiPhuc.Visible = sach.Da_xoa;
            }
            else
            {
                dgvQuanLySach.DataSource = xulysach.getAllExist();
                rowtosach(0);
                //ẩn đòng trạng thái đã xóa đi
                dgvQuanLySach.Columns[5].Visible = false;
            }
        }

        private void btnXatNhan_Click(object sender, EventArgs e)
        {
            //1 = them , 2 = sua
            if (this.chucNang == 1)
            {
                if (!string.IsNullOrEmpty(txtGiaMuon.Text) && !string.IsNullOrEmpty(txtNamPhatHanh.Text) && !string.IsNullOrEmpty(txtTenSach.Text))
                {
                    string manhaxuatban = null;
                    BAL_nhaxuatban xulynhaxuatban = new BAL_nhaxuatban();
                    DataTable dtnhaxuatban = new DataTable();
                    dtnhaxuatban = xulynhaxuatban.searcher_nhaxuatban(cboNhaPhatHanh.Text.Trim());
                    manhaxuatban = dtnhaxuatban.Rows[0]["ma_nha_xuat_ban"].ToString();

                    string mantheloai = null;
                    BAL_theloai xulytheloai = new BAL_theloai();
                    DataTable dttheloai = new DataTable();
                    dttheloai = xulytheloai.searcher_theloai(cboTheLoai.Text.Trim());
                    mantheloai = dttheloai.Rows[0]["ma_the_loai"].ToString();

                    string matacgia = null;
                    BAL_tacgia xulytacgia = new BAL_tacgia();
                    DataTable dttacgia = new DataTable();
                    dttacgia = xulytacgia.searcher_tacgia(cboTacGia.Text.Trim());
                    matacgia = dttacgia.Rows[0]["ma_tac_gia"].ToString();

                    BEL.BEL_sach sach = new BEL.BEL_sach(txtMaSach.Text, txtTenSach.Text, Convert.ToInt32(numberSoLuong.Value), Convert.ToInt32(txtNamPhatHanh.Text), manhaxuatban, matacgia, mantheloai, txtGiaMuon.Text, dateTimeNgayDang.Value, false);
                    BAL.BAL_sach xulysach = new BAL.BAL_sach();
                    bool ketqua = xulysach.Themsach(sach);
                    if (ketqua == true)
                    {
                        MessageBox.Show("Đã thêm sách " + txtTenSach.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvQuanLySach.DataSource = xulysach.getAll();
                    }
                    else
                    {
                        MessageBox.Show("Đã thêm sách thất bại " + txtTenSach.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Dữ liệu đang bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (this.chucNang == 2)
            {
                if (!string.IsNullOrEmpty(txtGiaMuon.Text) && !string.IsNullOrEmpty(txtNamPhatHanh.Text) && !string.IsNullOrEmpty(txtTenSach.Text))
                {
                    string manhaxuatban = null;
                    BAL_nhaxuatban xulynhaxuatban = new BAL_nhaxuatban();
                    DataTable dtnhaxuatban = new DataTable();
                    dtnhaxuatban = xulynhaxuatban.searcher_nhaxuatban(cboNhaPhatHanh.Text.Trim());
                    manhaxuatban = dtnhaxuatban.Rows[0]["ma_nha_xuat_ban"].ToString();

                    string mantheloai = null;
                    BAL_theloai xulytheloai = new BAL_theloai();
                    DataTable dttheloai = new DataTable();
                    dttheloai = xulytheloai.searcher_theloai(cboTheLoai.Text.Trim());
                    mantheloai = dttheloai.Rows[0]["ma_the_loai"].ToString();

                    string matacgia = null;
                    BAL_tacgia xulytacgia = new BAL_tacgia();
                    DataTable dttacgia = new DataTable();
                    dttacgia = xulytacgia.searcher_tacgia(cboTacGia.Text.Trim());
                    matacgia = dttacgia.Rows[0]["ma_tac_gia"].ToString();

                    BEL.BEL_sach sach = new BEL.BEL_sach(txtMaSach.Text, txtTenSach.Text, Convert.ToInt32(numberSoLuong.Value), Convert.ToInt32(txtNamPhatHanh.Text), manhaxuatban, matacgia, mantheloai, txtGiaMuon.Text, dateTimeNgayDang.Value, false);
                    BAL.BAL_sach xulysach = new BAL.BAL_sach();
                    bool ketqua = xulysach.Suasach(sach);
                    if (ketqua == true)
                    {
                        MessageBox.Show("Đã update sách " + txtTenSach.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvQuanLySach.DataSource = xulysach.getAll();
                        //xóa dòng cuối
                        dgvQuanLySach.AllowUserToAddRows = false;
                    }
                }
                else {
                    MessageBox.Show("Dữ liệu đang bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            swap_btn();
        }
        public bool IsNumber(string str)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(str);
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //1 = them , 2 = sua
            if (this.chucNang == 1)
            {
                resetText();
            }
            if (this.chucNang == 2)
            {
                sachtoText();
            }
            swap_btn();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            sachtoText();
            swap_btn();
        }

        private void txtTenSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtNamPhatHanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            string manhaxuatban = null;
            BAL_nhaxuatban xulynhaxuatban = new BAL_nhaxuatban();
            DataTable dtnhaxuatban = new DataTable();
            dtnhaxuatban = xulynhaxuatban.searcher_nhaxuatban(cboNhaPhatHanh.Text.Trim());
            manhaxuatban = dtnhaxuatban.Rows[0]["ma_nha_xuat_ban"].ToString();
            string mantheloai = null;
            BAL_theloai xulytheloai = new BAL_theloai();
            DataTable dttheloai = new DataTable();
            dttheloai = xulytheloai.searcher_theloai(cboTheLoai.Text.Trim());
            mantheloai = dttheloai.Rows[0]["ma_the_loai"].ToString();
            string matacgia = null;
            BAL_tacgia xulytacgia = new BAL_tacgia();
            DataTable dttacgia = new DataTable();
            dttacgia = xulytacgia.searcher_tacgia(cboTacGia.Text.Trim());
            matacgia = dttacgia.Rows[0]["ma_tac_gia"].ToString();
            BEL.BEL_sach sach = new BEL.BEL_sach(txtMaSach.Text, txtTenSach.Text, Convert.ToInt32(numberSoLuong.Value), Convert.ToInt32(txtNamPhatHanh.Text), manhaxuatban, matacgia, mantheloai, txtGiaMuon.Text, dateTimeNgayDang.Value, false);
            BAL.BAL_sach xulysach = new BAL.BAL_sach();
            string[] arr = new string[dgvQuanLySach.SelectedRows.Count];
            int id = 0;
            try
            {
                foreach (DataGridViewRow rows in dgvQuanLySach.SelectedRows)
                {
                    arr[id++] = dgvQuanLySach.Rows[rows.Index].Cells[0].Value.ToString();
                }
                DialogResult res = MessageBox.Show("Xác nhận khôi phục ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    if (!FormDangNhap.Nhanvien.Quan_ly)
                        foreach (DataGridViewRow item in dgvQuanLySach.SelectedRows)
                        {
                            dgvQuanLySach.Rows.RemoveAt(item.Index);
                        }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bool ketqua = xulysach.capnhat_tragthai_moi(sach);
            if (ketqua == false)
            {
                MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvQuanLySach.DataSource = xulysach.getAll();
                //xóa dòng cuối
                dgvQuanLySach.AllowUserToAddRows = false;
            } 
            if (FormDangNhap.Nhanvien.Quan_ly)
            {
                dgvQuanLySach.DataSource = xulysach.getAll();
                rowtosach(0);
                btnKhoiPhuc.Visible = sach.Da_xoa;
            }
            else
            {
                dgvQuanLySach.DataSource = xulysach.getAll();
                rowtosach(0);
                //ẩn đòng trạng thái đã xóa đi
                dgvQuanLySach.Columns[5].Visible = false;
            }
        }

        private void FormQLSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
