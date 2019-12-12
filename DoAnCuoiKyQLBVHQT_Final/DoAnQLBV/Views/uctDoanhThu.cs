using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQLBV.Models;

namespace DoAnQLBV.Views
{
    public partial class uctDoanhThu : UserControl
    {

        DoanhThuMod doanhThu = new DoanhThuMod();
        public static uctDoanhThu uctHD = new uctDoanhThu();

        public uctDoanhThu()
        {
            InitializeComponent();
        }

        void bingding()
        {
            try
            {
                txtMaHD.DataBindings.Clear();
                txtMaHD.DataBindings.Add("Text", dtgvDoanhThu.DataSource, "MaHD");

            }

            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng HD !",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void HienThiDanhSachHoaDon()
        {
            dtgvDoanhThu.DataSource = DoanhThuMod.Instance.HienThiDoanhThu();
            dtgvDoanhThu.Dock = DockStyle.Fill;
            dtgvDoanhThu.RowHeadersVisible = false;
            dtgvDoanhThu.BorderStyle = BorderStyle.Fixed3D;
        }

        private void uctDoanhThu_Load_1(object sender, EventArgs e)
        {
            TongDoanhThu.Text = "";

            HienThiDanhSachHoaDon();
        }


        private void btnNhan_Click_1(object sender, EventArgs e)
        {
            if (NgayStart.Value.Date > NgayEnd.Value.Date)
            {
                MessageBox.Show("Vui lòng nhập lại ngày bắt đầy và ngày kết thúc");
            }
            else
            {

                var r = doanhThu.GetTongDoanhThux(NgayStart.Value.Date, NgayEnd.Value.Date, txtMaHD.Text);

                //DataSet dt = new DataSet();
                //dt = Models.DoanhThuMod.get(NgayStart.Value.Date, NgayEnd.Value.Date);
                dtgvDoanhThu.DataSource = doanhThu.HienThiDoanhThu();
                dtgvDoanhThu.Dock = DockStyle.Fill;
                dtgvDoanhThu.RowHeadersVisible = false;
                dtgvDoanhThu.BorderStyle = BorderStyle.Fixed3D;
                string Tong = "";
                //Tong = Models.DoanhThuMod.GetTongDoanhThu(NgayStart.Value.Date, NgayEnd.Value.Date);
                
                TongDoanhThu.Text = Tong;
            }
        }

        private void dtgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
