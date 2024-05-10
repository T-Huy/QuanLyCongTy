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
    public partial class FHoanThanhDuAn : Form
    {
        string MaDA;
        Form currentFormChild;
        public FHoanThanhDuAn(string maDA)
        {
            InitializeComponent();
            MaDA = maDA;
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlNoiDung.Controls.Add(childForm);
            pnlNoiDung.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnNhanXet_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new FNhanXetDA_TruongPhong(MaDA));
        }

        private void btnThuong_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new FChiaThuong(MaDA));
        }

        private void FHoanThanhDuAn_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FNhanXetDA_TruongPhong(MaDA));
        }
    }
}
