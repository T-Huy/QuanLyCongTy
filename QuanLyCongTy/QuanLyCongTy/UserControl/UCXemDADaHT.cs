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
    public partial class UCXemDADaHT : UserControl
    {
        TienDoDADAO ttdaDAO = new TienDoDADAO();
        DuAnDAO daDAO = new DuAnDAO();
        Reload.Flp HamRL;
        string MaDA;
        public UCXemDADaHT(String MaDA)
        {
            InitializeComponent();
            this.MaDA = MaDA;
        }
        public void addReLoat(Reload.Flp HamRL)
        {
            this.HamRL = HamRL;
        }

        private void UCXemDADaHT_Load(object sender, EventArgs e)
        {
            TienDoDA da = ttdaDAO.LayDanhSachDuAn(MaDA);
            lblTenDA.Text = da.TenDuAn;
            lblTenPhong.Text = da.TenPB;
            prgTienDo.Value = ttdaDAO.LayTienDo(MaDA);
            lblTienDo.Text = ttdaDAO.LayTienDo(MaDA).ToString() + "%";

            float t = float.Parse(daDAO.LayDiemDA(MaDA));
            RatingStar.Value = t / 20;
        }

        private void ptbBG_Click(object sender, EventArgs e)
        {
            Form form = new FHoanThanhDuAn(MaDA);
            Enabled = false;
            form.ShowDialog();
            Enabled = true;
            HamRL();
        }
    }
}

