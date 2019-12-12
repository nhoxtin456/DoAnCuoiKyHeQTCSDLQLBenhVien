using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    class PhieuDangKyMod
    {
        QLBVDataContext context = new QLBVDataContext();
        protected string MaPhieuDK { get; set; }
        protected bool Hide { get; set; }
        protected string MaNV { get; set; }
        protected string MaBN { get; set; }
        protected string MaKhoa { get; set; }
        protected string MaBA { get; set; }

        public PhieuDangKyMod (string _MaPhieuDK)
        {
            MaPhieuDK = _MaPhieuDK;
        }
        public PhieuDangKyMod() { }
        public PhieuDangKyMod(string _maPhieuDK, bool _hidePhieuDK, string _maNhanVien, string _maBenhNhan, string _maKhoa, string _maHoSoBenhAn)
        {
            MaPhieuDK = _maPhieuDK;
            Hide = _hidePhieuDK;
            MaNV = _maNhanVien;
            MaBN = _maBenhNhan;
            MaKhoa = _maKhoa;
            MaBA = _maHoSoBenhAn;
        }
        public static DataSet FillDataSetPhieuDangKy () { return connection.FillDataSet("Hospital.spGetPhieuDangKy", CommandType.StoredProcedure); }
        public int InsertPhieuDangKy()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaPhieuDK", "@Hide", "@MaNV", "@MaBN", "@MaKhoa", "@MaBA" };
            object[] values = new object[6] { MaPhieuDK, Hide, MaNV, MaBN, MaKhoa, MaBA };
            i = connection.Excute_Sql("Hospital.spCreatePhieuDangKy", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdatePhieuDangKy()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaPhieuDK", "@Hide", "@MaNV", "@MaBN", "@MaKhoa", "@MaBA" };
            object[] values = new object[6] { MaPhieuDK, Hide, MaNV, MaBN, MaKhoa, MaBA };
            i = connection.Excute_Sql("Hospital.spUpdatePhieuDangKy", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeletePhieuDangKy()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaPhieuDK" };
            object[] values = new object[1] { MaPhieuDK };
            i = connection.Excute_Sql("Hospital.spDeletePhieuDangKy", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public string GetMaPhieuDKTuDongTang() { return context.fnMaPhieuDKTuDongTang(); }

        public static DataSet FillDataSet_getMaPhieuDK()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaPhieuDKParas", CommandType.StoredProcedure);
        }


        public static DataSet FillDataSet_getMaBA()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaBAParas", CommandType.StoredProcedure);
        }

      

        public static DataSet FillDataSet_getMaNV()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaNVParas", CommandType.StoredProcedure);
        }

        public static DataSet FillDataSet_getMaBN()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaBNParas", CommandType.StoredProcedure);
        }


        public static DataSet FillDataSet_getMaKhoa()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaKhoaParas", CommandType.StoredProcedure);
        }

      







    }
}