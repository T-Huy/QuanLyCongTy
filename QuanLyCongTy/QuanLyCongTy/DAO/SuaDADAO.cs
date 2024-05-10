using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class SuaDADAO
    {
        DBConnection dbConn = new DBConnection();

        public string GetMaLPB1(string MaDA)
        {
            string sqlStr = string.Format("SELECT PhongBan.MaLPB FROM DuAn, PhongBan  WHERE DuAn.MaPB = PhongBan.MaPB and DuAn.MaDA = '{0}'", MaDA);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString();
        }

        public string GetMaLPB2(string text)
        {
            string sqlStr = string.Format("SELECT MaLPB FROM LoaiPhongBan WHERE TenLPB = N'{0}'", text);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString();
        }
        public string GetMaPB(string text)
        {
            string sqlStr = string.Format("SELECT MaPB FROM PhongBan WHERE TenPB = N'{0}'", text);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString();
        }

        public List<string> LayDanhSachTenLoaiPhongBan()
        {
            string sqlStr = string.Format("SELECT TenLPB FROM LoaiPhongBan");
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr[0].ToString());
            }
            list.Sort();
            return list;
        }

        public List<string> LayDanhSachTenPhongBan(string MaLPB)
        {
            string sqlStr = string.Format("SELECT TenPB FROM LoaiPhongBan, PhongBan WHERE LoaiPhongBan.MaLPB = PhongBan.MaLPB and LoaiPhongBan.MaLPB = '{0}'", MaLPB);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr[0].ToString());
            }
            list.Sort();
            return list;
        }


        public SuaDA LayThongTinDA(string MaDA)
        {
            string sqlstr = string.Format("SELECT DuAn.MaDA, TenDuAn, MoTa,  PhongBan.TenPB, DiaDiem, NgayBD, DeadLine " +
                                          "FROM DuAn, PhongBan WHERE DuAn.MaPB = PhongBan.MaPB " +
                                          "AND DuAn.MaDA = '{0}'", MaDA);
            DataRow dr = dbConn.LayDanhSach(sqlstr).Rows[0];
            return new SuaDA(
                dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()), DateTime.Parse(dr[6].ToString()));
        }

        public void Sua(SuaDA da, string MaPB)
        {
            string sqlStr = string.Format("UPDATE DuAn SET TenDuAn = N'{0}', MoTa = N'{1}',MaPB = '{2}', DiaDiem = N'{3}',NgayBD = '{4}', DeadLine = '{5}' " +
                                          "WHERE MaDA = '{6}'",
                                             da.TenDA, da.MoTa, MaPB, da.DiaDiem, da.NgayBD, da.DeadLine, da.MaDA);
            dbConn.ThucThi(sqlStr);
        }

        public void Xoa(string MaDA)
        {
            string sqlStr2 = string.Format("DELETE FROM HoTro WHERE MaDA = '{0}'", MaDA);
            string sqlStr1 = string.Format("DELETE FROM DuAn WHERE MaDA = '{0}'", MaDA);
            string sqlStr = string.Format("DELETE FROM PhanCong WHERE MaDA = '{0}'", MaDA);
            dbConn.ThucThi(sqlStr2);
            dbConn.ThucThi(sqlStr); 
            dbConn.ThucThi(sqlStr1);
        }

        public void Them(ThemDA da, string MaPB)
        {
            string sqlStr = string.Format("INSERT INTO DuAn (MaDA, TenDuAn, MoTa, MaPB, DiaDiem, NgayBD, DeadLine) " +
                                           "VALUES ( '{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}', '{6}' )", da.MaDA, da.TenDA, da.MoTa, MaPB, da.DiaDiem, da.NgayBD, da.DeadLine);
            dbConn.ThucThi(sqlStr);
        }

        public DataTable LayDSTinhTrangPB()
        {
            string sqlStr = string.Format(
                "SELECT TenPB,Max(DeadLine) as DL " +
                "FROM DuAn " + 
                      "RIGHT OUTER JOIN PhongBan " +
                      "ON PhongBan.MaPB = DuAn.MaPB " +
                "GROUP BY TenPB " +
                "ORDER BY DL") ;
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            dt.Columns.Add(string.Format("TinhTrang"), typeof(string));
            DateTime current = DateTime.Now;
            foreach (DataRow dr in dt.Rows)
            {
                if (!(dr[1] is DBNull) && current.CompareTo(DateTime.Parse(dr[1].ToString())) <= 0)
                    dr[2] = "Bận";
                else
                    dr[2] = "Rảnh";
            }
            return dt;
        }

        public DataTable LayDSTinhTrangLPB(string MaLPB)
        {
            string sqlStr = string.Format(
                "SELECT TenPB,Max(DeadLine) as DL " +
                "FROM DuAn " +
                      "RIGHT OUTER JOIN PhongBan " +
                      "ON PhongBan.MaPB = DuAn.MaPB " +
                "WHERE PhongBan.MaLPB = '{0}' "+
                "GROUP BY TenPB " +
                "ORDER BY DL", MaLPB);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            dt.Columns.Add(string.Format("TinhTrang"), typeof(string));
            DateTime current = DateTime.Now;
            foreach (DataRow dr in dt.Rows)
            {
                if (!(dr[1] is DBNull) && current.CompareTo(DateTime.Parse(dr[1].ToString())) <= 0)
                    dr[2] = "Bận";
                else
                    dr[2] = "Rảnh";
            }
            return dt;
        }

        public string TaoMaDA()
        {
            string sqlStr = string.Format("SELECT max(MaDA)" +
                                            "FROM DuAN ");
            string temp = dbConn.LayDanhSach(sqlStr).Rows[0][0].ToString();
            return temp.Substring(0, 2) + (int.Parse(temp.Substring(2, 3)) + 1).ToString("D3");
        }
    }
}
