using QuanLyDien.Admin;
using QuanLyDien.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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

        private void VeBieuDoDoanhThu()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();
                string sql = @"SELECT Thang, SUM(TongTien) as DoanhThu 
                           FROM HoaDon 
                           WHERE Nam = YEAR(GETDATE()) AND TrangThaiThanhToan = N'Đã thanh toán'
                           GROUP BY Thang 
                           ORDER BY Thang ASC";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 1. Làm sạch biểu đồ trước khi vẽ
                    chartDoanhThu.Series.Clear();
                    chartDoanhThu.ChartAreas.Clear();

                    // 2. Tạo và cấu hình Vùng vẽ (ChartArea)
                    ChartArea chartArea = new ChartArea("MainArea");

                    // --- Cấu hình màu sắc Dark Mode ---
                    chartArea.BackColor = Color.FromArgb(15, 16, 37); // Màu nền trùng với Form

                    // --- Cấu hình Trục X (Tháng) ---
                    chartArea.AxisX.LabelStyle.ForeColor = Color.White;
                    chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(50, 50, 50); // Đường lưới mờ
                    chartArea.AxisX.Interval = 1;
                    chartArea.AxisX.Minimum = 1;
                    chartArea.AxisX.Maximum = 12;
                    chartArea.AxisX.Title = "Tháng";
                    chartArea.AxisX.TitleForeColor = Color.Silver;

                    // --- Cấu hình Trục Y (Doanh thu - VNĐ) ---
                    chartArea.AxisY.LabelStyle.ForeColor = Color.White;
                    chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(50, 50, 50);
                    chartArea.AxisY.LabelStyle.Format = "#,##0 VNĐ"; // <--- ĐỊNH DẠNG VNĐ Ở ĐÂY
                    chartArea.AxisY.Title = "Doanh thu";
                    chartArea.AxisY.TitleForeColor = Color.Silver;

                    chartDoanhThu.ChartAreas.Add(chartArea);

                    // 3. Tạo và cấu hình Đường sóng (Series)
                    Series series = new Series("DoanhThu");
                    series.ChartType = SeriesChartType.SplineArea; // Kiểu sóng mượt có vùng bóng đổ
                    series.XValueMember = "Thang";
                    series.YValueMembers = "DoanhThu";


                    chartArea.AxisX.IsMarginVisible = false; // bỏ khoảng trống đầu
                    // --- Màu sắc và Hiệu ứng ---
                    series.Color = Color.FromArgb(100, 0, 255, 255); // Màu Cyan với độ trong suốt (Alpha = 100)
                    series.BorderColor = Color.FromArgb(0, 255, 255); // Viền Cyan đậm
                    series.BorderWidth = 3;

                    // Hiệu ứng Gradient mờ dần về phía đáy
                    series.BackGradientStyle = GradientStyle.TopBottom;
                    series.BackSecondaryColor = Color.Transparent;

                    // 4. Thêm Series vào biểu đồ và gán dữ liệu
                    chartDoanhThu.Series.Add(series);
                    chartDoanhThu.DataSource = dt;
                    chartDoanhThu.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi vẽ biểu đồ: " + ex.Message);
            }
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
                string sqlDoanhThu = @"SELECT ISNULL(SUM(TongTien), 0) 
                       FROM HoaDon 
                       WHERE Thang = MONTH(GETDATE())  AND Nam = YEAR(GETDATE()) AND TrangThaiThanhToan = N'Đã thanh toán'";
                decimal doanhThu = decimal.Parse(LayGiaTriDonLe(sqlDoanhThu));
                lblDoanhThu.Text = doanhThu.ToString("N0") + " VNĐ";

                // Ô 5: Sản lượng
                double sanLuong = double.Parse(LayGiaTriDonLe("SELECT ISNULL(SUM(SanLuong), 0) FROM GhiChiSo WHERE Thang = MONTH(GETDATE()) AND Nam = YEAR(GETDATE())"));
                lblVal5.Text = sanLuong.ToString("N0") + " kWh";

                // Ô 6: Nhân viên b
                lblNhanVien.Text = LayGiaTriDonLe("SELECT COUNT(*) FROM NhanVien");

                // Ô 7: Nhật ký hôm nay
                lblNhatKyHeThong.Text = LayGiaTriDonLe("SELECT COUNT(*) FROM NhatKyHeThong WHERE CAST(ThoiGian AS DATE) = CAST(GETDATE() AS DATE)");
                VeBieuDoDoanhThu();
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