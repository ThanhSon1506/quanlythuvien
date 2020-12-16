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
using System.Data;
using BAL;
using BEL;

namespace do_an_wind
{
    public partial class FormMuonTraSach : Form
    {
        private BEL_sach sach = new BEL_sach();
        private const int maxMuon = 6;

        private BEL_phieumuon phieumuon_muon = new BEL_phieumuon();
        private BEL_phieumuon phieumuon_tra = new BEL_phieumuon();
        private BAL_phieumuon xulyphieumuon = new BAL_phieumuon();
         


        public FormMuonTraSach()
        {
            InitializeComponent();
        }

        private void FormMuonTraSach_Load(object sender, EventArgs e)
        {

            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            AutoCompleteStringCollection acsc_tra = new AutoCompleteStringCollection();
            DataTable data = null;
            DataTable data_tra = null;
            BAL_sach xulysach = new BAL_sach();
            data = xulysach.getAll();
            BAL_phieumuon xulyphieumuon = new BAL_phieumuon();
            data_tra = xulyphieumuon.GetAll();
            //******************************
            //**Muon
            dgvSach_muon.AllowUserToAddRows = false;
            dgvSach_muon.RowHeadersVisible = false;
            dgvSachMuon_muon.AllowUserToAddRows = false;
            dgvSachMuon_muon.RowHeadersVisible = false;
            muon_load();
            
            //******************************
            //**Tra
            dgvPhieuMuon.AllowUserToAddRows = false;
            dgvPhieuMuon.RowHeadersVisible = false;
            dgvThongTinPhieu.AllowUserToAddRows = false;
            dgvThongTinPhieu.RowHeadersVisible = false;
            tra_load();
            foreach (DataRow row in data.Rows)
            {
                acsc.Add(row["ma_sach"].ToString());
                acsc.Add(row["ten_sach"].ToString());
            }
            foreach (DataRow row in data_tra.Rows)
            {
                acsc_tra.Add(row["ma_phieu"].ToString());
                acsc_tra.Add(row["doc_gia"].ToString());
                acsc_tra.Add(row["nhan_vien"].ToString());
            }
            txtTimSach_muon.AutoCompleteCustomSource = acsc;
            txtTimTra.AutoCompleteCustomSource = acsc_tra;
        }

        private void muon_load()
        {
            BAL_sach sach = new BAL_sach();
            dgvSach_muon.DataSource = sach.getAllExist();
            //ẩn dồng cuối và cột đầu

            dgvSach_muon.Columns[10].Visible = false;
            btnXatNhan_muon.Enabled = false;
            txtNhanVien.Text = FormDangNhap.Nhanvien.Ma_nhan_vien;
        }

        private void tra_load()
        {

            if (FormDangNhap.Nhanvien.Quan_ly)
            {
                dgvPhieuMuon.DataSource = xulyphieumuon.GetAll();
                rowtoPhieuMuon(0);
                phieumuontotxt();
                btnKhoiPhuc.Visible = phieumuon_tra.Da_xoa;

            }
            else
            {
                dgvPhieuMuon.DataSource = xulyphieumuon.ChuaTra();
                rowtoPhieuMuon(0);
                phieumuontotxt();
                dgvPhieuMuon.Columns[7].Visible = false;
            }
            dgvThongTinPhieu.DataSource = xulyphieumuon.thongtinphieu(phieumuon_tra.Ma);
            themsach();
        }

        //*************************************************************************************************************************
        //mượn
        private void txtTimSach_muon_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtTimSach_muon.Text == "Tên sách, mã sách")
                txtTimSach_muon.Text = "";
        }

        private void txtTimSach_muon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTimSach_muon.PerformClick();
        }

        private void btnTimSach_muon_Click(object sender, EventArgs e)
        {
            BAL_sach xulysach = new BAL_sach();
            if (IsNumber(txtTimSach_muon.Text) == true)
            {
                DataTable Table = xulysach.searcher_msach(txtTimSach_muon.Text);
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvSach_muon.DataSource = xulysach.searcher_msach(txtTimSach_muon.Text);

                    dgvSach_muon.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTimSach_muon.Text))
                {
                    dgvSach_muon.DataSource = xulysach.getAll();
                    //xóa dòng cuối
                    dgvSach_muon.AllowUserToAddRows = false;
                }
                else
                {
                    MessageBox.Show("Mã này " + txtTimSach_muon.Text + " chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                DataTable Table = xulysach.searcher_sach(txtTimSach_muon.Text);
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvSach_muon.DataSource = Table;
                    dgvSach_muon.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTimSach_muon.Text))
                {
                    dgvSach_muon.DataSource = xulysach.getAll();
                    //xóa dòng cuối
                    dgvSach_muon.AllowUserToAddRows = false;
                }
                else
                {
                    MessageBox.Show("Sách này " + txtTimSach_muon.Text + " chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void dgvSach_muon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (phieumuon_muon.Dsmuon.Count < maxMuon)
                {
                    rowtosach(e.RowIndex);
                    if(sach.So_luong == 0)
                    {
                        MessageBox.Show("Sách này đã hết !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    foreach (string tmp in phieumuon_muon.Dsmuon)
                    {
                        if (tmp == sach.Ma_sach)
                        {
                            MessageBox.Show("Sách này đã tồn tại trong danh sách mượn", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    phieumuon_muon.Themsach(sach.Ma_sach);
                    dgvSachMuon_muon.Rows.Add(sach.Ma_sach, sach.Ten_sach, sach.Tac_gia, sach.Gia_muon);
                    btnXatNhan_muon.Enabled = true;
                    txtTongTien_muon.Text = (int.Parse(txtTongTien_muon.Text) + int.Parse(sach.Gia_muon)).ToString();
                }
                else
                {
                    MessageBox.Show("Số lượng sách mượn tối da 6 cuốn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void rowtosach(int id)
        {
            sach.Ma_sach = dgvSach_muon.Rows[id].Cells[1].Value.ToString();
            sach.Ten_sach = dgvSach_muon.Rows[id].Cells[2].Value.ToString();
            sach.So_luong = int.Parse( dgvSach_muon.Rows[id].Cells[3].Value.ToString());
            sach.Tac_gia = dgvSach_muon.Rows[id].Cells[6].Value.ToString();
            sach.Gia_muon = dgvSach_muon.Rows[id].Cells[8].Value.ToString();
        }

        private void dgvSachMuon_muon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string mas = dgvSachMuon_muon.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTongTien_muon.Text = (int.Parse(txtTongTien_muon.Text) - int.Parse(dgvSachMuon_muon.Rows[e.RowIndex].Cells[3].Value.ToString())).ToString();
                phieumuon_muon.xoasach(mas);
                dgvSachMuon_muon.Rows.RemoveAt(e.RowIndex);
            }
            if(dgvSachMuon_muon.Rows.Count == 0)
                btnXatNhan_muon.Enabled = false;
        }

        private void resetText_muon()
        {
            txtDocGia_muon.Text = "";
            txtTongTien_muon.Text = "0";
            dateTimeNgayTra_muon.ResetText();
            dgvSachMuon_muon.Rows.Clear();
            phieumuon_muon = new BEL_phieumuon();
            btnXatNhan_muon.Enabled = false;
        }

        private void btnLamMoi_muon_Click(object sender, EventArgs e)
        {
            resetText_muon();
        }

        private void btnXatNhan_muon_Click(object sender, EventArgs e)
        {
             
            if (txtDocGia_muon.Text == "" || dateTimeNgayTra_muon.Value < dateTimeNgayMuong_muon.Value)
            {
                MessageBox.Show("Chưa điền đủ thông tin hoặc không hợp lệ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!IsNumber(txtDocGia_muon.Text))
            {
                MessageBox.Show("Mã đọc giả không hợp lệ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!xulyphieumuon.KiemTraDocGia_tontai(txtDocGia_muon.Text))
                {
                    MessageBox.Show("Không có đọc giả này", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDocGia_muon.Focus();
                    return;
                }
                else if (xulyphieumuon.KiemTraDocGia_dangmuon(txtDocGia_muon.Text))
                {
                    MessageBox.Show("Đọc giả này đang mượn sách", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDocGia_muon.Focus();
                    return;
                }
                else
                {
                    phieumuon_muon.Nhan_vien = txtNhanVien.Text;
                    phieumuon_muon.Doc_gia = txtDocGia_muon.Text;
                    phieumuon_muon.Ngay_muon = dateTimeNgayMuong_muon.Value;
                    phieumuon_muon.Ngay_tra = dateTimeNgayTra_muon.Value;
                    phieumuon_muon.Tong_tien = txtTongTien_muon.Text;
                    if (xulyphieumuon.insert_Phieu(phieumuon_muon))
                    {
                        MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetText_muon();
                        tra_load();
                        muon_load();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        //*************************************************************************************************************************
        //dung chung

        public void themsach()
        {
            int size = dgvThongTinPhieu.Rows.Count;
            for (int i = 0; i < size; ++i)
            {
                phieumuon_tra.Themsach(dgvThongTinPhieu.Rows[i].Cells[0].Value.ToString());
            }
        }

        public bool IsNumber(string str)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(str);
        }

        //*************************************************************************************************************************
        //trả

        private void dgvPhieuMuon_MouseClick(object sender, MouseEventArgs e)
        {
            //lấy id row đc chọn
            int id = dgvPhieuMuon.SelectedRows[0].Index;
            if (bool.Parse(dgvPhieuMuon.Rows[id].Cells[6].Value.ToString()))
                btnXatNhanTra.Enabled = false;
            else
            {
                btnXatNhanTra.Enabled = true;
                btnKhoiPhuc.Enabled = btnXatNhanTra.Enabled = true;
                //in data vào test box và thêm vào biến
                rowtoPhieuMuon(id);
                phieumuontotxt();
                btnKhoiPhuc.Visible = phieumuon_tra.Da_xoa;
                dgvThongTinPhieu.DataSource = xulyphieumuon.thongtinphieu(phieumuon_tra.Ma);
                themsach();
            }

        }

        private void rowtoPhieuMuon(int id)
        {
            phieumuon_tra.Ma = dgvPhieuMuon.Rows[id].Cells[0].Value.ToString();
            phieumuon_tra.Doc_gia = dgvPhieuMuon.Rows[id].Cells[1].Value.ToString();
            phieumuon_tra.Nhan_vien = dgvPhieuMuon.Rows[id].Cells[2].Value.ToString();
            phieumuon_tra.Ngay_muon = Convert.ToDateTime(dgvPhieuMuon.Rows[id].Cells[3].Value);
            phieumuon_tra.Ngay_tra = Convert.ToDateTime(dgvPhieuMuon.Rows[id].Cells[4].Value);
            phieumuon_tra.Tong_tien = dgvPhieuMuon.Rows[id].Cells[5].Value.ToString();
            phieumuon_tra.Trang_thai = bool.Parse(dgvPhieuMuon.Rows[id].Cells[6].Value.ToString());
            phieumuon_tra.Da_xoa = bool.Parse(dgvPhieuMuon.Rows[id].Cells[7].Value.ToString());
        }

        private void phieumuontotxt()
        {
            txtNhanVien_tra.Text = phieumuon_tra.Nhan_vien;
            txtDocGia_tra.Text = phieumuon_tra.Doc_gia;
            dateTimeNgayMuon_tra.Value = phieumuon_tra.Ngay_muon;
            dateTimeNgayTra_tra.Value = phieumuon_tra.Ngay_tra;
            txtTongTien_tra.Text = phieumuon_tra.Tong_tien;
        }

        private void resetTextTra()
        {
            txtNhanVien_tra.Text = txtDocGia_tra.Text = phieumuon_tra.Doc_gia = txtTongTien_tra.Text = "";
            dateTimeNgayMuon_tra.ResetText();
            dateTimeNgayTra_tra.ResetText();
        }

        private void btnXatNhanTra_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xát nhận trả !", "Thông báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if (xulyphieumuon.xatnhantra(phieumuon_tra.Ma))
                {
                    MessageBox.Show("Trả thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tra_load();
                    muon_load();
                }
                else
                {
                    MessageBox.Show("Trả không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_tra_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xát nhận xóa !", "Thông báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if (xulyphieumuon.xoaphieu(phieumuon_tra.Ma))
                {
                    MessageBox.Show("xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tra_load();
                    muon_load();
                }
                else
                {
                    MessageBox.Show("xóa không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xát nhận khôi phục !", "Thông báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if (xulyphieumuon.khoiphuc(phieumuon_tra.Ma))
                {
                    MessageBox.Show("Khôi phục thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tra_load();
                    muon_load();
                }
                else
                {
                    MessageBox.Show("Khôi phục không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvThongTinPhieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string mas = dgvThongTinPhieu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTongTien_tra.Text = (int.Parse(txtTongTien_tra.Text) - int.Parse(dgvThongTinPhieu.Rows[e.RowIndex].Cells[4].Value.ToString())).ToString();
                phieumuon_tra.xoasach(mas);
                dgvThongTinPhieu.Rows.RemoveAt(e.RowIndex);
            }
            if (dgvThongTinPhieu.Rows.Count == 0)
                btnXatNhanTra.Enabled = false;
        }

        //*************************************************************************************************************************
        private void FormMuonTraSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnTimSach_muon_Click_1(object sender, EventArgs e)
        {
            BAL_sach xulysach = new BAL_sach();
            if (IsNumber(txtTimSach_muon.Text) == true)
            {
                DataTable Table = null;
                Table = xulysach.searcher_msach(txtTimSach_muon.Text);
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvSach_muon.DataSource = Table;

                    dgvSach_muon.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTimSach_muon.Text))
                {
                    dgvSach_muon.DataSource = xulysach.getAll();
                    //xóa dòng cuối
                    dgvSach_muon.AllowUserToAddRows = false;
                }
                else
                {
                    MessageBox.Show("Mã này " + txtTimSach_muon.Text + " chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                DataTable Table = xulysach.searcher_sach(txtTimSach_muon.Text);
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvSach_muon.DataSource = Table;
                    dgvSach_muon.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTimSach_muon.Text))
                {
                    dgvSach_muon.DataSource = xulysach.getAll();
                    //xóa dòng cuối
                    dgvSach_muon.AllowUserToAddRows = false;
                }
                else
                {
                    MessageBox.Show("Sách này " + txtTimSach_muon.Text + " chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void tabTra_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtTimTra.Text == "mã phiếu mượn")
                txtTimTra.Text = "";
        }

        private void tabTra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btntim_1.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (IsNumber(txtTimTra.Text) == true)
            {
                DataTable Table = null;
                Table = xulyphieumuon.searcher_phiemuon(txtTimTra.Text);
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvPhieuMuon.DataSource = Table;

                    dgvPhieuMuon.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTimTra.Text))
                {
                    dgvPhieuMuon.DataSource = xulyphieumuon.GetAll();
                    //xóa dòng cuối
                    dgvPhieuMuon.AllowUserToAddRows = false;
                }
                else
                {
                    MessageBox.Show("Mã này " + txtTimTra.Text + " chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtTimTra.Text))
                {
                    dgvPhieuMuon.DataSource = xulyphieumuon.GetAll();
                    //xóa dòng cuối
                    dgvPhieuMuon.AllowUserToAddRows = false;
                }
                else
                {
                    MessageBox.Show("Sách này " + txtTimTra.Text + " chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
