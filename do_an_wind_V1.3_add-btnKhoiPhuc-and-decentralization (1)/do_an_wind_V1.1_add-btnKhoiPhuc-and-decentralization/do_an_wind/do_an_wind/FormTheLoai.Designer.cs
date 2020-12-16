namespace do_an_wind
{
    partial class FormTheLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTheLoai));
            this.gbxThongTin = new System.Windows.Forms.GroupBox();
            this.txtMaTheLoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenTheLoai = new System.Windows.Forms.TextBox();
            this.Tên = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXatNhan = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.ma_the_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.the_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da_xoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.gbxThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxThongTin
            // 
            this.gbxThongTin.Controls.Add(this.txtMaTheLoai);
            this.gbxThongTin.Controls.Add(this.label5);
            this.gbxThongTin.Controls.Add(this.txtTenTheLoai);
            this.gbxThongTin.Controls.Add(this.Tên);
            this.gbxThongTin.Enabled = false;
            this.gbxThongTin.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.gbxThongTin.Location = new System.Drawing.Point(24, 377);
            this.gbxThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.gbxThongTin.Name = "gbxThongTin";
            this.gbxThongTin.Padding = new System.Windows.Forms.Padding(2);
            this.gbxThongTin.Size = new System.Drawing.Size(846, 176);
            this.gbxThongTin.TabIndex = 106;
            this.gbxThongTin.TabStop = false;
            this.gbxThongTin.Text = "Thông thể loại";
            // 
            // txtMaTheLoai
            // 
            this.txtMaTheLoai.Location = new System.Drawing.Point(132, 26);
            this.txtMaTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.Size = new System.Drawing.Size(276, 38);
            this.txtMaTheLoai.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên thể loại:";
            // 
            // txtTenTheLoai
            // 
            this.txtTenTheLoai.Location = new System.Drawing.Point(532, 26);
            this.txtTenTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Size = new System.Drawing.Size(310, 38);
            this.txtTenTheLoai.TabIndex = 9;
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Location = new System.Drawing.Point(13, 29);
            this.Tên.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(152, 31);
            this.Tên.TabIndex = 10;
            this.Tên.Text = "Mã thể loại :";
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
            this.btnSua.TabIndex = 111;
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
            this.btnXoa.TabIndex = 112;
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
            this.btnThem.TabIndex = 110;
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
            this.btnLamMoi.TabIndex = 114;
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
            this.btnQuayLai.TabIndex = 115;
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
            this.btnXatNhan.TabIndex = 113;
            this.btnXatNhan.Text = "Xác nhận";
            this.btnXatNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXatNhan.UseVisualStyleBackColor = false;
            this.btnXatNhan.Click += new System.EventHandler(this.btnXatNhan_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnTim.Location = new System.Drawing.Point(556, 27);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(70, 32);
            this.btnTim.TabIndex = 109;
            this.btnTim.Text = "Tìm...";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.ColumnHeadersHeight = 30;
            this.dgvTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_the_loai,
            this.the_loai,
            this.da_xoa});
            this.dgvTheLoai.Location = new System.Drawing.Point(24, 65);
            this.dgvTheLoai.MultiSelect = false;
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.ReadOnly = true;
            this.dgvTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheLoai.Size = new System.Drawing.Size(1236, 290);
            this.dgvTheLoai.TabIndex = 108;
            this.dgvTheLoai.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvTheLoai_MouseClick);
            // 
            // ma_the_loai
            // 
            this.ma_the_loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ma_the_loai.DataPropertyName = "ma_the_loai";
            this.ma_the_loai.HeaderText = "Mã loại";
            this.ma_the_loai.Name = "ma_the_loai";
            this.ma_the_loai.ReadOnly = true;
            // 
            // the_loai
            // 
            this.the_loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.the_loai.DataPropertyName = "the_loai";
            this.the_loai.HeaderText = "Tên loại";
            this.the_loai.Name = "the_loai";
            this.the_loai.ReadOnly = true;
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
            this.txtTim.Location = new System.Drawing.Point(24, 27);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(526, 38);
            this.txtTim.TabIndex = 107;
            this.txtTim.Tag = "";
            this.txtTim.Text = "Tên thể loại, mã thể loại";
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
            this.txtTim.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtTim_MouseUp);
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
            this.btnKhoiPhuc.TabIndex = 116;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Visible = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // FormTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 581);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.gbxThongTin);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXatNhan);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvTheLoai);
            this.Controls.Add(this.txtTim);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormTheLoai";
            this.Text = "FormTheLoai";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTheLoai_FormClosing);
            this.Load += new System.EventHandler(this.Formtheloai_Load);
            this.gbxThongTin.ResumeLayout(false);
            this.gbxThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxThongTin;
        private System.Windows.Forms.TextBox txtMaTheLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenTheLoai;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXatNhan;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_the_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn the_loai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn da_xoa;


    }
}