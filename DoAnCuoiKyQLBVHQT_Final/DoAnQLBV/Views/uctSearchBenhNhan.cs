using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQLBV.Models;
using System.Data.SqlClient;

namespace DoAnQLBV.Views
{
    public partial class uctSearchBenhNhan : UserControl
    {
        BenhNhanMod benhNhanMod = new BenhNhanMod();


        string recentError = null;
        SqlConnection myConn = new SqlConnection("Server  = MINHKHOA\\TIN;Initial Catalog=QuanLyBenhVienDoAnCuoiKi;Integrated Security=True");




        public uctSearchBenhNhan()
        {
            InitializeComponent();
            ConnectDB();
        }

        public void ConnectDB()
        {
            myConn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = new DataTable();
                SqlCommand myCmd = new SqlCommand("Hospital.SearchBenhNhan", myConn);
                myCmd.CommandType = CommandType.StoredProcedure;
                string select = cmbFind.GetItemText(cmbFind.SelectedItem);
                switch (select)
                {
                    case "":
                        MessageBox.Show("Vui lòng chọn loại muốn tìm kiếm!", "Error..."); break;
                    case "Mã BN":
                        myCmd.Parameters.Add("@MaBN", SqlDbType.NVarChar).Value = txtMaBN.Text;
                        break;
                    case "Họ BN":
                        myCmd.Parameters.Add("@HoBN", SqlDbType.NVarChar).Value = txtHoBN.Text;
                        break;
                    case "Tên BN":
                        myCmd.Parameters.Add("@TenBN", SqlDbType.NVarChar).Value = txtTenBN.Text;
                        break;
                    case "Ngày Sinh":
                        myCmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = dtpNgaySinhBN.Value;
                        break;
                    case "Giới Tính":
                        myCmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = txtGioiTinh.Text;
                        break;
                }
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.Fill(dt);
                dgvDanhSachNV.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Đã có lỗi! Không thể tìm kiếm, Vui lòng kiểm tra mã lỗi ở Recent Error!", "Error...");
                recentError = Ex.ToString();
            }






        }

        private void uctSearchBenhNhan_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            try
            {
                // Trỏ tới data Bệnh Nhân
                dgvDanhSachNV.DataSource = Models.BenhNhanMod.FillDataSetBenhNhan().Tables[0];

                dgvDanhSachNV.Dock = DockStyle.Fill;
                dgvDanhSachNV.RowHeadersVisible = false;
                dgvDanhSachNV.BorderStyle = BorderStyle.Fixed3D;
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được cơ sở dữ liệu trong bảng Bệnh Nhân!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
