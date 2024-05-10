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
    public partial class FThongTinDA : Form
    {
        string maDA;
        string maPB;
        ThongTinDADAO ttDAdao;
        public FThongTinDA(string maDA)
        {
            InitializeComponent();
            this.maDA = maDA;
            ttDAdao = new ThongTinDADAO(maDA);
        }

        private void FThongTinDA_Load(object sender, EventArgs e)
        {
            DuAn da = ttDAdao.ThongTinDA();
            this.maPB = da.MaPhongBan;
            txtTenDa.Text = da.TenDA;
            lblDiaDiem.Text = da.DiaDiem;
            lblNgayBD.Text = da.NgayBD.ToShortDateString();
            lblThoiHan.Text = da.ThoiHan.ToShortDateString();
            txtMoTa.Text = da.MoTa;
            txtTenDa.Enabled = false;
            txtMoTa.Enabled = false;
            txtMoTa.ForeColor = System.Drawing.Color.Black;
            List<string> dsMaCVChuaHoanThanh = ttDAdao.DSMaCVChuaHoanThanh();
            foreach(string maCV in dsMaCVChuaHoanThanh)
            {
                UCXemPhanCong uc = new UCXemPhanCong();
                uc.Set(da.MaPhongBan, maDA, maCV);
                uc.Margin = new Padding(10,10,0,0);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void txtMoTa_MouseMove(object sender, MouseEventArgs e)
        {
            txtMoTa.SelectionLength = 0;
        }

        private void pbThem_Click(object sender, EventArgs e)
        {
            FPhanCong fPhanCong = new FPhanCong(maDA,maPB);
            Hide();
            fPhanCong.ShowDialog();
            Show();
        }
        private void pbThem_MouseEnter(object sender, EventArgs e)
        {
            pbThem.Size = new Size(pbThem.Size.Height + 10, pbThem.Size.Height + 10);
            pbThem.Location = new Point(pbThem.Location.X - 5, pbThem.Location.Y - 5);
        }

        private void pbThem_MouseLeave(object sender, EventArgs e)
        {
            pbThem.Size = new Size(pbThem.Size.Height - 10, pbThem.Size.Height - 10);
            pbThem.Location = new Point(pbThem.Location.X + 5, pbThem.Location.Y + 5);
        }
    }
}
