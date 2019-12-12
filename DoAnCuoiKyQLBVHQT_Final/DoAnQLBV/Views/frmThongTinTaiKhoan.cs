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
    public partial class frmThongTinTaiKhoan : Form
    {
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        public void ClearData()
        {
            txtTenDangNhap.Text = "";
            txtMatKhauHT.Text = "";
            txtMatKhauMoi.Text = "";
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string UserName = txtTenDangNhap.Text;
            string PassCu = txtMatKhauHT.Text;
            string PassMoi = txtMatKhauMoi.Text;
            if (KetNoiMod.Instance.DoiMatKhau(UserName, PassCu, PassMoi))
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                ClearData();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại");
                ClearData();
            }
        }

     
    }
}
