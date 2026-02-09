using QuanLyDien.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyDien.ChucNangChung
{
    public partial class FormThongTinNhanVien : Form
    {
            public FormThongTinNhanVien()
            {
                InitializeComponent();
                this.TopLevel = false;
                this.Dock = DockStyle.Fill;
            }

            private void FormThongTinNhanVien_Load(object sender, EventArgs e)
            {
                // Tự động gán dữ liệu từ Session vào các TextBox
                txtMaNV.Text = Session.MaNV;
                txtTenDangNhap.Text = Session.TenDangNhap;
                txtHoTen.Text = Session.TenNV;
                txtSDT.Text = Session.DienThoai;
                txtChucVu.Text = Session.VaiTro;

                // Gọi hàm căn giữa một lần khi load
                panelCenter_Resize(null, null);
            }

            private void panelCenter_Resize(object sender, EventArgs e)
            {
                // Code giúp GroupBox luôn nằm chính giữa form dù phóng to hay thu nhỏ
                groupBoxProfile.Left = (panelCenter.Width - groupBoxProfile.Width) / 2;
                groupBoxProfile.Top = (panelCenter.Height - groupBoxProfile.Height) / 2;
            }
        }
    }
