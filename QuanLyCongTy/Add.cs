using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class Add : Form
    {
        ThemXNBUS themXNBUS = new ThemXNBUS();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        string manv;
        public Add(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            txt_Khac.Enabled = false;
            txt_MaNV.Text = manv;
            txt_MaNV.Enabled= false;
            
        }


        private void cb_Lydo_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (cb_LyDo.SelectedItem == "Khác")
            {
                txt_Khac.Enabled = true;
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "select * from NhanVien where MaNV = '" + txt_MaNV.Text + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(s, conn);
                da.Fill(dt);
                if (txt_SoNgayNghi.Text == "0")
                {
                    MessageBox.Show("Số ngày nghỉ phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Mã nhân viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    themXNBUS.ThemXN(txt_MaNV, guna2DateTimePicker1, txt_SoNgayNghi, cb_LyDo, -1);
                    Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Bạn đã xin nghỉ ngày này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            
        }

        private void txt_SoNgayNghi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
