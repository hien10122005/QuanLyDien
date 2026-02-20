using QuanLyDien.ChucNangChung;
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
using System.Runtime.InteropServices;
using QuanLyDien.Admin;
using QuanLyDien.NhanVienGhi;
using QuanLyDien.NhanVienThu;
namespace QuanLyDien.Test
{
    public partial class FormMain : Form
    {
        // ================== BIẾN TOÀN CỤC ==================
        [DllImport("user32.dll")]
        public static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        // Trạng thái menu
        //bool labMenuList = true;
        bool labThongTinTk = true;

        // Trạng thái menu danh mục
        bool menuNV_TK = false;   // Nhân viên – Tài khoản
        bool menuKH_KV = false;  // Khách hàng – Khu vực

        // Animation menu
        Timer menuTimer = new Timer();
        bool dangThu = false;
        bool dangMo = false;

        // Form con đang mở
        public Form activeForm = null;

        // ================== HÀM KHỞI TẠO ==================

        public FormMain()
        {
         
            InitializeComponent();

            SetHoverDieuHuong(btnClose);
            SetHoverDieuHuong(btnMin);
            SetHoverDieuHuong(btnMax);
            SetHoverMenu(btnHienMenu);
            SetHoverMenu(btnThuMenu);

            PhanLoaiNguoiDung();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 1500;
            this.Height = 800 ;
            DongTatCaMenu();
        }

        // ================== FORM LOAD ==================

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormTrangChu());
            HienMenu();
            ThulThongTinTK();

            DongTatCaMenu();

            menuNV_TK = false;
            menuKH_KV = false;
            labMaNV.Text = Session.MaNV;
           // labMaNV.Text = "NV 02"; 
            XapSepListMenu();

            // Gán sự kiện click cho panel
            GanClickChoPanel(pnllistTrangChu, pnlTrangChu_Click);
            GanClickChoPanel(palQuanLyKhuVuc, palQuanLyKhuVuc_Click);
            GanClickChoPanel(palQuanLyKhachHang, palQuanLyKhachHang_Click);
            GanClickChoPanel(palQuanLyTaiKhoan, palQuanLyTaiKhoan_Click);
            GanClickChoPanel(palQuanLyNhanVien, palQuanLyNhanVien_Click);
            GanClickChoPanel(pallistNhatKyHeThong, palNhatKyHeThong_Click);
        }

        // ================== HOVER BUTTON ==================

        public void SetHoverDieuHuong(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.Red;
            btn.FlatAppearance.MouseDownBackColor = Color.DarkRed;
        }

        public void SetHoverMenu(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#9572D5");
            btn.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#8E5DAB");
        }

        // ================== PHÂN LOẠI NGƯỜI DÙNG ==================

        public void PhanLoaiNguoiDung()
        {
            // Hiển thị Mã NV đang đăng nhập
            labMaNV.Text = Session.MaNV;
            string vaiTro = Session.VaiTro;

            // 1. Mặc định cho hiện tất cả (dành cho Admin)
            foreach (Control c in panelMenu.Controls) c.Visible = true;

            // 2. Phân quyền cho Nhân Viên Thu Tiền
            if (vaiTro == "Nhân Viên Thu Tiền" || vaiTro == "Nhân Viên Thu Điện")
            {
                // Ẩn các chức năng của bộ phận Ghi điện và Quản trị
                pallist_NV.Visible = false;             // Không quản lý nhân sự
             //   pnlMenuBangGiaDien.Visible = false;    // Không sửa bảng giá
                pallistGhiSoDien.Visible = false;      // Không ghi số điện
                pallistQuanLyYeuCaiLapDat.Visible = false; // Không tiếp nhận lắp đặt
                pallistQLDongHoDien.Visible = false;  // Không quản lý thiết bị
                pallistNhatKyHeThong.Visible = false;     // Không xem log
            }

            // 3. Phân quyền cho Nhân Viên Ghi Số
            else if (vaiTro == "Nhân Viên Ghi Số" || vaiTro == "Nhân Viên Ghi Điện")
            {
                // Ẩn các chức năng của bộ phận Kế toán/Thu tiền và Quản trị
                pallistHoaDon.Visible = false;          // Không xem hóa đơn/công nợ
                pallistBaoCao.Visible = false;          // Không xem báo cáo doanh thu
                pallist_NV.Visible = false;             // Không quản lý nhân sự
                pallistNhatKyHeThong.Visible = false;     // Không xem log
                pnllist_KH.Visible = false;            // Không quản lý khách hàng chung
            }
        }

        // ================== ĐIỀU KHIỂN FORM ==================

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            pnlTitle_MouseDown(sender, e);
        }
        // ================== MỞ FORM CON ==================

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            palMain.Controls.Clear();
            palMain.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();

            childForm.Show();
        }


        // ================== ANIMATION MENU ==================

       

        private void btnHien_Click(object sender, EventArgs e)
        {
            HienMenu();
        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            DongTatCaMenu();
            ThuMenu();
        }

        // ================== MENU CHÍNH ==================

        public void HienMenu()
        {
            panelMenu.Width = 280; // Gán kích thước tối đa ngay lập tức
            btnHienMenu.Visible = false;
            btnThuMenu.Visible = true;

            // Hiện các chữ nhãn
            labTrangChu.Visible = true;
            labNhanSu.Visible = true;
            labKhachHang.Visible = true;
            labHoaDon.Visible = true;
            labNKHeThong.Visible = true;
            labGhiSoDien.Visible = true;
            labQLDongHo.Visible = true;
            labQLLapDongHo.Visible = true;
            labBangGiaDien.Visible = true;
            labChitietBangGia.Visible = true;
            labBaoCao.Visible = true;

        }

        public void ThuMenu()
        {
            panelMenu.Width = 70; // Thu nhỏ về icon ngay lập tức
            btnHienMenu.Visible = true;
            btnThuMenu.Visible = false;

            // Ẩn các chữ nhãn
            labTrangChu.Visible = false;
            labNhanSu.Visible = false;
            labKhachHang.Visible = false;
            labHoaDon.Visible = false;
            labNKHeThong.Visible = false;
            labGhiSoDien.Visible = false;
            labBangGiaDien.Visible = false;
            labQLDongHo.Visible = false;
            labQLLapDongHo.Visible = false;
            labChitietBangGia.Visible = false;
            labBaoCao.Visible = false;

        }

        // ================== SẮP XẾP MENU HIỂN THỊ  ==================

        public void XapSepListMenu()
        {
            // Danh sách các Panel Menu theo thứ tự từ DƯỚI lên TRÊN
           Control[] menuOrder = new Control[] {
            pallistNhatKyHeThong,      
            pallistBaoCao,
            pallistQLDongHoDien,
            pallistQuanLyYeuCaiLapDat,
            pallistGhiSoDien,
            pnllist_KH,
            pallistHoaDon,
            pallist_NV,
            pnllistTrangChu,          
            palTapMoDong              
        };

            foreach (Control ctrl in menuOrder)
            {
                if (ctrl != null)
                {
                    ctrl.SendToBack(); // Đẩy dần các control lên trên
                }
            }
        }

        // ================== THÔNG TIN TÀI KHOẢN ==================

        public void ThulThongTinTK()
        {
            pnlThongTinTK.Visible = false;
            labThongTinTk = true;
        }

        private void btnThongTinTK_Click(object sender, EventArgs e)
        {
            if (labThongTinTk)
            {
                pnlThongTinTK.Visible = true;
                labThongTinTk = false;
            }
            else
            {
                ThulThongTinTK();
            }
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongTinNhanVien());
        }

        private void btnDangXuatTaiKhoan_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            FormDangNhap form = new FormDangNhap();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        // ================== MENU DANH MỤC ==================

        public void DongTatCaMenu()
        {
            labNutTha_TK.Text = "▶";
            pallist_NV.Height = 60;
            pnlMenuList_NV_TK.Visible = false;

            labNutTha_TK_KH.Text = "▶";
            pnllist_KH.Height = 60;
            pnlMenuList_KH_KV.Visible = false;


            labNutTha_HD.Text = "▶";
            pallistHoaDon.Height = 60;
            pnlMenuLiKH_HH_CTHH.Visible = false;

           

        }

        public void ToggleMenu(Panel pnlCha, Panel pnlCon, Label lblMuiTen, ref bool trangThai, int caoMo, int caoDong)
        {
            if (trangThai)
            {
                pnlCha.Height = caoDong;
                pnlCon.Visible = false;
                lblMuiTen.Text = "▶";
                trangThai = false;
            }
            else
            {
                pnlCha.Height = caoMo;
                pnlCon.Visible = true;
                lblMuiTen.Text = "▼";
                trangThai = true;
            }
        }
        //================== panel ==================
        private void GanClickChoPanel(Panel pnl, EventHandler click)
        {
            pnl.Click += click;
            foreach (Control c in pnl.Controls)
                c.Click += click;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ToggleMenu(pallist_NV, pnlMenuList_NV_TK, labNutTha_TK, ref menuNV_TK, 150, 60);
        }

        private void labNutTha_TK_KH_Click(object sender, EventArgs e)
        {
            ToggleMenu(pnllist_KH, pnlMenuList_KH_KV, labNutTha_TK_KH, ref menuKH_KV, 150, 60);
        }
        private void labNutTha_HD_Click(object sender, EventArgs e)
        {
            ToggleMenu(pallistHoaDon, pnlMenuLiKH_HH_CTHH, labNutTha_HD, ref menuKH_KV, 150, 60);
        }
        // ================== SỰ KIỆN KHÁC ==================

        private void label2_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Trang Chủ";
            OpenChildForm(new FormTrangChu());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Trang Chủ";
            OpenChildForm(new FormTrangChu());
        }
        private void button5_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Quản Lý Nhân Viên";
            OpenChildForm(new FormQuanLyNhanVien());
        }

        private void pnlTrangChu_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Trang Chủ";
            OpenChildForm(new FormTrangChu());
        }

        private void palQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Quản Lý Tài Khoản";
            OpenChildForm(new FormQuanLyTaiKhoan());

        }

        private void palQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Quản Lý Khách Hàng";
            OpenChildForm(new FormQuanLyKhachHang());

        }

        private void palQuanLyKhuVuc_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Quản Lý Khu Vực";
            OpenChildForm(new FormQuanLyKhuVuc());

        }

        private void palQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Quản Lý Nhân Viên";
            OpenChildForm(new FormQuanLyNhanVien());

        }

        private void palNhatKyHeThong_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Nhật Ký Hệ Thống";
            OpenChildForm(new FormNhatKyHeThong());
        }

        private void pallistGhiSoDien_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Ghi Số Điện";
            OpenChildForm(new FormGhiSoDien());
        }

        private void palQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Quản Lý Hóa Đơn";
            OpenChildForm(new FormQuanLyHoaDon());
        }

        private void palQuanLyCongNo_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Quản Lý Công Nợ";
            OpenChildForm (new FormQuanLyCongNo());
        }

        private void pallistQuanLyDongHoDien_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Quản Lý Đồng Hồ điện";
            OpenChildForm(new FormQuanLyDongHo());
        }

        private void pallistQuanLyYeuCaiLapDat_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Quản Lý Lắp Đồng Hồ điện";
            OpenChildForm(new FormQuanLyLapDatDongHo());
        }
        private void pallistBaoCao_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Bao Cao";
            OpenChildForm(new FormBaoCaoDoanhThu());

        }

        private void panel12_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Quản Lý bảng giá điện";
            OpenChildForm(new FormQuanLyBangGia());
        }

        private void pallistChiTietBangGiaDien_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Chi tiết bảng giá điện";
            OpenChildForm(new FormChiTietBangGia(null));
        }
    }
}
