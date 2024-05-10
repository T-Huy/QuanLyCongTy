using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace QuanLyCongTy
{
   public class TienDoDA
    {
        string maDA;
        string tenDuAn;
        string maPB;
        string tenPB;
        DateTime ngayBD;
        DateTime ngayKT;

        public string MaDA { get { return maDA; } }
        public string TenDuAn { get { return tenDuAn; } }
        public string MaPB { get { return maPB; } }
        public string TenPB {  get { return tenPB; } }
        public DateTime NgayBD { get { return ngayBD; } }
        public DateTime NgayKT { get { return ngayKT; } }

        public TienDoDA(string maDA, string tenDuAn, string maPB, string tenPB, DateTime ngayBD, DateTime ngayKT)
        {
            this.maDA = maDA;
            this.tenDuAn = tenDuAn;
            this.maPB = maPB;
            this.tenPB = tenPB;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
        }
    }
}
