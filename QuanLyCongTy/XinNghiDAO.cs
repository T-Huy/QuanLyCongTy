using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyCongTy
{
    public class XinNghiDAO
    {
        DBConnection dbConn = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DataProvider dataProvider = new DataProvider();

        public string LayHeSo(string MaNV)
        {
            string sqlStr = string.Format("SELECT HeSoDuyet FROM XinNghi WHERE MaNV = '{0}'", MaNV);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString();
        }


        public DataTable LayDanhSachChuaDuyetXinNghi()
        {
            string sqlStr = string.Format("SELECT MaNV " +
                                           "FROM XinNghi " +
                                            "WHERE HeSoDuyet = -1");
            return dbConn.LayDanhSach(sqlStr);
        }

        public List<XinNghiModel> ListXinNghi()
        {
            List<XinNghiModel> list = new List<XinNghiModel>();
            string query = "SELECT * FROM XinNghi";
            DataTable dt = dataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
                list.Add(new XinNghiModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString(), int.Parse(dr[4].ToString())));
            return list;
        }

        public List<XinNghiModel> ListXinNghiNhanVien(string MaNV)
        {
            List<XinNghiModel> list = new List<XinNghiModel>();
            string query = String.Format("SELECT * FROM XinNghi WHERE MaNV = '{0}'", MaNV);
            DataTable dt = dataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
                list.Add(new XinNghiModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString(), int.Parse(dr[4].ToString())));
            return list;
        }

        public List<XinNghiModel> ListXinNghiDaDuyet(XinNghiModel xn)
        {
            List<XinNghiModel> list = new List<XinNghiModel>();
            string query = "SELECT * FROM XinNghi WHERE HeSoDuyet = 1";
            DataTable dt = dataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new XinNghiModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString(), int.Parse(dr[4].ToString())));
            }
            return list;
        }

        public DataTable LayDanhSachXinNghiDaDuyet()
        {
            string sqlStr = string.Format("SELECT MaNV " +
                                           "FROM XinNghi " +
                                           "WHERE HeSoDuyet = 1");
            return dbConn.LayDanhSach(sqlStr);
        }

        public XinNghiModel getXinNghiTheoMa(string MaNV)
        {
            string query = "SELECT * FROM XinNghi WHERE MaNV = @MaNV ";
            object[] para = new object[] { MaNV };
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            DataRow dr = dt.Rows[0];
            return new XinNghiModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString(), int.Parse(dr[4].ToString()));
        }
        public bool Them(XinNghiModel xn)
        {
            
            string query = "INSERT INTO XinNghi VALUES ( @MaNV , @NgayNghi , @SoNgayNghi, @LyDo, @HeSoDuyet  )";

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
             cmd.Parameters.AddWithValue("@MANV", xn.MaNV);
             cmd.Parameters.AddWithValue("@NgayNghi", xn.NgayBD);
             cmd.Parameters.AddWithValue("@SoNgayNghi", xn.SoNgayNghi);
             cmd.Parameters.AddWithValue("@LyDo", xn.LyDo);
             cmd.Parameters.AddWithValue("@HeSoDuyet", xn.HeSoDuyet);
             cmd.ExecuteNonQuery();
             conn.Close();
            object[] para = new object[] { xn.MaNV, xn.NgayBD, xn.SoNgayNghi, xn.LyDo, xn.HeSoDuyet };
            
            return true;
        }

        public bool Xoa(XinNghiModel xn)
        {
            string query = "DELETE FROM XinNghi WHERE MaNV = @MaNV ";
            object[] para = new object[] { xn.MaNV };
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }

    }
}
