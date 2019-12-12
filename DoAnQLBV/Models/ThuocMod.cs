using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    class ThuocMod
    {
        QLBVDataContext context = new QLBVDataContext();
        protected string MaThuoc { get; set; }
        protected string TenThuoc { get; set; }
        protected double GiaThuoc { get; set; }
        protected bool Hide { get; set; }

        public ThuocMod() { }
        public ThuocMod(string _maThuoc)
        {
            MaThuoc = _maThuoc;
        }
        public ThuocMod(string _maThuoc, string _tenThuoc, double _giaThuoc, bool _hide)
        {
            MaThuoc = _maThuoc;
            TenThuoc = _tenThuoc;
            GiaThuoc = _giaThuoc;
            Hide = _hide;
        }
        
        public static DataSet FillDataSetThuoc() { return connection.FillDataSet("Hospital.spGetThuoc", CommandType.StoredProcedure); }
        public int InsertThuoc()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaThuoc", "@TenThuoc", "@GiaThuoc", "@Hide" };
            object[] values = new object[4] { MaThuoc, TenThuoc, GiaThuoc, Hide };
            i = connection.Excute_Sql("Hospital.spCreateThuoc", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateThuoc()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaThuoc", "@TenThuoc", "@GiaThuoc", "@Hide" };
            object[] values = new object[4] { MaThuoc, TenThuoc, GiaThuoc, Hide };
            i = connection.Excute_Sql("Hospital.spUpdateThuoc", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteThuoc()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaThuoc" };
            object[] values = new object[1] { MaThuoc };
            i = connection.Excute_Sql("Hospital.spDeleteThuoc", CommandType.StoredProcedure, paras, values);
            return i;
        }

       

        public static DataSet FillDataSet_getMaThuoc()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaThuocParas", CommandType.StoredProcedure);
        }


        public string GetMaThuocTuDongTang() { return context.fnMaThuocTuDongTang(); }


    }
}
