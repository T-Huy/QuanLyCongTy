using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class DuAnDAO
    {
        DBConnection dbConn = new DBConnection();
        DataProvider dataProvider = new DataProvider();

        public DataTable LayDanhSachDuAnChuaHT()
        {
            string sqlStr = string.Format("SELECT MaDA " +
                                           "FROM DuAn " +
                                           "WHERE MaDA IN (SELECT MaDA " +
                                                           "FROM PhanCong " +
                                                         " Where TienDo < 100) " +
                                                         " OR MaDA NOT IN (SELECT MaDA FROM PhanCong) ");
            return dbConn.LayDanhSach(sqlStr);
        }
        public List<DuAnModel> ListDuAnChuaHT()
        {
            List <DuAnModel> list = new List<DuAnModel>();
            string query = "SELECT * FROM DuAn WHERE ChamDiem = -1 ";
            DataTable dt = dataProvider.ExecuteQuery(query);
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(new DuAnModel(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),
                    DateTime.Parse(dr[5].ToString()), DateTime.Parse(dr[6].ToString()), dr[7].ToString(), int.Parse(dr[8].ToString()), double.Parse(dr[8].ToString())));
            }
            return list;
        }
        public List<DuAnModel> ListDuAnDaHT()
        {
            List<DuAnModel> list = new List<DuAnModel>();
            string query = "SELECT * FROM DuAn WHERE ChamDiem > 0 ";
            DataTable dt = dataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new DuAnModel(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),
                    DateTime.Parse(dr[5].ToString()), DateTime.Parse(dr[6].ToString()), dr[7].ToString(), int.Parse(dr[8].ToString()), double.Parse(dr[8].ToString())));
            }
            return list;
        }
        public DataTable LayDanhSachDuAnDaHT()
        {
            string sqlStr = string.Format("SELECT MaDA " +
                                           "FROM DuAn " +
                                           "WHERE MaDA NOT IN (SELECT MaDA " +
                                                           "FROM PhanCong " +
                                                         " Where TienDo < 100) " +
                                                         " AND MaDA IN (SELECT MaDA FROM PhanCong) ");
            return dbConn.LayDanhSach(sqlStr);
        }
        public string LayDiemDA(string MaDA)
        {
            string sqlStr = string.Format("SELECT ChamDiem FROM DuAn WHERE MaDA = '{0}'", MaDA);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString();
        }
        public string MaDALonNhat()
        {
            string query = "SELECT max(MaDA) FROM DuAN ";
            return dataProvider.ExecuteScalar(query).ToString();            
        }
        public bool Them(DuAnModel da)
        {
            string query = "INSERT INTO DuAn " +
                "VALUES ( @MaDA , @TenDuAn , @MoTa , @MaPB , @DiaDiem , @NgayBD , @DeadLine , @DanhGia , @ChamDiem , @Thuong )";
            object[] para = new object[] { da.MaDA, da.TenDuAn, da.MoTa, da.MaPB, da.DiaDiem, da.NgayBD, da.DeadLine, da.DanhGia, da.ChamDiem, da.Thuong };
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }
        public bool Xoa(DuAnModel da)
        {
            string query = "DELETE FROM DuAn WHERE MaDA = @MaDA ";
            object[] para = new object[] {da.MaDA };
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }
        public bool Sua(DuAnModel da)
        {
            string query = "UPDATE DuAn SET TenDuAn = @TenDuAn , MoTa = @MoTa ,MaPB = @MaPB , DiaDiem = @DiaDiem ,NgayBD = @NgayBD , DeadLine = @DeadLine , " +
                "DanhGia = @DanhGia , ChamDiem = @ChamDiem , Thuong = @Thuong WHERE MaDA = @MaDA ";
            object[] para = new object[] { da.TenDuAn, da.MoTa, da.MaPB, da.DiaDiem, da.NgayBD, da.DeadLine, da.DanhGia, da.ChamDiem, da.Thuong , da.MaDA};
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }
        public DuAnModel getDuAnTheoMa(string MaDA)
        {
            string query = "SELECT * FROM DuAn WHERE MaDA = @MaDA ";
            object[] para = new object[] { MaDA};
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            DataRow dr = dt.Rows[0];
            return new DuAnModel(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),
                DateTime.Parse(dr[5].ToString()), DateTime.Parse(dr[6].ToString()), dr[7].ToString(), int.Parse(dr[8].ToString()), double.Parse(dr[8].ToString()));
        }
        public int GetTienDo(DuAnModel da)
        {
            string query = "SELECT AVG(TienDo) FROM  PhanCong WHERE MaDA = @MaDA ";
            object[] para = new object[] { da.MaDA };
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            if (!(dt.Rows[0][0] is DBNull))
                return (int)dt.Rows[0][0];
            else return 0;
        }
    }
}
