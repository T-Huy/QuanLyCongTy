using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class DuAn
    {
        string maDA;
        string tenDA;
        string maPhongBan;
        string diaDiem;
        DateTime thoiHan;
        DateTime ngayBD;
        string moTa;
        public string MaDA { get { return maDA; } }
        public string TenDA { get { return tenDA; } }
        public string MaPhongBan { get { return maPhongBan; } }
        public string DiaDiem { get { return diaDiem; } }
        public DateTime ThoiHan { get { return thoiHan; } }
        public DateTime NgayBD { get { return ngayBD; } }
        public string MoTa { get { return moTa; } }
        public DuAn(string maDA, string tenDA, string maPhongBan, string diaDiem, DateTime thoiHan, DateTime ngayBD, string moTa)
        {
            this.maDA = maDA;
            this.tenDA = tenDA;
            this.maPhongBan = maPhongBan;
            this.diaDiem = diaDiem;
            this.ngayBD = ngayBD;
            this.thoiHan = thoiHan;
            this.moTa = moTa;
            
        }
    }
}
