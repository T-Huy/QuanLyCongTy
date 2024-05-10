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
    public partial class FXemDuAn : Form
    {
        XemDADAO xemdaDAO = new XemDADAO();
        string maPB;
        public FXemDuAn(string maPB)
        {
            InitializeComponent();
            this.maPB = maPB;
            
        }
        private void FXemDuAn_Load(object sender, EventArgs e)
        {
            DataTable dt = xemdaDAO.LayDanhSachDuAnChuaHT(maPB);
            foreach (DataRow dr in dt.Rows)
            {
                UCXemDAChuaHT uc = new UCXemDAChuaHT(dr[0].ToString());
                flp_ListDA.Controls.Add(uc);
            }
        }

        public delegate void FReload();

        private void DAChuaHT()
        {
            flp_ListDA.Controls.Clear();
            DataTable dt = xemdaDAO.LayDanhSachDuAnChuaHT(maPB);
            foreach (DataRow dr in dt.Rows)
            {
                UCXemDAChuaHT uc = new UCXemDAChuaHT(dr[0].ToString());
                flp_ListDA.Controls.Add(uc);
                uc.addReLoat(DAChuaHT);
            }
        }
        private void DADaHT()
        {
            flp_ListDA.Controls.Clear();
            DataTable dt = xemdaDAO.LayDanhSachDuAnDaHT(maPB);
            foreach (DataRow dr in dt.Rows)
            {
                UCSailorStar uc = new UCSailorStar(dr[0].ToString());
                flp_ListDA.Controls.Add(uc);
                uc.addReLoat(DADaHT);
            }
        }

        private void btnChuaHT_Click(object sender, EventArgs e)
        {
            DAChuaHT();
        }

        private void btnDaHT_Click(object sender, EventArgs e)
        {
            DADaHT();
        }
    }
}

