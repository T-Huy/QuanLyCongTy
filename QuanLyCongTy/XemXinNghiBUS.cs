using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemXinNghiBUS
    {
        public XinNghiModel xn;

        XinNghiDAO xinNghiDAO = new XinNghiDAO();
        FlowLayoutPanel flpListXN;

        public void AddFlpXN(FlowLayoutPanel flpListXN)
        {
            this.flpListXN = flpListXN;
        }

        public void FillXinNghi()
        {
            flpListXN.Controls.Clear();
            List<XinNghiModel> listXN = xinNghiDAO.ListXinNghi();
            foreach (XinNghiModel xn in listXN)
            {
                UCXemXinNghiChuaDuyet uc = new UCXemXinNghiChuaDuyet();
                uc.CapNhat(xn, FillXinNghi);
                flpListXN.Controls.Add(uc);
            }
        }

    }
}
