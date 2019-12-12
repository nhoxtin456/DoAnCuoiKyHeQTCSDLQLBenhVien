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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }

        // Khai báo biến để phân biệt lúc THÊM và SỬA
        int flag = 0;

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            dis_end(false);
            HienThiDanhSachKhoa();
            bingding();
        }



        void dis_end(bool e)
        {
            txtTenKhoa.Enabled = e;

            cmbHide.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }

        public void HienThiDanhSachKhoa()
        {
            try
            {
                // Trỏ tới data Khoa
                dgvDanhSachKhoa.DataSource = Models.KhoaMod.FillDataSetKhoa().Tables[0];

                dgvDanhSachKhoa.Dock = DockStyle.Fill;
                dgvDanhSachKhoa.RowHeadersVisible = false;
                dgvDanhSachKhoa.BorderStyle = BorderStyle.Fixed3D;
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Khoa!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void bingding()
        {
            try
            {
                txtMaKhoa.DataBindings.Clear();
                txtMaKhoa.DataBindings.Add("Text", dgvDanhSachKhoa.DataSource, "MaKhoa");



                txtTenKhoa.DataBindings.Clear();
                txtTenKhoa.DataBindings.Add("Text", dgvDanhSachKhoa.DataSource, "TenKhoa");





                //txtQuen.DataBindings.Clear();
                //txtQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");


                cmbHide.DataBindings.Clear();
                cmbHide.DataBindings.Add("Text", dgvDanhSachKhoa.DataSource, "Hide");
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Khoa!",
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
            txtMaKhoa.Text = Models.connection.ExcuteScalar(String.Format("select MaKhoa= Hospital.fnMaKhoaTuDongTang()"));     //MaKhoa tự động tăng

            txtTenKhoa.Text = "";



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

       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra khai báo các biến 
            string _maKhoa = "";
            try
            {
                _maKhoa = txtMaKhoa.Text;
            }
            catch { }


            string _tenKhoa = "";
            try
            {
                _tenKhoa = txtTenKhoa.Text;
            }
            catch { }


            string _hideKhoa = "";
            try
            {
                _hideKhoa = cmbHide.Text;
            }
            catch { }

            if (flag == 0)
            {
                // Thêm mới
                if (_maKhoa == "" || _tenKhoa == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.KhoaCtrl.InsertKhoa(_maKhoa, _tenKhoa, Convert.ToBoolean(_hideKhoa));
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachKhoa();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.KhoaCtrl.UpdateKhoa(_maKhoa, _tenKhoa, Convert.ToBoolean(_hideKhoa));
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachKhoa();
                    frmKhoa_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            frmKhoa_Load(sender, e);
        }
    
        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Load lại 
            frmKhoa_Load(sender, e);
            dis_end(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _maKhoa = "";
            try
            {
                _maKhoa = txtMaKhoa.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.KhoaCtrl.DeleteKhoa(_maKhoa);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachKhoa();
                    frmKhoa_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }
    }
}
