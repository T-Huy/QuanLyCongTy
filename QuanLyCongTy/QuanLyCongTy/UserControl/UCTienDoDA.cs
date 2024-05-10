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
    public partial class UCTienDoDA : UserControl
    {
        XemDAChuaHTQLBUS xemDAChuaHTQLBUS = new XemDAChuaHTQLBUS();
        public UCTienDoDA()
        {
            InitializeComponent();
        }
        public void CapNhat(DuAnModel da, Reload.Flp HamRL)
        {
            xemDAChuaHTQLBUS.da = da;
            xemDAChuaHTQLBUS.HamRL = HamRL;
        }
        private void UCTienDoDA_Load(object sender, EventArgs e)
        {
            xemDAChuaHTQLBUS.FillControls(lblTenDA, lblTenPhong, lblNgayConLai, prgTienDo);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xemDAChuaHTQLBUS.OpenFThongBao(this);
        }

        private void ptbBG_Click(object sender, EventArgs e)
        {
            xemDAChuaHTQLBUS.OpenFSuaDA(this);
        }
    }
}
