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
    public partial class frmToaThuoc : Form
    {
        ToaThuocMod toaThuocMod = new ToaThuocMod();





        public frmToaThuoc()
        {
            InitializeComponent();
        }

        // Khai báo biến để phân biệt lúc THÊM và SỬA
        int flag = 0;

        void dis_end(bool e)
        {


            cmbMaThuoc.Enabled = e;
            cmbMaBA.Enabled = e;
            txtSoLuong.Enabled = e;


            cmbHide.Enabled = e;



            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }

        public void HienThiDanhSachToaThuoc()
        {
            try
            {
                // Trỏ tới data ToaThuoc
                dgvDanhSachToaThuoc.DataSource = Models.ToaThuocMod.FillDataSetToaThuoc().Tables[0];

                dgvDanhSachToaThuoc.Dock = DockStyle.Fill;
                dgvDanhSachToaThuoc.RowHeadersVisible = false;
                dgvDanhSachToaThuoc.BorderStyle = BorderStyle.Fixed3D;

                //dgvDanhsachTD.RowHeadersVisible = false;
                //dgvDanhsachTD.BorderStyle = BorderStyle.Fixed3D;



            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng ToaThuoc!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void bingding()
        {
            try
            {
                cmbMaThuoc.DataBindings.Clear();
                cmbMaThuoc.DataBindings.Add("Text", dgvDanhSachToaThuoc.DataSource, "MaThuoc");

                cmbMaBA.DataBindings.Clear();
                cmbMaBA.DataBindings.Add("Text", dgvDanhSachToaThuoc.DataSource, "MaBA");

                txtSoLuong.DataBindings.Clear();
                txtSoLuong.DataBindings.Add("Text", dgvDanhSachToaThuoc.DataSource, "SoLuong");

                cmbHide.DataBindings.Clear();
                cmbHide.DataBindings.Add("Text", dgvDanhSachToaThuoc.DataSource, "Hide");










                //txtQuen.DataBindings.Clear();
                //txtQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");








            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng ToaThuoc!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        // Hàm load 
        void loadcontrol()
        {

            cmbMaThuoc.DataSource = Models.ToaThuocMod.FillDataSet_getMaThuoc().Tables[0];
            cmbMaThuoc.DisplayMember = "MaThuoc";

            cmbMaBA.DataSource = Models.ToaThuocMod.FillDataSet_getMaBA().Tables[0];
            cmbMaBA.DisplayMember = "MaBA";



            cmbHide.Items.Clear();
            cmbHide.Items.Add("False");
            cmbHide.Items.Add("True");





        }


        // Hàm xóa dữ liệu ở textbox lúc ta nhấn vào button
        void ClearData()
        {


            txtSoLuong.Text = "";



            //txtQuyen.Text = "";
            loadcontrol(); // Gọi hàm 
        }







        private void frmToaThuoc_Load(object sender, EventArgs e)
        {
            HienThiDanhSachToaThuoc();
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

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra khai báo các biến 
            string _maThuoc = "";
            try
            {
                _maThuoc = cmbMaThuoc.Text;
            }
            catch { }

            string _maBA = "";
            try
            {
                _maBA = cmbMaBA.Text;
            }
            catch { }

            string _soLuong =  "";

            try {
                _soLuong = txtSoLuong.Text;
            }
            catch { }


            string _hideToaThuoc = "";
            try
            {
                _hideToaThuoc = cmbHide.Text;
            }
            catch { }


            if (flag == 0)
            {
                // Thêm mới
                if (_maThuoc == "" || _maBA == "" )
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.ToaThuocCtrl.InsertToaThuoc(_maThuoc, _maBA, Convert.ToInt32(_soLuong), Convert.ToBoolean(_hideToaThuoc));
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachToaThuoc();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.ToaThuocCtrl.UpdateToaThuoc(_maThuoc, _maBA, Convert.ToInt32(_soLuong), Convert.ToBoolean(_hideToaThuoc));
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachToaThuoc();
                    frmToaThuoc_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            frmToaThuoc_Load(sender, e);
        }
    

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Load lại 
            frmToaThuoc_Load(sender, e);
            dis_end(false);
        }
    }
}
