using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class ThongTinDADAO
    {
        DBConnection dbConn = new DBConnection();
        string MaDA;
        public ThongTinDADAO(string MaDA)
        {
            this.MaDA = MaDA;
        }
        public DuAn ThongTinDA()
        {
            string sqlStr = string.Format("SELECT TenDuAn, MaPB, DiaDiem, NgayBD, DeadLine, MoTa FROM DuAn " +
                "WHERE MaDA = '{0}'",MaDA);
            DataRow dr = dbConn.LayDanhSach(sqlStr).Rows[0];
            DuAn da = new DuAn(MaDA, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),
                               DateTime.Parse(dr[3].ToString()), DateTime.Parse(dr[4].ToString()), dr[5].ToString());
            return da;
        }
        public List<string> DSMaCVChuaHoanThanh()
        {
            List<string> dsMaCV = new List<string>();
            string sqlStr = string.Format("SELECT MaCV FROM PhanCong Where MaDA = '{0}'", MaDA);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0] != null)
                    dsMaCV.Add(dr[0].ToString());
            }
            return dsMaCV;
        }
    }
}
