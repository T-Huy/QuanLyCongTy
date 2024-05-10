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
    public partial class FNhanXetDA : Form
    {
        NhanXetDABUS nhanXetDABUS = new NhanXetDABUS();

        public FNhanXetDA()
        {
            InitializeComponent();
        }
        public void CapNhat(DuAnModel da)
        {
            nhanXetDABUS.da = da;
        }
        
        private void FNhanXet_Load(object sender, EventArgs e)
        {
            nhanXetDABUS.FillControl(lblTenDA, txtNhanXet, lblXepLoai, ratingStar, txtThuong );
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            nhanXetDABUS.LuuNhanXet(txtNhanXet, ratingStar,txtThuong);
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RatingStar_ValueChanged(object sender, EventArgs e)
        {
            nhanXetDABUS.XepLoai(lblXepLoai,ratingStar);
        }
    }
}
