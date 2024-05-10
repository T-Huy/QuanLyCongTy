using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class CongViecDAO
    {
        DataProvider dataProvider = new DataProvider();
        public List<CongViecModel> ListCongViecTheoLPB(string MaLPB)
        {
            List<CongViecModel> list = new List<CongViecModel>();
            string query = "SELECT * FROM CongViec WHERE MaLPB = @MaLPB ";
            object[] para = new object[] {MaLPB };
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new CongViecModel(dr[0].ToString(), dr[1].ToString(), dr[2].ToString()));
            }
            return list;
        }
        public string GetMaxMaCVTheoLPB(string MaLPB)
        {
            string query = "SELECT MAX(MaCV) FROM CongViec WHERE MaLPB = @MaLPB ";
            object[] para = new object[] { MaLPB };
            return dataProvider.ExecuteScalar(query,para).ToString();
        }

        public CongViecModel GetCongViecTheoMaCV(string MaCV)
        {
            string query = " SELECT * FROM CongViec WHERE MaCV =   @MaCV     ";
            object[] para = new object[] { MaCV };
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            DataRow dr = dt.Rows[0];
            return new CongViecModel(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
        }
        public bool Them(CongViecModel cv)
        {
            string query = "INSERT INTO CongViec VALUES ( @MaCV , @TenCV , @MaLPB )";
            object[] para = new object[] { cv.MaCV, cv.TenCV, cv.MaLPB};
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }
    }
}
