using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class ThongTinBenhNhan
    {
        public string MaSo { get; set; }
        public DateTime NgayNhapVien { get; set; }
        public string SoPhong { get; set; }
        public string MshoaDon { get; set; }

        public virtual BenhNhan MaSoNavigation { get; set; }
        public virtual HoaDon MshoaDonNavigation { get; set; }
    }
}
