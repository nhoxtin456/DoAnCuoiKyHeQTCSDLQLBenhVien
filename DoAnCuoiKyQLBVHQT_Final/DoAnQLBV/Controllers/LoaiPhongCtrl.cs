using DoAnQLBV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Controllers
{
    class LoaiPhongCtrl
    {
        public static int InsertLoaiPhong(string _maLoaiPhong, string _tenLoaiPhong, double _giaPhong, bool _hide)
        {
            try
            {
                LoaiPhongMod loaiPhongMod = new LoaiPhongMod(_maLoaiPhong, _tenLoaiPhong, _giaPhong, _hide);
                return loaiPhongMod.InsertLoaiPhong();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateLoaiPhong(string _maLoaiPhong, string _tenLoaiPhong, double _giaPhong, bool _hide)
        {
            try
            {
                LoaiPhongMod loaiPhongMod = new LoaiPhongMod(_maLoaiPhong, _tenLoaiPhong, _giaPhong, _hide);
                return loaiPhongMod.UpdateLoaiPhong();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteLoaiPhong(string _maLoaiPhong)
        {
            try
            {
                LoaiPhongMod loaiPhongMod = new LoaiPhongMod(_maLoaiPhong);
                return loaiPhongMod.DeleteLoaiPhong();
            }
            catch { return 0; }
        }
    }
}
