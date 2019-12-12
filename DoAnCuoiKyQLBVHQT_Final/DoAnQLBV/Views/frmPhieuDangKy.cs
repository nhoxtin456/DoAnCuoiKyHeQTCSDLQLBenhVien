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
    public partial class frmPhieuDangKy : Form
    {
        public frmPhieuDangKy()
        {
            InitializeComponent();
        }

        // Khai báo biến để phân biệt lúc THÊM và SỬA
        int flag = 0;

        void dis_end(bool e)
        {

           

           
            cmbHide.Enabled = e;
            cmbMaNV.Enabled = e;
            cmbMaBN.Enabled = e;
            cmbMaKhoa.Enabled = e;
            cmbMaBA.Enabled = e;
           

            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }

        public void HienThiDanhSachPhieuDK()
        {
            try
            {
                // Trỏ tới data Phiếu Đăng Ký
                dgvDanhSachPhieuDK.DataSource = Models.PhieuDangKyMod.FillDataSetPhieuDangKy().Tables[0];

                dgvDanhSachPhieuDK.Dock = DockStyle.Fill;
                dgvDanhSachPhieuDK.RowHeadersVisible = false;
                dgvDanhSachPhieuDK.BorderStyle = BorderStyle.Fixed3D;

                //dgvDanhsachTD.RowHeadersVisible = false;
                //dgvDanhsachTD.BorderStyle = BorderStyle.Fixed3D;



            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Phiếu Đăng Ký!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void bingding()
        {
            try
            {
                txtMaPhieuDK.DataBindings.Clear();
                txtMaPhieuDK.DataBindings.Add("Text", dgvDanhSachPhieuDK.DataSource, "MaPhieuDK");

                cmbHide.DataBindings.Clear();
                cmbHide.DataBindings.Add("Text", dgvDanhSachPhieuDK.DataSource, "Hide");

               


                cmbMaNV.DataBindings.Clear();
                cmbMaNV.DataBindings.Add("Text", dgvDanhSachPhieuDK.DataSource, "MaNV");

                cmbMaBN.DataBindings.Clear();
                cmbMaBN.DataBindings.Add("Text", dgvDanhSachPhieuDK.DataSource, "MaBN");

                cmbMaKhoa.DataBindings.Clear();
                cmbMaKhoa.DataBindings.Add("Text", dgvDanhSachPhieuDK.DataSource, "MaKhoa");

                cmbMaBA.DataBindings.Clear();
                cmbMaBA.DataBindings.Add("Text", dgvDanhSachPhieuDK.DataSource, "MaBA");



                //txtQuen.DataBindings.Clear();
                //txtQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");


               

              


              
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Phiếu Đăng Ký!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        // Hàm load 
        void loadcontrol()
        {


            cmbHide.Items.Clear();
            cmbHide.Items.Add("False");
            cmbHide.Items.Add("True");

            cmbMaNV.DataSource = Models.NhanVienMod.FillDataSet_getMaNV().Tables[0];
            cmbMaNV.DisplayMember = "MaNV";

            cmbMaBN.DataSource = Models.BenhNhanMod.FillDataSet_getMaBN().Tables[0];
            cmbMaBN.DisplayMember = "MaBN";

            cmbMaKhoa.DataSource = Models.KhoaMod.FillDataSet_getMaKhoa().Tables[0];
            cmbMaKhoa.DisplayMember = "MaKhoa";

            cmbMaBA.DataSource = Models.HoSoBenhAnMod.FillDataSet_getMaHoSoBA().Tables[0];
            cmbMaBA.DisplayMember = "MaBA";


        }


        // Hàm xóa dữ liệu ở textbox lúc ta nhấn vào button
        void ClearData()
        {
            txtMaPhieuDK.Text = Models.connection.ExcuteScalar(String.Format("select MaPhieuDK= Hospital.fnMaPhieuDKTuDongTang()"));     //MaPhieuDK tự động tăng


            


            //txtQuyen.Text = "";
            loadcontrol(); // Gọi hàm 
        }

        private void frmPhieuDangKy_Load(object sender, EventArgs e)
        {
            HienThiDanhSachPhieuDK();
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
            string _maPhieuDK = "";
            try
            {
                _maPhieuDK = txtMaPhieuDK.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.PhieuDangKyCtrl.DeletePhieuDangKy(_maPhieuDK);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachPhieuDK();
                    frmPhieuDangKy_Load(sender, e);
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
            string _maPhieuDK = "";
            try
            {
                _maPhieuDK = txtMaPhieuDK.Text;
            }
            catch { }

            string _hidePDK = "";
            try
            {
                _hidePDK = cmbHide.Text;
            }
            catch { }

            string _maNV = "";
            try
            {
                _maNV = cmbMaNV.Text;
            }
            catch { }

            string _maBN = "";
            try
            {
                _maBN = cmbMaBN.Text;
            }
            catch { }

            string _maKhoa = "";
            try
            {
                _maKhoa = cmbMaKhoa.Text;
            }
            catch { }






            string _maBA = "";
            try
            {
                _maBA = cmbMaBA.Text;
            }
            catch { }


          

            if (flag == 0)
            {
                // Thêm mới
                if (_maPhieuDK == "" || _maNV == "" || _maBN == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.PhieuDangKyCtrl.InsertPhieuDangKy(_maPhieuDK, Convert.ToBoolean(_hidePDK), _maNV, _maBN, _maKhoa, _maBA);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachPhieuDK();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.PhieuDangKyCtrl.UpdatePhieuDangKy(_maPhieuDK, Convert.ToBoolean(_hidePDK), _maNV, _maBN, _maKhoa, _maBA);
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachPhieuDK();
                    frmPhieuDangKy_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            frmPhieuDangKy_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Load lại 
            frmPhieuDangKy_Load(sender, e);
            dis_end(false);
        }
    }

}
        
