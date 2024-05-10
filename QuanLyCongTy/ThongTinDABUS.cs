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
        public DuAnModel da;
        public Reload.Flp rl;
        FlowLayoutPanel flp;
        DuAnDAO duAnDAO = new DuAnDAO();
        PhanCongDAO phanCongDAO = new PhanCongDAO();

        public void FillControl(Label lblTen, Label lblDiaDiem, Label lblNgayBD, Label lblThoiHan, Label lblMoTa, FlowLayoutPanel flp)
        {
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
            List<PhanCongModel> listPCChuaHTTheoDA = phanCongDAO.ListPCTheoDA(da.MaDA);
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
            FPhanCong fPhanCong = new FPhanCong(da.NgayBD, da.DeadLine);
            fPhanCong.CapNhat(da, Fillflp);
            fPhanCong.ShowDialog();
        }
        public void OpenFChartDA()
        {
            FChartDA fChartDA = new FChartDA();
            fChartDA.CapNhat(da);
            fChartDA.ShowDialog();
        }

        public void Finished()
        {
            if(phanCongDAO.KiemTraTienDo(da))
            {
                if(!duAnDAO.HoanThanh(da))
                {
                    MessageBox.Show("Thất bại");
                }
                else
                {
                    rl();
                }
            }
            else
            {
                MessageBox.Show("Có task chưa hoàn thành!!!");
            }    
        }
    }
}
