using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;
using System.Text.RegularExpressions;
namespace do_an_wind
{
    public partial class FormTheLoai : Form
    {
        public int chucNang;
        private BEL_theloai theloai = new BEL_theloai();
        public FormTheLoai()
        {
            InitializeComponent();
        }

        private void Formtheloai_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            txtMaTheLoai.Enabled = false;
            txtTim.MaxLength = 20;
            txtMaTheLoai.MaxLength = 20;
            txtTenTheLoai.MaxLength = 20;
            //thây getAll() = getAllExit()
            //getAllExit() = khong lấy đọc giả đã xóa
            BAL_theloai xulytheloai = new BAL_theloai();
            DataTable data = null;
            dgvTheLoai.AllowUserToAddRows = false;
            
            if (FormDangNhap.Nhanvien.Quan_ly)
            {
                data = xulytheloai.getAll();
                dgvTheLoai.DataSource = data;
                rowtotheloai(0);
                btnKhoiPhuc.Visible = theloai.Da_xoa;
            }
            else
            {
                data = xulytheloai.getAllExist();
                dgvTheLoai.DataSource = data;
                rowtotheloai(0);
                dgvTheLoai.Columns[2].Visible = false;
            }
            btnXatNhan.Visible = btnLamMoi.Visible = btnQuayLai.Visible = false;
            foreach (DataRow row in data.Rows)
            {
                acsc.Add(row["ma_the_loai"].ToString());
                acsc.Add(row["the_loai"].ToString());
            }
            txtTim.AutoCompleteCustomSource = acsc;
        }
        private void dgvTheLoai_MouseClick(object sender, MouseEventArgs e)
        {
            btnKhoiPhuc.Visible = false;
            if (dgvTheLoai.SelectedRows.Count < 2)
                btnThem.Enabled = true;
            if (dgvTheLoai.SelectedRows.Count == 1)
            {
                btnSua.Enabled = true;
                //lấy id row đc chọn
                int id = dgvTheLoai.SelectedRows[0].Index;
                //in data vào test box và thêm vào biến
                rowtotheloai(id);
                btnKhoiPhuc.Visible = theloai.Da_xoa;
            }
            else
            {
                resetText();
                btnThem.Enabled = btnSua.Enabled = false;
            }
        }
        private void rowtotheloai(int id)
        {
            theloai.Ma_the_loai = txtMaTheLoai.Text = dgvTheLoai.Rows[id].Cells[0].Value.ToString();
            theloai.The_loai = txtTenTheLoai.Text = dgvTheLoai.Rows[id].Cells[1].Value.ToString();
            if (Convert.ToBoolean(dgvTheLoai.Rows[id].Cells[2].Value.ToString()) == true)
                theloai.Da_xoa = true;
            else
                theloai.Da_xoa = false;
        }
        private void resetText()
        {
            txtMaTheLoai.Text = txtTenTheLoai.Text = "";
        }
        private void swap_btn()
        {
            gbxThongTin.Enabled = !gbxThongTin.Enabled;
            txtTenTheLoai.Focus();
            btnThem.Visible = btnXoa.Visible = btnSua.Visible = !btnSua.Visible;
            btnXatNhan.Visible = btnLamMoi.Visible = btnQuayLai.Visible = !btnQuayLai.Visible;
            dgvTheLoai.Enabled = !dgvTheLoai.Enabled;
        }
        private void theloaitoText()
        {
            txtMaTheLoai.Text = theloai.Ma_the_loai;
            txtTenTheLoai.Text = theloai.The_loai;
        }
        private void txtTim_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtTim.Text == "Tên thể loại, mã thể loại")
                txtTim.Text = "";
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucNang = 2;
            swap_btn();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BEL.BEL_theloai theloai = new BEL.BEL_theloai(txtMaTheLoai.Text, txtTenTheLoai.Text, false);
            BAL.BAL_theloai xulytheloai = new BAL.BAL_theloai();

            string[] arr = new string[dgvTheLoai.SelectedRows.Count];
            int id = 0;
            try
            {
                foreach (DataGridViewRow rows in dgvTheLoai.SelectedRows)
                {
                    arr[id++] = dgvTheLoai.Rows[rows.Index].Cells[0].Value.ToString();
                }

                DialogResult res = MessageBox.Show("Xát nhận xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {

                    if (!FormDangNhap.Nhanvien.Quan_ly)
                        foreach (DataGridViewRow item in dgvTheLoai.SelectedRows)
                        {
                            dgvTheLoai.Rows.RemoveAt(item.Index);
                        }
                }
                bool ketqua = xulytheloai.capnhat_tragthai(theloai);
                if (ketqua == false)
                {
                    MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTheLoai.DataSource = xulytheloai.getAll();
                    //xóa dòng cuối
                    dgvTheLoai.AllowUserToAddRows = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            if (FormDangNhap.Nhanvien.Quan_ly)
            {
                dgvTheLoai.DataSource = xulytheloai.getAll();
                rowtotheloai(0);
                btnKhoiPhuc.Visible = this.theloai.Da_xoa;
            }
            else
            {
                dgvTheLoai.DataSource = xulytheloai.getAllExist();
                rowtotheloai(0);
                dgvTheLoai.Columns[2].Visible = false;
            }
        }

        private void btnXatNhan_Click(object sender, EventArgs e)
        {
            //1 = them , 2 = sua
            if (this.chucNang == 1)
            {
                if (!string.IsNullOrEmpty(txtTenTheLoai.Text))
                {
                    BEL.BEL_theloai theloai = new BEL.BEL_theloai(txtMaTheLoai.Text, txtTenTheLoai.Text, false);
                    BAL.BAL_theloai xulytheloai = new BAL.BAL_theloai();
                    bool ketqua = xulytheloai.Themtheloai(theloai);
                    if (ketqua == true)
                    {
                        MessageBox.Show("Đã thêm thể loại " + txtTenTheLoai.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (FormDangNhap.Nhanvien.Quan_ly)
                        {
                            dgvTheLoai.DataSource = xulytheloai.getAll();
                            rowtotheloai(0);
                            btnKhoiPhuc.Visible = this.theloai.Da_xoa;
                        }
                        else
                        {
                            dgvTheLoai.DataSource = xulytheloai.getAllExist();
                            rowtotheloai(0);
                            dgvTheLoai.Columns[2].Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã thêm thể loại thất bại " + txtTenTheLoai.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Dữu liệu đang bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (this.chucNang == 2)
            {
                if (!string.IsNullOrEmpty(txtTenTheLoai.Text))
                {
                    BEL.BEL_theloai theloai = new BEL.BEL_theloai(txtMaTheLoai.Text, txtTenTheLoai.Text, false);
                    BAL.BAL_theloai xulytheloai = new BAL.BAL_theloai();
                    bool ketqua = xulytheloai.Suatheloai(theloai);
                    if (ketqua == true)
                    {
                        MessageBox.Show("Đã update thể loại " + txtTenTheLoai.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (FormDangNhap.Nhanvien.Quan_ly)
                        {
                            dgvTheLoai.DataSource = xulytheloai.getAll();
                            rowtotheloai(0);
                            btnKhoiPhuc.Visible = this.theloai.Da_xoa;
                        }
                        else
                        {
                            dgvTheLoai.DataSource = xulytheloai.getAllExist();
                            rowtotheloai(0);
                            dgvTheLoai.Columns[2].Visible = false;
                        }
                        //xóa dòng cuối
                        dgvTheLoai.AllowUserToAddRows = false;
                    }
                }
                else {
                    MessageBox.Show("Dữ liệu đang bị rỗng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                theloaitoText();
            }
            swap_btn();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            theloaitoText();
            swap_btn();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            BAL_theloai xulytheloai = new BAL_theloai();
            
            if (IsNumber(txtTim.Text) == true)
            {
                DataTable Table = null;
                if (FormDangNhap.Nhanvien.Quan_ly)
                {
                    Table = xulytheloai.searcher_mtheloai_quanly(txtTim.Text);
                }
                else
                {
                    Table = xulytheloai.searcher_mtheloai(txtTim.Text);
                }
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvTheLoai.DataSource = xulytheloai.searcher_mtheloai(txtTim.Text);

                    dgvTheLoai.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTim.Text))
                {
                    if (FormDangNhap.Nhanvien.Quan_ly)
                    {
                        dgvTheLoai.DataSource = xulytheloai.getAll();
                        //xóa dòng cuối
                        dgvTheLoai.AllowUserToAddRows = false;
                    }
                    else
                    {
                        dgvTheLoai.DataSource = xulytheloai.getAllExist();
                        //xóa dòng cuối
                        dgvTheLoai.AllowUserToAddRows = false;
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
                    Table = xulytheloai.searcher_theloai_quanly(txtTim.Text);
                }
                else
                {
                    Table = xulytheloai.searcher_theloai(txtTim.Text);
                }
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvTheLoai.DataSource = xulytheloai.searcher_theloai(txtTim.Text);

                    dgvTheLoai.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTim.Text))
                {
                    if (FormDangNhap.Nhanvien.Quan_ly)
                    {
                        dgvTheLoai.DataSource = xulytheloai.getAll();
                        //xóa dòng cuối
                        dgvTheLoai.AllowUserToAddRows = false;
                    }
                    else
                    {
                        dgvTheLoai.DataSource = xulytheloai.getAllExist();
                        //xóa dòng cuối
                        dgvTheLoai.AllowUserToAddRows = false;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Thể loại này " + txtTim.Text + " chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void FormTheLoai_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            BEL.BEL_theloai theloai = new BEL.BEL_theloai(txtMaTheLoai.Text, txtTenTheLoai.Text, false);
            BAL.BAL_theloai xulytheloai = new BAL.BAL_theloai();

            string[] arr = new string[dgvTheLoai.SelectedRows.Count];
            int id = 0;
            try
            {
                foreach (DataGridViewRow rows in dgvTheLoai.SelectedRows)
                {
                    arr[id++] = dgvTheLoai.Rows[rows.Index].Cells[0].Value.ToString();
                }

                DialogResult res = MessageBox.Show("Xác nhận khôi phục ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {

                    if (!FormDangNhap.Nhanvien.Quan_ly)
                        foreach (DataGridViewRow item in dgvTheLoai.SelectedRows)
                        {
                            dgvTheLoai.Rows.RemoveAt(item.Index);
                        }
                    bool ketqua = xulytheloai.capnhat_tragthai_moi(theloai);
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
                dgvTheLoai.DataSource = xulytheloai.getAll();
                rowtotheloai(0);
                btnKhoiPhuc.Visible = theloai.Da_xoa;
            }
            else
            {
                dgvTheLoai.DataSource = xulytheloai.getAllExist();
                rowtotheloai(0);
                dgvTheLoai.Columns[2].Visible = false;
            }
        }
    }
}
