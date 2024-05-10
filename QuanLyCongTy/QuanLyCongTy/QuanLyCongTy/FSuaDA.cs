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
    public partial class FSuaDA : Form
    {
        SuaDADAO suadaDAO = new SuaDADAO();
        string MaDA;
        string MaPB;
        string MaLPB;
        public FSuaDA(string maDA)
        {
            InitializeComponent();
            MaDA = maDA;
        }

        private void FSuaDA_Load(object sender, EventArgs e)
        {
            SuaDA da = suadaDAO.LayThongTinDA(MaDA);
            cmb_TenPB.DataSource = suadaDAO.LayDanhSachTenPhongBan(MaLPB);

            txt_MaDA.Text = da.MaDA;
            txt_TenDA.Text = da.TenDA;
            rtxt_MoTa.Text = da.MoTa;
            cmb_TenPB.Text = da.TenPb;
            txtDiaDiem.Text = da.DiaDiem;
            dtp_NgayBD.Text = da.NgayBD.ToString();
            dtp_DeadLine.Text = da.DeadLine.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SuaDA da = new SuaDA(txt_MaDA.Text, txt_TenDA.Text, rtxt_MoTa.Text, cmb_TenPB.Text,txtDiaDiem.Text, dtp_NgayBD.Value, dtp_DeadLine.Value);
            suadaDAO.Sua(da, MaPB);
            Close();
        }

        private void cmb_TenPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaPB = suadaDAO.GetMaPB(cmb_TenPB.Text);
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
