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
    public partial class FThemTaiKhoan : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DataTable dt = new DataTable();
        public FThemTaiKhoan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaNV.Text))
                {
                    MessageBox.Show("Mã nhân viên không được để trống.");
                    return; // Ngăn không cho hành động tiếp tục nếu textbox trống
                }
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
                string qr = "SELECT * FROM dbo.TaiKhoan where MaNV=@MaNV";
                SqlCommand cm = new SqlCommand(qr, conn);
                cm.Parameters.AddWithValue("@MaNV", txtMaNV.Text.ToString());
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cm);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Nhân viên đã có tài khoản");
                    return;
                }

                qr = "SELECT * FROM dbo.TaiKhoan where TK=@TK";
                cm = new SqlCommand(qr, conn);
                cm.Parameters.AddWithValue("@TK",txtTK.Text.ToString());
                dt = new DataTable();
                adapter = new SqlDataAdapter(cm);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Trùng tài khoản");
                    return;
                }
                string query = "INSERT INTO dbo.TaiKhoan Values(@MaNV,@TK,@MK)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.ToString());
                cmd.Parameters.AddWithValue("@TK", txtTK.Text.ToString());
                cmd.Parameters.AddWithValue("@MK", txtMK.Text.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                txtMaNV.ResetText();
                txtTK.ResetText();
                txtMK.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có nhân viên này");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
