using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    class ToaXetNghiemMod
    {

        QLBVDataContext context = new QLBVDataContext();


        protected string MaXN { get; set; }
        protected string MaBA { get; set; }
        protected DateTime NgayXN { get; set; }
        public bool Hide { get; set; }

        public ToaXetNghiemMod() { }
        public ToaXetNghiemMod(string _MaXN, string _MaBA)
        {
            MaXN = _MaXN;
            MaBA = _MaBA;
        }
        public ToaXetNghiemMod(string _maXN, string _maBA, DateTime _ngayXN, bool _hide)
        {
            MaXN = _maXN;
            MaBA = _maBA;
            NgayXN = _ngayXN;
            Hide = _hide;
        }
        public static DataSet FillDataSetToaXetNghiem() { return connection.FillDataSet("Hospital.spGetToaXNs", CommandType.StoredProcedure); }
        public int InsertToaXetNghiem()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaXN", "@MaBA", "@NgayXN", "@Hide" };
            object[] values = new object[4] { MaXN, MaBA, NgayXN, Hide };
            i = connection.Excute_Sql("Hospital.spCreateToaXNs", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateToaXetNghiem()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaXN", "@MaBA", "@NgayXN", "@Hide" };
            object[] values = new object[4] { MaXN, MaBA, NgayXN, Hide };
            i = connection.Excute_Sql("Hospital.spUpdateToaXNs", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteToaXetNghiem()
        {
            int i = 0;
            string[] paras = new string[2] { "@MaXN", "@MaBA" };
            object[] values = new object[2] { MaXN, MaBA };
            i = connection.Excute_Sql("Hospital.spDeleteToaXNs", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public static DataSet FillDataSet_getMaBA()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaBAParas", CommandType.StoredProcedure);
        }



        public static DataSet FillDataSet_getMaXN()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaXetNghiemParas", CommandType.StoredProcedure);
        }





    }
}
