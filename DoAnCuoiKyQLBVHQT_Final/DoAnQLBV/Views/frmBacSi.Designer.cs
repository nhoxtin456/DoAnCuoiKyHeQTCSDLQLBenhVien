namespace DoAnQLBV.Views
{
    partial class frmBacSi
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
            this.pnlDanhSachBS = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.grbDanhSachBS = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachBS = new System.Windows.Forms.DataGridView();
            this.MaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbQuanLyBS = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbHide = new System.Windows.Forms.ComboBox();
            this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
            this.cmbGioiTinhBS = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaySinhBS = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoBS = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtTenBS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDanhSachBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBS)).BeginInit();
            this.grbQuanLyBS.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDanhSachBS
            // 
            this.pnlDanhSachBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDanhSachBS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDanhSachBS.Location = new System.Drawing.Point(498, 331);
            this.pnlDanhSachBS.Name = "pnlDanhSachBS";
            this.pnlDanhSachBS.Size = new System.Drawing.Size(1017, 302);
            this.pnlDanhSachBS.TabIndex = 110;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(793, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 22);
            this.label12.TabIndex = 109;
            this.label12.Text = "DANH SÁCH BÁC SĨ";
            // 
            // grbDanhSachBS
            // 
            this.grbDanhSachBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbDanhSachBS.Controls.Add(this.dgvDanhSachBS);
            this.grbDanhSachBS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachBS.Location = new System.Drawing.Point(486, 60);
            this.grbDanhSachBS.Name = "grbDanhSachBS";
            this.grbDanhSachBS.Size = new System.Drawing.Size(1034, 250);
            this.grbDanhSachBS.TabIndex = 108;
            this.grbDanhSachBS.TabStop = false;
            // 
            // dgvDanhSachBS
            // 
            this.dgvDanhSachBS.AllowUserToAddRows = false;
            this.dgvDanhSachBS.AllowUserToDeleteRows = false;
            this.dgvDanhSachBS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBS.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBS,
            this.HoBS,
            this.TenBS,
            this.NgaySinh,
            this.GioiTinh,
            this.ChucVu,
            this.MaKhoa,
            this.Hide});
            this.dgvDanhSachBS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachBS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachBS.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachBS.Name = "dgvDanhSachBS";
            this.dgvDanhSachBS.ReadOnly = true;
            this.dgvDanhSachBS.Size = new System.Drawing.Size(1028, 225);
            this.dgvDanhSachBS.TabIndex = 60;
            // 
            // MaBS
            // 
            this.MaBS.DataPropertyName = "MaBS";
            this.MaBS.HeaderText = "Mã Bác Sĩ";
            this.MaBS.Name = "MaBS";
            this.MaBS.ReadOnly = true;
            // 
            // HoBS
            // 
            this.HoBS.DataPropertyName = "HoBS";
            this.HoBS.HeaderText = "Họ Bác Sĩ";
            this.HoBS.Name = "HoBS";
            this.HoBS.ReadOnly = true;
            // 
            // TenBS
            // 
            this.TenBS.DataPropertyName = "TenBS";
            this.TenBS.HeaderText = "Tên Bác Sĩ";
            this.TenBS.Name = "TenBS";
            this.TenBS.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            // 
            // Hide
            // 
            this.Hide.DataPropertyName = "Hide";
            this.Hide.HeaderText = "Tình Trạng";
            this.Hide.Name = "Hide";
            this.Hide.ReadOnly = true;
            // 
            // grbQuanLyBS
            // 
            this.grbQuanLyBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbQuanLyBS.Controls.Add(this.label10);
            this.grbQuanLyBS.Controls.Add(this.cmbHide);
            this.grbQuanLyBS.Controls.Add(this.cmbMaKhoa);
            this.grbQuanLyBS.Controls.Add(this.cmbGioiTinhBS);
            this.grbQuanLyBS.Controls.Add(this.label13);
            this.grbQuanLyBS.Controls.Add(this.label4);
            this.grbQuanLyBS.Controls.Add(this.dtpNgaySinhBS);
            this.grbQuanLyBS.Controls.Add(this.label9);
            this.grbQuanLyBS.Controls.Add(this.label5);
            this.grbQuanLyBS.Controls.Add(this.label3);
            this.grbQuanLyBS.Controls.Add(this.txtHoBS);
            this.grbQuanLyBS.Controls.Add(this.txtChucVu);
            this.grbQuanLyBS.Controls.Add(this.txtTenBS);
            this.grbQuanLyBS.Controls.Add(this.label7);
            this.grbQuanLyBS.Controls.Add(this.label2);
            this.grbQuanLyBS.Controls.Add(this.label8);
            this.grbQuanLyBS.Controls.Add(this.txtMaBS);
            this.grbQuanLyBS.Controls.Add(this.label6);
            this.grbQuanLyBS.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuanLyBS.Location = new System.Drawing.Point(6, 60);
            this.grbQuanLyBS.Name = "grbQuanLyBS";
            this.grbQuanLyBS.Size = new System.Drawing.Size(476, 269);
            this.grbQuanLyBS.TabIndex = 101;
            this.grbQuanLyBS.TabStop = false;
            this.grbQuanLyBS.Enter += new System.EventHandler(this.grbQuanLyBS_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 95;
            this.label10.Text = "Chức Vụ:";
            // 
            // cmbHide
            // 
            this.cmbHide.FormattingEnabled = true;
            this.cmbHide.Location = new System.Drawing.Point(323, 195);
            this.cmbHide.Name = "cmbHide";
            this.cmbHide.Size = new System.Drawing.Size(137, 27);
            this.cmbHide.TabIndex = 94;
            // 
            // cmbMaKhoa
            // 
            this.cmbMaKhoa.FormattingEnabled = true;
            this.cmbMaKhoa.Location = new System.Drawing.Point(328, 147);
            this.cmbMaKhoa.Name = "cmbMaKhoa";
            this.cmbMaKhoa.Size = new System.Drawing.Size(137, 27);
            this.cmbMaKhoa.TabIndex = 94;
            this.cmbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbGioiTinhBS
            // 
            this.cmbGioiTinhBS.FormattingEnabled = true;
            this.cmbGioiTinhBS.Location = new System.Drawing.Point(319, 57);
            this.cmbGioiTinhBS.Name = "cmbGioiTinhBS";
            this.cmbGioiTinhBS.Size = new System.Drawing.Size(137, 27);
            this.cmbGioiTinhBS.TabIndex = 94;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(233, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 19);
            this.label13.TabIndex = 93;
            this.label13.Text = "Tình Trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 93;
            this.label4.Text = "Giới tính:";
            // 
            // dtpNgaySinhBS
            // 
            this.dtpNgaySinhBS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhBS.Location = new System.Drawing.Point(95, 190);
            this.dtpNgaySinhBS.Name = "dtpNgaySinhBS";
            this.dtpNgaySinhBS.Size = new System.Drawing.Size(125, 27);
            this.dtpNgaySinhBS.TabIndex = 81;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 22);
            this.label5.TabIndex = 85;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 88;
            this.label3.Text = "Ngày sinh :";
            // 
            // txtHoBS
            // 
            this.txtHoBS.Location = new System.Drawing.Point(95, 122);
            this.txtHoBS.Name = "txtHoBS";
            this.txtHoBS.Size = new System.Drawing.Size(125, 27);
            this.txtHoBS.TabIndex = 80;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(319, 93);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(125, 27);
            this.txtChucVu.TabIndex = 80;
            // 
            // txtTenBS
            // 
            this.txtTenBS.Location = new System.Drawing.Point(95, 150);
            this.txtTenBS.Name = "txtTenBS";
            this.txtTenBS.Size = new System.Drawing.Size(125, 27);
            this.txtTenBS.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 86;
            this.label7.Text = "Họ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 86;
            this.label2.Text = "Tên :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 91;
            this.label8.Text = "Mã Khoa :";
            // 
            // txtMaBS
            // 
            this.txtMaBS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaBS.Enabled = false;
            this.txtMaBS.Location = new System.Drawing.Point(90, 56);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(125, 27);
            this.txtMaBS.TabIndex = 92;
            this.txtMaBS.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 91;
            this.label6.Text = "Mã Bác Sĩ :";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageIndex = 3;
            this.btnLuu.Location = new System.Drawing.Point(300, 374);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 50);
            this.btnLuu.TabIndex = 102;
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
            this.btnSua.Location = new System.Drawing.Point(114, 374);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 50);
            this.btnSua.TabIndex = 103;
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
            this.btnXoa.Location = new System.Drawing.Point(204, 374);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 50);
            this.btnXoa.TabIndex = 104;
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
            this.btnHuy.Location = new System.Drawing.Point(387, 374);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 50);
            this.btnHuy.TabIndex = 106;
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
            this.btnThemMoi.Location = new System.Drawing.Point(14, 374);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(103, 50);
            this.btnThemMoi.TabIndex = 107;
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
            this.btnHide.Location = new System.Drawing.Point(234, 443);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(90, 49);
            this.btnHide.TabIndex = 99;
            this.btnHide.Text = "Ẩn ";
            this.btnHide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHide.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.Control;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.ImageIndex = 5;
            this.btnFind.Location = new System.Drawing.Point(114, 443);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(114, 49);
            this.btnFind.TabIndex = 100;
            this.btnFind.Text = "Tìm kiếm ";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(126, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 22);
            this.label1.TabIndex = 105;
            this.label1.Text = "QUẢN LÝ BÁC SĨ";
            // 
            // frmBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 663);
            this.Controls.Add(this.pnlDanhSachBS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grbDanhSachBS);
            this.Controls.Add(this.grbQuanLyBS);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Name = "frmBacSi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBacSi";
            this.Load += new System.EventHandler(this.frmBacSi_Load);
            this.grbDanhSachBS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBS)).EndInit();
            this.grbQuanLyBS.ResumeLayout(false);
            this.grbQuanLyBS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDanhSachBS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbDanhSachBS;
        private System.Windows.Forms.DataGridView dgvDanhSachBS;
        private System.Windows.Forms.GroupBox grbQuanLyBS;
        private System.Windows.Forms.ComboBox cmbHide;
        private System.Windows.Forms.ComboBox cmbGioiTinhBS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhBS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoBS;
        private System.Windows.Forms.TextBox txtTenBS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Hide;
        private System.Windows.Forms.ComboBox cmbMaKhoa;
    }
}