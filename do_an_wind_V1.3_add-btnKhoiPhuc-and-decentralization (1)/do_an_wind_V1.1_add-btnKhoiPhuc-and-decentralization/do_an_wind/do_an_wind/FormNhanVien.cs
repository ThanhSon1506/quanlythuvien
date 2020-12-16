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
using System.Security.Cryptography;
using BAL;
using BEL;
namespace do_an_wind
{

    public partial class FormNhanVien : Form
    {
        public int chucNang;
        private BEL_nhanvien nhanvien = new BEL_nhanvien();
        public MD5 md5 = MD5.Create();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            txtTim.MaxLength = 20;
            txtTenNhanVien.MaxLength = 20;
            txtSDT.MaxLength = 10;
            txtDiaChi.MaxLength = 20;
            //xóa dòng cuối cội đầu
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.RowHeadersVisible = false;
            btnXatNhan.Visible = btnLamMoi.Visible = btnQuayLai.Visible = false;
            BAL_nhanvien xulyNhanVien = new BAL_nhanvien();
            DataTable data = null;
            
            if (FormDangNhap.Nhanvien.Quan_ly)
            {
                data = xulyNhanVien.getAll();
                dgvNhanVien.DataSource = data;
                rowtonhanvien(0);
                btnKhoiPhuc.Visible = nhanvien.Da_xoa;
                if (bool.Parse(dgvNhanVien.Rows[0].Cells[5].Value.ToString()))
                {
                    btnXoa.Enabled = false;
                }
            }
            else
            {
                data = xulyNhanVien.getAllExist();
                dgvNhanVien.DataSource = data;
                rowtonhanvien(0);
                //ẩn đòng trạng thái đã xóa đi
                dgvNhanVien.Columns[7].Visible = false;
                if (bool.Parse(dgvNhanVien.Rows[0].Cells[5].Value.ToString()) || (dgvNhanVien.Rows[0].Cells[0].Value.ToString() == FormDangNhap.Nhanvien.Ma_nhan_vien))
                {
                    btnXoa.Enabled = false;
                }
                btnXoa.Enabled = true;
            }
            foreach (DataRow row in data.Rows)
            {
                acsc.Add(row["ma_nhan_vien"].ToString());
                acsc.Add(row["ten_nhan_vien"].ToString());
            }
            txtTim.AutoCompleteCustomSource = acsc;
        }

        private void dgvNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            //lấy id row đc chọn
            int id = dgvNhanVien.SelectedRows[0].Index;
            if (bool.Parse(dgvNhanVien.Rows[id].Cells[5].Value.ToString()) || (dgvNhanVien.Rows[id].Cells[0].Value.ToString() == FormDangNhap.Nhanvien.Ma_nhan_vien))
            {
                btnXoa.Enabled = false;
                if (dgvNhanVien.SelectedRows.Count < 2)
                    btnThem.Enabled = true;
                if (dgvNhanVien.SelectedRows.Count == 1)
                {
                    btnSua.Enabled = true;
                    //in data vào test box và thêm vào biến
                    rowtonhanvien(id);
                    btnKhoiPhuc.Visible = nhanvien.Da_xoa;
                }
                else
                {
                    resetText();
                    btnThem.Enabled = btnSua.Enabled = false;
                }
            }
            else
            {
                btnXoa.Enabled = true;
                if (dgvNhanVien.SelectedRows.Count < 2)
                    btnThem.Enabled = true;
                if (dgvNhanVien.SelectedRows.Count == 1)
                {
                    btnSua.Enabled = true;
                    //in data vào test box và thêm vào biến
                    rowtonhanvien(id);
                    btnKhoiPhuc.Visible = nhanvien.Da_xoa;
                }
                else
                {
                    resetText();
                    btnThem.Enabled = btnSua.Enabled = false;
                }

            }
        }

        private void rowtonhanvien(int id)
        {
            nhanvien.Ma_nhan_vien = txtMaNhanVien.Text = dgvNhanVien.Rows[id].Cells[0].Value.ToString();
            nhanvien.Ten_nhan_vien = txtTenNhanVien.Text = dgvNhanVien.Rows[id].Cells[1].Value.ToString();

            if (Convert.ToBoolean(dgvNhanVien.Rows[id].Cells[2].Value.ToString()) == true)
            {
                rdbNam.Checked = true;
                nhanvien.Gioi_tinh = true;
            }
            else
            {
                rdbNu.Checked = true;
                nhanvien.Gioi_tinh = false;
            }

            nhanvien.Ngay_sinh = Convert.ToDateTime(dgvNhanVien.Rows[id].Cells[3].Value);

            dateTimeNgaySinh.Value = new DateTime(nhanvien.Ngay_sinh.Year, nhanvien.Ngay_sinh.Month, nhanvien.Ngay_sinh.Day);

            nhanvien.Dia_chi = txtDiaChi.Text = dgvNhanVien.Rows[id].Cells[4].Value.ToString();

            if (Convert.ToBoolean(dgvNhanVien.Rows[id].Cells[5].Value.ToString()) == true)
                nhanvien.Quan_ly = true;
            else
                nhanvien.Quan_ly = false;

            nhanvien.Sdt = txtSDT.Text = dgvNhanVien.Rows[id].Cells[6].Value.ToString();

            if (Convert.ToBoolean(dgvNhanVien.Rows[id].Cells[7].Value.ToString()) == true)
                nhanvien.Da_xoa = true;
            else
                nhanvien.Da_xoa = false;
        }

        private void resetText()
        {
            txtMaNhanVien.Text = txtTenNhanVien.Text = txtSDT.Text = txtDiaChi.Text = txtTim.Text = "";
            dateTimeNgaySinh.ResetText();
        }

        private void swap_btn()
        {
            gbxThongTin.Enabled = !gbxThongTin.Enabled;
            txtTenNhanVien.Focus();
            btnThem.Visible = btnXoa.Visible = btnSua.Visible = !btnSua.Visible;
            btnXatNhan.Visible = btnLamMoi.Visible = btnQuayLai.Visible = !btnQuayLai.Visible;
            dgvNhanVien.Enabled = !dgvNhanVien.Enabled;
        }

        private void NhanVientoText()
        {
            txtMaNhanVien.Text = nhanvien.Ma_nhan_vien;
            txtTenNhanVien.Text = nhanvien.Ten_nhan_vien;
            txtDiaChi.Text = nhanvien.Dia_chi;
            txtSDT.Text = nhanvien.Sdt;
            if (nhanvien.Gioi_tinh == true)
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;
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
            BEL.BEL_nhanvien nhanvien = new BEL.BEL_nhanvien(txtMaNhanVien.Text, txtTenNhanVien.Text, gioitinh, dateTimeNgaySinh.Value, txtDiaChi.Text, false, txtSDT.Text, false);
            BAL.BAL_nhanvien xulynhanvien = new BAL.BAL_nhanvien();

            string[] arr = new string[dgvNhanVien.SelectedRows.Count];
            int id = 0;
            try
            {
                foreach (DataGridViewRow rows in dgvNhanVien.SelectedRows)
                {
                    arr[id++] = dgvNhanVien.Rows[rows.Index].Cells[0].Value.ToString();
                }

                DialogResult res = MessageBox.Show("Xác nhận xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    //code
                    BAL.BAL_nhanvien deleteTKNV = new BAL.BAL_nhanvien();
                    deleteTKNV.delete_tknv(nhanvien);
                    bool ketqua = xulynhanvien.capnhat_tragthai(nhanvien);
                    if (ketqua == false)
                    {
                        MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvNhanVien.DataSource = xulynhanvien.getAll();
                        //xóa dòng cuối
                        dgvNhanVien.AllowUserToAddRows = false;
                    }
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (FormDangNhap.Nhanvien.Quan_ly)
            {

                dgvNhanVien.DataSource = xulynhanvien.getAll();
                rowtonhanvien(0);
                btnKhoiPhuc.Visible = nhanvien.Da_xoa;
            }
            else
            {

                dgvNhanVien.DataSource = xulynhanvien.getAllExist();
                rowtonhanvien(0);
                //ẩn đòng trạng thái đã xóa đi
                dgvNhanVien.Columns[7].Visible = false;
            }
            rowtonhanvien(0);
            btnKhoiPhuc.Visible = this.nhanvien.Da_xoa;

        }

        private void btnXatNhan_Click(object sender, EventArgs e)
        {
            //1 = them , 2 = sua
            if (this.chucNang == 1)
            {

                if (txtSDT.TextLength == 10)
                {
                    if (!string.IsNullOrEmpty(txtDiaChi.Text) && !string.IsNullOrEmpty(txtSDT.Text) && !string.IsNullOrEmpty(txtTenNhanVien.Text))
                    {
                        // DataTable data = BAL.BAL_nhanvien.getAll();
                        //  dgvNhanVien.DataSource = data;
                        bool gioitinh = false;
                        if (rdbNam.Checked == true)
                            gioitinh = true;
                        else if (rdbNu.Checked == true)
                            gioitinh = true;
                        BEL.BEL_nhanvien NhanVien = new BEL.BEL_nhanvien(txtMaNhanVien.Text, txtTenNhanVien.Text, gioitinh, dateTimeNgaySinh.Value, txtDiaChi.Text, false, txtSDT.Text, false);
                        BAL.BAL_nhanvien xulyNhanVien = new BAL.BAL_nhanvien();
                        bool ketqua = xulyNhanVien.Themnhanvien(NhanVien);
                        if (ketqua == true)
                        {
                            MessageBox.Show("Đã thêm nhân viên " + txtTenNhanVien.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (FormDangNhap.Nhanvien.Quan_ly)
                            {

                                dgvNhanVien.DataSource = xulyNhanVien.getAll();
                                rowtonhanvien(0);
                                btnKhoiPhuc.Visible = nhanvien.Da_xoa;
                            }
                            else
                            {

                                dgvNhanVien.DataSource = xulyNhanVien.getAllExist();
                                rowtonhanvien(0);
                                //ẩn đòng trạng thái đã xóa đi
                                dgvNhanVien.Columns[7].Visible = false;
                            }
                            BAL.BAL_nhanvien xuly_addTKNV = new BAL.BAL_nhanvien();
                            NhanVien.Ma_nhan_vien = xuly_addTKNV.Max_nhanvien();
                            string mahoa_manv =xuly_addTKNV.Mahoakitu(NhanVien.Ma_nhan_vien);
                            NhanVien.Sdt = xuly_addTKNV.Mahoakitu(NhanVien.Sdt);
                            xuly_addTKNV.add_tknv(NhanVien, mahoa_manv);
                        }
                        else
                        {
                            MessageBox.Show("Đã thêm nhân viên thất bại " + txtTenNhanVien.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu đang bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ " + txtSDT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (this.chucNang == 2)
            {
                if (txtSDT.TextLength == 10)
                {
                    if (!string.IsNullOrEmpty(txtDiaChi.Text) && !string.IsNullOrEmpty(txtSDT.Text) && !string.IsNullOrEmpty(txtTenNhanVien.Text))
                    {
                        bool gioitinh = false;
                        if (rdbNam.Checked == true)
                            gioitinh = true;
                        else if (rdbNu.Checked == true)
                            gioitinh = true;
                        BEL.BEL_nhanvien NhanVien = new BEL.BEL_nhanvien(txtMaNhanVien.Text, txtTenNhanVien.Text, gioitinh, dateTimeNgaySinh.Value, txtDiaChi.Text, false, txtSDT.Text, false);
                        BAL.BAL_nhanvien xulyNhanVien = new BAL.BAL_nhanvien();
                        bool ketqua = xulyNhanVien.Suanhanvien(NhanVien);
                        if (ketqua == true)
                        {
                            MessageBox.Show("Đã update nhân viên " + txtTenNhanVien.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (FormDangNhap.Nhanvien.Quan_ly)
                            {

                                dgvNhanVien.DataSource = xulyNhanVien.getAll();
                                rowtonhanvien(0);
                                btnKhoiPhuc.Visible = nhanvien.Da_xoa;
                            }
                            else
                            {

                                dgvNhanVien.DataSource = xulyNhanVien.getAllExist();
                                rowtonhanvien(0);
                                //ẩn đòng trạng thái đã xóa đi
                                dgvNhanVien.Columns[7].Visible = false;
                            }
                            //xóa dòng cuối
                            dgvNhanVien.AllowUserToAddRows = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã SDT không hợp lệ " + txtSDT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Dữ liệu đang bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                NhanVientoText();
            }
            swap_btn();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            NhanVientoText();
            swap_btn();
        }

        private void txtMaNhanVien_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            bool gioitinh = false;
            if (rdbNam.Checked == true)
                gioitinh = true;
            else if (rdbNu.Checked == true)
                gioitinh = true;
            BEL.BEL_nhanvien nhanvien = new BEL.BEL_nhanvien(txtMaNhanVien.Text, txtTenNhanVien.Text, gioitinh, dateTimeNgaySinh.Value, txtDiaChi.Text, false, txtSDT.Text, false);
            BAL.BAL_nhanvien xulynhanvien = new BAL.BAL_nhanvien();

            string[] arr = new string[dgvNhanVien.SelectedRows.Count];
            int id = 0;
            try
            {
                foreach (DataGridViewRow rows in dgvNhanVien.SelectedRows)
                {
                    arr[id++] = dgvNhanVien.Rows[rows.Index].Cells[0].Value.ToString();
                }

                DialogResult res = MessageBox.Show("Xác nhận khôi phục ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    bool ketqua = xulynhanvien.capnhat_tragthai_moi(nhanvien);
                    if (ketqua == false)
                    {
                        MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    foreach (DataGridViewRow item in dgvNhanVien.SelectedRows)
                    {
                        dgvNhanVien.Rows.RemoveAt(item.Index);
                    }
                    xulynhanvien.restore_tknv(nhanvien);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            dgvNhanVien.DataSource = xulynhanvien.getAll();
            rowtonhanvien(0);
            btnKhoiPhuc.Visible = this.nhanvien.Da_xoa;

        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTim.PerformClick();
        }

        private void txtMaNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            BAL_nhanvien xulynhanvien = new BAL_nhanvien();
           
            
            if (IsNumber(txtTim.Text) == true)
            {
                DataTable Table = null;
                if (FormDangNhap.Nhanvien.Quan_ly)
                {
                    Table = xulynhanvien.searcher_mnhanvien_quanly(txtTim.Text);
                }
                else
                {
                    Table = xulynhanvien.searcher_mnhanvien(txtTim.Text);  
                }          
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvNhanVien.DataSource = Table;

                    dgvNhanVien.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTim.Text))
                {
                    if (FormDangNhap.Nhanvien.Quan_ly)
                    {
                        dgvNhanVien.DataSource = xulynhanvien.getAll();
                    }
                    else
                    {
                        dgvNhanVien.DataSource = xulynhanvien.getAllExist();
                    }   
                    //xóa dòng cuối
                    dgvNhanVien.AllowUserToAddRows = false;
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
                    Table = xulynhanvien.searcher_nhanvien_quanly(txtTim.Text);
                }
                else
                {
                    Table = xulynhanvien.searcher_nhanvien(txtTim.Text);
                }
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvNhanVien.DataSource = Table;

                    dgvNhanVien.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTim.Text))
                {
                    if (FormDangNhap.Nhanvien.Quan_ly)
                    {
                        dgvNhanVien.DataSource = xulynhanvien.getAll();
                    }
                    else
                    {
                        dgvNhanVien.DataSource = xulynhanvien.getAllExist();
                    }
                    //xóa dòng cuối
                    dgvNhanVien.AllowUserToAddRows = false;
                }
                else
                {
                    MessageBox.Show("Nhân viên này " + txtTim.Text + " chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void txtTim_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtTim.Text == "Tên nhân viên, mã nhân viên")
                txtTim.Text = "";
        }

        private void FormNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
