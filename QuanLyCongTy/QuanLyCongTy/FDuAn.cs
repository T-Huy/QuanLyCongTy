using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class FDuAn : Form
    {
        XemDuAnQLBUS xemDuAnQLBUS = new XemDuAnQLBUS();
        public FDuAn()
        {
            InitializeComponent();
        }
        private void FDuAn_Load(object sender, EventArgs e)
        {
            xemDuAnQLBUS.AddFlp(flp_ListDA);
            xemDuAnQLBUS.FillDuAnChuaHT();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xemDuAnQLBUS.OpenFThemDA(this);
        }

        private void btnChuaHT_CheckedChanged(object sender, EventArgs e)
        {
            xemDuAnQLBUS.FillDuAnChuaHT();
        }

        private void btnDaHT_CheckedChanged(object sender, EventArgs e)
        {
            xemDuAnQLBUS.FillDuAnDaHT();
        }
    }
}
