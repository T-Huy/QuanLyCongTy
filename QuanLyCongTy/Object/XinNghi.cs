using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class XinNghi
    {
        string maNV;
        DateTime ngayBD;
        int soNgayNghi;
        string lyDo;
        int heSoDuyet;
        
        public string MaNV { get { return maNV; } }
        public DateTime NgayBD { get { return ngayBD; } }
        public int SoNgayNghi { get { return soNgayNghi; } }
        public string LyDo { get { return lyDo; } }
        public int HeSoDuyet { get { return heSoDuyet; } }


        public XinNghi(string maNV, DateTime ngayBD, int soNgayNghi, string lyDo, int heSoDuyet)
        {
            this.maNV = maNV;
            this.ngayBD = ngayBD;
            this.soNgayNghi = soNgayNghi;
            this.lyDo = lyDo;
            this.heSoDuyet = heSoDuyet;
        }
    }
}
