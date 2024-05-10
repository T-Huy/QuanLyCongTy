using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class CongViecModel
    {
        string maCV;
        string tenCV;
        string maLPB;

        public string MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
        public string MaLPB { get => maLPB; set => maLPB = value; }

        public CongViecModel(string maCV, string tenCV, string maLPB)
        {
            this.maCV = maCV;
            this.tenCV = tenCV;
            this.maLPB = maLPB;
        }
    }
}
