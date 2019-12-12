namespace DoAnQLBV.Views
{
    partial class frmThanhToan
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
            this.dgvTongHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaHDPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaHDThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaHDXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaHDAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTongHoaDon
            // 
            this.dgvTongHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.GiaHDPhong,
            this.GiaHDThuoc,
            this.GiaHDXN,
            this.GiaHDAll});
            this.dgvTongHoaDon.Location = new System.Drawing.Point(286, 100);
            this.dgvTongHoaDon.Name = "dgvTongHoaDon";
            this.dgvTongHoaDon.Size = new System.Drawing.Size(914, 499);
            this.dgvTongHoaDon.TabIndex = 126;
            this.dgvTongHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTongHoaDon_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.Name = "MaHD";
            // 
            // GiaHDPhong
            // 
            this.GiaHDPhong.DataPropertyName = "GiaHDPhong";
            this.GiaHDPhong.HeaderText = "Giá Hóa Đơn Phòng";
            this.GiaHDPhong.Name = "GiaHDPhong";
            // 
            // GiaHDThuoc
            // 
            this.GiaHDThuoc.DataPropertyName = "GiaHDThuoc";
            this.GiaHDThuoc.HeaderText = "Giá Hóa Đơn Thuốc";
            this.GiaHDThuoc.Name = "GiaHDThuoc";
            // 
            // GiaHDXN
            // 
            this.GiaHDXN.DataPropertyName = "GiaHDXN";
            this.GiaHDXN.HeaderText = "Giá Hóa Đơn XN";
            this.GiaHDXN.Name = "GiaHDXN";
            // 
            // GiaHDAll
            // 
            this.GiaHDAll.DataPropertyName = "GiaHDAll";
            this.GiaHDAll.HeaderText = "Giá HD Tổng";
            this.GiaHDAll.Name = "GiaHDAll";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(98, 86);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(68, 13);
            this.lblMaHD.TabIndex = 127;
            this.lblMaHD.Text = "Mã Hóa Đơn";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(329, 3);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 128;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(84, 159);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 129;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 21);
            this.comboBox1.TabIndex = 130;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(84, 241);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(100, 20);
            this.txtGiaPhong.TabIndex = 131;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 680);
            this.Controls.Add(this.txtGiaPhong);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.dgvTongHoaDon);
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThanhToan";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTongHoaDon;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaHDPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaHDThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaHDXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaHDAll;
        private System.Windows.Forms.TextBox txtGiaPhong;
    }
}