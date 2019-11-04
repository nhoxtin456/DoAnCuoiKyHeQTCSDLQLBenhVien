using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class BenhNhan
    {
        public BenhNhan()
        {
            ThongTinBenhNhan = new HashSet<ThongTinBenhNhan>();
        }

        public string MaBenhNhan { get; set; }
        public string TenBenhNhan { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public string Benh { get; set; }
        public string TinhTrang { get; set; }

        public virtual DoanhThuQuy1 DoanhThuQuy1 { get; set; }
        public virtual DoanhThuQuy2 DoanhThuQuy2 { get; set; }
        public virtual DoanhThuQuy3 DoanhThuQuy3 { get; set; }
        public virtual DsbenhNhanDaXuatVien DsbenhNhanDaXuatVien { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual ICollection<ThongTinBenhNhan> ThongTinBenhNhan { get; set; }
    }
}
