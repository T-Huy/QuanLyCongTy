using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public class NhanXetDADAO
    {
        DBConnection dbConn = new DBConnection();

        public NhanXetDA LayThongTinDA(string MaDA)
        {
            string sqlStr = string.Format("SELECT TenDuAn, DanhGia, ChamDiem FROM DuAN WHERE MaDA = '{0}'", MaDA);
            DataRow dr = dbConn.LayDanhSach(sqlStr).Rows[0];

            if (dr[1] is null) dr[1] = "";

            return new NhanXetDA(
                MaDA, dr[0].ToString(), dr[1].ToString(), float.Parse(dr[2].ToString()));
        }

        public void Sua(NhanXetDA nx)
        {
            string sqlStr = string.Format("UPDATE DuAn SET  DanhGia = N'{0}', ChamDiem = '{1}' WHERE MaDA = '{2}'", nx.DanhGia, nx.ChamDiem, nx.MaDA);
            dbConn.ThucThi(sqlStr);
        }

        public string LayChamDiem(float Diem)
        {
            if (Diem == 0) return "";
            if (Diem == 10) return "Tệ";
            if (Diem == 20) return "Tệ";
            if (Diem == 30) return "Chưa tốt";
            if (Diem == 40) return "Chưa tốt";
            if (Diem == 50) return "Tốt";
            if (Diem == 60) return "Tốt";
            if (Diem == 70) return "Rất tốt";
            if (Diem == 80) return "Rất tốt";
            if (Diem == 90) return "Xuất sắc";
            if (Diem == 100) return "Xuất sắc";
            return "";
        }
    }
}
