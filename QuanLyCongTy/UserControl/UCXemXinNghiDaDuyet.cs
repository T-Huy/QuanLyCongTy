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
    public partial class UCXemXinNghiDaDuyet : UserControl
    {
        XemXinNghiDaDuyetTPBUS xemXinNghiDaDuyetTPBUS = new XemXinNghiDaDuyetTPBUS();
        public UCXemXinNghiDaDuyet()
        {
            InitializeComponent();
        }


        public void CapNhat(XinNghiModel xn, Reload.Flp HamRL)
        {
            xemXinNghiDaDuyetTPBUS.xn = xn;
        }

        private void UCXemXinNghiDaDuyet_Load(object sender, EventArgs e)
        {
            xemXinNghiDaDuyetTPBUS.FillControls(lb_MaNV, lb_NgayNghi, lb_SoNgayNghi, lb_LyDo);
        }
    }
}
