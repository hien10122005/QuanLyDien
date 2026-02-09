using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDien.Class; // Chứa ChuoiKetNoi và Session

namespace QuanLyDien.NhanVienGhi
{
    public partial class FormGhiSoDien : Form
    {
        // 1. Khai báo các đối tượng kết nối
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        bool isBinding = false; // Biến cờ chặn sự kiện chạy lung tung

        public FormGhiSoDien()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void FormGhiSoDien_Load(object sender, EventArgs e)
        {
            LoadCmbDongHo();     // Nạp danh sách đồng hồ vào ComboBox
            LoadDataGhiChiSo();  // Nạp lịch sử ghi điện vào bảng
            SetupDefaultTime();  // Thiết lập tháng/năm hiện tại
            panelTop_Resize(null, null); // Căn giữa giao diện
        }

        // --- NHÓM 1: CÁC HÀM NẠP DỮ LIỆU ---

        void SetupDefaultTime()
        {
            nudThang.Value = DateTime.Now.Month;
            nudNam.Value = DateTime.Now.Year;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            isBinding = true; // Chặn các sự kiện SelectedIndexChanged chạy ngầm
            txtMaGhi.Clear();
            cmbMaDongHo.SelectedIndex = -1;
            txtChiSoCu.Text = "0";
            txtChiSoMoi.Clear();
            txtSanLuong.Text = "0";
            txtSanLuong.ForeColor = Color.Lime;
            SetupDefaultTime();
            isBinding = false;

            LoadDataGhiChiSo();
        }
        void LoadCmbDongHo()
        {
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                // Lấy MaDongHo và Tên khách hàng để nhân viên dễ chọn
                //Thay vì chỉ có DH01, nó sẽ tạo ra chuỗi: "DH01 - Nguyễn Văn An".
                string sql = "SELECT MaDongHo, MaDongHo + ' - ' + HoTen as HienThi FROM DongHoDien JOIN KhachHang ON DongHoDien.MaKH = KhachHang.MaKH";
                da = new SqlDataAdapter(sql, con);
                DataTable dtDH = new DataTable();
                da.Fill(dtDH);

                cmbMaDongHo.DataSource = dtDH;
                cmbMaDongHo.DisplayMember = "HienThi";
                cmbMaDongHo.ValueMember = "MaDongHo";
                cmbMaDongHo.Text = null ; 
            }
        }

        void LoadDataGhiChiSo()
        {
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                string sql = "SELECT * FROM GhiChiSo ORDER BY Nam DESC, Thang DESC";
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
                dgvGhiChiSo.DataSource = dt;
                DataGridViewStyle.ApplyModernStyle(dgvGhiChiSo);
            }
        }

        // --- NHÓM 2: LOGIC TỰ ĐỘNG (QUAN TRỌNG) ---
        // --- NHÓM 2: LOGIC TỰ ĐỘNG (ĐÃ TỐI ƯU) ---

        private void TinhSanLuong()
        {
            try
            {
                // Dùng TryParse để an toàn hơn parse trực tiếp
                int cu = 0;
                int.TryParse(txtChiSoCu.Text, out cu);

                int moi = 0;
                if (!string.IsNullOrEmpty(txtChiSoMoi.Text))
                    int.TryParse(txtChiSoMoi.Text, out moi);

                if (moi >= cu)
                {
                    txtSanLuong.Text = (moi - cu).ToString();
                    txtSanLuong.ForeColor = Color.Lime;
                }
                else
                {
                    txtSanLuong.Text = "0";
                    txtSanLuong.ForeColor = Color.Red;
                }
            }
            catch { txtSanLuong.Text = "0"; }
        }

        private void CapNhatChiSoCu()
        {
            if (isBinding || cmbMaDongHo.SelectedValue == null || cmbMaDongHo.SelectedValue is DataRowView)
                return;

            string maDH = cmbMaDongHo.SelectedValue.ToString();
            int thang = (int)nudThang.Value;
            int nam = (int)nudNam.Value;

            using (SqlConnection connection = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                connection.Open();
                // Lấy chỉ số mới của lần ghi gần nhất trước thời điểm đang chọn
                string sql = @"SELECT TOP 1 ChiSoMoi FROM GhiChiSo 
                       WHERE MaDongHo = @ma 
                       AND (Nam < @nam OR (Nam = @nam AND Thang < @thang)) 
                       ORDER BY Nam DESC, Thang DESC";

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@ma", maDH);
                cmd.Parameters.AddWithValue("@thang", thang);
                cmd.Parameters.AddWithValue("@nam", nam);

                object kq = cmd.ExecuteScalar();
                txtChiSoCu.Text = (kq != null) ? kq.ToString() : "0";

                TinhSanLuong();
            }
        }

        private void cmbMaDongHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chỉ cần gọi hàm này là đủ, xóa bỏ đoạn code mở connection cũ ở đây
            CapNhatChiSoCu();

            // Khi đổi đồng hồ, nên xóa chỉ số mới cũ để nhân viên nhập lại
            if (!isBinding) txtChiSoMoi.Clear();
        }

        // Bổ sung isBinding cho 2 sự kiện này
        private void nudThang_ValueChanged(object sender, EventArgs e)
        {
            if (!isBinding) CapNhatChiSoCu();
        }

        private void nudNam_ValueChanged(object sender, EventArgs e)
        {
            if (!isBinding) CapNhatChiSoCu();
        }

        // --- NHÓM 3: THÊM, XÓA, LÀM MỚI ---

        private string TuSinhMaGhi()
        {
            // Tạo mã dạng: G + Năm + Tháng + Ngày + Giờ + Phút + Giây
            return "G" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbMaDongHo.SelectedIndex == -1 || string.IsNullOrEmpty(txtChiSoMoi.Text))
            {
                MessageBox.Show("Vui lòng chọn đồng hồ và nhập chỉ số mới!");
                return;
            }

            int cu = int.Parse(txtChiSoCu.Text);
            int moi = int.Parse(txtChiSoMoi.Text);
            int sanLuong = moi - cu;

            if (moi < cu)
            {
                MessageBox.Show("Chỉ số mới không được nhỏ hơn chỉ số cũ!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    connection.Open();
                    string maMoi = TuSinhMaGhi();

                    // 1. Kiểm tra trùng
                    string sqlCheck = "SELECT COUNT(*) FROM GhiChiSo WHERE MaDongHo = @ma AND Thang = @t AND Nam = @n";
                    SqlCommand cmdCheck = new SqlCommand(sqlCheck, connection);
                    cmdCheck.Parameters.AddWithValue("@ma", cmbMaDongHo.SelectedValue.ToString());
                    cmdCheck.Parameters.AddWithValue("@t", nudThang.Value);
                    cmdCheck.Parameters.AddWithValue("@n", nudNam.Value);

                    if ((int)cmdCheck.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Đồng hồ này đã được ghi chỉ số trong tháng " + nudThang.Value + "/" + nudNam.Value + " rồi!");
                        return;
                    }

                    // 2. Lưu bảng GhiChiSo
                    string sqlInsert = "INSERT INTO GhiChiSo VALUES (@maghi, @madh, @thang, @nam, @cscu, @csmoi, @sl)";
                    SqlCommand cmd = new SqlCommand(sqlInsert, connection);
                    cmd.Parameters.AddWithValue("@maghi", maMoi);
                    cmd.Parameters.AddWithValue("@madh", cmbMaDongHo.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@thang", nudThang.Value);
                    cmd.Parameters.AddWithValue("@nam", nudNam.Value);
                    cmd.Parameters.AddWithValue("@cscu", cu);
                    cmd.Parameters.AddWithValue("@csmoi", moi);
                    cmd.Parameters.AddWithValue("@sl", sanLuong);

                    cmd.ExecuteNonQuery(); // Lưu lần 1 thành công

                    // 3. Gọi hàm tự động lập hóa đơn (Truyền giá trị đã tính vào)
                    TuDongLapHoaDon(maMoi, cmbMaDongHo.SelectedValue.ToString(), (int)nudThang.Value, (int)nudNam.Value, sanLuong);

                    MessageBox.Show("Lưu chỉ số và xuất hóa đơn thành công!");

                    // 4. Cuối cùng mới làm mới giao diện
                    LoadDataGhiChiSo();
                    btnLamMoi_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        // Khi nhập chỉ số mới -> Tự động tính: Sản lượng = Mới - Cũ
        private void txtChiSoMoi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int cu = int.Parse(txtChiSoCu.Text);
                int moi = int.Parse(txtChiSoMoi.Text);

                if (moi >= cu)
                {
                    txtSanLuong.Text = (moi - cu).ToString();
                    txtSanLuong.ForeColor = Color.Lime; // Màu xanh: Hợp lệ
                }
                else
                {
                    txtSanLuong.Text = "!"; // Cảnh báo
                    txtSanLuong.ForeColor = Color.Red; // Màu đỏ: Lỗi nhập liệu
                }
            }
            catch
            {
                txtSanLuong.Text = "0";
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaGhi.Text == "") return;
            if (MessageBox.Show("Bạn có chắc muốn xóa bản ghi này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) return;

            try
            {
                using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM GhiChiSo WHERE MaGhi = @ma", con);
                    cmd.Parameters.AddWithValue("@ma", txtMaGhi.Text);
                    cmd.ExecuteNonQuery();
                    btnLamMoi_Click(null, null);
                }
            }
            catch { MessageBox.Show("Không thể xóa bản ghi này!"); }
        }
        // --- NHÓM 4: GIAO DIỆN & BẢNG ---

        private void dgvGhiChiSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            isBinding = true;
            DataGridViewRow r = dgvGhiChiSo.Rows[e.RowIndex];
            txtMaGhi.Text = r.Cells["MaGhi"].Value.ToString();
            cmbMaDongHo.SelectedValue = r.Cells["MaDongHo"].Value.ToString();
            nudThang.Value = Convert.ToInt32(r.Cells["Thang"].Value);
            nudNam.Value = Convert.ToInt32(r.Cells["Nam"].Value);
            txtChiSoCu.Text = r.Cells["ChiSoCu"].Value.ToString();
            txtChiSoMoi.Text = r.Cells["ChiSoMoi"].Value.ToString();
            txtSanLuong.Text = r.Cells["SanLuong"].Value.ToString();
            isBinding = false;
        }

        private void panelTop_Resize(object sender, EventArgs e)
        {
            if (palThongTin != null && pnlSearch != null)
            {
                palThongTin.Left = (panelTop.Width - palThongTin.Width) / 2;
                pnlSearch.Left = (panelTop.Width - pnlSearch.Width) / 2;
            }
        }

        private void dgvGhiChiSo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvGhiChiSo.ClearSelection();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                // Tìm theo mã đồng hồ và tháng năm
                string sql = "SELECT * FROM GhiChiSo WHERE Thang = @t AND Nam = @n";
                if (cmbMaDongHo.SelectedIndex != -1)
                    sql = sql+ " AND MaDongHo = @dh";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@t", nudThang.Value);
                cmd.Parameters.AddWithValue("@n", nudNam.Value);
                if (cmbMaDongHo.SelectedIndex != -1) cmd.Parameters.AddWithValue("@dh", cmbMaDongHo.SelectedValue.ToString());

                da = new SqlDataAdapter(cmd);
                DataTable dtTim = new DataTable();
                da.Fill(dtTim);
                dgvGhiChiSo.DataSource = dtTim;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Tương tự hàm Thêm nhưng dùng lệnh UPDATE
            // Thường thì chỉ số điện hạn chế cho sửa để tránh gian lận
            MessageBox.Show("Chức năng sửa đang được bảo trì!");
        }

        private void panelTop_Resize_1(object sender, EventArgs e)
        {
            if (palThongTin != null && pnlSearch != null)
            {
                palThongTin.Left = (panelTop.Width - palThongTin.Width) / 2;
                pnlSearch.Left = (panelTop.Width - pnlSearch.Width) / 2;
            }
        }
        private void TuDongLapHoaDon(string maGhi, string maDongHo, int thang, int nam, int sanLuong)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    con.Open();
                    // 1. Tìm Mã Khách Hàng từ Mã Đồng Hồ
                    string sqlGetKH = "SELECT MaKH FROM DongHoDien WHERE MaDongHo = @maDH";
                    SqlCommand cmdKH = new SqlCommand(sqlGetKH, con);
                    cmdKH.Parameters.AddWithValue("@maDH", maDongHo);
                    string maKH = cmdKH.ExecuteScalar()?.ToString(); 

                    // 2. Lấy Mã Bảng Giá đang hoạt động (ví dụ lấy cái mới nhất)
                    string sqlGetBG = "SELECT TOP 1 MaBangGia FROM BangGiaDien WHERE TrangThai = N'Hoạt động'";
                    string maBG = new SqlCommand(sqlGetBG, con).ExecuteScalar()?.ToString();

                    if (maKH == null || maBG == null) return;

                    // 3. Tạo Mã Hóa Đơn tự động (Ví dụ: HD + MaGhi)
                    string maHD = "HD" + maGhi.Substring(1);

                    // 4. Lập Hóa Đơn tổng quát (Tạm thời cho tiền bằng 0 để tính sau)
                    string sqlHD = @"INSERT INTO HoaDon (MaHoaDon, MaKH, MaBangGia, Thang, Nam, TongTien, TrangThaiThanhToan) 
                                   VALUES (@mahd, @makh, @mabg, @t, @n, 0, N'Chưa thanh toán')";
                    SqlCommand cmdHD = new SqlCommand(sqlHD, con);
                    cmdHD.Parameters.AddWithValue("@mahd", maHD);
                    cmdHD.Parameters.AddWithValue("@makh", maKH);
                    cmdHD.Parameters.AddWithValue("@mabg", maBG);
                    cmdHD.Parameters.AddWithValue("@t", thang);
                    cmdHD.Parameters.AddWithValue("@n", nam);
                    cmdHD.ExecuteNonQuery();

                    // 5. TÍNH TOÁN CHI TIẾT THEO BẬC THANG
                    // Lấy danh sách các bậc giá
                    string sqlGetTiers = "SELECT * FROM ChiTietBangGia WHERE MaBangGia = @mabg ORDER BY Bac ASC";
                    SqlDataAdapter da = new SqlDataAdapter(sqlGetTiers, con);
                    da.SelectCommand.Parameters.AddWithValue("@mabg", maBG);
                    DataTable dtBacs = new DataTable();
                    da.Fill(dtBacs);

                    decimal tongTien = 0;
                    int soDienConLai = sanLuong;

                    foreach (DataRow row in dtBacs.Rows)
                    {
                        int bac = Convert.ToInt32(row["Bac"]);
                        int tuSo = Convert.ToInt32(row["TuSo"]);
                        int denSo = Convert.ToInt32(row["DenSo"]);
                        decimal donGia = Convert.ToDecimal(row["DonGia"]);

                        int soTrongBac = 0;
                        int gioiHanBac = denSo - tuSo + 1;

                        if (soDienConLai > 0)
                        {
                            // Nếu số điện còn lại lớn hơn giới hạn của bậc này (ví dụ bậc 1 chỉ có 50 số)
                            if (soDienConLai > gioiHanBac && denSo != 9999) // 9999 là bậc cuối không giới hạn
                            {
                                soTrongBac = gioiHanBac;
                            }
                            else
                            {
                                soTrongBac = soDienConLai;
                            }

                            decimal thanhTienBac = soTrongBac * donGia;
                            tongTien += thanhTienBac;
                            soDienConLai -= soTrongBac;

                            // Lưu vào bảng ChiTietHoaDon
                            string sqlInsertCT = @"INSERT INTO ChiTietHoaDon (MaCTHD, MaHoaDon, Bac, SoDien, DonGia, ThanhTien) 
                                           VALUES (@mact, @mahd, @b, @sd, @dg, @tt)";
                            SqlCommand cmdCT = new SqlCommand(sqlInsertCT, con);
                            cmdCT.Parameters.AddWithValue("@mact", "CT" + maHD.Substring(2) + bac); // Mã chi tiết hóa đơn tự sinh theo bậc giá và mã hóa đơn 
                            cmdCT.Parameters.AddWithValue("@mahd", maHD);
                            cmdHD.Parameters.Clear(); 
                            cmdCT.Parameters.AddWithValue("@b", bac);
                            cmdCT.Parameters.AddWithValue("@sd", soTrongBac);
                            cmdCT.Parameters.AddWithValue("@dg", donGia);
                            cmdCT.Parameters.AddWithValue("@tt", thanhTienBac);
                            cmdCT.ExecuteNonQuery();
                        }
                    }
                    // 6. Cập nhật lại Tổng Tiền cuối cùng vào Hóa Đơn
                    string sqlUpdateTong = "UPDATE HoaDon SET TongTien = @tong WHERE MaHoaDon = @mahd";
                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdateTong, con);
                    cmdUpdate.Parameters.AddWithValue("@tong", tongTien);
                    cmdUpdate.Parameters.AddWithValue("@mahd", maHD);
                    cmdUpdate.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tự động lập hóa đơn: " + ex.Message);
            }
        }

    }
}