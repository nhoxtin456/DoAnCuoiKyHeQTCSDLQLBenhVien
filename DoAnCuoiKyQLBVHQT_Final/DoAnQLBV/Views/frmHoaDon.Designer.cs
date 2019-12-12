namespace DoAnQLBV.Views
{
    partial class frmHoaDon
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
            this.label12 = new System.Windows.Forms.Label();
            this.grbDanhSachHD = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThanhToanHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaHDPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaHDXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaHDThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaHDAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbQuanLyHD = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbHide = new System.Windows.Forms.ComboBox();
            this.cmbMaBA = new System.Windows.Forms.ComboBox();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTTHD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaHD = new System.Windows.Forms.TextBox();
            this.txtTenHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dgvHoaDonTong = new System.Windows.Forms.DataGridView();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.dgvGiaHD = new System.Windows.Forms.DataGridView();
            this.txtGiaHDPhong = new System.Windows.Forms.TextBox();
            this.lblGiaHDPhong = new System.Windows.Forms.Label();
            this.grbDanhSachHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHD)).BeginInit();
            this.grbQuanLyHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonTong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(781, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 22);
            this.label12.TabIndex = 121;
            this.label12.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // grbDanhSachHD
            // 
            this.grbDanhSachHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbDanhSachHD.Controls.Add(this.dgvDanhSachHD);
            this.grbDanhSachHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachHD.Location = new System.Drawing.Point(474, 61);
            this.grbDanhSachHD.Name = "grbDanhSachHD";
            this.grbDanhSachHD.Size = new System.Drawing.Size(1136, 250);
            this.grbDanhSachHD.TabIndex = 120;
            this.grbDanhSachHD.TabStop = false;
            // 
            // dgvDanhSachHD
            // 
            this.dgvDanhSachHD.AllowUserToAddRows = false;
            this.dgvDanhSachHD.AllowUserToDeleteRows = false;
            this.dgvDanhSachHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHD.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.TenHD,
            this.GiaHD,
            this.Hide,
            this.MaNV,
            this.MaBA,
            this.NgayLapHD,
            this.NgayThanhToanHD,
            this.ThoiGian,
            this.GiaHDPhong,
            this.GiaHDXN,
            this.GiaHDThuoc,
            this.GiaHDAll});
            this.dgvDanhSachHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachHD.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachHD.Name = "dgvDanhSachHD";
            this.dgvDanhSachHD.ReadOnly = true;
            this.dgvDanhSachHD.Size = new System.Drawing.Size(1130, 225);
            this.dgvDanhSachHD.TabIndex = 60;
            this.dgvDanhSachHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHD_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            // 
            // TenHD
            // 
            this.TenHD.DataPropertyName = "TenHD";
            this.TenHD.HeaderText = "Tên HD";
            this.TenHD.Name = "TenHD";
            this.TenHD.ReadOnly = true;
            // 
            // GiaHD
            // 
            this.GiaHD.DataPropertyName = "GiaHD";
            this.GiaHD.HeaderText = "Giá HD";
            this.GiaHD.Name = "GiaHD";
            this.GiaHD.ReadOnly = true;
            // 
            // Hide
            // 
            this.Hide.DataPropertyName = "Hide";
            this.Hide.HeaderText = "Tình Trạng";
            this.Hide.Name = "Hide";
            this.Hide.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // MaBA
            // 
            this.MaBA.DataPropertyName = "MaBA";
            this.MaBA.HeaderText = "Mã BA";
            this.MaBA.Name = "MaBA";
            this.MaBA.ReadOnly = true;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.DataPropertyName = "NgayLapHD";
            this.NgayLapHD.HeaderText = "Ngày Lập HD";
            this.NgayLapHD.Name = "NgayLapHD";
            this.NgayLapHD.ReadOnly = true;
            // 
            // NgayThanhToanHD
            // 
            this.NgayThanhToanHD.DataPropertyName = "NgayThanhToanHD";
            this.NgayThanhToanHD.HeaderText = "Ngày TT HD";
            this.NgayThanhToanHD.Name = "NgayThanhToanHD";
            this.NgayThanhToanHD.ReadOnly = true;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời Gian";
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            // 
            // GiaHDPhong
            // 
            this.GiaHDPhong.DataPropertyName = "GiaHDPhong";
            this.GiaHDPhong.HeaderText = "Giá HD Phòng";
            this.GiaHDPhong.Name = "GiaHDPhong";
            this.GiaHDPhong.ReadOnly = true;
            // 
            // GiaHDXN
            // 
            this.GiaHDXN.DataPropertyName = "GiaHDXN";
            this.GiaHDXN.HeaderText = "Giá HD XN";
            this.GiaHDXN.Name = "GiaHDXN";
            this.GiaHDXN.ReadOnly = true;
            // 
            // GiaHDThuoc
            // 
            this.GiaHDThuoc.DataPropertyName = "GiaHDThuoc";
            this.GiaHDThuoc.HeaderText = "Giá HD Thuốc";
            this.GiaHDThuoc.Name = "GiaHDThuoc";
            this.GiaHDThuoc.ReadOnly = true;
            // 
            // GiaHDAll
            // 
            this.GiaHDAll.DataPropertyName = "GiaHDAll";
            this.GiaHDAll.HeaderText = "Giá HD Tổng";
            this.GiaHDAll.Name = "GiaHDAll";
            this.GiaHDAll.ReadOnly = true;
            // 
            // grbQuanLyHD
            // 
            this.grbQuanLyHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbQuanLyHD.Controls.Add(this.txtGiaHDPhong);
            this.grbQuanLyHD.Controls.Add(this.lblGiaHDPhong);
            this.grbQuanLyHD.Controls.Add(this.label10);
            this.grbQuanLyHD.Controls.Add(this.cmbHide);
            this.grbQuanLyHD.Controls.Add(this.cmbMaBA);
            this.grbQuanLyHD.Controls.Add(this.cmbMaNV);
            this.grbQuanLyHD.Controls.Add(this.label13);
            this.grbQuanLyHD.Controls.Add(this.label4);
            this.grbQuanLyHD.Controls.Add(this.dtpThoiGian);
            this.grbQuanLyHD.Controls.Add(this.dtpNgayTTHD);
            this.grbQuanLyHD.Controls.Add(this.dtpNgayLapHD);
            this.grbQuanLyHD.Controls.Add(this.label9);
            this.grbQuanLyHD.Controls.Add(this.label11);
            this.grbQuanLyHD.Controls.Add(this.label8);
            this.grbQuanLyHD.Controls.Add(this.label5);
            this.grbQuanLyHD.Controls.Add(this.label3);
            this.grbQuanLyHD.Controls.Add(this.txtGiaHD);
            this.grbQuanLyHD.Controls.Add(this.txtTenHD);
            this.grbQuanLyHD.Controls.Add(this.label7);
            this.grbQuanLyHD.Controls.Add(this.label2);
            this.grbQuanLyHD.Controls.Add(this.txtMaHD);
            this.grbQuanLyHD.Controls.Add(this.label6);
            this.grbQuanLyHD.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuanLyHD.Location = new System.Drawing.Point(-6, 61);
            this.grbQuanLyHD.Name = "grbQuanLyHD";
            this.grbQuanLyHD.Size = new System.Drawing.Size(476, 291);
            this.grbQuanLyHD.TabIndex = 113;
            this.grbQuanLyHD.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 95;
            this.label10.Text = "Mã BA:";
            // 
            // cmbHide
            // 
            this.cmbHide.FormattingEnabled = true;
            this.cmbHide.Location = new System.Drawing.Point(90, 186);
            this.cmbHide.Name = "cmbHide";
            this.cmbHide.Size = new System.Drawing.Size(137, 27);
            this.cmbHide.TabIndex = 94;
            // 
            // cmbMaBA
            // 
            this.cmbMaBA.FormattingEnabled = true;
            this.cmbMaBA.Location = new System.Drawing.Point(310, 98);
            this.cmbMaBA.Name = "cmbMaBA";
            this.cmbMaBA.Size = new System.Drawing.Size(137, 27);
            this.cmbMaBA.TabIndex = 94;
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(310, 56);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(137, 27);
            this.cmbMaNV.TabIndex = 94;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 19);
            this.label13.TabIndex = 93;
            this.label13.Text = "Tình Trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 93;
            this.label4.Text = "Mã NV:";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(340, 222);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(125, 27);
            this.dtpThoiGian.TabIndex = 81;
            // 
            // dtpNgayTTHD
            // 
            this.dtpNgayTTHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTTHD.Location = new System.Drawing.Point(340, 183);
            this.dtpNgayTTHD.Name = "dtpNgayTTHD";
            this.dtpNgayTTHD.Size = new System.Drawing.Size(125, 27);
            this.dtpNgayTTHD.TabIndex = 81;
            // 
            // dtpNgayLapHD
            // 
            this.dtpNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapHD.Location = new System.Drawing.Point(340, 141);
            this.dtpNgayLapHD.Name = "dtpNgayLapHD";
            this.dtpNgayLapHD.Size = new System.Drawing.Size(125, 27);
            this.dtpNgayLapHD.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 22);
            this.label9.TabIndex = 85;
            this.label9.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 19);
            this.label11.TabIndex = 88;
            this.label11.Text = "Thời Gian:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 88;
            this.label8.Text = "Ngày TT HD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-4, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 22);
            this.label5.TabIndex = 85;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 88;
            this.label3.Text = "Ngày Lập HD";
            // 
            // txtGiaHD
            // 
            this.txtGiaHD.Location = new System.Drawing.Point(84, 144);
            this.txtGiaHD.Name = "txtGiaHD";
            this.txtGiaHD.Size = new System.Drawing.Size(125, 27);
            this.txtGiaHD.TabIndex = 80;
            // 
            // txtTenHD
            // 
            this.txtTenHD.Location = new System.Drawing.Point(84, 98);
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(125, 27);
            this.txtTenHD.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 86;
            this.label7.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 86;
            this.label2.Text = "Tên :";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(84, 56);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(125, 27);
            this.txtMaHD.TabIndex = 92;
            this.txtMaHD.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 91;
            this.label6.Text = "Mã HD :";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageIndex = 3;
            this.btnLuu.Location = new System.Drawing.Point(288, 375);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 50);
            this.btnLuu.TabIndex = 114;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageIndex = 2;
            this.btnSua.Location = new System.Drawing.Point(102, 375);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 50);
            this.btnSua.TabIndex = 115;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageIndex = 1;
            this.btnXoa.Location = new System.Drawing.Point(192, 375);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 50);
            this.btnXoa.TabIndex = 116;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.ImageIndex = 4;
            this.btnHuy.Location = new System.Drawing.Point(375, 375);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 50);
            this.btnHuy.TabIndex = 118;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.ImageIndex = 0;
            this.btnThemMoi.Location = new System.Drawing.Point(2, 375);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(103, 50);
            this.btnThemMoi.TabIndex = 119;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.SystemColors.Control;
            this.btnHide.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHide.ImageIndex = 6;
            this.btnHide.Location = new System.Drawing.Point(222, 444);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(90, 49);
            this.btnHide.TabIndex = 111;
            this.btnHide.Text = "Ẩn ";
            this.btnHide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.Control;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.ImageIndex = 5;
            this.btnFind.Location = new System.Drawing.Point(102, 444);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(114, 49);
            this.btnFind.TabIndex = 112;
            this.btnFind.Text = "Tìm kiếm ";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(114, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 117;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(369, 500);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(74, 19);
            this.lblTongTien.TabIndex = 123;
            this.lblTongTien.Text = "labelTong";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(288, 499);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 124;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click_1);
            // 
            // dgvHoaDonTong
            // 
            this.dgvHoaDonTong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonTong.Location = new System.Drawing.Point(468, 317);
            this.dgvHoaDonTong.Name = "dgvHoaDonTong";
            this.dgvHoaDonTong.Size = new System.Drawing.Size(1142, 398);
            this.dgvHoaDonTong.TabIndex = 126;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(318, 458);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 127;
            this.btnUndo.Text = "UNDO";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(382, 458);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(75, 23);
            this.btnRedo.TabIndex = 127;
            this.btnRedo.Text = "REDO";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // dgvGiaHD
            // 
            this.dgvGiaHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaHD.Location = new System.Drawing.Point(2, 521);
            this.dgvGiaHD.Name = "dgvGiaHD";
            this.dgvGiaHD.Size = new System.Drawing.Size(455, 237);
            this.dgvGiaHD.TabIndex = 128;
            // 
            // txtGiaHDPhong
            // 
            this.txtGiaHDPhong.Location = new System.Drawing.Point(8, 250);
            this.txtGiaHDPhong.Name = "txtGiaHDPhong";
            this.txtGiaHDPhong.Size = new System.Drawing.Size(152, 27);
            this.txtGiaHDPhong.TabIndex = 96;
            // 
            // lblGiaHDPhong
            // 
            this.lblGiaHDPhong.AutoSize = true;
            this.lblGiaHDPhong.Location = new System.Drawing.Point(10, 228);
            this.lblGiaHDPhong.Name = "lblGiaHDPhong";
            this.lblGiaHDPhong.Size = new System.Drawing.Size(113, 19);
            this.lblGiaHDPhong.TabIndex = 97;
            this.lblGiaHDPhong.Text = "Giá HD Phòng:";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 782);
            this.Controls.Add(this.dgvGiaHD);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.dgvHoaDonTong);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grbDanhSachHD);
            this.Controls.Add(this.grbQuanLyHD);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.grbDanhSachHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHD)).EndInit();
            this.grbQuanLyHD.ResumeLayout(false);
            this.grbQuanLyHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonTong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbDanhSachHD;
        private System.Windows.Forms.DataGridView dgvDanhSachHD;
        private System.Windows.Forms.GroupBox grbQuanLyHD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbHide;
        private System.Windows.Forms.ComboBox cmbMaBA;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaHD;
        private System.Windows.Forms.TextBox txtTenHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayTTHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dgvHoaDonTong;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaHD;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Hide;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhToanHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaHDPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaHDXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaHDThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaHDAll;
        private System.Windows.Forms.DataGridView dgvGiaHD;
        private System.Windows.Forms.TextBox txtGiaHDPhong;
        private System.Windows.Forms.Label lblGiaHDPhong;
    }
}