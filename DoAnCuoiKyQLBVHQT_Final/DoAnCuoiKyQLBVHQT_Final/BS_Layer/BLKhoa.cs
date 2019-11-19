using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKyQLBVHQT_Final.BS_Layer
{
    public class BLKhoa
    {
        QLBVDataContext context = new QLBVDataContext();
        Khoa khoa = new Khoa();

        public DataTable LayKhoa()
        {
            var khoa = context.fnKhoa();
            DataTable table = new DataTable();
            table.Columns.Add("Ma Khoa");
            table.Columns.Add("Ten Khoa");
            foreach (var r in khoa) table.Rows.Add(r.MaKhoa, r.TenKhoa);
            return table;

        }

        public DataTable GetKhoa()
        {
            var getKhoa = context.spGetKhoa();
            DataTable table = new DataTable();
            table.Columns.Add("Ma Khoa");
            table.Columns.Add("Ten Khoa");
            foreach (var r in getKhoa) table.Rows.Add(r.MaKhoa, r.TenKhoa);
            return table;
        }

        public bool InsertKhoa(string _maKhoa, string _tenKhoa)
        {
            var khoa = context.spInsertKhoa(_maKhoa, _tenKhoa);
            return true;
        }

    }
}
