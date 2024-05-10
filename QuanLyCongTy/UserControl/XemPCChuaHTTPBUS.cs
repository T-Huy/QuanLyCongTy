using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemPCChuaHTTPBUS
    {
        public PhanCongModel pc;
        public Reload.Flp reLoadF;
        CongViecDAO congViecDAO = new CongViecDAO();
        PhanCongDAO phanCongDAO = new PhanCongDAO();
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        public void FillControl(Label lblTenCV, Label lblGTBatDauLam, Label lblTGConLai, Guna2ProgressBar ucTienDo1, TextBox textBox1, Label lblTienDo)
        {
            CongViecModel cv = congViecDAO.GetCongViecTheoMaCV(pc.MaCV);
            NhanVienModel nv = nhanVienDAO.GetNhanVienTheoMaNV(pc.MaNV);

            lblTenCV.Text = cv.TenCV;
            lblGTBatDauLam.Text = "Ngày bắt đầu: " + pc.NgayBD.ToString("dd/MM/yyyy");
            lblTGConLai.Text = "Còn " + (pc.DeadLine.Subtract(DateTime.Now)).Days.ToString() + " Ngày";
            ucTienDo1.Value = pc.TienDo;
            lblTienDo.Text = pc.TienDo.ToString()+"%";
            textBox1.Text = nv.HoTenNV;
        }
        public void OpenFPCXoa()
        {
            FXoaPC fXoaPC = new FXoaPC();
            fXoaPC.CapNhat(pc, reLoadF);
            fXoaPC.ShowDialog();
        }

        public void OpenFThemPC()
        {
            FThemTroGiup fThemTroGiup = new FThemTroGiup();
            fThemTroGiup.CapNhat(pc, reLoadF);
            fThemTroGiup.ShowDialog();
        }
    }
}
