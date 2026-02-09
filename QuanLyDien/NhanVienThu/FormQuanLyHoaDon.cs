using QuanLyDien.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;

namespace QuanLyDien.NhanVienThu
{
    public partial class FormQuanLyHoaDon : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;

        public FormQuanLyHoaDon()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu mặc định
            nudThang.Value = DateTime.Now.Month;
            nudNam.Value = DateTime.Now.Year;

            LoadCmbTrangThai();
            LoadDataHoaDon();
            panelTop_Resize(null, null);
        }

        // --- NHÓM 1: NẠP DỮ LIỆU ---

        void LoadCmbTrangThai()
        {
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("Chưa thanh toán");
            cmbTrangThai.Items.Add("Đã thanh toán");
            cmbTrangThai.SelectedIndex = 0;
        }

        void LoadDataHoaDon()
        {
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                // JOIN với khách hàng để hiện tên cho dễ nhìn
                string sql = @"SELECT MaHoaDon, HoaDon.MaKH, HoTen, Thang, Nam, TongTien, TrangThaiThanhToan, NgayThanhToan 
                               FROM HoaDon JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH 
                               ORDER BY Nam DESC, Thang DESC";
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
                dgvHoaDon.DataSource = dt;
                DataGridViewStyle.ApplyModernStyle(dgvHoaDon);
                // Định dạng tiêu đề cột
                dgvHoaDon.Columns["MaHoaDon"].HeaderText = "Mã HĐ";
                dgvHoaDon.Columns["HoTen"].HeaderText = "Khách Hàng";
                dgvHoaDon.Columns["TongTien"].HeaderText = "Số Tiền";
                dgvHoaDon.Columns["TrangThaiThanhToan"].HeaderText = "Trạng Thái";
            }
        }

        // --- NHÓM 2: XỬ LÝ THANH TOÁN ---

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần thu tiền!");
                return;
            }

            if (cmbTrangThai.Text == "Đã thanh toán")
            {
                MessageBox.Show("Hóa đơn này đã thanh toán rồi!");
                return;
            }

            try
            {
                using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();
                    // Cập nhật trạng thái thành Đã thanh toán và lưu ngày thu hiện tại
                    string sql = @"UPDATE HoaDon SET TrangThaiThanhToan = N'Đã thanh toán', 
                                   NgayThanhToan = GETDATE() WHERE MaHoaDon = @ma";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ma", txtMaHD.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xác nhận thanh toán thành công!");
                    LoadDataHoaDon(); // Tải lại bảng
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // --- NHÓM 3: XỬ LÝ IN HÓA ĐƠN (QUAN TRỌNG) ---

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {        
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn trong bảng bên dưới trước khi nhấn In!");
                return;
            }
            if (cmbTrangThai.Text == "Chưa thanh toán")
            {
                MessageBox.Show("Khách Hàng Chưa Thanh Toán Không Thể In Hóa Đơn !!!", "Thong Báo", MessageBoxButtons.OK);
                return;
            }
            // Lấy mã hóa đơn đang hiện ở ô TextBox
            string ma = txtMaHD.Text;

            // Khởi tạo Form In và truyền mã vào
            FormInHoaDonDien frm = new FormInHoaDonDien(ma);
            frm.Show();
        }

        // --- NHÓM 4: CÁC SỰ KIỆN GIAO DIỆN ---

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvHoaDon.Rows[e.RowIndex];

            txtMaHD.Text = r.Cells["MaHoaDon"].Value.ToString();
            txtTenKH.Text = r.Cells["HoTen"].Value.ToString();
            txtTongTien.Text = string.Format("{0:N0}", r.Cells["TongTien"].Value);
            cmbTrangThai.Text = r.Cells["TrangThaiThanhToan"].Value.ToString();

            // Nếu đã thanh toán rồi thì hiện ngày thu, chưa thì hiện ngày hiện tại
            if (r.Cells["NgayThanhToan"].Value != DBNull.Value)
                dtpNgayThanhToan.Value = Convert.ToDateTime(r.Cells["NgayThanhToan"].Value);
            else
                dtpNgayThanhToan.Value = DateTime.Now;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                string sql = "SELECT MaHoaDon, HoaDon.MaKH, HoTen, Thang, Nam, TongTien, TrangThaiThanhToan,NgayThanhToan FROM HoaDon JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH WHERE Thang = @t AND Nam = @n";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@t", nudThang.Value);
                cmd.Parameters.AddWithValue("@n", nudNam.Value);

                da = new SqlDataAdapter(cmd);
                DataTable dtTim = new DataTable();
                da.Fill(dtTim);
                dgvHoaDon.DataSource = dtTim;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            txtTenKH.Clear();
            txtTongTien.Clear();
            LoadDataHoaDon();
        }

        private void panelTop_Resize(object sender, EventArgs e)
        {
            if (panelTop != null && palThongTin != null)
            {
                palThongTin.Left = (panelTop.Width - palThongTin.Width) / 2;
            }

            if (panelTop != null && pnlSearch != null)
            {
                pnlSearch.Left = (panelTop.Width - pnlSearch.Width) / 2;
            }
        }

        private void dgvHoaDon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                // 1. Kiểm tra nếu là dòng mới (dòng trống cuối cùng) thì bỏ qua
                if (row.IsNewRow) continue;

                // 2. Kiểm tra ô dữ liệu có tồn tại và có giá trị không
                if (row.Cells["TrangThaiThanhToan"] != null && row.Cells["TrangThaiThanhToan"].Value != null)
                {
                    string status = row.Cells["TrangThaiThanhToan"].Value.ToString();

                    if (status == "Chưa thanh toán")
                    {
                        // Tô màu đỏ và in đậm cho nổi bật
                        row.Cells["TrangThaiThanhToan"].Style.ForeColor = Color.Red;
                        row.Cells["TrangThaiThanhToan"].Style.Font = new Font(dgvHoaDon.Font, FontStyle.Bold);
                    }
                    else if (status == "Đã thanh toán")
                    {
                        // Tô màu xanh lá cho hóa đơn đã thu tiền
                        row.Cells["TrangThaiThanhToan"].Style.ForeColor = Color.LimeGreen;
                    }
                }
            }
        }
    }
}