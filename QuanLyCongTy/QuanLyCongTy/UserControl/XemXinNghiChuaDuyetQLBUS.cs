using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemXinNghiChuaDuyetQLBUS
    {
        string MaNV;
        public XinNghiModel xn;
        public Reload.Flp HamRL;
        XinNghiDAO xinNghiDAO = new XinNghiDAO();
        
            private void FillControls(Label lb_MaNV, Label lb_HovaTen, Label lb_NgayNghi, Label lb_SoNgayNghi, Label lb_LyDo)
        {
            XinNghi xn = xinNghiDAO.LayDanhSachXinNghi(MaNV);

            lb_MaNV.Text = xn.MaNV;
            lb_HovaTen.Text = xn.HoVaTen;
            lb_NgayNghi.Text = "Nghỉ từ: " + xn.NgayBD.ToString();
            lb_SoNgayNghi.Text = xn.SoNgayNghi.ToString();
            lb_LyDo.Text = xn.LyDo.ToString();
        }

        void OpenForm(Form fnew, UCXemXinNghiChuaDuyet uc)
        {
            uc.Enabled = false;
            fnew.ShowDialog();
            uc.Enabled = true;
            HamRL();
        }

        public void OpenFThongBao(UCXemXinNghiChuaDuyet uc)
        {
            FThongBao form = new FThongBao();
            form.CapNhat(xn);
            OpenForm(form, uc);
        }

    }
}
