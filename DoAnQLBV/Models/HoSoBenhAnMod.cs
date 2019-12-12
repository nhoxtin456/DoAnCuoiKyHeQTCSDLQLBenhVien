using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    class HoSoBenhAnMod
    {
        QLBVDataContext context = new QLBVDataContext();

        protected string MaBA { get; set; }
        protected string ChuanDoanBenh { get; set; }
        protected string MaBS { get; set; }
        protected string MaPhong { get; set; }
        protected double SoNgayO { get; set; }
        protected bool Hide { get; set; }

        public HoSoBenhAnMod() { }
        public HoSoBenhAnMod(string _maBA) { MaBA = _maBA; }
        public HoSoBenhAnMod(string _maBA, string _chuanDoanBenh, string _maBS, string _maPhong, double _soNgayO, bool _hide)
        {
            MaBA = _maBA;
            ChuanDoanBenh = _chuanDoanBenh;
            MaBS = _maBS;
            MaPhong = _maPhong;
            SoNgayO = _soNgayO;
            Hide = _hide;
        }
        public static DataSet FillDataSetHoSoBenhAn() { return connection.FillDataSet("Hospital.spGetHSBA", CommandType.StoredProcedure); }
        public int InsertHoSoBenhAn()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaBA", "@ChuanDoanBenh", "@MaBS", "@MaPhong", "@SoNgayO", "@Hide" };
            object[] values = new object[6] { MaBA, ChuanDoanBenh, MaBS, MaPhong, SoNgayO, Hide };
            i = connection.Excute_Sql("Hospital.spCreateHSBA", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateHoSoBenhAn()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaBA", "@ChuanDoanBenh", "@MaBS", "@MaPhong", "@SoNgayO", "@Hide" };
            object[] values = new object[6] { MaBA, ChuanDoanBenh, MaBS, MaPhong, SoNgayO, Hide };
            i = connection.Excute_Sql("Hospital.spUpdateHSBA", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteHoSoBenhAn()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaBA" };
            object[] values = new object[1] { MaBA };
            i = connection.Excute_Sql("Hospital.spDeleteHSBA", CommandType.StoredProcedure, paras, values);
            return i;
        }

       

        public string GetMaBATuDongTang() { return context.fnMaHoSoBenhAnTuDongTang(); }

        public static DataSet FillDataSet_getMaHoSoBA()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaBAParas", CommandType.StoredProcedure);
        }

        public static DataSet FillDataSet_getMaBS()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaBSParas", CommandType.StoredProcedure);
        }

        public static DataSet FillDataSet_getMaPhong()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaPhongParas", CommandType.StoredProcedure);
        }









    }
}
