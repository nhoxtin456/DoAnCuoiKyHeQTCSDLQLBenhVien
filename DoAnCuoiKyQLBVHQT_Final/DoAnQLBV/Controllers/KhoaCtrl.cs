using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLBV.Models;

namespace DoAnQLBV.Controllers
{
    class KhoaCtrl
    {
        public static int InsertKhoa(string _maKhoa, string _tenKhoa, bool _hideKhoa)
        {
            try
            {
                Models.KhoaMod khoaMod = new Models.KhoaMod(_maKhoa, _tenKhoa, _hideKhoa);
                return khoaMod.InsertKhoa();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateKhoa(string _maKhoa, string _tenKhoa, bool _hideKhoa)
        {
            try
            {
                KhoaMod khoaMod = new KhoaMod(_maKhoa, _tenKhoa, _hideKhoa);
                return khoaMod.UpdateKhoa();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteKhoa(string _maKhoa)
        {
            try
            {
                KhoaMod khoaMod = new KhoaMod(_maKhoa);
                return khoaMod.DeleteKhoa();
            }
            catch
            {
                return 0;
            }
        }
    }
}
