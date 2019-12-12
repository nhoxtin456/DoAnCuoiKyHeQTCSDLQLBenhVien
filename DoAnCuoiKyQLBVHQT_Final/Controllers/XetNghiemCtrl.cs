using DoAnQLBV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Controllers
{
    class XetNghiemCtrl
    {
        public static int InsertXetNghiem(string _maXN, string _tenXN, string _maLoaiXN, bool _hide)
        {
            try
            {
                XetNghiemMod xetNghiemMod = new XetNghiemMod(_maXN, _tenXN, _maLoaiXN, _hide);
                return xetNghiemMod.InsertXetNghiem();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateXetNghiem(string _maXN, string _tenXN, string _maLoaiXN, bool _hide)
        {
            try
            {
                XetNghiemMod xetNghiemMod = new XetNghiemMod(_maXN, _tenXN, _maLoaiXN, _hide);
                return xetNghiemMod.UpdateXetNghiem();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteXetNghiem(string _maXN)
        {
            try
            {
                XetNghiemMod xetNghiemMod = new XetNghiemMod(_maXN);
                return xetNghiemMod.DeleteXetNghiem();
            }
            catch
            {
                return 0;
            }
        }
    }
}
