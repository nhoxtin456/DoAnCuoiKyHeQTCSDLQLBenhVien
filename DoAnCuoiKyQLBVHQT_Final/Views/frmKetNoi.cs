using DoAnQLBV.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBV
{
    public partial class frmKetNoi : Form
    {
        public frmKetNoi()
        {
            InitializeComponent();
        }

        private void frmKetNoi_Load(object sender, EventArgs e)
        {
            // Load server lên
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            // Đổ data từ table vào combobox   
            DataTable table = instance.GetDataSources();
            cbServer.DataSource = table;
            cbServer.DisplayMember = "ServerName"; // Tên server
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string QuanLyBenhVienDoAnCuoiKiConnectionString = "Server=MINHKHOA\\TIN" + cbServer.Text + "; Database = QuanLyBenhVienDoAnCuoiKi; User Id =" + txtUser.Text + "; Password=" + txtPass.Text + ";";
            SqlConnection sqlcon = new SqlConnection(QuanLyBenhVienDoAnCuoiKiConnectionString);
            try
            {
                sqlcon.Open();
                DoAnQLBV.Properties.Settings.Default.strConnect = QuanLyBenhVienDoAnCuoiKiConnectionString;
                DoAnQLBV.Properties.Settings.Default.Save();
                MessageBox.Show("Kết nối thành công !!!");
                frmMain frm = new frmMain();
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Kết nối không thành công, xin kiểm tra lại!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }
    }
}
