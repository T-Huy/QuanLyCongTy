using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class PhongBanDAO
    {
        DataProvider dataProvider = new DataProvider();

        public PhongBanModel GetPhongBanTheoMaPB(string MaPB)
        {
            string query = "SELECT * FROM PhongBan WHERE MaPB = @MaPB ";
            object[] para = new object[] { MaPB};
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            DataRow dr = dt.Rows[0];
            return new PhongBanModel(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
        }
        public List<PhongBanModel> ListPhongBanTheoLPB(string MaLPB, DateTime NgayBD, DateTime DeadLine)
        {            
            List<PhongBanModel> list = new List<PhongBanModel>();
            string query = "SELECT * "+
                            "FROM PhongBan " +
                            "WHERE NOT MaLPB = 'LPBQL' AND MaLPB = @MaLPB " +
                                "AND MaPB NOT IN(SELECT MaPB FROM DuAn " +
                                "WHERE DeadLine >= @NgayBD AND NgayBD <= @DeadLine )";
            object[] para = new object[] { MaLPB, NgayBD, DeadLine};
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new PhongBanModel(dr[0].ToString(), dr[1].ToString(),
                        dr[2].ToString(), dr[3].ToString(), dr[4].ToString()));
            }
            return list;
        }
        public DataTable DSTinhTrangPBTheoLPB(string MaLPB, DateTime NgayBD, DateTime DeadLine)
        {
            string query = "SELECT TenPB, TenDuAn, DeadLine, NgayBD " +
                            "FROM DuAn JOIN PhongBan ON DuAn.MaPB = PhongBan.MaPB " +
                            "WHERE DeadLine >= @NgayBD AND NgayBD <= @DeadLine AND MaLPB = @MaLPB ";
            object[] para = new object[] { NgayBD, DeadLine, MaLPB };
            return  dataProvider.ExecuteQuery(query, para);
        }

        public List<PhongBanModel> ListPhongBanTheoLPB2(string MaLPB, string MaDA, DateTime NgayBD, DateTime DeadLine)
        {
            List<PhongBanModel> list = new List<PhongBanModel>();
            string query = "SELECT * " +
                            "FROM PhongBan " +
                            "WHERE NOT MaLPB = 'LPBQL' AND MaLPB = @MaLPB " +
                                "AND MaPB NOT IN(SELECT MaPB FROM DuAn " +
                                "WHERE DeadLine >= @NgayBD AND NgayBD <= @DeadLine AND NOT MaDA = @MaDA )";
            object[] para = new object[] { MaLPB, NgayBD, DeadLine, MaDA };
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new PhongBanModel(dr[0].ToString(), dr[1].ToString(),
                        dr[2].ToString(), dr[3].ToString(), dr[4].ToString()));
            }
            return list;
        }

        public DataTable DSTinhTrangPBTheoLPB2(string MaLPB, string MaDA, DateTime NgayBD, DateTime DeadLine)
        {
            string query = "SELECT TenPB, TenDuAn, DeadLine, NgayBD " +
                            "FROM DuAn JOIN PhongBan ON DuAn.MaPB = PhongBan.MaPB " +
                            "WHERE DeadLine >= @NgayBD AND NgayBD <= @DeadLine AND MaLPB = @MaLPB AND NOT MaDA = @MaDA ";
            object[] para = new object[] { NgayBD, DeadLine, MaLPB, MaDA };
            return dataProvider.ExecuteQuery(query, para);
        }
    }
}
