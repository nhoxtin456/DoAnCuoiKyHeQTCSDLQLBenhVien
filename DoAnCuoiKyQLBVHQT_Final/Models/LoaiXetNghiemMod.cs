using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    class LoaiXetNghiemMod
    {
        QLBVDataContext context = new QLBVDataContext();
        protected string MaLoaiXN { get; set; }
        protected string TenLoaiXN { get; set; }
        protected double GiaLXN { get; set; }
        protected bool Hide { get; set; }

        public LoaiXetNghiemMod() { }
        public LoaiXetNghiemMod(string _maLoaiXN)
        {
            MaLoaiXN = _maLoaiXN;
        }
        public LoaiXetNghiemMod(string _maLoaiXN, string _tenLoaiXN, double _giaLXN, bool _hide)
        {
            MaLoaiXN = _maLoaiXN;
            TenLoaiXN = _tenLoaiXN;
            GiaLXN = _giaLXN;
            Hide = _hide;
        }

        public static DataSet FillDataSetLoaiXetNghiem() { return connection.FillDataSet("Hospital.spGetLoaiXNs", CommandType.StoredProcedure); }
        public int InsertLoaiXetNghiem()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaLoaiXN", "@TenLoaiXN", "@GiaLXN", "@Hide" };
            object[] values = new object[4] { MaLoaiXN, TenLoaiXN, GiaLXN, Hide };
            i = connection.Excute_Sql("Hospital.spInsertLoaiXNs", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateLoaiXetNghiem()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaLoaiXN", "@TenLoaiXN", "@GiaLXN", "@Hide" };
            object[] values = new object[4] { MaLoaiXN, TenLoaiXN, GiaLXN, Hide };
            i = connection.Excute_Sql("Hospital.spUpdateLoaiXNs", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteLoaiXetNghiem()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaLoaiXN" };
            object[] values = new object[1] { MaLoaiXN };
            i = connection.Excute_Sql("Hospital.spDeleteLoaiXNs", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public static DataSet FillDataSet_getMaLoaiXN()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaLoaiXNParas", CommandType.StoredProcedure);
        }

        public string GetMaLoaiXNTuDongTang() { return context.fnMaLoaiXetNghiemTuDongTang(); }

    }
}
