using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemPCNVBUS
    {
        public PhanCongModel pc;
        public Reload.Flp reLoadF;
        CongViecDAO congViecDAO = new CongViecDAO();
        public void FillControl(Label lblTenCV,Label lblNgayBD, Label NgayCl, Guna2ProgressBar prgTienDo, Label lblTienDo)
        {
            CongViecModel cv = congViecDAO.GetCongViecTheoMaCV(pc.MaCV);
            lblTenCV.Text = cv.TenCV;
            lblNgayBD.Text = pc.NgayBD.ToString("dd/MM/yyyy");
            NgayCl.Text = "Thời hạn: Còn " + pc.DeadLine.Subtract(pc.NgayBD).Days.ToString() + " ngày.";
            prgTienDo.Value = pc.TienDo;
            lblTienDo.Text = pc.TienDo.ToString() + "%";
        }
        public void OpenFCapNhatTienDo()
        {
            FCapNhatTienDo fCapNhatTienDo = new FCapNhatTienDo();
            fCapNhatTienDo.CapNhat(pc, reLoadF);
            fCapNhatTienDo.ShowDialog();
        }
    }
}
