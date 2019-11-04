using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Benh
    {
        public string TenBenh { get; set; }
        public string TrieuChung1 { get; set; }
        public string TrieuChung2 { get; set; }
        public string TrieuChung3 { get; set; }

        public virtual PhiDieuTri PhiDieuTri { get; set; }
    }
}
