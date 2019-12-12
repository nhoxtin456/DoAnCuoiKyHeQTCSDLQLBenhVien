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
    public partial class frmBacSi : Form
    {
        public frmBacSi()
        {
            InitializeComponent();
        }

        // Khai báo biến để phân biệt lúc THÊM và SỬA
        int flag = 0;

        void dis_end(bool e)
        {
           
            txtHoBS.Enabled = e;
            txtTenBS.Enabled = e;
           
            cmbGioiTinhBS.Enabled = e;
            txtChucVu.Enabled = e;
            cmbMaKhoa.Enabled = e;
            cmbHide.Enabled = e;
           
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }

        public void HienThiDanhSachBacSi()
        {
            try
            {
                // Trỏ tới data Bác Sĩ
                dgvDanhSachBS.DataSource = Models.BacSiMod.FillDataSetBacSi().Tables[0];

                dgvDanhSachBS.Dock = DockStyle.Fill;
                dgvDanhSachBS.RowHeadersVisible = false;
                dgvDanhSachBS.BorderStyle = BorderStyle.Fixed3D;

                //dgvDanhsachTD.RowHeadersVisible = false;
                //dgvDanhsachTD.BorderStyle = BorderStyle.Fixed3D;



            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Bác Sĩ!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void bingding()
        {
            try
            {
                txtMaBS.DataBindings.Clear();
                txtMaBS.DataBindings.Add("Text", dgvDanhSachBS.DataSource, "MaBS");

                

                txtHoBS.DataBindings.Clear();
                txtHoBS.DataBindings.Add("Text", dgvDanhSachBS.DataSource, "HoBS");

                txtTenBS.DataBindings.Clear();
                txtTenBS.DataBindings.Add("Text", dgvDanhSachBS.DataSource, "TenBS");


                dtpNgaySinhBS.DataBindings.Clear();
                dtpNgaySinhBS.DataBindings.Add("Text", dgvDanhSachBS.DataSource, "NgaySinh");


                cmbGioiTinhBS.DataBindings.Clear();
                cmbGioiTinhBS.DataBindings.Add("Text", dgvDanhSachBS.DataSource, "GioiTinh");

                txtChucVu.DataBindings.Clear();
                txtChucVu.DataBindings.Add("Text", dgvDanhSachBS.DataSource, "ChucVu");




                //txtQuen.DataBindings.Clear();
                //txtQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");


                txtChucVu.DataBindings.Clear();
                txtChucVu.DataBindings.Add("Text", dgvDanhSachBS.DataSource, "ChucVu");

                cmbMaKhoa.DataBindings.Clear();
                cmbMaKhoa.DataBindings.Add("Text", dgvDanhSachBS.DataSource, "MaKhoa");


                cmbHide.DataBindings.Clear();
                cmbHide.DataBindings.Add("Text", dgvDanhSachBS.DataSource, "Hide");
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Bác Sĩ!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        // Hàm load giới tính cho Bác Sĩ
        void loadcontrol()
        {


            cmbGioiTinhBS.Items.Clear();
            cmbGioiTinhBS.Items.Add("Nam");
            cmbGioiTinhBS.Items.Add("Nữ");

            cmbMaKhoa.DataSource = Models.KhoaMod.FillDataSet_getMaKhoa().Tables[0];
            cmbMaKhoa.DisplayMember = "MaKhoa";

            cmbHide.Items.Clear();
            cmbHide.Items.Add("False");
            cmbHide.Items.Add("True");

           
        }


        // Hàm xóa dữ liệu ở textbox lúc ta nhấn vào button
        void ClearData()
        {
            txtMaBS.Text = Models.connection.ExcuteScalar(String.Format("select MaBS= Hospital.fnMaBacSiTuDongTang()"));     //MaBS tự động tăng
           

            txtHoBS.Text = "";
            txtTenBS.Text = "";
            
            txtChucVu.Text = "";


            //txtQuyen.Text = "";
            loadcontrol(); // Gọi hàm để load Giới tính
        }

        private void frmBacSi_Load(object sender, EventArgs e)
        {
            //dis_end(false);
            //HienThiDanhSachBacSi();
            //bingding();

            HienThiDanhSachBacSi();
            bingding();
            dis_end(false);

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
            string _maBS = "";
            try
            {
                _maBS = txtMaBS.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.BacSiCtrl.DeleteBacSi(_maBS);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachBacSi();
                    frmBacSi_Load(sender, e);
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
            string _maBS = "";
            try
            {
                _maBS = txtMaBS.Text;
            }
            catch { }


           

            string _hoBS = "";
            try
            {
                _hoBS = txtHoBS.Text;
            }
            catch { }

            string _tenBS = "";
            try
            {
                _tenBS = txtTenBS.Text;
            }
            catch { }

            DateTime _ngaysinhBacSi = dtpNgaySinhBS.Value;

            try { }
            catch { }

            string _gioiTinh = "";
            try
            {
                _gioiTinh = cmbGioiTinhBS.Text;
            }
            catch { }

            string _chucVu = "";
            try
            {
                _chucVu = txtChucVu.Text;
            }
            catch { }



            string _maKhoa = "";
            try
            {
                _maKhoa = cmbMaKhoa.Text;
            }
            catch { }


            string _hideBS = "";
            try
            {
                _hideBS = cmbHide.Text;
            }
            catch { }

            if (flag == 0)
            {
                // Thêm mới
                if (_maBS == "" || _tenBS == "" || _hoBS == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.BacSiCtrl.InsertBacSi(_maBS, _hoBS, _tenBS, _ngaysinhBacSi, _gioiTinh, _chucVu, _maKhoa, Convert.ToBoolean(_hideBS));
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachBacSi();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.BacSiCtrl.UpdateBacSi(_maBS, _hoBS, _tenBS, _ngaysinhBacSi, _gioiTinh, _chucVu, _maKhoa, Convert.ToBoolean(_hideBS));
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachBacSi();
                    frmBacSi_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            frmBacSi_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Load lại 
            frmBacSi_Load(sender, e);
            dis_end(false);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grbQuanLyBS_Enter(object sender, EventArgs e)
        {

        }
    }
}
