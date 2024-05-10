using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class ThongTin
    {
        string maNV;
        string hoTenNV;
        string diaChi;
        string sdt;
        DateTime ngaySinh;
        string gioiTinh;
        string cccd;
        string email;
        string maPB;
        string tenPB;
        string chucVu;


        public string MaNV { get { return maNV; } }
        public string HoTenNV { get { return hoTenNV; } }
        public string DiaChi { get { return diaChi; } }
        public string Sdt { get { return sdt; } }
        public DateTime NgaySinh { get { return ngaySinh; } }
        public string GioiTinh { get { return gioiTinh; } } 
        public string Cccd { get { return cccd; } }
        public string Email { get { return email; } }
        public string MaPB { get { return maPB; } }
        public string TenPB { get { return tenPB; } }
        public string ChucVu { get { return chucVu; } }

        public ThongTin(string maNV, string hoTenNV, string diaChi, string sdt, DateTime ngaySinh,
                                string gioiTinh,string cccd, string email, string maPB, string tenPB, string chucVu)
        {
            this.maNV = maNV;
            this.hoTenNV = hoTenNV;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.cccd = cccd;
            this.email = email;
            this.maPB = maPB;
            this.tenPB = tenPB;
            this.chucVu = chucVu;
        }
    }
}
