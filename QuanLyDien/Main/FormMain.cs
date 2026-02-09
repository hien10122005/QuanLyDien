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

            labMaNV.Text = "NV 02"; // Session.MaNV
            XapSepListMenu();

            // Gán sự kiện click cho panel
            GanClickChoPanel(pnllistTrangChu, pnlTrangChu_Click);
            GanClickChoPanel(palQuanLyKhuVuc, palQuanLyKhuVuc_Click);
            GanClickChoPanel(palQuanLyKhachHang, palQuanLyKhachHang_Click);
            GanClickChoPanel(palQuanLyTaiKhoan, palQuanLyTaiKhoan_Click);
            GanClickChoPanel(palQuanLyNhanVien, palQuanLyNhanVien_Click);
            GanClickChoPanel(pallistQuanLyYeuCaiLapDat, palNhatKyHeThong_Click);
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
            labMaNV.Text = Session.MaNV;

            if (Session.VaiTro == "Nhân Viên Thu Điện")
            {
                pallistHoaDon.Visible = false;
                pnllist_KH.Visible = false;
            }

            if (Session.VaiTro == "Nhân Viên Ghi Điện")
            {
                pallistHoaDon.Visible = false;
                pnllist_KH.Visible = false;
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
            // Bỏ hết logic timer, gọi trực tiếp
            HienMenu();
        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            // Bỏ hết logic timer, gọi trực tiếp
            ThuMenu();
        }

        // ================== MENU CHÍNH ==================

        public void HienMenu()
        {
            panelMenu.Width = 280; // Gán kích thước tối đa ngay lập tức
            btnHienMenu.Visible = false;
            btnThuMenu.Visible = true;

            // Hiện các chữ nhãn
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label10.Visible = true;
        }

        public void ThuMenu()
        {
            panelMenu.Width = 70; // Thu nhỏ về icon ngay lập tức
            btnHienMenu.Visible = true;
            btnThuMenu.Visible = false;

            // Ẩn các chữ nhãn
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label10.Visible = false;
        }

        // ================== SẮP XẾP MENU HIỂN THỊ  ==================

        public void XapSepListMenu()
        {
            // panelMenu.Controls.SetChildIndex(pnlTrangChu, 3);
            // panelMenu.Controls.SetChildIndex(pnllist_KH, 1);
            //  panelMenu.Controls.SetChildIndex(pnlTrangChu,0);
            //  panelMenu.Controls.SetChildIndex(palQuanLyYeuCaiLapDat, 0);

            Control[] menuOrder = new Control[] {
                pallistNhatKyHeThong,
                pallistGhiSoDien,
                pallistQuanLyDongHoDien,
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
                if (ctrl != null) ctrl.SendToBack();
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
            OpenChildForm(new FormTrangChu());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTrangChu());
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labTieuDe.Text = "Quản Lý Nhân Viên";
            OpenChildForm(new FormQuanLyNhanVien());
        }

        private void pnlTrangChu_Click(object sender, EventArgs e)
        {
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
            label1.Text = "Nhật Ký Hệ Thống";
            OpenChildForm(new FormNhatKyHeThong());
        }

        private void pallistGhiSoDien_Click(object sender, EventArgs e)
        {
            label1.Text = "Ghi Số Điện";
            OpenChildForm(new FormGhiSoDien());
        }

        private void palQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            label1.Text = "Quản Lý Hóa Đơn";
            OpenChildForm(new FormQuanLyHoaDon());
        }

        private void palQuanLyCongNo_Click(object sender, EventArgs e)
        {
            label1.Text = "Quản Lý Công Nợ";
            OpenChildForm (new FormQuanLyCongNo());
        }

        private void pallistQuanLyDongHoDien_Click(object sender, EventArgs e)
        {
            label1.Text = "Quản Lý Đồng Hồ điện";
            OpenChildForm(new FormQuanLyDongHo());
        }
    }
}
