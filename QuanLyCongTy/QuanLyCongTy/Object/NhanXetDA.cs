using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class NhanXetDA
    {
        string maDA;
        string tenDA;
        string danhGia;
        float chamDiem;

        public string MaDA { get { return maDA; } }
        public string TenDA { get { return tenDA; } }
        public string DanhGia { get { return danhGia ; } }
        public float ChamDiem { get { return chamDiem; } }
        public NhanXetDA(string maDA, string tenDA, string danhGia, float chamDiem)
        {
            this.maDA = maDA;
            this.tenDA = tenDA;
            this.danhGia = danhGia;
            this.chamDiem = chamDiem;
        }
    }
}
