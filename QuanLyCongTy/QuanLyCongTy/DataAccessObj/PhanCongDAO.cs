using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public class PhanCongDAO
    {
        DBConnection dbConn = new DBConnection();
        string maPB;

        public PhanCongDAO( string maPB)
        {
            this.maPB = maPB;
        }
        public string GetMaNV(string HoTenNV)
        {
            string sqlStr = string.Format("SELECT MaNV FROM NhanVien Where HoTenNV = N'{0}'", HoTenNV);
            return dbConn.LayDanhSach(sqlStr).Rows[0][0].ToString();
        }
        public string GetMaCV(string TenCV)
        {
            string sqlStr = string.Format("SELECT MaCV FROM CongViec Where TenCV = N'{0}'", TenCV);
            return dbConn.LayDanhSach(sqlStr).Rows[0][0].ToString();
        }
        public string GetMaLPB()
        {
            string sqlStr = string.Format("SELECT MaLPB FROM PhongBan Where MaPB = '{0}'", maPB);
            return dbConn.LayDanhSach(sqlStr).Rows[0][0].ToString();
        }
        public List<string> LayDSTenNV()
        {
            string sqlStr = string.Format("SELECT HoTenNV FROM NhanVien WHERE MaPB = '{0}'", maPB);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            List<string> list = dt.AsEnumerable().Select(r => r.Field<string>("HoTenNV")).ToList();
            list.Sort();
            return list;
        }
        public List<string> LayDSCongViec()
        {
            string sqlStr = string.Format("SELECT TenCV FROM CongViec,PhongBan Where MaPB = '{0}' AND CongViec.MaLPB = PhongBan.MaLPB", maPB);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            List<string> list = dt.AsEnumerable().Select(r => r.Field<string>("TenCV")).ToList();
            list.Add("Khác");
            return list;
        }
        public DataTable LayDSTinhTrangNV()
        {
            string sqlStr = string.Format(
                "SELECT HoTenNV,Max(DeadLine) as DL " +
                "FROM ((SELECT MaNV,DeadLine  " +
                      "FROM PhanCong)  " +
                      "UNION " +
                      "(SELECT HoTro.MaNV,DeadLine  " +
                      "FROM HoTro,PhanCong  " +
                      "WHERE HoTro.MaDA = PhanCong.MaDA AND HoTro.MaCV = PhanCong.MaCV)) AS Q " +
                      "RIGHT OUTER JOIN NhanVien " +
                      "ON NhanVien.MaNV = Q.MaNV " +
                "Where NhanVien.MaPB = '{0}' " +
                "GROUP BY HoTenNV " +
                "ORDER BY DL",maPB);
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
        public DataTable LayDSTinhTrangNVTroGiup()
        {
            string sqlStr = string.Format(
                "SELECT HoTenNV,Max(DeadLine) as DL " +
                "FROM ((SELECT MaNV,DeadLine  " +
                      "FROM PhanCong)  " +
                      "UNION " +
                      "(SELECT HoTro.MaNV,DeadLine  " +
                      "FROM HoTro,PhanCong  " +
                      "WHERE HoTro.MaDA = PhanCong.MaDA AND HoTro.MaCV = PhanCong.MaCV)) AS Q " +
                      "RIGHT OUTER JOIN NhanVien " +
                      "ON NhanVien.MaNV = Q.MaNV " +
                      "JOIN PhongBan " +
                      "ON NhanVien.MaPB = PhongBan.MaPB " +
                "Where PhongBan.MaLPB = '{0}' " +
                "GROUP BY HoTenNV " +
                "ORDER BY DL", this.GetMaLPB());
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
        public PhanCong ThongTinPC(string MaCV,string MaDA)
        {
            string sqlStr = string.Format("SELECT HoTenNV, TenCV, TienDo ,NgayBD, DeadLine FROM PhanCong,NhanVien,CongViec " +
                                         "Where PhanCong.MaCV = '{0}' AND MaDA = '{1}' " +
                                         "AND PhanCong.MaNV = NhanVien.MaNV AND PhanCong.MaCV = CongViec.MaCV", MaCV,MaDA);
            DataRow dr = dbConn.LayDanhSach(sqlStr).Rows[0];
            return new PhanCong(dr[0].ToString(), MaDA,  dr[1].ToString(), "", int.Parse(dr[2].ToString()), DateTime.Parse(dr[3].ToString()), DateTime.Parse(dr[4].ToString()));
            
        }
        public string TaoMaCV()
        {
            string temp = maPB.Substring(2,2);
            string sqlStr = string.Format("SELECT max(MaCV)"+
                                            "FROM CongViec where MaCV like 'CV{0}%'",temp);
            temp = dbConn.LayDanhSach(sqlStr).Rows[0][0].ToString();
            return temp.Substring(0, 4) + (int.Parse(temp.Substring(4, 3)) + 1).ToString("D3");
        }
        public string ThemCV(string TenCV)
        {
            string MaCV = TaoMaCV();
            string LPB = "LPB" + maPB.Substring(2,2);
            string sqlStr = string.Format("INSERT INTO CongViec VALUES('{0}',N'{1}','{2}')",
                                           MaCV,TenCV,LPB);
            dbConn.ThucThi(sqlStr);
            return MaCV;

        }
        public void Sua(PhanCong pc)
        {
            //string MaCV = GetMaCV(pc.CongViec);
            string sqlStr = string.Format("UPDATE PhanCong SET  MaNV = '{2}', NgayBD = '{3}', DeadLine = '{4}' " +
                                          "WHERE MaDA = '{0}' AND MaCV = '{1}'",
                                            pc.MaDA, pc.CongViec, GetMaNV(pc.HoTenNV), pc.NgayBatDau.ToShortDateString(), pc.Deadline.ToShortDateString());
            
            dbConn.ThucThi(sqlStr);
        }
        public void ThemTroGiup(HoTro ht)
        {
            string sqlStr = string.Format("INSERT INTO HoTro VALUES('{0}', '{1}', '{2}')",ht.MaDA,ht.MaCV,ht.MaNV);
            dbConn.ThucThi(sqlStr);
        }
        public string DSTenNVThamGia(string MaCV, string MaDA)
        {
            string DSTenNVThamGia = ThongTinPC(MaCV, MaDA).HoTenNV;
            string sqlStr = string.Format("SELECT HoTenNV FROM HoTro,NhanVien " +
                                         "Where HoTro.MaCV = '{0}' AND MaDA = '{1}' " +
                                        "AND HoTro.MaNV = NhanVien.MaNV", MaCV, MaDA);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            dt.AsEnumerable().Select(r => r.Field<string>("HoTenNV")).ToList()
                .ForEach(hoten => DSTenNVThamGia += ", " + hoten);
            return DSTenNVThamGia;
            
        }

        DataProvider dataProvider = new DataProvider();
        public PhanCongDAO(){}
        public PhanCongModel GetPhanCongTheoMa(string MaCV, string MaDA)
        {
            string query = " SELECT * FROM PhanCong WHERE MaCV = @MaCV AND MaDA = @MaDA ";
            object[] para = new object[] { MaCV, MaDA };
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            DataRow dr = dt.Rows[0];
            return new PhanCongModel(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), DateTime.Parse(dr[4].ToString()), DateTime.Parse(dr[5].ToString()),
                    int.Parse(dr[6].ToString()), dr[7].ToString(), int.Parse(dr[8].ToString()), int.Parse(dr[9].ToString()));
        }
        public bool Them(PhanCongModel pc)
        {
            string query = "INSERT INTO PhanCong VALUES ( @MaDA , @MaCV , @MaNV , @MoTa , @NgayBD , @DealLine , @TienDo , @DanhGia , @ChamDiem , @TienThuong )";
            object[] para = new object[] { pc.MaDA, pc.MaCV, pc.MaNV, pc.MoTa, pc.NgayBD, pc.DeadLine, pc.TienDo, pc.Danhgia, pc.ChamDiem, pc.Thuong};
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }

        public bool Xoa(PhanCongModel pc)
        {
            string query = "DELETE FROM PhanCong WHERE MaCV = @MaCV AND MaDA = @MaDA ";
            object[] para = new object[] { pc.MaCV, pc.MaDA };
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }

        public List<PhanCongModel> ListPCChuaHTTheoDA(string maDA)
        {
            List<PhanCongModel> list = new List<PhanCongModel>();
            string query = "SELECT *FROM PhanCong WHERE MaDA = @MaDA AND TienDo < 100 ";
            object[] para = new object[] { maDA };
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(new PhanCongModel(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), DateTime.Parse(dr[4].ToString()), DateTime.Parse(dr[5].ToString()),
                    int.Parse(dr[6].ToString()), dr[7].ToString(), int.Parse(dr[8].ToString()), int.Parse(dr[9].ToString())));
            }
            return list;
        }
    }
}
