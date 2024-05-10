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
    public partial class FThongTin : Form
    {
        ThongTinDAO ttDAO = new ThongTinDAO();
        string MaNV;
        public FThongTin(string MaNV)
        {   
            InitializeComponent();
            this.MaNV = MaNV;
        }

        private void FThongTin_Load(object sender, EventArgs e)
        {
            ThongTin tt = ttDAO.LayThongTin(MaNV);

            label11.Text = tt.MaNV;
            label12.Text = tt.HoTenNV;
            label13.Text = tt.DiaChi;
            label14.Text = tt.Sdt;
            label15.Text = tt.NgaySinh.ToString("dd/MM/yyyy");
            label16.Text = tt.GioiTinh;
            label22.Text = tt.Cccd;
            label17.Text = tt.Email;
            label18.Text = tt.MaPB;
            label19.Text = tt.TenPB;
        }
    }
}
