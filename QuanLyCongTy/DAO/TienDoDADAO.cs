using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class TienDoDADAO
    {
        DBConnection dbConn = new DBConnection();

        public TienDoDA LayDanhSachDuAn(string MaDA)
        {
            string sqlStr = string.Format("SELECT DuAn.MaDA, TenDuAn, PhongBan.MaPB, TenPB, NgayBD, DeadLine " +
                                            "FROM DuAn, PhongBan WHERE DuAn.MaPB = PhongBan.MaPB " +
                                            "AND DuAn.MaDA = '{0}'", MaDA);
            DataRow dr = dbConn.LayDanhSach(sqlStr).Rows[0];
            return new TienDoDA(
                dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), DateTime.Parse(dr[4].ToString()), DateTime.Parse(dr[5].ToString()));
        }

        public int LayTienDo(string MaDA)
        {
            string sqlStr = string.Format("SELECT AVG(TienDo)" +
                                            "FROM  PhanCong WHERE MaDA = '{0}'", MaDA);
            DataTable dt = dbConn.LayDanhSach(sqlStr) ;
            if (!(dt.Rows[0][0] is DBNull))
                return (int)dt.Rows[0][0];
            else return 0;
        }
    }
}
