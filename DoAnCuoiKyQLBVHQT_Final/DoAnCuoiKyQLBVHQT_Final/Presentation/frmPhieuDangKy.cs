using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKyQLBVHQT_Final.BS_Layer;

namespace DoAnCuoiKyQLBVHQT_Final.Presentation
{
    public partial class frmPhieuDangKy : Form
    {
        BLPhieuDangKy bL = new BLPhieuDangKy();
        public frmPhieuDangKy()
        {
            InitializeComponent();
        }

        private void frmPhieuDangKy_Load(object sender, EventArgs e)
        {
            this.dgvPhieuDK.DataSource = bL.LayPhieuDK();
        }
    }
}
