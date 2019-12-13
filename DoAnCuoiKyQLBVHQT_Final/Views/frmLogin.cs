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
    public partial class frmLogin : Form
    {
        NhanVienMod nhanVienMod = new NhanVienMod();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool Flag;
            if (rdbAdmin.Checked == true)
            {
                Flag = nhanVienMod.KiemTraDangNhap(txtUser.Text, txtPass.Text, "Admin",false);
                frmMain.QuanLyMode = true;
            }
            else
            {
                Flag = nhanVienMod.KiemTraDangNhap(txtUser.Text, txtPass.Text, "NhanVien", false);
                frmMain.QuanLyMode = false;
            }            
            if (Flag == true)
            {
                frmMain.isLogin = true;
                frmMain.user = txtUser.Text;
                frmMain.password = txtPass.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu", "Thông báo");
                txtUser.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
