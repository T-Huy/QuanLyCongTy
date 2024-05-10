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
    public partial class FNhanXetDA_TruongPhong : Form
    {
        NhanXetDADAO nxdaDAO = new NhanXetDADAO();
        string MaDA;
        float Diem;
        public FNhanXetDA_TruongPhong(string MaDA)
        {
            InitializeComponent();
            this.MaDA = MaDA;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FNhanXetDA_TruongPhong_Load(object sender, EventArgs e)
        {
            nxdaDAO.LayThongTinDA(MaDA);
            NhanXetDA nx = nxdaDAO.LayThongTinDA(MaDA);
            LayXepLoai(nx.ChamDiem);
            lblTenDA.Text = nx.TenDA;
            txtNhanXet.Text = nx.DanhGia;
            RatingStar.Value = nx.ChamDiem / 20;
        }
        private void LayXepLoai(float diem)
        {
            lblXepLoai.Text = nxdaDAO.LayChamDiem(diem);
        }
    }
}
