using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemDAChuaHTQLBUS
    {
        public DuAnModel da;
        public Reload.Flp HamRL;
        DuAnDAO duAnDAO = new DuAnDAO();
        PhongBanDAO PhongBanDAO = new PhongBanDAO();
        public void FillControls(Label lbl_tenDA,Label lbl_TenPhong, Label lbl_NgayCL,Guna2ProgressBar prgTienDo)
        {
            PhongBanModel pb = PhongBanDAO.GetPhongBanTheoMaPB(da.MaPB);
            lbl_tenDA.Text = da.TenDuAn;
            lbl_TenPhong.Text = pb.TenPB;
            lbl_NgayCL.Text = "Thời hạn: Còn " + da.DeadLine.Subtract(da.NgayBD).Days.ToString() + " ngày.";
            prgTienDo.Value = duAnDAO.GetTienDo(da);
        }
        void OpenForm(Form fnew,UCTienDoDA uc)
        {
            uc.Enabled = false;
            fnew.ShowDialog();
            uc.Enabled = true;
            HamRL();
        }
        public void OpenFSuaDA(UCTienDoDA uc)
        {
            FSuaDA form = new FSuaDA();
            form.CapNhat(da);
            OpenForm(form, uc);
        }
        public void OpenFThongBao(UCTienDoDA uc)
        {
            FThongBao form = new FThongBao();
            form.CapNhat(da);
            OpenForm(form, uc);
        }

    }
}
