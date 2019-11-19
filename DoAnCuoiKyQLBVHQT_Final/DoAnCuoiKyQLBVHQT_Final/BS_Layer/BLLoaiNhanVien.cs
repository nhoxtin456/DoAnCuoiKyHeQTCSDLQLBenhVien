using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKyQLBVHQT_Final.BS_Layer
{
    public class BLLoaiNhanVien
    {
        QLBVDataContext context = new QLBVDataContext();
        LoaiNhanVien loaiNhanVien = new LoaiNhanVien();

        public DataTable LayLoaiNV()
        {
            var loaiNV = context.spGetLoaiNV();
            DataTable dt = new DataTable();
            dt.Columns.Add("Ma Loai NV");
            dt.Columns.Add("Ten Loai NV");

            foreach (var r in loaiNV) dt.Rows.Add(r.MaLoaiNV, r.TenLoaiNV);
            return dt;
        }

        public int? DemLoaiNV()
        {
            var count = context.fnSoNVKeToan();
            return count;
        }







    }
}
