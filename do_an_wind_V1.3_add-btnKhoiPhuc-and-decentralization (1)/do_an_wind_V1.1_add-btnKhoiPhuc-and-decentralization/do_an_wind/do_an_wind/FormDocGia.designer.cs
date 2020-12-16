namespace do_an_wind
{
    partial class FormDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocGia));
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXatNhan = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.ma_doc_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_doc_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioi_tinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da_xoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.gbxThongTin = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.dateTimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tên = new System.Windows.Forms.Label();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.gbxThongTin.SuspendLayout();
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
            this.txtTim.TabIndex = 46;
            this.txtTim.Text = "Tên đọc giả, mã đọc giả";
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
            this.txtTim.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtTim_MouseUp);
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
            this.btnSua.TabIndex = 49;
            this.btnSua.Text = "    Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnXoa.TabIndex = 50;
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
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm ";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnXatNhan.TabIndex = 51;
            this.btnXatNhan.Text = "Xác nhận";
            this.btnXatNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXatNhan.UseVisualStyleBackColor = false;
            this.btnXatNhan.Click += new System.EventHandler(this.XatNhan_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnTim.Location = new System.Drawing.Point(556, 25);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(70, 32);
            this.btnTim.TabIndex = 47;
            this.btnTim.Text = "Tìm...";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            this.btnTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
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
            this.btnLamMoi.TabIndex = 52;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.ColumnHeadersHeight = 30;
            this.dgvDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_doc_gia,
            this.ten_doc_gia,
            this.gioi_tinh,
            this.ngay_sinh,
            this.dia_chi,
            this.CMND,
            this.SDT,
            this.da_xoa});
            this.dgvDocGia.Location = new System.Drawing.Point(24, 63);
            this.dgvDocGia.MultiSelect = false;
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocGia.Size = new System.Drawing.Size(1236, 290);
            this.dgvDocGia.TabIndex = 54;
            this.dgvDocGia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDocGia_MouseClick);
            // 
            // ma_doc_gia
            // 
            this.ma_doc_gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ma_doc_gia.DataPropertyName = "ma_doc_gia";
            this.ma_doc_gia.HeaderText = "Mã đọc giả";
            this.ma_doc_gia.Name = "ma_doc_gia";
            this.ma_doc_gia.ReadOnly = true;
            this.ma_doc_gia.Width = 164;
            // 
            // ten_doc_gia
            // 
            this.ten_doc_gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ten_doc_gia.DataPropertyName = "ten_doc_gia";
            this.ten_doc_gia.HeaderText = "Tên đọc giả";
            this.ten_doc_gia.Name = "ten_doc_gia";
            this.ten_doc_gia.ReadOnly = true;
            this.ten_doc_gia.Width = 170;
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gioi_tinh.DataPropertyName = "gioi_tinh";
            this.gioi_tinh.HeaderText = "Giới tính";
            this.gioi_tinh.Name = "gioi_tinh";
            this.gioi_tinh.ReadOnly = true;
            this.gioi_tinh.Width = 117;
            // 
            // ngay_sinh
            // 
            this.ngay_sinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngay_sinh.DataPropertyName = "ngay_sinh";
            this.ngay_sinh.HeaderText = "Ngày sinh";
            this.ngay_sinh.Name = "ngay_sinh";
            this.ngay_sinh.ReadOnly = true;
            this.ngay_sinh.Width = 151;
            // 
            // dia_chi
            // 
            this.dia_chi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dia_chi.DataPropertyName = "dia_chi";
            this.dia_chi.HeaderText = "Địa Chỉ";
            this.dia_chi.Name = "dia_chi";
            this.dia_chi.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            this.CMND.Width = 123;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 188;
            // 
            // da_xoa
            // 
            this.da_xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.da_xoa.DataPropertyName = "da_xoa";
            this.da_xoa.HeaderText = "Đã xóa";
            this.da_xoa.Name = "da_xoa";
            this.da_xoa.ReadOnly = true;
            this.da_xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.da_xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.da_xoa.Width = 121;
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
            this.btnQuayLai.TabIndex = 53;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // gbxThongTin
            // 
            this.gbxThongTin.Controls.Add(this.rdbNu);
            this.gbxThongTin.Controls.Add(this.rdbNam);
            this.gbxThongTin.Controls.Add(this.dateTimeNgaySinh);
            this.gbxThongTin.Controls.Add(this.label6);
            this.gbxThongTin.Controls.Add(this.txtTenDocGia);
            this.gbxThongTin.Controls.Add(this.label1);
            this.gbxThongTin.Controls.Add(this.txtMaDocGia);
            this.gbxThongTin.Controls.Add(this.label5);
            this.gbxThongTin.Controls.Add(this.label4);
            this.gbxThongTin.Controls.Add(this.txtDiaChi);
            this.gbxThongTin.Controls.Add(this.label3);
            this.gbxThongTin.Controls.Add(this.txtSDT);
            this.gbxThongTin.Controls.Add(this.txtCMND);
            this.gbxThongTin.Controls.Add(this.label2);
            this.gbxThongTin.Controls.Add(this.Tên);
            this.gbxThongTin.Enabled = false;
            this.gbxThongTin.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.gbxThongTin.Location = new System.Drawing.Point(24, 375);
            this.gbxThongTin.Name = "gbxThongTin";
            this.gbxThongTin.Size = new System.Drawing.Size(845, 180);
            this.gbxThongTin.TabIndex = 55;
            this.gbxThongTin.TabStop = false;
            this.gbxThongTin.Text = "Thông tin đọc giả";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(229, 108);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(69, 35);
            this.rdbNu.TabIndex = 3;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(139, 108);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(86, 35);
            this.rdbNam.TabIndex = 2;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // dateTimeNgaySinh
            // 
            this.dateTimeNgaySinh.Checked = false;
            this.dateTimeNgaySinh.CustomFormat = "dd-MM-yyyy";
            this.dateTimeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgaySinh.Location = new System.Drawing.Point(137, 141);
            this.dateTimeNgaySinh.Name = "dateTimeNgaySinh";
            this.dateTimeNgaySinh.Size = new System.Drawing.Size(275, 38);
            this.dateTimeNgaySinh.TabIndex = 4;
            this.dateTimeNgaySinh.Value = new System.DateTime(2020, 6, 19, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "SDT :";
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(137, 69);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(275, 38);
            this.txtTenDocGia.TabIndex = 1;
            this.txtTenDocGia.Tag = "1";
            this.txtTenDocGia.Text = " ";
            this.txtTenDocGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDocGia_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "CMND :";
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Enabled = false;
            this.txtMaDocGia.Location = new System.Drawing.Point(137, 31);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(275, 38);
            this.txtMaDocGia.TabIndex = 10;
            this.txtMaDocGia.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đia chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giới tính :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(522, 31);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(317, 38);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày sinh :";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(522, 107);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(317, 38);
            this.txtSDT.TabIndex = 7;
            this.txtSDT.Text = " ";
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(522, 69);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(317, 38);
            this.txtCMND.TabIndex = 6;
            this.txtCMND.Text = " ";
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã đọc giả :";
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Location = new System.Drawing.Point(14, 72);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(161, 31);
            this.Tên.TabIndex = 10;
            this.Tên.Text = "Tên đọc giả : ";
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
            this.btnKhoiPhuc.Location = new System.Drawing.Point(886, 375);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(374, 180);
            this.btnKhoiPhuc.TabIndex = 49;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Visible = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // FormDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 581);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXatNhan);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.gbxThongTin);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đọc giả";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDocGia_FormClosing);
            this.Load += new System.EventHandler(this.FormDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.gbxThongTin.ResumeLayout(false);
            this.gbxThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXatNhan;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.GroupBox gbxThongTin;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.DateTimePicker dateTimeNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_doc_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_doc_gia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn da_xoa;
        private System.Windows.Forms.Button btnKhoiPhuc;


    }
}