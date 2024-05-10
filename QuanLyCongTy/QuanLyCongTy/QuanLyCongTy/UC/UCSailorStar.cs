using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class UCSailorStar : UserControl
    {
        TienDoDADAO ttdaDAO = new TienDoDADAO();
        DuAnDAO daDAO = new DuAnDAO();
        FDuAn.FReload HamRL;
        string MaDA;
        public UCSailorStar(String MaDA)
        {
            InitializeComponent();
            this.MaDA = MaDA;
        }

        private void UCSailorStar_Load(object sender, EventArgs e)
        {
            TienDoDA da = ttdaDAO.LayDanhSachDuAn(MaDA);
            lbl_tenDA.Text = da.TenDuAn;
            lbl_TenPhong.Text = da.TenPB;
            
            int t = int.Parse(daDAO.LayDiemDA(MaDA));
            int s = 100 - t;
            flpNgoiSao.Padding = new Padding(10,0,0,0);

            while (t > 0)
            {
                PictureBox pb = new PictureBox();
                pb.Image = Properties.Resources.SaoVang;
                pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pb.Size = new Size(20, 20);
                flpNgoiSao.Controls.Add(pb);
                t = t - 20;
            }
            
            while (s > 0)
            {
                PictureBox pb = new PictureBox();
                pb.Image = Properties.Resources.VienSaoVang;
                pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pb.Size = new Size(20, 20);
                flpNgoiSao.Controls.Add(pb);
                s = s - 20;
            }
        }
        public void addReLoat(FDuAn.FReload HamRL)
        {
            this.HamRL = HamRL;
        }

        private void UCSailorStar_Click(object sender, EventArgs e)
        {
            Form form = new FNhanXet(MaDA);
            Enabled = false;
            form.ShowDialog();
            Enabled = true;
            HamRL();
        }
    }
}
