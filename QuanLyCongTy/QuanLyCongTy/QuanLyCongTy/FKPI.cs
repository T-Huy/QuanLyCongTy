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
        DuAnDAO DAdao = new DuAnDAO();
        PhanCongDAO PCdao = new PhanCongDAO("");
        public FKPI()
        {
            InitializeComponent();
        }

        private void FKPI_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            cbo_DuAn.DataSource = PCdao.LayDSTenNV();
        }
        private void HienThiDanhSach()
        {
            this.gv_PhanCong.DataSource = PCdao.LayDSTenNV();
        }
    }
}
