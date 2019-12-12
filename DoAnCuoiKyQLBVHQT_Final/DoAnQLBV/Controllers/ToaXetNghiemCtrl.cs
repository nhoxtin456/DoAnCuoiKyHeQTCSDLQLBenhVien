using DoAnQLBV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Controllers
{
    class ToaXetNghiemCtrl
    {
        public static int InsertToaXetNghiem(string _maXN, string _maBA, DateTime _ngayXN, bool _hide)
        {
            try
            {
                ToaXetNghiemMod toaXetNghiemMod = new ToaXetNghiemMod(_maXN, _maBA, _ngayXN, _hide);
                return toaXetNghiemMod.InsertToaXetNghiem();
            }
            catch { return 0; }
        }
        public static int UpdateToaXetNghiem(string _maXN, string _maBA, DateTime _ngayXN, bool _hide)
        {
            try
            {
                ToaXetNghiemMod toaXetNghiemMod = new ToaXetNghiemMod(_maXN, _maBA, _ngayXN, _hide);
                return toaXetNghiemMod.UpdateToaXetNghiem();
            }
            catch { return 0; }
        }
        public static int DeleteToaXetNghiem(string _maXN, string _maBA)
        {
            try
            {
                ToaXetNghiemMod toaXetNghiemMod = new ToaXetNghiemMod(_maXN, _maBA);
                return toaXetNghiemMod.DeleteToaXetNghiem();
            }
            catch
            {
                return 0;
            }
        }
    }
}
