using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDien.Class;

namespace QuanLyDien.NhanVienThu
{
    public partial class FormBaoCaoDoanhThu : Form
    {
        public FormBaoCaoDoanhThu()
        {
            InitializeComponent();
            // Thiết lập để Form hiển thị tràn trong Panel chính
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void FormBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            // Khi vừa mở Form, tự lấy Tháng/Năm hiện tại của máy tính gán vào ô chọn
            nudThang.Value = DateTime.Now.Month;
            nudNam.Value = DateTime.Now.Year;

            // Tự động chạy thống kê lần đầu
            ChayThongKe();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ChayThongKe();
        }

        // --- HÀM TỔNG HỢP CHÍNH ---
        void ChayThongKe()
        {
            // Lấy giá trị người dùng đang chọn trên giao diện
            int thang = (int)nudThang.Value;
            int nam = (int)nudNam.Value;

            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();

                    /* 
                     * THUẬT TOÁN 1: Tính tổng sản lượng điện của THÁNG được chọn
                     * Logic: Cộng dồn cột 'SanLuong' của tất cả khách hàng trong tháng đó.
                     * Hàm ISNULL(..., 0): Nếu tháng đó chưa có ai ghi điện (NULL), thì trả về số 0 để không bị lỗi.
                     */
                    string sqlThang = "SELECT ISNULL(SUM(SanLuong), 0) FROM GhiChiSo WHERE Thang = @t AND Nam = @n";
                    SqlCommand cmd1 = new SqlCommand(sqlThang, con);
                    cmd1.Parameters.AddWithValue("@t", thang);
                    cmd1.Parameters.AddWithValue("@n", nam);
                    double slThang = Convert.ToDouble(cmd1.ExecuteScalar());
                    lblSanLuongThang.Text = slThang.ToString("N0") + " kWh"; // N0 giúp hiện dấu phẩy: 1,200


                    /* 
                     * THUẬT TOÁN 2: Tính tổng sản lượng điện của cả NĂM được chọn
                     * Logic: Giống bên trên nhưng bỏ điều kiện THÁNG, chỉ lọc theo NĂM.
                     */
                    string sqlNam = "SELECT ISNULL(SUM(SanLuong), 0) FROM GhiChiSo WHERE Nam = @n";
                    SqlCommand cmd2 = new SqlCommand(sqlNam, con);
                    cmd2.Parameters.AddWithValue("@n", nam);
                    double slNam = Convert.ToDouble(cmd2.ExecuteScalar());
                    lblSanLuongNam.Text = slNam.ToString("N0") + " kWh";


                    /* 
                     * THUẬT TOÁN 3: Tính tổng doanh thu thực tế (Tiền đã thu được)
                     * Logic: Chỉ cộng 'TongTien' của những hóa đơn có trạng thái là 'Đã thanh toán'.
                     */
                    string sqlTien = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon " +
                                     "WHERE Thang = @t AND Nam = @n AND TrangThaiThanhToan = N'Đã thanh toán'";
                    SqlCommand cmd3 = new SqlCommand(sqlTien, con);
                    cmd3.Parameters.AddWithValue("@t", thang);
                    cmd3.Parameters.AddWithValue("@n", nam);
                    decimal doanhThu = Convert.ToDecimal(cmd3.ExecuteScalar());
                    lblDoanhThu.Text = doanhThu.ToString("N0") + " VNĐ";


                    /* 
                     * THUẬT TOÁN 4: Nạp danh sách chi tiết các hóa đơn vào bảng
                     * Logic: Dùng lệnh JOIN để lấy Tên Khách Hàng từ bảng KhachHang sang.
                     */
                    string sqlBang = @"SELECT MaHoaDon, KH.HoTen, Thang, Nam, TongTien, TrangThaiThanhToan 
                                       FROM HoaDon JOIN KhachHang KH ON HoaDon.MaKH = KH.MaKH 
                                       WHERE Thang = @t AND Nam = @n";
                    SqlDataAdapter da = new SqlDataAdapter(sqlBang, con);
                    da.SelectCommand.Parameters.AddWithValue("@t", thang);
                    da.SelectCommand.Parameters.AddWithValue("@n", nam);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBaoCao.DataSource = dt;
                    DataGridViewStyle.ApplyModernStyle(dgvBaoCao);
                    // Định dạng lại tiêu đề bảng cho chuyên nghiệp
                    dgvBaoCao.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
                    dgvBaoCao.Columns["HoTen"].HeaderText = "Tên Khách Hàng";
                    dgvBaoCao.Columns["TongTien"].HeaderText = "Số Tiền";
                    dgvBaoCao.Columns["TongTien"].DefaultCellStyle.Format = "N0"; // Hiện số: 1,000,000
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi làm báo cáo: " + ex.Message);
            }
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang chuẩn bị dữ liệu để in ra file PDF...");
        }
    }
}