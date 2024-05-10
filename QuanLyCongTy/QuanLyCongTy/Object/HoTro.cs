using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class HoTro
    {
        string maDA;
        string maCV;
        string maNV;
        public string MaDA { get { return maDA; } }
        public string MaCV { get { return maCV; } }
        public string MaNV { get { return maNV; } }

        public HoTro(string maDA, string maCV, string maNV)
        {
            this.maDA = maDA;
            this.maCV = maCV;
            this.maNV = maNV;
        }
    }
}
