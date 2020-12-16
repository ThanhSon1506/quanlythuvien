namespace do_an_wind
{
    partial class FormTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTacGia));
            this.tieu_su = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_tac_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_tac_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.Tên = new System.Windows.Forms.Label();
            this.gbxThongTin = new System.Windows.Forms.GroupBox();
            this.rtbTieuSu = new System.Windows.Forms.RichTextBox();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXatNhan = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.gbxThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // tieu_su
            // 
            this.tieu_su.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tieu_su.DataPropertyName = "tieu_su";
            this.tieu_su.HeaderText = "Tiểu sử";
            this.tieu_su.Name = "tieu_su";
            this.tieu_su.ReadOnly = true;
            // 
            // ma_tac_gia
            // 
            this.ma_tac_gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ma_tac_gia.DataPropertyName = "ma_tac_gia";
            this.ma_tac_gia.HeaderText = "Mã tác giả";
            this.ma_tac_gia.Name = "ma_tac_gia";
            this.ma_tac_gia.ReadOnly = true;
            this.ma_tac_gia.Width = 156;
            // 
            // ten_tac_gia
            // 
            this.ten_tac_gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_tac_gia.DataPropertyName = "ten_tac_gia";
            this.ten_tac_gia.HeaderText = "Tên tác giả";
            this.ten_tac_gia.Name = "ten_tac_gia";
            this.ten_tac_gia.ReadOnly = true;
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Location = new System.Drawing.Point(552, 26);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(287, 38);
            this.txtTenTacGia.TabIndex = 9;
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Location = new System.Drawing.Point(17, 29);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(140, 31);
            this.Tên.TabIndex = 10;
            this.Tên.Text = "Mã tác giả :";
            // 
            // gbxThongTin
            // 
            this.gbxThongTin.Controls.Add(this.rtbTieuSu);
            this.gbxThongTin.Controls.Add(this.txtMaTacGia);
            this.gbxThongTin.Controls.Add(this.label1);
            this.gbxThongTin.Controls.Add(this.label5);
            this.gbxThongTin.Controls.Add(this.txtTenTacGia);
            this.gbxThongTin.Controls.Add(this.Tên);
            this.gbxThongTin.Enabled = false;
            this.gbxThongTin.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.gbxThongTin.Location = new System.Drawing.Point(24, 377);
            this.gbxThongTin.Name = "gbxThongTin";
            this.gbxThongTin.Size = new System.Drawing.Size(845, 176);
            this.gbxThongTin.TabIndex = 84;
            this.gbxThongTin.TabStop = false;
            this.gbxThongTin.Text = "Thông tác giả";
            // 
            // rtbTieuSu
            // 
            this.rtbTieuSu.Location = new System.Drawing.Point(130, 60);
            this.rtbTieuSu.Name = "rtbTieuSu";
            this.rtbTieuSu.Size = new System.Drawing.Size(709, 104);
            this.rtbTieuSu.TabIndex = 11;
            this.rtbTieuSu.Text = "";
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.Location = new System.Drawing.Point(130, 26);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(245, 38);
            this.txtMaTacGia.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tiểu sử :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên tác giả :";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnTim.Location = new System.Drawing.Point(556, 27);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(70, 32);
            this.btnTim.TabIndex = 85;
            this.btnTim.Text = "Tìm...";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.TextChanged += new System.EventHandler(this.btnTim_Click);
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_tac_gia,
            this.ten_tac_gia,
            this.tieu_su});
            this.dgvTacGia.Location = new System.Drawing.Point(24, 65);
            this.dgvTacGia.MultiSelect = false;
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.ReadOnly = true;
            this.dgvTacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTacGia.Size = new System.Drawing.Size(1236, 290);
            this.dgvTacGia.TabIndex = 83;
            this.dgvTacGia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvTacGia_MouseClick);
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
            this.btnSua.Location = new System.Drawing.Point(886, 472);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(179, 81);
            this.btnSua.TabIndex = 87;
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
            this.btnXoa.Location = new System.Drawing.Point(1081, 472);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(179, 81);
            this.btnXoa.TabIndex = 88;
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
            this.btnThem.Location = new System.Drawing.Point(886, 377);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(374, 81);
            this.btnThem.TabIndex = 86;
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
            this.btnLamMoi.Location = new System.Drawing.Point(886, 472);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(179, 81);
            this.btnLamMoi.TabIndex = 90;
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
            this.btnQuayLai.Location = new System.Drawing.Point(1081, 472);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(179, 81);
            this.btnQuayLai.TabIndex = 91;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXatNhan
            // 
            this.btnXatNhan.BackColor = System.Drawing.Color.Lime;
            this.btnXatNhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXatNhan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXatNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXatNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXatNhan.Image")));
            this.btnXatNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXatNhan.Location = new System.Drawing.Point(886, 377);
            this.btnXatNhan.Name = "btnXatNhan";
            this.btnXatNhan.Size = new System.Drawing.Size(374, 81);
            this.btnXatNhan.TabIndex = 89;
            this.btnXatNhan.Text = "Xác nhận";
            this.btnXatNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXatNhan.UseVisualStyleBackColor = false;
            this.btnXatNhan.Click += new System.EventHandler(this.btnXatNhan_Click);
            // 
            // txtTim
            // 
            this.txtTim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtTim.Location = new System.Drawing.Point(24, 27);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(526, 38);
            this.txtTim.TabIndex = 82;
            this.txtTim.Tag = "";
            this.txtTim.Text = "Tên tác giả, mã tác giả";
            this.txtTim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTim_MouseUp);
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
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
            this.btnKhoiPhuc.Location = new System.Drawing.Point(886, 377);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(374, 180);
            this.btnKhoiPhuc.TabIndex = 92;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Visible = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // FormTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 581);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.gbxThongTin);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvTacGia);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXatNhan);
            this.Controls.Add(this.txtTim);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormTacGia";
            this.Tag = "";
            this.Text = "Tác Giả";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTacGia_FormClosing);
            this.Load += new System.EventHandler(this.FormTacGia_Load);
            this.gbxThongTin.ResumeLayout(false);
            this.gbxThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn tieu_su;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_tac_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_tac_gia;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.GroupBox gbxThongTin;
        private System.Windows.Forms.RichTextBox rtbTieuSu;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXatNhan;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnKhoiPhuc;


    }
}