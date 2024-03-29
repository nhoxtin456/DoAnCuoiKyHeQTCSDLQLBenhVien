﻿using System;
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
    public partial class frmMain : Form
    {
        public static bool isLogin;
        public static bool QuanLyMode;
        public static string user;
        public static string password;
        public frmMain()
        {
            isLogin = false;
            QuanLyMode = true;
            InitializeComponent();
            KhoiTaoMoi();
        }
        private void KhoiTaoMoi()
        {
            if (isLogin == false)
            {
                this.đăngNhậpToolStripMenuItem.Enabled = true;
                this.đăngXuấtToolStripMenuItem.Enabled = false;
                this.quảnLýToolStripMenuItem.Enabled = false;
                this.hoatDongToolStripMenuItem.Enabled = false;
                
            }
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if (frmMain.isLogin == true)
            {
                if (QuanLyMode == true)
                {
                    this.quảnLýToolStripMenuItem.Enabled = true;
                   
                    this.quảnLýNhânViênToolStripMenuItem.Enabled = true;
                    this.quảnLýBácSĩToolStripMenuItem.Enabled = true;
                    this.quảnLýKhoaToolStripMenuItem.Enabled = true;
                    this.đăngNhậpToolStripMenuItem.Enabled = false;
                    this.đăngXuấtToolStripMenuItem.Enabled = true;

                }
                else
                {
                    this.quảnLýToolStripMenuItem.Enabled = false;
                    this.hoatDongToolStripMenuItem.Enabled = true;
                    this.đăngNhậpToolStripMenuItem.Enabled = false;
                    this.đăngXuấtToolStripMenuItem.Enabled = true;
                }

            }
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isLogin = false;
            KhoiTaoMoi();
        }
        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //this.Close();
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }
        private void quảnLýNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.ShowDialog();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoa khoa = new frmKhoa();
            khoa.ShowDialog();
        }

        private void quảnLýBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBacSi bacSi = new frmBacSi();
            bacSi.ShowDialog();
        }

        private void quảnLýLoạiXétNghiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiXetNghiem loaiXetNghiem = new frmLoaiXetNghiem();
            loaiXetNghiem.ShowDialog();
        }

        private void quảnLýXétNghiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXetNghiem xetNghiem = new frmXetNghiem();
            xetNghiem.ShowDialog();
        }

      

        private void quảnLýLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiPhong loaiPhong = new frmLoaiPhong();
            loaiPhong.ShowDialog();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhong phong = new frmPhong();
            phong.ShowDialog();
        }


        private void quảnLýThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThuoc thuoc = new frmThuoc();
            thuoc.ShowDialog();
        }

       



        private void bệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBenhNhan benhNhan = new frmBenhNhan();
            benhNhan.ShowDialog();
        }

        private void phiếuĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuDangKy dangKy = new frmPhieuDangKy();
            dangKy.ShowDialog();
        }

        private void hồSơBệnhÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoSoBenhAn hoSoBenhAn = new frmHoSoBenhAn();
            hoSoBenhAn.ShowDialog();
        }

      

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon hoaDon = new frmHoaDon();
            hoaDon.ShowDialog();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThanhToan thanhToan = new frmThanhToan();
            thanhToan.ShowDialog();
        }

        private void toaXétNghiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmToaXetNghiem frmToaXetNghiem = new frmToaXetNghiem();
            frmToaXetNghiem.ShowDialog();
        }

        private void toaThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmToaThuoc frmToaThuoc = new frmToaThuoc();
            frmToaThuoc.ShowDialog();
        }


        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan tk = new frmThongTinTaiKhoan();
            tk.ShowDialog();
            
        }

      

        private void doanhThuToolStrip_Click(object sender, EventArgs e)
        {
           
            uctDoanhThu doanhThu = new uctDoanhThu();
            doanhThu.Show();
            
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = doiNgay(DateTime.Now.DayOfWeek.ToString()) + "/" +
               DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" +
               DateTime.Now.Year.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Bây giờ là: " + DateTime.Now.Hour.ToString() + " : " +
              DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
        }

       
    }
}