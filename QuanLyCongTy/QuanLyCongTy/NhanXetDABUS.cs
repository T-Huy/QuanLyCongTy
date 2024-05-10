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

        public void FillControl(Label lbl_TenDA, Guna2TextBox txt_NhanXet, Label lblXepLoai, Guna2RatingStar ratingStar)
        {
            lbl_TenDA.Text = da.TenDuAn;
            txt_NhanXet.Text = da.DanhGia;
            ratingStar.Value = da.ChamDiem / 20;
            XepLoai(lblXepLoai,ratingStar);
        }
        public void LuuNhanXet(Guna2TextBox txt_NhanXet, Guna2RatingStar ratingStar)
        {
            da.DanhGia = txt_NhanXet.Text;
            da.ChamDiem = (int)ratingStar.Value * 20;
            duAnDAO.Sua(da);
        }
        public void XepLoai(Label lblXepLoai, Guna2RatingStar ratingStar)
        {
            lblXepLoai.Text = ListXepLoai[(int)ratingStar.Value * 2];
        }
    }
}
