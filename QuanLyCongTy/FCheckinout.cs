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
    public partial class FCheckinout : Form
    {
        CheckIOBUS checkIOBUS = new CheckIOBUS();
        public FCheckinout()
        {
            InitializeComponent();
            
        }

        public void CapNhat(NhanVienModel nv)
        {
            checkIOBUS.nv = nv;
        }
        private void Checkin_Load(object sender, EventArgs e)
        {
            checkIOBUS.FillDataGrid(gvCheckIO);
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            checkIOBUS.CheckIN();
            checkIOBUS.FillDataGrid(gvCheckIO);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            checkIOBUS.CheckOUT();
            checkIOBUS.FillDataGrid(gvCheckIO);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString();
        }
    }
}
