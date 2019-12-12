using DoAnQLBV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBV.Views
{
    public partial class frmThanhToan : Form
    {
        ThanhToanMod thanhToanMod = new ThanhToanMod();
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            //lblMaHD = Convert.to(thanhToanMod.TinhHoaDonPhong(txtMaHD.Text).ToString();
        }

        private void dgvTongHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTongHoaDon.CurrentCell.RowIndex;
            
            
            this.txtMaHD.Text = dgvTongHoaDon.Rows[r].Cells[0].Value.ToString();

            //this.TenDV_TextBox.Text = dgvDV.Rows[r].Cells[1].Value.ToString();
            //this.GiaDV_TextBox.Text = dgvDV.Rows[r].Cells[2].Value.ToString();
            
        }

        private void LoadData()
        {
            //dgvTongHoaDon.Rows[1].Cells["Giá Hóa Đơn Phòng"].Value.ToString()) = thanhToanMod.TinhHoaDonPhong(txtMaHD.Text);

            int tien = dgvTongHoaDon.Rows.Count;


            double? b = thanhToanMod.TinhHoaDonPhong(txtMaHD.Text);

            b = Convert.ToDouble(dgvTongHoaDon.Rows[1].Cells["Giá Hóa Đơn Phòng"].Value.ToString());
        }

       

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        //public void tinhtien()
        //{
        //    int tien = dgvGoiMon.Rows.Count;
        //    decimal thanhtien = 0;
        //    for (int i = 0; i < tien; i++)
        //    {
        //        thanhtien += decimal.Parse(dgvGoiMon.Rows[i].Cells["Thành Tiền"].Value.ToString());
        //    }
        //    // "#,### dung de ngan cach cac ki tu thap phan phan tram,nagn.....phia sau
        //    // Dinh dang theo tien te VND
        //    lblTongTien.Text = thanhtien.ToString("#,###") + " VND";
        //    lblTongTien.ForeColor = SystemColors.HotTrack;
        //}
        //private void btnTinhtien_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DialogResult ok = new DialogResult();
        //        ok = MessageBox.Show("Bạn có muốn tính tiền " + label1.Text + " Không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        if (ok == DialogResult.Yes)
        //        {
        //            MessageBox.Show("TỔNG SỐ TIỀN THANH TOÁN CỦA " + " [ " + label1.Text + " ] " + " LÀ " + lblTongTien.Text, "Thông báo",
        //                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //            tinhtien();
        //            uctMonDaGoi uctMDG = new uctMonDaGoi();
        //            nhung(uctMDG);
        //            string _IdBan = lvDanhSachBan.SelectedItems[0].SubItems[1].Text;
        //            dgvGoiMon.DataSource = Controllers.GoiMonCtrl.DeleteGoiMon(_IdBan);
        //            uctGoiMon_Load(sender, e);
        //        }
        //        else
        //        {
        //            return;
        //        }
        //    }
        //    catch { MessageBox.Show("Bạn chưa chọn bàn thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        //    uctGoiMon_Load(sender, e);
        //}












    }
}
