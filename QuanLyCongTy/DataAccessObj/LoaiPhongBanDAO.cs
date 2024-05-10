using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class LoaiPhongBanDAO
    {
        DataProvider dataProvider = new DataProvider();
        public List<LoaiPhongBanModel> ListLoaiPB()
        {
            List <LoaiPhongBanModel> list = new List<LoaiPhongBanModel>();
            string query = "SELECT * FROM LoaiPhongBan WHERE NOT MaLPB = 'LPBQL' ";
            DataTable dt = dataProvider.ExecuteQuery(query);
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(new LoaiPhongBanModel(dr[0].ToString(), dr[1].ToString()));
            }
            return list;
        }
    }
}
