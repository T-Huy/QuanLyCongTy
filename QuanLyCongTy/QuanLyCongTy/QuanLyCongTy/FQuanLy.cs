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
    public partial class FQuanLy : Form
    {
        public FQuanLy(string ma)
        {
            InitializeComponent();
            ucTheme.Setma(ma);
            ucbtnCheckinout.SetupButon(ColorTranslator.FromHtml("#8BC240"), ucTheme, new FCheckinout(ma));
            ucbtnTaoDA.SetupButon(ColorTranslator.FromHtml("#126881"), ucTheme, new FDuAn());
            ucbtnXinNghi.SetupButon(ColorTranslator.FromHtml("#8BC240"), ucTheme, new FXinNghi());
        }

    }
}
