using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    class ToaThuocMod
    {
        QLBVDataContext context = new QLBVDataContext();
        protected string MaThuoc { get; set; }
        protected string MaBA { get; set; }
        protected int SoLuong { get; set; }
        public bool Hide { get; set; }

        public ToaThuocMod() { }
        public ToaThuocMod(string _MaThuoc, string _MaBA)
        {
            MaThuoc = _MaThuoc;
            MaBA = _MaBA;
        }
        public ToaThuocMod(string _maThuoc, string _maBA, int _soLuong, bool _hide)
        {
            MaThuoc = _maThuoc;
            MaBA = _maBA;
            SoLuong = _soLuong;
            Hide = _hide;
        }
        public static DataSet FillDataSetToaThuoc() { return connection.FillDataSet("Hospital.spGetToaThuoc", CommandType.StoredProcedure); }
        public int InsertToaThuoc()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaThuoc", "@MaBA", "@SoLuong", "@Hide" };
            object[] values = new object[4] { MaThuoc, MaBA, SoLuong, Hide };
            i = connection.Excute_Sql("Hospital.spCreateToaThuoc", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateToaThuoc()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaThuoc", "@MaBA", "@SoLuong", "@Hide" };
            object[] values = new object[4] { MaThuoc, MaBA, SoLuong, Hide };
            i = connection.Excute_Sql("Hospital.spUpdateToaThuoc", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteToaThuoc()
        {
            int i = 0;
            string[] paras = new string[2] { "@MaThuoc", "@MaBA" };
            object[] values = new object[2] { MaThuoc, MaBA };
            i = connection.Excute_Sql("Hospital.spDeleteToaThuoc", CommandType.StoredProcedure, paras, values);
            return i;
        }

       

        public static DataSet FillDataSet_getMaBA()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaBAParas", CommandType.StoredProcedure);
        }

      

        public static DataSet FillDataSet_getMaThuoc()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaThuocParas", CommandType.StoredProcedure);
        }

     

      
        




    }
}
