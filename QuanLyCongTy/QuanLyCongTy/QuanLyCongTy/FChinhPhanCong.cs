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
    public partial class FChinhPhanCong : Form
    {
        PhanCongDAO PCdao;
        string maDA;
        string maCV;
        public FChinhPhanCong(string maDA, string maPB,string maCV)
        {
            InitializeComponent();
            PCdao = new PhanCongDAO(maPB);
            this.maDA = maDA;
            this.maCV = maCV;
        }

        private void ChinhPhanCong_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            cboNhanVien.DataSource = PCdao.LayDSTenNV();
            PhanCong pc = PCdao.ThongTinPC(maCV, maDA);
            cboNhanVien.Text = pc.HoTenNV;
            dtpDBLam.Value = pc.NgayBatDau;
            dtpDeadline.Value = pc.Deadline;
            
        }
        private void HienThiDanhSach()
        {
            this.gv_CongViec.DataSource = PCdao.LayDSTinhTrangNV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            PhanCong pc = new PhanCong(cboNhanVien.Text,
                                       maDA,
                                       maCV,
                                       "",
                                       dtpDBLam.Value,
                                       dtpDeadline.Value);
            PCdao.Sua(pc);
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
            PictureBox pb = new PictureBox();
        }

    }
}
