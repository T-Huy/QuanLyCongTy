using QuanLyCongTy.DataAccessObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class ThemHoTroBUS
    {
        public PhanCongModel pc;
        public Reload.Flp reLoadF;
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        PhongBanDAO phongBanDAO = new PhongBanDAO();
        DuAnDAO duAnDAO = new DuAnDAO();
        HoTroDao hoTroDAO = new HoTroDao();
        public void Fillgv(DataGridView gv)
        {
            DuAnModel da = duAnDAO.getDuAnTheoMa(pc.MaDA);
            PhongBanModel pb = phongBanDAO.GetPhongBanTheoMaPB(da.MaPB);
            gv.DataSource = nhanVienDAO.DSNhanVienRanhTheoLPB(pb, pc);
            gv.Columns[0].Visible = false;
        }
        public void AddListBox(DataGridView gv, ListBox lb)
        {
            string MaNV = gv.CurrentRow.Cells[0].Value.ToString();
            NhanVienModel nv = nhanVienDAO.GetNhanVienTheoMaNV(MaNV);
            foreach (NhanVienModel nvlb in lb.Items)
                if (nv.MaNV.Equals(nvlb.MaNV))
                    return;
            lb.Items.Add(nv);
            lb.DisplayMember = "HoTenNV";
        }
        public void ThemHoTro(ListBox lb)
        {
            foreach(object obj in lb.Items)
                if (obj is NhanVienModel)
                {
                    NhanVienModel nv = (NhanVienModel)obj;
                    if (!hoTroDAO.Them(new HoTroModel(pc.MaDA, pc.MaCV, nv.MaNV)))
                    {
                        MessageBox.Show("Them That bai");
                        return;
                    }
                }
            MessageBox.Show("Them Thanh Cong");
            reLoadF();
        }
    }
}
