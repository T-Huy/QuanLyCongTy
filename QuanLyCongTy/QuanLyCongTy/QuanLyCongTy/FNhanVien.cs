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
    public partial class FNhanVien : Form
    {
        public FNhanVien(string ma)
        {
            InitializeComponent();
            ucTheme.Setma(ma);
            ucbtnCheckinout.SetupButon(ColorTranslator.FromHtml("#8BC240"), ucTheme, new FCheckinout(ma));
            ucbtnPhanCong.SetupButon(ColorTranslator.FromHtml("#126881"), ucTheme, new FKPI());
            ucbtnKPI.SetupButon(ColorTranslator.FromHtml("#A12059"), ucTheme, new FKPI());
            ucbtnXinNghi.SetupButon(ColorTranslator.FromHtml("#8BC240"), ucTheme, new FXinNghi());
        }
    }
}
