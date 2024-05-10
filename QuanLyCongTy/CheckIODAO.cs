using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class CheckIODAO
    {
        DataProvider dataProvider = new DataProvider();
        public DataTable LayDanhSachCheckIO(NhanVienModel nv)
        {
            string query = "SELECT NgayCheckin, GioCheckin, GioCheckout, (CASE "+
                            " WHEN GioCheckin > '08:00:00' AND GioCheckout< '17:00:00' THEN N'Trễ, Về Sớm' "+
                            " ELSE CASE "+
                                " WHEN GioCheckin > '08:00:00' THEN N'Trễ' "+
                                " WHEN GioCheckout< '17:00:00' THEN N'Về sớm' "+
                                " ELSE N'Đúng Giờ' END END) as TrangThai "+
                            " FROM Checkin LEFT OUTER JOIN Checkout ON Checkin.NgayCheckin = Checkout.NgayCheckout AND Checkin.MaNV = Checkout.MaNV "+
                            " WHERE Checkin.MaNV = @MaNV ";
            object[] para = new object[] { nv.MaNV };
            return dataProvider.ExecuteQuery(query, para);
        }

        public bool CheckIn(NhanVienModel nv)
        {
            DateTime current = DateTime.Now;
            string query = "INSERT INTO Checkin VALUES( @MaNV , @NgayCI , @GioCI )";
            object[] para = new object[] { nv.MaNV, current.Date, current.ToShortTimeString() };
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }

        public bool CheckOUT(NhanVienModel nv)
        {
            DateTime current = DateTime.Now;
            string query = "INSERT INTO Checkout VALUES( @MaNV , @NgayCI , @GioCI )";
            object[] para = new object[] { nv.MaNV, current.Date, current.ToShortTimeString() };
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }

        public bool KiemTraCI(NhanVienModel nv)
        {
            DateTime current = DateTime.Now;
            string query = " SELECT * FROM Checkin WHERE MaNV = @MaNV and NgayCheckin = @NgayCI ";
            object[] para = new object[] { nv.MaNV, current.Date };
            return dataProvider.ExecuteScalar(query, para) is null;
        }

        public bool KiemTraCO(NhanVienModel nv)
        {
            DateTime current = DateTime.Now;
            string query = " SELECT * FROM Checkout WHERE MaNV = @MaNV and NgayCheckout = @NgayCO ";
            object[] para = new object[] { nv.MaNV, current.Date };
            return dataProvider.ExecuteScalar(query, para) is null;
        }
    }
}
