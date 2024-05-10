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
    public partial class FLich : Form
    {
        DateTime datecal;
        public FLich()
        {
            InitializeComponent();
        }

        private void Hienlich()
        {
            DateTime ngaydau = datecal;
            int songay = DateTime.DaysInMonth(datecal.Year, datecal.Month);
            int ngaytrongtuan = Convert.ToInt32(ngaydau.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < ngaytrongtuan; i++)
            {
                UCBlank ucblank = new UCBlank();
                fpnlDays.Controls.Add(ucblank);
            }

            for (int i = 1; i <= songay; i++)
            {
                UCNgay ucngay = new UCNgay();
                ucngay.songay(i);
                ucngay.kiemtraDL(datecal.Year, datecal.Month, i);
                ucngay.kiemtraBD(datecal.Year, datecal.Month, i);
                fpnlDays.Controls.Add(ucngay);
            }
        }

        private void FLich2_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            datecal = new DateTime(now.Year, now.Month, 1);
            lblThang.Text = "Tháng " + datecal.Month.ToString() + " Năm " + datecal.Year.ToString();
            Hienlich();
        }

        private void btnPast_Click(object sender, EventArgs e)
        {
            fpnlDays.Controls.Clear();
            datecal = datecal.AddMonths(-1);
            lblThang.Text = "Tháng " + datecal.Month.ToString() + " Năm " + datecal.Year.ToString();
            Hienlich();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            fpnlDays.Controls.Clear();
            datecal = datecal.AddMonths(1);
            lblThang.Text = "Tháng " + datecal.Month.ToString() + " Năm " + datecal.Year.ToString();
            Hienlich();
        }
    }
}
