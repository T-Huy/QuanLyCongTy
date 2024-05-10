using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyCongTy.FXemDuAn;

namespace QuanLyCongTy
{
    public partial class FThemTroGiup : Form
    {

        ThemHoTroBUS themTroGiupBUS = new ThemHoTroBUS();
        public FThemTroGiup()
        {
            InitializeComponent();
        }
        public void CapNhat(PhanCongModel pc,Reload.Flp reLoadF)
        {
            themTroGiupBUS.pc = pc;
            themTroGiupBUS.reLoadF = reLoadF;

        }
        private void HienThiDanhSach()
        {
            themTroGiupBUS.Fillgv(gvPhongBanRanh);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FThemTroGiup_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void gv_CongViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            themTroGiupBUS.AddListBox(gvPhongBanRanh, listBox1);

        }
        private void btnThemTroGiup_Click(object sender, EventArgs e)
        {
            themTroGiupBUS.ThemHoTro(listBox1);
            Close();
        }
    }
}
