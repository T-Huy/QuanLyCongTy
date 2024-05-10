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
    public partial class FKPI : Form
    {
        KPIBUS kPIBUS = new KPIBUS();
        public FKPI()
        {
            InitializeComponent();

        }
        public void CapNhat(NhanVienModel nv)
        {
            kPIBUS.nv = nv;
            kPIBUS.AddFlp(flpListPC);
        }
        private void btnDaHT_CheckedChanged(object sender, EventArgs e)
        {
            kPIBUS.FillFlpDaHT();
        }

        private void btnChuaHT_CheckedChanged(object sender, EventArgs e)
        {
            kPIBUS.FillflpChuaHT();
        }

        private void FKPI_Load(object sender, EventArgs e)
        {
            kPIBUS.FillflpChuaHT();
        }
    }
}
