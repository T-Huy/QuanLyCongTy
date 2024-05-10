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
    public partial class FPhanCong : Form
    {
        PhanCongDAO PCdao;
        string maDA;
        public FPhanCong(string maDA,string maPB)
        { 
            InitializeComponent();
            PCdao = new PhanCongDAO(maPB);
            this.maDA = maDA;
        }

        private void PhanCong_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            cboNhanVien.DataSource = PCdao.LayDSTenNV();
            cboCongViec.DataSource = PCdao.LayDSCongViec();
        }
        private void HienThiDanhSach()
        {   
            this.gv_CongViec.DataSource = PCdao.LayDSTinhTrangNV();          
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            PhanCong pc = new PhanCong(cboNhanVien.Text,
                                       maDA,
                                       cboCongViec.Text,
                                       textBox1.Text,
                                       dtpDBLam.Value,
                                       dtpDeadline.Value);
            PCdao.Them(pc);
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboCongViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCongViec.Text == "Kh�c")
            {
                textBox1.Show();
                panel1.Location = new Point(textBox1.Location.X, textBox1.Location.Y + textBox1.Size.Height + 1);
            }
            else
            {
                textBox1.Hide();
                panel1.Location = new Point(cboCongViec.Location.X, cboCongViec.Location.Y + cboCongViec.Size.Height + 1);
            }
            
        }
    }
}
