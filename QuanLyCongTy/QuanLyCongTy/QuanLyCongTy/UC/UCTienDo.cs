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
    public partial class UCTienDo : UserControl
    {
        public UCTienDo()
        {
            InitializeComponent();
        }
        public void Change(int num)
        {
            if (num == 100)
                pictureBox3.Show();
            else
                pictureBox3.Hide();
            pictureBox2.Size = new Size((int)(num*3),16);
            lblTienDo.Text = num.ToString()+"%";
        }
    }
}
