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
    public partial class frmBenhNhan : Form
    {
        BLBenhNhan bL = new BLBenhNhan();
        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void frmBenhNhan_Load(object sender, EventArgs e)
        {
            LoadData();
           // this.Dispose();
        }

        private void LoadData()
        {
            //txtMaBN.DataBindings.Clear();
            //txtMaBN.DataBindings.Add("Text", dgvBN.DataSource, "MaBN");

            this.dgvBN.DataSource = bL.LayBN();
            this.dgvBN.AutoResizeColumns();
            this.dgvBN.AutoResizeRows();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //var r = bL.DemBS();
            //MessageBox.Show(r.ToString());

        }

        private void dgvBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            // Thứ tự dòng hiện hành    
            int r = dgvBN.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel           
            this.txtMaBN.Text =
                dgvBN.Rows[r].Cells[0].Value.ToString();
            this.txtHoBN.Text =
                dgvBN.Rows[r].Cells[1].Value.ToString();
            this.txtTenBN.Text =
                dgvBN.Rows[r].Cells[2].Value.ToString();
            this.dtpNgaySinh.Text =
                dgvBN.Rows[r].Cells[3].Value.ToString();
            this.txtGioiTinh.Text =
                dgvBN.Rows[r].Cells[4].Value.ToString();
            this.txtTinhTrang.Text =
                dgvBN.Rows[r].Cells[5].Value.ToString();

            //var tpQuery1 = (from nv in qlBN.NhanViens
            //                where nv.MaNV == this.txtMaNV.Text
            //                select nv);
            //foreach (var n in tpQuery1)
            //{
            //    this.dtPNgaySinh.Value = n.DateOfBirth.Value;

            //}
        }
    }
}
