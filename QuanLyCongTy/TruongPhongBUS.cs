using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class TruongPhongBUS
    {
        public NhanVienModel nv;
        Form currentFormChild;
        PhongBanDAO pbDAO = new PhongBanDAO();
        Panel pnl;

        private void moveImageBox(PictureBox imgSlide, Guna2Button b)
        {
            imgSlide.Location = new Point(b.Location.X + 166, b.Location.Y - 30);
            imgSlide.BringToFront();
        }
        public void AddPnl(Panel pnl)
        {
            this.pnl = pnl;
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
            pnl.Controls.Add(childForm);
            pnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void OpenFCheckIO(PictureBox imgSlide, Guna2Button b)
        {
            FCheckinout fcheckIO = new FCheckinout();
            fcheckIO.CapNhat(nv);
            OpenChildForm(fcheckIO);
            moveImageBox(imgSlide, b);
        }

        public void OpenFXemDuAn(PictureBox imgSlide, Guna2Button b)
        {
            FXemDuAn fXemDuAn = new FXemDuAn();
            PhongBanModel pb = pbDAO.GetPhongBanTheoMaPB(nv.MaPB);
            fXemDuAn.CapNhat(pb);
            OpenChildForm(fXemDuAn);
            moveImageBox(imgSlide, b);
        }

        public void OpenFThongTin(PictureBox imgSlide, Guna2Button b)
        {
            
            OpenChildForm(new FThongTin(nv.MaNV));
            moveImageBox(imgSlide, b);
        }
        public void OpenFXinNghi(PictureBox imgSlide, Guna2Button b, string MaNV)
        {

            OpenChildForm(new FXinNghi(MaNV));
            moveImageBox(imgSlide,b);
        }
        public void OpenFLich(PictureBox imgSlide, Guna2Button b)
        {

            OpenChildForm(new FLich());
            moveImageBox(imgSlide, b);
        }
        public void Load(Label lblTen)
        {
            lblTen.Text = nv.HoTenNV;
            OpenChildForm(new FThongTin(nv.MaNV));
        }
    }
}
