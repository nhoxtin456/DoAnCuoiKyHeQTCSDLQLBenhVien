using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKyQLBVHQT_Final.BS_Layer
{
    public class BLNhanVien
    {

        QLBVDataContext context = new QLBVDataContext();
        NhanVien nhanVien = new NhanVien();

        public DataTable LayNV()
        {
            var nv = context.spGetNV();
            DataTable dt = new DataTable();
            dt.Columns.Add("Ma NV");
            dt.Columns.Add("Ho NV");
            dt.Columns.Add("Ten NV");
            dt.Columns.Add("Ngay Sinh");
            dt.Columns.Add("Gioi Tinh");
            dt.Columns.Add("Ma Loai NV");
            dt.Columns.Add("Password");
            dt.Columns.Add("Hide");

            foreach (var r in nv) dt.Rows.Add(r.MaNV, r.HoNV, r.TenNV, r.NgaySinh.Date, r.GioiTinh, r.MaLoaiNV, r.Password, r.Hide);


            return dt;
        }



        //public bool ThemNV(string MaNVV, string HoTenn, string GioiTinhh, string DiaChii, DateTime NgaySinhh, string NgheNghiepp, ref string err)
        //{
        //    //QuanLyBenhVIENDataContext qlBN = new QuanLyBenhVIENDataContext();
        //    //NhanVien nv = new NhanVien();
        //    nv.MaNV = MaNVV;
        //    nv.HoTen = HoTenn;
        //    nv.GioiTinh = GioiTinhh;
        //    nv.DiaChi = DiaChii;
        //    nv.DateOfBirth = NgaySinhh;
        //    nv.NgheNghiep = NgheNghiepp;
        //    nv.SoNgayDiLam = 0;

        //    qlBN.NhanViens.InsertOnSubmit(nv);
        //    qlBN.NhanViens.Context.SubmitChanges();
        //    return true;

        //}
    }
}
