using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class CheckinDAO
    {
        DBConnection dbConn = new DBConnection();
        string ma;
        public CheckinDAO(string ma)
        {
            this.ma = ma;
        }
        public bool KTTre(TimeSpan time)
        {
            return time.CompareTo(new TimeSpan(8, 0, 0)) > 0;
        }
        public DataTable LayDanhSachCheckin()
        {
            string sqlStr = string.Format("SELECT NgayCheckin, GioCheckin FROM Checkin Where MaNV = '{0}'", ma);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            dt.Columns.Add(string.Format("Nhanxet"), typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                TimeSpan time = TimeSpan.Parse(dr[1].ToString());//.TimeOfDay;
                if (KTTre(time))
                    dr[2] = string.Format("Trễ");
                else
                    dr[2] = string.Format("Đúng giờ");
            }
            return dt;
        }
        public DataTable LayDSPieChar()
        {
            DataTable dt = LayDanhSachCheckin();
            int Tre = 0;
            int DungGio = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[1].Equals("Trễ"))
                    Tre++;
                else
                    DungGio++;
            }
            DataTable newdt = new DataTable();
            newdt.Columns.Add("NhanXet");
            newdt.Columns.Add("SL",typeof(int));
            DataRow row1 = newdt.NewRow();
            row1["NhanXet"] = string.Format("Trễ");
            row1["SL"] = Tre;
            newdt.Rows.Add(row1);
            DataRow row2 = newdt.NewRow();
            row2["NhanXet"] = string.Format("Đúng giờ");
            row2["SL"] = DungGio;
            newdt.Rows.Add(row2);
            
            return newdt;
        }
        public bool KTDiemDanh(DateTime current)
        {
            DataTable dt = LayDanhSachCheckin();
            foreach (DataRow dr in dt.Rows)
            {
                DateTime datetime = DateTime.Parse(dr[0].ToString());
                if(datetime.Date.Equals(current.Date))
                    return false;
            }
            return true;
        }
        public void Them(DateTime current)
        { 
            string sqlStr = string.Format("INSERT INTO Checkin VALUES('{0}' , '{1}', '{2}')",
                ma, current.ToString("yyyy-MM-dd"), current.ToString("HH:mm:ss"));
            dbConn.ThucThi(sqlStr);
        }
    }
}
