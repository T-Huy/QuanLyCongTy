using Microsoft.Win32;
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
    public partial class FTinhLuong : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public FTinhLuong()
        {
            InitializeComponent();
            LoadTenPhongBan();
         
        }

        private void LoadTenPhongBan()
        {
            try
            {
                conn.Open();
               string query = "SELECT TenPB FROM dbo.PhongBan";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                cmbTenPB.Items.Clear();

                while (reader.Read())
                {
                    cmbTenPB.Items.Add(reader["TenPB"].ToString());
                }

                reader.Close();

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



        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = @"SELECT NV.MaNV, NV.HoTenNV,NV.Cccd,NV.Email, dbo.TinhLuongTheoThang(NV.MaNV, @Thang) AS Luong
                                 FROM dbo.NhanVien NV
                                 INNER JOIN dbo.PhongBan PB ON NV.MaPB = PB.MaPB
                                 WHERE PB.TenPB = @TenPB";

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand(query, conn);

                // Thêm các tham số vào câu truy vấn
                cmd.Parameters.AddWithValue("@Thang", dtpNgayTinhLuong.Value);
                cmd.Parameters.AddWithValue("@TenPB", cmbTenPB.SelectedItem.ToString());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                gvTinhLuong.DataSource = dt;
                gvTinhLuong.Columns["MaNV"].HeaderText = "Mã NV";
                gvTinhLuong.Columns["HoTenNV"].HeaderText = "Họ và tên";
                gvTinhLuong.Columns["Cccd"].HeaderText = "CCCD";
                gvTinhLuong.Columns["Email"].HeaderText = "Email";
                gvTinhLuong.Columns["Luong"].HeaderText = "Lương";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối sau khi sử dụng xong
                conn.Close();
            }
        }
        private void ToExcel(DataGridView dataGridView, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "TinhLuong";

                // Xuất header
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                }

                // Xuất nội dung
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }


        private void cmbTenPB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbTenPB.SelectedItem != null)
            {
                LoadData();
            }
        }

        private void dtpNgayTinhLuong_ValueChanged_1(object sender, EventArgs e)
        {
            if (cmbTenPB.SelectedItem != null)
            {
                LoadData();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(gvTinhLuong, saveFileDialog1.FileName);
            }
        }
    }
}
