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
        NhanXetDATPBUS nhanXetDATPBUS = new NhanXetDATPBUS();
        public FNhanXetDA_TruongPhong()
        {
            InitializeComponent();
        }

        public void CapNhat(DuAnModel da)
        {
            nhanXetDATPBUS.da = da;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FNhanXetDA_TruongPhong_Load(object sender, EventArgs e)
        {
            nhanXetDATPBUS.FillControls(lblTenDA, txtNhanXet, RatingStar, lblXepLoai, lblTienThuong);
        }
    }
}
