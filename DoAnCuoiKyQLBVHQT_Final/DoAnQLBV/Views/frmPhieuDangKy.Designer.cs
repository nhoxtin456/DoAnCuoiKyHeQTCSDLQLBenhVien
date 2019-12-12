namespace DoAnQLBV.Views
{
    partial class frmPhieuDangKy
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
            this.pnlDanhSachPhieuDK = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.grbDanhSachPhieuDK = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachPhieuDK = new System.Windows.Forms.DataGridView();
            this.MaPhieuDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbQuanLyPhieuDK = new System.Windows.Forms.GroupBox();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbMaBA = new System.Windows.Forms.ComboBox();
            this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMaBN = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbHide = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPhieuDK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDanhSachPhieuDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuDK)).BeginInit();
            this.grbQuanLyPhieuDK.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDanhSachPhieuDK
            // 
            this.pnlDanhSachPhieuDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDanhSachPhieuDK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDanhSachPhieuDK.Location = new System.Drawing.Point(494, 325);
            this.pnlDanhSachPhieuDK.Name = "pnlDanhSachPhieuDK";
            this.pnlDanhSachPhieuDK.Size = new System.Drawing.Size(1017, 302);
            this.pnlDanhSachPhieuDK.TabIndex = 122;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(789, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(279, 22);
            this.label12.TabIndex = 121;
            this.label12.Text = "DANH SÁCH PHIẾU ĐĂNG KÝ";
            // 
            // grbDanhSachPhieuDK
            // 
            this.grbDanhSachPhieuDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbDanhSachPhieuDK.Controls.Add(this.dgvDanhSachPhieuDK);
            this.grbDanhSachPhieuDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachPhieuDK.Location = new System.Drawing.Point(482, 54);
            this.grbDanhSachPhieuDK.Name = "grbDanhSachPhieuDK";
            this.grbDanhSachPhieuDK.Size = new System.Drawing.Size(1034, 250);
            this.grbDanhSachPhieuDK.TabIndex = 120;
            this.grbDanhSachPhieuDK.TabStop = false;
            // 
            // dgvDanhSachPhieuDK
            // 
            this.dgvDanhSachPhieuDK.AllowUserToAddRows = false;
            this.dgvDanhSachPhieuDK.AllowUserToDeleteRows = false;
            this.dgvDanhSachPhieuDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieuDK.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachPhieuDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuDK,
            this.Hide,
            this.MaNV,
            this.MaBN,
            this.MaKhoa,
            this.MaBA});
            this.dgvDanhSachPhieuDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachPhieuDK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachPhieuDK.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachPhieuDK.Name = "dgvDanhSachPhieuDK";
            this.dgvDanhSachPhieuDK.ReadOnly = true;
            this.dgvDanhSachPhieuDK.Size = new System.Drawing.Size(1028, 225);
            this.dgvDanhSachPhieuDK.TabIndex = 60;
            // 
            // MaPhieuDK
            // 
            this.MaPhieuDK.DataPropertyName = "MaPhieuDK";
            this.MaPhieuDK.HeaderText = "Mã Phiếu Đăng Ký";
            this.MaPhieuDK.Name = "MaPhieuDK";
            this.MaPhieuDK.ReadOnly = true;
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
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // MaBN
            // 
            this.MaBN.DataPropertyName = "MaBN";
            this.MaBN.HeaderText = "Mã Bệnh Nhân";
            this.MaBN.Name = "MaBN";
            this.MaBN.ReadOnly = true;
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            // 
            // MaBA
            // 
            this.MaBA.DataPropertyName = "MaBA";
            this.MaBA.HeaderText = "Mã Bệnh Án";
            this.MaBA.Name = "MaBA";
            this.MaBA.ReadOnly = true;
            // 
            // grbQuanLyPhieuDK
            // 
            this.grbQuanLyPhieuDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbQuanLyPhieuDK.Controls.Add(this.cmbMaNV);
            this.grbQuanLyPhieuDK.Controls.Add(this.label14);
            this.grbQuanLyPhieuDK.Controls.Add(this.cmbMaBA);
            this.grbQuanLyPhieuDK.Controls.Add(this.cmbMaKhoa);
            this.grbQuanLyPhieuDK.Controls.Add(this.label2);
            this.grbQuanLyPhieuDK.Controls.Add(this.label8);
            this.grbQuanLyPhieuDK.Controls.Add(this.cmbMaBN);
            this.grbQuanLyPhieuDK.Controls.Add(this.label11);
            this.grbQuanLyPhieuDK.Controls.Add(this.cmbHide);
            this.grbQuanLyPhieuDK.Controls.Add(this.label13);
            this.grbQuanLyPhieuDK.Controls.Add(this.label5);
            this.grbQuanLyPhieuDK.Controls.Add(this.txtMaPhieuDK);
            this.grbQuanLyPhieuDK.Controls.Add(this.label6);
            this.grbQuanLyPhieuDK.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuanLyPhieuDK.Location = new System.Drawing.Point(2, 54);
            this.grbQuanLyPhieuDK.Name = "grbQuanLyPhieuDK";
            this.grbQuanLyPhieuDK.Size = new System.Drawing.Size(476, 403);
            this.grbQuanLyPhieuDK.TabIndex = 113;
            this.grbQuanLyPhieuDK.TabStop = false;
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(102, 165);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(137, 27);
            this.cmbMaNV.TabIndex = 101;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-1, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 19);
            this.label14.TabIndex = 100;
            this.label14.Text = "Mã NV :";
            // 
            // cmbMaBA
            // 
            this.cmbMaBA.FormattingEnabled = true;
            this.cmbMaBA.Location = new System.Drawing.Point(340, 210);
            this.cmbMaBA.Name = "cmbMaBA";
            this.cmbMaBA.Size = new System.Drawing.Size(137, 27);
            this.cmbMaBA.TabIndex = 99;
            // 
            // cmbMaKhoa
            // 
            this.cmbMaKhoa.FormattingEnabled = true;
            this.cmbMaKhoa.Location = new System.Drawing.Point(340, 138);
            this.cmbMaKhoa.Name = "cmbMaKhoa";
            this.cmbMaKhoa.Size = new System.Drawing.Size(137, 27);
            this.cmbMaKhoa.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 98;
            this.label2.Text = "Mã BA :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 98;
            this.label8.Text = "Mã Khoa :";
            // 
            // cmbMaBN
            // 
            this.cmbMaBN.FormattingEnabled = true;
            this.cmbMaBN.Location = new System.Drawing.Point(337, 57);
            this.cmbMaBN.Name = "cmbMaBN";
            this.cmbMaBN.Size = new System.Drawing.Size(137, 27);
            this.cmbMaBN.TabIndex = 97;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 19);
            this.label11.TabIndex = 96;
            this.label11.Text = "Mã BN :";
            // 
            // cmbHide
            // 
            this.cmbHide.FormattingEnabled = true;
            this.cmbHide.Location = new System.Drawing.Point(108, 102);
            this.cmbHide.Name = "cmbHide";
            this.cmbHide.Size = new System.Drawing.Size(137, 27);
            this.cmbHide.TabIndex = 94;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-1, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 19);
            this.label13.TabIndex = 93;
            this.label13.Text = "Tình Trạng:";
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
            // txtMaPhieuDK
            // 
            this.txtMaPhieuDK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaPhieuDK.Enabled = false;
            this.txtMaPhieuDK.Location = new System.Drawing.Point(120, 57);
            this.txtMaPhieuDK.Name = "txtMaPhieuDK";
            this.txtMaPhieuDK.Size = new System.Drawing.Size(125, 27);
            this.txtMaPhieuDK.TabIndex = 92;
            this.txtMaPhieuDK.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 91;
            this.label6.Text = "Mã Phiếu ĐK";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageIndex = 3;
            this.btnLuu.Location = new System.Drawing.Point(290, 499);
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
            this.btnSua.Location = new System.Drawing.Point(104, 499);
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
            this.btnXoa.Location = new System.Drawing.Point(194, 499);
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
            this.btnHuy.Location = new System.Drawing.Point(377, 499);
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
            this.btnThemMoi.Location = new System.Drawing.Point(4, 499);
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
            this.btnHide.Location = new System.Drawing.Point(224, 568);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(90, 49);
            this.btnHide.TabIndex = 111;
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
            this.btnFind.Location = new System.Drawing.Point(104, 568);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(114, 49);
            this.btnFind.TabIndex = 112;
            this.btnFind.Text = "Tìm kiếm ";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(122, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 22);
            this.label1.TabIndex = 117;
            this.label1.Text = "QUẢN LÝ PHIẾU ĐĂNG KÝ";
            // 
            // frmPhieuDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 651);
            this.Controls.Add(this.pnlDanhSachPhieuDK);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grbDanhSachPhieuDK);
            this.Controls.Add(this.grbQuanLyPhieuDK);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Name = "frmPhieuDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhieuDangKy";
            this.Load += new System.EventHandler(this.frmPhieuDangKy_Load);
            this.grbDanhSachPhieuDK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuDK)).EndInit();
            this.grbQuanLyPhieuDK.ResumeLayout(false);
            this.grbQuanLyPhieuDK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDanhSachPhieuDK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbDanhSachPhieuDK;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuDK;
        private System.Windows.Forms.GroupBox grbQuanLyPhieuDK;
        private System.Windows.Forms.ComboBox cmbHide;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaPhieuDK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDK;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Hide;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBA;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbMaKhoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMaBN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbMaBA;
        private System.Windows.Forms.Label label2;
    }
}