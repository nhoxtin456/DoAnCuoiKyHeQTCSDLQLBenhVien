namespace DoAnQLBV.Views
{
    partial class frmXetNghiem
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
            this.pnlDanhSachXN = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.grbDanhSachXN = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachXN = new System.Windows.Forms.DataGridView();
            this.MaXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbQuanLyXN = new System.Windows.Forms.GroupBox();
            this.cmbMaLoaiXN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHide = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenXN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaXN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDanhSachXN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXN)).BeginInit();
            this.grbQuanLyXN.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDanhSachXN
            // 
            this.pnlDanhSachXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDanhSachXN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDanhSachXN.Location = new System.Drawing.Point(495, 337);
            this.pnlDanhSachXN.Name = "pnlDanhSachXN";
            this.pnlDanhSachXN.Size = new System.Drawing.Size(1017, 302);
            this.pnlDanhSachXN.TabIndex = 134;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(790, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(252, 22);
            this.label12.TabIndex = 133;
            this.label12.Text = "DANH SÁCH XÉT NGHIỆM";
            // 
            // grbDanhSachXN
            // 
            this.grbDanhSachXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbDanhSachXN.Controls.Add(this.dgvDanhSachXN);
            this.grbDanhSachXN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachXN.Location = new System.Drawing.Point(483, 66);
            this.grbDanhSachXN.Name = "grbDanhSachXN";
            this.grbDanhSachXN.Size = new System.Drawing.Size(1034, 250);
            this.grbDanhSachXN.TabIndex = 132;
            this.grbDanhSachXN.TabStop = false;
            // 
            // dgvDanhSachXN
            // 
            this.dgvDanhSachXN.AllowUserToAddRows = false;
            this.dgvDanhSachXN.AllowUserToDeleteRows = false;
            this.dgvDanhSachXN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachXN.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachXN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXN,
            this.TenXN,
            this.MaLoaiXN,
            this.Hide});
            this.dgvDanhSachXN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachXN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachXN.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachXN.Name = "dgvDanhSachXN";
            this.dgvDanhSachXN.ReadOnly = true;
            this.dgvDanhSachXN.Size = new System.Drawing.Size(1028, 225);
            this.dgvDanhSachXN.TabIndex = 60;
            // 
            // MaXN
            // 
            this.MaXN.DataPropertyName = "MaXN";
            this.MaXN.HeaderText = "Mã Xét Nghiệm";
            this.MaXN.Name = "MaXN";
            this.MaXN.ReadOnly = true;
            // 
            // TenXN
            // 
            this.TenXN.DataPropertyName = "TenXN";
            this.TenXN.HeaderText = "Tên XN";
            this.TenXN.Name = "TenXN";
            this.TenXN.ReadOnly = true;
            // 
            // MaLoaiXN
            // 
            this.MaLoaiXN.DataPropertyName = "MaLoaiXN";
            this.MaLoaiXN.HeaderText = "Mã Loại XN";
            this.MaLoaiXN.Name = "MaLoaiXN";
            this.MaLoaiXN.ReadOnly = true;
            // 
            // Hide
            // 
            this.Hide.DataPropertyName = "Hide";
            this.Hide.HeaderText = "Tình Trạng";
            this.Hide.Name = "Hide";
            this.Hide.ReadOnly = true;
            // 
            // grbQuanLyXN
            // 
            this.grbQuanLyXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbQuanLyXN.Controls.Add(this.cmbMaLoaiXN);
            this.grbQuanLyXN.Controls.Add(this.label2);
            this.grbQuanLyXN.Controls.Add(this.cmbHide);
            this.grbQuanLyXN.Controls.Add(this.label13);
            this.grbQuanLyXN.Controls.Add(this.txtTenXN);
            this.grbQuanLyXN.Controls.Add(this.label7);
            this.grbQuanLyXN.Controls.Add(this.txtMaXN);
            this.grbQuanLyXN.Controls.Add(this.label6);
            this.grbQuanLyXN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuanLyXN.Location = new System.Drawing.Point(3, 66);
            this.grbQuanLyXN.Name = "grbQuanLyXN";
            this.grbQuanLyXN.Size = new System.Drawing.Size(476, 269);
            this.grbQuanLyXN.TabIndex = 125;
            this.grbQuanLyXN.TabStop = false;
            // 
            // cmbMaLoaiXN
            // 
            this.cmbMaLoaiXN.FormattingEnabled = true;
            this.cmbMaLoaiXN.Location = new System.Drawing.Point(135, 171);
            this.cmbMaLoaiXN.Name = "cmbMaLoaiXN";
            this.cmbMaLoaiXN.Size = new System.Drawing.Size(137, 27);
            this.cmbMaLoaiXN.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 101;
            this.label2.Text = "Mã Loại XN:";
            // 
            // cmbHide
            // 
            this.cmbHide.FormattingEnabled = true;
            this.cmbHide.Location = new System.Drawing.Point(102, 219);
            this.cmbHide.Name = "cmbHide";
            this.cmbHide.Size = new System.Drawing.Size(137, 27);
            this.cmbHide.TabIndex = 100;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-2, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 19);
            this.label13.TabIndex = 99;
            this.label13.Text = "Tình Trạng:";
            // 
            // txtTenXN
            // 
            this.txtTenXN.Location = new System.Drawing.Point(135, 111);
            this.txtTenXN.Name = "txtTenXN";
            this.txtTenXN.Size = new System.Drawing.Size(125, 27);
            this.txtTenXN.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 97;
            this.label7.Text = "Tên XN:";
            // 
            // txtMaXN
            // 
            this.txtMaXN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaXN.Enabled = false;
            this.txtMaXN.Location = new System.Drawing.Point(124, 60);
            this.txtMaXN.Name = "txtMaXN";
            this.txtMaXN.Size = new System.Drawing.Size(125, 27);
            this.txtMaXN.TabIndex = 92;
            this.txtMaXN.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 91;
            this.label6.Text = "Mã XN:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageIndex = 3;
            this.btnLuu.Location = new System.Drawing.Point(297, 380);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 50);
            this.btnLuu.TabIndex = 126;
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
            this.btnSua.Location = new System.Drawing.Point(111, 380);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 50);
            this.btnSua.TabIndex = 127;
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
            this.btnXoa.Location = new System.Drawing.Point(201, 380);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 50);
            this.btnXoa.TabIndex = 128;
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
            this.btnHuy.Location = new System.Drawing.Point(384, 380);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 50);
            this.btnHuy.TabIndex = 130;
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
            this.btnThemMoi.Location = new System.Drawing.Point(11, 380);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(103, 50);
            this.btnThemMoi.TabIndex = 131;
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
            this.btnHide.Location = new System.Drawing.Point(231, 449);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(90, 49);
            this.btnHide.TabIndex = 123;
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
            this.btnFind.Location = new System.Drawing.Point(111, 449);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(114, 49);
            this.btnFind.TabIndex = 124;
            this.btnFind.Text = "Tìm kiếm ";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(123, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 22);
            this.label1.TabIndex = 129;
            this.label1.Text = "QUẢN LÝ XÉT NGHIỆM";
            // 
            // frmXetNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 674);
            this.Controls.Add(this.pnlDanhSachXN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grbDanhSachXN);
            this.Controls.Add(this.grbQuanLyXN);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Name = "frmXetNghiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXetNghiem";
            this.Load += new System.EventHandler(this.frmXetNghiem_Load);
            this.grbDanhSachXN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXN)).EndInit();
            this.grbQuanLyXN.ResumeLayout(false);
            this.grbQuanLyXN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDanhSachXN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbDanhSachXN;
        private System.Windows.Forms.DataGridView dgvDanhSachXN;
        private System.Windows.Forms.GroupBox grbQuanLyXN;
        private System.Windows.Forms.ComboBox cmbMaLoaiXN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHide;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenXN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaXN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiXN;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Hide;
    }
}