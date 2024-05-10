using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class PhongBanModel
    {
        string maPB;
        string tenPB;
        string maLPB;
        string maTrPhong;
        string viTri;
        public string MaPB { get => maPB; set => maPB = value; }
        public string TenPB { get => tenPB; set => tenPB = value; }
        public string MaLPB { get => maLPB; set => maLPB = value; }
        public string MaTrPhong { get => maTrPhong; set => maTrPhong = value; }
        public string ViTri { get => viTri; set => viTri = value; }
        public PhongBanModel(string maPB, string tenPB, string maLPB, string maTrPhong, string viTri)
        {
            this.maPB = maPB;
            this.tenPB = tenPB;
            this.maLPB = maLPB;
            this.maTrPhong = maTrPhong;
            this.viTri = viTri;
        }
    }
}
