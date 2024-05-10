using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class CheckInModel
    {
        string MaNV;
        DateTime NgayCheckIn;
        TimeSpan GioCheckIn;

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public DateTime NgayCheckIn1 { get => NgayCheckIn; set => NgayCheckIn = value; }
        public TimeSpan GioCheckIn1 { get => GioCheckIn; set => GioCheckIn = value; }

        public CheckInModel(string maNV, DateTime ngayCheckIn, TimeSpan gioCheckIn)
        {
            MaNV = maNV;
            NgayCheckIn = ngayCheckIn;
            GioCheckIn = gioCheckIn;
        }
    }
}
