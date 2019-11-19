using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKyQLBVHQT_Final.BS_Layer
{
    public class BLPhieuDangKy
    {
        QLBVDataContext context = new QLBVDataContext();
        PhieuDangKy phieuDangKy = new PhieuDangKy();

        public DataTable LayPhieuDK()
        {
            var pdk = context.spGetPhieuDK();
            DataTable dt = new DataTable();
            dt.Columns.Add("Ma Phieu DK");
            dt.Columns.Add("Ma NV");
            dt.Columns.Add("Ma BN");
            dt.Columns.Add("Ma Khoa");

            foreach (var r in pdk) dt.Rows.Add(r.MaPhieuDK, r.MaNV, r.MaBN, r.MaKhoa);

            return dt;
        }






    }
}
