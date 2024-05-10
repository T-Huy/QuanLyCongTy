 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new FDangNhap());
            //Application.Run(new FDangNhap());

            //Application.Run(new FSuaDA("DA001"));
            //Application.Run(new FThemDA());

            //Application.Run(new FQuanLy2("NV001"));
            //Application.Run(new FNhanVien2("NV003"));
            Application.Run(new FTruongPhong("NV004"));

            //Application.Run(new FCapNhatTienDo());
            //Application.Run(new FLich2());
            //Application.Run(new FThongTinDA2());
            //Application.Run(new FPhanCong2());
        }
    }
}
