using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyCongTy.FXemDuAn;

namespace QuanLyCongTy
{
    public partial class FXoaPC : Form
    {
        PhanCongDAO phanCongDAO = new PhanCongDAO();
        Reload.Flp reLoadF;
        PhanCongModel pc;
        public FXoaPC()
        {
            InitializeComponent();
        }

        public void CapNhat(PhanCongModel pc,Reload.Flp reLoadF)
        {
            this.pc = pc;
            this.reLoadF = reLoadF;
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            phanCongDAO.Xoa(pc);
            reLoadF();
            Close();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
