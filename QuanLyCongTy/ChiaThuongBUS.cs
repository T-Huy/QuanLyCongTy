using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class ChiaThuongBUS
    {
        PhanCongDAO phanCongDAO = new PhanCongDAO();
        public DuAnModel da;

        public void FillCaNhan(FlowLayoutPanel flp, Label TongTien)
        {
            flp.Controls.Clear();
            double TienThuong = da.Thuong;
            List<PhanCongModel> list = phanCongDAO.ListPCDaHTTheoDA(da.MaDA);
            foreach(PhanCongModel pc in list)
            {
                UCThuongCaNhan uc = new UCThuongCaNhan();
                uc.CapNhat(pc);
                flp.Controls.Add(uc);
                TienThuong -= pc.Thuong;
            }
            TongTien.Text = TienThuong.ToString();
        }

        public void XacNhan(FlowLayoutPanel flp)
        {
            foreach(Control ctr in flp.Controls)
            {
                if (ctr is UCThuongCaNhan)
                {
                    UCThuongCaNhan ucThuongCaNhan = (UCThuongCaNhan)ctr;
                    ucThuongCaNhan.Luu();
                }
            }
        }
    }
}
