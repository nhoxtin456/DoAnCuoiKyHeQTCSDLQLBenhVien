using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class SoLuongBenhNhan
    {
        public string Slbn { get; set; }

        public virtual HoaDon SlbnNavigation { get; set; }
    }
}
