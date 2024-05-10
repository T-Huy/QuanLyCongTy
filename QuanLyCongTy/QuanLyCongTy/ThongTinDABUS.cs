using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyCongTy.FXemDuAn;

namespace QuanLyCongTy
{
    internal class ThongTinDABUS
    {
        public string maDA;
        FlowLayoutPanel flp;
        DuAnDAO duAnDAO = new DuAnDAO();
        PhanCongDAO phanCongDAO = new PhanCongDAO();

        public void FillControl(Label lblTen, Label lblDiaDiem, Label lblNgayBD, Label lblThoiHan, Label lblMoTa, FlowLayoutPanel flp)
        {
            DuAnModel da = duAnDAO.getDuAnTheoMa(maDA);
            lblTen.Text = da.TenDuAn;
            lblDiaDiem.Text = da.DiaDiem;
            lblNgayBD.Text = da.NgayBD.ToShortDateString();
            lblThoiHan.Text = da.DeadLine.ToShortDateString();
            lblMoTa.Text = da.MoTa;
            this.flp = flp;
            Fillflp();

        }
        public void Fillflp()
        {
            flp.Controls.Clear();
            List<PhanCongModel> listPCChuaHTTheoDA = phanCongDAO.ListPCChuaHTTheoDA(maDA);
            foreach (PhanCongModel pc in listPCChuaHTTheoDA)
            {
                UCXemPhanCong uc = new UCXemPhanCong();
                uc.CapNhat(pc, Fillflp);
                uc.Margin = new Padding(10, 10, 0, 0);
                flp.Controls.Add(uc);
            }
        }
        public void OpenFThem()
        {
            DuAnModel da = duAnDAO.getDuAnTheoMa(maDA);
            FPhanCong fPhanCong = new FPhanCong();
            fPhanCong.CapNhat(da, Fillflp);
            fPhanCong.ShowDialog();
        }
    }
}
