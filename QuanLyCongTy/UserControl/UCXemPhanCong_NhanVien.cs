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
    public partial class UCXemPhanCong_NhanVien : UserControl
    {
        XemPCNVBUS xemPCNVBUS = new XemPCNVBUS();
        public UCXemPhanCong_NhanVien()
        {
            InitializeComponent();
        }
        public void CapNhat(PhanCongModel pc, Reload.Flp reLoadF)
        {
            xemPCNVBUS.pc = pc;
            xemPCNVBUS.reLoadF = reLoadF;
        }

        private void UCXemPhanCong_NhanVien_Load(object sender, EventArgs e)
        {
            xemPCNVBUS.FillControl(lblTenCV, lblNgayBD, lblNgayCl, prgTienDo, lblTienDo);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            xemPCNVBUS.OpenFCapNhatTienDo();
        }
    }
}
