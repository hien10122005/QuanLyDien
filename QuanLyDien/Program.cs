
using QuanLyDien.Admin;
using QuanLyDien.ChucNangChung;
using QuanLyDien.NhanVienThu;
using QuanLyDien.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDien
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
           // Application.Run(new FormMain());
           Application.Run(new FormDangNhap());
        }
    }
}
