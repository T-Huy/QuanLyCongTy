using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class CheckOutModel
    {
        string MaNV;
        DateTime NgayCheckOut;
        TimeSpan GioCheckOut;

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public DateTime NgayCheckOut1 { get => NgayCheckOut; set => NgayCheckOut = value; }
        public TimeSpan GioCheckOut1 { get => GioCheckOut; set => GioCheckOut = value; }

        public CheckOutModel(string maNV, DateTime ngayCheckOut, TimeSpan gioCheckOut)
        {
            MaNV = maNV;
            NgayCheckOut = ngayCheckOut;
            GioCheckOut = gioCheckOut;
        }
    }
}
