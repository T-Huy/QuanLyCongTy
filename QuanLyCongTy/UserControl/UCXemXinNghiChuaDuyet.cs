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
    public partial class UCXemXinNghiChuaDuyet : UserControl
    {
        XemXinNghiChuaDuyetQLBUS xemXinNghiChuaDuyetQLBUS = new XemXinNghiChuaDuyetQLBUS();
  
        public UCXemXinNghiChuaDuyet()
        {
            InitializeComponent();
        }

        public void CapNhat(XinNghiModel xn, Reload.Flp HamRL)
        {
            xemXinNghiChuaDuyetQLBUS.xn = xn;
            xemXinNghiChuaDuyetQLBUS.HamRL = HamRL;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            xemXinNghiChuaDuyetQLBUS.OpenFThongBao(this);
        }

        private void UCXemXinNghiChuaDuyet_Load(object sender, EventArgs e)
        {
            xemXinNghiChuaDuyetQLBUS.FillControls(lb_MaNV, lb_NgayNghi, lb_SoNgayNghi, lb_Lydo);
        }
    }
}
