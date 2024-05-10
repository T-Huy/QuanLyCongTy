using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class LichDA
    {
        string maDA;
        string tenDuAn;
        DateTime ngayBD;
        DateTime deadLine;

        public string MaDA { get { return maDA; } }
        public string TenDuAn { get { return tenDuAn; } }
        public DateTime NgayBD { get { return ngayBD; } }
        public DateTime DeadLine { get { return deadLine; } }

        public LichDA(string maDA, string tenDuAn, DateTime ngayBD, DateTime deadLine)
        {
            this.maDA = maDA;
            this.tenDuAn = tenDuAn;
            this.ngayBD = ngayBD;
            this.deadLine = deadLine;
        }
    }
}
