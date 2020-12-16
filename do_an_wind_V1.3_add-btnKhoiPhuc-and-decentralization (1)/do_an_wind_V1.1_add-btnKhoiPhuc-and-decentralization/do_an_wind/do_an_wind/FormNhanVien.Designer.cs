namespace do_an_wind
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXatNhan = new System.Windows.Forms.Button();
            this.gbxThongTin = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tên = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.ma_nhan_vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_nhan_vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioi_tinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanly = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da_xoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.gbxThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTim
            // 
            this.txtTim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtTim.Location = new System.Drawing.Point(24, 25);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(526, 38);
            this.txtTim.TabIndex = 69;
            this.txtTim.Text = "Tên nhân viên, mã nhân viên";
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
            this.txtTim.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtTim_MouseUp);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXoa.Location = new System.Drawing.Point(1081, 470);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(179, 81);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.Text = "    Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(886, 375);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(374, 81);
            this.btnThem.TabIndex = 72;
            this.btnThem.Text = "Thêm ";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Yellow;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLamMoi.Location = new System.Drawing.Point(886, 470);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(179, 81);
            this.btnLamMoi.TabIndex = 76;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.OrangeRed;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.Black;
            this.btnQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("btnQuayLai.Image")));
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuayLai.Location = new System.Drawing.Point(1081, 470);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(179, 81);
            this.btnQuayLai.TabIndex = 77;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnTim.Location = new System.Drawing.Point(556, 25);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(70, 32);
            this.btnTim.TabIndex = 78;
            this.btnTim.Text = "Tìm...";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXatNhan
            // 
            this.btnXatNhan.BackColor = System.Drawing.Color.Lime;
            this.btnXatNhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXatNhan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXatNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXatNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXatNhan.Image")));
            this.btnXatNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXatNhan.Location = new System.Drawing.Point(886, 375);
            this.btnXatNhan.Name = "btnXatNhan";
            this.btnXatNhan.Size = new System.Drawing.Size(374, 81);
            this.btnXatNhan.TabIndex = 75;
            this.btnXatNhan.Text = "Xác nhận";
            this.btnXatNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXatNhan.UseVisualStyleBackColor = false;
            this.btnXatNhan.Click += new System.EventHandler(this.btnXatNhan_Click);
            // 
            // gbxThongTin
            // 
            this.gbxThongTin.Controls.Add(this.rdbNu);
            this.gbxThongTin.Controls.Add(this.rdbNam);
            this.gbxThongTin.Controls.Add(this.label4);
            this.gbxThongTin.Controls.Add(this.dateTimeNgaySinh);
            this.gbxThongTin.Controls.Add(this.label6);
            this.gbxThongTin.Controls.Add(this.txtTenNhanVien);
            this.gbxThongTin.Controls.Add(this.label1);
            this.gbxThongTin.Controls.Add(this.txtMaNhanVien);
            this.gbxThongTin.Controls.Add(this.label5);
            this.gbxThongTin.Controls.Add(this.txtDiaChi);
            this.gbxThongTin.Controls.Add(this.txtSDT);
            this.gbxThongTin.Controls.Add(this.label2);
            this.gbxThongTin.Controls.Add(this.Tên);
            this.gbxThongTin.Enabled = false;
            this.gbxThongTin.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.gbxThongTin.Location = new System.Drawing.Point(24, 375);
            this.gbxThongTin.Name = "gbxThongTin";
            this.gbxThongTin.Size = new System.Drawing.Size(845, 181);
            this.gbxThongTin.TabIndex = 71;
            this.gbxThongTin.TabStop = false;
            this.gbxThongTin.Text = "Thông tin nhân viên";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(264, 109);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(69, 35);
            this.rdbNu.TabIndex = 13;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(161, 109);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(86, 35);
            this.rdbNam.TabIndex = 12;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giới tính :";
            // 
            // dateTimeNgaySinh
            // 
            this.dateTimeNgaySinh.CustomFormat = "dd-MM-yyyy";
            this.dateTimeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgaySinh.Location = new System.Drawing.Point(546, 107);
            this.dateTimeNgaySinh.Name = "dateTimeNgaySinh";
            this.dateTimeNgaySinh.Size = new System.Drawing.Size(293, 38);
            this.dateTimeNgaySinh.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày sinh :";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(161, 69);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(254, 38);
            this.txtTenNhanVien.TabIndex = 1;
            this.txtTenNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNhanVien_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "SDT :";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(161, 31);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(254, 38);
            this.txtMaNhanVien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa chỉ :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(546, 31);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(293, 38);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(546, 69);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(293, 38);
            this.txtSDT.TabIndex = 9;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã nhân viên :";
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Location = new System.Drawing.Point(14, 74);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(189, 31);
            this.Tên.TabIndex = 10;
            this.Tên.Text = "Tên nhân viên : ";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeight = 30;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_nhan_vien,
            this.ten_nhan_vien,
            this.gioi_tinh,
            this.ngay_sinh,
            this.dia_chi,
            this.quanly,
            this.sdt,
            this.da_xoa});
            this.dgvNhanVien.Location = new System.Drawing.Point(24, 63);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowTemplate.Height = 30;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1236, 290);
            this.dgvNhanVien.TabIndex = 70;
            this.dgvNhanVien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvNhanVien_MouseClick);
            // 
            // ma_nhan_vien
            // 
            this.ma_nhan_vien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ma_nhan_vien.DataPropertyName = "ma_nhan_vien";
            this.ma_nhan_vien.HeaderText = "Mã nhân viên";
            this.ma_nhan_vien.Name = "ma_nhan_vien";
            this.ma_nhan_vien.ReadOnly = true;
            this.ma_nhan_vien.Width = 192;
            // 
            // ten_nhan_vien
            // 
            this.ten_nhan_vien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ten_nhan_vien.DataPropertyName = "ten_nhan_vien";
            this.ten_nhan_vien.HeaderText = "Tên nhân viên";
            this.ten_nhan_vien.Name = "ten_nhan_vien";
            this.ten_nhan_vien.ReadOnly = true;
            this.ten_nhan_vien.Width = 198;
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gioi_tinh.DataPropertyName = "gioi_tinh";
            this.gioi_tinh.HeaderText = "Giới tính";
            this.gioi_tinh.Name = "gioi_tinh";
            this.gioi_tinh.ReadOnly = true;
            this.gioi_tinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gioi_tinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gioi_tinh.Width = 140;
            // 
            // ngay_sinh
            // 
            this.ngay_sinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngay_sinh.DataPropertyName = "ngay_sinh";
            this.ngay_sinh.HeaderText = "Ngày sinh";
            this.ngay_sinh.Name = "ngay_sinh";
            this.ngay_sinh.ReadOnly = true;
            // 
            // dia_chi
            // 
            this.dia_chi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dia_chi.DataPropertyName = "dia_chi";
            this.dia_chi.HeaderText = "Địa chỉ";
            this.dia_chi.Name = "dia_chi";
            this.dia_chi.ReadOnly = true;
            // 
            // quanly
            // 
            this.quanly.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quanly.DataPropertyName = "quanly";
            this.quanly.HeaderText = "quanly";
            this.quanly.Name = "quanly";
            this.quanly.ReadOnly = true;
            this.quanly.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quanly.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.quanly.Width = 118;
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 94;
            // 
            // da_xoa
            // 
            this.da_xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.da_xoa.DataPropertyName = "da_xoa";
            this.da_xoa.HeaderText = "Đã xóa";
            this.da_xoa.Name = "da_xoa";
            this.da_xoa.ReadOnly = true;
            this.da_xoa.Width = 98;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Yellow;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSua.Location = new System.Drawing.Point(886, 470);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(179, 81);
            this.btnSua.TabIndex = 73;
            this.btnSua.Text = "    Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.Yellow;
            this.btnKhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.Black;
            this.btnKhoiPhuc.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoiPhuc.Image")));
            this.btnKhoiPhuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoiPhuc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(886, 373);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(374, 180);
            this.btnKhoiPhuc.TabIndex = 50;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Visible = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 581);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXatNhan);
            this.Controls.Add(this.gbxThongTin);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btnSua);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormNhanVien";
            this.Text = "Nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.gbxThongTin.ResumeLayout(false);
            this.gbxThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXatNhan;
        private System.Windows.Forms.GroupBox gbxThongTin;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_nhan_vien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_nhan_vien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_chi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn quanly;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn da_xoa;
        private System.Windows.Forms.Button btnKhoiPhuc;



    }
}