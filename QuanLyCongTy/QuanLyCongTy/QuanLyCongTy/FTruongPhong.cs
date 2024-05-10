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
    public partial class FTruongPhong : Form
    {
        TruongPhongDAO tpDao = new TruongPhongDAO();
        public FTruongPhong(string ma)
        {
            InitializeComponent();
            ucTheme.Setma(ma);
            string maTP = tpDao.GetMaPB(ma);
            ucbtnCheckinout.SetupButon(ColorTranslator.FromHtml("#8BC240"), ucTheme, new FCheckinout(ma));
            ucbtnTaoPC.SetupButon(ColorTranslator.FromHtml("#126881"), ucTheme, new FXemDuAn(ma));
            ucbtnXinNghi.SetupButon(ColorTranslator.FromHtml("#8BC240"), ucTheme, new FXinNghi());
        }
    }
}
