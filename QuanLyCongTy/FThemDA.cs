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
    public partial class FThemDA : Form
    {
        ThemDABUS themDABUS = new ThemDABUS();
        public FThemDA()
        {
            InitializeComponent();
            themDABUS.FillcmbLoaiPB(cmbLoaiPB);
        }

        private void HienThiDanhSach()
        {
            themDABUS.DSTinhTrangPBTheoLPB(gvPhongBanRanh, cmbLoaiPB, dtpNgayBD, dtpDeadline);
        }

        private void FThemDA_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            themDABUS.TaoMaDA(lblMaDA);
        }

        private void cmbLoaiPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            themDABUS.FillcmbTenPB(cmbTenPB, cmbLoaiPB, dtpNgayBD, dtpDeadline);
            HienThiDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themDABUS.ThemDA(lblMaDA, txtTenDA, txtMoTa, cmbTenPB, txtDiaDiem, dtpNgayBD, dtpDeadline);
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            themDABUS.FillcmbTenPB(cmbTenPB, cmbLoaiPB, dtpNgayBD, dtpDeadline);
            HienThiDanhSach();
        }

        private void dtpDeadline_ValueChanged(object sender, EventArgs e)
        {
            themDABUS.FillcmbTenPB(cmbTenPB, cmbLoaiPB, dtpNgayBD, dtpDeadline);
            HienThiDanhSach();
        }
    }
}
