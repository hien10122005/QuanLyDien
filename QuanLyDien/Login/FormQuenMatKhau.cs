using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDien.Login;
using System.Data.SqlClient;
namespace QuanLyDien.Login
{
    public partial class FormQuenMatKhau : Form
    {
        SqlConnection conn = new SqlConnection(ChuoiKetNoi.KetNoi);
       // SqlDataAdapter daNguoiDung;
      //  DataSet dsNguoiDung;

        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        public void HienKhuDangKy()
        {
            txtMatKhauVsSDT.Clear();
            btnCheck.Visible = false;
            btnDoiMK.Visible = true;
            labMK.Text = "Mật Khẩu :";
            labNhapLaiMK.Visible = true;
            txtNhapLaiMK.Visible = true;
        }
        public void AnKhuDangKy()
        {
            btnDoiMK.Visible = false;
            labMK.Text = "SDT :";         
            labNhapLaiMK.Visible = false;
            txtNhapLaiMK.Visible = false;
        }
        private void FormQuenMatKhau_Load(object sender, EventArgs e)
        {
            AnKhuDangKy();

        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ChuoiKetNoi.KetNoi);
            string sql = @"
            SELECT COUNT(*) 
            FROM NguoiDung nd
            JOIN NhanVien nv ON nd.MaNV = nv.MaNV
            WHERE nd.MaNV = @MaNV 
            AND nd.TenDangNhap = @TenDN
            AND nv.DienThoai = @SDT
            AND nd.TrangThai = N'Hoạt động'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaNV", txtMaNv.Text.Trim());
            cmd.Parameters.AddWithValue("@TenDN", txtTenDangNhap.Text.Trim());
            cmd.Parameters.AddWithValue("@SDT", txtMatKhauVsSDT.Text.Trim());
            conn.Open();
            int count = (int)cmd.ExecuteScalar(); 

            if (count > 0)
            {
                MessageBox.Show("Xác nhận thành công! Vui lòng nhập mật khẩu mới.");
                HienKhuDangKy();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Sai mã nhân viên hoặc số điện thoại.");
            }
                 

        }
        private void btnDoiMK_Click(object sender, EventArgs e)
        {

            if (txtMatKhauVsSDT.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            conn = new SqlConnection(ChuoiKetNoi.KetNoi);
            conn.Open();
            string sql = @"
            UPDATE NguoiDung
            SET MatKhau = @MatKhau
            WHERE MaNV = @MaNv
            AND TenDangNhap = @TaiKhoan
            AND TrangThai = N'Hoạt động'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MatKhau", txtNhapLaiMK.Text);
            cmd.Parameters.AddWithValue("@MaNv", txtMaNv.Text);
            cmd.Parameters.AddWithValue("@TaiKhoan", txtTenDangNhap.Text);
            int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                 MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhapLaiMK.Clear();
                txtMaNv.Clear();
                 txtTenDangNhap.Clear();
                txtMatKhauVsSDT.Clear();
                AnKhuDangKy();
                 conn.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        // Thoát ứng dụng
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // Quay về form đăng nhập
        private void button3_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
            this.Hide();
        }     
    }
}
