using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDien.Class;

namespace QuanLyDien.Admin
{
    public partial class FormQuanLyNhanVien : Form
    {
        SqlConnection con;
        Timer searchTimer = new Timer();
        bool isBinding = false;

        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        public void LoadNhanVien()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    // Lấy thêm cột TrangThai
                    string sql = "SELECT MaNV, HoTen, DienThoai, TrangThai FROM NhanVien";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvNhanVien.DataSource = dt;        
                    DataGridViewStyle.ApplyModernStyle(dgvNhanVien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void LoadCmbTrangThai()
        {
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("Hoạt động");
            cmbTrangThai.Items.Add("Khóa");
        }
        private void FormQuanLyNhanVien_Load_1(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadCmbTrangThai();
            searchTimer.Interval = 300;
            searchTimer.Tick += timer1_Tick;

            // Gọi căn chỉnh lần đầu
            panel6_Resize(null, null);
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            isBinding = true;
            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
            txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();
            cmbTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
            isBinding = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu vào biến (Gọn và dễ dùng lại)
            string ma = txtMaNV.Text.Trim();
            string ten = txtHoTen.Text.Trim();
            string dt = txtDienThoai.Text.Trim();
            string trangThai = cmbTrangThai.Text;

            // 2. Kiểm tra rỗng đúng cách
            if (ma == "" || ten == "" || dt == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            try
            {
                // 3. Chỉ dùng 1 khối using duy nhất cho toàn bộ quá trình
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();

                    // BƯỚC A: KIỂM TRA TRÙNG
                    string sqlCheck = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @ma";
                    SqlCommand cmdCheck = new SqlCommand(sqlCheck, con);
                    cmdCheck.Parameters.AddWithValue("@ma", ma);

                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng sử dụng mã khác.");
                        return; // Kết thúc hàm, using sẽ tự đóng kết nối
                    }

                    // BƯỚC B: THÊM MỚI (Vẫn dùng chung kết nối 'con' đang mở)
                    string sqlInsert = "INSERT INTO NhanVien(MaNV, HoTen, DienThoai, TrangThai) VALUES (@ma, @ten, @dt, @trangthai)";
                    SqlCommand cmdInsert = new SqlCommand(sqlInsert, con);
                    cmdInsert.Parameters.AddWithValue("@ma", ma);
                    cmdInsert.Parameters.AddWithValue("@ten", ten);
                    cmdInsert.Parameters.AddWithValue("@dt", dt);
                    cmdInsert.Parameters.AddWithValue("@trangthai", trangThai);

                    cmdInsert.ExecuteNonQuery();

                    // 4. Thông báo và ghi nhật ký
                    MessageBox.Show("Thêm thành công!");
                    NhatKy.Ghi("Thêm", "Nhân Viên", "Thêm nhân viên mã: " + ma);

                    btbClea_Click(null, null); // Làm mới giao diện
                    LoadNhanVien(); // Tải lại bảng
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btbSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text.Trim();
            // Lấy trực tiếp giá trị đang hiển thị trên ComboBox
            string trangThaiMoi = cmbTrangThai.Text;

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!");
                return;
            }

            try
            {
                using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();
                    // Câu lệnh đơn giản: Cập nhật trạng thái theo giá trị ComboBox
                    string sql = "UPDATE NhanVien SET TrangThai = @trangthai WHERE MaNV = @ma";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@trangthai", trangThaiMoi);
                    cmd.Parameters.AddWithValue("@ma", ma);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã cập nhật trạng thái nhân viên thành: " + trangThaiMoi);
                    LoadNhanVien(); // Tải lại bảng để thấy thay đổi
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btbXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text.Trim();
            if (string.IsNullOrEmpty(ma)) return;

            // Thay đổi nội dung hỏi người dùng
            DialogResult rs = MessageBox.Show("Bạn có muốn thay đổi trạng thái hoạt động của nhân viên " + ma + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                try
                {
                    using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
                    {
                        con.Open();
                        // Câu lệnh SQL: Nếu đang Hoạt động thì đổi thành Khóa, và ngược lại
                        string sql = @"UPDATE NhanVien SET TrangThai = CASE  
                        WHEN TrangThai = N'Hoạt động' THEN N'Khóa' ELSE N'Hoạt động'  
                        END WHERE MaNV = @ma";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@ma", ma);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật trạng thái thành công!");
                        NhatKy.Ghi("Cập nhật trạng thái", "Nhân Viên", "Cập nhật trạng thái nhân viên mã: " + ma);
                        LoadNhanVien(); // Tải lại bảng
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    string sql = "SELECT MaNV, HoTen, DienThoai ,TrangThai FROM NhanVien WHERE 1=1";
                    if (!string.IsNullOrEmpty(txtMaNV.Text)) 
                        sql += " AND MaNV LIKE '%" + txtMaNV.Text + "%'";
                    if (!string.IsNullOrEmpty(txtHoTen.Text))
                        sql += " AND HoTen LIKE N'%" + txtHoTen.Text + "%'";
                    if (!string.IsNullOrEmpty(cmbTrangThai.Text))
                        sql += " AND TrangThai LIKE '%" + cmbTrangThai.Text + "%'";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvNhanVien.DataSource = table;
                    DataGridViewStyle.ApplyModernStyle(dgvNhanVien);
                }
            }
            catch { }
        }

        // CĂN GIỮA GIAO DIỆN KHI RESIZE
        private void panel6_Resize(object sender, EventArgs e)
        {
            if (panel1 != null && palThongTin != null && pnlSearch != null)
            {
                palThongTin.Left = (panel1.Width - palThongTin.Width) / 2;
                pnlSearch.Left = (panel1.Width - pnlSearch.Width) / 2;
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e) 
        { 
            if (!isBinding)
            {
                searchTimer.Stop(); 
                searchTimer.Start(); 
            } 
        }
        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            if (!isBinding) 
            { 
                searchTimer.Stop(); searchTimer.Start(); 
            } 
        }
        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        { 
            if (!isBinding)
            { 
                searchTimer.Stop(); searchTimer.Start();
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            btnTim_Click(null, null);
        }

        private void btbClea_Click(object sender, EventArgs e)
        {
            isBinding = true;
            cmbTrangThai.Text = " ";
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtDienThoai.Clear();
            isBinding = false;
            LoadNhanVien();
        }

        private void dgvNhanVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (row.Cells["TrangThai"].Value != null && row.Cells["TrangThai"].Value.ToString() == "Khóa")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray; // Tô màu xám
                    row.DefaultCellStyle.ForeColor = Color.Red;       // Chữ đỏ
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(25, 26, 62); // Màu nền cũ của bạn
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}