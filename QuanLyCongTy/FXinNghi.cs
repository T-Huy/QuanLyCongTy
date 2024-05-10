using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class FXinNghi : Form
    {
        XemXinNghiQLBUS xemXinNghiQLBUS = new XemXinNghiQLBUS();
        public delegate void FReload();
        private string MaNV;

        public FXinNghi(string maNV)
        {
            InitializeComponent();
            this.MaNV = maNV;
        }

        public void CapNhat(XinNghiModel xn)
        {
            xemXinNghiQLBUS.AddFlpXN(flp_ListXN);
            xemXinNghiQLBUS.AddMaNV(MaNV);
            xemXinNghiQLBUS.FillXinNghi();
            flp_ListXN.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add f = new Add(MaNV);
            f.Show();
        }

        private void FXinNghi_Load(object sender, EventArgs e)
        {
            xemXinNghiQLBUS.AddFlpXN(flp_ListXN);
            xemXinNghiQLBUS.AddMaNV(MaNV);
            xemXinNghiQLBUS.FillXinNghi();
            flp_ListXN.Show();
        }

    }
}
