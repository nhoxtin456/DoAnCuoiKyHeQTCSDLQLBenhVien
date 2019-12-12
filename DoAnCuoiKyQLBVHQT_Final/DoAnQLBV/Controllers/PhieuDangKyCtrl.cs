using DoAnQLBV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Controllers
{
    class PhieuDangKyCtrl
    {
        public static int InsertPhieuDangKy(string _maPhieuDangKy, bool _hidePhieuDangKy, string _maNhanVien, string _maBenhNhan, string _maKhoa, string _maHoSoBenhAn)
        {
            try
            {
                PhieuDangKyMod phieuDangKyMod = new PhieuDangKyMod(_maPhieuDangKy, _hidePhieuDangKy, _maNhanVien, _maBenhNhan, _maKhoa, _maHoSoBenhAn);
                return phieuDangKyMod.InsertPhieuDangKy();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdatePhieuDangKy(string _maPhieuDangKy, bool _hidePhieuDangKy, string _maNhanVien, string _maBenhNhan, string _maKhoa, string _maHoSoBenhAn)
        {
            try
            {
                PhieuDangKyMod phieuDangKyMod = new PhieuDangKyMod(_maPhieuDangKy, _hidePhieuDangKy, _maNhanVien, _maBenhNhan, _maKhoa, _maHoSoBenhAn);
                return phieuDangKyMod.UpdatePhieuDangKy();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeletePhieuDangKy (string _maPhieuDK)
        {
            try
            {
                PhieuDangKyMod phieuDangKyMod = new PhieuDangKyMod(_maPhieuDK);
                return phieuDangKyMod.DeletePhieuDangKy();
            }
            catch
            {
                return 0;
            }
        }   
    }
}
