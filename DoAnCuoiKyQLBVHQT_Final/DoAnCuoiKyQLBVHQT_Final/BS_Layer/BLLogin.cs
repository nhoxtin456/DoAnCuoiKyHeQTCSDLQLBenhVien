using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKyQLBVHQT_Final.BS_Layer
{
    public class BLLogin
    {
        QLBVDataContext context = new QLBVDataContext();
        

        public bool KiemTraDangNhap(string user, string password, string chucvu)
        {
            var dn = context.spGetUser(user, password, chucvu);
            int count = 0;

            foreach (var r in dn) count++;
            if (count == 0) return false;
            return true;
        }

    }
}
