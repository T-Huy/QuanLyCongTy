using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class FDangNhap : Form
    {
        DangNhapDAO dnDao = new DangNhapDAO();
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
            string MaNV = dnDao.KTTaiKhoan(dn);
            if (MaNV != null)
            {
                this.Hide();
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                Form newForm;
                if (dnDao.KTQuanLy(MaNV))
                    newForm = new FQuanLy(MaNV);
                else if (dnDao.KTTruongPhong(MaNV))
                    newForm = new FTruongPhong(MaNV);
                else
                    newForm = new FNhanVien(MaNV);
                newForm.ShowDialog();
                this.Show();
            }
            else
            {
                Form form = new FSaiTK();
                Enabled = false;
                form.ShowDialog();
                Enabled = true;
            }
        }

        private void ckbMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }
                
            if (!ckbMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = '●';
            }    
        }
    }
}
