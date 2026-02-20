using Microsoft.ReportingServices.Diagnostics.Internal;
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
        SqlConnection ketNoi;
        SqlDataAdapter adapter;
        DataTable duLieu;
        bool isBinding = false; 

        public FormQuanLyBangGia()
        {
            InitializeComponent();
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
                    string maMoi = txtMaBangGia.Text.Trim();

                    MessageBox.Show("Thêm bảng giá thành công! Hãy thiết lập đơn giá bậc thang cho mã này.");
                    FormChiTietBangGia f = new FormChiTietBangGia(maMoi);
                    Panel pnlChinh = (Panel)this.Parent;
                    if (pnlChinh != null)
                    {
                        f.TopLevel = false;
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.Dock = DockStyle.Fill;

                        pnlChinh.Controls.Clear();
                        pnlChinh.Controls.Add(f);
                        f.Show();
                    }
                    else
                    {
                        // Nếu không tìm thấy Panel cha (trường hợp chạy lẻ Form)
                        f.ShowDialog();
                    }
                    LoadDataBangGia();
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
            if (maHienTai == "") return;

            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();

                    // Bước 1: Kiểm tra xem có bao nhiêu bảng đang "Hoạt động"
                    SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM BangGiaDien WHERE TrangThai = N'Hoạt động'", con);
                    int soLuongDangHoatDong = (int)cmdCount.ExecuteScalar();

                    // Bước 2: Xác định trạng thái mới dựa trên IF ELSE
                    string trangThaiMoi = "";
                    if (cmbTrangThai.Text == "Hoạt động")
                    {
                        // Nếu người dùng muốn KHÓA bảng giá này
                        // Kiểm tra xem nó có phải là cái cuối cùng không
                        if (soLuongDangHoatDong <= 1)
                        {
                            MessageBox.Show("Không thể KHÓA vì đây là bảng giá duy nhất đang hoạt động. Hệ thống cần ít nhất 1 bảng giá để tính tiền!", "Cảnh báo");
                            return; // Dừng lại không làm gì cả
                        }
                        trangThaiMoi = "Khóa";
                    }
                    else
                    {
                        // Nếu người dùng muốn MỞ bảng giá này
                        trangThaiMoi = "Hoạt động";

                        // Tự động Khóa tất cả các bảng khác (để chỉ có 1 cái hoạt động)
                        SqlCommand cmdDisable = new SqlCommand("UPDATE BangGiaDien SET TrangThai = N'Khóa' WHERE MaBangGia <> @ma", con);
                        cmdDisable.Parameters.AddWithValue("@ma", maHienTai);
                        cmdDisable.ExecuteNonQuery();
                    }

                    // Bước 3: Cập nhật trạng thái mới
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE BangGiaDien SET TrangThai = @status WHERE MaBangGia = @ma", con);
                    cmdUpdate.Parameters.AddWithValue("@status", trangThaiMoi);
                    cmdUpdate.Parameters.AddWithValue("@ma", maHienTai);
                    cmdUpdate.ExecuteNonQuery();

                    MessageBox.Show("Đã cập nhật trạng thái bảng giá thành: " + trangThaiMoi);
                    btnLamMoi_Click(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
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
            
            if (palThongTin != null)
                palThongTin.Left = (panelTop.Width - palThongTin.Width) / 2;

            if (pnlSearch != null)
                pnlSearch.Left = (panelTop.Width - pnlSearch.Width) / 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maBG = txtMaBangGia.Text.Trim();
            if (string.IsNullOrEmpty(maBG))
            {
                MessageBox.Show("Vui lòng chọn bảng giá cần xóa từ danh sách!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    connection.Open();

                    string sqlCheckHD = "SELECT COUNT(*) FROM HoaDon WHERE MaBangGia = @ma";
                    SqlCommand cmdCheckHD = new SqlCommand(sqlCheckHD, connection);
                    cmdCheckHD.Parameters.AddWithValue("@ma", maBG);
                    int countHD = (int)cmdCheckHD.ExecuteScalar();

                    if (countHD > 0)
                    {

                        MessageBox.Show($"Không thể xóa! Bảng giá này đã được sử dụng cho {countHD} hóa đơn.\n" +
                                        "Để đảm bảo tính chính xác của báo cáo, bạn chỉ có thể KHÓA bảng giá này.",
                                        "Vi phạm ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    if (cmbTrangThai.Text == "Hoạt động")
                    {
                        string sqlCheckActive = "SELECT COUNT(*) FROM BangGiaDien WHERE TrangThai = N'Hoạt động'";
                        SqlCommand cmdCheckActive = new SqlCommand(sqlCheckActive, connection);
                        int countActive = (int)cmdCheckActive.ExecuteScalar();

                        if (countActive <= 1)
                        {
                            MessageBox.Show("Đây là bảng giá duy nhất đang HOẠT ĐỘNG. Bạn phải có ít nhất 1 bảng giá để hệ thống vận hành!",
                                            "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa vĩnh viễn bảng giá {maBG} không?\n" +
                                                      "Hành động này cũng sẽ xóa toàn bộ các bậc giá chi tiết bên trong.",
                                                      "Xác nhận xóa cứng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        string sqlDeleteChild = "DELETE FROM ChiTietBangGia WHERE MaBangGia = @ma";
                        SqlCommand cmdDelChild = new SqlCommand(sqlDeleteChild, connection);
                        cmdDelChild.Parameters.AddWithValue("@ma", maBG);
                        cmdDelChild.ExecuteNonQuery();
                        string sqlDeleteParent = "DELETE FROM BangGiaDien WHERE MaBangGia = @ma";
                        SqlCommand cmdDelParent = new SqlCommand(sqlDeleteParent, connection);
                        cmdDelParent.Parameters.AddWithValue("@ma", maBG);
                        cmdDelParent.ExecuteNonQuery();

                        MessageBox.Show("Đã xóa vĩnh viễn bảng giá thành công!");
                        btnLamMoi_Click(null, null); // Load lại bảng dữ liệu
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }
    }
}