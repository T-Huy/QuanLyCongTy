using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class FSuaDA : Form
    {
        SuaDABUS suaDABUS = new SuaDABUS();
        public FSuaDA()
        {
            InitializeComponent();
        }
        public void CapNhat(DuAnModel da)
        {
            suaDABUS.da = da;
        }

        private void FSuaDA_Load(object sender, EventArgs e)
        {
            suaDABUS.FillControl(txtTenDA, txtMoTa, cmbTenPB, txtDiaDiem, dtpNgayBD, dtpDeadline);
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            suaDABUS.DSTinhTrangPBTheoLPB(gvPhongBanRanh, cmbTenPB, dtpNgayBD, dtpDeadline);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suaDABUS.SuaDA(txtTenDA, txtMoTa, cmbTenPB, txtDiaDiem, dtpNgayBD, dtpNgayBD);
            Close();
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            suaDABUS.FillcmbTenPB(cmbTenPB,dtpNgayBD, dtpDeadline);
        }

        private void dtpDeadline_ValueChanged(object sender, EventArgs e)
        {
            suaDABUS.FillcmbTenPB(cmbTenPB, dtpNgayBD, dtpDeadline);
        }
    }
}
