using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class CheckoutDAO
    {
        DBConnection dbConn = new DBConnection();
        string ma;
        public CheckoutDAO(string ma)
        {
            this.ma = ma;
        }
        public bool KTSom(TimeSpan time)
        {
            return time.CompareTo(new TimeSpan(17, 0, 0)) < 0;
        }
        public DataTable LayDanhSachCheckout()
        {
            string sqlStr = string.Format("SELECT NgayCheckout, GioCheckout FROM Checkout Where MaNV = '{0}'", ma);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            dt.Columns.Add(string.Format("Nhanxet", typeof(string)));
            foreach (DataRow dr in dt.Rows)
            {
                TimeSpan time = DateTime.Parse(dr[1].ToString()).TimeOfDay;
                if (KTSom(time))
                    dr[2] = string.Format("Về sớm");
                else
                    dr[2] = string.Format("Đúng giờ");
            }
            return dt;
        }
        public bool KTDiemDanh(DateTime current)
        {
            DataTable dt = LayDanhSachCheckout();
            foreach (DataRow dr in dt.Rows)
            {
                DateTime datetime = DateTime.Parse(dr[0].ToString());
                if (datetime.Date.Equals(current.Date))
                    return false;
            }
            return true;
        }
        public void Them(DateTime current)
        {
            string sqlStr = string.Format("INSERT INTO Checkout VALUES('{0}' , '{1}', '{2}')",
                ma, current.ToString("yyyy-MM-dd"), current.ToString("HH:mm:ss"));
            dbConn.ThucThi(sqlStr);
        }
    }
}
