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
    public partial class FPhanCong : Form
    {
        ThemPhanCongBUS themPhanCongBUS = new ThemPhanCongBUS();
        public FPhanCong()
        {
            InitializeComponent();
        }
        public void CapNhat(DuAnModel da,Reload.Flp reLoadF)
        {
            themPhanCongBUS.da = da;
            themPhanCongBUS.reLoadF = reLoadF;
        }

        private void PhanCong_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            themPhanCongBUS.FillcboNV(cmbNhanVien, dtpDBLam, dtpDeadline);
            themPhanCongBUS.FillcboCV(cmbCongViec);
        }
        private void HienThiDanhSach()
        {
            themPhanCongBUS.Fillgv(gvPhongBanRanh, dtpDBLam, dtpDeadline);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            themPhanCongBUS.ThemPC(cmbNhanVien, cmbCongViec, txtPhanCong,txtMoTa, ckbKhac, dtpDBLam, dtpDeadline);
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpDBLam_ValueChanged(object sender, EventArgs e)
        {
            PhanCong_Load(sender, e);
        }

        private void dtpDeadline_ValueChanged(object sender, EventArgs e)
        {
            PhanCong_Load(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKhac.Checked)
            {
                txtPhanCong.Enabled = true;
            }
            else
            {
                txtPhanCong.Enabled = false;
            }
        }
    }
}
