using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCTy
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            txt_Khac.Enabled = false;
        }


        private void cb_Lydo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_Lydo.SelectedItem == "Khác")
            {
                txt_Khac.Enabled = true;
            }
        }

        private void picBox_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog odf = new OpenFileDialog();
            if (odf.ShowDialog() == DialogResult.OK)
            {
                picBox_Image.Image = Image.FromFile(odf.FileName);
                this.Text = odf.FileName;
            }
        }
    }
}
