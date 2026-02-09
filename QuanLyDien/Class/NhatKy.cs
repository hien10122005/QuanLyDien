using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDien.Class
{
    public static class NhatKy
    {
        public static void Ghi(string hanhDong, string tenBang, string noiDung)
        {
            try
            {
                string sql = @"
                INSERT INTO NhatKyHeThong
                (TenDangNhap, VaiTro, HanhDong, TenBang, NoiDung, ThoiGian)
                VALUES
                (@TenDangNhap, @VaiTro, @HanhDong, @TenBang, @NoiDung, GETDATE())";

                using (SqlConnection conn = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@TenDangNhap", Session.TenDangNhap);
                    cmd.Parameters.AddWithValue("@VaiTro", Session.VaiTro);
                    cmd.Parameters.AddWithValue("@HanhDong", hanhDong);
                    cmd.Parameters.AddWithValue("@TenBang", tenBang);
                    cmd.Parameters.AddWithValue("@NoiDung", noiDung);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
              
            }
        }
    }}
