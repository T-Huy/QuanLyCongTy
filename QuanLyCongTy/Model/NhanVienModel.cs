using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class NhanVienModel
    {
        string maNV;
        string hoTenNV;
        string diaChi;
        string sdt;
        DateTime ngaySinh;
        string phai;
        string cccd;
        string email;
        string maPB;
        string maLuong;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Phai { get => phai; set => phai = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Email { get => email; set => email = value; }
        public string MaPB { get => maPB; set => maPB = value; }
        public string MaLuong { get => maLuong; set => maLuong = value; }

        public NhanVienModel(string maNV, string hoTenNV, string diaChi, string sdt, DateTime ngaySinh, string phai, string cccd, string email, string maPB, string maLuong)
        {
            this.maNV = maNV;
            this.hoTenNV = hoTenNV;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.ngaySinh = ngaySinh;
            this.phai = phai;
            this.cccd = cccd;
            this.email = email;
            this.maPB = maPB;
            this.maLuong = maLuong;
        }
    }
}
