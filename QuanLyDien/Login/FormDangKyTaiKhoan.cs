using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDien;
using QuanLyDien.Class;
namespace QuanLyDien.Login
{
    public partial class FormDangKyTaiKhoan : Form
    {
        SqlConnection conn = new SqlConnection(ChuoiKetNoi.KetNoi);
        SqlDataAdapter da;
        DataTable dt;
        public FormDangKyTaiKhoan()
        {
            InitializeComponent();

        }
        public void loadcmbVaiTro()
        {
            cmbVaiTro.Items.Add("Admin");
            cmbVaiTro.Items.Add("Nhân Viên Thu Điện");
            cmbVaiTro.Items.Add("Nhân Viên Ghi Điện");
           
        }
        void HienKhuDangKy()
        {
            //
            txtManv.ReadOnly = true;
            txtTenDangNhap.ReadOnly = true;
            //
            txtNLMatKhau.Visible = true;
            cmbVaiTro.Visible = true;
            btnDangKy.Visible = true;

            labTenDangNhap.Text = "Tên Đăng Nhập :";
            labNhapLaiMK.Visible = true;
           // labSDTvsMatKhau.Visible = true;
            labVaiTro.Visible = true;
            labSDTvsMatKhau.Text = "Mặt Khẩu :";
            btnKiemTraThongTin.Visible = false;
           
        }
        void AnKhuDangKy()
        {
            txtNLMatKhau.Visible = false;
            cmbVaiTro.Visible = false;
            btnDangKy.Visible = false;

            labTenDangNhap.Text = "Tên NV :";
            labNhapLaiMK.Visible = false;
            labSDTvsMatKhau.Text = "SDT :";
            labVaiTro.Visible = false;
        }
        private void FormDangKyTaiKhoan_Load(object sender, EventArgs e)
        {
            loadcmbVaiTro();
            AnKhuDangKy();
        }
        public void Clear()
        {
            txtManv.Clear();
            txtTenDangNhap.Clear();
            txtMatKhauVsSDT.Clear();
            txtNLMatKhau.Clear();
          cmbVaiTro.Text = "";
        }
        // Đăng ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu và kiểm tra rỗng
            string maNV = txtManv.Text.Trim();
            string tenDN = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhauVsSDT.Text.Trim(); // Giả sử đây là mật khẩu

            if (maNV == "" || tenDN == "" || matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(ChuoiKetNoi.KetNoi))
                {
                    conn.Open();

                    // BƯỚC 1: Kiểm tra xem mã NV này có tồn tại trong công ty không
                    string sqlCheckNV = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @ma";
                    SqlCommand cmdNV = new SqlCommand(sqlCheckNV, conn);
                    cmdNV.Parameters.AddWithValue("@ma", maNV);
                    int tonTaiNV = (int)cmdNV.ExecuteScalar();

                    if (tonTaiNV == 0)
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại trong hệ thống!", "Lỗi");
                        return;
                    }

                    // BƯỚC 2: Kiểm tra xem nhân viên này ĐÃ CÓ tài khoản chưa
                    string sqlCheckMa = "SELECT COUNT(*) FROM NguoiDung WHERE MaNV = @ma";
                    SqlCommand cmdMa = new SqlCommand(sqlCheckMa, conn);
                    cmdMa.Parameters.AddWithValue("@ma", maNV);
                    if ((int)cmdMa.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Nhân viên này đã được cấp tài khoản rồi!", "Lỗi");
                        AnKhuDangKy();
                        return;
                    }

                    // BƯỚC 3: Kiểm tra xem Tên đăng nhập đã bị ai khác đặt chưa
                    string sqlCheckUser = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @user";
                    SqlCommand cmdUser = new SqlCommand(sqlCheckUser, conn);
                    cmdUser.Parameters.AddWithValue("@user", tenDN);
                    if ((int)cmdUser.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!", "Lỗi");
                        return;
                    }

                    // BƯỚC 4: Nếu mọi thứ OK thì tiến hành INSERT (Đăng ký)
                    string sqlInsert = "INSERT INTO NguoiDung (TenDangNhap, MaNV, MatKhau, VaiTro, TrangThai) " +
                                       "VALUES (@user, @ma, @pass, @vaitro, @trangthai)";
                    SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn);
                    cmdInsert.Parameters.AddWithValue("@user", tenDN);
                    cmdInsert.Parameters.AddWithValue("@ma", maNV);
                    cmdInsert.Parameters.AddWithValue("@pass", matKhau);
                    cmdInsert.Parameters.AddWithValue("@vaitro", cmbVaiTro.Text); // Mặc định hoặc lấy từ đâu đó
                    cmdInsert.Parameters.AddWithValue("@trangthai", "Khóa");

                    cmdInsert.ExecuteNonQuery();

                    MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo");
                    Clear();
                     NhatKy.Ghi("Đăng ký", "Tài khoản", "Đăng ký mới cho NV: " + maNV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }
        private void btnKiemTraThongTin_Click(object sender, EventArgs e)
        {
            string maNV = txtManv.Text.Trim();
            string tenDN = txtTenDangNhap.Text.Trim();
            string sdt = txtMatKhauVsSDT.Text.Trim();
            string sqlNV = @"SELECT * 
                 FROM NhanVien 
                 WHERE MaNV=@ma AND HoTen=@ten AND DienThoai=@sdt";

             da = new SqlDataAdapter(sqlNV, conn);
            da.SelectCommand.Parameters.AddWithValue("@ma", maNV);
            da.SelectCommand.Parameters.AddWithValue("@ten", tenDN);
            da.SelectCommand.Parameters.AddWithValue("@sdt", sdt);

            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtMatKhauVsSDT.Clear();
                HienKhuDangKy();
                MessageBox.Show("Thông tin hợp lệ. Vui lòng nhập mật khẩu để tạo tài khoản.");
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên với thông tin đã nhập!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // Thoát form
        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // Quay lại form đăng nhập
        private void button1_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
            this.Hide();
        }
        // Chỉ nhập số cho SDT và Mật Khẩu
        private void txtMatKhauVsSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (labSDTvsMatKhau.Text == "SDT :")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    MessageBox.Show("Vui lòng chỉ nhập số cho số điện thoại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true; // Ngăn chặn ký tự không hợp lệ
                }
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
