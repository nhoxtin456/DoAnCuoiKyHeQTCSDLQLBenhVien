using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

namespace DoAnCuoiKyQLBVHQT_Final.BS_Layer
{
    class BLBacSi
    {
        QLBVDataContext qLBV = new QLBVDataContext();
        BacSi bacSi = new BacSi();
        CultureInfo cultures = new CultureInfo("en-US");

        public DataTable LayBacSi()
        {

            DataSet dataSet = new DataSet();
            var getBacSi = qLBV.spLayBacSi();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Mã Bác Sĩ");
            dataTable.Columns.Add("Họ Bác Sĩ");
            dataTable.Columns.Add("Tên Bác Sĩ");
            dataTable.Columns.Add("Ngày Sinh");
            dataTable.Columns.Add("Giới Tính");
            dataTable.Columns.Add("Chức Vụ");
            dataTable.Columns.Add("Mã Khoa");
            foreach (var r in getBacSi)
            {
                dataTable.Rows.Add(r.MaBS,r.HoBS, r.TenBS, r.NgaySinh, r.GioiTinh, r.ChucVu, r.MaKhoa);
            }
            return dataTable;
        }

        public bool ThemBacSi(string maBS, string hoBS, string tenBS, DateTime ngaySinh, string gioiTinh, string chucVu, string maKhoa, ref string err)
        {
            bacSi.MaBS = maBS;
            bacSi.HoBS = hoBS;
            bacSi.TenBS = tenBS;
            bacSi.NgaySinh = Convert.ToDateTime(ngaySinh, cultures);
            bacSi.GioiTinh = gioiTinh;
            bacSi.ChucVu = chucVu;
            bacSi.MaKhoa = maKhoa;
            var q = qLBV.spThemBacSi(maBS, hoBS, tenBS, ngaySinh, gioiTinh, chucVu, maKhoa);
            //if (q != null)
            
            return true;
        }

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
