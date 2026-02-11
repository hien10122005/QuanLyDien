using Microsoft.ReportingServices.Diagnostics.Internal;
using QuanLyDien.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDien.Admin
{
    public partial class FormQuanLyKhachHang : Form
    {
        SqlConnection con;
        bool isBinding = false;

        public FormQuanLyKhachHang()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadCmbKhuVuc();
            LoadCmbLoaiKH();
            LoadCmbTrangThai();
            LoadDataKhachHang();
            panelTop_Resize(null, null);
        }

        // --- NHÓM 1: NẠP DỮ LIỆU ---

        void LoadCmbKhuVuc()
        {
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaKhuVuc, TenKhuVuc FROM KhuVuc", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbKhuVuc.DataSource = dt;
                cmbKhuVuc.DisplayMember = "TenKhuVuc";
                cmbKhuVuc.ValueMember = "MaKhuVuc";
                cmbKhuVuc.SelectedIndex = -1;
            }
        }

        void LoadCmbLoaiKH()
        {
            cmbLoaiKH.Items.Clear();
            cmbLoaiKH.Items.AddRange(new string[] { "Sinh hoạt", "Kinh doanh", "Sản xuất", "Cơ quan hành chính" });
            cmbLoaiKH.SelectedIndex = -1;
        }

        void LoadCmbTrangThai()
        {
            cmbTrangThai.Items.Clear();
            // cmbTrangThai.Items.AddRange(new string[] { "Hoạt động", "Khóa" });
            cmbTrangThai.Items.Add("Hoạt động");
            cmbTrangThai.Items.Add("Khóa");
              //  cmbt
            cmbTrangThai.SelectedIndex = -1;
        }

        void LoadDataKhachHang()
        {
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                // JOIN với KhuVuc để hiện tên Quận/Huyện cho dễ nhìn
                string sql = @"SELECT MaKH, HoTen, DiaChi, KV.TenKhuVuc, LoaiKH, KH.TrangThai, KH.MaKhuVuc 
                               FROM KhachHang KH 
                               JOIN KhuVuc KV ON KH.MaKhuVuc = KV.MaKhuVuc";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKhachHang.DataSource = dt;
                DataGridViewStyle.ApplyModernStyle(dgvKhachHang);
                // Ẩn cột MaKhuVuc vì đã có TenKhuVuc
                if (dgvKhachHang.Columns.Contains("MaKhuVuc"))
                    dgvKhachHang.Columns["MaKhuVuc"].Visible = false;
            }
        }

        // --- NHÓM 2: CÁC NÚT CHỨC NĂNG ---

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtHoTen.Text == "" || cmbKhuVuc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đủ Mã, Tên và chọn Khu vực!");
                return;
            }

            try
            {
                using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();
                    string sql = "INSERT INTO KhachHang VALUES (@ma, @ten, @dc, @kv, @loai, @tt)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ma", txtMaKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtHoTen.Text.Trim());
                    cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@kv", cmbKhuVuc.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@loai", cmbLoaiKH.Text);
                    cmd.Parameters.AddWithValue("@tt", cmbTrangThai.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm khách hàng thành công!");
                    btnLamMoi_Click(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "") return;
            try
            {
                using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();
                    string sql = @"UPDATE KhachHang SET HoTen=@ten, DiaChi=@dc, MaKhuVuc=@kv, 
                                   LoaiKH=@loai, TrangThai=@tt WHERE MaKH=@ma";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ma", txtMaKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtHoTen.Text.Trim());
                    cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@kv", cmbKhuVuc.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@loai", cmbLoaiKH.Text);
                    cmd.Parameters.AddWithValue("@tt", cmbTrangThai.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                    btnLamMoi_Click(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "") return;
            string trangThaiMoi;
          string  maKH = txtMaKH.Text;
            if (cmbTrangThai.Text == "Hoạt động")
            {
                trangThaiMoi = "Khóa";
            }
            else
            {
                trangThaiMoi = "Hoạt động";
            }

            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                if (cmbTrangThai.Text == "Hoạt động")
                {
                    // Truy vấn kiểm tra: Có hóa đơn nào của khách này đang bị "CẮT ĐIỆN" mà "CHƯA THANH TOÁN" không?
                    string sqlCheck = @"SELECT COUNT(*) 
                                FROM BienPhapXuLy sl 
                                JOIN HoaDon hd ON sl.MaHoaDon = hd.MaHoaDon 
                                WHERE hd.MaKH = @ma 
                                AND sl.NoiDung LIKE N'%CẮT ĐIỆN%' 
                                AND hd.TrangThaiThanhToan = N'Chưa thanh toán'";
                    SqlCommand cmdCheck = new SqlCommand(sqlCheck, con);
                    cmdCheck.Parameters.AddWithValue("@ma", maKH);
                    int soHoaDonViPham = (int)cmdCheck.ExecuteScalar();
                    if (soHoaDonViPham > 0)
                    {
                        MessageBox.Show($"Không thể mở khóa! Khách hàng này đang có {soHoaDonViPham} hóa đơn nợ quá hạn bị CẮT ĐIỆN. Vui lòng thanh toán trước!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        cmbTrangThai.Text = "Khóa";
                        return;
                    }
                }
                string sql = "UPDATE KhachHang SET TrangThai = @TrangThai WHERE MaKH = @ma";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TrangThai", trangThaiMoi);
                cmd.Parameters.AddWithValue("@ma", maKH);
                cmd.ExecuteNonQuery();
                if (trangThaiMoi == "Khóa")
                {
                    string sqlDH = "UPDATE DongHoDien SET TrangThai = N'Ngừng Cấp Điện' WHERE MaKH = @ma";
                    SqlCommand cmdDH = new SqlCommand(sqlDH, con);
                    cmdDH.Parameters.AddWithValue("@ma", maKH);
                    cmdDH.ExecuteNonQuery();
                    MessageBox.Show("Đã ngừng cấp điện khách hàng và ngừng cấp điện đồng hồ!");
                }
                else // Trường hợp Mở lại
                {
                    string sqlDH = "UPDATE DongHoDien SET TrangThai = N'Hoạt động' WHERE MaKH = @ma";
                    SqlCommand cmdDH = new SqlCommand(sqlDH, con);
                    cmdDH.Parameters.AddWithValue("@ma", maKH);
                    cmdDH.ExecuteNonQuery();
                    MessageBox.Show("Đã mở lại trạng thái khách hàng và đồng hồ!");
                }
                MessageBox.Show("Đã đổi trạng thái khách hàng sang: " + trangThaiMoi);
                btnLamMoi_Click(null, null);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            isBinding = true;
            txtMaKH.Clear();
            txtMaKH.ReadOnly = false;
            txtHoTen.Clear();
            txtDiaChi.Clear();
            cmbKhuVuc.SelectedIndex = -1;
            cmbLoaiKH.SelectedIndex = -1;
            cmbTrangThai.SelectedIndex = -1;
            isBinding = false;
            LoadDataKhachHang();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            isBinding = true;
            DataGridViewRow r = dgvKhachHang.Rows[e.RowIndex];

            txtMaKH.Text = r.Cells["MaKH"].Value.ToString();
            txtMaKH.ReadOnly = true; // Khóa mã không cho sửa
            txtHoTen.Text = r.Cells["HoTen"].Value.ToString();
            txtDiaChi.Text = r.Cells["DiaChi"].Value.ToString();
            cmbKhuVuc.Text = r.Cells["TenKhuVuc"].Value.ToString();
            cmbLoaiKH.Text = r.Cells["LoaiKH"].Value.ToString();
            cmbTrangThai.Text = r.Cells["TrangThai"].Value.ToString();
            isBinding = false;
        }

        private void panelTop_Resize(object sender, EventArgs e)
        {
            if (palThongTin != null) palThongTin.Left = (panelTop.Width - palThongTin.Width) / 2;
            if (pnlSearch != null) pnlSearch.Left = (panelTop.Width - pnlSearch.Width) / 2;
        }
    }
}