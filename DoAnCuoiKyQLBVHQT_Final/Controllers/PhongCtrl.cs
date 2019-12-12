using DoAnQLBV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Controllers
{
    class PhongCtrl
    {
        public static int InsertPhong(string _maPhong, string _tenPhong, string _maLoaiPhong, bool _hide)
        {
            try
            {
                PhongMod phongMod = new PhongMod(_maPhong, _tenPhong, _maLoaiPhong, _hide);
                return phongMod.InsertPhong();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdatePhong(string _maPhong, string _tenPhong, string _maLoaiPhong, bool _hide)
        {
            try
            {
                PhongMod phongMod = new PhongMod(_maPhong, _tenPhong, _maLoaiPhong, _hide);
                return phongMod.UpdatePhong();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeletePhong(string _maPhong)
        {
            try
            {
                PhongMod phongMod = new PhongMod(_maPhong);
                return phongMod.DeletePhong();
            }
            catch { return 0; }
        }
    }
}
