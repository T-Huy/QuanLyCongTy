using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class TDCaNhanDAO
    {
        DBConnection dbConn = new DBConnection();
        public TDCaNhan LayDanhSachTienDo(string MaNV)
        {
            string sqlstr = string.Format("SELECT NhanVien.MaNV, PhanCong.MaDA, HoTenNV, CongViec.TenCV, TienDO, ChamDiem, NgayBD, DeadLine " +
                                            "FROM CongViec, PhanCong, NhanVien  " +
                                            "WHERE PhanCong.MaNV = NhanVien.MaNV and PhanCong.CongViec = CongViec.MaCV " +
                                            "AND NhanVien.MaNV = '{0}'", MaNV);
            DataRow dr = dbConn.LayDanhSach(sqlstr).Rows[0];
            return new TDCaNhan(
                dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), DateTime.Parse(dr[6].ToString()), DateTime.Parse(dr[7].ToString()));
        }

        public void Sua(string MaNV, string MaDA, string Diem)
        {
            string sqlStr = string.Format("UPDATE PhanCong SET  ChamDiem = '{2}' WHERE MaNV = '{0}' and MaDA = '{1}' ", MaNV, MaDA, int.Parse(Diem));
            dbConn.ThucThi(sqlStr);
        }
    }
}
