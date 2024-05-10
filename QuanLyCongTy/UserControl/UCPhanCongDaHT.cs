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
    public partial class UCPhanCongDaHT : UserControl
    {
        PhanCongDAO phanCongDAO = new PhanCongDAO();
        DuAnDAO duAnDAO = new DuAnDAO();
        CongViecDAO congViecDAO = new CongViecDAO();
        PhanCongModel pc;
        
        public UCPhanCongDaHT()
        {
            InitializeComponent();
        }

        public void CapNhat(PhanCongModel pc)
        {
            this.pc = pc;
        }

        private void UCPhanCongDaHT_Load(object sender, EventArgs e)
        {
            lblTenDA.Text = duAnDAO.getDuAnTheoMa(pc.MaDA).TenDuAn;
            lblTenCV.Text = congViecDAO.GetCongViecTheoMaCV(pc.MaCV).TenCV;
            lblThuong.Text = pc.Thuong.ToString();
            lblTienDo.Text = "100%";
            prgTienDo.Value = 100;
            RatingStar.Value =(float)pc.ChamDiem / 20;
        }
    }
}
