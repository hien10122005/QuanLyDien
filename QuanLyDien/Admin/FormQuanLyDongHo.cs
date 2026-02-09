using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDien.Class;

namespace QuanLyDien.Admin
{
    public partial class FormQuanLyDongHo : Form
    {
        SqlConnection con;
        bool isBinding = false; // Biển báo: "Đang gán dữ liệu, các sự kiện đừng chạy"

        public FormQuanLyDongHo()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void FormQuanLyDongHo_Load(object sender, EventArgs e)
        {
            LoadComboBoxKhuVuc();   // 1. Nạp các Quận/Huyện vào ô Lọc
            LoadComboBoxTrangThai(); // 2. Nạp trạng thái (Hoạt động, Bảo trì...)
            HienThiTatCaDongHo();   // 3. Mặc định hiện hết đồng hồ lên bảng
            panelTop_Resize(null, null); // Căn giữa giao diện
        }

        // ======================================================
        // NHÓM 1: CÁC HÀM NẠP DỮ LIỆU LÊN GIAO DIỆN
        // ======================================================

        // Hàm lấy danh sách Khu Vực từ SQL để cho người dùng chọn lọc
        void LoadComboBoxKhuVuc()
        {
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaKhuVuc, TenKhuVuc FROM KhuVuc", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Thêm một dòng "Tất cả" lên đầu danh sách để chọn xem toàn bộ
                DataRow dr = dt.NewRow();
                dr["MaKhuVuc"] = "ALL";
                dr["TenKhuVuc"] = "-- Xem tất cả khu vực --";
                dt.Rows.InsertAt(dr, 0);

                cmbLocKhuVuc.DataSource = dt;
                cmbLocKhuVuc.DisplayMember = "TenKhuVuc";
                cmbLocKhuVuc.ValueMember = "MaKhuVuc";
            }
        }

        // Hàm nạp danh sách Khách Hàng (Dùng để lắp đặt đồng hồ mới)
        // Lưu ý: Chỉ hiện khách hàng thuộc khu vực đang chọn
        void LoadComboBoxKhachHang(string maKV)
        {
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                string sql = "SELECT MaKH, HoTen FROM KhachHang WHERE MaKhuVuc = @ma";
                if (maKV == "ALL") sql = "SELECT MaKH, HoTen FROM KhachHang"; // Nếu xem tất cả thì hiện hết khách

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", maKV);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbKhachHang.DataSource = dt;
                cmbKhachHang.DisplayMember = "HoTen";
                cmbKhachHang.ValueMember = "MaKH";
                cmbKhachHang.SelectedIndex = -1; // Để trống ô khách hàng lúc mới đầu
            }
        }

        // Hàm hiện dữ liệu lên bảng (DataGridView)
        void HienThiTatCaDongHo(string maKV = "ALL")
        {
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                // Câu lệnh JOIN để lấy tên Khách Hàng và tên Khu Vực thay vì hiện Mã số
                string sql = @"SELECT MaDongHo, KH.HoTen, KV.TenKhuVuc, NgayLap, DH.TrangThai 
                               FROM DongHoDien DH 
                               JOIN KhachHang KH ON DH.MaKH = KH.MaKH 
                               JOIN KhuVuc KV ON KH.MaKhuVuc = KV.MaKhuVuc";

                // Nếu người dùng chọn 1 khu vực cụ thể thì thêm điều kiện WHERE
                if (maKV != "ALL") sql += " WHERE KV.MaKhuVuc = @ma";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", maKV);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDongHo.DataSource = dt;
                DataGridViewStyle.ApplyModernStyle(dgvDongHo);
            }
        }

        // ======================================================
        // NHÓM 2: XỬ LÝ LOGIC LỌC (PHẦN BẠN MUỐN BIẾT)
        // ======================================================

        private void cmbLocKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra tránh lỗi khi dữ liệu đang load
            if (cmbLocKhuVuc.SelectedValue == null || cmbLocKhuVuc.SelectedValue is DataRowView) return;

            string maKV_DangChon = cmbLocKhuVuc.SelectedValue.ToString();

            // Bước 1: Lọc danh sách đồng hồ ở dưới bảng cho đúng khu vực đó
            HienThiTatCaDongHo(maKV_DangChon);

            // Bước 2: Cập nhật luôn ô "Chọn khách hàng" ở trên (chỉ hiện người ở khu vực đó)
            LoadComboBoxKhachHang(maKV_DangChon);
        }

        // ======================================================
        // NHÓM 3: CÁC NÚT BẤM VÀ CLICK BẢNG
        // ======================================================

        private void dgvDongHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            isBinding = true; // Bật biển báo chặn các sự kiện Changed chạy lung tung

            DataGridViewRow r = dgvDongHo.Rows[e.RowIndex];
            txtMaDongHo.Text = r.Cells["MaDongHo"].Value.ToString();
            cmbKhachHang.Text = r.Cells["HoTen"].Value.ToString();
            dtpNgayLap.Value = Convert.ToDateTime(r.Cells["NgayLap"].Value);
            cmbTrangThai.Text = r.Cells["TrangThai"].Value.ToString();

            isBinding = false; // Tắt biển báo
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDongHo.Text == "" || cmbKhachHang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đủ Mã ĐH và chọn Khách hàng!");
                return;
            }

            try
            {
                using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();
                    string sql = "INSERT INTO DongHoDien VALUES (@ma, @makh, @ngay, @tt)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ma", txtMaDongHo.Text.Trim());
                    cmd.Parameters.AddWithValue("@makh", cmbKhachHang.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@ngay", dtpNgayLap.Value);
                    cmd.Parameters.AddWithValue("@tt", cmbTrangThai.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã lắp đặt đồng hồ mới thành công!");
                    btnLamMoi_Click(null, null); // Xóa trắng ô nhập và nạp lại bảng
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDongHo.Clear();
            cmbLocKhuVuc.SelectedIndex = 0; // Quay về "Xem tất cả"
            HienThiTatCaDongHo();
        }

        // Hàm đơn giản để nạp danh sách trạng thái
        void LoadComboBoxTrangThai()
        {
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("Hoạt động");
            cmbTrangThai.Items.Add("Bảo trì");
            cmbTrangThai.Items.Add("Ngừng cấp điện");
            cmbTrangThai.SelectedIndex = 0;
        }

        private void panelTop_Resize(object sender, EventArgs e)
        {
            if (palThongTin != null) palThongTin.Left = (panelTop.Width - palThongTin.Width) / 2;
            if (pnlSearch != null) pnlSearch.Left = (panelTop.Width - pnlSearch.Width) / 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDongHo.Text))
            {
                MessageBox.Show("Vui lòng chọn đồng hồ cần sửa từ danh sách!");
                return;
            }

            try
            {
                using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    string maDongHo = txtMaDongHo.Text.Trim();
                    string trangThaiMoi = cmbTrangThai.Text;
                    con.Open();
                    string sql = "UPDATE DongHoDien SET TrangThai = @trangthai WHERE MaDongHo = @madh";
             
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@trangthai", trangThaiMoi);
                    cmd.Parameters.AddWithValue("@madh", maDongHo);
                    int ketQua = cmd.ExecuteNonQuery();
                    if (ketQua > 0)
                    {
                        MessageBox.Show("Cập nhật trạng thái đồng hồ thành công!");
                        btnLamMoi_Click(null, null); // Load lại bảng và xóa trắng ô nhập
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã đồng hồ này trong hệ thống!");
                    }
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}