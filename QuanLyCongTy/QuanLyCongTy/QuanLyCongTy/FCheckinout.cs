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
    public partial class FCheckinout : Form
    {
        string ma;
        CheckinDAO ciDao;
        CheckoutDAO coDao;
        public FCheckinout(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            ciDao = new CheckinDAO(ma);
            coDao = new CheckoutDAO(ma);
        }
        private void CapNhatGVCheckin()
        {
            gvCheckinList.DataSource = ciDao.LayDanhSachCheckin();
            
        }
        private void CapNhatGVCheckout()
        {
            gvCheckoutList.DataSource = coDao.LayDanhSachCheckout();
        }
        private void Checkin_Load(object sender, EventArgs e)
        {
            CapNhatGVCheckin();
            CapNhatGVCheckout();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            DateTime curent = DateTime.Now;
            if (ciDao.KTDiemDanh(curent))
            {
                ciDao.Them(curent);
                CapNhatGVCheckin();
                if (ciDao.KTTre(curent.TimeOfDay))
                {
                    MessageBox.Show("Bạn đã trễ");
                }
            }
            else
            {
                MessageBox.Show("Bạn đã điểm danh rồi");
            }    
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            if (coDao.KTDiemDanh(current))
            {
                coDao.Them(current);
                CapNhatGVCheckout();
                if (coDao.KTSom(current.TimeOfDay))
                {
                    MessageBox.Show("Bạn về trước giờ nghỉ");
                }
            }
            else
            {
                MessageBox.Show("Bạn đã điểm danh rồi");
            }
        }
    }
}
