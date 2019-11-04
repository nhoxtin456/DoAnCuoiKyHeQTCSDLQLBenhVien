using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class NhanVien
    {
        public string MaNv { get; set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NgheNghiep { get; set; }
        public int SoNgayDiLam { get; set; }

        public virtual HeSoLuong NgheNghiepNavigation { get; set; }
    }
}
