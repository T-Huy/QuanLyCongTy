using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class ThemXNBUS
    {
        int n;
        XinNghiDAO xinNghiDAO = new XinNghiDAO();

        public void ThemXN(Guna2TextBox txt_MaNV, Guna2TextBox txt_HovaTen, Guna2DateTimePicker guna2DateTimePicker, Guna2TextBox txt_SoNgayNghi, Guna2ComboBox cb_LyDo, int n)
        {
            if (xinNghiDAO.Them(new XinNghiModel(txt_MaNV.Text, txt_HovaTen.Text, guna2DateTimePicker.Value, int.Parse(txt_SoNgayNghi.Text) , cb_LyDo.Text, -1)))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            return;
        }
    }
}
