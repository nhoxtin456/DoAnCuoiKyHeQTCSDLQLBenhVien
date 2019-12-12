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
    public partial class frmLoaiPhong : Form
    {
        LoaiPhongMod loaiPhongMod = new LoaiPhongMod();

        // Khai báo biến để phân biệt lúc THÊM và SỬA
        int flag = 0;
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            dis_end(false);
            HienThiDanhSachLoaiPhong();
            bingding();
         
        }

      
        void dis_end(bool e)
        {
            txtTenLoaiPhong.Enabled = e;
            txtGiaPhong.Enabled = e;

            

            cmbHide.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }

        public void HienThiDanhSachLoaiPhong()
        {
            try
            {
                // Trỏ tới data LoaiPhong
                dgvDanhSachLoaiPhong.DataSource = Models.LoaiPhongMod.FillDataSetLoaiPhong().Tables[0];

                dgvDanhSachLoaiPhong.Dock = DockStyle.Fill;
                dgvDanhSachLoaiPhong.RowHeadersVisible = false;
                dgvDanhSachLoaiPhong.BorderStyle = BorderStyle.Fixed3D;
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Loại Phòng!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void bingding()
        {
            try
            {
                txtMaLoaiPhong.DataBindings.Clear();
                txtMaLoaiPhong.DataBindings.Add("Text", dgvDanhSachLoaiPhong.DataSource, "MaLoaiPhong");




                txtTenLoaiPhong.DataBindings.Clear();
                txtTenLoaiPhong.DataBindings.Add("Text", dgvDanhSachLoaiPhong.DataSource, "TenLoaiPhong");

                txtGiaPhong.DataBindings.Clear();
                txtGiaPhong.DataBindings.Add("Text", dgvDanhSachLoaiPhong.DataSource, "GiaPhong");



                //txtQuen.DataBindings.Clear();
                //txtQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");


                cmbHide.DataBindings.Clear();
                cmbHide.DataBindings.Add("Text", dgvDanhSachLoaiPhong.DataSource, "Hide");
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Loại Phòng!",
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
            txtMaLoaiPhong.Text = string.Format(loaiPhongMod.GetMaLoaiPhongTuDongTang());
                
                //Models.connection.ExcuteScalar(String.Format("select MaKhoa= Hospital.fnMaKhoaTuDongTang()"));     //MaKhoa tự động tăng

            txtTenLoaiPhong.Text = "";
            txtGiaPhong.Text = "";



            //txtQuyen.Text = "";
            loadcontrol(); // Gọi hàm để load Giới tính
        }

       

         

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            flag = 0;
            ClearData();
            dis_end(true);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            // Lúc click sửa mặc định cho flag = 1;
            flag = 1;
            dis_end(true); // Lúc này các nút thêm, sửa , xóa sẽ ẩn đi, chỉ còn nút lưu và hủy
            loadcontrol();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string _maLoaiPhong = "";
            try
            {
                _maLoaiPhong = txtMaLoaiPhong.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.LoaiPhongCtrl.DeleteLoaiPhong(_maLoaiPhong);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachLoaiPhong();
                    frmLoaiPhong_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra khai báo các biến 
            string _maLoaiPhong = "";
            try
            {
                _maLoaiPhong = txtMaLoaiPhong.Text;
            }
            catch { }


            string _tenLoaiPhong = "";
            try
            {
                _tenLoaiPhong = txtTenLoaiPhong.Text;
            }
            catch { }

            string _giaPhong = "";
            try
            {
                _giaPhong = txtGiaPhong.Text;
            }
            catch { }


            string _hideLoaiPhong = "";
            try
            {
                _hideLoaiPhong = cmbHide.Text;
            }
            catch { }

            if (flag == 0)
            {
                // Thêm mới
                if (_maLoaiPhong == "" || _tenLoaiPhong == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.LoaiPhongCtrl.InsertLoaiPhong(_maLoaiPhong, _tenLoaiPhong, Convert.ToDouble(_giaPhong), Convert.ToBoolean(_hideLoaiPhong));
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachLoaiPhong();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.LoaiPhongCtrl.UpdateLoaiPhong(_maLoaiPhong, _tenLoaiPhong, Convert.ToDouble(_giaPhong), Convert.ToBoolean(_hideLoaiPhong));
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachLoaiPhong();
                    frmLoaiPhong_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            frmLoaiPhong_Load(sender, e);
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            // Load lại 
            frmLoaiPhong_Load(sender, e);
            dis_end(false);
        }
    }
}
