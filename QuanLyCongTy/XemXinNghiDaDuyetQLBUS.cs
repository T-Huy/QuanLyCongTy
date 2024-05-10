using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemXinNghiDaDuyetQLBUS
    {
        public XinNghiModel xn;
        public Reload.Flp HamRL;


        public void FillControls(Label lb_MaNV, Label lb_NgayNghi, Label lb_SoNgayNghi, Label lb_LyDo)
        {
            lb_MaNV.Text = xn.MaNV;
            lb_NgayNghi.Text = "Nghỉ từ: " + xn.NgayBD.ToString();
            lb_SoNgayNghi.Text = xn.SoNgayNghi.ToString();
            lb_LyDo.Text = xn.LyDo.ToString();
        }

        void OpenForm(Form f, UCXemXinNghiDaDuyet uc)
        {
            uc.Enabled = false;
            f.ShowDialog();
            uc.Enabled = true;
            HamRL();
        }
    }
}
