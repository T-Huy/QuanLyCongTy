using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class ThongTinDAO
    {
        DBConnection dbConn = new DBConnection();

        public ThongTin LayThongTin(string MaNV)
        {
            string sqlStr = string.Format("SELECT MaNV, HoTenNV, DiaChi, Sdt, NgaySinh, Phai, Cccd, Email, NhanVien.MaPB, TenPB " +
                                          "FROM NhanVien inner join PhongBan ON NhanVien.MaPB = PhongBan.MaPB " + 
                                          "WHERE NhanVien.MaNV = '{0}'", MaNV);
            DataRow dr = dbConn.LayDanhSach(sqlStr).Rows[0];
            return  new ThongTin(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),DateTime.Parse(dr[4].ToString()), 
                                                    dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), "");
        }
    }
}
