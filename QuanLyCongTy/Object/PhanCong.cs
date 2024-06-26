﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class PhanCong
    {
        string maDA;
        string congViec;
        string hoTenNV;
        string cVMoi;
        int tienDo;
        DateTime ngayBatDau;
        DateTime deadline;

        public string HoTenNV { get { return hoTenNV; } }
        public string MaDA { get { return maDA; } }
        public string CongViec { get { return congViec; } }
        public string CVMoi { get { return cVMoi; } }
        public int TienDo { get { return tienDo; } }    
        public DateTime NgayBatDau {get {return ngayBatDau;}}
        public DateTime Deadline { get { return deadline; } }

        public PhanCong(string hoTenNV, string maDA, string congViec, string cVMoi,
            int tienDo, DateTime NgayBatDau, DateTime deadline)
        {
            this.hoTenNV = hoTenNV;
            this.maDA = maDA;
            this.congViec = congViec;
            this.cVMoi = cVMoi;
            this.tienDo = tienDo;
            this.ngayBatDau = NgayBatDau;
            this.deadline = deadline;
        }
    }
}
