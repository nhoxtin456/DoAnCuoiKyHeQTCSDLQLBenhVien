namespace DoAnCuoiKyQLBVHQT_Final.Presentation
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
            this.dgvBS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBS
            // 
            this.dgvBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBS.Location = new System.Drawing.Point(107, 120);
            this.dgvBS.Name = "dgvBS";
            this.dgvBS.Size = new System.Drawing.Size(565, 267);
            this.dgvBS.TabIndex = 0;
            // 
            // frmBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBS);
            this.Name = "frmBacSi";
            this.Text = "frmBacSi";
            this.Load += new System.EventHandler(this.frmBacSi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBS;
    }
}