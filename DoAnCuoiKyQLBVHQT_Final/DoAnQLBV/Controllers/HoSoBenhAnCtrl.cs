using DoAnQLBV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoAnQLBV.Controllers
{
    class HoSoBenhAnCtrl
    {
        public static int InsertHoSoBenhAn(string _maBA, string _chuanDoanBenh, string _maBS, string _maPhong, double _soNgayO, bool _hide)
        {
            try
            {
                HoSoBenhAnMod hoSoBenhAnMod = new HoSoBenhAnMod(_maBA, _chuanDoanBenh, _maBS, _maPhong, _soNgayO, _hide);
                return hoSoBenhAnMod.InsertHoSoBenhAn();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateHoSoBenhAn(string _maBA, string _chuanDoanBenh, string _maBS, string _maPhong, double _soNgayO, bool _hide)
        {
            try
            {
                HoSoBenhAnMod hoSoBenhAnMod = new HoSoBenhAnMod(_maBA, _chuanDoanBenh, _maBS, _maPhong, _soNgayO, _hide);
                return hoSoBenhAnMod.UpdateHoSoBenhAn();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteHoSoBenhAn(string _maBA)
        {
            try
            {
                HoSoBenhAnMod hoSoBenhAnMod = new HoSoBenhAnMod(_maBA);
                return hoSoBenhAnMod.DeleteHoSoBenhAn();
            }
            catch
            {
                return 0;
            }
        }
    }
}
