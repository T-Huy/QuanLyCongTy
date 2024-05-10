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
    public partial class Add : Form
    {
        ThemXNBUS themXNBUS = new ThemXNBUS();
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            txt_Khac.Enabled = false;
        }


        private void cb_Lydo_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (cb_LyDo.SelectedItem == "Khác")
            {
                txt_Khac.Enabled = true;
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            themXNBUS.ThemXN(txt_MaNV, txt_HovaTen, guna2DateTimePicker1, txt_SoNgayNghi, cb_LyDo, -1);
            Close();
        }
    }
}
