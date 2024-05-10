using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class ThemDABUS
    {
        PhongBanDAO phongBanDAO = new PhongBanDAO();
        LoaiPhongBanDAO loaiPhongBanDAO = new LoaiPhongBanDAO();
        DuAnDAO duAnDAO = new DuAnDAO();
        public void DSTinhTrangPBTheoLPB(DataGridView gv, Guna2ComboBox cmbLoaiPB, Guna2DateTimePicker dtpNgayBD, Guna2DateTimePicker dtpDeadLine)
        {
            gv.DataSource = phongBanDAO.DSTinhTrangPBTheoLPB(cmbLoaiPB.SelectedValue.ToString(),
                dtpNgayBD.Value, dtpDeadLine.Value);
        }

        public void FillcmbLoaiPB(Guna2ComboBox cmbLoaiPB)
        {
            cmbLoaiPB.DataSource = loaiPhongBanDAO.ListLoaiPB();
            cmbLoaiPB.ValueMember = "MaLPB";
            cmbLoaiPB.DisplayMember = "TenLPB";
        }

        public void FillcmbTenPB(Guna2ComboBox cmbTenPB, Guna2ComboBox cmbLoaiPB, Guna2DateTimePicker dtpNgayBD, Guna2DateTimePicker dtpDeadLine)
        {
            cmbTenPB.DataSource = phongBanDAO.ListPhongBanTheoLPB(cmbLoaiPB.SelectedValue.ToString(),
                dtpNgayBD.Value, dtpDeadLine.Value);
            cmbTenPB.ValueMember = "MaPB";
            cmbTenPB.DisplayMember = "TenPB";
        }

        public void TaoMaDA(Label lblMaDA)
        {
            string MaxMaDA = duAnDAO.MaDALonNhat();
            lblMaDA.Text = MaxMaDA.Substring(0, 2) + (int.Parse(MaxMaDA.Substring(2, 3)) + 1).ToString("D3");
        }

        public void ThemDA(Label lblMaDA, Guna2TextBox txtTenDA, Guna2TextBox txtMoTa, Guna2ComboBox cmbTenPB,
            Guna2TextBox txtDiaDiem, Guna2DateTimePicker dtpNgayBD, Guna2DateTimePicker dtpDeadLine)
        {
            if (duAnDAO.Them(new DuAnModel(lblMaDA.Text, txtTenDA.Text, txtMoTa.Text, cmbTenPB.SelectedValue.ToString(),
                txtDiaDiem.Text, dtpNgayBD.Value, dtpDeadLine.Value, "", -1, 0)))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            return;
        }

        
    }
}
