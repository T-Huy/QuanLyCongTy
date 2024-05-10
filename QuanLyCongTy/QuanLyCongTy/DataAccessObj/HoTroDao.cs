using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy.DataAccessObj
{
    internal class HoTroDao
    {
        DataProvider dataProvider = new DataProvider();
        public bool Them(HoTroModel ht)
        {
            string query = "INSERT INTO HoTro VALUES ( @MaDA , @TenCV , @MaNV )";
            object[] para = new object[] { ht.MaDA, ht.MaCV, ht.MaNV };
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }
    }
}
