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
    public partial class UCThuongCaNhan : UserControl
    {
        ThuongCaNhanBUS thuongCaNhanBUS = new ThuongCaNhanBUS();
        public UCThuongCaNhan()
        {
            InitializeComponent();
        }

        public void CapNhat(PhanCongModel pc)
        {
            thuongCaNhanBUS.pc = pc;
        }

        public void Luu()
        {
            thuongCaNhanBUS.XacNhan(txtThuong, RatingStar);
        }

        private void UCThuongCaNhan_Load(object sender, EventArgs e)
        {
            thuongCaNhanBUS.FillControls(lblTenNV, lblPhanCong, txtThuong, RatingStar);
        }
    }
}
