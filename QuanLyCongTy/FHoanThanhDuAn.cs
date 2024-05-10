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
    public partial class FHoanThanhDuAn : Form
    {
        HoanThanhDuAnBUS hoanThanhDuAnBUS = new HoanThanhDuAnBUS();

        public delegate void FReload();
        public FHoanThanhDuAn()
        {
            InitializeComponent();
            hoanThanhDuAnBUS.AddPnl(pnlNoiDung);
        }

        public void CapNhat(DuAnModel da)
        {
            hoanThanhDuAnBUS.da = da;
        }

        private void btnNhanXet_CheckedChanged(object sender, EventArgs e)
        {
            hoanThanhDuAnBUS.FillNhanXet();
        }

        private void btnThuong_CheckedChanged(object sender, EventArgs e)
        {
            hoanThanhDuAnBUS.FillChiaThuong();
        }

        private void FHoanThanhDuAn_Load(object sender, EventArgs e)
        {
            hoanThanhDuAnBUS.FillNhanXet();
        }
    }
}
