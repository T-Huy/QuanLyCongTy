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
    public partial class FChiaThuong : Form
    {
        ChiaThuongBUS chiaThuongBUS = new ChiaThuongBUS();
        public FChiaThuong()
        {
            InitializeComponent();
        }

        public void CapNhat(DuAnModel da)
        {
            chiaThuongBUS.da = da;
        }

        private void FChiaThuong_Load(object sender, EventArgs e)
        {
            chiaThuongBUS.FillCaNhan(flpChiaThuong, lblTienThuong);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            chiaThuongBUS.XacNhan(flpChiaThuong);
            Form f = (Form)Parent.Parent;
            f.Close();
        }
    }
}
