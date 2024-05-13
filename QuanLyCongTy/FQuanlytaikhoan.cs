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
    public partial class FQuanlytaikhoan : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DataTable dt = new DataTable();
        public FQuanlytaikhoan()
        {
            InitializeComponent();
            LoadTaikhoan();
        }

        private void LoadTaikhoan()
        {
            try
            {
                conn.Open();
                dt.Clear();
                string query = "SELECT * FROM dbo.TaiKhoan";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                

                da.Fill(dt);

               
                gvQuanlytaikhoan.DataSource = dt;
            

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {           
                conn.Open();
                string query = "DELETE FROM dbo.TaiKhoan where MaNV =  @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaNV", gvQuanlytaikhoan.SelectedRows[0].Cells["MaNV"].Value.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
                LoadTaikhoan();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int i = gvQuanlytaikhoan.SelectedRows[0].Index;
            FSuaTaiKhoan fSuaTaiKhoan = new FSuaTaiKhoan(gvQuanlytaikhoan.Rows[i].Cells["MaNV"].Value.ToString(), 
                gvQuanlytaikhoan.Rows[i].Cells["TK"].Value.ToString(), gvQuanlytaikhoan.Rows[i].Cells["MK"].Value.ToString());
            fSuaTaiKhoan.ShowDialog();
            LoadTaikhoan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FThemTaiKhoan fThemTaiKhoan = new FThemTaiKhoan();
            fThemTaiKhoan.ShowDialog();
            LoadTaikhoan();
        }

    }     
}
