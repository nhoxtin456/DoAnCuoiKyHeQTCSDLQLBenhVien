using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ThongTinBenhNhan = new HashSet<ThongTinBenhNhan>();
        }

        public string MaSo { get; set; }
        public int SoLuongThuocA { get; set; }
        public int SoLuongThuocB { get; set; }
        public int SoLuongThuocC { get; set; }
        public int SoLuongThuocD { get; set; }
        public int SoLuongThuocE { get; set; }
        public int? PhiDieuTri { get; set; }

        public virtual BenhNhan MaSoNavigation { get; set; }
        public virtual SoLuongBenhNhan SoLuongBenhNhan { get; set; }
        public virtual ICollection<ThongTinBenhNhan> ThongTinBenhNhan { get; set; }
    }
}
