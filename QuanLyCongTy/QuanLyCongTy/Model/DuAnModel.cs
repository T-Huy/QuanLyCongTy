using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class DuAnModel
    {
        string maDA;
        string tenDuAn;
        string moTa;
        string maPB;
        string diaDiem;
        DateTime ngayBD;
        DateTime deadLine;
        string danhGia;
        int chamDiem;
        double thuong;

        public string MaDA { get => maDA; set => maDA = value; }
        public string TenDuAn { get => tenDuAn; set => tenDuAn = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string MaPB { get => maPB; set => maPB = value; }
        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public DateTime DeadLine { get => deadLine; set => deadLine = value; }
        public string DanhGia { get => danhGia; set => danhGia = value; }
        public int ChamDiem { get => chamDiem; set => chamDiem = value; }
        public double Thuong { get => thuong; set => thuong = value; }

        public DuAnModel(string maDA, string tenDuAn, string moTa, string maPB, string diaDiem, 
            DateTime ngayBD, DateTime deadLine, string danhGia, int chamDiem, double thuong)
        {
            this.maDA = maDA;
            this.tenDuAn = tenDuAn;
            this.moTa = moTa;
            this.maPB = maPB;
            this.diaDiem = diaDiem;
            this.ngayBD = ngayBD;
            this.deadLine = deadLine;
            this.danhGia = danhGia;
            this.chamDiem = chamDiem;
            this.thuong = thuong;
        }
    }
}
