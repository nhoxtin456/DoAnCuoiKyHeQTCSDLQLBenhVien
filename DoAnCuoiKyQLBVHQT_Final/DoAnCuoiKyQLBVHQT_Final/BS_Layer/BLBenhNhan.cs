using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKyQLBVHQT_Final.BS_Layer
{
    public class BLBenhNhan
    {
        QLBVDataContext context = new QLBVDataContext();
        BenhNhan benhNhan = new BenhNhan();

        public DataTable LayBN()
        {
            var bn = context.spGetBN();
            DataTable table = new DataTable();
            table.Columns.Add("Ma BN");
            table.Columns.Add("Ho BN");
            table.Columns.Add("Ten BN");
            table.Columns.Add("Ngay Sinh");
            table.Columns.Add("Gioi Tinh");
            table.Columns.Add("Tinh Trang");

            foreach (var r in bn) table.Rows.Add(r.MaBN, r.HoBN, r.TenBN, r.NgaySinh, r.GioiTinh, r.TinhTrang);
            return table;
        }


        //public System.Data.Linq.Table<viewBenhNhan> LayBenhNhan()
        //{
        //    DataSet ds = new DataSet();
        //    //QLBVDataContext co = new QuanLyBenhVIENDataContext();
        //    return context.viewBenhNhans;
        //}


        //public DataTable LayBN()
        //{
        //    var bn = context.viewBenhNhans.ToList();
        //    return bn;
        //}

        //public bool SuaBacSi(string maBS, string hoBS, string tenBS, DateTime ngaySinh, string gioiTinh, string chucVu, string maKhoa, ref string err)
        //{
        //    bacSi.MaBS = maBS;
        //    bacSi.HoBS = hoBS;
        //    bacSi.TenBS = tenBS;
        //    bacSi.NgaySinh = Convert.ToDateTime(ngaySinh, cultures);
        //    bacSi.GioiTinh = gioiTinh;
        //    bacSi.ChucVu = chucVu;
        //    bacSi.MaKhoa = maKhoa;
        //    var updatebs = qLBV.
        //}


    }
}
