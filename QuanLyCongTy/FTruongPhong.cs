using Guna.UI2.WinForms;
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
    public partial class FTruongPhong : Form
    {
        //FThongTin fthongtin;

        NhanVienDAO nvDao = new NhanVienDAO();
        TruongPhongBUS truongPhongBUS = new TruongPhongBUS();
        private string MaNV;
        public FTruongPhong(string ma)
        {
            InitializeComponent();
            truongPhongBUS.AddPnl(pnlNoiDung);
            this.MaNV = ma;
            truongPhongBUS.nv = nvDao.GetNhanVienTheoMaNV(ma);
        }

        public void CapNhat(NhanVienModel nv)
        {
            truongPhongBUS.nv = nv;
        }

        private void FTruongPhong2_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            truongPhongBUS.Load(lblName);
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCaNhan_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            truongPhongBUS.OpenFThongTin(imgSlide,btnCaNhan);
        } 

        private void btnCheckinout_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnCheckinout.Text;
            truongPhongBUS.OpenFCheckIO(imgSlide, btnCheckinout);
        }

        private void btnDuAn_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnDuAn.Text;
            truongPhongBUS.OpenFXemDuAn(imgSlide, btnDuAn);
        }

        private void btnXinNghi_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnXinNghi.Text;
            truongPhongBUS.OpenFXinNghi(imgSlide, btnXinNghi,MaNV);
        }

        private void btnLich_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnLich.Text;
            truongPhongBUS.OpenFLich(imgSlide, btnLich);
        }
    }
}
