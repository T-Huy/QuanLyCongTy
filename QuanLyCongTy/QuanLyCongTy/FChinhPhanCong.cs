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
        SuaPhanCongBUS suaPhanCongBUS = new SuaPhanCongBUS();
        public FChinhPhanCong(string maDA, string maPB,string maCV)
        {
            InitializeComponent();
            PCdao = new PhanCongDAO(maPB);
            this.maDA = maDA;
            this.maCV = maCV;
            suaPhanCongBUS.MaDA = maDA;
            suaPhanCongBUS.MaPB = maPB;
            suaPhanCongBUS.MaCV = maCV; 
        }

        private void ChinhPhanCong_Load(object sender, EventArgs e)
        {
            
            cboNhanVien.DataSource = PCdao.LayDSTenNV();
            PhanCong pc = PCdao.ThongTinPC(maCV, maDA);
            cboNhanVien.Text = pc.HoTenNV;
            dtpDBLam.Value = pc.NgayBatDau;
            dtpDeadline.Value = pc.Deadline;
            HienThiDanhSach();

        }
        private void HienThiDanhSach()
        {
            //this.gv_CongViec.DataSource = PCdao.LayDSTinhTrangNV();
            //suaPhanCongBUS.Fillgv(gv_CongViec, dtpDBLam, dtpDeadline);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            PhanCong pc = new PhanCong(cboNhanVien.Text,
                                       maDA,
                                       maCV,
                                       "",
                                       0,
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
