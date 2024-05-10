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
    public partial class UC : UserControl
    {
        FThongTin fthongtin;
        Form currentFormChild;
        readonly NhanVienDAO nvDao = new NhanVienDAO();
        public void Setma(string ma)
        {
            lblName.Text = nvDao.GetTenNV(ma);
            fthongtin = new FThongTin(ma);
            AddChildForm(fthongtin);
        }
        public UC()
        {
            InitializeComponent();
        }
        public void ChangeTiltle(Color backcolor,string tiltle)
        {
            pnlTitle.BackColor = backcolor;
            lblTitle.Text = tiltle;
        }
        public void OffColor()
        {
            foreach (Control ctrl in Parent.Controls)
            {
                if (ctrl is ucMenuBtn)
                {
                    ucMenuBtn btns = (ucMenuBtn)ctrl;
                    btns.BackColor = ColorTranslator.FromHtml("#33334C");
                }
            }
        }
        public void AddChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlNoiDung.Controls.Add(childForm);
            pnlNoiDung.Tag = childForm;
        }
        public void OpenChildForm(Form childForm)
        {
            
            if (currentFormChild != null)
            {
                currentFormChild.Hide();
            }
            currentFormChild = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void panelName_Click(object sender, EventArgs e)
        {
            if(fthongtin != null)
                OpenChildForm(fthongtin);
            OffColor();
            ChangeTiltle(ColorTranslator.FromHtml("#33334C"), "Thông Tin");
        }
    }
}
