Chào bạn, đây là bản README.md được thiết kế "đo ni đóng giày" cho dự án của bạn. Bản này cực kỳ chi tiết, làm nổi bật được các kỹ thuật khó mà bạn đã xử lý (như tính tiền điện bậc thang, xử lý công nợ tự động, và Dashboard) để giáo viên thấy rõ giá trị của phần mềm.

⚡ PVH POWER - HỆ THỐNG QUẢN LÝ ĐIỆN NĂNG CHUYÊN NGHIỆP

![alt text](https://img.shields.io/badge/Language-C%23-blue)


![alt text](https://img.shields.io/badge/Database-SQL%20Server-red)


![alt text](https://img.shields.io/badge/UI-Modern%20Dark%20Mode-darkblue)


![alt text](https://img.shields.io/badge/Report-Microsoft%20RDLC-orange)

📖 Giới thiệu dự án

PVH Power là giải pháp quản lý điện năng toàn diện được xây dựng trên nền tảng Windows Forms. Dự án giải quyết trọn vẹn quy trình từ tiếp nhận lắp đặt đồng hồ, ghi chỉ số điện hàng tháng, tính toán hóa đơn theo biểu giá bậc thang lũy tiến cho đến quản lý công nợ và báo cáo doanh thu.

Hệ thống được tối ưu hóa cho trải nghiệm người dùng với giao diện Dark Mode hiện đại và cơ chế xử lý dữ liệu thông minh.

Chào bạn, để làm "chi tiết hơn nữa" nhằm thuyết phục hoàn toàn giáo viên về độ phức tạp và tính thực tế của phần mềm, tôi sẽ viết lại phần ✨ Tính năng chi tiết theo hướng mô tả rõ các Luồng xử lý (Workflows) và Quy tắc nghiệp vụ (Business Rules) ẩn bên dưới code.

Đây là bản nâng cấp cực kỳ chuyên sâu dành cho file README của bạn:

✨ Tính năng chi tiết
1. Phân hệ Quản trị & Bảo mật hệ thống (System & Security)

Xác thực đa lớp (Authentication):

Cơ chế đăng nhập phân quyền dựa trên 03 vai trò chính: Quản trị viên, Nhân viên Ghi điện, Nhân viên Thu tiền.

Hệ thống tự động ẩn/hiện các menu chức năng tương ứng ngay khi đăng nhập thành công để tối ưu không gian làm việc.

Bảo mật dữ liệu (Data Security):

Ứng dụng thuật toán SHA-256 Hashing để mã hóa mật khẩu một chiều trước khi lưu trữ vào CSDL SQL Server, đảm bảo an toàn tuyệt đối.

Giám sát hoạt động (Audit Logs):

Module Nhật ký hệ thống tự động ghi lại vết (tracking) của mọi phiên làm việc: định danh người dùng, thời điểm tác động, hành động (Thêm/Sửa/Xóa/Khóa), bảng dữ liệu bị tác động và nội dung chi tiết của thay đổi.

Cơ chế Xóa mềm (Soft Delete):

Áp dụng trạng thái Hoạt động và Khóa cho Nhân viên và Khách hàng thay vì xóa vĩnh viễn. Kỹ thuật này giúp bảo toàn Ràng buộc toàn vẹn (Foreign Key) cho các hóa đơn và báo cáo tài chính trong quá khứ.

2. Quản lý Danh mục & Biểu giá động (Dynamic Category & Pricing)

Cấu trúc dữ liệu phân cấp:

Quản lý danh mục theo luồng logic: Khu vực (Area) -> Khách hàng (Customer) -> Đồng hồ điện (Meter).

Tự động lọc Khách hàng theo Khu vực đã chọn để tránh sai sót khi bàn giao địa bàn quản lý.

Thiết lập Biểu giá Bậc thang (Tiered Pricing):

Cho phép Admin cấu hình không giới hạn các bộ biểu giá (Giá sinh hoạt, Giá kinh doanh, Giá sản xuất...).

Chi tiết bậc thang: Cấu hình động các mức định mức (Từ số, Đến số) và Đơn giá cho từng bậc.

Quy tắc kiểm soát: Hệ thống tự động kiểm tra và khóa các biểu giá cũ khi một biểu giá mới được kích hoạt, đảm bảo tính nhất quán trong tính toán.

3. Nghiệp vụ Ghi chỉ số & Tự động hóa tính tiền (Billing Automation)

Logic Ghi chỉ số thông minh:

Hệ thống tự động truy vấn Chỉ số mới của tháng gần nhất để làm Chỉ số cũ cho tháng hiện tại ngay khi nhân viên chọn mã đồng hồ.

Tự động tính toán Sản lượng tiêu thụ thời gian thực (Real-time) ngay trong quá trình nhập liệu.

Ràng buộc logic: Chặn lưu dữ liệu nếu Chỉ số mới < Chỉ số cũ và cảnh báo màu sắc trực quan nếu dữ liệu bất thường.

Thuật toán tính tiền Lũy tiến:

Ngay sau khi lưu chỉ số, hệ thống kích hoạt hàm Xử lý hóa đơn tự động.

Thuật toán sẽ tự động phân tách tổng sản lượng vào từng bậc giá tương ứng theo biểu giá đang áp dụng (Ví dụ: 120 số sẽ chia thành 50 số bậc 1, 50 số bậc 2, 20 số bậc 3).

Tự động sinh đồng thời bản ghi ở bảng HoaDon (Tổng quát) và bảng ChiTietHoaDon (Chi tiết từng bậc tiền).

4. Quản lý Thu tiền & Xử lý Công nợ (Debt & Penalty Workflow)

Nghiệp vụ Thu ngân:

Lọc nhanh danh sách hóa đơn theo kỳ (Tháng/Năm) và Trạng thái (Đã nộp/Chưa nộp).

Xác nhận thanh toán 1-click: Tự động ghi nhận Ngày thanh toán và chuyển trạng thái hóa đơn.

Quy trình Xử lý Công nợ tự động:

Hệ thống tự động tính toán Số tháng trễ hạn dựa trên chênh lệch thời gian thực (CurrentDate - BillDate).

Phân tầng xử lý (Penalty Levels):

Trễ 1 tháng: Đề xuất biện pháp "Gửi SMS nhắc nợ".

Trễ 2 tháng: Đề xuất "Gửi giấy báo/Đến nhà thông báo trực tiếp".

Trễ 3 tháng: Đề xuất "CẮT ĐIỆN".

Tác động dây chuyền: Khi thực hiện lệnh "CẮT ĐIỆN", hệ thống tự động khóa trạng thái của Đồng hồ điện sang Ngừng cấp điện và khóa trạng thái của Khách hàng.

5. Dashboard Phân tích & Kết xuất Báo cáo (Analytics & RDLC)

Dashboard KPI:

Hiển thị các con số tổng quát: Tổng số khách hàng, yêu cầu lắp đặt mới, tổng doanh thu thực tế và sản lượng điện tiêu thụ trong kỳ.

Trực quan hóa dữ liệu (Charts):

Tích hợp Biểu đồ sóng (Spline Area Chart) theo dõi diễn biến doanh thu qua 12 tháng, giúp quản lý nhận diện các giai đoạn cao điểm sử dụng điện.

In ấn chuyên nghiệp với Microsoft RDLC:

Thiết kế mẫu in hóa đơn chuẩn ngành điện: Thông tin khách hàng, bảng kê chi tiết từng bậc thang tiền điện, tổng tiền bằng số và bằng chữ.

Hỗ trợ kết xuất báo cáo tổng hợp doanh thu theo năm/tháng ra định dạng PDF, Excel, Word.

Mẹo cho bạn:

Phần này mô tả rất sâu về "bên trong" phần mềm (backend logic). Khi giáo viên đọc phần này, họ sẽ thấy bạn không chỉ làm giao diện mà thực sự đã thiết kế ra một hệ thống có quy trình (Process-oriented system). Điều này thường là tiêu chuẩn để chấm điểm 9 hoặc 10 cho Đồ án Cơ sở.

🛠 Công nghệ & Kỹ thuật sử dụng

Lập trình: C# WinForms (.NET Framework 4.7.2).

Kiến trúc: ADO.NET (SqlConnection, SqlCommand, SqlDataAdapter, SqlDataReader).

Cơ sở dữ liệu: SQL Server (13 bảng chuẩn hóa 3NF).

UI/UX:

Cơ chế Double Buffered chống nhấp nháy giao diện.

Kỹ thuật isBinding flag để chặn các sự kiện lặp vô hạn.

Responsive Layout (tự động căn giữa controls khi phóng to màn hình).

📂 Cấu trúc thư mục Project
code
Text
download
content_copy
expand_less
QuanLyDien/
├── Admin/              # Module dành cho Quản trị viên
├── ChucNangChung/      # Dashboard, Thông tin cá nhân, Nhật ký
├── Class/              # Lớp dùng chung (CSDL, SHA256, Session)
├── DataSet/            # Nguồn dữ liệu cho báo cáo
├── Login/              # Đăng nhập, Đăng ký, Quên mật khẩu
├── NhanVienGhi/        # Module nghiệp vụ ghi điện, lắp đặt
├── NhanVienThu/        # Module thu tiền, công nợ, báo cáo doanh thu
└── RDLC/               # File thiết kế mẫu in ấn báo cáo (.rdlc)
🚀 Hướng dẫn cài đặt

Clone dự án:

code
Bash
download
content_copy
expand_less
git clone https://github.com/your-username/QuanLyDien.git

Cấu hình CSDL:

Đính kèm file Database_QuanLyDien.sql.

Mở SSMS, tạo database mới tên QuanLyDienNang và thực thi script.

Cập nhật Connection String:

Mở file Class/ChuoiKetNoi.cs và thay đổi Data Source phù hợp với máy cá nhân.

Tài khoản mặc định:

User: admin | Pass: 123

👤 Thông tin tác giả

Tác giả: Phan Văn Hiển 

Email: PhanHien00001@gmail.

Vai trò: Developer & System Analyst

Dự án này được xây dựng như một Đồ án Cơ sở 1 với mục tiêu nghiên cứu và ứng dụng quy trình quản lý thực tế vào lập trình Windows Forms.

Gợi ý cho bạn:

Bản README này rất chi tiết về mặt kỹ thuật. Khi nộp bài, bạn hãy chụp 4 tấm ảnh đẹp nhất của dự án chèn vào mục "Hình ảnh giao diện" (không có trong text nhưng bạn nên tự thêm vào GitHub) gồm:

Dashboard Trang chủ (có biểu đồ sóng).

Form Ghi số điện (thể hiện tính sản lượng).

Báo cáo doanh thu (có các ô màu sắc).

Mẫu hóa đơn RDLC (tờ giấy in).

Chúc bạn đạt điểm 10 tuyệt đối cho đồ án này!
