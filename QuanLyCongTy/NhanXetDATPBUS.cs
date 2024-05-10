using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class NhanXetDATPBUS
    {
        public DuAnModel da;
        string[] list = {" ", "Tệ", "Tệ", "Chưa tốt", "Chưa Tốt", "Tốt", "Tốt", "Rất tốt", "Rất tốt", "Xuất sắc", "Xuất sắc" };

        public void FillControls(Label Ten, Guna2TextBox NhanXet, Guna2RatingStar ratingStar, Label XepLoai, Label TienThuong)
        {
            Ten.Text = da.TenDuAn;
            NhanXet.Text = da.DanhGia;
            ratingStar.Value = da.ChamDiem / 20;
            TienThuong.Text = da.Thuong.ToString();
            XepLoai.Text = list[(int)ratingStar.Value * 2];
        }
    }
}
