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
    public partial class FThemDA : Form
    {

        SuaDADAO suadaDAO = new SuaDADAO();
        string MaPB;
        string MaLPB;
        public FThemDA()
        {
            InitializeComponent();
            cmb_TenLPB.DataSource = suadaDAO.LayDanhSachTenLoaiPhongBan();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemDA da = new ThemDA(txt_MaDA.Text, txt_TenDA.Text, rtxt_MoTa.Text, cmb_TenLPB.Text, cmb_TenPB.Text, txtDiaDiem.Text, dtp_NgayBD.Value, dtp_DeadLine.Value);
            MaPB = suadaDAO.GetMaPB(cmb_TenPB.Text);
            suadaDAO.Them(da, MaPB);
            Close();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmb_TenLPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaLPB = suadaDAO.GetMaLPB2(cmb_TenLPB.Text);
            cmb_TenPB.DataSource = suadaDAO.LayDanhSachTenPhongBan(MaLPB);
        }
    }
}
