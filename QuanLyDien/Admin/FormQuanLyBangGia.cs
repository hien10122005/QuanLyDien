using QuanLyDien.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Data;
using System.Windows.Forms;

namespace QuanLyDien.Admin
{
    public partial class FormQuanLyBangGia : Form
    {
        // 1. Khai báo các đối tượng kết nối cơ bản
        SqlConnection ketNoi;
        SqlDataAdapter adapter;
        DataTable duLieu;
        bool isBinding = false; // Biển báo chặn sự kiện chạy lung tung

        public FormQuanLyBangGia()
        {
            InitializeComponent();
            // Cấu hình Form để nhúng vào Panel chính
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void FormQuanLyBangGia_Load(object sender, EventArgs e)
        {
            LoadTrangThai();      // Nạp danh sách trạng thái vào ComboBox
            LoadDataBangGia();    // Nạp dữ liệu từ SQL vào bảng
            panelTop_Resize(null, null); // Căn giữa giao diện
        }

        // --- NHÓM 1: CÁC HÀM NẠP DỮ LIỆU ---

        void LoadTrangThai()
        {
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("Hoạt động");
            cmbTrangThai.Items.Add("Khóa");
            cmbTrangThai.SelectedIndex = 0; // Mặc định chọn cái đầu tiên
        }

        void LoadDataBangGia()
        {
            try
            {
                using (ketNoi = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    string sql = "SELECT MaBangGia, TenBangGia, NgayApDung, TrangThai FROM BangGiaDien";
                    adapter = new SqlDataAdapter(sql, ketNoi);
                    duLieu = new DataTable();
                    adapter.Fill(duLieu);
                    dgvBangGia.DataSource = duLieu;
                    DataGridViewStyle.ApplyModernStyle(dgvBangGia);
                    // Đổi tên tiêu đề cột cho người dùng dễ đọc
                    dgvBangGia.Columns["MaBangGia"].HeaderText = "Mã Bảng Giá";
                    dgvBangGia.Columns["TenBangGia"].HeaderText = "Tên Biểu Giá";
                    dgvBangGia.Columns["NgayApDung"].HeaderText = "Ngày Áp Dụng";
                    dgvBangGia.Columns["TrangThai"].HeaderText = "Trạng Thái";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        // --- NHÓM 2: CÁC NÚT CHỨC NĂNG (THEM, SUA, KHOA) ---

        private void btnThem_Click(object sender, EventArgs e)
        {
           // string ma = txtMaBangGia.Text.Trim();
          //  string ten = txtTenBangGia.Text.Trim();
          //  string trangThaiChon = cmbTrangThai.Text;
            if (txtMaBangGia.Text == "" || txtTenBangGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ Mã và Tên bảng giá!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();
                    // Kiểm tra xem mã bảng giá đã tồn tại chưa
                    string sqlCheck = "SELECT COUNT(*) FROM BangGiaDien WHERE MaBangGia = @ma";
                    SqlCommand cmdCheck = new SqlCommand(sqlCheck, con);
                    cmdCheck.Parameters.AddWithValue("@ma", txtMaBangGia.Text.Trim());

                    if ((int)cmdCheck.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Mã bảng giá này đã tồn tại!");
                        return;
                    }

                    string cauLenhCheck = "SELECT COUNT(*) FROM BangGiaDien WHERE TrangThai = N'Hoạt động'";
                    SqlCommand cmdCheckHD = new SqlCommand(cauLenhCheck, con);
                    int soLuongDangChay = (int)cmdCheckHD.ExecuteScalar();

                    if (soLuongDangChay > 0 && cmbTrangThai.Text == "Hoạt động")
                    {
                        MessageBox.Show("Hiện đã có một bảng giá đang hoạt động!\nHệ thống tự động chuyển bảng này về trạng thái 'Khóa'.");
                       cmbTrangThai.Text = "Khóa";
                    }
              
                    // Thực hiện thêm mới
                    string sqlInsert = "INSERT INTO BangGiaDien (MaBangGia,TenBangGia,NgayApDung,TrangThai) VALUES (@ma, @ten, @ngay, @tt)";
                    SqlCommand cmd = new SqlCommand(sqlInsert, con);
                    cmd.Parameters.AddWithValue("@ma", txtMaBangGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtTenBangGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@ngay", dtpNgayApDung.Value);
                    cmd.Parameters.AddWithValue("@tt", cmbTrangThai.Text);

                    cmd.ExecuteNonQuery();
                    // NhatKy.Ghi("Thêm", "NguoiDung", "Tạo tài khoản " + txtTenDangNhap.Text + "cho nhân viên " +cmbMaNV.Text);
                    NhatKy.Ghi("Thêm ", "BangGiaDien", "Thêm Bảng Giá" + txtMaBangGia.Text);
                    MessageBox.Show("Thêm bảng giá mới thành công!");
                    btnLamMoi_Click(null, null); // Xóa trắng ô nhập và tải lại bảng
                }
            }
            catch (Exception ex) 
            { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaBangGia.Text == "") return;

            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();
                    if (cmbTrangThai.Text == "Hoạt động")
                    {
                        // Lệnh SQL: Cập nhật tất cả các bảng khác thành 'Khóa', ngoại trừ bảng đang sửa
                        string sqlDisableOthers = "UPDATE BangGiaDien SET TrangThai = N'Khóa' WHERE MaBangGia <> @ma";
                        SqlCommand cmdDisable = new SqlCommand(sqlDisableOthers, con);
                        cmdDisable.Parameters.AddWithValue("@ma", txtMaBangGia.Text.Trim());
                        cmdDisable.ExecuteNonQuery();
                    }
                    // Cập nhật thông tin bảng giá (không cho sửa Mã)
                    string sqlUpdate = "UPDATE BangGiaDien SET TenBangGia=@ten, NgayApDung=@ngay, TrangThai=@tt WHERE MaBangGia=@ma";
                    SqlCommand cmd = new SqlCommand(sqlUpdate, con);
                    cmd.Parameters.AddWithValue("@ma", txtMaBangGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtTenBangGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@ngay", dtpNgayApDung.Value);
                    cmd.Parameters.AddWithValue("@tt", cmbTrangThai.Text);
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    NhatKy.Ghi("Cập nhật ", "BangGiaDien", "Cập nhật Bảng Giá" + txtMaBangGia.Text);

                    btnLamMoi_Click(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi sửa: " + ex.Message); }
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            string maHienTai = txtMaBangGia.Text.Trim();
            if (maHienTai == "")
            {
                MessageBox.Show("Vui lòng chọn một bảng giá từ danh sách!");
                return;
            }
            string trangThaiMoi = "";

            if (cmbTrangThai.Text == "Hoạt động")
            {
                trangThaiMoi = "Khóa";
            }
            else
            {
                trangThaiMoi = "Hoạt động";
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();

                    // Nếu trạng thái sau khi nhấn nút là 'Hoạt động'
                    // Ta cần tắt (Khóa) tất cả các bảng giá khác để tránh xung đột
                    if (trangThaiMoi == "Hoạt động")
                    {
                        string sqlTatHet = "UPDATE BangGiaDien SET TrangThai = N'Khóa' WHERE MaBangGia <> @ma";
                        SqlCommand cmdTatHet = new SqlCommand(sqlTatHet, con);
                        cmdTatHet.Parameters.AddWithValue("@ma", maHienTai);
                        cmdTatHet.ExecuteNonQuery();
                    }

                    // Cập nhật trạng thái mới cho bảng giá đang được chọn
                    string sqlUpdate = "UPDATE BangGiaDien SET TrangThai = @status WHERE MaBangGia = @ma";
                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, con);
                    cmdUpdate.Parameters.AddWithValue("@status", trangThaiMoi);
                    cmdUpdate.Parameters.AddWithValue("@ma", maHienTai);

                    cmdUpdate.ExecuteNonQuery();

                    // Thông báo cho người dùng và nạp lại bảng dữ liệu
                    MessageBox.Show("Đã chuyển bảng giá " + maHienTai + " sang trạng thái: " + trangThaiMoi);
                    NhatKy.Ghi(trangThaiMoi, "BangGiaDien", trangThaiMoi+ " Bảng Giá" + txtMaBangGia.Text);

                    // Gọi hàm làm mới để dgvBangGia cập nhật con số mới nhất
                    btnLamMoi_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaBangGia.Clear();
            txtMaBangGia.ReadOnly = false; // Mở lại ô Mã để nhập mới
            txtTenBangGia.Clear();
            dtpNgayApDung.Value = DateTime.Now;
            cmbTrangThai.SelectedIndex = 0;
            LoadDataBangGia();
        }

        // --- NHÓM 3: XỬ LÝ SỰ KIỆN GIAO DIỆN ---

        private void dgvBangGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            isBinding = true; // Bật cờ chặn

            DataGridViewRow r = dgvBangGia.Rows[e.RowIndex];
            txtMaBangGia.Text = r.Cells["MaBangGia"].Value.ToString();
            txtMaBangGia.ReadOnly = true; // Khóa mã không cho sửa khi đang chọn dòng
            txtTenBangGia.Text = r.Cells["TenBangGia"].Value.ToString();
            dtpNgayApDung.Value = Convert.ToDateTime(r.Cells["NgayApDung"].Value);
            cmbTrangThai.Text = r.Cells["TrangThai"].Value.ToString();

            isBinding = false; // Tắt cờ
        }

        private void panelTop_Resize(object sender, EventArgs e)
        {
            // Code giúp cụm thông tin luôn nằm chính giữa màn hình
            if (palThongTin != null)
                palThongTin.Left = (panelTop.Width - palThongTin.Width) / 2;

            if (pnlSearch != null)
                pnlSearch.Left = (panelTop.Width - pnlSearch.Width) / 2;
        }
    }
}