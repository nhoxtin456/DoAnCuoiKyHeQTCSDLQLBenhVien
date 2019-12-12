using DoAnQLBV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Controllers
{
    class LoaiXetNghiemCtrl
    {
        public static int InsertLoaiXetNghiem(string _maLoaiXN, string _tenLoaiXetNghiem, double _giaLXN, bool _hide)
        {
            try
            {
                LoaiXetNghiemMod loaiXetNghiemMod = new LoaiXetNghiemMod(_maLoaiXN, _tenLoaiXetNghiem, _giaLXN, _hide);
                return loaiXetNghiemMod.InsertLoaiXetNghiem();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateLoaiXetNghiem(string _maLoaiXN, string _tenLoaiXetNghiem, double _giaLXN, bool _hide)
        {
            try
            {
                LoaiXetNghiemMod loaiXetNghiemMod = new LoaiXetNghiemMod(_maLoaiXN, _tenLoaiXetNghiem, _giaLXN, _hide);
                return loaiXetNghiemMod.UpdateLoaiXetNghiem();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteLoaiXetNghiem(string _maLoaiXN)
        {
            try
            {
                LoaiXetNghiemMod loaiXetNghiemMod = new LoaiXetNghiemMod(_maLoaiXN);
                return loaiXetNghiemMod.DeleteLoaiXetNghiem();
            }
            catch
            {
                return 0;
            }
        }
    }
}
