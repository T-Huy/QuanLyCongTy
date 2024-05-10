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
        DateTime nbd, nkt;
        public FPhanCong(DateTime nbd, DateTime nkt)
        {
            InitializeComponent();
            this.nbd = nbd;
            this.nkt = nkt;
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
            dtpDBLam.Text= nbd.ToString();
            dtpDeadline.Text = nkt.ToString();
            
        }
        private void HienThiDanhSach()
        {
            themPhanCongBUS.Fillgv(gvPhongBanRanh, dtpDBLam, dtpDeadline);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (dtpDBLam.Value <= dtpDeadline.Value && dtpDBLam.Value <= nkt && dtpDBLam.Value >= nbd && dtpDeadline.Value <= nkt && dtpDeadline.Value > nbd )
            {
                themPhanCongBUS.ThemPC(cmbNhanVien, cmbCongViec, txtPhanCong, txtMoTa, ckbKhac, dtpDBLam, dtpDeadline);
                Close();
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc không hợp lẹ");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpDBLam_ValueChanged(object sender, EventArgs e)
        {
            /*PhanCong_Load(sender, e);*/
        }

        private void dtpDeadline_ValueChanged(object sender, EventArgs e)
        {
            /*PhanCong_Load(sender, e);*/
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
