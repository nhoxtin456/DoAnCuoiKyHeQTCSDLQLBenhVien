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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        // Khai báo biến để phân biệt lúc THÊM và SỬA
        int flag = 0;
        public void HienThiDanhSachNhanVien()
        {
            try
            {
                // Trỏ tới data Nhân Viên
                dgvDanhSachNV.DataSource = Models.NhanVienMod.FillDataSetNhanVien().Tables[0];
                //this.dgvDanhSachNV.DataSource = context.HienThiThongTinNhanVien();
                dgvDanhSachNV.Dock = DockStyle.Fill;
                dgvDanhSachNV.RowHeadersVisible = false;
                dgvDanhSachNV.BorderStyle = BorderStyle.Fixed3D;
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Nhân Viên!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Load lại 
            frmNhanVien_Load(sender, e);
            dis_end(false);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            uctSearchNhanVien uctSearch = new uctSearchNhanVien();
            nhung(uctSearch);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlDanhSachNV.Controls.Clear();
            pnlDanhSachNV.BorderStyle = BorderStyle.None;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dis_end(false);
            HienThiDanhSachNhanVien();
            bingding();
        }

        private void dgvDanhSachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }




        // Tạo hàm dữ liệu để trỏ đến dữ liệu trên DataGridView
        public void nhung(Control ctr)
        {
            try
            {
                pnlDanhSachNV.Controls.Clear();
                pnlDanhSachNV.BorderStyle = BorderStyle.Fixed3D;
                ctr.Dock = DockStyle.Fill;
                pnlDanhSachNV.Controls.Add(ctr);
                pnlDanhSachNV.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Nhân Viên!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Hàm load giới tính cho Nhân Viên
        void loadcontrol()
        {
            cmbGioiTinhNV.Items.Clear();
            cmbGioiTinhNV.Items.Add("Nam");
            cmbGioiTinhNV.Items.Add("Nữ");

            cmbQuyen.Items.Clear();
            cmbQuyen.Items.Add("Admin");
            cmbQuyen.Items.Add("NhanVienTiepTan");
            cmbQuyen.Items.Add("NhanVienKeToan");

            cmbHide.Items.Clear();
            cmbHide.Items.Add("False");
            cmbHide.Items.Add("True");
        }

       


        void bingding()
        {
            try
            {
                txtMaNhanVien.DataBindings.Clear();
                txtMaNhanVien.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "MaNV");

                txtMatKhau.DataBindings.Clear();
                txtMatKhau.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "MatKhau");

                txtHoNV.DataBindings.Clear();
                txtHoNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "HoNV");

                txtTenNV.DataBindings.Clear();
                txtTenNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "TenNV");

                dtpNgaySinhNV.DataBindings.Clear();
                dtpNgaySinhNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "NgaySinh");

                cmbGioiTinhNV.DataBindings.Clear();
                cmbGioiTinhNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "GioiTinh");

                txtSDTNV.DataBindings.Clear();
                txtSDTNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "SDT");

                txtEmailNV.DataBindings.Clear();
                txtEmailNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Email");


                txtLuongNV.DataBindings.Clear();
                txtLuongNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Luong");

                //txtQuen.DataBindings.Clear();
                //txtQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");

                cmbQuyen.DataBindings.Clear();
                cmbQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");

                cmbHide.DataBindings.Clear();
                cmbHide.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Hide");
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Nhân Viên!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // Hàm xóa dữ liệu ở textbox lúc ta nhấn vào button
        void ClearData()
        {
            txtMaNhanVien.Text = Models.connection.ExcuteScalar(String.Format("select MaNV= HR.fnMaNhanVienTuDongTang()")); //MaNhanVien tự động tăng
            txtMatKhau.Text = "";
            txtHoNV.Text = "";
            txtTenNV.Text = "";
            txtSDTNV.Text = "";
            txtEmailNV.Text = "";
            txtLuongNV.Text = "";
            //txtQuyen.Text = "";
            loadcontrol(); // Gọi hàm để load Giới tính
        }

        void dis_end(bool e)
        {
            txtMatKhau.Enabled = e;
            txtHoNV.Enabled = e;
            txtTenNV.Enabled = e;
            dtpNgaySinhNV.Enabled = e;
            cmbGioiTinhNV.Enabled = e;
            txtSDTNV.Enabled = e;
            txtEmailNV.Enabled = e;
            txtLuongNV.Enabled = e;
            cmbQuyen.Enabled = e;
            //txtQuyen.Enabled = e;
            cmbHide.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
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
            string _maNhanVien = "";
            try
            {
                _maNhanVien = txtMaNhanVien.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.NhanVienCtrl.DeleteNhanVien(_maNhanVien);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachNhanVien();
                    frmNhanVien_Load(sender, e);
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
            string _maNhanVien = "";
            try
            {
                _maNhanVien = txtMaNhanVien.Text;
            }
            catch { }

            string _matKhau = "";
            try
            {
                _matKhau = txtMatKhau.Text;
            }
            catch { }


            string _hoNhanVien = "";
            try
            {
                _hoNhanVien = txtHoNV.Text;
            }
            catch { }

            string _tenNhanVien = "";
            try
            {
                _tenNhanVien = txtTenNV.Text;
            }
            catch { }

            DateTime _ngaysinhNhanVien = dtpNgaySinhNV.Value;

            try { }
            catch { }

            string _giotinhNhanVien = "";
            try
            {
                _giotinhNhanVien = cmbGioiTinhNV.Text;
            }
            catch { }
            string _dienthoaiNhanVien = "";
            try
            {
                _dienthoaiNhanVien = txtSDTNV.Text;
            }
            catch { }

            string _emailNhanVien = "";
            try
            {
                _emailNhanVien = txtEmailNV.Text;
            }
            catch { }


            Double _luongNhanVien = Convert.ToDouble(txtLuongNV.Text);

            try { }
            catch { }
            string _quyenNhanVien = "";
            try
            {
                _quyenNhanVien = cmbQuyen.Text;
                //_quyenNhanVien = txtQuyen.Text;
            }

            catch { }

            string _hideNV = "";
            try
            {
                _hideNV = cmbHide.Text;
            }
            catch { }

            if (flag == 0)
            {
                // Thêm mới
                if (_maNhanVien == "" || _tenNhanVien == "" || _matKhau == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.NhanVienCtrl.InSertNhanVien(_maNhanVien, _matKhau, _hoNhanVien, _tenNhanVien, _ngaysinhNhanVien, _giotinhNhanVien, _dienthoaiNhanVien, _emailNhanVien, _luongNhanVien, _quyenNhanVien, Convert.ToBoolean(_hideNV));
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachNhanVien();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.NhanVienCtrl.UpdateNhanVien(_maNhanVien, _matKhau, _hoNhanVien, _tenNhanVien, _ngaysinhNhanVien, _giotinhNhanVien, _dienthoaiNhanVien, _emailNhanVien, _luongNhanVien, _quyenNhanVien, Convert.ToBoolean(_hideNV));
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachNhanVien();
                    frmNhanVien_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            frmNhanVien_Load(sender, e);
        }  
    }
}