using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class FThemTroGiup : Form
    {
        PhanCongDAO PCdao;
        string maDA;
        string maCV;
        public FThemTroGiup()
        {
            InitializeComponent();
        }
        public void Set(string maPB, string maDA, string maCV)
        {
            PCdao = new PhanCongDAO(maPB);
            this.maDA = maDA;
            this.maCV = maCV;
        }
        private void HienThiDanhSach()
        {
            this.gv_CongViec.DataSource = PCdao.LayDSTinhTrangNVTroGiup();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FThemTroGiup_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void gv_CongViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tenNV = gv_CongViec.CurrentRow.Cells[0].Value.ToString();
            foreach (string str in listBox1.Items)
                if(tenNV.Equals(str))
                    return;
            listBox1.Items.Add(gv_CongViec.CurrentRow.Cells[0].Value.ToString());
            
        }
        private void btnThemTroGiup_Click(object sender, EventArgs e)
        {
            foreach (string str in listBox1.Items)
            {
                HoTro ht =  new HoTro(maDA,maCV,PCdao.GetMaNV(str));
                PCdao.ThemTroGiup(ht);
            }
            Close();
        }
    }
}
