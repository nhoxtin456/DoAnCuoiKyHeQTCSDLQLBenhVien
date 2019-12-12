using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBV.Models
{
    class HoaDonMod
    {
        QLBVDataContext context = new QLBVDataContext();
        protected string MaHD { get; set; }
        protected string TenHD { get; set; }
        protected double GiaHD { get; set; }
        protected bool Hide { get; set; }
        protected string MaNV { get; set; }
        protected string MaBA { get; set; }
        protected DateTime NgayLapHD { get; set; }
        protected DateTime NgayThanhToanHD { get; set; }

        protected DateTime ThoiGian { get; set; }

        public HoaDonMod() { }
        public HoaDonMod(string _maHD) { MaHD = _maHD; }
        public HoaDonMod(string _maHD, string _tenHD, double _giaHD, bool _hide, string _maNhanVien, string _maHoSoBenhAn, DateTime _ngayLapHD, DateTime _ngayThanhToanHD, DateTime _thoiGian)
        {
            MaHD = _maHD;
            TenHD = _tenHD;
            GiaHD = _giaHD;
            Hide = _hide;
            MaNV = _maNhanVien;
            MaBA = _maHoSoBenhAn;
            NgayLapHD = _ngayLapHD;
            NgayThanhToanHD = _ngayThanhToanHD;
            ThoiGian = _thoiGian;
        }
        public static DataSet FillDataSetHoaDon() { return connection.FillDataSet("Hospital.spGetHD"); }


        public static DataSet FillDataSetHoaDonPhong() { return connection.FillDataSet("Hospital.fnHDPhong"); }

        public static DataSet FillDataSetHoaDonThuoc() { return connection.FillDataSet("Hospital.fnHDThuoc"); }

        public static DataSet FillDataSetHoaDonXN() { return connection.FillDataSet("Hospital.fnHDXetNghiem"); }

        //public static DataSet FillDataSetHoaDonAll() { return connection.FillDataSet("Hospital.fnHDTongJoin"); }

        ////public int GetHoaDonTong()
        ////{
        ////    int i = 0;
        ////    string[] paras = new string[1] { "@MaHD"};
        ////    object[] values = new object[1] { MaHD};
        ////    i = connection.Excute_Sql("Hospital.spGetHDTong", CommandType.StoredProcedure, paras, values);
        ////    return i;
        ////}




        public int InsertHoaDon()
        {
            int i = 0;
            string[] paras = new string[9] { "@MaHD", "@TenHD", "@GiaHD", "@Hide", "@MaNV", "@MaBA", "@NgayLapHD", "@NgayThanhToanHD","@ThoiGian" };
            object[] values = new object[9] { MaHD, TenHD, GiaHD, Hide, MaNV, MaBA, NgayLapHD, NgayThanhToanHD,ThoiGian };
            i = connection.Excute_Sql("Hospital.spCreateHoaDons", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateHoaDon()
        {
            int i = 0;
            string[] paras = new string[9] { "@MaHD", "@TenHD", "@GiaHD", "@Hide", "@MaNV", "@MaBA", "@NgayLapHD", "@NgayThanhToanHD","@ThoiGian" };
            object[] values = new object[9] { MaHD, TenHD, GiaHD, Hide, MaNV, MaBA, NgayLapHD, NgayThanhToanHD,ThoiGian };
            i = connection.Excute_Sql("Hospital.spUpdateHoaDons", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteHoaDon()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaHD" };
            object[] values = new object[1] { MaHD };
            i = connection.Excute_Sql("Hospital.spDeleteHoaDons", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int TinhTienHD(string text)
        {
            int i = 0;
            string[] paras = new string[1] { "@MaHD" };
            object[] values = new object[1] { MaHD };
            i = connection.Excute_Sql("Hospital.spTinhTongHoaDonTheoMaHD", CommandType.StoredProcedure, paras, values);
            return i;

            //  public static string GetTongDoanhThu(DateTime NgayStart, DateTime NgayEnd)
            //{
            //    return connection.ExcuteScalar3("select dbo.TongTienDoanhThu('" + NgayStart + "','" + NgayEnd + "');", CommandType.Text);
            //}
            //}


        }

        public void HoaDonUndo() { context.spUndoHoaDons(); }
        public void HoaDonRedo() { context.spRedoHoaDons(); }

        //public static DataSet FillDataSet_getMaNV()
        //{
        //    return Models.connection.FillDataSet("HR.spGetMaNhanVienParas", CommandType.StoredProcedure);
        //}


        public double? TinhTongHDAll (string _maHD)
        {
            var r = context.fnTinhTongHoaDonAll(_maHD);
            return r;
        
        }

        public void LayTableHD(DataGridView gridView, string _maHD)
        {
            gridView.DataSource = context.fnTableHoaDonAll(_maHD);
        }




        public DataTable LayHDTongAll(string _maHD)
        {
            var hd = context.fnTableHoaDonAll(_maHD);
            DataTable dt = new DataTable();
            dt.Columns.Add("Ma BA");
            dt.Columns.Add("Chuan Doan Benh");
            dt.Columns.Add("Ma BS");
            dt.Columns.Add("Ma Phong");
            dt.Columns.Add("So Ngay O");
            dt.Columns.Add("Tinh Trang");
            dt.Columns.Add("Ho BS");
            dt.Columns.Add("Ten BS");
            dt.Columns.Add("Mã XN");
            dt.Columns.Add("Ngày XN");
            dt.Columns.Add("Ten XN");
            dt.Columns.Add("Ma Loai XN");
            dt.Columns.Add("Ten Loai XN");
            dt.Columns.Add("Gia LXN");
            dt.Columns.Add("Ma HD");
            dt.Columns.Add("Ten HD");
            dt.Columns.Add("Gia HD");
            dt.Columns.Add("Thoi Gian");
            dt.Columns.Add("Thanh Toan");
            dt.Columns.Add("Ma NV");
            dt.Columns.Add("Ma Thuoc");
            dt.Columns.Add("So Luong");
            dt.Columns.Add("Ten Thuoc");
            dt.Columns.Add("Gia Thuoc");
            dt.Columns.Add("Ma Loai Phong");
            dt.Columns.Add("Ten Phong");
            dt.Columns.Add("Ten Loai Phong");
            dt.Columns.Add("Gia Phong");

            foreach (var r in hd) dt.Rows.Add(r.MaBA, r.ChuanDoanBenh, r.MaBS, r.MaPhong, r.SoNgayO, r.TinhTrang, r.HoBS, r.TenBS, r.MaXN, r.NgayXN, r.TenXN, r.MaLoaiXN, r.TenLoaiXN, r.GiaLXN, r.MaHD, r.TenHD, r.GiaHD, r.ThoiGian, r.ThanhToan, r.MaNV, r.MaThuoc, r.SoLuong, r.TenThuoc
                , r.GiaThuoc, r.MaLoaiPhong, r.TenPhong, r.TenLoaiPhong, r.GiaPhong);


            return dt;
        }







        public double? TinhHoaDonPhong(string _maHD)
        {
            var r = context.fnTinhTongHDPhong(_maHD);
            return r;
        }
        public double? TinhHoaDonThuoc(string _maHD)
        {
            return context.fnTinhTongHDThuoc(_maHD);

        }
        public double? TinhHoaDonXetNghiem(string _maHD)
        {
            return context.fnTinhTongHDXN(_maHD);
        }
        public double? TinhHoaDonTongAll(string _maHD)
        {
            return context.fnTinhTongHDAllx(_maHD);
        }






        //private static DoanhThuMod instance;

        //public static DoanhThuMod Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new DoanhThuMod();
        //        return instance;
        //    }

        //    private set
        //    {
        //        instance = value;
        //    }
        //}

        //private DoanhThuMod() { }

        public DataTable HienThiDoanhThu()
        {
            return KetNoi.Instance.ExecuteQuery("select * FROM Hospital.HoaDons");
        }
        public static DataSet GetDoanhThu(DateTime NgayStart, DateTime NgayEnd)
        {
            return connection.ExcuteScalar2("select MaHD,MaBA,TenHD,GiaHD,SoLuong,ThoiGian,dbo.HienThiThu(ThoiGian) as Thu,ThanhTien from GoiMon where CONVERT(datetime,ThoiGian,103) between CONVERT(DATETIME,'" + NgayStart + "',103) and convert(datetime,'" + NgayEnd + "',103);", CommandType.Text);
        }
        public static string GetTongDoanhThu(DateTime NgayStart, DateTime NgayEnd)
        {
            return connection.ExcuteScalar3("select Hospital.TongTienDoanhThu('" + NgayStart + "','" + NgayEnd + "');", CommandType.Text);
        }

        public static DataSet SearchKhuVuc(String KhuVuc)
        {
            return connection.ExcuteScalar4("Select * from dbo.TimKiemKhuVuc('" + KhuVuc + "');", CommandType.Text);
        }


        public static DataSet FillDataSet_getDonGiaHoaDon()
        {
            DataSet ds = new DataSet();
            try
            {

                ds = Models.connection.FillDataSet("HienThiThongTinHoaDon", CommandType.StoredProcedure);
            }
            catch { }
            return ds;
        }

        //public void getData(DataGridView temp)
        //{
        //    temp.DataSource = context.fnTongHDJoin();
        //}

        public static DataSet FillDataSet_getMaHD()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaHDParas", CommandType.StoredProcedure);
        }

        public string GetMaHDTuDongTang() { return context.fnMaHoaDonTuDongTang(); }

        public static DataSet FillDataSet_getMaNV()
        {
            return Models.connection.FillDataSet("HR.spGetMaNhanVienParas", CommandType.StoredProcedure);
        }

        public static DataSet FillDataSet_getMaBA()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaBAParas", CommandType.StoredProcedure);
        }









    }
}
