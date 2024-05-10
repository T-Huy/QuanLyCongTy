using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class HoTroModel
    {
        string maDA;
        string maCV;
        string maNV;
        public string MaDA { get => maDA; set => maDA = value; }
        public string MaCV { get => maCV; set => maCV = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public HoTroModel(string maDA, string maCV, string maNV)
        {
            this.maDA = maDA;
            this.maCV = maCV;
            this.maNV = maNV;
        }
    }
}
