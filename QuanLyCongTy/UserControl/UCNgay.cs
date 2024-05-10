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
    public partial class UCNgay : UserControl
    {
        LichDAO lichDAO = new LichDAO();
        public UCNgay()
        {
            InitializeComponent();
        }
        public void songay(int ngay)
        {
            lblDay.Text = ngay + " ";
        }

        public void kiemtraDL(int year, int month, int day)
        {
            DateTime datecheck = new DateTime(year, month, day);
            LichDA lda = lichDAO.KiemtraDL(datecheck);

            if (lda != null)
            {
                pnlNotice.FillColor = ColorTranslator.FromHtml("#F44336");
                lblDay.ForeColor = ColorTranslator.FromHtml("#F44336");
                lblNotice.Text = "Deadline dự án";
                lblNotice.ForeColor = ColorTranslator.FromHtml("#F44336");
            }
        }
        public void kiemtraBD(int year, int month, int day)
        {
            DateTime datecheck = new DateTime(year, month, day);
            LichDA lda = lichDAO.KiemtraBD(datecheck);

            if (lda != null)
            {
                pnlNotice.FillColor = ColorTranslator.FromHtml("#128C7E");
                lblDay.ForeColor = ColorTranslator.FromHtml("#128C7E");
                lblNotice.Text = "Có dự án";
                lblNotice.ForeColor = ColorTranslator.FromHtml("#128C7E");
            }
        }
    }
}
