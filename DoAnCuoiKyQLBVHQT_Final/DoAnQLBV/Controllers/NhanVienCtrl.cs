using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLBV.Models;

namespace DoAnQLBV.Controllers
{
    class NhanVienCtrl
    {
        public static DataSet FillDataSet_getSearchNVbyId(string _maNhanVien)
        {
            try
            {
                Models.NhanVienMod nvien = new Models.NhanVienMod(_maNhanVien);
                return nvien.FillDataSet_getSearchNVbyId();

            }
            catch
            {
                return null;
            }
        }

        public static DataSet FillDataSet_FindNVByTen(string _tenNhanVien)
        {
            try
            {
                Models.NhanVienMod nvien = new Models.NhanVienMod(_tenNhanVien);
                return nvien.FillDataSet_FindNVByTen();

            }
            catch
            {
                return null;
            }
        }

        public static int InSertNhanVien(string _maNhanVien, string _matKhauNhanVien, string _hoNhanVien, string _tenNhanVien, DateTime _ngaysinhNhanVien, string _giotinhNhanVien, string _sodienthoaiNhanVien, string _emailNhanVien, double _luongNhanVien, string _quyenNhanVien, bool _hideNhanVien)
        {
            try
            {
                Models.NhanVienMod _nhanVien = new Models.NhanVienMod(_maNhanVien, _matKhauNhanVien, _hoNhanVien, _tenNhanVien, _ngaysinhNhanVien, _giotinhNhanVien, _sodienthoaiNhanVien, _emailNhanVien, _luongNhanVien, _quyenNhanVien, _hideNhanVien);
                return _nhanVien.InsertNhanVien();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateNhanVien(string _maNhanVien, string _matKhauNhanVien, string _hoNhanVien, string _tenNhanVien, DateTime _ngaysinhNhanVien, string _giotinhNhanVien, string _sodienthoaiNhanVien, string _emailNhanVien, double _luongNhanVien, string _quyenNhanVien, bool _hideNhanVien)
        {
            try
            {
                Models.NhanVienMod _nhanVien = new Models.NhanVienMod(_maNhanVien, _matKhauNhanVien, _hoNhanVien, _tenNhanVien, _ngaysinhNhanVien, _giotinhNhanVien, _sodienthoaiNhanVien, _emailNhanVien, _luongNhanVien, _quyenNhanVien, _hideNhanVien);
                return _nhanVien.UpdateNhanVien();
            }
            catch
            {
                return 0;
            }

        }

        public static int DeleteNhanVien(string _maNhanVien)
        {
            try
            {
                Models.NhanVienMod _nhanVien = new Models.NhanVienMod(_maNhanVien);
                return _nhanVien.DeleteNhanVien();
            }

            catch
            {
                return 0;
            }
        }
    }
}