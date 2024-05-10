using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class CapNhatTienDoBUS
    {
        public PhanCongModel pc;
        public Reload.Flp reLoadF;
        CongViecDAO congViecDAO = new CongViecDAO();
        PhanCongDAO phanCongDAO = new PhanCongDAO();

        public void FillControl(Label lblCV, Label lblMoTa, Guna2HScrollBar prgTienDo, Label lblTienDo)
        {
            lblCV.Text = congViecDAO.GetCongViecTheoMaCV(pc.MaCV).TenCV;
            lblMoTa.Text = pc.MoTa;
            prgTienDo.Value = pc.TienDo;
            lblTienDo.Text = pc.TienDo.ToString() + "%";
        }
        public void UpdateLbl(Guna2HScrollBar prgTienDo, Label lblTienDo)
        {
            lblTienDo.Text = prgTienDo.Value + "%";
            pc.TienDo = prgTienDo.Value;
        }
        public void CapNhatPC()
        {
            phanCongDAO.Sua(pc);
            reLoadF();
        }
    }
}
