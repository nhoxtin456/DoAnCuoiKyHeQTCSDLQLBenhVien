using DoAnQLBV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Controllers
{
    class ThuocCtrl
    {
        public static int InsertThuoc(string _maThuoc, string _tenThuoc, double _giaThuoc, bool _hide)
        {
            try
            {
                ThuocMod thuocMod = new ThuocMod(_maThuoc, _tenThuoc, _giaThuoc, _hide);
                return thuocMod.InsertThuoc();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateThuoc(string _maThuoc, string _tenThuoc, double _giaThuoc, bool _hide)
        {
            try
            {
                ThuocMod thuocMod = new ThuocMod(_maThuoc, _tenThuoc, _giaThuoc, _hide);
                return thuocMod.UpdateThuoc();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteThuoc(string _maThuoc)
        {
            try
            {
                ThuocMod thuocMod = new ThuocMod(_maThuoc);
                return thuocMod.DeleteThuoc();
            }
            catch
            {
                return 0;
            }
        }
    }
}
