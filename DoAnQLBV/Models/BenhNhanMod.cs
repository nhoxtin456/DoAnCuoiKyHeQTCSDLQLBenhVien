using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBV.Models
{
    class BenhNhanMod
    {
        QLBVDataContext context = new QLBVDataContext();

        protected string MaBN { get; set; }
        protected string HoBN { get; set; }
        protected string TenBN { get; set; }
        protected DateTime NgaySinh { get; set; }
        protected string GioiTinh { get; set; }
        protected bool Hide { get; set; }
        
        public BenhNhanMod (string _MaBN)
        {
            MaBN = _MaBN;
        }
        public BenhNhanMod() { }
        public BenhNhanMod (string _maBN, string _hoBN, string _tenBN, DateTime _ngaySinh, string _gioiTinh, bool _hide)
        {
            MaBN = _maBN;
            HoBN = _hoBN;
            TenBN = _tenBN;
            NgaySinh = _ngaySinh;
            GioiTinh = _gioiTinh;
            Hide = _hide;
        }
        public static DataSet FillDataSetBenhNhan() { return connection.FillDataSet("Hospital.spGetBN", CommandType.StoredProcedure); }
        public int InsertBenhNhan ()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaBN", "@HoBN", "@TenBN", "@NgaySinh", "@GioiTinh", "@Hide" };
            object[] values = new object[6] { MaBN, HoBN, TenBN, NgaySinh, GioiTinh, Hide };
            i = connection.Excute_Sql("Hospital.spInsertBN", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateBenhNhan()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaBN", "@HoBN", "@TenBN", "@NgaySinh", "@GioiTinh", "@Hide" };
            object[] values = new object[6] { MaBN, HoBN, TenBN, NgaySinh, GioiTinh, Hide };
            i = connection.Excute_Sql("Hospital.spUpdateBN", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteBenhNhan()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaBN" };
            object[] values = new object[1] { MaBN };
            i = connection.Excute_Sql("Hospital.spDeleteBN", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSet_getMaBN()
        {
            return Models.connection.FillDataSet("Hospital.spGetMaBNParas", CommandType.StoredProcedure);
        }

        public string GetMaBNTuDongTang() { return context.fnMaBenhNhanTuDongTang(); }

        //public DataTable TimBenhNhanDong(string _maBN, string _hoBN, string _tenBN, DateTime _ngaySinh, string _gioiTinh)
        //{

        //    var bn = context.SearchBenhNhan(_maBN, _hoBN, _tenBN, _ngaySinh, _gioiTinh);
           
        //    DataTable table = new DataTable();
        //    table.Columns.Add("Ma BN");
        //    table.Columns.Add("Ho BN");
        //    table.Columns.Add("Ten BN");
        //    table.Columns.Add("Ngay Sinh");
        //    table.Columns.Add("Gioi Tinh");
        //    table.Columns.Add("Tinh Trang");

        //    foreach (var r in bn) table.Rows.Add(r.MaBN, r.HoBN, r.TenBN, r.NgaySinh, r.GioiTinh);
        //    return table;
        //}

        //public void GetBenhNhan(DataGridView dgv)
        //{
        //    dgv.DataSource = context.spGetBN();
        //}

    }
}