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
        QLBVDataContext context = new QLBVDataContext();
        BacSi bacSi = new BacSi();
        //BenhNhan benhNhan = new BenhNhan();
        CultureInfo cultures = new CultureInfo("en-US");


     

       

        public DataTable GetBS()
        {
            var getBS = context.spGetBS();
            DataTable table = new DataTable();
            table.Columns.Add("Ma BS");
            table.Columns.Add("Ho BS");
            table.Columns.Add("Ten BS");
            table.Columns.Add("Ngay Sinh");
            table.Columns.Add("Gioi Tinh");
            table.Columns.Add("Chuc Vu");
            table.Columns.Add("Ma Khoa");
            foreach (var r in getBS) table.Rows.Add(r.MaBS, r.HoBS, r.TenBS, r.NgaySinh, r.GioiTinh, r.ChucVu, r.MaKhoa);
            return table;
        }

        public bool InsertBS(string _maBS, string _hoBS, string _tenBS, DateTime _ngaySinh, string _gioiTinh, string _chucVu, string _maKhoa)
        {
            bacSi.MaBS = _maBS;
            bacSi.HoBS = _hoBS;
            bacSi.TenBS = _tenBS;

            bacSi.NgaySinh = _ngaySinh;
            
            bacSi.GioiTinh = _gioiTinh;
            bacSi.ChucVu = _chucVu;
            bacSi.MaKhoa = _maKhoa;
            var bacsi = context.spInsertBS(_maBS, _hoBS, _tenBS, _ngaySinh, _gioiTinh, _chucVu, _maKhoa);
            return true;
        }




       

      


        //public DataTable LayBacSi()
        //{

        //    DataSet dataSet = new DataSet();
        //    var getBacSi = context.spGetBS();
        //    DataTable dataTable = new DataTable();
        //    dataTable.Columns.Add("Mã Bác Sĩ");
        //    dataTable.Columns.Add("Họ Bác Sĩ");
        //    dataTable.Columns.Add("Tên Bác Sĩ");
        //    dataTable.Columns.Add("Ngày Sinh");
        //    dataTable.Columns.Add("Giới Tính");
        //    dataTable.Columns.Add("Chức Vụ");
        //    dataTable.Columns.Add("Mã Khoa");
        //    foreach (var r in getBacSi)
        //    {
        //        dataTable.Rows.Add(r.MaBS,r.HoBS, r.TenBS,r.GioiTinh, r.ChucVu, r.MaKhoa);
        //    }
        //    return dataTable;
        //}

        //public bool ThemBacSi(string maBS, string hoBS, string tenBS, DateTime ngaySinh, string gioiTinh, string chucVu, string maKhoa, ref string err)
        //{
        //    bacSi.MaBS = maBS;
        //    bacSi.HoBS = hoBS;
        //    bacSi.TenBS = tenBS;
        //    //bacSi.NgaySinh = Convert.ToDateTime(ngaySinh, cultures);
        //    bacSi.GioiTinh = gioiTinh;
        //    bacSi.ChucVu = chucVu;
        //    bacSi.MaKhoa = maKhoa;
        //    var q = context.spThemBacSi(maBS, hoBS, tenBS, ngaySinh, gioiTinh, chucVu, maKhoa);
        //    //if (q != null)

        //    return true;
        //}


      

        //public bool DoiChuHoa(string tenBN)
        //{
        //    var upper = from p in context.BenhNhans
        //                where context.fnMyUpperFunction(p.TenBN) == "HENRY"
        //                select new
        //                {
        //                  p.MaBN,
        //                  p.HoBN,
        //                  p.TenBN,
        //                  p.NgaySinh,
        //                  p.GioiTinh,
        //                  p.TinhTrang
        //                };



        //    return true;
        //}




     
    }
}
