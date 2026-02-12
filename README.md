# Quản Lý Điện
 Giới thiệu dự án
Đồ án Cơ sở 1: Xây dựng ứng dụng Windows Forms quản lý quy trình ghi chỉ số, tính toán hóa đơn theo bậc thang lũy tiến và quản lý công nợ khách hàng. Hệ thống được tối ưu hóa giao diện Dark Mode hiện đại và tích hợp báo cáo trực quan.
 Tính năng nổi bật
1. Quản trị hệ thống
Phân quyền: 3 nhóm quyền (Admin, Nhân viên ghi điện, Nhân viên thu tiền).
Nhật ký hệ thống: Tự động lưu vết mọi hành động (Thêm, Sửa, Xóa, Khóa).
Cơ chế Xóa mềm (Soft Delete): Quản lý trạng thái "Hoạt động/Khóa" để bảo toàn dữ liệu lịch sử.
2. Quản lý nghiệp vụ
Ghi chỉ số điện: Tự động lấy chỉ số cũ, tính sản lượng và kiểm tra logic (Mới >= Cũ).
Tính toán hóa đơn tự động: Thuật toán chia bậc thang (lũy tiến) chính xác 100% ngay sau khi ghi số.
Quản lý công nợ: Tự động phân loại biện pháp xử lý (Nhắc nợ/Cắt điện) dựa trên số tháng trễ hạn.
3. Báo cáo & Thống kê
Dashboard trực quan: Thống kê nhanh KPI và biểu đồ sóng (Spline Area Chart) diễn biến doanh thu 12 tháng.
Xuất hóa đơn (RDLC): In hóa đơn tiền điện chuyên nghiệp, hỗ trợ xuất file PDF/Excel.
🛠 Công nghệ sử dụng
Ngôn ngữ: C# (WinForms)
Kiến trúc dữ liệu: ADO.NET (SqlConnection, SqlDataAdapter, DataSet)
Cơ sở dữ liệu: SQL Server (Thiết kế 13 bảng chuẩn hóa)
Báo cáo: Microsoft Reporting Services (RDLC)
Giao diện: Flat Design, Responsive Controls (xử lý sự kiện Resize)
##  Tác giả
- Phan Văn Hiển
