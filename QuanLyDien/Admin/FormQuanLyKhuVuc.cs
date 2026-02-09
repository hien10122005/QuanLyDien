using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDien.Class; // Chứa chuỗi kết nối

namespace QuanLyDien.Admin
{
    public partial class FormQuanLyKhuVuc : Form
    {
        // Khai báo các đối tượng cơ bản
        SqlConnection ketNoi;
        SqlDataAdapter adapter;
        DataTable duLieu;

        public FormQuanLyKhuVuc()
        {
            InitializeComponent();
            // Cấu hình form con
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void FormQuanLyKhuVuc_Load(object sender, EventArgs e)
        {
            LoadDataKhuVuc(); // Nạp dữ liệu lên bảng khi mở form
            panelTop_Resize(null, null); // Căn giữa giao diện
        }

        // --- 1. HÀM TẢI DỮ LIỆU ---
        void LoadDataKhuVuc()
        {
            try
            {
                using (ketNoi = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    string sql = "SELECT MaKhuVuc, TenKhuVuc FROM KhuVuc";
                    adapter = new SqlDataAdapter(sql, ketNoi);
                    duLieu = new DataTable();
                    adapter.Fill(duLieu);
                    dgvKhuVuc.DataSource = duLieu;

                    // Đặt lại tên cột cho đẹp
                    dgvKhuVuc.Columns[0].HeaderText = "Mã Khu Vực";
                    dgvKhuVuc.Columns[1].HeaderText = "Tên Khu Vực";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // --- 2. CHỨC NĂNG THÊM ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã nhập đủ chưa
            if (txtMaKhuVuc.Text == "" || txtTenKhuVuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên khu vực!");
                return;
            }

            try
            {
                using (ketNoi = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    ketNoi.Open();
                    // Bước A: Kiểm tra xem mã này đã tồn tại chưa
                    string checkSql = "SELECT COUNT(*) FROM KhuVuc WHERE MaKhuVuc = @ma";
                    SqlCommand cmdCheck = new SqlCommand(checkSql, ketNoi);
                    cmdCheck.Parameters.AddWithValue("@ma", txtMaKhuVuc.Text.Trim());

                    int tonTai = (int)cmdCheck.ExecuteScalar();
                    if (tonTai > 0)
                    {
                        MessageBox.Show("Mã khu vực này đã có trong hệ thống!");
                        return;
                    }

                    // Bước B: Thực hiện thêm mới
                    string sql = "INSERT INTO KhuVuc VALUES (@ma, @ten)";
                    SqlCommand cmd = new SqlCommand(sql, ketNoi);
                    cmd.Parameters.AddWithValue("@ma", txtMaKhuVuc.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtTenKhuVuc.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm khu vực mới thành công!");
                    btnLamMoi_Click(null, null); // Xóa trắng ô nhập và tải lại bảng
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thêm: " + ex.Message); }
        }

        // --- 3. CHỨC NĂNG SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhuVuc.Text == "") return;

            try
            {
                using (ketNoi = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    ketNoi.Open();
                    // Cập nhật tên khu vực dựa trên mã
                    string sql = "UPDATE KhuVuc SET TenKhuVuc = @ten WHERE MaKhuVuc = @ma";
                    SqlCommand cmd = new SqlCommand(sql, ketNoi);
                    cmd.Parameters.AddWithValue("@ma", txtMaKhuVuc.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtTenKhuVuc.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    btnLamMoi_Click(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi sửa: " + ex.Message); }
        }

        // --- 4. CHỨC NĂNG XÓA ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhuVuc.Text == "") return;

            DialogResult dr = MessageBox.Show("Xóa khu vực sẽ ảnh hưởng đến các khách hàng bên trong. Bạn chắc chắn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (ketNoi = new SqlConnection(ChuoiKetNoi.KetNoi))
                    {
                        ketNoi.Open();
                        string sql = "DELETE FROM KhuVuc WHERE MaKhuVuc = @ma";
                        SqlCommand cmd = new SqlCommand(sql, ketNoi);
                        cmd.Parameters.AddWithValue("@ma", txtMaKhuVuc.Text.Trim());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đã xóa khu vực!");
                        btnLamMoi_Click(null, null);
                    }
                }
                catch
                {
                    // Thường lỗi do đang có Khách hàng thuộc khu vực này (Khóa ngoại)
                    MessageBox.Show("Không thể xóa khu vực này vì đang có khách hàng thuộc khu vực này!");
                }
            }
        }

        // --- 5. CÁC HÀM HỖ TRỢ GIAO DIỆN ---

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKhuVuc.Clear();
            txtTenKhuVuc.Clear();
            txtMaKhuVuc.ReadOnly = false; // Cho phép nhập mã khi thêm mới
            LoadDataKhuVuc(); // Tải lại bảng
        }

        private void dgvKhuVuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Nếu nhấn vào tiêu đề thì bỏ qua

            DataGridViewRow r = dgvKhuVuc.Rows[e.RowIndex];
            txtMaKhuVuc.Text = r.Cells["MaKhuVuc"].Value.ToString();
            txtTenKhuVuc.Text = r.Cells["TenKhuVuc"].Value.ToString();

            // Khi chọn để sửa, không cho phép đổi Mã (Primary Key)
            txtMaKhuVuc.ReadOnly = true;
        }

        private void panelTop_Resize(object sender, EventArgs e)
        {
            // Căn giữa 2 panel thông tin và nút bấm
            if (palThongTin != null)
                palThongTin.Left = (panelTop.Width - palThongTin.Width) / 2;

            if (pnlSearch != null)
                pnlSearch.Left = (panelTop.Width - pnlSearch.Width) / 2;
        }
    }
}