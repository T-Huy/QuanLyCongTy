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
    public partial class FTienDoCaNhan : Form
    {
        TDCaNhanDAO ttcnDAO = new TDCaNhanDAO();
        string MaNV;
        public FTienDoCaNhan(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        private void btn_ThemDG_Click(object sender, EventArgs e)
        {
            TDCaNhan td = ttcnDAO.LayDanhSachTienDo(MaNV);
            ttcnDAO.Sua(MaNV, td.MaDA, txt_Diem.Text);
            MessageBox.Show("Thanh cong");
        }

        private void TienDoCaNhan_Load(object sender, EventArgs e)
        {
            TDCaNhan td = ttcnDAO.LayDanhSachTienDo(MaNV);
          
            lbl_TenNV.Text = td.TenNV;
            lbl_TenCV.Text = td.CongViec;
            lbl_TGBD.Text = td.NgayBD.ToString("dd/MM/yyyy");
            lbl_TGKT.Text = td.DeadLine.ToString("dd/MM/yyyy");

            pgb_TienDo.Minimum = 0;
            pgb_TienDo.Maximum = 100;
            pgb_TienDo.Value = int.Parse(td.TienDo.ToString());
        }
    }
}
