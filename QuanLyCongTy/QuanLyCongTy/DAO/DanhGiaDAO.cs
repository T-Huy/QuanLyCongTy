using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class DanhGiaDAO
    {
        DBConnection dbConn = new DBConnection();

        public DataTable LayDanhSachDanhGia()
        {
            string sqlStr = string.Format("SELECT * FROM PhanCong");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Sua(DanhGia dg)
        {
            string sqlStr = string.Format("UPDATE PhanCong SET  NhanXet = N'{0}', ChamCong = '{1}' WHERE MaNV = '{2}' AND MaDA = '{3}'",  dg.NhanXet, dg.ChamCong, dg.MaNV, dg.MaDA);
            dbConn.ThucThi(sqlStr);
        }
    }
}
