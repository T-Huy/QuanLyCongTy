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
        Reload.Flp HamRL;
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
            prgTienDo.Value = ttdaDAO.LayTienDo(MaDA);
            lblTienDo.Text = ttdaDAO.LayTienDo(MaDA).ToString() + "%";
        }

        public void addReLoat(Reload.Flp HamRL)
        {
            this.HamRL = HamRL;
        }

        private void ptbBG_Click(object sender, EventArgs e)
        {
            Form form = new FThongTinDA(MaDA);
            Enabled = false;
            form.ShowDialog();
            Enabled = true;
            HamRL();
        }
    }
}
