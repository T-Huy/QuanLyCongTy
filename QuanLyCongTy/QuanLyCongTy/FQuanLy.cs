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
    public partial class FQuanLy : Form
    {
        Form currentFormChild;
        readonly NhanVienDAO nvDao = new NhanVienDAO();
        string MaNV;
        public FQuanLy(string ma)
        {
            InitializeComponent();
            this.MaNV = ma;
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 166, b.Location.Y - 30);
            imgSlide.BringToFront();
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

        private void FQuanLy2_Load(object sender, EventArgs e)
        {
            lblName.Text = nvDao.GetTenNV(MaNV);
            lblTitle.Text = "Thông tin cá nhân";
            OpenChildForm(new FThongTin(MaNV));
        }

        private void btnCaNhan_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            OpenChildForm(new FThongTin(MaNV));
            moveImageBox(sender);
        }

        private void btnCheckin_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnCheckin.Text;
            OpenChildForm(new FCheckinout(MaNV));
            moveImageBox(sender);
        }

        private void btnDuAn_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnDuAn.Text;
            OpenChildForm(new FDuAn());
            moveImageBox(sender);
        }

        private void btnXinNghi_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnXinNghi.Text;
            OpenChildForm(new FXinNghi());
            moveImageBox(sender);
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
