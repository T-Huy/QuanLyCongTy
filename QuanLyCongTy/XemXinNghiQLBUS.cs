using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemXinNghiQLBUS
    {
        XinNghiDAO xinNghiDAO = new XinNghiDAO();
        FlowLayoutPanel flpListXN = new FlowLayoutPanel();
        XinNghiModel xn;
        NhanVienDAO nvDAO;
        DangNhapDAO dnDao = new DangNhapDAO();
        private string MaNV;
        public void AddFlpXN(FlowLayoutPanel flpListXN)
        {
            this.flpListXN = flpListXN;
        }

        public void AddMaNV(string MaNV)
        {
            this.MaNV = MaNV;
        }


        public void FillXinNghi()
        {

            flpListXN.Controls.Clear();
            List<XinNghiModel> listXN = new List<XinNghiModel>();
            if ((dnDao.KTTruongPhong(MaNV)) || (dnDao.KTQuanLy(MaNV)))
            {
                listXN = xinNghiDAO.ListXinNghi();
            }
            else listXN = xinNghiDAO.ListXinNghiNhanVien(MaNV);
            foreach (XinNghiModel xn in listXN)
            {
                UCXemXinNghiChuaDuyet uc = new UCXemXinNghiChuaDuyet();
                uc.CapNhat(xn, FillXinNghi);
                flpListXN.Controls.Add(uc);              
            }
        }

    }
}
