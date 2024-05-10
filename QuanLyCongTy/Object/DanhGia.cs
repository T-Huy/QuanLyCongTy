using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class DanhGia
    {
        string maNV;
        string maDA;
        string nhanXet;
        string chamCong;

        public string MaNV { get { return maNV; } }
        public string MaDA { get { return maDA; } }
        public string NhanXet { get { return nhanXet; } }
        public string ChamCong { get { return chamCong; } }

        public DanhGia(string maNV, string maDA, string nhanXet, string chamCong)
        {
            this.maNV = maNV;
            this.maDA = maDA;
            this.nhanXet = nhanXet;
            this.chamCong = chamCong;
        }
    }
}
