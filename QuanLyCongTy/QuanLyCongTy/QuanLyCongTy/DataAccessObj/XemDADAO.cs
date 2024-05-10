using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class XemDADAO
    {
        DBConnection dbConn = new DBConnection();
        public DataTable LayDanhSachDuAnChuaHT(string MaPB)
        {
            string sqlStr = string.Format("SELECT MaDA " +
                                           "FROM DuAn " +
                                           "WHERE MaDA IN (SELECT MaDA " +
                                                           "FROM PhanCong " +
                                                         " Where TienDo < 100) " +
                                                         " OR MaDA NOT IN (SELECT MaDA FROM PhanCong) ");
                                                         //" AND MaPB = {0}",MaPB);
            return dbConn.LayDanhSach(sqlStr);
        }

        public DataTable LayDanhSachDuAnDaHT(string MaPB)
        {
            string sqlStr = string.Format("SELECT MaDA " +
                                           "FROM DuAn " +
                                           "WHERE MaDA NOT IN (SELECT MaDA " +
                                                           "FROM PhanCong " +
                                                         " Where TienDo < 100) " +
                                                         " AND MaDA IN (SELECT MaDA FROM PhanCong) ");
                                                         //" AND MaPB = {0}", MaPB);
            return dbConn.LayDanhSach(sqlStr);
        }
        public string LayDiemDA(string MaDA)
        {
            string sqlStr = string.Format("SELECT ChamDiem FROM DuAn WHERE MaDA = '{0}'", MaDA);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString();
        }
    }
}
