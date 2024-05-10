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
    partial class UCXemPhanCong : UserControl
    {
        XemPCChuaHTTPBUS xemPCChuaHTTPBUS = new XemPCChuaHTTPBUS();
        public UCXemPhanCong()
        {
            InitializeComponent();
        }
        public void CapNhat(PhanCongModel pc, Reload.Flp reLoadF)
        {
            xemPCChuaHTTPBUS.pc = pc;
            xemPCChuaHTTPBUS.reLoadF = reLoadF;
        }

        private void UCXemPhanCong_Load(object sender, EventArgs e)
        {
            xemPCChuaHTTPBUS.FillControl(lblTenCV, lblGTBatDauLam, lblTGConLai, prgTienDo, textBox1 );
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xemPCChuaHTTPBUS.OpenFPCXoa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xemPCChuaHTTPBUS.OpenFThemPC();
        }
    }
}
