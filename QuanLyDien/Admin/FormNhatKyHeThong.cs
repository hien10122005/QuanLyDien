using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDien.Class;

namespace QuanLyDien.ChucNangChung
{
    public partial class FormNhatKyHeThong : Form
    {
        public FormNhatKyHeThong()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }
        public void LoadCmbVaiTro()
        {
            cmbVaiTro.Items.Clear();
            cmbVaiTro.Items.Add("Tất cả");
            cmbVaiTro.Items.Add("Admin");
            cmbVaiTro.Items.Add("Nhân Viên Thu Tiền");
            cmbVaiTro.Items.Add("Nhân Viên Ghi Số");
            cmbVaiTro.SelectedIndex = 0;
            dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDate.Value = DateTime.Now;
            LoadNhatKy();
        }
        private void FormNhatKyHeThong_Load(object sender, EventArgs e)
        {
            // Mặc định lọc từ đầu tháng đến hiện tại
            dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDate.Value = DateTime.Now;
            LoadCmbVaiTro();
            LoadNhatKy();
        }

        public void LoadNhatKy()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    // Lấy dữ liệu và sắp xếp cái mới nhất lên đầu (DESC)
                    string sql = "SELECT TenDangNhap, VaiTro, HanhDong, TenBang, NoiDung, ThoiGian FROM NhatKyHeThong ORDER BY ThoiGian DESC";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvNhatKy.DataSource = dt;

                    // Đặt tên cột tiếng Việt
                    dgvNhatKy.Columns["TenDangNhap"].HeaderText = "Tài khoản";
                    dgvNhatKy.Columns["VaiTro"].HeaderText = "Vai trò";
                    dgvNhatKy.Columns["HanhDong"].HeaderText = "Hành động";
                    dgvNhatKy.Columns["TenBang"].HeaderText = "Bảng tác động";
                    dgvNhatKy.Columns["NoiDung"].HeaderText = "Chi tiết nội dung";
                    dgvNhatKy.Columns["ThoiGian"].HeaderText = "Thời gian";

                    // Định dạng cột thời gian
                    dgvNhatKy.Columns["ThoiGian"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                    DataGridViewStyle.ApplyModernStyle(dgvNhatKy);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải nhật ký: " + ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    // 1. Câu lệnh gốc lọc theo ngày (luôn có)
                    string sql = @"SELECT TenDangNhap, VaiTro, HanhDong, TenBang, NoiDung, ThoiGian 
                           FROM NhatKyHeThong 
                           WHERE CAST(ThoiGian AS DATE) BETWEEN @tu AND @den";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    // 2. Lọc theo Tài khoản (nếu có gõ)
                    if (!string.IsNullOrEmpty(txtSearchUser.Text))
                    {
                        sql += " AND TenDangNhap LIKE @user";
                        cmd.Parameters.AddWithValue("@user", "%" + txtSearchUser.Text.Trim() + "%");
                    }

                    // 3. LỌC THEO VAI TRÒ (Phần mới thêm)
                    // Nếu chọn khác mục "-- Tất cả --" (vị trí 0) thì mới lọc
                    if (cmbVaiTro.SelectedIndex > 0)
                    {
                        sql += " AND VaiTro = @vaiTro";
                        cmd.Parameters.AddWithValue("@vaiTro", cmbVaiTro.Text);
                    }

                    // Gán các tham số ngày tháng
                    cmd.Parameters.AddWithValue("@tu", dtpFromDate.Value.Date);
                    cmd.Parameters.AddWithValue("@den", dtpToDate.Value.Date);

                    sql += " ORDER BY ThoiGian DESC";
                    cmd.CommandText = sql;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvNhatKy.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSearchUser.Clear();
            cmbVaiTro.Text = "  ";
            dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDate.Value = DateTime.Now;
            LoadNhatKy();
        }
    }
}