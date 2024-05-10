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
    public partial class FChartDA : Form
    {
        ChartDABUS chartDABUS = new ChartDABUS();
        public FChartDA()
        {
            InitializeComponent();
        }
        public void CapNhat(DuAnModel da)
        {
            chartDABUS.da = da;
        }

        private void FChartDA_Load(object sender, EventArgs e)
        {
            chartDABUS.FillChart(chart1);
        }
    }
}
