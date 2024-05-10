using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class UCXemDAChuaHT : UserControl
    {
        TienDoDADAO ttdaDAO = new TienDoDADAO();
        string MaDA;
        FDuAn.FReload HamRL;
        public UCXemDAChuaHT(string MaDA)
        {
            InitializeComponent();
            this.MaDA = MaDA;
        }

        private void UCTienDoDA_Load(object sender, EventArgs e)
        {
            TienDoDA td = ttdaDAO.LayDanhSachDuAn(MaDA);

            lbl_tenDA.Text = td.TenDuAn;
            lbl_TenPhong.Text = td.TenPB;
            lbl_NgayCL.Text = "Thời hạn: Còn " + td.NgayKT.Subtract(td.NgayBD).Days.ToString() + " ngày.";

            ucTienDo.Change(ttdaDAO.LayTienDo(MaDA));
        }
        public void addReLoat(FDuAn.FReload HamRL)
        {
            this.HamRL = HamRL;
        }

        private void UCXemDAChuaHT_Click(object sender, EventArgs e)
        {
            Control ctr = Parent.Parent.Parent.Parent;
            if (ctr is UC)
            {
                UC uc = (UC)ctr;
                FThongTinDA fThongTinDA = new FThongTinDA(MaDA);
                uc.AddChildForm(fThongTinDA);
                uc.OpenChildForm(fThongTinDA);
            }
        }
    }
}
