using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDien.Class;
namespace QuanLyDien.Admin
{
    public partial class FormChiTietBangGia : Form
    {
        // Khai báo biến toàn cục trong FormChiTietBangGia
        string _maBangGiaNhanVao;
        SqlConnection con;
        // 1. Khai báo biến để lưu mã nhận được
        string maNhanDuoc = "";

        // 2. Sửa hàm tạo (Constructor)
        public FormChiTietBangGia(string ma)
        {
            InitializeComponent();
            this.maNhanDuoc = ma; // Lưu mã vào biến để dùng
            this.Dock = DockStyle.Fill;
        }

        private void FormChiTietBangGia_Load(object sender, EventArgs e)
        {
            LoadCmbBangGiaMaster(); // Nạp danh sách bảng giá vào ComboBox

            // 3. Nếu có mã truyền sang, tự động chọn bảng giá đó luôn
            if (!string.IsNullOrEmpty(maNhanDuoc))
            {
                // Phải gán sau khi đã nạp DataSource cho ComboBox
                cmbBangGiaCha.SelectedValue = maNhanDuoc;
                LoadDataChiTiet(maNhanDuoc); // Hiện luôn các bậc của mã đó
            }
        }


        void LoadCmbBangGiaMaster()
        {
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaBangGia, TenBangGia FROM BangGiaDien", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbBangGiaCha.DataSource = dt;
                cmbBangGiaCha.DisplayMember = "TenBangGia";
                cmbBangGiaCha.ValueMember = "MaBangGia";
                cmbBangGiaCha.SelectedIndex = -1;
            }
        }

        void LoadDataChiTiet(string maBG)
        {
            if (string.IsNullOrEmpty(maBG)) return;
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                string sql = "SELECT * FROM ChiTietBangGia WHERE MaBangGia = @ma ORDER BY Bac ASC";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", maBG);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvChiTiet.DataSource = dt;
            }
        }

        private void cmbBangGiaCha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBangGiaCha.SelectedValue == null || cmbBangGiaCha.SelectedValue is DataRowView) return;
            LoadDataChiTiet(cmbBangGiaCha.SelectedValue.ToString());
        }

        // --- THÊM BẬC GIÁ ---

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbBangGiaCha.SelectedIndex == -1 || txtDonGia.Text == "") return;

            try
            {
                using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();
                    // Tự sinh mã CTBG bằng thời gian
                    string maCT = "CT" + DateTime.Now.ToString("yyyyMMddHHmmss");

                    string sql = "INSERT INTO ChiTietBangGia VALUES (@mact, @mabg, @bac, @tuso, @denso, @gia)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@mact", maCT);
                    cmd.Parameters.AddWithValue("@mabg", cmbBangGiaCha.SelectedValue);
                    cmd.Parameters.AddWithValue("@bac", nudBac.Value);
                    cmd.Parameters.AddWithValue("@tuso", int.Parse(txtTuSo.Text));
                    cmd.Parameters.AddWithValue("@denso", int.Parse(txtDenSo.Text));
                    cmd.Parameters.AddWithValue("@gia", decimal.Parse(txtDonGia.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm bậc giá thành công!");
                    LoadDataChiTiet(cmbBangGiaCha.SelectedValue.ToString());
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvChiTiet.Rows[e.RowIndex];
            nudBac.Value = Convert.ToInt32(r.Cells["Bac"].Value);
            txtTuSo.Text = r.Cells["TuSo"].Value.ToString();
            txtDenSo.Text = r.Cells["DenSo"].Value.ToString();
            txtDonGia.Text = r.Cells["DonGia"].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTuSo.Clear(); txtDenSo.Clear(); txtDonGia.Clear(); nudBac.Value = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null) return;
            string maCT = dgvChiTiet.CurrentRow.Cells["MaCTBG"].Value.ToString();

            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM ChiTietBangGia WHERE MaCTBG=@ma", con);
                cmd.Parameters.AddWithValue("@ma", maCT);
                cmd.ExecuteNonQuery();
                LoadDataChiTiet(cmbBangGiaCha.SelectedValue.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một bậc giá trong bảng để sửa!");
                return;
            }
            string maCT = dgvChiTiet.CurrentRow.Cells["MaCTBG"].Value.ToString();

            if (txtDonGia.Text == "" || txtTuSo.Text == "" || txtDenSo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin số điện và đơn giá!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();

                    //Update (Không cho sửa MaCTBG và MaBangGia để đảm bảo tính nhất quán)
                    string sql = @"UPDATE ChiTietBangGia 
                           SET Bac = @bac, 
                               TuSo = @tuso, 
                               DenSo = @denso, 
                               DonGia = @gia 
                           WHERE MaCTBG = @ma";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ma", maCT);
                    cmd.Parameters.AddWithValue("@bac", nudBac.Value);
                    cmd.Parameters.AddWithValue("@tuso", int.Parse(txtTuSo.Text.Trim()));
                    cmd.Parameters.AddWithValue("@denso", int.Parse(txtDenSo.Text.Trim()));
                    cmd.Parameters.AddWithValue("@gia", decimal.Parse(txtDonGia.Text.Trim()));

                    int kq = cmd.ExecuteNonQuery();

                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật bậc giá thành công!");

                        //Nạp lại bảng dữ liệu để thấy thay đổi
                        LoadDataChiTiet(cmbBangGiaCha.SelectedValue.ToString());

                        // Xóa trắng các ô nhập (tùy chọn)
                        btnLamMoi_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}