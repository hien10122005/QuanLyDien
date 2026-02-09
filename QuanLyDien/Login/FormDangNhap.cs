
using QuanLyDien;
using QuanLyDien.Class;
using QuanLyDien.Login;
using QuanLyDien.Test;
using System;
using System.Data;
using System.Data.SqlClient; 
using System.Windows.Forms;

public partial class FormDangNhap : Form
{
    // Chuỗi kết nối (Hãy thay đổi tên Server và Database cho đúng với máy của bạn)
    public FormDangNhap()
    {
        InitializeComponent();
    }

    private void btnDangNhap_Click(object sender, EventArgs e)
    {
        // 1. Kiểm tra dữ liệu đầu vào
        if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu.", "Thông báo");
            return;
        }
        try
        {
            using (SqlConnection conn = new SqlConnection(ChuoiKetNoi.KetNoi))
            {
                conn.Open();
                // 2. Câu lệnh SQL lấy thông tin tài khoản
                string sql = @"
                SELECT nd.*, nv.HoTen, nv.DienThoai
                FROM NguoiDung nd
                JOIN NhanVien nv ON nd.MaNV = nv.MaNV
                WHERE nd.TenDangNhap = @user AND nd.MatKhau = @pass";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                NhatKy.Ghi("Đăng nhập", "NguoiDung", "Đăng nhập hệ thống");
                if (reader.Read())
                {
                    string vaiTro = reader["VaiTro"].ToString();
                    string maNV = reader["MaNV"].ToString();
                    string trangThai = reader["TrangThai"].ToString();
                    string hoTen = reader["HoTen"].ToString();       // từ NhanVien
                    string dienThoai = reader["DienThoai"].ToString(); // từ NhanVien
                    string tenDangNhap = reader["TenDangNhap"].ToString();
                    string matKhau = reader["MatKhau"].ToString();

                    if (trangThai == "Khóa")
                    {
                        MessageBox.Show("Tài khoản bị khóa!");
                        return;
                    }

                    // Lưu Session
                    Session.MaNV = maNV;
                    Session.TenNV = hoTen;
                    Session.VaiTro = vaiTro;
                    Session.TenDangNhap = tenDangNhap;
                    Session.MatKhau = matKhau;
                    Session.DienThoai = dienThoai;
                    NhatKy.Ghi("Đăng nhập", "NguoiDung", "Đăng nhập hệ thống");
                    FormMain f = new FormMain();
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Đăng nhập thất bại",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi hệ thống");
        }
    }

    private void lblClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnQuenMk_Click(object sender, EventArgs e)
    {
        FormQuenMatKhau frmQuenMk = new FormQuenMatKhau();
        frmQuenMk.StartPosition= FormStartPosition.CenterScreen;
        frmQuenMk.Show();
        this.Hide();
    }

    private void btnDangKy_Click(object sender, EventArgs e)
    {
        FormDangKyTaiKhoan frmDangKy = new FormDangKyTaiKhoan();
        frmDangKy.StartPosition = FormStartPosition.CenterScreen;
        frmDangKy.Show();
        this.Hide();
    }
}