namespace do_an_wind
{
    partial class FormNhaXuatBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhaXuatBan));
            this.btnXatNhan = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaNhaXuatBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNhaXuatBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNhaXuatBan = new System.Windows.Forms.DataGridView();
            this.ma_nha_xuat_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_nha_xuat_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dien_thoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da_xoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.Tên = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.gbxThongTin = new System.Windows.Forms.GroupBox();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaXuatBan)).BeginInit();
            this.gbxThongTin.SuspendLayout();
            this.SuspendLayout();
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
            this.btnXatNhan.TabIndex = 73;
            this.btnXatNhan.Text = "Xác nhận";
            this.btnXatNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXatNhan.UseVisualStyleBackColor = false;
            this.btnXatNhan.Click += new System.EventHandler(this.btnXatNhan_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(182, 107);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(238, 38);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtMaNhaXuatBan
            // 
            this.txtMaNhaXuatBan.Enabled = false;
            this.txtMaNhaXuatBan.Location = new System.Drawing.Point(182, 31);
            this.txtMaNhaXuatBan.Name = "txtMaNhaXuatBan";
            this.txtMaNhaXuatBan.Size = new System.Drawing.Size(238, 38);
            this.txtMaNhaXuatBan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email :";
            // 
            // txtTenNhaXuatBan
            // 
            this.txtTenNhaXuatBan.Location = new System.Drawing.Point(182, 69);
            this.txtTenNhaXuatBan.Name = "txtTenNhaXuatBan";
            this.txtTenNhaXuatBan.Size = new System.Drawing.Size(238, 38);
            this.txtTenNhaXuatBan.TabIndex = 2;
            this.txtTenNhaXuatBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNhaXuatBan_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "SDT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Địa Chỉ :";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(532, 31);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(307, 38);
            this.txtSDT.TabIndex = 4;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(532, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 38);
            this.txtEmail.TabIndex = 5;
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
            this.btnSua.TabIndex = 71;
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
            this.btnXoa.TabIndex = 72;
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
            this.btnThem.TabIndex = 70;
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
            this.btnLamMoi.TabIndex = 74;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên nhà xuất bản :";
            // 
            // dgvNhaXuatBan
            // 
            this.dgvNhaXuatBan.ColumnHeadersHeight = 30;
            this.dgvNhaXuatBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_nha_xuat_ban,
            this.ten_nha_xuat_ban,
            this.dia_chi,
            this.dien_thoai,
            this.email,
            this.da_xoa});
            this.dgvNhaXuatBan.Location = new System.Drawing.Point(24, 63);
            this.dgvNhaXuatBan.MultiSelect = false;
            this.dgvNhaXuatBan.Name = "dgvNhaXuatBan";
            this.dgvNhaXuatBan.ReadOnly = true;
            this.dgvNhaXuatBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaXuatBan.Size = new System.Drawing.Size(1236, 290);
            this.dgvNhaXuatBan.TabIndex = 67;
            this.dgvNhaXuatBan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvNhaXuatBan_MouseClick);
            // 
            // ma_nha_xuat_ban
            // 
            this.ma_nha_xuat_ban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ma_nha_xuat_ban.DataPropertyName = "ma_nha_xuat_ban";
            this.ma_nha_xuat_ban.HeaderText = "Mã nhà xuất bản";
            this.ma_nha_xuat_ban.Name = "ma_nha_xuat_ban";
            this.ma_nha_xuat_ban.ReadOnly = true;
            this.ma_nha_xuat_ban.Width = 227;
            // 
            // ten_nha_xuat_ban
            // 
            this.ten_nha_xuat_ban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_nha_xuat_ban.DataPropertyName = "ten_nha_xuat_ban";
            this.ten_nha_xuat_ban.HeaderText = "Tên nhà xuất bản";
            this.ten_nha_xuat_ban.Name = "ten_nha_xuat_ban";
            this.ten_nha_xuat_ban.ReadOnly = true;
            // 
            // dia_chi
            // 
            this.dia_chi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dia_chi.DataPropertyName = "dia_chi";
            this.dia_chi.HeaderText = "Địa chỉ";
            this.dia_chi.Name = "dia_chi";
            this.dia_chi.ReadOnly = true;
            // 
            // dien_thoai
            // 
            this.dien_thoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dien_thoai.DataPropertyName = "sdt";
            this.dien_thoai.HeaderText = "Điện thoại";
            this.dien_thoai.Name = "dien_thoai";
            this.dien_thoai.ReadOnly = true;
            this.dien_thoai.Width = 158;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 107;
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
            // txtTim
            // 
            this.txtTim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtTim.Location = new System.Drawing.Point(24, 25);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(526, 38);
            this.txtTim.TabIndex = 66;
            this.txtTim.Text = "Tên Nhà xuất bản, mã nhà xuất bản";
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
            this.txtTim.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtTim_MouseUp);
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Location = new System.Drawing.Point(14, 34);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(218, 31);
            this.Tên.TabIndex = 10;
            this.Tên.Text = "Mã nhà xuất bản : ";
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
            this.btnQuayLai.TabIndex = 75;
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
            this.btnTim.TabIndex = 69;
            this.btnTim.Text = "Tìm...";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // gbxThongTin
            // 
            this.gbxThongTin.Controls.Add(this.txtDiaChi);
            this.gbxThongTin.Controls.Add(this.txtMaNhaXuatBan);
            this.gbxThongTin.Controls.Add(this.label1);
            this.gbxThongTin.Controls.Add(this.txtTenNhaXuatBan);
            this.gbxThongTin.Controls.Add(this.label5);
            this.gbxThongTin.Controls.Add(this.label4);
            this.gbxThongTin.Controls.Add(this.txtSDT);
            this.gbxThongTin.Controls.Add(this.txtEmail);
            this.gbxThongTin.Controls.Add(this.label2);
            this.gbxThongTin.Controls.Add(this.Tên);
            this.gbxThongTin.Enabled = false;
            this.gbxThongTin.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.gbxThongTin.Location = new System.Drawing.Point(24, 375);
            this.gbxThongTin.Name = "gbxThongTin";
            this.gbxThongTin.Size = new System.Drawing.Size(845, 181);
            this.gbxThongTin.TabIndex = 68;
            this.gbxThongTin.TabStop = false;
            this.gbxThongTin.Text = "Thông nhà xuất bản";
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
            this.btnKhoiPhuc.TabIndex = 76;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Visible = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // FormNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 581);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.btnXatNhan);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvNhaXuatBan);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.gbxThongTin);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormNhaXuatBan";
            this.Text = "Nhà xuất bản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNhaXuatBan_FormClosing);
            this.Load += new System.EventHandler(this.FormNhaXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaXuatBan)).EndInit();
            this.gbxThongTin.ResumeLayout(false);
            this.gbxThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXatNhan;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaNhaXuatBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNhaXuatBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNhaXuatBan;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox gbxThongTin;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_nha_xuat_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_nha_xuat_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dien_thoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn da_xoa;

    }
}