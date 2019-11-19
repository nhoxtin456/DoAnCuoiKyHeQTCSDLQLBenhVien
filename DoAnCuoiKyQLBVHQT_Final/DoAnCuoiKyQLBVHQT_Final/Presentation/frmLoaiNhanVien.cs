using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKyQLBVHQT_Final.BS_Layer;

namespace DoAnCuoiKyQLBVHQT_Final.Presentation
{
    public partial class frmLoaiNhanVien : Form
    {
        BLLoaiNhanVien bL = new BLLoaiNhanVien();
        public frmLoaiNhanVien()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            this.dgvLoaiNV.DataSource = bL.LayLoaiNV();
            this.dgvLoaiNV.AutoResizeColumns();
            this.dgvLoaiNV.AutoResizeRows();
            ClearData();
            //this.Dispose();
        }

        private void ClearData()
        {
            this.txtMaLoaiNV.Clear();
            this.txtTenLoaiNV.Clear();
        }

        private void frmLoaiNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvLoaiNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLoaiNV.CurrentCell.RowIndex;
            this.txtMaLoaiNV.Text = this.dgvLoaiNV.Rows[r].Cells[0].Value.ToString();
            this.txtTenLoaiNV.Text = this.dgvLoaiNV.Rows[r].Cells[1].Value.ToString();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            var r = bL.DemLoaiNV();
            MessageBox.Show(r.ToString());
        }
    }
}
