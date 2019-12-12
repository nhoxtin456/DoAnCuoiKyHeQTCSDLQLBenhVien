using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    class XetNghiemMod
    {
        QLBVDataContext context = new QLBVDataContext();
        protected string MaXN { get; set; }
        protected string TenXN { get; set; }
        protected string MaLoaiXN { get; set; }
        protected bool Hide { get; set; }

        public XetNghiemMod() { }
        public XetNghiemMod(string _maXN)
        {
            MaXN = _maXN;
        }
        public XetNghiemMod(string _maXN, string _tenXN, string _maLoaiXN, bool _hide)
        {
            MaXN = _maXN;
            TenXN = _tenXN;
            MaLoaiXN = _maLoaiXN;
            Hide = _hide;
        }

        public static DataSet FillDataSetXetNghiem() { return connection.FillDataSet("Hospital.spGetXNs", CommandType.StoredProcedure); }
        public int InsertXetNghiem()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaXN", "@TenXN", "@MaLoaiXN", "@Hide" };
            object[] values = new object[4] { MaXN, TenXN, MaLoaiXN, Hide };
            i = connection.Excute_Sql("Hospital.spInsertXNs", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateXetNghiem()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaXN", "@TenXN", "@MaLoaiXN", "@Hide" };
            object[] values = new object[4] { MaXN, TenXN, MaLoaiXN, Hide };
            i = connection.Excute_Sql("Hospital.spUpdateXNs", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteXetNghiem()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaXN" };
            object[] values = new object[1] { MaXN };
            i = connection.Excute_Sql("Hospital.spDeleteXNs", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public string GetMaXNTuDongTang() { return context.fnMaXetNghiemTuDongTang(); }

        public static DataSet FillDataSet_getMaXN()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaXNParas", CommandType.StoredProcedure);
        }

        public static DataSet FillDataSet_getMaLoaiXN()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaLoaiXNParas", CommandType.StoredProcedure);
        }


    }
}
