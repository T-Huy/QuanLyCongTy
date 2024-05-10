using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class ucMenuBtn : UserControl
    {
        Color color;
        UC uc;
        Form childForm;
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Test text displayed in the textbox"), Category("Data")]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = btn.Text = value; }
        }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Test text displayed in the textbox"), Category("Data")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = btn.BackColor = value; }
        }
        public ucMenuBtn()
        {
            InitializeComponent();
        }
        public void SetupButon(Color color,UC uc,Form childForm)
        {
            this .color = color;
            this .uc = uc;
            this .childForm = childForm;
            uc.AddChildForm(childForm);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            uc.OffColor();
            BackColor = color;
            uc.ChangeTiltle(BackColor, Text);
            uc.OpenChildForm(childForm);
        }
    }
}
