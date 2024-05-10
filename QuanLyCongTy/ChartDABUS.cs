using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCongTy
{
    internal class ChartDABUS
    {
        public DuAnModel da;
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        PhanCongDAO phanCongDAO = new PhanCongDAO();
        public void FillChart(Chart chart)
        {
            chart.ChartAreas[0].AxisY.Maximum = 100;
            List<PhanCongModel> list = phanCongDAO.ListPCTheoDA(da.MaDA);
            foreach (PhanCongModel pc in list) 
            {
                chart.Series["TienDo"].Points.AddXY(nhanVienDAO.GetNhanVienTheoMaNV(pc.MaNV).HoTenNV, pc.TienDo);
            }
        }
    }
}
