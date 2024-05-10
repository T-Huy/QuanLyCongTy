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

namespace QLCTy
{
    public partial class F_XinNghi : Form
    {

        public F_XinNghi()
        {
            InitializeComponent();
        }



        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minisize_Click(object sender, EventArgs e)
        {
            
            this.WindowState= FormWindowState.Minimized;
        }

        private void btn_Maxnimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form f = new Add();
            f.Show();
        }
    }
}
