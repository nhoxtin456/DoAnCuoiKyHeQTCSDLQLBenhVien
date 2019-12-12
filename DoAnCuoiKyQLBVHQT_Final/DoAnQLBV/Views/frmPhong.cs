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
    public partial class frmPhong : Form
    {
        PhongMod phongMod = new PhongMod();
        public frmPhong()
        {
            InitializeComponent();
        }

        // Khai báo biến để phân biệt lúc THÊM và SỬA
        int flag = 0;

        void dis_end(bool e)
        {

            txtTenPhong.Enabled = e;
            

            cmbMaLoaiPhong.Enabled = e;
            
            cmbHide.Enabled = e;

            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }

        public void HienThiDanhSachPhong()
        {
            try
            {
                // Trỏ tới data Phòng
                dgvDanhSachPhong.DataSource = Models.PhongMod.FillDataSetLoaiPhong().Tables[0];

                dgvDanhSachPhong.Dock = DockStyle.Fill;
                dgvDanhSachPhong.RowHeadersVisible = false;
                dgvDanhSachPhong.BorderStyle = BorderStyle.Fixed3D;

                //dgvDanhsachTD.RowHeadersVisible = false;
                //dgvDanhsachTD.BorderStyle = BorderStyle.Fixed3D;



            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Phòng!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void bingding()
        {
            try
            {
                txtMaPhong.DataBindings.Clear();
                txtMaPhong.DataBindings.Add("Text", dgvDanhSachPhong.DataSource, "MaPhong");



                txtTenPhong.DataBindings.Clear();
                txtTenPhong.DataBindings.Add("Text", dgvDanhSachPhong.DataSource, "TenPhong");

               


                cmbMaLoaiPhong.DataBindings.Clear();
                cmbMaLoaiPhong.DataBindings.Add("Text", dgvDanhSachPhong.DataSource, "MaLoaiPhong");

              




                //txtQuen.DataBindings.Clear();
                //txtQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");


               

             

                cmbHide.DataBindings.Clear();
                cmbHide.DataBindings.Add("Text", dgvDanhSachPhong.DataSource, "Hide");
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Phòng!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        // Hàm load   cho Phòng
        void loadcontrol()
        {


           

            cmbMaLoaiPhong.DataSource = Models.PhongMod.FillDataSet_getMaLoaiPhong().Tables[0];
            cmbMaLoaiPhong.DisplayMember = "MaLoaiPhong";

            cmbHide.Items.Clear();
            cmbHide.Items.Add("False");
            cmbHide.Items.Add("True");


        }


        // Hàm xóa dữ liệu ở textbox lúc ta nhấn vào button
        void ClearData()
        {
            txtMaPhong.Text = string.Format(phongMod.GetMaPhongTuDongTang());


            txtTenPhong.Text = "";
           

            


            //txtQuyen.Text = "";
            loadcontrol(); // Gọi hàm để load Giới tính
        }





        private void frmPhong_Load(object sender, EventArgs e)
        {
            HienThiDanhSachPhong();
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
            string _maPhong = "";
            try
            {
                _maPhong = txtMaPhong.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.PhongCtrl.DeletePhong(_maPhong);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachPhong();
                    frmPhong_Load(sender, e);
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
            string _maPhong = "";
            try
            {
                _maPhong = txtMaPhong.Text;
            }
            catch { }

           

     

            string _tenPhong = "";
            try
            {
                _tenPhong = txtTenPhong.Text;
            }
            catch { }

            string _maLoaiPhong = "";
            try
            {
                _maLoaiPhong = cmbMaLoaiPhong.Text;
            }
            catch { }

            string _hidePhong = "";
            try
            {
                _hidePhong = cmbHide.Text;
            }
            catch { }




            if (flag == 0)
            {
                // Thêm mới
                if (_maPhong == "" || _tenPhong == "" || _maLoaiPhong == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.PhongCtrl.InsertPhong(_maPhong, _tenPhong, _maLoaiPhong, Convert.ToBoolean(_hidePhong));
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachPhong();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.PhongCtrl.UpdatePhong(_maPhong, _tenPhong, _maLoaiPhong, Convert.ToBoolean(_hidePhong));
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachPhong();
                    frmPhong_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            frmPhong_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Load lại 
            frmPhong_Load(sender, e);
            dis_end(false);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            phongMod.undophong();
            frmPhong_Load(sender, e);
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            phongMod.redophong();
            frmPhong_Load(sender, e);
        }
    }
}
