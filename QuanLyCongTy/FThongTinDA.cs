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
    public partial class FThongTinDA : Form
    {
        ThongTinDABUS thongTinDABUS = new ThongTinDABUS();

        public FThongTinDA()
        {
            InitializeComponent();
        }

        public void CapNhat(DuAnModel da, Reload.Flp rl)
        {
            thongTinDABUS.da = da;
            thongTinDABUS.rl  = rl;
        }

        private void FThongTinDA_Load(object sender, EventArgs e)
        {
            thongTinDABUS.FillControl(lblTen, lblDiaDiem, lblNgayBD, lblThoiHan, lblMoTa, flpPhanCong);
        }

        private void txtMoTa_MouseMove(object sender, MouseEventArgs e)
        {
            txtMoTa.SelectionLength = 0;
        }

        private void pbThem_Click(object sender, EventArgs e)
        {
            thongTinDABUS.OpenFThem();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            thongTinDABUS.Finished();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            thongTinDABUS.OpenFChartDA();
        }
    }
}
