using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    class PhongMod
    {
        QLBVDataContext context = new QLBVDataContext();
        protected string MaPhong { get; set; }
        protected string TenPhong { get; set; }
        protected string MaLoaiPhong { get; set; }
        protected bool Hide { get; set; }

        public PhongMod() { }
        public PhongMod(string _maPhong)
        {
            MaPhong = _maPhong;
        }
        public PhongMod(string _maPhong, string _tenPhong, string _maLoaiPhong, bool _hide)
        {
            MaPhong = _maPhong;
            TenPhong = _tenPhong;
            MaLoaiPhong = _maLoaiPhong;
            Hide = _hide;
        }

        public static DataSet FillDataSetLoaiPhong() { return connection.FillDataSet("Hospital.spGetPhongs", CommandType.StoredProcedure); }
        public int InsertPhong()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaPhong", "@TenPhong", "@MaLoaiPhong", "@Hide" };
            object[] values = new object[4] { MaPhong, TenPhong, MaLoaiPhong, Hide };
            i = connection.Excute_Sql("Hospital.spCreatePhongs", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdatePhong()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaPhong", "@TenPhong", "@MaLoaiPhong", "@Hide" };
            object[] values = new object[4] { MaPhong, TenPhong, MaLoaiPhong, Hide };
            i = connection.Excute_Sql("Hospital.spUpdatePhongs", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeletePhong()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaPhong" };
            object[] values = new object[1] { MaPhong };
            i = connection.Excute_Sql("Hospital.spDeletePhongs", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public string GetMaPhongTuDongTang() { return context.fnMaPhongTuDongTang(); }

        public static DataSet FillDataSet_getMaPhong()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaPhongParas", CommandType.StoredProcedure);
        }

        public static DataSet FillDataSet_getMaLoaiPhong()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaLoaiPhongParas", CommandType.StoredProcedure);
        }

        public void undophong()
        {
            var r = context.spUndoRooms();

        }

        public void redophong()
        {
            var r = context.spRedoRooms();

        }



    }
}
