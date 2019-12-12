using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    class KetNoiMod
    {
        private static KetNoiMod instance;
        public static KetNoiMod Instance
        {
            get
            {
                if (instance == null)
                    instance = new KetNoiMod();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private KetNoiMod() { }
        public bool DoiMatKhau(string username, string MatKhauCu, string MatKhauMoi)
        {
            int data = KetNoi.Instance.ExecuteNonQuery("Exec HR.spDoiMatKhauDangNhap @username , @passwordcu , @passwordmoi", new object[] { username, MatKhauCu, MatKhauMoi });
            return data > 0;
        }
    }
}
