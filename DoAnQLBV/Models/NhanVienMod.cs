using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    class NhanVienMod
    {
        QLBVDataContext context = new QLBVDataContext();
        protected string MaNV { get; set; }

        protected string MatKhau { get; set; }

        protected string HoNV { get; set; }

        protected string TenNV { get; set; }

        protected DateTime NgaySinh { get; set; }

        protected string GioiTinh { get; set; }

        protected string SDT { get; set; }

        protected string Email { get; set; }

        protected double Luong { get; set; }

        protected string Quyen { get; set; }

        protected bool Hide { get; set; }

        public NhanVienMod(string _MaNV)
        {
            MaNV = _MaNV;
        }
        public NhanVienMod()
        {

        }

        public NhanVienMod(string _maNhanVien, string _matKhauNhanVien, string _hoNhanVien, string _tenNhanVien, DateTime _ngaysinhNhanVien, string _giotinhNhanVien, string _sodienthoaiNhanVien, string _emailNhanVien, double _luongNhanVien, string _quyenNhanVien, bool _tinhtrangNhanVien)
        {
            MaNV = _maNhanVien;
            MatKhau = _matKhauNhanVien;
            HoNV = _hoNhanVien;
            TenNV = _tenNhanVien;
            NgaySinh = _ngaysinhNhanVien;
            GioiTinh = _giotinhNhanVien;
            SDT = _sodienthoaiNhanVien;
            Email = _emailNhanVien;
            Luong = _luongNhanVien;
            Quyen = _quyenNhanVien;
            Hide = _tinhtrangNhanVien;
        }

        public int InsertNhanVien()
        {
            int i = 0;
            string[] paras = new string[11] { "@MaNV", "@MatKhau", "HoNV", "@TenNV", "@NgaySinh", "@GioiTinh", "@SDT", "@Email", "@Luong", "@Quyen", "@Hide" };
            object[] values = new object[11] { MaNV, MatKhau, HoNV, TenNV, NgaySinh, GioiTinh, SDT, Email, Luong, Quyen, Hide };
            i = Models.connection.Excute_Sql("HR.spInsertNV", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int UpdateNhanVien()
        {
            int i = 0;
            string[] paras = new string[11] { "@MaNV", "@MatKhau", "HoNV", "@TenNV", "@NgaySinh", "@GioiTinh", "@SDT", "@Email", "@Luong", "@Quyen", "@Hide" };
            object[] values = new object[11] { MaNV, MatKhau, HoNV, TenNV, NgaySinh, GioiTinh, SDT, Email, Luong, Quyen, Hide };
            i = Models.connection.Excute_Sql("Hr.spUpdateNV", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int DeleteNhanVien()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaNV" };
            object[] values = new object[1] { MaNV };
            i = Models.connection.Excute_Sql("HR.spDeleteNV", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public static DataSet FillDataSetNhanVien()
        {
            return Models.connection.FillDataSet("HR.spGetNV", CommandType.StoredProcedure);
        }

        public DataSet FillDataSet_getSearchNVbyId()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaNV" };
            object[] values = new object[1] { MaNV };
            ds = Models.connection.FillDataSet("HR.spTimKiemNVTheoMaNV", CommandType.StoredProcedure, paras, values);
            return ds;
        }

        public DataSet FillDataSet_FindNVByTen()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@TenNV" };
            object[] values = new object[1] { MaNV };
            ds = Models.connection.FillDataSet("spTimKiemNVTheoTenNV", CommandType.StoredProcedure, paras, values);
            return ds;
        }

       

        public string GetMaNVTuDongTang() { return context.fnMaNhanVienTuDongTang(); }

        public static DataSet FillDataSet_getMaNV()
        {
            return Models.connection.FillDataSet("HR.spGetMaNhanVienParas", CommandType.StoredProcedure);
        }



    }
}