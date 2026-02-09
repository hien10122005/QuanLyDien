using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDien.Class;
using QuanLyDien.Admin;

namespace QuanLyDien.ChucNangChung
{
    public partial class FormTrangChu : Form
    {
        
        SqlConnection ketNoi;
        Timer boDemThoiGian = new Timer();

        public FormTrangChu()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormTrangChu_Load_1(object sender, EventArgs e)
        {
            // Chạy đồng hồ hiển thị thời gian
            ThietLapDongHo();

            // Tải dữ liệu lên các ô thống kê
            CapNhatThongKe();
        }

        // XỬ LÝ ĐỒNG HỒ ---
        private void ThietLapDongHo()
        {
            boDemThoiGian.Interval = 1000; // 1 giây
            boDemThoiGian.Tick += (s, ev) => {
                lblWelcome.Text = "Hệ thống đang chạy | " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            };
            boDemThoiGian.Start();
        }

        // LẤY DỮ LIỆU TỪ CSDL  ---
        public void CapNhatThongKe()
        {
            try
            {
                // Khởi tạo kết nối (Sử dụng chuỗi kết nối từ lớp dùng chung)
                ketNoi = new SqlConnection(ChuoiKetNoi.KetNoi);
                ketNoi.Open();

                // Cập nhật từng ô thông tin bằng hàm ExecuteScalar 

                // Ô 1: Khách hàng
                lblKhachHang.Text = LayGiaTriDonLe("SELECT COUNT(*) FROM KhachHang");

                // Ô 2: Yêu cầu mới
                lblYeuCauMoi.Text = LayGiaTriDonLe("SELECT COUNT(*) FROM YeuCauLapDatDongHo WHERE TrangThai LIKE N'%Chờ%'");

                // Ô 3: Hóa đơn nợ 
                lblHoaDon.Text = LayGiaTriDonLe("SELECT COUNT(*) FROM HoaDon WHERE TrangThaiThanhToan = N'Chưa thanh toán'");

                // Ô 4: Doanh thu 
                decimal doanhThu = decimal.Parse(LayGiaTriDonLe("SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon WHERE Thang = MONTH(GETDATE()) AND Nam = YEAR(GETDATE())"));
                lblDoanhThu.Text = doanhThu.ToString("N0") + " VNĐ"; // Định dạng 1,000,000

                // Ô 5: Sản lượng
                double sanLuong = double.Parse(LayGiaTriDonLe("SELECT ISNULL(SUM(SanLuong), 0) FROM GhiChiSo WHERE Thang = MONTH(GETDATE()) AND Nam = YEAR(GETDATE())"));
                lblVal5.Text = sanLuong.ToString("N0") + " kWh";

                // Ô 6: Nhân viên b
                lblNhanVien.Text = LayGiaTriDonLe("SELECT COUNT(*) FROM NhanVien");

                // Ô 7: Nhật ký hôm nay
                lblNhatKyHeThong.Text = LayGiaTriDonLe("SELECT COUNT(*) FROM NhatKyHeThong WHERE CAST(ThoiGian AS DATE) = CAST(GETDATE() AS DATE)");

                // Thông báo trạng thái
                lblGhiChuNhanh.Text = "Cập nhật dữ liệu thành công lúc: " + DateTime.Now.ToString("HH:mm");
                lblGhiChuNhanh.ForeColor = Color.Gray;
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có 
                lblGhiChuNhanh.Text = "Lỗi hệ thống: " + ex.Message;
                lblGhiChuNhanh.ForeColor = Color.Red;
            }
            finally
            {
                // Luôn đóng kết nối sau khi dùng xong 
                if (ketNoi != null && ketNoi.State == ConnectionState.Open)
                    ketNoi.Close();
            }
        }

        private string LayGiaTriDonLe(string cauLenhSQL)
        {
            SqlCommand boLenh = new SqlCommand(cauLenhSQL, ketNoi);
            object ketQua = boLenh.ExecuteScalar();

            if (ketQua == null || ketQua == DBNull.Value)
                return "0";

            return ketQua.ToString();
        }

        public void RefreshDashboard()
        {
            CapNhatThongKe();
        }

        private void lblNhatKyHeThong_Click(object sender, EventArgs e)
        {
            
        }

        private void lblNhanVien_Click(object sender, EventArgs e)
        {
            FormQuanLyNhanVien f = new FormQuanLyNhanVien();
            f.Show();
            f.Hide();
        }
    }
}