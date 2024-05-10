using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class ThemDA
    {
        string maDA;
        string tenDA;
        string moTa;
        string tenLPB;
        string tenPB;
        string diaDiem;
        DateTime ngayBD;
        DateTime deadLine;

        public string MaDA { get { return maDA; } }
        public string TenDA { get { return tenDA; } }
        public string MoTa { get { return moTa; } }
        public string TenLPB { get { return tenLPB; } }
        public string TenPb { get { return tenPB; } }
        public string DiaDiem { get { return diaDiem; } }
        public DateTime NgayBD { get { return ngayBD; } }
        public DateTime DeadLine { get { return deadLine; } }

        public ThemDA(string maDA, string tenDA, string moTa, string tenLPB, string tenPB, string diaDiem, DateTime ngayBD, DateTime deadLine)
        {
            this.maDA = maDA;
            this.tenDA = tenDA;
            this.moTa = moTa;
            this.tenLPB = tenLPB;
            this.tenPB = tenPB;
            this.diaDiem = diaDiem;
            this.ngayBD = ngayBD;
            this.deadLine = deadLine;
        }
    }
}
