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
    public partial class frmThuoc : Form
    {
        ThuocMod thuocMod = new ThuocMod();
        // Khai báo biến để phân biệt lúc THÊM và SỬA
        int flag = 0;
        public frmThuoc()
        {
            InitializeComponent();
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {
            dis_end(false);
            HienThiDanhSachLoaiThuoc();
            bingding();
        }

       
    

        void dis_end(bool e)
        {
            txtTenThuoc.Enabled = e;
            txtGiaThuoc.Enabled = e;



            cmbHide.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }

        public void HienThiDanhSachLoaiThuoc()
        {
            try
            {
                // Trỏ tới data Thuoc
                dgvDanhSachThuoc.DataSource = Models.ThuocMod.FillDataSetThuoc().Tables[0];

                dgvDanhSachThuoc.Dock = DockStyle.Fill;
                dgvDanhSachThuoc.RowHeadersVisible = false;
                dgvDanhSachThuoc.BorderStyle = BorderStyle.Fixed3D;
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Thuốc!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void bingding()
        {
            try
            {
                txtMaThuoc.DataBindings.Clear();
                txtMaThuoc.DataBindings.Add("Text", dgvDanhSachThuoc.DataSource, "MaThuoc");




                txtTenThuoc.DataBindings.Clear();
                txtTenThuoc.DataBindings.Add("Text", dgvDanhSachThuoc.DataSource, "TenThuoc");

                txtGiaThuoc.DataBindings.Clear();
                txtGiaThuoc.DataBindings.Add("Text", dgvDanhSachThuoc.DataSource, "GiaThuoc");



                //txtQuen.DataBindings.Clear();
                //txtQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");


                cmbHide.DataBindings.Clear();
                cmbHide.DataBindings.Add("Text", dgvDanhSachThuoc.DataSource, "Hide");
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Thuốc!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        void loadcontrol()
        {



            cmbHide.Items.Clear();
            cmbHide.Items.Add("False");
            cmbHide.Items.Add("True");
        }


        // Hàm xóa dữ liệu ở textbox lúc ta nhấn vào button
        void ClearData()
        {
            txtMaThuoc.Text = string.Format(thuocMod.GetMaThuocTuDongTang());

            //Models.connection.ExcuteScalar(String.Format("select MaKhoa= Hospital.fnMaKhoaTuDongTang()"));     //MaKhoa tự động tăng

            txtTenThuoc.Text = "";
            txtGiaThuoc.Text = "";



            //txtQuyen.Text = "";
            loadcontrol(); // Gọi hàm để load Giới tính
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
            string _maThuoc = "";
            try
            {
                _maThuoc = txtMaThuoc.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.ThuocCtrl.DeleteThuoc(_maThuoc);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachLoaiThuoc();
                    frmThuoc_Load(sender, e);
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
            string _maThuoc = "";
            try
            {
                _maThuoc = txtMaThuoc.Text;
            }
            catch { }


            string _tenThuoc = "";
            try
            {
                _tenThuoc = txtTenThuoc.Text;
            }
            catch { }

            string _giaThuoc = "";
            try
            {
                _giaThuoc = txtGiaThuoc.Text;
            }
            catch { }


            string _hideThuoc = "";
            try
            {
                _hideThuoc = cmbHide.Text;
            }
            catch { }

            if (flag == 0)
            {
                // Thêm mới
                if (_maThuoc == "" || _tenThuoc == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.ThuocCtrl.InsertThuoc(_maThuoc, _tenThuoc, Convert.ToDouble(_giaThuoc), Convert.ToBoolean(_hideThuoc));
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachLoaiThuoc();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.ThuocCtrl.UpdateThuoc(_maThuoc, _tenThuoc, Convert.ToDouble(_giaThuoc), Convert.ToBoolean(_hideThuoc));
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachLoaiThuoc();
                    frmThuoc_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            frmThuoc_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Load lại 
            frmThuoc_Load(sender, e);
            dis_end(false);
        }
    }
}
