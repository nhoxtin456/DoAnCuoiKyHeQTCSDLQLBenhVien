using DoAnQLBV.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Controllers
{

    class HoaDonCtrl
    {
        QLBVDataContext context = new QLBVDataContext();
        public static int InsertHoaDon(string _maHD, string _tenHD, double _giaHD, bool _hide, string _maNhanVien, string _maHoSoBenhAn, DateTime _ngayLapHD, DateTime _ngayThanhToanHD,DateTime _thoiGian)
        {
            try
            {
                HoaDonMod hoaDonMod = new HoaDonMod(_maHD, _tenHD, _giaHD, _hide, _maNhanVien, _maHoSoBenhAn, _ngayLapHD, _ngayThanhToanHD, _thoiGian);
                return hoaDonMod.InsertHoaDon();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateHoaDon(string _maHD, string _tenHD, double _giaHD, bool _hide, string _maNhanVien, string _maHoSoBenhAn, DateTime _ngayLapHD, DateTime _ngayThanhToanHD,DateTime _thoiGian)
        {
            try
            {
                HoaDonMod hoaDonMod = new HoaDonMod(_maHD, _tenHD, _giaHD, _hide, _maNhanVien, _maHoSoBenhAn, _ngayLapHD, _ngayThanhToanHD,_thoiGian);
                return hoaDonMod.UpdateHoaDon();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteHoaDon(string _maHD)
        {
            try
            {
                HoaDonMod hoaDonMod = new HoaDonMod(_maHD);
                return hoaDonMod.DeleteHoaDon();
            }
            catch { return 0; }
        }

        //public static int LayHDTong(string _maHD)
        //{
        //    try
        //    {
        //        HoaDonMod hoaDonMod = new HoaDonMod(_maHD);
        //        return hoaDonMod.GetHoaDonTong();
        //    }
        //    catch { return 0; }
        //}

        //public static int TinhTienHD (string _maHD)
        //{
        //    try
        //    {
        //        HoaDonMod hoaDonMod = new HoaDonMod(_maHD);
        //        return hoaDonMod.TinhTienHD();
        //    }
        //    catch
        //    {
        //        return 0;
        //    }
        //}



        //public static DataSet GetDoanhThu(DateTime NgayStart, DateTime NgayEnd)
        //{
        //    try
        //    {
        //        return Models.DoanhThuMod.GetDoanhThu(NgayStart, NgayEnd);
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
        //public static string GetTongDoanhThu(DateTime NgayStart, DateTime NgayEnd)
        //{
        //    try
        //    {
        //        return Models.DoanhThuMod.GetTongDoanhThu(NgayStart, NgayEnd);
        //    }
        //    catch
        //    {
        //        return "";
        //    }
        //}

    }
}
