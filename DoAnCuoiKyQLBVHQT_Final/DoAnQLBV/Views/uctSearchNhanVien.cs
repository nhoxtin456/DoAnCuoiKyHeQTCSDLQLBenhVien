using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBV.Views
{
    public partial class uctSearchNhanVien : UserControl
    {
        public uctSearchNhanVien()
        {
            InitializeComponent();
        }

        void loadcontrol()
        {
            try
            {
                cmbFind.Items.Clear();
                cmbFind.Items.Add("Mã Nhân Viên");
                cmbFind.Items.Add("Tên Nhân Viên");
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Nhân Viên!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void uctSearchNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                cmbFind.Text = "Mã Nhân Viên";
                loadcontrol();
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Nhân Viên!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFind.Text == "")
                    MessageBox.Show("Hãy nhập vào ô tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    if (cmbFind.Text == "Mã Nhân Viên")
                    {
                        string _maNhanVien = txtFind.Text.ToString();
                        DataTable dt = new DataTable();
                        dt = Controllers.NhanVienCtrl.FillDataSet_getSearchNVbyId(_maNhanVien).Tables[0];

                        if (dt.Rows.Count > 0)
                        {
                            dgvDanhSachNV.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("MaNV " + txtFind.Text + " Không có trong dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        string _tenFind = txtFind.Text.ToString();
                        DataTable dt = new DataTable();
                        dt = Controllers.NhanVienCtrl.FillDataSet_FindNVByTen(_tenFind).Tables[0];

                        if (dt.Rows.Count > 0)
                        {
                            dgvDanhSachNV.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("TenNV " + txtFind.Text + " Không có trong dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Nhân Viên!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFind.Text == "Mã Nhân Viên")
                {
                    string _idNhanVien = txtFind.Text.ToString();
                    DataTable dt = new DataTable();
                    dt = Controllers.NhanVienCtrl.FillDataSet_getSearchNVbyId(_idNhanVien).Tables[0];
                    dgvDanhSachNV.DataSource = dt;
                }
                else
                {
                    string _tenFind = txtFind.Text.ToString();
                    DataTable dt = new DataTable();
                    dt = Controllers.NhanVienCtrl.FillDataSet_FindNVByTen(_tenFind).Tables[0];
                    dgvDanhSachNV.DataSource = dt;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Nhân Viên!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
