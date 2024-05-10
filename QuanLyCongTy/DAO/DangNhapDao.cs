using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class DangNhapDAO
    {
        DBConnection dbConn = new DBConnection();
        public string KTTaiKhoan(DangNhap dn)
        {
            string sqlStr = string.Format("SELECT * FROM TaiKhoan");
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            foreach (DataRow row in dt.Rows)
            {
                if (row[1].ToString().Equals(dn.Taikhoan) && row[2].ToString().Equals(dn.Matkhau))
                    return row[0].ToString();
            }
            return null;
        }
        public bool KTQuanLy(string MaNV)
        {
            string sqlStr = string.Format("SELECT MaPB FROM NhanVien Where MaNV = '{0}'", MaNV);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString() == "PBQL1";
        }
        public bool KTTruongPhong(string MaNV)
        {
            string sqlStr = string.Format("SELECT MaTrPhong " +
                            "FROM NhanVien INNER JOIN PhongBan " +
                            "ON NhanVien.MaPB = PhongBan.MaPB " +
                            "Where MaNV = '{0}'", MaNV);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString() == MaNV;
        }
    }
}
