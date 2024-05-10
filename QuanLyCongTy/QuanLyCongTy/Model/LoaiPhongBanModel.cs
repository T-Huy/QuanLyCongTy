using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class LoaiPhongBanModel
    {
        string maLPB;
        string tenLPB;
        public string MaLPB { get => maLPB; set => maLPB = value; }
        public string TenLPB { get => tenLPB; set => tenLPB = value; }
        public LoaiPhongBanModel(string maLPB, string tenLPB)
        {
            this.maLPB = maLPB;
            this.tenLPB = tenLPB;
        }
    }
}
