using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms; // Bắt buộc phải có dòng này
using QuanLyDien.Class;

namespace QuanLyDien.NhanVienThu
{
    public partial class FormInHoaDonDien : Form
    {
        string _maHD; // Biến để nhận mã hóa đơn từ Form quản lý gửi sang

        // Sửa lại Constructor để nhận MaHD
        public FormInHoaDonDien(string maHD)
        {
            InitializeComponent();
            this._maHD = maHD;
            this.StartPosition = FormStartPosition.CenterScreen;
            //991, 620
            this.Width = 1010;
            this.Height = 600;
        }

        private void FormInHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    // Lệnh SQL JOIN 3 bảng để lấy đầy đủ thông tin:
                    // Thông tin khách hàng + Thông tin hóa đơn + Chi tiết các bậc tiền
                    string sql = @"SELECT HD.MaHoaDon, KH.HoTen, KH.DiaChi, HD.Thang, HD.Nam, 
                                          CT.Bac, CT.SoDien, CT.DonGia, CT.ThanhTien, HD.TongTien
                                   FROM HoaDon HD
                                   JOIN KhachHang KH ON HD.MaKH = KH.MaKH
                                   JOIN ChiTietHoaDon CT ON HD.MaHoaDon = CT.MaHoaDon
                                   WHERE HD.MaHoaDon = @ma";

                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    da.SelectCommand.Parameters.AddWithValue("@ma", _maHD);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Kiểm tra nếu không có dữ liệu
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho hóa đơn này!");
                        return;
                    }

                    // 1. Khai báo đường dẫn file RDLC (đảm bảo đúng tên file bạn đã vẽ)
                    // rptHoaDon.LocalReport.ReportPath = "RDLC/rptInHoaDon.rdlc";
                    rptHoaDon.LocalReport.ReportEmbeddedResource = "QuanLyDien.RDLC.rptInHoaDon.rdlc";
                    // Lưu ý: Nếu file rdlc nằm trong thư mục khác, hãy sửa đường dẫn trên cho đúng.

                    // 2. Tạo nguồn dữ liệu cho báo cáo
                    // "DataSet1" là cái tên bạn thấy trong cửa sổ Report Data bên trái
                    ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                    // 3. Làm sạch và nạp dữ liệu mới vào ReportViewer
                    rptHoaDon.LocalReport.DataSources.Clear();
                    rptHoaDon.LocalReport.DataSources.Add(rds);

                    // 4. Vẽ lại báo cáo
                    rptHoaDon.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị hóa đơn: " + ex.Message);
            }
        }
    }
}