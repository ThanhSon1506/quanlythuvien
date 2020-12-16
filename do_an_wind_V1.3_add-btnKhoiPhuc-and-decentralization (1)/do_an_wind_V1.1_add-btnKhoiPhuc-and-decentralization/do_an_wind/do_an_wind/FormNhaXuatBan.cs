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
    public partial class FormNhaXuatBan : Form
    {
        public int chucNang;
        private BEL_nhaxuatban nhaxuatban = new BEL_nhaxuatban();
        public FormNhaXuatBan()
        {
            InitializeComponent();
        }
        private void FormNhaXuatBan_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            txtTim.MaxLength = 25;
            txtTenNhaXuatBan.MaxLength = 20;
            txtSDT.MaxLength = 10;
            txtDiaChi.MaxLength = 20;
            txtEmail.MaxLength = 25;
            dgvNhaXuatBan.AllowUserToAddRows = false;
            dgvNhaXuatBan.RowHeadersVisible = false;
            btnXatNhan.Visible = btnLamMoi.Visible = btnQuayLai.Visible = false;
            BAL_nhaxuatban xulynhaxuatban = new BAL_nhaxuatban();
            DataTable data;
            if (FormDangNhap.Nhanvien.Quan_ly)
            {
                data = xulynhaxuatban.getAll();
                dgvNhaXuatBan.DataSource = data;
                rowtonhaxuatban(0);
                btnKhoiPhuc.Visible = nhaxuatban.Da_xoa;
            }
            else
            {
                data = xulynhaxuatban.getAllExist();
                dgvNhaXuatBan.DataSource = data;
                rowtonhaxuatban(0);
                //ẩn đòng trạng thái đã xóa đi
                dgvNhaXuatBan.Columns[5].Visible = false;
            }
            foreach (DataRow row in data.Rows)
            {
                acsc.Add(row["ma_nha_xuat_ban"].ToString());
                acsc.Add(row["ten_nha_xuat_ban"].ToString());
            }
            txtTim.AutoCompleteCustomSource = acsc;
        }
        private void dgvNhaXuatBan_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvNhaXuatBan.SelectedRows.Count < 2)
                btnThem.Enabled = true;
            if (dgvNhaXuatBan.SelectedRows.Count == 1)
            {
                btnSua.Enabled = true;
                //lấy id row đc chọn
                int id = dgvNhaXuatBan.SelectedRows[0].Index;
                //in data vào test box và thêm vào biến
                rowtonhaxuatban(id);
                btnKhoiPhuc.Visible = nhaxuatban.Da_xoa;
            }
            else
            {
                resetText();
                btnThem.Enabled = btnSua.Enabled = false;
            }
        }

        private void rowtonhaxuatban(int id)
        {
            nhaxuatban.Ma_nha_xuat_ban = txtMaNhaXuatBan.Text = dgvNhaXuatBan.Rows[id].Cells[0].Value.ToString();
            nhaxuatban.Ten_nha_xuat_ban = txtTenNhaXuatBan.Text = dgvNhaXuatBan.Rows[id].Cells[1].Value.ToString();
            nhaxuatban.Dia_chi = txtDiaChi.Text = dgvNhaXuatBan.Rows[id].Cells[2].Value.ToString();
            nhaxuatban.Sdt = txtSDT.Text = dgvNhaXuatBan.Rows[id].Cells[3].Value.ToString();
            nhaxuatban.Email = txtEmail.Text = dgvNhaXuatBan.Rows[id].Cells[4].Value.ToString();
            if (Convert.ToBoolean(dgvNhaXuatBan.Rows[id].Cells[5].Value.ToString()) == true)
                nhaxuatban.Da_xoa = true;
            else
                nhaxuatban.Da_xoa = false;
        }

        private void resetText()
        {
            txtMaNhaXuatBan.Text = txtTenNhaXuatBan.Text = txtSDT.Text = txtDiaChi.Text = txtEmail.Text = txtTim.Text = "";
        }

        private void swap_btn()
        {
            gbxThongTin.Enabled = !gbxThongTin.Enabled;
            txtMaNhaXuatBan.Focus();
            btnThem.Visible = btnXoa.Visible = btnSua.Visible = !btnSua.Visible;
            btnXatNhan.Visible = btnLamMoi.Visible = btnQuayLai.Visible = !btnQuayLai.Visible;
            dgvNhaXuatBan.Enabled = !dgvNhaXuatBan.Enabled;
        }
        private void nhaxuatbantoText()
        {
            txtMaNhaXuatBan.Text = nhaxuatban.Ma_nha_xuat_ban;
            txtTenNhaXuatBan.Text = nhaxuatban.Ten_nha_xuat_ban;
            txtDiaChi.Text = nhaxuatban.Dia_chi;
            txtSDT.Text = nhaxuatban.Sdt;
            txtEmail.Text = nhaxuatban.Email;
        }
        public bool IsNumber(string str)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(str);
        }

        private void btnXatNhan_Click(object sender, EventArgs e)
        {
            //1 = them , 2 = sua
            if (this.chucNang == 1)
            {
                if (txtSDT.TextLength == 10)
                {
                    if (isEmail(txtEmail.Text))
                    {
                        if (!string.IsNullOrEmpty(txtDiaChi.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtSDT.Text) && !string.IsNullOrEmpty(txtTenNhaXuatBan.Text))
                        {
                            BEL.BEL_nhaxuatban nhaxuatban = new BEL.BEL_nhaxuatban(txtMaNhaXuatBan.Text, txtTenNhaXuatBan.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, false);
                            BAL.BAL_nhaxuatban xulynhaxuatban = new BAL.BAL_nhaxuatban();
                            bool ketqua = xulynhaxuatban.Themnhaxuatban(nhaxuatban);
                            if (ketqua == true)
                            {
                                MessageBox.Show("Đã thêm nhà xuất bản " + txtTenNhaXuatBan.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvNhaXuatBan.DataSource = xulynhaxuatban.getAll();
                            }
                            else
                            {
                                MessageBox.Show("Đã thêm nhà xuất bản thất bại " + txtTenNhaXuatBan.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu đang bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gmail bạn không hợp lệ " + txtSDT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (isEmail(txtEmail.Text))
                    {
                        if (!string.IsNullOrEmpty(txtDiaChi.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtSDT.Text) && !string.IsNullOrEmpty(txtTenNhaXuatBan.Text))
                        {
                            BEL.BEL_nhaxuatban nhaxuatban = new BEL.BEL_nhaxuatban(txtMaNhaXuatBan.Text, txtTenNhaXuatBan.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, false);
                            BAL.BAL_nhaxuatban xulynhaxuatban = new BAL.BAL_nhaxuatban();
                            bool ketqua = xulynhaxuatban.Suanhaxuatban(nhaxuatban);
                            if (ketqua == true)
                            {
                                MessageBox.Show("Đã update nhà xuất bản " + txtTenNhaXuatBan.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvNhaXuatBan.DataSource = xulynhaxuatban.getAll();
                                //xóa dòng cuối
                                dgvNhaXuatBan.AllowUserToAddRows = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu đang bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gmail bạn không hợp lệ " + txtSDT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mã SDT không hợp lệ " + txtSDT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            swap_btn();
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            nhaxuatbantoText();
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
                nhaxuatbantoText();
            }
            swap_btn();
        }
        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTim.PerformClick();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            BAL_nhaxuatban xulynhaxuatban = new BAL_nhaxuatban();
            if (IsNumber(txtTim.Text) == true)
            {
                DataTable Table = null;

                if (FormDangNhap.Nhanvien.Quan_ly)
                {
                    Table = xulynhaxuatban.searcher_mnhaxuatban_quanly(txtTim.Text);
                }
                else
                {
                    Table = xulynhaxuatban.searcher_mnhaxuatban(txtTim.Text);
                }
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvNhaXuatBan.DataSource = Table;
                    dgvNhaXuatBan.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTim.Text))
                {
                    if (FormDangNhap.Nhanvien.Quan_ly)
                    {
                        dgvNhaXuatBan.DataSource = xulynhaxuatban.getAll();
                        //xóa dòng cuối
                        dgvNhaXuatBan.AllowUserToAddRows = false;
                    }
                    else
                    {
                        dgvNhaXuatBan.DataSource = xulynhaxuatban.getAllExist();
                        //xóa dòng cuối
                        dgvNhaXuatBan.AllowUserToAddRows = false;
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
                    Table = xulynhaxuatban.searcher_nhaxuatban_quanly(txtTim.Text);
                }
                else
                {
                    Table = xulynhaxuatban.searcher_nhaxuatban(txtTim.Text);
                }
                if (Table != null && Table.Rows.Count > 0)
                {
                    dgvNhaXuatBan.DataSource = Table;
                    dgvNhaXuatBan.AllowUserToAddRows = false;
                }
                else if (string.IsNullOrEmpty(txtTim.Text))
                {
                    if (FormDangNhap.Nhanvien.Quan_ly)
                    {
                        dgvNhaXuatBan.DataSource = xulynhaxuatban.getAll();
                        //xóa dòng cuối
                        dgvNhaXuatBan.AllowUserToAddRows = false;
                    }
                    else
                    {
                        dgvNhaXuatBan.DataSource = xulynhaxuatban.getAllExist();
                        //xóa dòng cuối
                        dgvNhaXuatBan.AllowUserToAddRows = false;
                    }

                }
                else
                {
                    MessageBox.Show("Nhà xuất bản này " + txtTim.Text + " chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void txtTim_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtTim.Text == "Tên Nhà xuất bản, mã nhà xuất bản")
                txtTim.Text = "";
        }
        private void txtTenNhaXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }
        public static bool isEmail(string Email)
        {
            Email = Email ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(Email))
                return (true);
            else
                return (false);
        }

        //private void txtTenNhaXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        //}
        //private void txtSDT_KeyPress_1(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

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
            BEL.BEL_nhaxuatban NhaXuatBan = new BEL.BEL_nhaxuatban(txtMaNhaXuatBan.Text, txtTenNhaXuatBan.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, false);
            BAL.BAL_nhaxuatban xulyNhaXuatBan = new BAL.BAL_nhaxuatban();
            string[] arr = new string[dgvNhaXuatBan.SelectedRows.Count];
            int id = 0;
            try
            {
                foreach (DataGridViewRow rows in dgvNhaXuatBan.SelectedRows)
                {
                    arr[id++] = dgvNhaXuatBan.Rows[rows.Index].Cells[0].Value.ToString();
                }
                DialogResult res = MessageBox.Show("Xát nhận xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    if (!FormDangNhap.Nhanvien.Quan_ly)
                        foreach (DataGridViewRow item in dgvNhaXuatBan.SelectedRows)
                        {
                            dgvNhaXuatBan.Rows.RemoveAt(item.Index);
                        }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bool ketqua = xulyNhaXuatBan.capnhat_tragthai(NhaXuatBan);
            if (ketqua == false)
            {
                MessageBox.Show("Lỗi này là của của chúng tôi không phải do bạn? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNhaXuatBan.DataSource = xulyNhaXuatBan.getAllExist();
                //xóa dòng cuối
                dgvNhaXuatBan.AllowUserToAddRows = false;
            }
            if (FormDangNhap.Nhanvien.Quan_ly)
            {
                dgvNhaXuatBan.DataSource = xulyNhaXuatBan.getAll();
                rowtonhaxuatban(0);
                btnKhoiPhuc.Visible = nhaxuatban.Da_xoa;
            }
            else
            {
                dgvNhaXuatBan.DataSource = xulyNhaXuatBan.getAllExist();
                rowtonhaxuatban(0);
                //ẩn đòng trạng thái đã xóa đi
                dgvNhaXuatBan.Columns[5].Visible = false;
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            BEL.BEL_nhaxuatban NhaXuatBan = new BEL.BEL_nhaxuatban(txtMaNhaXuatBan.Text, txtTenNhaXuatBan.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, false);
            BAL.BAL_nhaxuatban xulyNhaXuatBan = new BAL.BAL_nhaxuatban();
            string[] arr = new string[dgvNhaXuatBan.SelectedRows.Count];
            int id = 0;
            try
            {
                foreach (DataGridViewRow rows in dgvNhaXuatBan.SelectedRows)
                {
                    arr[id++] = dgvNhaXuatBan.Rows[rows.Index].Cells[0].Value.ToString();
                }
                DialogResult res = MessageBox.Show("Xác nhận khôi phục ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    if (!FormDangNhap.Nhanvien.Quan_ly)
                        foreach (DataGridViewRow item in dgvNhaXuatBan.SelectedRows)
                        {
                            dgvNhaXuatBan.Rows.RemoveAt(item.Index);
                        }
                    bool ketqua = xulyNhaXuatBan.capnhat_tragthai_moi(NhaXuatBan);
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
                dgvNhaXuatBan.DataSource = xulyNhaXuatBan.getAll();
                rowtonhaxuatban(0);
                btnKhoiPhuc.Visible = nhaxuatban.Da_xoa;
            }
            else
            {
                dgvNhaXuatBan.DataSource = xulyNhaXuatBan.getAll();
                rowtonhaxuatban(0);
                //ẩn đòng trạng thái đã xóa đi
                dgvNhaXuatBan.Columns[5].Visible = false;
            }
        }

        private void FormNhaXuatBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
                e.Cancel = false;
        }
    }
}