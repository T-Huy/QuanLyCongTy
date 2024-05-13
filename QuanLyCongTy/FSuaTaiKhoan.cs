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
    public partial class FSuaTaiKhoan : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DataTable dt = new DataTable();
        public FSuaTaiKhoan(string MaNV,string TK, string MK)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtMaNV.Text = MaNV;
            this.txtTK.Text = TK;
            this.txtMK.Text = MK;
            txtMaNV.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTK.Text))
                {
                    MessageBox.Show("Tài khoản không được để trống.");
                    return; // Ngăn không cho hành động tiếp tục nếu textbox trống
                }
                if (string.IsNullOrWhiteSpace(txtMK.Text))
                {
                    MessageBox.Show("Mật khẩu không được để trống.");
                    return; // Ngăn không cho hành động tiếp tục nếu textbox trống
                }
                conn.Open();
                string qr = "SELECT * FROM dbo.TaiKhoan where TK=@TK and MaNV<>@MaNV";
                SqlCommand cm = new SqlCommand(qr, conn);
                cm.Parameters.AddWithValue("@TK",txtTK.Text.ToString());
                cm.Parameters.AddWithValue("@MaNV", txtMaNV.Text.ToString());
                dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cm);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Trùng tài khoản");
                    return;
                }
                string query = "UPDATE dbo.TaiKhoan SET TK=@TK, MK=@MK WHERE MaNV=@MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.ToString());
                cmd.Parameters.AddWithValue("@TK", txtTK.Text.ToString());
                cmd.Parameters.AddWithValue("@MK", txtMK.Text.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:", ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
