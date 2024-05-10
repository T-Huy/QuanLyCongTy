using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class NhanXetDABUS
    {
        DuAnDAO duAnDAO = new DuAnDAO();
        public DuAnModel da;
        string[] ListXepLoai = { "", "Tệ", "Tệ", "Chưa tốt", "Chưa tốt", 
            "Tốt", "Tốt", "Rất tốt","Rất tốt", "Xuất sắc", "Xuất sắc" };

        public void FillControl(Label lbl_TenDA, Guna2TextBox txt_NhanXet, Label lblXepLoai, Guna2RatingStar ratingStar, Guna2TextBox txtThuong)
        {
            lbl_TenDA.Text = da.TenDuAn;
            txt_NhanXet.Text = da.DanhGia;
            ratingStar.Value = (float)da.ChamDiem / 20;
            XepLoai(lblXepLoai,ratingStar);
            txtThuong.Text = da.Thuong.ToString();
        }
        public void LuuNhanXet(Guna2TextBox txt_NhanXet, Guna2RatingStar ratingStar, Guna2TextBox txtThuong)
        {
            da.DanhGia = txt_NhanXet.Text;
            da.ChamDiem = (int)(ratingStar.Value * 20);
            da.Thuong = int.Parse(txtThuong.Text);
            duAnDAO.Sua(da);
        }
        public void XepLoai(Label lblXepLoai, Guna2RatingStar ratingStar)
        {
            lblXepLoai.Text = ListXepLoai[(int)ratingStar.Value * 2];
        }
    }
}
