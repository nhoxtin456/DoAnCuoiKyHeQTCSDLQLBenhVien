using DoAnQLBV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Controllers
{
    class BenhNhanCtrl
    {
        public static int InsertBenhNhan(string _maBN, string _hoBN, string _tenBN, DateTime _ngaySinh, string _gioiTinh, bool _hideBN)
        {
            try
            {
                BenhNhanMod benhNhanMod = new BenhNhanMod(_maBN, _hoBN, _tenBN, _ngaySinh, _gioiTinh, _hideBN);
                return benhNhanMod.InsertBenhNhan();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateBenhNhan(string _maBN, string _hoBN, string _tenBN, DateTime _ngaySinh, string _gioiTinh, bool _hideBN)
        {
            try
            {
                BenhNhanMod benhNhanMod = new BenhNhanMod(_maBN, _hoBN, _tenBN, _ngaySinh, _gioiTinh, _hideBN);
                return benhNhanMod.UpdateBenhNhan();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteBenhNhan(string _maBN)
        {
            try
            {
                BenhNhanMod benhNhanMod = new BenhNhanMod(_maBN);
                return benhNhanMod.DeleteBenhNhan();
            }
            catch
            {
                return 0;
            }
        }
    }
}
