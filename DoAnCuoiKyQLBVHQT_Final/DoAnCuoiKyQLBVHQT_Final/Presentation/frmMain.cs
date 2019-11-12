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

namespace DoAnCuoiKyQLBVHQT_Final
{
    public partial class frmMain : Form
    {
        BLBacSi bacSi = new BLBacSi();
        //bool Them;
        string err;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.DataSource = bacSi.LayBacSi();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                bacSi.ThemBacSi(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDateTime(textBox4.Text), textBox5.Text, textBox6.Text, textBox7.Text, ref err);
                frmMain_Load(sender, e);
           

        }
    }
}
