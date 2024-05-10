using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class HoanThanhDuAnBUS
    {
        Guna2Panel pnl;
        public DuAnModel da;
        Form currentFormChild;
        public void AddPnl(Guna2Panel pnl)
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
        
        public void FillChiaThuong()
        {
            FChiaThuong fchiathuong = new FChiaThuong();
            fchiathuong.CapNhat(da);
            OpenChildForm(fchiathuong);
        }

        public void FillNhanXet()
        {
            FNhanXetDA_TruongPhong fnhanxetDATP = new FNhanXetDA_TruongPhong();
            fnhanxetDATP.CapNhat(da);
            OpenChildForm(fnhanxetDATP);
        }
    }
}
