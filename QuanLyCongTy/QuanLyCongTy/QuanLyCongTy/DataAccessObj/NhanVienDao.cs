using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class NhanVienDAO
    {
        DBConnection dbConn = new DBConnection();
        public string GetTenNV(string MaNV)
        {
            string sqlStr = string.Format("SELECT HoTenNV FROM NhanVien Where MaNV = '{0}'", MaNV);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString();
        }

    }
}
