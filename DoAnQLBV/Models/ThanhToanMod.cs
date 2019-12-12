using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    class ThanhToanMod
    {
        QLBVDataContext context = new QLBVDataContext();


        public double? TinhHoaDonPhong(string _maHD)
        {
            var r = context.fnTinhTongHDPhong(_maHD);
            return r;
        }
        public double? TinhHoaDonThuoc(string _maHD)
        {
            return context.fnTinhTongHDThuoc(_maHD);

        }
        public double? TinhHoaDonXetNghiem(string _maHD)
        {
            return context.fnTinhTongHDXN(_maHD);
        }
        public double? TinhHoaDonTongAll(string _maHD)
        {
            return context.fnTinhTongHDAllx(_maHD);
        }






    }
}
