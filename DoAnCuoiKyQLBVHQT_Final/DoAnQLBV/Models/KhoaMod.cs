using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    class KhoaMod
    {
        QLBVDataContext context = new QLBVDataContext();
        protected string MaKhoa { get; set; }
        protected string TenKhoa { get; set; }
        protected bool Hide { get; set; }
        public KhoaMod (string _MaKhoa)
        {
            MaKhoa = _MaKhoa;
        }
        public KhoaMod() { }
        public KhoaMod(string _maKhoa, string _tenKhoa, bool _hideKhoa)
        {
            MaKhoa = _maKhoa;
            TenKhoa = _tenKhoa;
            Hide = _hideKhoa;
        }
        public static DataSet FillDataSetKhoa()
        {
            return Models.connection.FillDataSet("Hospital.spGetKhoa", CommandType.StoredProcedure);
        }
        public int InsertKhoa()
        {
            int i = 0;
            string[] paras = new string[3] { "@MaKhoa", "@TenKhoa", "@Hide" };
            object[] values = new object[3] { MaKhoa, TenKhoa, Hide };
            i = Models.connection.Excute_Sql("Hospital.spInsertKhoa", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateKhoa()
        {
            int i = 0;
            string[] paras = new string[3] { "@MaKhoa", "@TenKhoa", "@Hide" };
            object[] values = new object[3] { MaKhoa, TenKhoa, Hide };
            i = Models.connection.Excute_Sql("Hospital.spUpdateKhoa", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteKhoa()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaKhoa" };
            object[] values = new object[1] { MaKhoa };
            i = Models.connection.Excute_Sql("Hospital.spDeleteKhoa", CommandType.StoredProcedure, paras, values);
            return i;
        }

       

        public string GetMaKhoaTuDongTang() { return context.fnMaKhoaTuDongTang(); }

        public static DataSet FillDataSet_getMaKhoa()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaKhoaBS", CommandType.StoredProcedure);
        }




    }
}