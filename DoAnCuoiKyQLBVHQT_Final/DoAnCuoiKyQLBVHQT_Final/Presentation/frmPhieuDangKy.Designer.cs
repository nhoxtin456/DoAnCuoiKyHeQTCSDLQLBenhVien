﻿namespace DoAnCuoiKyQLBVHQT_Final.Presentation
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
            this.dgvPhieuDK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhieuDK
            // 
            this.dgvPhieuDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDK.Location = new System.Drawing.Point(118, 92);
            this.dgvPhieuDK.Name = "dgvPhieuDK";
            this.dgvPhieuDK.Size = new System.Drawing.Size(565, 267);
            this.dgvPhieuDK.TabIndex = 1;
            // 
            // frmPhieuDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPhieuDK);
            this.Name = "frmPhieuDangKy";
            this.Text = "frmPhieuDangKy";
            this.Load += new System.EventHandler(this.frmPhieuDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuDK;
    }
}