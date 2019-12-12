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
    public partial class frmBenhNhan : Form
    {
        public frmBenhNhan()
        {
            InitializeComponent();
        }

        // Khai báo biến để phân biệt lúc THÊM và SỬA
        int flag = 0;

        void dis_end(bool e)
        {
            txtHoBN.Enabled = e;
            txtTenBN.Enabled = e;
            dtpNgaySinhBN.Enabled = e;
            cmbGioiTinhBN.Enabled = e;
            //txtQuyen.Enabled = e;
            cmbHide.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }

        public void HienThiDanhSachBenhNhan()
        {
            try
            {
                // Trỏ tới data Bệnh Nhân
                dgvDanhSachBN.DataSource = Models.BenhNhanMod.FillDataSetBenhNhan().Tables[0];
               
                dgvDanhSachBN.Dock = DockStyle.Fill;
                dgvDanhSachBN.RowHeadersVisible = false;
                dgvDanhSachBN.BorderStyle = BorderStyle.Fixed3D;
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Bệnh Nhân!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void bingding()
        {
            try
            {
                txtMaBN.DataBindings.Clear();
                txtMaBN.DataBindings.Add("Text", dgvDanhSachBN.DataSource, "MaBN");

               

                txtHoBN.DataBindings.Clear();
                txtHoBN.DataBindings.Add("Text", dgvDanhSachBN.DataSource, "HoBN");

                txtTenBN.DataBindings.Clear();
                txtTenBN.DataBindings.Add("Text", dgvDanhSachBN.DataSource, "TenBN");

                dtpNgaySinhBN.DataBindings.Clear();
                dtpNgaySinhBN.DataBindings.Add("Text", dgvDanhSachBN.DataSource, "NgaySinh");

                cmbGioiTinhBN.DataBindings.Clear();
                cmbGioiTinhBN.DataBindings.Add("Text", dgvDanhSachBN.DataSource, "GioiTinh");

             

                //txtQuen.DataBindings.Clear();
                //txtQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");

               
                cmbHide.DataBindings.Clear();
                cmbHide.DataBindings.Add("Text", dgvDanhSachBN.DataSource, "Hide");
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Bệnh Nhân!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        // Hàm load giới tính cho Bệnh Nhân 
        void loadcontrol()
        {
            cmbGioiTinhBN.Items.Clear();
            cmbGioiTinhBN.Items.Add("Nam");
            cmbGioiTinhBN.Items.Add("Nữ");
           
            cmbHide.Items.Clear();
            cmbHide.Items.Add("False");
            cmbHide.Items.Add("True");
        }


        // Hàm xóa dữ liệu ở textbox lúc ta nhấn vào button
        void ClearData()
        {
            txtMaBN.Text = Models.connection.ExcuteScalar(String.Format("select MaBN= Hospital.fnMaBenhNhanTuDongTang()"));     //MaBenhNhan tự động tăng
           
            txtHoBN.Text = "";
            txtTenBN.Text = "";
            
           
            //txtQuyen.Text = "";
            loadcontrol(); // Gọi hàm để load Giới tính
        }


        // Tạo hàm dữ liệu để trỏ đến dữ liệu trên DataGridView
        public void nhung(Control ctr)
        {
            try
            {
                pnlDanhSachBN.Controls.Clear();
                pnlDanhSachBN.BorderStyle = BorderStyle.Fixed3D;
                ctr.Dock = DockStyle.Fill;
                pnlDanhSachBN.Controls.Add(ctr);
                pnlDanhSachBN.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Bệnh Nhân!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void frmBenhNhan_Load(object sender, EventArgs e)
        {
            dis_end(false);
            HienThiDanhSachBenhNhan();
            bingding();
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Load lại 
            frmBenhNhan_Load(sender, e);
            dis_end(false);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            uctSearchBenhNhan uctSearch = new uctSearchBenhNhan();
            nhung(uctSearch);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlDanhSachBN.Controls.Clear();
            pnlDanhSachBN.BorderStyle = BorderStyle.None;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _maBenhNhan = "";
            try
            {
                _maBenhNhan = txtMaBN.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.BenhNhanCtrl.DeleteBenhNhan(_maBenhNhan);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachBenhNhan();
                    frmBenhNhan_Load(sender, e);
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
            string _maBenhNhan = "";
            try
            {
                _maBenhNhan = txtMaBN.Text;
            }
            catch { }

           


            string _hoBenhNhan = "";
            try
            {
                _hoBenhNhan = txtHoBN.Text;
            }
            catch { }

            string _tenBenhNhan = "";
            try
            {
                _tenBenhNhan = txtTenBN.Text;
            }
            catch { }

            DateTime _ngaysinhBenhNhan = dtpNgaySinhBN.Value;

            try { }
            catch { }

            string _giotinhBenhNhan = "";
            try
            {
                _giotinhBenhNhan = cmbGioiTinhBN.Text;
            }
            catch { }

           

            string _hideBN = "";
            try
            {
                _hideBN = cmbHide.Text;
            }
            catch { }

            if (flag == 0)
            {
                // Thêm mới
                if (_maBenhNhan == "" || _tenBenhNhan == "" || _hoBenhNhan == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.BenhNhanCtrl.InsertBenhNhan(_maBenhNhan, _hoBenhNhan, _tenBenhNhan, _ngaysinhBenhNhan, _giotinhBenhNhan, Convert.ToBoolean(_hideBN));
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachBenhNhan();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.BenhNhanCtrl.UpdateBenhNhan(_maBenhNhan, _hoBenhNhan, _tenBenhNhan, _ngaysinhBenhNhan, _giotinhBenhNhan, Convert.ToBoolean(_hideBN));
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachBenhNhan();
                    frmBenhNhan_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            frmBenhNhan_Load(sender, e);
        }

      
    }
}
