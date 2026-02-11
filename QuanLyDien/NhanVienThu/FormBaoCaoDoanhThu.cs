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
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void FormBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            nudThang.Value = DateTime.Now.Month;
            nudNam.Value = DateTime.Now.Year;
            ChayThongKe();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ChayThongKe();
        }

        // --- HÀM TỔNG HỢP VÀ THUẬT TOÁN LỌC ---
        void ChayThongKe()
        {
            int thang = (int)nudThang.Value;
            int nam = (int)nudNam.Value;

            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();

                    // --- PHẦN 1: CÁC CON SỐ TỔNG QUÁT (KPI) ---

                    // 1. Tính tổng sản lượng tháng đang chọn
                    string sqlThang = "SELECT ISNULL(SUM(SanLuong), 0) FROM GhiChiSo WHERE Thang = @t AND Nam = @n";
                    SqlCommand cmd1 = new SqlCommand(sqlThang, con);
                    cmd1.Parameters.AddWithValue("@t", thang);
                    cmd1.Parameters.AddWithValue("@n", nam);
                     
                    lblSanLuongThang.Text = Convert.ToDouble(cmd1.ExecuteScalar()).ToString("N0") + " kWh";

                    // 2. Tính tổng sản lượng cả năm đang chọn (Bỏ qua điều kiện Tháng)
                    string sqlNam = "SELECT ISNULL(SUM(SanLuong), 0) FROM GhiChiSo WHERE Nam = @n";
                    SqlCommand cmd2 = new SqlCommand(sqlNam, con);
                    cmd2.Parameters.AddWithValue("@n", nam);
                    lblSanLuongNam.Text = Convert.ToDouble(cmd2.ExecuteScalar()).ToString("N0") + " kWh";

                    // 3. Tính doanh thu tháng (Chỉ lấy hóa đơn đã trả tiền)
                    string sqlTien = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon WHERE Thang = @t AND Nam = @n AND TrangThaiThanhToan = N'Đã thanh toán'";
                    SqlCommand cmd3 = new SqlCommand(sqlTien, con);
                    cmd3.Parameters.AddWithValue("@t", thang);
                    cmd3.Parameters.AddWithValue("@n", nam);
                    lblDoanhThu.Text = Convert.ToDecimal(cmd3.ExecuteScalar()).ToString("N0") + " VNĐ";

                    // --- PHẦN 2: THUẬT TOÁN LỌC DỮ LIỆU LÊN BẢNG (DÙNG IF-ELSE) ---

                    string sqlBang = "";

                    // BƯỚC 1: QUYẾT ĐỊNH CÂU LỆNH SQL
                    if (chkXemCaNam.Checked == true)
                    {
                        // Xem cả năm: Chỉ lọc theo Năm và Trạng thái
                        sqlBang = @"SELECT MaHoaDon, KH.HoTen, Thang, Nam, TongTien, TrangThaiThanhToan 
                        FROM HoaDon JOIN KhachHang KH ON HoaDon.MaKH = KH.MaKH 
                        WHERE Nam = @n AND TrangThaiThanhToan = @ThanhToan
                        ORDER BY Thang ASC";
                    }
                    else
                    {
                        // Xem theo tháng: Lọc cả Tháng, Năm và Trạng thái
                        sqlBang = @"SELECT MaHoaDon, KH.HoTen, Thang, Nam, TongTien, TrangThaiThanhToan 
                        FROM HoaDon JOIN KhachHang KH ON HoaDon.MaKH = KH.MaKH 
                        WHERE Thang = @t AND Nam = @n AND TrangThaiThanhToan = @ThanhToan";
                    }

                    // BƯỚC 2: TẠO ĐỐI TƯỢNG LỆNH (SqlCommand)
                    SqlCommand boLenh = new SqlCommand(sqlBang, con);

                    // BƯỚC 3: NẠP THAM SỐ (Parameters) - Dùng IF/ELSE để gán cho chuẩn
                    boLenh.Parameters.AddWithValue("@n", nam);
                    boLenh.Parameters.AddWithValue("@ThanhToan", "Đã thanh toán"); // Đã xóa dấu cách thừa

                    if (chkXemCaNam.Checked == false)
                    {
                        // Chỉ nạp tham số Tháng nếu người dùng KHÔNG tích vào 'Xem cả năm'
                        boLenh.Parameters.AddWithValue("@t", thang);
                    }

                    // BƯỚC 4: ĐỔ DỮ LIỆU (SqlDataAdapter)
                    SqlDataAdapter da = new SqlDataAdapter(boLenh);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Hiển thị lên bảng
                    dgvBaoCao.DataSource = dt;
                    DataGridViewStyle.ApplyModernStyle(dgvBaoCao);

                    // --- PHẦN 3: TRANG TRÍ BẢNG ---
                    if (dgvBaoCao.Columns.Count > 0)
                    {
                        dgvBaoCao.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
                        dgvBaoCao.Columns["HoTen"].HeaderText = "Tên Khách Hàng";
                        dgvBaoCao.Columns["TongTien"].HeaderText = "Số Tiền";
                        dgvBaoCao.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                        dgvBaoCao.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void chkXemCaNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXemCaNam.Checked)
            {
                nudThang.Enabled = false; // Vô hiệu hóa ô chọn tháng
            }
            else
            {
                nudThang.Enabled = true;  // Mở lại ô chọn tháng
            }
            ChayThongKe(); // Tự động load lại dữ liệu khi người dùng vừa tích vào
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được kết nối với hệ thống máy in...");
        }
    }
}