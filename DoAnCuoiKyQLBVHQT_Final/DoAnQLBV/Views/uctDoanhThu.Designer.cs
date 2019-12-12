namespace DoAnQLBV.Views
{
    partial class uctDoanhThu
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
            this.TongDoanhThu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNhan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NgayEnd = new System.Windows.Forms.DateTimePicker();
            this.NgayStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // TongDoanhThu
            // 
            this.TongDoanhThu.AutoSize = true;
            this.TongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.TongDoanhThu.Location = new System.Drawing.Point(534, 475);
            this.TongDoanhThu.Name = "TongDoanhThu";
            this.TongDoanhThu.Size = new System.Drawing.Size(0, 26);
            this.TongDoanhThu.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "TỔNG DOANH THU:";
            // 
            // btnNhan
            // 
            this.btnNhan.BackColor = System.Drawing.Color.Green;
            this.btnNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhan.Location = new System.Drawing.Point(389, 24);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(136, 43);
            this.btnNhan.TabIndex = 21;
            this.btnNhan.Text = "Thống kê";
            this.btnNhan.UseVisualStyleBackColor = false;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Từ:";
            // 
            // NgayEnd
            // 
            this.NgayEnd.CalendarMonthBackground = System.Drawing.Color.White;
            this.NgayEnd.CustomFormat = "dd/MM/yyyy";
            this.NgayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayEnd.Location = new System.Drawing.Point(606, 34);
            this.NgayEnd.Name = "NgayEnd";
            this.NgayEnd.Size = new System.Drawing.Size(110, 20);
            this.NgayEnd.TabIndex = 18;
            // 
            // NgayStart
            // 
            this.NgayStart.CustomFormat = "dd/MM/yyyy";
            this.NgayStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayStart.Location = new System.Drawing.Point(245, 34);
            this.NgayStart.Name = "NgayStart";
            this.NgayStart.Size = new System.Drawing.Size(105, 20);
            this.NgayStart.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDoanhThu);
            this.groupBox1.Location = new System.Drawing.Point(39, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(898, 397);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // dtgvDoanhThu
            // 
            this.dtgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDoanhThu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDoanhThu.Location = new System.Drawing.Point(4, 17);
            this.dtgvDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDoanhThu.Name = "dtgvDoanhThu";
            this.dtgvDoanhThu.Size = new System.Drawing.Size(890, 376);
            this.dtgvDoanhThu.TabIndex = 13;
            this.dtgvDoanhThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDoanhThu_CellContentClick);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(940, 219);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 24;
            // 
            // uctDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.TongDoanhThu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NgayEnd);
            this.Controls.Add(this.NgayStart);
            this.Controls.Add(this.groupBox1);
            this.Name = "uctDoanhThu";
            this.Size = new System.Drawing.Size(1054, 516);
            this.Load += new System.EventHandler(this.uctDoanhThu_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TongDoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker NgayEnd;
        private System.Windows.Forms.DateTimePicker NgayStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDoanhThu;
        private System.Windows.Forms.TextBox txtMaHD;
    }
}
