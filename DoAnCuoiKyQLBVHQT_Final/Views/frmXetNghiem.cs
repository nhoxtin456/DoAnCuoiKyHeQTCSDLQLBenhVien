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
    public partial class frmXetNghiem : Form
    {
        XetNghiemMod xetNghiemMod = new XetNghiemMod();
        public frmXetNghiem()
        {
            InitializeComponent();
        }

        // Khai báo biến để phân biệt lúc THÊM và SỬA
        int flag = 0;

        void dis_end(bool e)
        {

            txtTenXN.Enabled = e;


            cmbMaLoaiXN.Enabled = e;

            cmbHide.Enabled = e;

            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }

        public void HienThiDanhSachXN()
        {
            try
            {
                // Trỏ tới data Xét Nghiệm
                dgvDanhSachXN.DataSource = Models.XetNghiemMod.FillDataSetXetNghiem().Tables[0];

                dgvDanhSachXN.Dock = DockStyle.Fill;
                dgvDanhSachXN.RowHeadersVisible = false;
                dgvDanhSachXN.BorderStyle = BorderStyle.Fixed3D;

                //dgvDanhsachTD.RowHeadersVisible = false;
                //dgvDanhsachTD.BorderStyle = BorderStyle.Fixed3D;



            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Xét Nghiệm!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void bingding()
        {
            try
            {
                txtMaXN.DataBindings.Clear();
                txtMaXN.DataBindings.Add("Text", dgvDanhSachXN.DataSource, "MaXN");



                txtTenXN.DataBindings.Clear();
                txtTenXN.DataBindings.Add("Text", dgvDanhSachXN.DataSource, "TenXN");




                cmbMaLoaiXN.DataBindings.Clear();
                cmbMaLoaiXN.DataBindings.Add("Text", dgvDanhSachXN.DataSource, "MaLoaiXN");






                //txtQuen.DataBindings.Clear();
                //txtQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");






                cmbHide.DataBindings.Clear();
                cmbHide.DataBindings.Add("Text", dgvDanhSachXN.DataSource, "Hide");
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Xét Nghiệm!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        // Hàm load   cho XN
        void loadcontrol()
        {




            cmbMaLoaiXN.DataSource = Models.XetNghiemMod.FillDataSetXetNghiem().Tables[0];
            cmbMaLoaiXN.DisplayMember = "MaLoaiXN";

            cmbHide.Items.Clear();
            cmbHide.Items.Add("False");
            cmbHide.Items.Add("True");


        }


        // Hàm xóa dữ liệu ở textbox lúc ta nhấn vào button
        void ClearData()
        {
            txtMaXN.Text = string.Format(xetNghiemMod.GetMaXNTuDongTang());

            txtTenXN.Text = "";

            //txtMaXN.Text = "";





            //txtQuyen.Text = "";
            loadcontrol(); // Gọi hàm để load Giới tính
        }










        private void frmXetNghiem_Load(object sender, EventArgs e)
        {
            HienThiDanhSachXN();
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
            string _maXN = "";
            try
            {
                _maXN = txtMaXN.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.XetNghiemCtrl.DeleteXetNghiem(_maXN);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachXN();
                    frmXetNghiem_Load(sender, e);
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
            string _maXN = "";
            try
            {
                _maXN = txtMaXN.Text;
            }
            catch { }





            string _tenXN = "";
            try
            {
                _tenXN = txtTenXN.Text;
            }
            catch { }

            string _maLoaiXN = "";
            try
            {
                _maLoaiXN = cmbMaLoaiXN.Text;
            }
            catch { }

            string _hideXN = "";
            try
            {
                _hideXN = cmbHide.Text;
            }
            catch { }




            if (flag == 0)
            {
                // Thêm mới
                if (_maXN == "" || _tenXN == "" || _maLoaiXN == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.XetNghiemCtrl.InsertXetNghiem(_maXN, _tenXN, _maLoaiXN, Convert.ToBoolean(_hideXN));
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachXN();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.XetNghiemCtrl.UpdateXetNghiem(_maXN, _tenXN, _maLoaiXN, Convert.ToBoolean(_hideXN));
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachXN();
                    frmXetNghiem_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            frmXetNghiem_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Load lại 
            frmXetNghiem_Load(sender, e);
            dis_end(false);
        }
    }
}
