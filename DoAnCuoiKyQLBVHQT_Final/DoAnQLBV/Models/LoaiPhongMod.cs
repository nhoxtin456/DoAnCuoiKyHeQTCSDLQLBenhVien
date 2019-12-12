using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBV.Models
{
    class LoaiPhongMod
    {
        QLBVDataContext context = new QLBVDataContext();
        protected string MaLoaiPhong { get; set; }
        protected string TenLoaiPhong { get; set; }
        protected double GiaPhong { get; set; }
        protected bool Hide { get; set; }

        public LoaiPhongMod() { }
        public LoaiPhongMod(string _maLoaiPhong)
        {
            MaLoaiPhong = _maLoaiPhong;
        }
        public LoaiPhongMod(string _maLoaiPhong, string _tenLoaiPhong, double _giaPhong, bool _hide)
        {
            MaLoaiPhong = _maLoaiPhong;
            TenLoaiPhong = _tenLoaiPhong;
            GiaPhong = _giaPhong;
            Hide = _hide;
        }

        public static DataSet FillDataSetLoaiPhong() { return connection.FillDataSet("Hospital.spGetLoaiPhongs", CommandType.StoredProcedure); }
        public int InsertLoaiPhong()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaLoaiPhong", "@TenLoaiPhong", "@GiaPhong", "@Hide" };
            object[] values = new object[4] { MaLoaiPhong, TenLoaiPhong, GiaPhong, Hide };
            i = connection.Excute_Sql("Hospital.spCreateLoaiPhongs", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateLoaiPhong()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaLoaiPhong", "@TenLoaiPhong", "@GiaPhong", "@Hide" };
            object[] values = new object[4] { MaLoaiPhong, TenLoaiPhong, GiaPhong, Hide };
            i = connection.Excute_Sql("Hospital.spUpdateLoaiPhongs", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteLoaiPhong()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaLoaiPhong" };
            object[] values = new object[1] { MaLoaiPhong };
            i = connection.Excute_Sql("Hospital.spDeleteLoaiPhongs", CommandType.StoredProcedure, paras, values);
            return i;
        }

       // public void getdata (DataGridView gridView) { gridView.DataSource = context.spGetLoaiPhongs(); }

        public static DataSet FillDataSet_getMaLoaiPhong()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaLoaiPhongParas", CommandType.StoredProcedure);
        }

       

        public string GetMaLoaiPhongTuDongTang()
        {
            var r = context.fnMaLoaiPhongTuDongTang();
            return r;
        }


    }
}
