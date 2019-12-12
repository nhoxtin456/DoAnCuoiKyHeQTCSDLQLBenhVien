using DoAnQLBV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Controllers
{
    class BacSiCtrl
    {
        public static int InsertBacSi(string _maBS, string _hoBS, string _tenBS, DateTime _ngaySinh, string _gioiTinh, string _chucVu, string _maKhoa, bool _hide)
        {
            try
            {
                BacSiMod bacSiMod = new BacSiMod(_maBS, _hoBS, _tenBS, _ngaySinh, _gioiTinh, _chucVu, _maKhoa, _hide);
                return bacSiMod.InsertBacSi();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateBacSi(string _maBS, string _hoBS, string _tenBS, DateTime _ngaySinh, string _gioiTinh, string _chucVu, string _maKhoa, bool _hide)
        {
            try
            {
                BacSiMod bacSiMod = new BacSiMod(_maBS, _hoBS, _tenBS, _ngaySinh, _gioiTinh, _chucVu, _maKhoa, _hide);
                return bacSiMod.UpdateBacSi();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteBacSi (string _maBS)
        {
            try
            {
                BacSiMod bacSiMod = new BacSiMod(_maBS);
                return bacSiMod.DeleteBacSi();
            }
            catch
            {
                return 0;
            }
        }
    }
}