using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class SuaDABUS
    {
        PhongBanDAO phongBanDAO = new PhongBanDAO();
        DuAnDAO duAnDAO = new DuAnDAO();
        public DuAnModel da;
        public void DSTinhTrangPBTheoLPB(DataGridView gv, Guna2ComboBox cmbTenPB, Guna2DateTimePicker dtpNgayBD, Guna2DateTimePicker dtpDeadLine)
        {
            PhongBanModel pb =(PhongBanModel)cmbTenPB.SelectedItem;
            gv.DataSource = phongBanDAO.DSTinhTrangPBTheoLPB2(pb.MaLPB,da.MaDA,dtpNgayBD.Value, dtpDeadLine.Value);
        }

        public void FillcmbTenPB(Guna2ComboBox cmbTenPB, Guna2DateTimePicker dtpNgayBD, Guna2DateTimePicker dtpDeadLine)
        {
            if (cmbTenPB.SelectedItem is PhongBanModel)
            {
                PhongBanModel pb = (PhongBanModel)cmbTenPB.SelectedItem;
                cmbTenPB.DataSource = phongBanDAO.ListPhongBanTheoLPB(pb.MaLPB, dtpNgayBD.Value, dtpDeadLine.Value);
                cmbTenPB.ValueMember = "MaPB";
                cmbTenPB.DisplayMember = "TenPB";
            }
        }

        public void FillControl(Guna2TextBox txtTenDA, Guna2TextBox txtMoTa, Guna2ComboBox cmbTenPB,
            Guna2TextBox txtDiaDiem, Guna2DateTimePicker dtpNgayBD, Guna2DateTimePicker dtpDeadLine)
        {
            PhongBanModel pb = phongBanDAO.GetPhongBanTheoMaPB(da.MaPB);
            txtTenDA.Text = da.TenDuAn;
            txtMoTa.Text = da.MoTa;
            txtDiaDiem.Text = da.DiaDiem;
            dtpNgayBD.Text = da.NgayBD.ToString();
            dtpDeadLine.Text = da.DeadLine.ToString();
            cmbTenPB.DataSource = phongBanDAO.ListPhongBanTheoLPB2(pb.MaLPB, da.MaDA, dtpNgayBD.Value, dtpDeadLine.Value);
            cmbTenPB.ValueMember = "MaPB";
            cmbTenPB.DisplayMember = "TenPB";
            cmbTenPB.SelectedItem = pb;
        }

        public void SuaDA(Guna2TextBox txtTenDA, Guna2TextBox txtMoTa, Guna2ComboBox cmbTenPB,
            Guna2TextBox txtDiaDiem, Guna2DateTimePicker dtpNgayBD, Guna2DateTimePicker dtpDeadLine)
        {
            if (duAnDAO.Sua(new DuAnModel(da.MaDA, txtTenDA.Text, txtMoTa.Text, cmbTenPB.SelectedValue.ToString(),
                txtDiaDiem.Text, dtpNgayBD.Value, dtpDeadLine.Value, "", -1, 0)))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            return;
        }
    }
}
