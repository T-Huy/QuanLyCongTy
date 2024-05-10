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
    public partial class UCXemDADaHT : UserControl
    {
        XemDADaHTTPBUS xemDADaHTTPBUS = new XemDADaHTTPBUS();
        public UCXemDADaHT()
        {
            InitializeComponent();
        }

        public void CapNhat(DuAnModel da)
        {
            xemDADaHTTPBUS.da = da;
        }

        private void UCXemDADaHT_Load(object sender, EventArgs e)
        {
            xemDADaHTTPBUS.FillControl(lblTenDA, lblTenPhong, prgTienDo, ratingStar, lblTienDo);
        }

        private void ptbBG_Click(object sender, EventArgs e)
        {
            xemDADaHTTPBUS.OpenFNhanXet();
        }
    }
}

