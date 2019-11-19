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
    public partial class frmBacSi : Form
    {
        BLBacSi bL = new BLBacSi();

        public frmBacSi()
        {
            InitializeComponent();
        }

        private void frmBacSi_Load(object sender, EventArgs e)
        {
            this.dgvBS.DataSource = bL.GetBS();
            
        }

      
    }
}
