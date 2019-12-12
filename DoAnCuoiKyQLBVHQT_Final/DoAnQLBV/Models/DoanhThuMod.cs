using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    public class DoanhThuMod
    {
        QLBVDataContext context = new QLBVDataContext();

        public string GetNgay(DateTime? _ngay)
        {
            return context.HienThiThu(_ngay);
        }
        public string GetTongDoanhThux(DateTime _ngayStart, DateTime _ngayEnd, string _maHD)
        {
            return context.fnTinhTongDoanhThu(_ngayStart, _ngayEnd, _maHD);
        }




        private static DoanhThuMod instance;

        public static DoanhThuMod Instance
        {
            get
            {
                if (instance == null)
                    instance = new DoanhThuMod();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public DoanhThuMod() { }
        public DataTable HienThiDoanhThu()
        {
            return KetNoi.Instance.ExecuteQuery("select * FROM Hospital.HoaDons");
        }
        public static DataSet GetDoanhThu(DateTime NgayStart, DateTime NgayEnd)
        {
            return connection.ExcuteScalar2("select MaHD,TenHD,GiaHD,Hide,MaNV,MaBA,NgayLapHD,NgayThanhToanHD,dbo.HienThiThu(ThoiGian) as Thu from Hospital.HoaDons where CONVERT(datetime,ThoiGian,103) between CONVERT(DATETIME,'" + NgayStart + "',103) and convert(datetime,'" + NgayEnd + "',103);", CommandType.Text);
        }
        public static string GetTongDoanhThu(DateTime NgayStart, DateTime NgayEnd)
        {
            return connection.ExcuteScalar3("select dbo.TongTienDoanhThu('" + NgayStart + "','" + NgayEnd + "');", CommandType.Text);
        }









    }
}
