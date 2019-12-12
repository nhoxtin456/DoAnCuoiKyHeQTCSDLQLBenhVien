using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Controllers
{
    class DoanhThuCtrl
    {
        public static DataSet GetDoanhThu(DateTime NgayStart, DateTime NgayEnd)
        {
            try
            {
                return Models.DoanhThuMod.GetDoanhThu(NgayStart, NgayEnd);
            }
            catch
            {
                return null;
            }
        }
        public static string GetTongDoanhThu(DateTime NgayStart, DateTime NgayEnd)
        {
            try
            {
                return Models.DoanhThuMod.GetTongDoanhThu(NgayStart, NgayEnd);
            }
            catch
            {
                return "";
            }
        }
    }

}
