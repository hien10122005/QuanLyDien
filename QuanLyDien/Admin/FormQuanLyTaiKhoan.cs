using QuanLyDien.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Data;
using System.Windows.Forms;

namespace QuanLyDien.Admin
{
    public partial class FormQuanLyTaiKhoan : Form
    {
        // Khai báo các đối tượng dùng chung
        SqlConnection ketNoi;
        SqlDataAdapter adapter;
        DataTable duLieu;
      
        public FormQuanLyTaiKhoan()
        {
            InitializeComponent();
            // Cấu hình để nhúng vào panel chính
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadComboboxNhanVien(); // Lấy danh sách nhân viên vào máy
            LoadComboboxHeThong(); // Nạp Vai trò và Trạng thái
            LoadDanhSachTaiKhoan(); // Hiển thị bảng tài khoản
            panelTop_Resize(null, null); // Căn giữa giao diện
            btbClea_Click(null, null);
        }

        // --- 1. HÀM NẠP DỮ LIỆU ---

        void LoadComboboxNhanVien()
        {
            using (ketNoi = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                // Lấy MaNV và HoTen để hiển thị
                string sql = "SELECT MaNV, HoTen FROM NhanVien WHERE TrangThai = N'Hoạt động'";
                adapter = new SqlDataAdapter(sql, ketNoi);
                DataTable dtNV = new DataTable();
                adapter.Fill(dtNV);

                cmbMaNV.DataSource = dtNV;
                cmbMaNV.DisplayMember = "HoTen"; // Hiển thị tên
                cmbMaNV.ValueMember = "MaNV";    // Giá trị ngầm là mã
              
            }
        }

        void LoadComboboxHeThong()
        {
            // Nạp vai trò
            cmbVaiTro.Items.Clear();
            cmbVaiTro.Items.AddRange(new string[] { "Admin", "Nhân Viên Thu Tiền", "Nhân Viên Ghi Số" });
            cmbVaiTro.SelectedIndex = 0;

            // Nạp trạng thái
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.AddRange(new string[] { "Hoạt động", "Khóa" });
            cmbTrangThai.SelectedIndex = -1;
        }

        void LoadDanhSachTaiKhoan()
        {
            using (ketNoi = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                // Dùng JOIN để lấy luôn tên nhân viên cho dễ nhìn
                string sql = @"SELECT TenDangNhap, ND.MaNV, HoTen, MatKhau, VaiTro, ND.TrangThai 
                               FROM NguoiDung ND JOIN NhanVien NV ON ND.MaNV = NV.MaNV";
                adapter = new SqlDataAdapter(sql, ketNoi);
                duLieu = new DataTable();
                adapter.Fill(duLieu);
                dgvTaiKhoan.DataSource = duLieu;
                DataGridViewStyle.ApplyModernStyle(dgvTaiKhoan);
            }
        }

        // --- 2. HÀM XỬ LÝ CLICK BẢNG ---

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];

            txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
            txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            cmbMaNV.SelectedValue = row.Cells["MaNV"].Value.ToString();
            cmbVaiTro.Text = row.Cells["VaiTro"].Value.ToString();
            cmbTrangThai.Text = row.Cells["TrangThai"].Value.ToString();

           txtTenDangNhap.ReadOnly = true;
        }

        // --- 3. CÁC NÚT CHỨC NĂNG ---

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ Tên đăng nhập và Mật khẩu!");
                return;
            }

            try
            {
                using (ketNoi = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    ketNoi.Open();
                    // Kiểm tra trùng tên đăng nhập
                    string check = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @user";
                    SqlCommand cmdCheck = new SqlCommand(check, ketNoi);
                    cmdCheck.Parameters.AddWithValue("@user", txtTenDangNhap.Text);
                    if ((int)cmdCheck.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Tên đăng nhập này đã tồn tại!");
                        return;
                    }

                    // Thực hiện thêm
                    string sql = "INSERT INTO NguoiDung VALUES (@user, @ma, @pass, @quyen, @tinhtrang)";
                    SqlCommand cmd = new SqlCommand(sql, ketNoi);
                    cmd.Parameters.AddWithValue("@user", txtTenDangNhap.Text);
                    cmd.Parameters.AddWithValue("@ma", cmbMaNV.SelectedValue);
                    cmd.Parameters.AddWithValue("@pass", txtMatKhau.Text);
                    cmd.Parameters.AddWithValue("@quyen", cmbVaiTro.Text);
                    cmd.Parameters.AddWithValue("@tinhtrang", cmbTrangThai.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tạo tài khoản thành công!");
                    NhatKy.Ghi("Thêm", "NguoiDung", "Tạo tài khoản " + txtTenDangNhap.Text + "cho nhân viên " +cmbMaNV.Text);
                    btbClea_Click(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (ketNoi = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    ketNoi.Open();
                    string sql = "UPDATE NguoiDung SET MatKhau=@pass, VaiTro=@quyen, TrangThai=@status WHERE TenDangNhap=@user";
                    SqlCommand cmd = new SqlCommand(sql, ketNoi);
                    cmd.Parameters.AddWithValue("@user", txtTenDangNhap.Text);
                    cmd.Parameters.AddWithValue("@pass", txtMatKhau.Text);
                    cmd.Parameters.AddWithValue("@quyen", cmbVaiTro.Text);
                    cmd.Parameters.AddWithValue("@status", cmbTrangThai.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thành công!");
                    NhatKy.Ghi("Sửa", "NguoiDung", "Cập nhật tài khoản " + txtTenDangNhap.Text + "cho nhân viên " + cmbMaNV.Text);
                    btbClea_Click(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

       /* private void btnXoa_Click(object sender, EventArgs e)
        {
            // Logic: Đổi trạng thái từ Hoạt động -> Khóa (Giống Form Nhân viên bạn vừa làm)
            if (txtTenDangNhap.Text == "") return;

            string trangThaiMoi = cmbTrangThai.Text == "Hoạt động" ? "Khóa" : "Hoạt động";

            using (ketNoi = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                ketNoi.Open();
                string sql = "UPDATE NguoiDung SET TrangThai = @status WHERE TenDangNhap = @user";
                SqlCommand cmd = new SqlCommand(sql, ketNoi);
                cmd.Parameters.AddWithValue("@status", trangThaiMoi);
                cmd.Parameters.AddWithValue("@user", txtTenDangNhap.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Đã đổi trạng thái sang: " + trangThaiMoi);
                NhatKy.Ghi("Xóa", "NguoiDung", "Đổi trạng thái tài khoản " + txtTenDangNhap + "cho nhân viên " + cmbMaNV.Text + " thành " + trangThaiMoi);
                btbClea_Click(null, null);
            }
        }*/

        private void btnTim_Click(object sender, EventArgs e)
        {
            using (ketNoi = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                string sql = "SELECT * FROM NguoiDung WHERE TenDangNhap LIKE '%" + txtTenDangNhap.Text + "%'";
                adapter = new SqlDataAdapter(sql, ketNoi);
                DataTable dtTim = new DataTable();
                adapter.Fill(dtTim);
                dgvTaiKhoan.DataSource = dtTim;
            }
        }

        private void btbClea_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Clear();
            txtTenDangNhap.ReadOnly = false;
            txtMatKhau.Clear();
            cmbMaNV.Text = " ";
            cmbTrangThai.Text = " ";
            cmbVaiTro.Text = " ";
            LoadDanhSachTaiKhoan();
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string TenDangNhap = this.txtTenDangNhap.Text;
            string trangThai = cmbTrangThai.Text;
            if (string.IsNullOrEmpty(TenDangNhap))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần khóa/mở từ danh sách!");
                return;
            }
            DialogResult re = MessageBox.Show("Bạn có chắc muốn thay đổi trạng thái tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No)
            {
                return;
            }
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    ketNoi.Open();
                    // Câu lệnh SQL cập nhật trạng thái
                    string sql = "UPDATE NguoiDung SET TrangThai = @TrangThai WHERE TenDangNhap = @TenDangNhap";
                    SqlCommand cmd = new SqlCommand(sql, ketNoi);

                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);

                    cmd.ExecuteNonQuery();// Thực thi câu lệnh SQL

                    MessageBox.Show("Xóa trạng thái tài khoản thành công!");
                    NhatKy.Ghi("Xóa", "NguoiDung", "Thay đổi trạng thái tài khoản " + txtTenDangNhap.Text + " thành " + trangThai);
                    btbClea_Click(null, null); // Xóa trắng ô nhập và nạp lại bảng
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        // --- 4. GIAO DIỆN ---

        private void panelTop_Resize(object sender, EventArgs e)
        {
            // Căn giữa card thông tin
            palThongTin.Left = (panelTop.Width - palThongTin.Width) / 2;
            // Căn giữa hàng nút bấm
            pnlSearch.Left = (panelTop.Width - pnlSearch.Width) / 2;
        }

        private void dgvTaiKhoan_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Tô màu tài khoản bị khóa
            foreach (DataGridViewRow row in dgvTaiKhoan.Rows)
            {
                if (row.Cells["TrangThai"].Value != null && row.Cells["TrangThai"].Value.ToString() == "Khóa")
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void cmbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isBinding = false;
            // Nếu đang trong quá trình đổ dữ liệu từ CellClick hoặc Load thì không chạy
            if (isBinding) return;

            // Kiểm tra xem đã chọn nhân viên nào chưa
            if (cmbMaNV.SelectedValue == null || cmbMaNV.SelectedIndex == -1) return;

            // Lấy Mã nhân viên đang chọn (Lưu ý: SelectedValue trả về MaNV)
            string maNV = cmbMaNV.SelectedValue.ToString();

            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();
                    // Truy vấn thông tin tài khoản của nhân viên này
                    string sql = "SELECT TenDangNhap, MatKhau, VaiTro, TrangThai FROM NguoiDung WHERE MaNV = @ma";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ma", maNV);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // Nếu tìm thấy (Nhân viên này ĐÃ CÓ tài khoản)
                    {
                        txtTenDangNhap.Text = reader["TenDangNhap"].ToString();
                        txtMatKhau.Text = reader["MatKhau"].ToString();
                        cmbVaiTro.Text = reader["VaiTro"].ToString();
                        cmbTrangThai.Text = reader["TrangThai"].ToString();

                        // Khóa ô Tên đăng nhập vì tài khoản đã tồn tại (chỉ cho phép sửa mật khẩu/vai trò)
                        txtTenDangNhap.ReadOnly = true;
                    }
                    else // Nếu không tìm thấy (Nhân viên này CHƯA CÓ tài khoản)
                    {
                        // Xóa trắng các ô để Admin nhập mới
                        txtTenDangNhap.Clear();
                        txtTenDangNhap.ReadOnly = false;
                        txtMatKhau.Clear();
                        cmbVaiTro.SelectedIndex = -1;
                        cmbTrangThai.SelectedIndex = -1;
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}