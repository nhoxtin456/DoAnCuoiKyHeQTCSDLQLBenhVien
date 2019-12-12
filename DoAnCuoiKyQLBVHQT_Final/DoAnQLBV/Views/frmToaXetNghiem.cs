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
    public partial class frmToaXetNghiem : Form
    {
        ToaXetNghiemMod toaXetNghiemMod = new ToaXetNghiemMod();
        public frmToaXetNghiem()
        {
            InitializeComponent();
        }


        // Khai báo biến để phân biệt lúc THÊM và SỬA
        int flag = 0;

        void dis_end(bool e)
        {


            cmbMaXN.Enabled = e;
            cmbMaBA.Enabled = e;
            dtpNgayXN.Enabled = e;
            

            cmbHide.Enabled = e;
           


            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }

        public void HienThiDanhSachToaXN()
        {
            try
            {
                // Trỏ tới data ToaXN
                dgvDanhSachToaXN.DataSource = Models.ToaXetNghiemMod.FillDataSetToaXetNghiem().Tables[0];

                dgvDanhSachToaXN.Dock = DockStyle.Fill;
                dgvDanhSachToaXN.RowHeadersVisible = false;
                dgvDanhSachToaXN.BorderStyle = BorderStyle.Fixed3D;

                //dgvDanhsachTD.RowHeadersVisible = false;
                //dgvDanhsachTD.BorderStyle = BorderStyle.Fixed3D;



            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng ToaXN!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void bingding()
        {
            try
            {
                cmbMaXN.DataBindings.Clear();
                cmbMaXN.DataBindings.Add("Text", dgvDanhSachToaXN.DataSource, "MaXN");

                cmbMaBA.DataBindings.Clear();
                cmbMaBA.DataBindings.Add("Text", dgvDanhSachToaXN.DataSource, "MaBA");

                dtpNgayXN.DataBindings.Clear();
                dtpNgayXN.DataBindings.Add("Text", dgvDanhSachToaXN.DataSource, "NgayXN");

                cmbHide.DataBindings.Clear();
                cmbHide.DataBindings.Add("Text", dgvDanhSachToaXN.DataSource, "Hide");




              

               



                //txtQuen.DataBindings.Clear();
                //txtQuyen.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Quyen");








            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng ToaXN!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        // Hàm load 
        void loadcontrol()
        {

            cmbMaXN.DataSource = Models.ToaXetNghiemMod.FillDataSet_getMaXN().Tables[0];
            cmbMaXN.DisplayMember = "MaXN";

            cmbMaBA.DataSource = Models.ToaXetNghiemMod.FillDataSet_getMaBA().Tables[0];
            cmbMaBA.DisplayMember = "MaBA";



            cmbHide.Items.Clear();
            cmbHide.Items.Add("False");
            cmbHide.Items.Add("True");

          



        }


        // Hàm xóa dữ liệu ở textbox lúc ta nhấn vào button
        void ClearData()
        {
            





            //txtQuyen.Text = "";
            loadcontrol(); // Gọi hàm 
        }








        private void frmToaXetNghiem_Load(object sender, EventArgs e)
        {
            HienThiDanhSachToaXN();
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
            string _maXN = "";
            try
            {
                _maXN = cmbMaXN.Text;
            }
            catch { }

            string _maBA = "";
            try
            {
                _maBA = cmbMaBA.Text;
            }
            catch { }

            DateTime _ngayXN = dtpNgayXN.Value;

            try { }
            catch { }


            string _hideToaXN = "";
            try
            {
                _hideToaXN = cmbHide.Text;
            }
            catch { }

            if (flag == 0)
            {
                // Thêm mới
                if (_maXN == "" || _maBA == "" )
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.ToaXetNghiemCtrl.InsertToaXetNghiem(_maXN, _maBA, _ngayXN, Convert.ToBoolean(_hideToaXN));
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachToaXN();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.ToaXetNghiemCtrl.UpdateToaXetNghiem(_maXN, _maBA, _ngayXN, Convert.ToBoolean(_hideToaXN));
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachToaXN();
                    frmToaXetNghiem_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            frmToaXetNghiem_Load(sender, e);
        }


    

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Load lại 
            frmToaXetNghiem_Load(sender, e);
            dis_end(false);
        }
    }
}
