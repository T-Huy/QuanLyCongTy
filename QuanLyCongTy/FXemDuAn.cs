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
    public partial class FXemDuAn : Form
    {
        XemDuAnBUS xemDuAnBUS = new XemDuAnBUS();
        public delegate void FReload();

        public FXemDuAn()
        {
            InitializeComponent();
        }

        public void CapNhat(PhongBanModel pb)
        {
            xemDuAnBUS.pb = pb;
            xemDuAnBUS.AddFlp(flp_ListDA);
        }
        private void FXemDuAn_Load(object sender, EventArgs e)
        {
            xemDuAnBUS.FillDuAnChuaHT();
        }

        private void btnDaHT_CheckedChanged(object sender, EventArgs e)
        {
            xemDuAnBUS.FillDuAnDaHT();
        }

        private void btnChuaHT_CheckedChanged(object sender, EventArgs e)
        {
            xemDuAnBUS.FillDuAnChuaHT(); 
        }
    }
}
