using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemDuAnQLBUS
    {
        DuAnDAO duAnDAO = new DuAnDAO();
        FlowLayoutPanel flpListDA;
        public void AddFlp(FlowLayoutPanel flpListDA)
        {
            this.flpListDA = flpListDA;
        }
        public void FillDuAnChuaHT()
        {
            flpListDA.Controls.Clear();
            List<DuAnModel> listDA = duAnDAO.ListDuAnChuaHT();
            foreach(DuAnModel da in listDA)
            {
                UCTienDoDA uc = new UCTienDoDA();
                uc.CapNhat(da, FillDuAnChuaHT);
                flpListDA.Controls.Add(uc);
            }
        }
        public void FillDuAnDaHT()
        {
            flpListDA.Controls.Clear();
            List<DuAnModel> listDA = duAnDAO.ListDuAnDaHT();
            foreach (DuAnModel da in listDA)
            {
                UCSailorStar uc = new UCSailorStar();
                uc.CapNhat(da, FillDuAnChuaHT);
                flpListDA.Controls.Add(uc);
            }
        }
        public void OpenFThemDA(Form fthis)
        {
            FThemDA form = new FThemDA();
            fthis.Enabled = false;
            form.ShowDialog();
            fthis.Enabled = true;
            FillDuAnChuaHT();
        }
    }
}
