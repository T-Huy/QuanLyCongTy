using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class NhanVienDAO
    {
        DBConnection dbConn = new DBConnection();
        public string GetTenNV(string MaNV)
        {
            string sqlStr = string.Format("SELECT HoTenNV FROM NhanVien Where MaNV = '{0}'", MaNV);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString();
        }
        DataProvider dataProvider = new DataProvider();
        public DataTable DSNhanVienBanTheoPB(DuAnModel da)
        {
            string query = "SELECT HoTenNV, NgayBD, DeadLine " +
                            "FROM((SELECT MaNV, NgayBD, DeadLine FROM PhanCong) UNION " +
                                    "(SELECT HoTro.MaNV, NgayBD, DeadLine FROM HoTro, PhanCong " +
                                    "WHERE HoTro.MaDA = PhanCong.MaDA AND HoTro.MaCV = PhanCong.MaCV)) AS Q " +
                                    "JOIN NhanVien ON NhanVien.MaNV = Q.MaNV " +
                            "WHERE NhanVien.MaPB = @MaPB AND DeadLine >= @NgayBD AND NgayBD <= @DeadLine ";
            object[] para = new object[] { da.MaPB, da.NgayBD, da.DeadLine };
            return dataProvider.ExecuteQuery(query, para);
        }
        public List<NhanVienModel> ListNhanVienRanhTheoPB(DuAnModel da)
        {
            List<NhanVienModel> list = new List<NhanVienModel>();
            string query = "SELECT * " +
                        "FROM NhanVien " +
                        "WHERE MaNV NOT IN " +
                            "(SELECT MaNV " +
                            "FROM ((SELECT MaNV, NgayBD, DeadLine FROM PhanCong) UNION " +
                                "(SELECT HoTro.MaNV, NgayBD, DeadLine FROM HoTro, PhanCong " +
                                "WHERE HoTro.MaDA = PhanCong.MaDA AND HoTro.MaCV = PhanCong.MaCV)) AS Q " +
                            "Where DeadLine >= @NgayBD AND NgayBD <= @DeadLine ) " +
                            "AND MaNV NOT IN(SELECT MaTrPhong FROM PhongBan) " +
                            "AND MaPB = @MaPB ";
            object[] para = new object[] { da.NgayBD, da.DeadLine, da.MaPB};
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new NhanVienModel(dr[0].ToString(), dr[1].ToString(),dr[2].ToString(), dr[3].ToString(), DateTime.Parse(dr[4].ToString()),
                    dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString()));
            }
            return list;
        }
        public DataTable DSNhanVienRanhTheoLPB(PhongBanModel pb, PhanCongModel pc)
        {
            string query = "SELECT MaNV, HoTenNV, TenPB " +
                        "FROM NhanVien JOIN PhongBan ON NhanVien.MaPB = PhongBan.MaPB " +
                        "WHERE MaNV NOT IN " +
                            "(SELECT MaNV " +
                            "FROM ((SELECT MaNV, NgayBD, DeadLine FROM PhanCong) UNION " +
                                "(SELECT HoTro.MaNV, NgayBD, DeadLine FROM HoTro, PhanCong " +
                                "WHERE HoTro.MaDA = PhanCong.MaDA AND HoTro.MaCV = PhanCong.MaCV)) AS Q " +
                            "Where DeadLine >= @NgayBD AND NgayBD <= @DeadLine ) " +
                            "AND MaNV NOT IN(SELECT MaTrPhong FROM PhongBan) " +
                            "AND MaLPB = @MaLPB ";
            object[] para = new object[] { pc.NgayBD, pc.DeadLine, pb.MaLPB};
            return dataProvider.ExecuteQuery(query, para);
        }

        public NhanVienModel GetNhanVienTheoMaNV(string MaNV)
        {
            string query = " SELECT * FROM NhanVien WHERE MaNV = @MaNV ";
            object[] para = new object[] { MaNV };
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            DataRow dr = dt.Rows[0];
            return new NhanVienModel(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), DateTime.Parse(dr[4].ToString()),
                    dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
        }

        public XinNghiModel GetXinNghi()
        {
            string query = " SELECT * FROM XinNghi";
            DataTable dt = dataProvider.ExecuteQuery(query);
            DataRow dr = dt.Rows[0];
            return new XinNghiModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString(), int.Parse(dr[4].ToString()));
        }

        public XinNghiModel GetXinNghiTheoMaNV(string MaNV)
        {
            string query = " SELECT * FROM XinNghi WHERE MaNV = @MaNV ";
            object[] para = new object[] { MaNV };
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            DataRow dr = dt.Rows[0];
            return new XinNghiModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString(), int.Parse(dr[4].ToString()));
        }

        public List<NhanVienModel> ListNhanVienThucHienDA(PhanCongModel pc)
        {
            List<NhanVienModel> list = new List<NhanVienModel>();
            string query = "SELECT NhanVien.MaNV, NhanVien.HoTenNV, NhanVien.DiaChi, NhanVien.Sdt, NhanVien.NgaySinh, NhanVien.Phai, NhanVien.Cccd, NhanVien.Email, NhanVien.MaPB, NhanVien.MaLuong " +
                "FROM NhanVien, PhanCong " +
                "WHERE NhanVien.MaNV = PhanCong.MaNV  AND PhanCong.MaDA = @MaDA ";
            object[] para = new object[] { pc.MaDA };
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new NhanVienModel(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), DateTime.Parse(dr[4].ToString()),
                    dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString()));
            }
            return list;
        }

    }
}
