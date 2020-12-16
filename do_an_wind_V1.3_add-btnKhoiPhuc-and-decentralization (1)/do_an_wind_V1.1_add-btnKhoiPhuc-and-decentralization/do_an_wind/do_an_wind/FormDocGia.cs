using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Thêm thư viện regex
using System.Text.RegularExpressions;
using BAL;
using BEL;

namespace do_an_wind
{
    public partial class FormDocGia : Form
    {

        public int chucNang;
        private BEL_DocGia docGia = new BEL_DocGia();

        public FormDocGia()
        {
            InitializeComponent();
        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            txtTim.MaxLength = 20;
            txtTenDocGia.MaxLength = 20;
            txtSDT.MaxLength = 10;
            txtCMND.MaxLength = 12;
            txtDiaChi.MaxLength = 20;
            dgvDocGia.AllowUserToAddRows = false;
            dgvDocGia.RowHeadersVisible = false;
            btnXatNhan.Visible = btnLamMoi.Visible = btnQuayLai.Visible = false;
            BAL_docGia xulydocgia = new BAL_docGia();
            DataTable data;
            if (FormDangNhap.Nhanvien.Quan_ly)
            {
                data = xulydocgia.getAll();
                dgvDocGia.DataSource = data;
                rowtodocGia(0);
                btnKhoiPhuc.Visible = docGia.Da_xoa;
            }
            else
            {
                data = xulydocgia.getAllExist();
                dgvDocGia.DataSource = data;
                rowtodocGia(0);
                //ẩn đòng trạng thái đã xóa đi
                dgvDocGia.Columns[7].Visible = false;
            }
            foreach (DataRow row in data.Rows)
            {
                acsc.Add(row["ma_doc_gia"].ToString());
                acsc.Add(row["ten_doc_gia"].ToString());
            }
            txtTim.AutoCompleteCustomSource = acsc;
        }

        private void dgvDocGia_MouseClick(object sender, MouseEventArgs e)
        {
            btnKhoiPhuc.Visible = false;
            if (dgvDocGia.SelectedRows.Count < 2)
                btnThem.Enabled = true;
            if (dgvDocGia.SelectedRows.Count == 1)
            {
                btnSua.Enabled = true;
                //lấy id row đc chọn
                int id = dgvDocGia.SelectedRows[0].Index;
                //in data vào test box và thêm vào biến
                rowtodocGia(id);
                btnKhoiPhuc.Visible = docGia.Da_xoa;
            }
            else
            {
                resetText();
                btnThem.Enabled = btnSua.Enabled = false;
            }
        }

        private void rowtodocGia(int id)
        {
            //Mã độc giẳ
            docGia.Ma_doc_gia = txtMaDocGia.Text = dgvDocGia.Rows[id].Cells[0].Value.ToString();
            //Tên độc giả
            docGia.Ten_doc_gia = txtTenDocGia.Text = dgvDocGia.Rows[id].Cells[1].Value.ToString();

            if (Convert.ToBoolean(dgvDocGia.Rows[id].Cells[2].Value.ToString()) == true)
            {
                rdbNam.Checked = true;
                docGia.Gio_tinh = true;
            }
            else
            {
                rdbNu.Checked = true;
                docGia.Gio_tinh = false;
            }

            docGia.Ngay_sinh = Convert.ToDateTime(dgvDocGia.Rows[id].Cells[3].Value);

            dateTimeNgaySinh.Value = new DateTime(docGia.Ngay_sinh.Year, docGia.Ngay_sinh.Month, docGia.Ngay_sinh.Day);

            docGia.Dia_chi = txtDiaChi.Text = dgvDocGia.Rows[id].Cells[4].Value.ToString();

            docGia.Cmnd = txtCMND.Text = dgvDocGia.Rows[id].Cells[5].Value.ToString();

            docGia.Sdt = txtSDT.Text = dgvDocGia.Rows[id].Cells[6].Value.ToString();

            if (Convert.ToBoolean(dgvDocGia.Rows[id].Cells[7].Value.ToString()) == true)
                docGia.Da_xoa = true;
            else
                docGia.Da_xoa = false;
        }

        private void swap_btn()
        {
            gbxThongTin.Enabled = !gbxThongTin.Enabled;
            txtTenDocGia.Focus();
            btnThem.Visible = btnXoa.Visible = btnSua.Visible = !btnSua.Visible;
            btnXatNhan.Visible = btnLamMoi.Visible = btnQuayLai.Visible = !btnQuayLai.Visible;
            dgvDocGia.Enabled = !dgvDocGia.Enabled;
        }

        private void docGiatoText()
        {
            txtCMND.Text = docGia.Cmnd;
            txtDiaChi.Text = docGia.Dia_chi;
            txtMaDocGia.Text = docGia.Ma_doc_gia;
            txtTenDocGia.Text = docGia.Ten_doc_gia;
            txtSDT.Text = docGia.Sdt;
            if (docGia.Gio_tinh == true)
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;
        }

        private void resetText()
        {
            txtMaDocGia.Text = txtCMND.Text = txtDiaChi.Text = txtSDT.Text = txtTenDocGia.Text = txtTim.Text = "";
            dateTimeNgaySinh.ResetText();
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
            bool gioitinh = false;
            if (rdbNam.Checked == true)
                gioitinh = true;
            else if (rdbNu.Checked == true)
                gioitinh = true;
            BEL.BEL_DocGia docgia = new BEL.BEL_DocGia(txtMaDocGia.Text, txtTenDocGia.Text, gioitinh, dateTimeNgaySinh.Value, txtDiaChi.Text, txtSDT.Text, txtCMND.Text, false);
            BAL.BAL_docGia xulydocgia = new BAL.BAL_docGia();

            string[] arr = new string[dgvDocGia.SelectedRows.Count];
            int id = 0;
            bool ketqua = false;
            try
            {

                foreach (DataGridViewRow rows in dgvDocGia.SelectedRows)
                {
                    arr[id++] = dgvDocGia.Rows[rows.Index].Cells[0].Value.ToString();
                }

                DialogResult res = MessageBox.Show("Xát nhận xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    
                    if (!FormDangNhap.Nhanvien.Quan_ly)

                        for (int i = 0; i < dgvDocGia.Rows.Count; i++)
                        {
                            dgvDocGia.Rows.RemoveAt(i);
                            ketqua = xulydocgia.capnhat_tragthai(docgia);
                        }
                    //foreach (DataGridViewRow item in dgvDocGia.SelectedRows)
                    //{
                    //    dgvDocGia.Rows.RemoveAt(item.Index);
                    //    ketqua = xulydocgia.capnhat_tragthai(itemdocgia);
                    //}
                    ketqua = xulydocgia.capnhat_tragthai(docgia);
                    if (ketqua == false)
                    {
                        MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (FormDangNhap.Nhanvien.Quan_ly)
            {
                dgvDocGia.DataSource = xulydocgia.getAll();
                rowtodocGia(0);
                btnKhoiPhuc.Visible = this.docGia.Da_xoa;
            }
            else
            {
                dgvDocGia.DataSource = xulydocgia.getAllExist();
                rowtodocGia(0);
                dgvDocGia.Columns[2].Visible = false;
            }
        }

        private void XatNhan_Click(object sender, EventArgs e)
        {
            //1 = them , 2 = sua
            if (this.chucNang == 1)
            {
                if (txtCMND.TextLength == 12 || txtCMND.TextLength == 9)
                {
                    if (txtSDT.TextLength == 10)
                    {
                        if (!string.IsNullOrEmpty(txtCMND.Text) && !string.IsNullOrEmpty(txtDiaChi.Text) && !string.IsNullOrEmpty(txtSDT.Text) && !string.IsNullOrEmpty(txtTenDocGia.Text))
                        {// DataTable data = BAL.BAL_docGia.getAll();
                            //  dgvDocGia.DataSource = data;
                            bool gioitinh = false;
                            if (rdbNam.Checked == true)
                                gioitinh = true;
                            else if (rdbNu.Checked == true)
                                gioitinh = true;
                            BEL.BEL_DocGia docgia = new BEL.BEL_DocGia(txtMaDocGia.Text, txtTenDocGia.Text, gioitinh, dateTimeNgaySinh.Value, txtDiaChi.Text, txtSDT.Text, txtCMND.Text, false);
                            BAL.BAL_docGia xulydocgia = new BAL.BAL_docGia();
                            bool ketqua = xulydocgia.Themdocgia(docgia);
                            if (ketqua == true)
                            {
                                MessageBox.Show("Đã thêm độc giả " + txtTenDocGia.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (FormDangNhap.Nhanvien.Quan_ly)
                                {
                                    dgvDocGia.DataSource = xulydocgia.getAll();
                                    rowtodocGia(0);
                                    btnKhoiPhuc.Visible = this.docGia.Da_xoa;
                                }
                                else
                                {
                                    dgvDocGia.DataSource = xulydocgia.getAllExist();
                                    rowtodocGia(0);
                                    dgvDocGia.Columns[2].Visible = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Đã thêm độc giả thất bại " + txtTenDocGia.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu còn để rỗng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ " + txtSDT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {

                    MessageBox.Show("Mã CMND không hợp lệ " + txtCMND.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            if (this.chucNang == 2)
            {
                if (txtCMND.TextLength == 12 || txtCMND.TextLength == 9)
                {
                    if (txtSDT.TextLength == 10)
                    {
                        if (!string.IsNullOrEmpty(txtCMND.Text) && !string.IsNullOrEmpty(txtDiaChi.Text) && !string.IsNullOrEmpty(txtSDT.Text) && !string.IsNullOrEmpty(txtTenDocGia.Text))
                        {
                            bool gioitinh = false;
                            if (rdbNam.Checked == true)
                                gioitinh = true;
                            else if (rdbNu.Checked == true)
                                gioitinh = true;
                            BEL.BEL_DocGia docgia = new BEL.BEL_DocGia(txtMaDocGia.Text, txtTenDocGia.Text, gioitinh, dateTimeNgaySinh.Value, txtDiaChi.Text, txtSDT.Text, txtCMND.Text, false);
                            BAL.BAL_docGia xulydocgia = new BAL.BAL_docGia();
                            bool ketqua = xulydocgia.Suadocgia(docgia);
                            if (ketqua == true)
                            {
                                MessageBox.Show("Đã update độc giả " + txtTenDocGia.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (FormDangNhap.Nhanvien.Quan_ly)
                                {
                                    dgvDocGia.DataSource = xulydocgia.getAll();
                                    rowtodocGia(0);
                                    btnKhoiPhuc.Visible = this.docGia.Da_xoa;
                                }
                                else
                                {
                                    dgvDocGia.DataSource = xulydocgia.getAllExist();
                                    rowtodocGia(0);
                                    dgvDocGia.Columns[2].Visible = false;
                                }
                                //xóa dòng cuối
                                dgvDocGia.AllowUserToAddRows = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu đang bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã SDT không hợp lệ " + txtSDT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        docGiatoText();
                    }

                }
                else
                {
                    MessageBox.Show("Mã CMND không hợp lệ " + txtCMND.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    docGiatoText();
                }

            }
            swap_btn();
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
                docGiatoText();
            }
            swap_btn();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            docGiatoText();
            swap_btn();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            bool gioitinh = false;
            if (rdbNam.Checked == true)
                gioitinh = true;
            else if (rdbNu.Checked == true)
                gioitinh = true;
            BEL.BEL_DocGia docgia = new BEL.BEL_DocGia(txtMaDocGia.Text, txtTenDocGia.Text, gioitinh, dateTimeNgaySinh.Value, txtDiaChi.Text, txtSDT.Text, txtCMND.Text, false);
            BAL.BAL_docGia xulydocgia = new BAL.BAL_docGia();

            string[] arr = new string[dgvDocGia.SelectedRows.Count];
            int id = 0;
            try
            {
                foreach (DataGridViewRow rows in dgvDocGia.SelectedRows)
                {
                    arr[id++] = dgvDocGia.Rows[rows.Index].Cells[0].Value.ToString();
                }

                DialogResult res = MessageBox.Show("Xác nhận khôi phục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    if (!FormDangNhap.Nhanvien.Quan_ly)
                        foreach (DataGridViewRow item in dgvDocGia.SelectedRows)
                        {
                            dgvDocGia.Rows.RemoveAt(item.Index);
                        }
                    bool ketqua = xulydocgia.capnhat_tragthai_moi(docgia);
                    if (ketqua == false)
                    {
                        MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (FormDangNhap.Nhanvien.Quan_ly)
            {
                dgvDocGia.DataSource = xulydocgia.getAll();
                rowtodocGia(0);
                btnKhoiPhuc.Visible = this.docGia.Da_xoa;
            }
            else
            {
                dgvDocGia.DataSource = xulydocgia.getAllExist();
                rowtodocGia(0);
                dgvDocGia.Columns[2].Visible = false;
            }
        }

        public bool IsNumber(string str)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(str);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            BAL_docGia xulydocgia = new BAL_docGia();
            if (IsNumber(txtTim.Text) == true)
            {
                DataTable Table = null;
                if (FormDangNhap.Nhanvien.Quan_ly)
                {
                    Table = xulydocgia.searcher_mdocgia_quanly(txtTim.Text);
                }
                else
                {
                    Table = xulydocgia.searcher_mdocgia(txtTim.Text);
                }
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvDocGia.DataSource = Table;

                    dgvDocGia.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTim.Text))
                {
                    if (FormDangNhap.Nhanvien.Quan_ly)
                    {
                        dgvDocGia.DataSource = xulydocgia.getAll();
                    }
                    else
                    {
                        dgvDocGia.DataSource = xulydocgia.getAllExist();
                    }
                    //xóa dòng cuối
                    dgvDocGia.AllowUserToAddRows = false;
                }
                else
                {
                    MessageBox.Show("Mã này " + txtTim.Text + " chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                DataTable Table = xulydocgia.searcher_docgia(txtTim.Text);
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvDocGia.DataSource = Table;
                    dgvDocGia.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTim.Text))
                {
                    if (FormDangNhap.Nhanvien.Quan_ly)
                    {
                        dgvDocGia.DataSource = xulydocgia.getAll();
                    }
                    else
                    {
                        dgvDocGia.DataSource = xulydocgia.getAllExist();
                    }
                    //xóa dòng cuối
                    dgvDocGia.AllowUserToAddRows = false;
                }
                else
                {
                    MessageBox.Show("Tác giả này " + txtTim.Text + " chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }


        private void txtMaDocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txtTenDocGia.Text.Length < 4)
            //{
            //    e.Handled = true;
            //}
        }

        private void txtTenDocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTim.PerformClick();
        }

        private void txtTim_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtTim.Text == "Tên đọc giả, mã đọc giả")
                txtTim.Text = "";
        }

        private void FormDocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
                e.Cancel = true;
        }

    }
}
