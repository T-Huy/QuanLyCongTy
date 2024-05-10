using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class KPIBUS
    {
        public NhanVienModel nv;
        FlowLayoutPanel flp;
        PhanCongDAO phanCongDAO = new PhanCongDAO();
        public void AddFlp(FlowLayoutPanel flp)
        {
            this.flp = flp;
        }
        public void FillflpChuaHT()
        {
            flp.Controls.Clear();
            List<PhanCongModel> list = phanCongDAO.ListPCChuaHTTheoNV(nv);
            foreach (PhanCongModel pc in list)
            {
                UCXemPhanCong_NhanVien uc = new UCXemPhanCong_NhanVien();
                uc.CapNhat(pc, FillflpChuaHT);
                flp.Controls.Add(uc);
            }
        }

        public void FillFlpDaHT()
        {
            flp.Controls.Clear();
            List<PhanCongModel> list = phanCongDAO.ListPCDaHTTheoNV(nv);
            foreach (PhanCongModel pc in list)
            {
                UCPhanCongDaHT uc = new UCPhanCongDaHT();
                uc.CapNhat(pc);
                flp.Controls.Add(uc);
            }
        }
    }
}
