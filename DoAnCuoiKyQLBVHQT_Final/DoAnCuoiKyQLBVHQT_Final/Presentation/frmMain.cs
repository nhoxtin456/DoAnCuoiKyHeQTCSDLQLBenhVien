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
using DoAnCuoiKyQLBVHQT_Final.Presentation;

namespace DoAnCuoiKyQLBVHQT_Final
{
    public partial class frmMain : Form
    {
        BLBacSi qlBV = new BLBacSi();

        public static bool isLogin;
        public static bool QuanLyMode;
        public static string user;
        public static string password;

        //bool Them;
        //string err;
        public frmMain()
        {
            isLogin = false;
            QuanLyMode = true;
            InitializeComponent();
            KhoiTaoMoi();
            //LoadData();
        }

        private void KhoiTaoMoi()
        {
            if (isLogin == false)
            {
                this.dangNhapToolStripMenuItem.Enabled = true;
                this.dangXuatToolStripMenuItem.Enabled = false;
                this.quanLyToolStripMenuItem.Enabled = false;
                this.hoatDongToolStripMenuItem.Enabled = false;
                this.thongKeToolStripMenuItem.Enabled = false;
            }
        }

        private void LoadData()
        {
            //dataGridView1.DataSource = qlBV.GetBS();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = doiNgay(DateTime.Now.DayOfWeek.ToString()) + "/" +
               DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" +
               DateTime.Now.Year.ToString();
            //dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dataGridView1.DataSource = qlBV.LayKhoa();

            //dataGridView1.DataSource = qlBV.LayBacSi();

            // qlBV.DoiChuHoa(txtTenBN.Text);

            //dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            //dtpNgaySinh.CustomFormat = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //qlBV.ThemBacSi(txtMaBN.Text, txtHoBN.Text, txtTenBN.Text, Convert.ToDateTime(textBox4.Text), textBox5.Text, textBox6.Text, textBox7.Text, ref err);

            // qlBV.DoiChuHoa(txtTenBN.Text);

            //qlBV.ThemNV(txtMaNV.Text, txtHoTen.Text, txtGioiTinh.Text, txtDiaChi.Text, dtpNgaySinh.Value, txtNgheNghiep.Text, ref err);
           //qlBV.InsertBS(txtMaBN.Text, txtHoBN.Text, txtTenBN.Text, dtpNgaySinh.Value,txtGioiTinh.Text, txtChucVu.Text, txtMaKhoa.Text);

            frmMain_Load(sender, e);
           

        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if (frmMain.isLogin == true)
            {
                if (QuanLyMode == true)
                {
                    this.quanLyToolStripMenuItem.Enabled = true;
                    this.thongKeToolStripMenuItem.Enabled = true;
                    this.quanLyLoaiNhanVienToolStripMenuItem.Enabled = true;
                    this.quanLyNhanVienToolStripMenuItem.Enabled = true;
                    this.quanLyBacSiToolStripMenuItem.Enabled = true;
                    this.quanLyKhoaToolStripMenuItem.Enabled = true;
                    this.dangNhapToolStripMenuItem.Enabled = false;
                    this.dangXuatToolStripMenuItem.Enabled = true;

                }
                else
                {
                    this.quanLyToolStripMenuItem.Enabled = false;
                    this.hoatDongToolStripMenuItem.Enabled = true;
                    this.dangNhapToolStripMenuItem.Enabled = false;
                    this.dangXuatToolStripMenuItem.Enabled = true;
                }
            
            }
        }


        private String doiNgay(String name)
        {
            String ngay = "";
            switch (name)
            {
                case "Monday":
                    ngay = "Thứ hai";
                    break;
                case "Tuesday":
                    ngay = "Thứ ba";
                    break;
                case "Wednesday":
                    ngay = "Thứ tư";
                    break;
                case "Thursday":
                    ngay = "Thứ năm";
                    break;
                case "Friday":
                    ngay = "Thứ sáu";
                    break;
                case "Saturday":
                    ngay = "Thứ bảy";
                    break;
                default:
                    ngay = "Chủ nhật";
                    break;
            }
            return ngay;
        }

        private void thoatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dangXuatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            isLogin = false;
            KhoiTaoMoi();
        }

        private void hoatDongToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quanLyLoaiNhanVienToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLoaiNhanVien loaiNV = new frmLoaiNhanVien();
            loaiNV.ShowDialog();
        }

        private void quanLyNhanVienToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.ShowDialog();
        }

        private void quanLyKhoaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmKhoa khoa = new frmKhoa();
            khoa.ShowDialog();
        }

        private void quanLyBacSiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmBacSi bacSi = new frmBacSi();
            bacSi.ShowDialog();
        }

       
        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Bây giờ là: " + DateTime.Now.Hour.ToString() + " : " +
               DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
        }

        private void quanLyPhieuDangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuDangKy dangKy = new frmPhieuDangKy();
            dangKy.ShowDialog();
        }

        private void quanLyBenhNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBenhNhan benhNhan = new frmBenhNhan();
            benhNhan.ShowDialog();

        }
    }
}