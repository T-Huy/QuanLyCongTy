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
        XinNghiDAO xnDAO = new XinNghiDAO();
        string MaNV;
        Reload.Flp HamRL;
        public UCXemXinNghiChuaDuyet(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        public void CapNhat(XinNghiModel xn, Reload.Flp HamRL)
        {
            xemXinNghiChuaDuyetQLBUS.xn = xn;
            xemXinNghiChuaDuyetQLBUS.HamRL = HamRL;
        }

        public void addReLoat(Reload.Flp HamRL)
        {
            this.HamRL = HamRL;
        }

        private void UCXinNghi_Load(object sender, EventArgs e)
        {
            XinNghi xn = xnDAO.LayDanhSachXinNghi(MaNV);

            lb_MaNV.Text = MaNV;
            lb_HovaTen.Text = xn.HoVaTen;
            lb_NgayNghi.Text = "Nghỉ từ: " + xn.NgayBD.ToString() ;
            lb_SoNgayNghi.Text = xn.SoNgayNghi.ToString();
            lb_Lydo.Text = xn.LyDo.ToString();
        }

        private void btn_Duyet_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            xemXinNghiChuaDuyetQLBUS.OpenFThongBao(this);
        }
    }
}
