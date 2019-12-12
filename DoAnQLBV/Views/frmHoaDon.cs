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
    public partial class frmHoaDon : Form
    {
        HoaDonMod hoaDonMod  = new HoaDonMod();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        // Khai báo biến để phân biệt lúc THÊM và SỬA
        int flag = 0;

        void dis_end(bool e)
        {

            txtTenHD.Enabled = e;
            txtGiaHD.Enabled = e;


            cmbHide.Enabled = e;
            cmbMaNV.Enabled = e;
            cmbMaBA.Enabled = e;
            dtpNgayLapHD.Enabled = e;
            dtpNgayTTHD.Enabled = e;
            dtpThoiGian.Enabled = e;



            btnLuu.Enabled = e;
            btnHuy.Enabled = e;

            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }


        // Tạo hàm dữ liệu để trỏ đến dữ liệu trên DataGridView
        public void nhung(Control ctr)
        {
            try
            {
                //pnlDanhSachHD.Controls.Clear();
                //pnlDanhSachHD.BorderStyle = BorderStyle.Fixed3D;
                //ctr.Dock = DockStyle.Fill;
                //pnlDanhSachHD.Controls.Add(ctr);
                //pnlDanhSachHD.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Nhân Viên!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void HienThiDanhSachHD()
        {
            try
            {
                //dgvHoaDonTong.DataSource = hoaDonMod.LayHDTongAll(txtMaHD.Text);

                // Trỏ tới data HD

                dgvDanhSachHD.DataSource = HoaDonMod.FillDataSetHoaDon().Tables[0];
                //.DataSource = Models.HoaDonMod.FillDataSetHoaDon().Tables[0];

                //dgvDanhSachHD.DataSource = hoaDonMod.

                dgvDanhSachHD.Dock = DockStyle.Fill;
                dgvDanhSachHD.RowHeadersVisible = false;
                dgvDanhSachHD.BorderStyle = BorderStyle.Fixed3D;

                //dgvHoaDonTong.DataSource = hoaDonMod.LayHDTongAll(txtMaHD.Text);

            }
          
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng HD!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void bingding()
        {
            try
            {
                txtMaHD.DataBindings.Clear();
                txtMaHD.DataBindings.Add("Text", dgvDanhSachHD.DataSource, "MaHD");




                txtTenHD.DataBindings.Clear();
                txtTenHD.DataBindings.Add("Text", dgvDanhSachHD.DataSource, "TenHD");

                txtGiaHD.DataBindings.Clear();
                txtGiaHD.DataBindings.Add("Text", dgvDanhSachHD.DataSource, "GiaHD");

                cmbHide.DataBindings.Clear();
                cmbHide.DataBindings.Add("Text", dgvDanhSachHD.DataSource, "Hide");




                cmbMaNV.DataBindings.Clear();
                cmbMaNV.DataBindings.Add("Text", dgvDanhSachHD.DataSource, "MaNV");

               

                cmbMaBA.DataBindings.Clear();
                cmbMaBA.DataBindings.Add("Text", dgvDanhSachHD.DataSource, "MaBA");

                dtpNgayLapHD.DataBindings.Clear();
                dtpNgayLapHD.DataBindings.Add("Text", dgvDanhSachHD.DataSource, "NgayLapHD");

                dtpNgayTTHD.DataBindings.Clear();
                dtpNgayTTHD.DataBindings.Add("Text", dgvDanhSachHD.DataSource, "NgayThanhToanHD");

                dtpThoiGian.DataBindings.Clear();
                dtpThoiGian.DataBindings.Add("Text", dgvDanhSachHD.DataSource, "ThoiGian");




                //txtQuen.DataBindings.Clear();
                //txtQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");


                //txtMaHD.DataBindings.Clear();
                //txtMaHD.DataBindings.Add("Text", dgvHoaDonTong.DataSource, "MaHD");
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng HD !",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        // Hàm load 
        void loadcontrol()
        {


            cmbHide.Items.Clear();
            cmbHide.Items.Add("False");
            cmbHide.Items.Add("True");

            cmbMaNV.DataSource = Models.HoaDonMod.FillDataSet_getMaNV().Tables[0];
            cmbMaNV.DisplayMember = "MaNV";

         

            cmbMaBA.DataSource = Models.HoaDonMod.FillDataSet_getMaBA().Tables[0];
            cmbMaBA.DisplayMember = "MaBA";




        }


        // Hàm xóa dữ liệu ở textbox lúc ta nhấn vào button
        void ClearData()
        {
            txtMaHD.Text = string.Format(hoaDonMod.GetMaHDTuDongTang());

            txtTenHD.Text = "";
            txtGiaHD.Text = "";



            //txtQuyen.Text = "";
            loadcontrol(); // Gọi hàm 
        }


        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            //HienThiDanhSachHD();
            //bingding();
            //dis_end(false);

            dis_end(false);
            HienThiDanhSachHD();
            bingding();

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            flag = 0;
            ClearData();
            dis_end(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lúc click sửa mặc định cho flag = 1;
            flag = 1;
            dis_end(true); // Lúc này các nút thêm, sửa , xóa sẽ ẩn đi, chỉ còn nút lưu và hủy
            loadcontrol();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _maHD = "";
            try
            {
                _maHD = txtMaHD.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.HoaDonCtrl.DeleteHoaDon(_maHD);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachHD();
                    frmHoaDon_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra khai báo các biến 
            string _maHD = "";
            try
            {
                _maHD = txtMaHD.Text;
            }
            catch { }

            string _tenHD = "";
            try
            {
                _tenHD = txtTenHD.Text;
            }
            catch { }

            string _giaHD = "";
            try
            {
                _giaHD = txtGiaHD.Text;
            }
            catch { }

            string _hidemaHD = "";
            try
            {
                _hidemaHD = cmbHide.Text;
            }
            catch { }

            string _maNV = "";
            try
            {
                _maNV = cmbMaNV.Text;
            }
            catch { }

            string _maBA = "";
            try
            {
                _maBA = cmbMaBA.Text;
            }
            catch { }

            DateTime _ngayLapHD = dtpNgayLapHD.Value;

            try { }
            catch { }

            DateTime _ngayTTHD = dtpNgayTTHD.Value;

            try { }
            catch { }

            DateTime _thoiGian = dtpThoiGian.Value;

            try { }
            catch { }




            if (flag == 0)
            {
                // Thêm mới
                if (_maHD == "" || _tenHD == "" || _maBA == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.HoaDonCtrl.InsertHoaDon(_maHD,_tenHD,Convert.ToDouble(_giaHD), Convert.ToBoolean(_hidemaHD), _maNV, _maBA, _ngayLapHD, _ngayTTHD,_thoiGian);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachHD();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.HoaDonCtrl.UpdateHoaDon(_maHD, _tenHD, Convert.ToDouble(_giaHD), Convert.ToBoolean(_hidemaHD), _maNV, _maBA, _ngayLapHD, _ngayTTHD, _thoiGian);
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachHD();
                    frmHoaDon_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            frmHoaDon_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Load lại 
            frmHoaDon_Load(sender, e);
            dis_end(false);
        }

      

        public void tinhtien()
        {
            int tien = dgvDanhSachHD.Rows.Count;
            decimal thanhtien = 0;
            for (int i = 0; i < tien; i++)
            {
                thanhtien += decimal.Parse(dgvDanhSachHD.Rows[i].Cells["Thành Tiền"].Value.ToString());
            }
            // "#,### dung de ngan cach cac ki tu thap phan phan tram,nagn.....phia sau
            // Dinh dang theo tien te VND
            label10.Text = thanhtien.ToString("#,###") + " VND";
            label10.ForeColor = SystemColors.HotTrack;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string _maHD = "";
            
            
                _maHD = txtMaHD.Text;
            
            //catch { }
            //DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr == DialogResult.Yes)
            //{
            //    int i = 0;
            //    i = Controllers.HoaDonCtrl.LayHDTong(_maHD);
            //    if (i > 0)
            //    {
            //        MessageBox.Show(" Xóa thành công");
            //        HienThiDanhSachHD();
            //        frmHoaDon_Load(sender, e);
            //    }
            //    else
            //        MessageBox.Show("Xóa không thành công");
            //}
            //else
            //    return;

              HienThiDanhSachHD();
            frmHoaDon_Load(sender, e);











            //hoaDonMod.LayTableHD(this.dgvDanhSachHD, txtMaHD.Text);
        }

        private void dgvDanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //pnlDanhSachHD.Controls.Clear();
            //pnlDanhSachHD.BorderStyle = BorderStyle.None;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            uctDoanhThu uctS = new uctDoanhThu();
            nhung(uctS);
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            var r = hoaDonMod.TinhTongHDAll(txtMaHD.Text);
            //MessageBox.Show(r.ToString());

            lblTongTien.Text = r.ToString();


            //try
            //{
            //    DialogResult ok = new DialogResult();
            //    ok = MessageBox.Show("Bạn có muốn tính tiền " + label1.Text + " Không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (ok == DialogResult.Yes)
            //    {
            //        MessageBox.Show("TỔNG SỐ TIỀN THANH TOÁN CỦA " + " [ " + label1.Text + " ] " + " LÀ " + label10.Text, "Thông báo",
            //            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        tinhtien();

            //        dgvDanhSachHD.DataSource = Controllers.HoaDonCtrl.DeleteHoaDon(_maHD);
            //        uctGoiMon_Load(sender, e);
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}
            //catch { MessageBox.Show("Bạn chưa chọn bàn thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            //uctGoiMon_Load(sender, e);

            //MessageBox 
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            hoaDonMod.HoaDonUndo();
            frmHoaDon_Load(sender, e);
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            hoaDonMod.HoaDonRedo();
            frmHoaDon_Load(sender, e);
        }






        //private void frmHoaDon_Load(object sender, EventArgs e)
        //{
        //    HienThiDanhSachHoaDon();
        //    bingding();
        //}

        //private void button1_Click(object sender, EventArgs e)

        //string _maHD = "";
        //try
        //{
        //    _maHD = textBox1.Text;
        //}
        //catch { }
        //int i = 0;
        //i = Controllers.HoaDonCtrl.TinhTienHD(_maHD);
        //if (i > 0)



        //  MessageBox.Show(i.ToString());
        //this.lbSoNgay.Text = w.ToString();

        //txtMaBS.Text = Models.connection.ExcuteScalar(String.Format("select MaBS= Hospital.fnMaBacSiTuDongTang()"));     //MaBS tự động tăng

        // label1.Text = Models.connection.ExcuteScalar(String.Format("select Hospital.fnTinhTongHoaDonAll"));
        //MaBS tự động tăng
        //HienThiDanhSachBacSi();
        //frmBacSi_Load(sender, e);

        //else
        //    MessageBox.Show("Xóa không thành công");



        //public static uctDoanhThu uctHD = new uctDoanhThu();
        //public uctDoanhThu()
        //{
        //    InitializeComponent();
        //}
        //public void HienThiDanhSachHoaDon()
        //{
        //    dtgvDoanhThu.DataSource = DoanhThuMod.Instance.HienThiDoanhThu();
        //    dtgvDoanhThu.Dock = DockStyle.Fill;
        //    dtgvDoanhThu.RowHeadersVisible = false;
        //    dtgvDoanhThu.BorderStyle = BorderStyle.Fixed3D;
        //}
        //private void uctDoanhThu_Load(object sender, EventArgs e)
        //{
        //    TongDoanhThu.Text = "";
        //    HienThiDanhSachHoaDon();
        //}
        //private void btnNhan_Click(object sender, EventArgs e)
        //{
        //    if (NgayStart.Value.Date > NgayEnd.Value.Date)
        //    {
        //        MessageBox.Show("Vui lòng nhập lại ngày bắt đầy và ngày kết thúc");
        //    }
        //    else
        //    {
        //        DataSet dt = new DataSet();
        //        dt = Models.DoanhThuMod.GetDoanhThu(NgayStart.Value.Date, NgayEnd.Value.Date);
        //        dtgvDoanhThu.DataSource = dt.Tables[0];
        //        dtgvDoanhThu.Dock = DockStyle.Fill;
        //        dtgvDoanhThu.RowHeadersVisible = false;
        //        dtgvDoanhThu.BorderStyle = BorderStyle.Fixed3D;
        //        string Tong = "";
        //        Tong = Models.DoanhThuMod.GetTongDoanhThu(NgayStart.Value.Date, NgayEnd.Value.Date);
        //        TongDoanhThu.Text = Tong;
        //    }
        //}




    }
}