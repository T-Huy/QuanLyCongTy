using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public class LichDAO
    {
        DBConnection dbConn = new DBConnection();
        public LichDA KiemtraDL(DateTime ngaythang)
        {
            string strsql = String.Format("SELECT MaDA, TenDuAn, NgayBD, DeadLine FROM DuAn WHERE DeadLine = '{0}'", ngaythang);
            DataTable dt = dbConn.LayDanhSach(strsql);
            DataRow dr = null;
            if (dt.Rows.Count != 0)
            {
                dr = dt.Rows[0];
                return new LichDA(dr[0].ToString(), dr[1].ToString(), DateTime.Parse(dr[2].ToString()), DateTime.Parse(dr[3].ToString()));
            }
            return null;
        }

        public LichDA KiemtraBD(DateTime ngaythang)
        {
            string strsql = String.Format("SELECT MaDA, TenDuAn, NgayBD, DeadLine FROM DuAn WHERE NgayBD = '{0}'", ngaythang);
            DataTable dt = dbConn.LayDanhSach(strsql);
            DataRow dr = null;
            if (dt.Rows.Count != 0)
            {
                dr = dt.Rows[0];
                return new LichDA(dr[0].ToString(), dr[1].ToString(), DateTime.Parse(dr[2].ToString()), DateTime.Parse(dr[3].ToString()));
            }
            return null;
        }
    }
}