using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class TDCaNhan
    {
        string maNV;
        string maDA;
        string tenNV;
        string congViec;
        string tienDO;
        string chamDiem;
        DateTime ngayBD;
        DateTime deadLine;


        public string MaNV { get { return maNV; } }
        public string MaDA { get { return maDA; } }
        public string TenNV { get { return tenNV; } }
        public string CongViec { get { return congViec; } }
        public string TienDo { get { return tienDO; } }
        public string ChamDiem { get { return chamDiem; } }
        public DateTime NgayBD { get { return ngayBD; } }
        public DateTime DeadLine { get { return deadLine; } }

        public TDCaNhan(string maNV, string maDA, string tenNV, string congViec, string tienDO, string chamDiem, DateTime ngayBD, DateTime deadLine)
        {
            this.maNV = maNV;
            this.maDA = maDA;
            this.tenNV = tenNV;
            this.congViec = congViec;
            this.tienDO = tienDO;
            this.chamDiem = chamDiem;
            this.ngayBD = ngayBD;
            this.deadLine = deadLine;
        }
    }
}
