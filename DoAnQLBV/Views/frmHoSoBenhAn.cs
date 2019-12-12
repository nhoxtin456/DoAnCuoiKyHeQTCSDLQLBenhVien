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
    public partial class frmHoSoBenhAn : Form
    {
        HoSoBenhAnMod hoSoBenhAnMod = new HoSoBenhAnMod();
        public frmHoSoBenhAn()
        {
            InitializeComponent();
        }

        // Khai báo biến để phân biệt lúc THÊM và SỬA
        int flag = 0;

        void dis_end(bool e)
        {

            txtChuanDoanBenh.Enabled = e;
            txtSoNgayO.Enabled = e;

            cmbMaBS.Enabled = e;
            cmbMaPhong.Enabled = e;
            cmbHide.Enabled = e;
            



            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }

        public void HienThiDanhSachHSBA()
        {
            try
            {
                // Trỏ tới data HSBA
                dgvDanhSachHSBA.DataSource = Models.HoSoBenhAnMod.FillDataSetHoSoBenhAn().Tables[0];

                dgvDanhSachHSBA.Dock = DockStyle.Fill;
                dgvDanhSachHSBA.RowHeadersVisible = false;
                dgvDanhSachHSBA.BorderStyle = BorderStyle.Fixed3D;

                //dgvDanhsachTD.RowHeadersVisible = false;
                //dgvDanhsachTD.BorderStyle = BorderStyle.Fixed3D;



            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng HSBA!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void bingding()
        {
            try
            {
                txtMaBA.DataBindings.Clear();
                txtMaBA.DataBindings.Add("Text", dgvDanhSachHSBA.DataSource, "MaBA");

                txtChuanDoanBenh.DataBindings.Clear();
                txtChuanDoanBenh.DataBindings.Add("Text", dgvDanhSachHSBA.DataSource, "ChuanDoanBenh");

                cmbMaBS.DataBindings.Clear();
                cmbMaBS.DataBindings.Add("Text", dgvDanhSachHSBA.DataSource, "MaBS");

                cmbMaPhong.DataBindings.Clear();
                cmbMaPhong.DataBindings.Add("Text", dgvDanhSachHSBA.DataSource, "MaPhong");

                txtSoNgayO.DataBindings.Clear();
                txtSoNgayO.DataBindings.Add("Text", dgvDanhSachHSBA.DataSource, "SoNgayO");


                cmbHide.DataBindings.Clear();
                cmbHide.DataBindings.Add("Text", dgvDanhSachHSBA.DataSource, "Hide");







                //txtQuen.DataBindings.Clear();
                //txtQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");








            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng HSBA !",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        // Hàm load 
        void loadcontrol()
        {


            cmbMaBS.DataSource = Models.HoSoBenhAnMod.FillDataSet_getMaBS().Tables[0];
            cmbMaBS.DisplayMember = "MaBS";



            cmbMaPhong.DataSource = Models.HoSoBenhAnMod.FillDataSet_getMaPhong().Tables[0];
            cmbMaPhong.DisplayMember = "MaPhong";

            
            cmbHide.Items.Clear();
            cmbHide.Items.Add("False");
            cmbHide.Items.Add("True");

            




        }


        // Hàm xóa dữ liệu ở textbox lúc ta nhấn vào button
        void ClearData()
        {
            txtMaBA.Text = string.Format(hoSoBenhAnMod.GetMaBATuDongTang());

            txtChuanDoanBenh.Text = "";
            txtSoNgayO.Text = "";



            //txtQuyen.Text = "";
            loadcontrol(); // Gọi hàm 
        }







        private void frmHoSoBenhAn_Load(object sender, EventArgs e)
        {
            HienThiDanhSachHSBA();
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
            string _maBA = "";
            try
            {
                _maBA = txtMaBA.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.HoSoBenhAnCtrl.DeleteHoSoBenhAn(_maBA);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachHSBA();
                    frmHoSoBenhAn_Load(sender, e);
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
            string _maBA = "";
            try
            {
                _maBA = txtMaBA.Text;
            }
            catch { }

            string _chuanDoanBenh = "";
            try
            {
                _chuanDoanBenh = txtChuanDoanBenh.Text;
            }
            catch { }

            string _maBS = "";
            try
            {
                _maBS = cmbMaBS.Text;
            }
            catch { }

            string _maPhong = "";
            try
            {
                _maPhong = cmbMaPhong.Text;
            }
            catch { }

            string _soNgayO = "";
            try
            {
                _soNgayO = txtSoNgayO.Text;
            }
            catch { }

            string _hidemaBA = "";
            try
            {
                _hidemaBA = cmbHide.Text;
            }
            catch { }

         
           






            if (flag == 0)
            {
                // Thêm mới
                if (_maBA == "" || _chuanDoanBenh == "" || _maBS == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.HoSoBenhAnCtrl.InsertHoSoBenhAn(_maBA, txtChuanDoanBenh.Text, _maBS, _maPhong, Convert.ToDouble(txtSoNgayO.Text), Convert.ToBoolean(_hidemaBA));
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachHSBA();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.HoSoBenhAnCtrl.UpdateHoSoBenhAn(_maBA, txtChuanDoanBenh.Text, _maBS, _maPhong, Convert.ToDouble(txtSoNgayO.Text), Convert.ToBoolean(_hidemaBA));
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachHSBA();
                    frmHoSoBenhAn_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            frmHoSoBenhAn_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Load lại 
            frmHoSoBenhAn_Load(sender, e);
            dis_end(false);
        }
    }
}
