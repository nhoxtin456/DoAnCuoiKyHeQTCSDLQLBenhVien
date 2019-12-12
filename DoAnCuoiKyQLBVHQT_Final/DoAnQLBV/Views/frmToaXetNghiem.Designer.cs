namespace DoAnQLBV.Views
{
    partial class frmToaXetNghiem
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
            this.pnlDanhSachToaXN = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.grbDanhSachToaXN = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachToaXN = new System.Windows.Forms.DataGridView();
            this.MaXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbQuanLyToaXN = new System.Windows.Forms.GroupBox();
            this.dtpNgayXN = new System.Windows.Forms.DateTimePicker();
            this.cmbMaBA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaXN = new System.Windows.Forms.ComboBox();
            this.cmbHide = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDanhSachToaXN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachToaXN)).BeginInit();
            this.grbQuanLyToaXN.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDanhSachToaXN
            // 
            this.pnlDanhSachToaXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDanhSachToaXN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDanhSachToaXN.Location = new System.Drawing.Point(491, 335);
            this.pnlDanhSachToaXN.Name = "pnlDanhSachToaXN";
            this.pnlDanhSachToaXN.Size = new System.Drawing.Size(1017, 302);
            this.pnlDanhSachToaXN.TabIndex = 134;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(786, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 22);
            this.label12.TabIndex = 133;
            this.label12.Text = "DANH SÁCH TOA XN";
            // 
            // grbDanhSachToaXN
            // 
            this.grbDanhSachToaXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbDanhSachToaXN.Controls.Add(this.dgvDanhSachToaXN);
            this.grbDanhSachToaXN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachToaXN.Location = new System.Drawing.Point(479, 64);
            this.grbDanhSachToaXN.Name = "grbDanhSachToaXN";
            this.grbDanhSachToaXN.Size = new System.Drawing.Size(1034, 250);
            this.grbDanhSachToaXN.TabIndex = 132;
            this.grbDanhSachToaXN.TabStop = false;
            // 
            // dgvDanhSachToaXN
            // 
            this.dgvDanhSachToaXN.AllowUserToAddRows = false;
            this.dgvDanhSachToaXN.AllowUserToDeleteRows = false;
            this.dgvDanhSachToaXN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachToaXN.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachToaXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachToaXN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXN,
            this.MaBA,
            this.NgayXN,
            this.Hide});
            this.dgvDanhSachToaXN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachToaXN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachToaXN.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachToaXN.Name = "dgvDanhSachToaXN";
            this.dgvDanhSachToaXN.ReadOnly = true;
            this.dgvDanhSachToaXN.Size = new System.Drawing.Size(1028, 225);
            this.dgvDanhSachToaXN.TabIndex = 60;
            // 
            // MaXN
            // 
            this.MaXN.DataPropertyName = "MaXN";
            this.MaXN.HeaderText = "Mã XN";
            this.MaXN.Name = "MaXN";
            this.MaXN.ReadOnly = true;
            // 
            // MaBA
            // 
            this.MaBA.DataPropertyName = "MaBA";
            this.MaBA.HeaderText = "Mã Bệnh Án";
            this.MaBA.Name = "MaBA";
            this.MaBA.ReadOnly = true;
            // 
            // NgayXN
            // 
            this.NgayXN.DataPropertyName = "NgayXN";
            this.NgayXN.HeaderText = "Ngày XN";
            this.NgayXN.Name = "NgayXN";
            this.NgayXN.ReadOnly = true;
            // 
            // Hide
            // 
            this.Hide.DataPropertyName = "Hide";
            this.Hide.HeaderText = "Tình Trạng";
            this.Hide.Name = "Hide";
            this.Hide.ReadOnly = true;
            // 
            // grbQuanLyToaXN
            // 
            this.grbQuanLyToaXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbQuanLyToaXN.Controls.Add(this.dtpNgayXN);
            this.grbQuanLyToaXN.Controls.Add(this.cmbMaBA);
            this.grbQuanLyToaXN.Controls.Add(this.label2);
            this.grbQuanLyToaXN.Controls.Add(this.cmbMaXN);
            this.grbQuanLyToaXN.Controls.Add(this.cmbHide);
            this.grbQuanLyToaXN.Controls.Add(this.label13);
            this.grbQuanLyToaXN.Controls.Add(this.label5);
            this.grbQuanLyToaXN.Controls.Add(this.label3);
            this.grbQuanLyToaXN.Controls.Add(this.label6);
            this.grbQuanLyToaXN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuanLyToaXN.Location = new System.Drawing.Point(-1, 64);
            this.grbQuanLyToaXN.Name = "grbQuanLyToaXN";
            this.grbQuanLyToaXN.Size = new System.Drawing.Size(476, 403);
            this.grbQuanLyToaXN.TabIndex = 125;
            this.grbQuanLyToaXN.TabStop = false;
            // 
            // dtpNgayXN
            // 
            this.dtpNgayXN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXN.Location = new System.Drawing.Point(79, 199);
            this.dtpNgayXN.Name = "dtpNgayXN";
            this.dtpNgayXN.Size = new System.Drawing.Size(125, 27);
            this.dtpNgayXN.TabIndex = 101;
            // 
            // cmbMaBA
            // 
            this.cmbMaBA.FormattingEnabled = true;
            this.cmbMaBA.Location = new System.Drawing.Point(337, 75);
            this.cmbMaBA.Name = "cmbMaBA";
            this.cmbMaBA.Size = new System.Drawing.Size(137, 27);
            this.cmbMaBA.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 98;
            this.label2.Text = "Mã BA :";
            // 
            // cmbMaXN
            // 
            this.cmbMaXN.FormattingEnabled = true;
            this.cmbMaXN.Location = new System.Drawing.Point(79, 57);
            this.cmbMaXN.Name = "cmbMaXN";
            this.cmbMaXN.Size = new System.Drawing.Size(137, 27);
            this.cmbMaXN.TabIndex = 94;
            // 
            // cmbHide
            // 
            this.cmbHide.FormattingEnabled = true;
            this.cmbHide.Location = new System.Drawing.Point(327, 133);
            this.cmbHide.Name = "cmbHide";
            this.cmbHide.Size = new System.Drawing.Size(137, 27);
            this.cmbHide.TabIndex = 94;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(218, 136);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 91;
            this.label3.Text = "Ngày XN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 91;
            this.label6.Text = "Mã XN";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageIndex = 3;
            this.btnLuu.Location = new System.Drawing.Point(287, 509);
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
            this.btnSua.Location = new System.Drawing.Point(101, 509);
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
            this.btnXoa.Location = new System.Drawing.Point(191, 509);
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
            this.btnHuy.Location = new System.Drawing.Point(374, 509);
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
            this.btnThemMoi.Location = new System.Drawing.Point(1, 509);
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
            this.btnHide.Location = new System.Drawing.Point(221, 578);
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
            this.btnFind.Location = new System.Drawing.Point(101, 578);
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
            this.label1.Location = new System.Drawing.Point(119, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 129;
            this.label1.Text = "QUẢN LÝ TOA XN";
            // 
            // frmToaXetNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 670);
            this.Controls.Add(this.pnlDanhSachToaXN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grbDanhSachToaXN);
            this.Controls.Add(this.grbQuanLyToaXN);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Name = "frmToaXetNghiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmToaXetNghiem";
            this.Load += new System.EventHandler(this.frmToaXetNghiem_Load);
            this.grbDanhSachToaXN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachToaXN)).EndInit();
            this.grbQuanLyToaXN.ResumeLayout(false);
            this.grbQuanLyToaXN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDanhSachToaXN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbDanhSachToaXN;
        private System.Windows.Forms.DataGridView dgvDanhSachToaXN;
        private System.Windows.Forms.GroupBox grbQuanLyToaXN;
        private System.Windows.Forms.ComboBox cmbMaBA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHide;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXN;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Hide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaXN;
        private System.Windows.Forms.DateTimePicker dtpNgayXN;
    }
}