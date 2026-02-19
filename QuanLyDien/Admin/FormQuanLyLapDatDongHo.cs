using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDien.Class;

namespace QuanLyDien.Admin
{
    public partial class FormQuanLyLapDatDongHo : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        bool isBinding = false;

        public FormQuanLyLapDatDongHo()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void FormQuanLyLapDatDongHo_Load(object sender, EventArgs e)
        {
            LoadCmbKhachHang();   
            LoadCmbNhanVien();    
            LoadCmbTrangThai();  
            LoadDataYeuCau();   
            panelTop_Resize(null, null);
        }

        // ================== NHÓM 1: NẠP DỮ LIỆU ==================

        void LoadCmbKhachHang()
        {
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                // Lấy MaKH và HoTen để nhân viên dễ chọn
                string sql = "SELECT MaKH, HoTen, DiaChi FROM KhachHang";
                da = new SqlDataAdapter(sql, con);
                DataTable dtKH = new DataTable();
                da.Fill(dtKH);
                cmbKhachHang.DataSource = dtKH;
                cmbKhachHang.DisplayMember = "HoTen";
                cmbKhachHang.ValueMember = "MaKH";
                cmbKhachHang.SelectedIndex = -1;
            }
        }

        void LoadCmbNhanVien()
        {
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                // Chỉ lấy những nhân viên có vai trò kỹ thuật hoặc cho phép lắp đặt
                string sql = "SELECT MaNV, HoTen FROM NhanVien";
                da = new SqlDataAdapter(sql, con);
                DataTable dtNV = new DataTable();
                da.Fill(dtNV);
                cmbNhanVien.DataSource = dtNV;
                cmbNhanVien.DisplayMember = "HoTen";
                cmbNhanVien.ValueMember = "MaNV";
                cmbNhanVien.SelectedIndex = -1;
            }
        }

        void LoadCmbTrangThai()
        {
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("Chờ xử lý");
            cmbTrangThai.Items.Add("Đang lắp đặt");
            cmbTrangThai.Items.Add("Đã hoàn thành");
            cmbTrangThai.Items.Add("Đã hủy");
            cmbTrangThai.SelectedIndex = 0; // Mặc định là Chờ xử lý
        }

        void LoadDataYeuCau()
        {
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                string sql = "SELECT * FROM YeuCauLapDatDongHo ORDER BY MaYeuCau DESC";
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
                dgvYeuCau.DataSource = dt;
                DataGridViewStyle.ApplyModernStyle(dgvYeuCau);              
                dgvYeuCau.Columns["NgayYeuCau"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
        private string TuSinhMaYC()
        {
            // 1. Mặc định nếu bảng chưa có dữ liệu thì mã đầu tiên là YC001
            string maMoi = "YC001";

            using (SqlConnection connection = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                connection.Open();
                string sql = "SELECT MAX(MaYeuCau) FROM YeuCauLapDatDongHo";
                SqlCommand cmd = new SqlCommand(sql, connection);
                object ketQua = cmd.ExecuteScalar();

                // Nếu tìm thấy mã (bảng không trống) thì mới xử lý tăng số
                if (ketQua != DBNull.Value && ketQua != null)
                {
                    string maHienTai = ketQua.ToString(); // Lấy ra chuỗi "YC005"

                    // bỏ qua 2 chữ cái đầu (Y và C)
                    string phanSo = maHienTai.Substring(2);

                    int soHienTai = int.Parse(phanSo); // Biến thành số 5
                    int soTiepTheo = soHienTai + 1;    // Tăng lên thành số 6
                    maMoi = "YC" + soTiepTheo.ToString("000");
                }
            }

            return maMoi; 
        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isBinding || cmbKhachHang.SelectedIndex == -1 || cmbKhachHang.SelectedValue is DataRowView) return;

            // Tự động lấy địa chỉ khách hàng điền vào ô Địa điểm lắp đặt
            DataRowView row = (DataRowView)cmbKhachHang.SelectedItem;
            txtDiaDiem.Text = row["DiaChi"].ToString();
        }

        // ================== NHÓM 3: THÊM (TIẾP NHẬN) ==================

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbKhachHang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng yêu cầu lắp đặt!");
                return;
            }

            try
            {
                using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();
                    string maMoi = TuSinhMaYC(); // Tự sinh mã tiếp theo

                    string sql = @"INSERT INTO YeuCauLapDatDongHo (MaYeuCau, MaNV, MaKH, NgayYeuCau, DiaDiemLapDat, TrangThai, GhiChu) 
                                   VALUES (@ma, @manv, @makh, @ngay, @diadiem, @tt, @note)";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ma", maMoi);

                    // Nếu chưa giao nhân viên thì để NULL
                    if (cmbNhanVien.SelectedIndex != -1)
                        cmd.Parameters.AddWithValue("@manv", cmbNhanVien.SelectedValue);
                    else
                        cmd.Parameters.AddWithValue("@manv", DBNull.Value);

                    cmd.Parameters.AddWithValue("@makh", cmbKhachHang.SelectedValue);
                    cmd.Parameters.AddWithValue("@ngay", DateTime.Now); // Lấy giờ máy tính
                    cmd.Parameters.AddWithValue("@diadiem", txtDiaDiem.Text.Trim());
                    cmd.Parameters.AddWithValue("@tt", cmbTrangThai.Text);
                    cmd.Parameters.AddWithValue("@note", txtGhiChu.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã tiếp nhận yêu cầu lắp đặt mới: " + maMoi);
                    btnLamMoi_Click(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            isBinding = true;
            txtMaYeuCau.Clear();
            cmbKhachHang.SelectedIndex = -1;
            cmbNhanVien.SelectedIndex = -1;
            txtDiaDiem.Clear();
            txtGhiChu.Clear();
            cmbTrangThai.SelectedIndex = 0;
            isBinding = false;
            LoadDataYeuCau();
        }

        private void dgvYeuCau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            isBinding = true;
            DataGridViewRow r = dgvYeuCau.Rows[e.RowIndex];

            txtMaYeuCau.Text = r.Cells["MaYeuCau"].Value.ToString();
            cmbKhachHang.SelectedValue = r.Cells["MaKH"].Value.ToString();

            if (r.Cells["MaNV"].Value != DBNull.Value)
                cmbNhanVien.SelectedValue = r.Cells["MaNV"].Value.ToString();
            else
                cmbNhanVien.SelectedIndex = -1;

            txtDiaDiem.Text = r.Cells["DiaDiemLapDat"].Value.ToString();
            cmbTrangThai.Text = r.Cells["TrangThai"].Value.ToString();
            txtGhiChu.Text = r.Cells["GhiChu"].Value.ToString();
            isBinding = false;
        }

        private void panelTop_Resize(object sender, EventArgs e)
        {
            if (palThongTin != null) palThongTin.Left = (this.Width - palThongTin.Width) / 2;
        }
    }
}