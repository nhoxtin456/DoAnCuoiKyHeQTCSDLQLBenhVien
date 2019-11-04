using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class PhiDieuTri
    {
        public string Benh { get; set; }
        public int ChiPhi { get; set; }

        public virtual Benh BenhNavigation { get; set; }
    }
}
