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
using BEL;
using BAL;
namespace do_an_wind
{
    public partial class FormTacGia : Form
    {
        public int chucNang;
        private BEL_tacgia tacgia = new BEL_tacgia();
        public FormTacGia()
        {
            InitializeComponent();
        }

        private void FormTacGia_Load(object sender, EventArgs e)
        {
            txtMaTacGia.Enabled = false;
            dgvTacGia.AllowUserToAddRows = false;
            dgvTacGia.RowHeadersVisible = false;
            btnXatNhan.Visible = btnLamMoi.Visible = btnQuayLai.Visible = false;
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            BAL_tacgia xulytacgia = new BAL_tacgia();
            DataTable data;
            if (FormDangNhap.Nhanvien.Quan_ly)
            {
                data = xulytacgia.getAll();
                dgvTacGia.DataSource = data;
                rowtotacgia(0);
                btnKhoiPhuc.Visible = tacgia.Daxoa;
            }
            else
            {
                data = xulytacgia.getAllExist();
                dgvTacGia.DataSource = data;
                rowtotacgia(0);
                //ẩn đòng trạng thái đã xóa đi
                dgvTacGia.Columns[3].Visible = false;
            }
            foreach (DataRow row in data.Rows)
            {
                acsc.Add(row["ma_tac_gia"].ToString());
                acsc.Add(row["ten_tac_gia"].ToString());
            }
            txtTim.AutoCompleteCustomSource = acsc;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            BAL_tacgia xulytacgia = new BAL_tacgia();
            if (IsNumber(txtTim.Text) == true)
            {
                DataTable Table = null;
                if (FormDangNhap.Nhanvien.Quan_ly)
                {
                    Table = xulytacgia.searcher_mtacgia_quanly(txtTim.Text);         
                }
                else
                {
                    Table = xulytacgia.searcher_mtacgia(txtTim.Text); 
                }
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvTacGia.DataSource = Table;

                    dgvTacGia.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTim.Text))
                {
                    if (FormDangNhap.Nhanvien.Quan_ly)
                    {
                        dgvTacGia.DataSource = xulytacgia.getAll();
                        //xóa dòng cuối
                        dgvTacGia.AllowUserToAddRows = false;
                    }
                    else
                    {
                        dgvTacGia.DataSource = xulytacgia.getAllExist();
                        //xóa dòng cuối
                        dgvTacGia.AllowUserToAddRows = false;
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
                    Table = xulytacgia.searcher_tacgia_quanly(txtTim.Text);
                }
                else
                {
                    Table = xulytacgia.searcher_tacgia(txtTim.Text);
                }
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvTacGia.DataSource = Table;

                    dgvTacGia.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTim.Text))
                {
                    if (FormDangNhap.Nhanvien.Quan_ly)
                    {
                        dgvTacGia.DataSource = xulytacgia.getAll();
                        //xóa dòng cuối
                        dgvTacGia.AllowUserToAddRows = false;
                    }
                    else
                    {
                        dgvTacGia.DataSource = xulytacgia.getAllExist();
                        //xóa dòng cuối
                        dgvTacGia.AllowUserToAddRows = false;
                    }

                }
                else
                {
                    MessageBox.Show("Tác giả này  " + txtTim.Text + " chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void dgvTacGia_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvTacGia.SelectedRows.Count < 2)
                btnThem.Enabled = true;
            if (dgvTacGia.SelectedRows.Count == 1)
            {
                btnSua.Enabled = true;
                //lấy id row đc chọn
                int id = dgvTacGia.SelectedRows[0].Index;
                //in data vào test box và thêm vào biến
                rowtotacgia(id);
                btnKhoiPhuc.Visible = tacgia.Daxoa;
            }
            else
            {
                resetText();
                btnThem.Enabled = btnSua.Enabled = false;
            }
        }

        private void rowtotacgia(int id)
        {
            //Mã độc giẳ
            tacgia.Matacgia = txtMaTacGia.Text = dgvTacGia.Rows[id].Cells[0].Value.ToString();
            //Tên độc giả
            tacgia.Tentacgia = txtTenTacGia.Text = dgvTacGia.Rows[id].Cells[1].Value.ToString();

           tacgia.Tieusu = rtbTieuSu.Text = dgvTacGia.Rows[id].Cells[2].Value.ToString();
           if (Convert.ToBoolean(dgvTacGia.Rows[id].Cells[3].Value.ToString()) == true)
               tacgia.Daxoa = true;
            else
                tacgia.Daxoa = false;
        }
        private void swap_btn()
        {
            gbxThongTin.Enabled = !gbxThongTin.Enabled;
            txtTenTacGia.Focus();
            btnThem.Visible = btnXoa.Visible = btnSua.Visible = !btnSua.Visible;
            btnXatNhan.Visible = btnLamMoi.Visible = btnQuayLai.Visible = !btnQuayLai.Visible;
            dgvTacGia.Enabled = !dgvTacGia.Enabled;
        }
        private void tacgiatoText()
        {
            txtMaTacGia.Text = tacgia.Matacgia;
            txtTenTacGia.Text = tacgia.Tentacgia;
            rtbTieuSu.Text = tacgia.Tieusu;
        }
        private void resetText()
        {
            txtMaTacGia.Text = txtTenTacGia.Text = rtbTieuSu.Text = "";
        }
        public bool IsNumber(string str)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(str);
        }
        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTim.PerformClick();
        }

        private void txtTenTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetText();
            chucNang = 1;
            swap_btn();
        }

        private void btnXatNhan_Click(object sender, EventArgs e)
        {
            //1 = them , 2 = sua
            if (this.chucNang == 1)
            {
                if (!string.IsNullOrEmpty(txtTenTacGia.Text))
                {
                    BEL.BEL_tacgia tacgia = new BEL.BEL_tacgia(txtMaTacGia.Text, txtTenTacGia.Text, rtbTieuSu.Text, false);
                    BAL_tacgia xulytacgia = new BAL_tacgia();
                    bool ketqua = xulytacgia.Themtacgia(tacgia);
                    if (ketqua == true)
                    {
                        MessageBox.Show("Đã thêm tác giả " + txtTenTacGia.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTacGia.DataSource = xulytacgia.getAll();
                    }
                    else
                    {
                        MessageBox.Show("Đã thêm độc giả tác giả " + txtTenTacGia.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Dữ liệu đang bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (this.chucNang == 2)
            {
                if (!string.IsNullOrEmpty(txtTenTacGia.Text))
                {
                    BEL.BEL_tacgia tacgia = new BEL.BEL_tacgia(txtMaTacGia.Text, txtTenTacGia.Text, rtbTieuSu.Text, false);
                    BAL_tacgia xulytacgia = new BAL_tacgia();
                    bool ketqua = xulytacgia.Suatacgia(tacgia);
                    if (ketqua == true)
                    {
                        MessageBox.Show("Đã update tác giả " + txtTenTacGia.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTacGia.DataSource = xulytacgia.getAll();
                        //xóa dòng cuối
                        dgvTacGia.AllowUserToAddRows = false;
                    }
                }else{
                    MessageBox.Show("Dữ liệu đang bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            swap_btn();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucNang = 2;
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
                tacgiatoText();
            }
            swap_btn();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BEL.BEL_tacgia tacgia = new BEL.BEL_tacgia(txtMaTacGia.Text, txtTenTacGia.Text, rtbTieuSu.Text, false);
            BAL_tacgia xulytacgia = new BAL_tacgia();

            string[] arr = new string[dgvTacGia.SelectedRows.Count];
            int id = 0;
            try
            {
                foreach (DataGridViewRow rows in dgvTacGia.SelectedRows)
                {
                    arr[id++] = dgvTacGia.Rows[rows.Index].Cells[0].Value.ToString();
                }

                DialogResult res = MessageBox.Show("Xác nhận xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    if (!FormDangNhap.Nhanvien.Quan_ly)
                        foreach (DataGridViewRow item in dgvTacGia.SelectedRows)
                        {
                            dgvTacGia.Rows.RemoveAt(item.Index);
                        }
                    bool ketqua = xulytacgia.capnhat_tragthai(tacgia);
                    if (ketqua == false)
                    {
                        MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTacGia.DataSource = xulytacgia.getAll();
                        //xóa dòng cuối
                        dgvTacGia.AllowUserToAddRows = false;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             
            if (FormDangNhap.Nhanvien.Quan_ly)
            {
                dgvTacGia.DataSource = xulytacgia.getAll();
                rowtotacgia(0);
                btnKhoiPhuc.Visible = tacgia.Daxoa;
            }
            else
            {
                dgvTacGia.DataSource = xulytacgia.getAllExist();
                rowtotacgia(0);
                //ẩn đòng trạng thái đã xóa đi
                dgvTacGia.Columns[3].Visible = false;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            tacgiatoText();
            swap_btn();
        }

        private void txtTim_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtTim.Text == "Tên tác giả, mã tác giả")
                txtTim.Text = "";
        }

        private void dgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTacGia.SelectedRows.Count < 2)
                btnThem.Enabled = true;
            if (dgvTacGia.SelectedRows.Count == 1)
            {
                btnSua.Enabled = true;
                //lấy id row đc chọn
                int id = dgvTacGia.SelectedRows[0].Index;
                //in data vào test box và thêm vào biến
                rowtotacgia(id);
            }
            else
            {
                resetText();
                btnThem.Enabled = btnSua.Enabled = false;
            }
        }

        private void FormTacGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            BEL.BEL_tacgia tacgia = new BEL.BEL_tacgia(txtMaTacGia.Text, txtTenTacGia.Text, rtbTieuSu.Text, false);
            BAL_tacgia xulytacgia = new BAL_tacgia();

            string[] arr = new string[dgvTacGia.SelectedRows.Count];
            int id = 0;
            try
            {
                foreach (DataGridViewRow rows in dgvTacGia.SelectedRows)
                {
                    arr[id++] = dgvTacGia.Rows[rows.Index].Cells[0].Value.ToString();
                }

                DialogResult res = MessageBox.Show("Xác nhận khôi phục lại ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    if (!FormDangNhap.Nhanvien.Quan_ly)
                        foreach (DataGridViewRow item in dgvTacGia.SelectedRows)
                        {
                            dgvTacGia.Rows.RemoveAt(item.Index);
                        } 
                    bool ketqua = xulytacgia.capnhat_trangthai_moi(tacgia);
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
                dgvTacGia.DataSource = xulytacgia.getAll();
                rowtotacgia(0);
                btnKhoiPhuc.Visible = tacgia.Daxoa;
            }
            else
            {
                dgvTacGia.DataSource = xulytacgia.getAllExist();
                rowtotacgia(0);
                //ẩn đòng trạng thái đã xóa đi
                dgvTacGia.Columns[3].Visible = false;
            }
        }

     


    }
}
