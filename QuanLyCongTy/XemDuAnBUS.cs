using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemDuAnBUS
    {
        public PhongBanModel pb;
        DuAnDAO duAnDAO = new DuAnDAO();
        FlowLayoutPanel flpListDA;
        public void AddFlp(FlowLayoutPanel flpListDA)
        {
            this.flpListDA = flpListDA;
        }
        public void FillDuAnChuaHT()
        {
            flpListDA.Controls.Clear();
            List<DuAnModel> listDA = duAnDAO.ListDuAnChuaHTTheoPB(pb);
            foreach (DuAnModel da in listDA)
            {
                UCXemDAChuaHT uc = new UCXemDAChuaHT();
                uc.CapNhat(da, FillDuAnChuaHT);
                flpListDA.Controls.Add(uc);
            }
        }

        public void FillDuAnDaHT()
        {
            flpListDA.Controls.Clear();
            List<DuAnModel> listDA = duAnDAO.ListDuAnDaHTTheoPB(pb);
            foreach (DuAnModel da in listDA)
            {
                UCXemDADaHT uc = new UCXemDADaHT();
                uc.CapNhat(da);
                flpListDA.Controls.Add(uc);
            }
        }
    }
}
