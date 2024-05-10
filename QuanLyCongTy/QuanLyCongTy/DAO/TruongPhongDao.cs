using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class TruongPhongDAO
    {
        DBConnection dbConn = new DBConnection();
        public string GetTenTP(string MaTP)
        {
            string sqlStr = string.Format("SELECT HoTenNV FROM NhanVien Where MaNV = '{0}'", MaTP);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString();
        }
        public string GetMaPB(string MaTP)
        {
            string sqlStr = string.Format("SELECT MaPB FROM NhanVien Where MaNV = '{0}'", MaTP);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString();
        }
    }
}
