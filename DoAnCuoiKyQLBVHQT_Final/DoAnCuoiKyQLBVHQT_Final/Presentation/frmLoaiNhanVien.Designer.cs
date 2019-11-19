namespace DoAnCuoiKyQLBVHQT_Final.Presentation
{
    partial class frmLoaiNhanVien
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
            this.lblMaLoaiNV = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaLoaiNV = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvLoaiNV = new System.Windows.Forms.DataGridView();
            this.lblTenLoaiNV = new System.Windows.Forms.Label();
            this.txtTenLoaiNV = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaLoaiNV
            // 
            this.lblMaLoaiNV.AutoSize = true;
            this.lblMaLoaiNV.Location = new System.Drawing.Point(27, 38);
            this.lblMaLoaiNV.Name = "lblMaLoaiNV";
            this.lblMaLoaiNV.Size = new System.Drawing.Size(63, 13);
            this.lblMaLoaiNV.TabIndex = 0;
            this.lblMaLoaiNV.Text = "Ma Loai NV";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(694, 107);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtMaLoaiNV
            // 
            this.txtMaLoaiNV.Location = new System.Drawing.Point(12, 85);
            this.txtMaLoaiNV.Name = "txtMaLoaiNV";
            this.txtMaLoaiNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaLoaiNV.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(845, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // dgvLoaiNV
            // 
            this.dgvLoaiNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiNV.Location = new System.Drawing.Point(12, 163);
            this.dgvLoaiNV.Name = "dgvLoaiNV";
            this.dgvLoaiNV.Size = new System.Drawing.Size(827, 324);
            this.dgvLoaiNV.TabIndex = 4;
            this.dgvLoaiNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiNV_CellClick);
            // 
            // lblTenLoaiNV
            // 
            this.lblTenLoaiNV.AutoSize = true;
            this.lblTenLoaiNV.Location = new System.Drawing.Point(247, 38);
            this.lblTenLoaiNV.Name = "lblTenLoaiNV";
            this.lblTenLoaiNV.Size = new System.Drawing.Size(67, 13);
            this.lblTenLoaiNV.TabIndex = 0;
            this.lblTenLoaiNV.Text = "Ten Loai NV";
            // 
            // txtTenLoaiNV
            // 
            this.txtTenLoaiNV.Location = new System.Drawing.Point(250, 85);
            this.txtTenLoaiNV.Name = "txtTenLoaiNV";
            this.txtTenLoaiNV.Size = new System.Drawing.Size(100, 20);
            this.txtTenLoaiNV.TabIndex = 2;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(891, 247);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 9;
            this.btnCount.Text = "Dem";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // frmLoaiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 588);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.dgvLoaiNV);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtTenLoaiNV);
            this.Controls.Add(this.txtMaLoaiNV);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblTenLoaiNV);
            this.Controls.Add(this.lblMaLoaiNV);
            this.Name = "frmLoaiNhanVien";
            this.Text = "frmLoaiNhanVien";
            this.Load += new System.EventHandler(this.frmLoaiNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaLoaiNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaLoaiNV;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvLoaiNV;
        private System.Windows.Forms.Label lblTenLoaiNV;
        private System.Windows.Forms.TextBox txtTenLoaiNV;
        private System.Windows.Forms.Button btnCount;
    }
}