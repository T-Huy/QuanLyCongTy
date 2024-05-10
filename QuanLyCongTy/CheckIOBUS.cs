using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class CheckIOBUS
    {
        CheckIODAO checkIODAO = new CheckIODAO();
        public NhanVienModel nv;
        public void FillDataGrid(Guna2DataGridView gvCheckIO)
        {
            gvCheckIO.DataSource = checkIODAO.LayDanhSachCheckIO(nv);
        }

        public void CheckIN()
        {
            if (checkIODAO.KiemTraCI(nv))
                checkIODAO.CheckIn(nv);
            else MessageBox.Show("Bạn đã checkin rồi!!!");
        }

        public void CheckOUT()
        {
            if (checkIODAO.KiemTraCO(nv))
                checkIODAO.CheckOUT(nv);
            else MessageBox.Show("Bạn đã checkout rồi!!!");
        }
    }
}
