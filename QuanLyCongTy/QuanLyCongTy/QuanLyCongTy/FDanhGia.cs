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
    public partial class FDanhGia : Form
    {
        DanhGiaDAO DGdao = new DanhGiaDAO();
        public FDanhGia()
        {
            InitializeComponent();
        }

        private void DanhGia_Load(object sender, EventArgs e)
        {
            gv_PhanCong.DataSource = DGdao.LayDanhSachDanhGia();
        }
        private void HienThiDanhSach()
        {
            this.gv_PhanCong.DataSource = DGdao.LayDanhSachDanhGia();
        }

        

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DanhGia dg = new DanhGia(txt_MaNV.Text, txt_MaDA.Text, rtxt_NhanXet.Text, txt_ChamCong.Text);
            DGdao.Sua(dg);
            HienThiDanhSach();
        }

        private void gv_PhanCong_MouseClick(object sender, MouseEventArgs e)
        {
            int i = gv_PhanCong.CurrentRow.Index;
            txt_MaNV.Text = gv_PhanCong.Rows[i].Cells[0].Value.ToString();
            txt_MaDA.Text = gv_PhanCong.Rows[i].Cells[1].Value.ToString();
            rtxt_NhanXet.Text = gv_PhanCong.Rows[i].Cells[4].Value.ToString();
            txt_ChamCong.Text = gv_PhanCong.Rows[i].Cells[5].Value.ToString();
        }
    }
}
