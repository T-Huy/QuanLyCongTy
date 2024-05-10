using Guna.UI2.WinForms;
using QuanLyCongTy.DataAccessObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class ThemPhanCongBUS
    {
        public DuAnModel da;
        public Reload.Flp reLoadF;
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        CongViecDAO congViecDAO = new CongViecDAO();
        PhongBanDAO phongBanDAO = new PhongBanDAO();
        PhanCongDAO phanCongDAO = new PhanCongDAO();
        public void Fillgv(DataGridView gv, Guna2DateTimePicker NgayBD, Guna2DateTimePicker DeadLine)
        {
            gv.DataSource = nhanVienDAO.DSNhanVienBanTheoPB(da);
        }
        public void FillcboNV(ComboBox cboNV, Guna2DateTimePicker NgayBD, Guna2DateTimePicker DeadLine)
        {
            cboNV.DataSource = nhanVienDAO.ListNhanVienRanhTheoPB(da);
            cboNV.DisplayMember = "HoTenNV";
            cboNV.ValueMember = "MaNV";
        }
        public void FillcboCV(ComboBox cboCV)
        {
            PhongBanModel pb = phongBanDAO.GetPhongBanTheoMaPB(da.MaPB);
            cboCV.DataSource = congViecDAO.ListCongViecTheoLPB(pb.MaLPB);
            cboCV.DisplayMember = "TenCV";
            cboCV.ValueMember = "MaCV";
        }
        public void ThemPC(ComboBox cboNhanVien, ComboBox cboCongViec, Guna2TextBox textBox, Guna2TextBox txtMoTa, Guna2CustomCheckBox checkbox, Guna2DateTimePicker dtpDBLam, Guna2DateTimePicker dtpDeadline)
        {
            if (checkbox.Checked)
            {
                PhongBanModel pb = phongBanDAO.GetPhongBanTheoMaPB(da.MaPB);
                string MaxMaCV = congViecDAO.GetMaxMaCVTheoLPB(pb.MaLPB);
                string MaCVMoi = MaxMaCV.Substring(0, 4) + (int.Parse(MaxMaCV.Substring(4, 3)) + 1).ToString("D3");
                if (congViecDAO.Them(new CongViecModel(MaCVMoi, textBox.Text, pb.MaLPB)))
                    if (phanCongDAO.Them(new PhanCongModel(da.MaDA, MaCVMoi, cboNhanVien.SelectedValue.ToString(), txtMoTa.Text, dtpDBLam.Value, dtpDeadline.Value, 0, "", -1,0)))
                        MessageBox.Show("Thêm thành công");
                    else
                        MessageBox.Show("Thêm không thành công");
                return;
            }
            if (phanCongDAO.Them(new PhanCongModel(da.MaDA, cboCongViec.SelectedValue.ToString(), cboNhanVien.SelectedValue.ToString(),txtMoTa.Text, dtpDBLam.Value, dtpDeadline.Value, 0, "", -1,0)))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm không thành công");
            reLoadF();
        }
    }
}
