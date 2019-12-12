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
    public partial class frmLoaiXetNghiem : Form
    {
        LoaiXetNghiemMod loaiXetNghiemMod = new LoaiXetNghiemMod();

        int flag = 0;

        public frmLoaiXetNghiem()
        {
            InitializeComponent();
        }

        private void frmLoaiXetNghiem_Load(object sender, EventArgs e)
        {
            dis_end(false);
            HienThiDanhSachLoaiXN();
            bingding();
        }

        void dis_end(bool e)
        {
            txtTenLoaiXN.Enabled = e;
            txtGiaLoaiXN.Enabled = e;

            cmbHide.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }

        public void HienThiDanhSachLoaiXN()
        {
            try
            {
                // Trỏ tới data LoaiXN
                dgvDanhSachLoaiXN.DataSource = Models.LoaiXetNghiemMod.FillDataSetLoaiXetNghiem().Tables[0];

                dgvDanhSachLoaiXN.Dock = DockStyle.Fill;
                dgvDanhSachLoaiXN.RowHeadersVisible = false;
                dgvDanhSachLoaiXN.BorderStyle = BorderStyle.Fixed3D;
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Loại XN!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void bingding()
        {
            try
            {
                txtMaLoaiXN.DataBindings.Clear();
                txtMaLoaiXN.DataBindings.Add("Text", dgvDanhSachLoaiXN.DataSource, "MaLoaiXN");




                txtTenLoaiXN.DataBindings.Clear();
                txtTenLoaiXN.DataBindings.Add("Text", dgvDanhSachLoaiXN.DataSource, "TenLoaiXN");

                txtGiaLoaiXN.DataBindings.Clear();
                txtGiaLoaiXN.DataBindings.Add("Text", dgvDanhSachLoaiXN.DataSource, "GiaLXN");



                //txtQuen.DataBindings.Clear();
                //txtQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");


                cmbHide.DataBindings.Clear();
                cmbHide.DataBindings.Add("Text", dgvDanhSachLoaiXN.DataSource, "Hide");
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Loại XN!",
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
            txtMaLoaiXN.Text = string.Format(loaiXetNghiemMod.GetMaLoaiXNTuDongTang());

            //Models.connection.ExcuteScalar(String.Format("select MaKhoa= Hospital.fnMaKhoaTuDongTang()"));     //MaKhoa tự động tăng

            txtTenLoaiXN.Text = "";
            txtGiaLoaiXN.Text = "";



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
            string _maLoaiXN = "";
            try
            {
                _maLoaiXN = txtMaLoaiXN.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.LoaiXetNghiemCtrl.DeleteLoaiXetNghiem(_maLoaiXN);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachLoaiXN();
                    frmLoaiXetNghiem_Load(sender, e);
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
            string _maLoaiXN = "";
            try
            {
                _maLoaiXN = txtMaLoaiXN.Text;
            }
            catch { }


            string _tenLoaiXN = "";
            try
            {
                _tenLoaiXN = txtTenLoaiXN.Text;
            }
            catch { }

            string _giaLXN = "";
            try
            {
                _giaLXN = txtGiaLoaiXN.Text;
            }
            catch { }


            string _hideLoaiXN = "";
            try
            {
                _hideLoaiXN = cmbHide.Text;
            }
            catch { }

            if (flag == 0)
            {
                // Thêm mới
                if (_maLoaiXN == "" || _tenLoaiXN == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.LoaiXetNghiemCtrl.InsertLoaiXetNghiem(_maLoaiXN, _tenLoaiXN, Convert.ToDouble(_giaLXN), Convert.ToBoolean(_hideLoaiXN));
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachLoaiXN();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.LoaiXetNghiemCtrl.UpdateLoaiXetNghiem(_maLoaiXN, _tenLoaiXN, Convert.ToDouble(_giaLXN), Convert.ToBoolean(_hideLoaiXN));
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachLoaiXN();
                    frmLoaiXetNghiem_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            frmLoaiXetNghiem_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Load lại 
            frmLoaiXetNghiem_Load(sender, e);
            dis_end(false);
        }
    }
}
