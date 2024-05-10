using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class XinNghiModel
    {
        string maNV;
        DateTime ngayBD;
        int soNgayNghi;
        string lyDo;
        int heSoDuyet;

        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public int SoNgayNghi { get => soNgayNghi; set => soNgayNghi = value; }
        public string LyDo { get => lyDo; set => lyDo = value; }
        public int HeSoDuyet { get => heSoDuyet; set => heSoDuyet = value; }

        public XinNghiModel(string maNV, DateTime ngayBD, int soNgayNghi, string lyDo, int heSoDuyet)
        {
            this.maNV = maNV;
            this.ngayBD = ngayBD;
            this.soNgayNghi = soNgayNghi;
            this.lyDo = lyDo;
            this.heSoDuyet = heSoDuyet;
        }
    }
}
