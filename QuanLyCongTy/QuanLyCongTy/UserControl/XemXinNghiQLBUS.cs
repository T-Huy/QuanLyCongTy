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
        FlowLayoutPanel flpListXN;

        public void AddFlpXN(FlowLayoutPanel flpListXN)
        {
            this.flpListXN = flpListXN;
        }

        public void FillXinNghiChuaDuyet()
        {
            flpListXN.Controls.Clear();
            List<XinNghiModel> listXN = xinNghiDAO.ListXinNghiChuaDuyet();
            foreach (XinNghiModel xn in listXN)
            {
                UCXemXinNghiChuaDuyet uc = new UCXemXinNghiChuaDuyet(xn.MaNV);
                uc.CapNhat(xn, FillXinNghiChuaDuyet);
                flpListXN.Controls.Add(uc);
            }
        }

        public void FillXinNghiDaDuyet()
        {
            flpListXN.Controls.Clear();
            List<XinNghiModel> listXN = xinNghiDAO.ListXinNghiDaDuyet();
            foreach (XinNghiModel xn in listXN)
            {
                UCXemXinNghiDaDuyet uc = new UCXemXinNghiDaDuyet(xn.MaNV);
                uc.CapNhat(xn, FillXinNghiDaDuyet) ;
                flpListXN.Controls.Add(uc);
            }
        }

    }
}
