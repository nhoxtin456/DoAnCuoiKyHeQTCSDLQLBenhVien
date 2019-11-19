using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKyQLBVHQT_Final.BS_Layer;

namespace DoAnCuoiKyQLBVHQT_Final.Presentation
{
    public partial class frmLogin : Form
    {
        BLLogin bL = new BLLogin();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool Flag;
            if (rdbQuanLy.Checked == true)
            {
                Flag = bL.KiemTraDangNhap(txtUser.Text, txtPass.Text, "Admin");
                frmMain.QuanLyMode = true;
            }
            else
            {
                Flag = bL.KiemTraDangNhap(txtUser.Text, txtPass.Text, "Nhân viên tiếp tân");
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

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
