using Guna.UI2.WinForms;
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
    partial class FCapNhatTienDo : Form
    {
        CapNhatTienDoBUS capNhatTienDoBUS = new CapNhatTienDoBUS();
        public FCapNhatTienDo()
        {
            InitializeComponent();
        }
        public void CapNhat(PhanCongModel pc, Reload.Flp reLoadF)
        {
            capNhatTienDoBUS.pc = pc;
            capNhatTienDoBUS.reLoadF = reLoadF;
        }

        private void FCapNhatTienDo_Load(object sender, EventArgs e)
        {
            capNhatTienDoBUS.FillControl(label1, label4, guna2HScrollBar1, label2);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            capNhatTienDoBUS.CapNhatPC();
            Close();
        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            capNhatTienDoBUS.UpdateLbl(guna2HScrollBar1, label2);
        }
    }
}
