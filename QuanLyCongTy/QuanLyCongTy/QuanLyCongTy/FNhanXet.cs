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
    public partial class FNhanXet : Form
    {
        NhanXetDADAO nxdaDAO = new NhanXetDADAO();
        string MaDA;
        int Diem;

        public FNhanXet(string MaDA)
        {
            InitializeComponent();
            this.MaDA = MaDA;
        }

        private void btnNhanXet_Click(object sender, EventArgs e)
        {
            NhanXetDA nx = new NhanXetDA(MaDA, lblTenDA.Text, txt_NhanXet.Text, Diem);
            nxdaDAO.Sua(nx);
            Close();
        }
        private void FNhanXet_Load(object sender, EventArgs e)
        {
            nxdaDAO.LayThongTinDA(MaDA);
            NhanXetDA nx = nxdaDAO.LayThongTinDA(MaDA);

            lblTenDA.Text = nx.TenDA;
            txt_NhanXet.Text = nx.DanhGia;
            lbl_ChamDiem.Text = nxdaDAO.LayChamDiem(nx.ChamDiem);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptbSao1_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Tệ";
            Diem = 20;
        }

        private void ptbSao2_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Chưa tốt";
            Diem = 40;
        }

        private void ptbSao3_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Tốt";
            Diem = 60;
        }

        private void ptbSao4_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Rất tốt";
            Diem = 80;
        }

        private void ptbSao5_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Xuất sắc";
            Diem = 100;
        }
    }
}
