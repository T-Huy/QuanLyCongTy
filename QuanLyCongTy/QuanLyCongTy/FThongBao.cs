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
    public partial class FThongBao : Form
    {
        XinNghiModel xn;
        DuAnModel da;
        DuAnDAO duAnDAO = new DuAnDAO();
        public FThongBao()
        {
            InitializeComponent();
        }

        public void CapNhat(DuAnModel da)
        {
            this.da = da;
        }

        public void CapNhat(XinNghiModel xn)
        {
            this.xn = xn;
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            duAnDAO.Xoa(da);
            Close();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
