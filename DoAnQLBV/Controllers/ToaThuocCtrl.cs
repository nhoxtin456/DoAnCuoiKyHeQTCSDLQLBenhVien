using DoAnQLBV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Controllers
{
    class ToaThuocCtrl
    {
        public static int InsertToaThuoc(string _maThuoc, string _maBA, int _soLuong, bool _hide)
        {
            try
            {
                ToaThuocMod toaThuocMod = new ToaThuocMod(_maThuoc, _maBA, _soLuong, _hide);
                return toaThuocMod.InsertToaThuoc();
            }
            catch { return 0; }
        }
        public static int UpdateToaThuoc(string _maThuoc, string _maBA, int _soLuong, bool _hide)
        {
            try
            {
                ToaThuocMod toaThuocMod = new ToaThuocMod(_maThuoc, _maBA, _soLuong, _hide);
                return toaThuocMod.UpdateToaThuoc();
            }
            catch { return 0; }
        }
        public static int DeleteToaThuoc(string _maThuoc, string _maBA)
        {
            try
            {
                ToaThuocMod toaThuocMod = new ToaThuocMod(_maThuoc, _maBA);
                return toaThuocMod.DeleteToaThuoc();
            }
            catch
            {
                return 0;
            }
        }
    }
}
