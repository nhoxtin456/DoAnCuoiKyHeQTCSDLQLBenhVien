using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class HeSoLuong
    {
        public HeSoLuong()
        {
            NhanVien = new HashSet<NhanVien>();
        }

        public string NgheNghiep { get; set; }
        public double HeSoLuongTheoGio { get; set; }

        public virtual ICollection<NhanVien> NhanVien { get; set; }
    }
}
