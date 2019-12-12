using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    class BacSiMod
    {
        QLBVDataContext context = new QLBVDataContext();

        protected string MaBS { get; set; }
        protected string HoBS { get; set; }
        protected string TenBS { get; set; }
        protected DateTime NgaySinh { get; set; }
        protected string GioiTinh { get; set; }
        protected string ChucVu { get; set; }
        protected string MaKhoa { get; set; }
        protected bool Hide { get; set; }

        public BacSiMod() { }
        public BacSiMod (string _MaBS)
        {
            MaBS = _MaBS;
        }
        public BacSiMod (string _maBS, string _hoBS, string _tenBS, DateTime _ngaySinh, string _gioiTinh, string _chucVu, string _maKhoa, bool _hide)
        {
            MaBS = _maBS;
            HoBS = _hoBS;
            TenBS = _tenBS;
            NgaySinh = _ngaySinh;
            GioiTinh = _gioiTinh;
            ChucVu = _chucVu;
            MaKhoa = _maKhoa;
            Hide = _hide;
        }
        public static DataSet FillDataSetBacSi() { return connection.FillDataSet("Hospital.spGetBS", CommandType.StoredProcedure); }
        public int InsertBacSi()
        {
            int i = 0;
            string[] paras = new string[8] { "@MaBS", "@HoBS", "@TenBS", "@NgaySinh", "@GioiTinh", "@ChucVu", "@MaKhoa", "@Hide" };
            object[] values = new object[8] { MaBS, HoBS, TenBS, NgaySinh, GioiTinh, ChucVu, MaKhoa, Hide };
            i = connection.Excute_Sql("Hospital.spInsertBS", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateBacSi()
        {
            int i = 0;
            string[] paras = new string[8] { "@MaBS", "@HoBS", "@TenBS", "@NgaySinh", "@GioiTinh", "@ChucVu", "@MaKhoa", "@Hide" };
            object[] values = new object[8] { MaBS, HoBS, TenBS, NgaySinh, GioiTinh, ChucVu, MaKhoa, Hide };
            i = connection.Excute_Sql("Hospital.spUpdateBS", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteBacSi()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaBS" };
            object[] values = new object[1] { MaBS };
            i = connection.Excute_Sql("Hospital.spDeleteBS", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public static DataSet FillDataSet_getMaBS()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaBSParas", CommandType.StoredProcedure);
        }

        public static DataSet FillDataSet_getMaKhoa()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaKhoaParas", CommandType.StoredProcedure);
        }

        public string GetMaBSTuDongTang() { return context.fnMaBacSiTuDongTang(); }




    }
}