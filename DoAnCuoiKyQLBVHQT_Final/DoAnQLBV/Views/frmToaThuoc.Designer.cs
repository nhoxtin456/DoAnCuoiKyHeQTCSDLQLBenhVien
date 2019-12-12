namespace DoAnQLBV.Views
{
    partial class frmToaThuoc
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
            this.pnlDanhSachToaThuoc = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.grbDanhSachToaThuoc = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachToaThuoc = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbQuanLyToaThuoc = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cmbMaBA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaThuoc = new System.Windows.Forms.ComboBox();
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
            this.grbDanhSachToaThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachToaThuoc)).BeginInit();
            this.grbQuanLyToaThuoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDanhSachToaThuoc
            // 
            this.pnlDanhSachToaThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDanhSachToaThuoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDanhSachToaThuoc.Location = new System.Drawing.Point(486, 330);
            this.pnlDanhSachToaThuoc.Name = "pnlDanhSachToaThuoc";
            this.pnlDanhSachToaThuoc.Size = new System.Drawing.Size(1017, 302);
            this.pnlDanhSachToaThuoc.TabIndex = 146;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(781, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(241, 22);
            this.label12.TabIndex = 145;
            this.label12.Text = "DANH SÁCH TOA THUỐC";
            // 
            // grbDanhSachToaThuoc
            // 
            this.grbDanhSachToaThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbDanhSachToaThuoc.Controls.Add(this.dgvDanhSachToaThuoc);
            this.grbDanhSachToaThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachToaThuoc.Location = new System.Drawing.Point(474, 59);
            this.grbDanhSachToaThuoc.Name = "grbDanhSachToaThuoc";
            this.grbDanhSachToaThuoc.Size = new System.Drawing.Size(1034, 250);
            this.grbDanhSachToaThuoc.TabIndex = 144;
            this.grbDanhSachToaThuoc.TabStop = false;
            // 
            // dgvDanhSachToaThuoc
            // 
            this.dgvDanhSachToaThuoc.AllowUserToAddRows = false;
            this.dgvDanhSachToaThuoc.AllowUserToDeleteRows = false;
            this.dgvDanhSachToaThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachToaThuoc.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachToaThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachToaThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.MaBA,
            this.SoLuong,
            this.Hide});
            this.dgvDanhSachToaThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachToaThuoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachToaThuoc.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachToaThuoc.Name = "dgvDanhSachToaThuoc";
            this.dgvDanhSachToaThuoc.ReadOnly = true;
            this.dgvDanhSachToaThuoc.Size = new System.Drawing.Size(1028, 225);
            this.dgvDanhSachToaThuoc.TabIndex = 60;
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "MaThuoc";
            this.MaThuoc.HeaderText = "Mã Thuốc";
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.ReadOnly = true;
            // 
            // MaBA
            // 
            this.MaBA.DataPropertyName = "MaBA";
            this.MaBA.HeaderText = "Mã Bệnh Án";
            this.MaBA.Name = "MaBA";
            this.MaBA.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // Hide
            // 
            this.Hide.DataPropertyName = "Hide";
            this.Hide.HeaderText = "Tình Trạng";
            this.Hide.Name = "Hide";
            this.Hide.ReadOnly = true;
            // 
            // grbQuanLyToaThuoc
            // 
            this.grbQuanLyToaThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbQuanLyToaThuoc.Controls.Add(this.txtSoLuong);
            this.grbQuanLyToaThuoc.Controls.Add(this.cmbMaBA);
            this.grbQuanLyToaThuoc.Controls.Add(this.label2);
            this.grbQuanLyToaThuoc.Controls.Add(this.cmbMaThuoc);
            this.grbQuanLyToaThuoc.Controls.Add(this.cmbHide);
            this.grbQuanLyToaThuoc.Controls.Add(this.label13);
            this.grbQuanLyToaThuoc.Controls.Add(this.label5);
            this.grbQuanLyToaThuoc.Controls.Add(this.label3);
            this.grbQuanLyToaThuoc.Controls.Add(this.label6);
            this.grbQuanLyToaThuoc.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuanLyToaThuoc.Location = new System.Drawing.Point(-6, 59);
            this.grbQuanLyToaThuoc.Name = "grbQuanLyToaThuoc";
            this.grbQuanLyToaThuoc.Size = new System.Drawing.Size(476, 403);
            this.grbQuanLyToaThuoc.TabIndex = 137;
            this.grbQuanLyToaThuoc.TabStop = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(102, 202);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 27);
            this.txtSoLuong.TabIndex = 100;
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
            // cmbMaThuoc
            // 
            this.cmbMaThuoc.FormattingEnabled = true;
            this.cmbMaThuoc.Location = new System.Drawing.Point(94, 65);
            this.cmbMaThuoc.Name = "cmbMaThuoc";
            this.cmbMaThuoc.Size = new System.Drawing.Size(137, 27);
            this.cmbMaThuoc.TabIndex = 94;
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
            this.label3.Location = new System.Drawing.Point(11, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 91;
            this.label3.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 91;
            this.label6.Text = "Mã Thuốc";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageIndex = 3;
            this.btnLuu.Location = new System.Drawing.Point(282, 504);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 50);
            this.btnLuu.TabIndex = 138;
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
            this.btnSua.Location = new System.Drawing.Point(96, 504);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 50);
            this.btnSua.TabIndex = 139;
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
            this.btnXoa.Location = new System.Drawing.Point(186, 504);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 50);
            this.btnXoa.TabIndex = 140;
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
            this.btnHuy.Location = new System.Drawing.Point(369, 504);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 50);
            this.btnHuy.TabIndex = 142;
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
            this.btnThemMoi.Location = new System.Drawing.Point(-4, 504);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(103, 50);
            this.btnThemMoi.TabIndex = 143;
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
            this.btnHide.Location = new System.Drawing.Point(216, 573);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(90, 49);
            this.btnHide.TabIndex = 135;
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
            this.btnFind.Location = new System.Drawing.Point(96, 573);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(114, 49);
            this.btnFind.TabIndex = 136;
            this.btnFind.Text = "Tìm kiếm ";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(114, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 22);
            this.label1.TabIndex = 141;
            this.label1.Text = "QUẢN LÝ TOA THUỐC";
            // 
            // frmToaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 660);
            this.Controls.Add(this.pnlDanhSachToaThuoc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grbDanhSachToaThuoc);
            this.Controls.Add(this.grbQuanLyToaThuoc);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Name = "frmToaThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmToaThuoc";
            this.Load += new System.EventHandler(this.frmToaThuoc_Load);
            this.grbDanhSachToaThuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachToaThuoc)).EndInit();
            this.grbQuanLyToaThuoc.ResumeLayout(false);
            this.grbQuanLyToaThuoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDanhSachToaThuoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbDanhSachToaThuoc;
        private System.Windows.Forms.DataGridView dgvDanhSachToaThuoc;
        private System.Windows.Forms.GroupBox grbQuanLyToaThuoc;
        private System.Windows.Forms.ComboBox cmbMaBA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaThuoc;
        private System.Windows.Forms.ComboBox cmbHide;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Hide;
    }
}