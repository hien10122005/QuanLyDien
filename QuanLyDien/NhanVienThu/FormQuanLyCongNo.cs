using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDien.Class;

namespace QuanLyDien.NhanVienThu
{
    public partial class FormQuanLyCongNo : Form
    {
        public FormQuanLyCongNo()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void FormQuanLyCongNo_Load(object sender, EventArgs e)
        {
            LoadDanhSachNo();
        }

        void LoadDanhSachNo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    // Câu lệnh SQL tính số tháng trễ nợ và gợi ý biện pháp
                    string sql = @"SELECT MaHoaDon, HoTen, DiaChi, Thang, Nam, TongTien,
                                ((YEAR(GETDATE()) * 12 + MONTH(GETDATE())) - (Nam * 12 + Thang)) AS SoThangTre,
                                CASE 
                                    WHEN ((YEAR(GETDATE()) * 12 + MONTH(GETDATE())) - (Nam * 12 + Thang)) < 0 
                                         THEN N'Hóa đơn dự kiến (Chưa tới kỳ)' -- Xử lý số âm
                                    WHEN ((YEAR(GETDATE()) * 12 + MONTH(GETDATE())) - (Nam * 12 + Thang)) = 0 
                                         THEN N'Trong hạn thanh toán' -- Hóa đơn của tháng hiện tại
                                    WHEN ((YEAR(GETDATE()) * 12 + MONTH(GETDATE())) - (Nam * 12 + Thang)) = 1 
                                         THEN N'Trễ 1 tháng: Gửi SMS' 
                                    WHEN ((YEAR(GETDATE()) * 12 + MONTH(GETDATE())) - (Nam * 12 + Thang)) = 2 
                                         THEN N'Trễ 2 tháng: Đến tận nhà'
                                    WHEN ((YEAR(GETDATE()) * 12 + MONTH(GETDATE())) - (Nam * 12 + Thang)) >= 3 
                                         THEN N'VI PHẠM NẶNG: CẮT ĐIỆN'
                                END AS BienPhapGoiY
                                FROM HoaDon JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH
                                WHERE TrangThaiThanhToan = N'Chưa thanh toán'
                                ORDER BY SoThangTre DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCongNo.DataSource = dt;
                    DataGridViewStyle.ApplyModernStyle(dgvCongNo);
                    // Tính toán thống kê nhanh
                    lblSoHoNo.Text = "Số hộ chưa đóng: " + dt.Rows.Count;
                    object sumNo = dt.Compute("Sum(TongTien)", "");
                    lblTongNo.Text = "Tổng nợ: " + string.Format("{0:N0}", sumNo) + " VNĐ";

                    // Định dạng màu sắc cột Biện pháp
                    DinhDangBang();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void DinhDangBang()
        {
            foreach (DataGridViewRow row in dgvCongNo.Rows)
            {
                if (row.Cells["BienPhapGoiY"].Value != null)
                {
                    string bp = row.Cells["BienPhapGoiY"].Value.ToString();
                    if (bp == "CẮT ĐIỆN") row.DefaultCellStyle.ForeColor = Color.Red;
                    if (bp == "Đến nhà thông báo trực tiếp") row.DefaultCellStyle.ForeColor = Color.Orange;
                }
            }
        }

        private void btnThucHienXuLy_Click(object sender, EventArgs e)
        {
            if (dgvCongNo.CurrentRow == null) return;

            string maHD = dgvCongNo.CurrentRow.Cells["MaHoaDon"].Value.ToString();
            string noiDung = dgvCongNo.CurrentRow.Cells["BienPhapGoiY"].Value.ToString();

            if (noiDung == "Mới nợ tháng này")
            {
                MessageBox.Show("Hóa đơn mới nợ, chưa cần xử lý vi phạm!");
                return;
            }

            DialogResult dr = MessageBox.Show($"Xác nhận thực hiện biện pháp '{noiDung}' cho hóa đơn {maHD}?", "Xác nhận", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                    {
                        con.Open();
                        string maXL = "XL" + DateTime.Now.ToString("yyyyMMddHHmmss");
                        string sql = "INSERT INTO BienPhapXuLy VALUES (@maxl, @mahd, @nd, GETDATE())";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@maxl", maXL);
                        cmd.Parameters.AddWithValue("@mahd", maHD);
                        cmd.Parameters.AddWithValue("@nd", noiDung);
                        if (noiDung.Contains("CẮT ĐIỆN"))
                        {
                            // Truy vấn tìm Mã Đồng Hồ của khách hàng chủ hóa đơn này
                            string sqlUpdateDH = @"UPDATE DongHoDien 
                                           SET TrangThai = N'Ngừng Cấp Điện' 
                                           WHERE MaKH = (SELECT MaKH FROM HoaDon WHERE MaHoaDon = @mahd)";

                            SqlCommand cmdUpdate = new SqlCommand(sqlUpdateDH, con);
                            cmdUpdate.Parameters.AddWithValue("@mahd", maHD);
                            cmdUpdate.ExecuteNonQuery();

                            MessageBox.Show("Hệ thống đã ghi nhận biện pháp và tự động KHÓA ĐỒNG HỒ ĐIỆN của khách hàng!");
                        }
                        else
                        {
                            MessageBox.Show("Đã ghi nhận biện pháp xử lý thành công!");
                        }
                        LoadDanhSachNo();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã ghi nhận biện pháp xử lý vào hệ thống!");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachNo();
        }
    }
}