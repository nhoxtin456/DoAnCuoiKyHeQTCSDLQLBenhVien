namespace DoAnQLBV.Views
{
    partial class uctSearchBenhNhan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.grDanhSachNV = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachNV = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHide = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.TextBox();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.txtHoBN = new System.Windows.Forms.TextBox();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.dtpNgaySinhBN = new System.Windows.Forms.DateTimePicker();
            this.grDanhSachNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(43, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 39);
            this.button2.TabIndex = 80;
            this.button2.Text = "Tìm kiếm theo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(311, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 30);
            this.button1.TabIndex = 79;
            this.button1.Text = "Kết quả tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFind.ForeColor = System.Drawing.Color.Green;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(677, 141);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(98, 37);
            this.btnFind.TabIndex = 78;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(348, 146);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(300, 26);
            this.txtFind.TabIndex = 77;
            // 
            // cmbFind
            // 
            this.cmbFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.Items.AddRange(new object[] {
            "Mã BN",
            "Họ BN",
            "Tên BN",
            "Ngày Sinh",
            "Giới Tính",
            "Tình Trạng"});
            this.cmbFind.Location = new System.Drawing.Point(180, 146);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(140, 27);
            this.cmbFind.TabIndex = 76;
            // 
            // grDanhSachNV
            // 
            this.grDanhSachNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grDanhSachNV.Controls.Add(this.dgvDanhSachNV);
            this.grDanhSachNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDanhSachNV.Location = new System.Drawing.Point(0, 215);
            this.grDanhSachNV.Name = "grDanhSachNV";
            this.grDanhSachNV.Size = new System.Drawing.Size(916, 247);
            this.grDanhSachNV.TabIndex = 75;
            this.grDanhSachNV.TabStop = false;
            // 
            // dgvDanhSachNV
            // 
            this.dgvDanhSachNV.AllowUserToAddRows = false;
            this.dgvDanhSachNV.AllowUserToDeleteRows = false;
            this.dgvDanhSachNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachNV.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachNV.Name = "dgvDanhSachNV";
            this.dgvDanhSachNV.ReadOnly = true;
            this.dgvDanhSachNV.Size = new System.Drawing.Size(910, 222);
            this.dgvDanhSachNV.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(730, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 94;
            this.label11.Text = "Tình Trạng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(569, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "Giới Tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Ngày Sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "Tên BN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Họ BN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Mã BN:";
            // 
            // txtHide
            // 
            this.txtHide.Location = new System.Drawing.Point(730, 60);
            this.txtHide.Margin = new System.Windows.Forms.Padding(2);
            this.txtHide.Name = "txtHide";
            this.txtHide.Size = new System.Drawing.Size(83, 20);
            this.txtHide.TabIndex = 87;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(552, 60);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(83, 20);
            this.txtGioiTinh.TabIndex = 85;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(180, 112);
            this.dtp.Margin = new System.Windows.Forms.Padding(2);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(83, 20);
            this.dtp.TabIndex = 84;
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(251, 60);
            this.txtTenBN.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(83, 20);
            this.txtTenBN.TabIndex = 83;
            // 
            // txtHoBN
            // 
            this.txtHoBN.Location = new System.Drawing.Point(138, 60);
            this.txtHoBN.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoBN.Name = "txtHoBN";
            this.txtHoBN.Size = new System.Drawing.Size(83, 20);
            this.txtHoBN.TabIndex = 82;
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(40, 60);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(56, 20);
            this.txtMaBN.TabIndex = 81;
            // 
            // dtpNgaySinhBN
            // 
            this.dtpNgaySinhBN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhBN.Location = new System.Drawing.Point(361, 60);
            this.dtpNgaySinhBN.Name = "dtpNgaySinhBN";
            this.dtpNgaySinhBN.Size = new System.Drawing.Size(125, 20);
            this.dtpNgaySinhBN.TabIndex = 95;
            // 
            // uctSearchBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpNgaySinhBN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHide);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtTenBN);
            this.Controls.Add(this.txtHoBN);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.cmbFind);
            this.Controls.Add(this.grDanhSachNV);
            this.Name = "uctSearchBenhNhan";
            this.Size = new System.Drawing.Size(932, 475);
            this.Load += new System.EventHandler(this.uctSearchBenhNhan_Load);
            this.grDanhSachNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ComboBox cmbFind;
        private System.Windows.Forms.GroupBox grDanhSachNV;
        private System.Windows.Forms.DataGridView dgvDanhSachNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHide;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox dtp;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.TextBox txtHoBN;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhBN;
    }
}
