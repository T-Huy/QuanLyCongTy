using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemDADaHTTPBUS
    {
        public DuAnModel da;
        PhongBanDAO PhongBanDAO = new PhongBanDAO();
        public void FillControl(Label lblTenDA, Label lblTenPhong, Guna2ProgressBar prgTienDo, Guna2RatingStar ratingStar, Label lblTienDo)
        {
            PhongBanModel pb = PhongBanDAO.GetPhongBanTheoMaPB(da.MaPB);
            lblTenDA.Text = da.TenDuAn;
            lblTenPhong.Text = pb.TenPB;
            prgTienDo.Value = 100;
            ratingStar.Value = (int)(da.ChamDiem / 20);
            lblTienDo.Text = 100 + "%";
        }

        public void OpenFNhanXet()
        {
            FHoanThanhDuAn form = new FHoanThanhDuAn();
            form.CapNhat(da);
            form.ShowDialog();
        }
    }
}
