using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class DoanhThuQuy3
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public string Benh { get; set; }
        public DateTime NgayXuatVien { get; set; }
        public int ChiPhi { get; set; }

        public virtual BenhNhan MaSoNavigation { get; set; }
    }
}
