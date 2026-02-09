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
namespace QuanLyDien.Test
{
    public partial class Form1 : Form
    {
        // ================== BIẾN TOÀN CỤC ==================
        [DllImport("user32.dll")]
        public static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        // Trạng thái menu
        bool labMenuList = true;
        bool labThongTinTk = true;

        // Trạng thái menu danh mục
        bool menuNV_TK = false;   // Nhân viên – Tài khoản
        bool menuKH_KV = false;  // Khách hàng – Khu vực

        // Animation menu
        Timer menuTimer = new Timer();
        bool dangThu = false;
        bool dangMo = false;

        // Form con đang mở
        private Form activeForm = null;

        // ================== HÀM KHỞI TẠO ==================

        public Form1()
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
            HienMenu();
            ThulThongTinTK();

            DongTatCaMenu();

            menuNV_TK = false;
            menuKH_KV = false;

            labMaNV.Text = "NV 02"; // Session.MaNV
            XapSepListMenu();

            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
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
                palDongHoDien.Visible = false;
                pnllist_KH.Visible = false;
            }

            if (Session.VaiTro == "Nhân Viên Ghi Điện")
            {
                palDongHoDien.Visible = false;
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

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.pnlMain.Controls.Add(childForm);
            this.pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // ================== ANIMATION MENU ==================

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dangMo)
            {
                if (panelMenu.Width < 280)
                    panelMenu.Width += 10;
                else
                {
                    panelMenu.Width = 280;
                    dangMo = false;
                    timer1.Stop();
                    HienMenu();
                }
            }

            if (dangThu)
            {
                if (panelMenu.Width > 70)
                    panelMenu.Width -= 10;
                else
                {
                    panelMenu.Width = 70;
                    dangThu = false;
                    timer1.Stop();
                    ThuMenu();
                }
            }
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            dangMo = true;
            dangThu = false;
            timer1.Start();
        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            dangThu = true;
            dangMo = false;
            timer1.Start();
        }

        // ================== MENU CHÍNH ==================

        public void HienMenu()
        {
            panelMenu.Width = 280;
            btnHienMenu.Visible = false;
            btnThuMenu.Visible = true;

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }

        public void ThuMenu()
        {
            panelMenu.Width = 70;
            btnHienMenu.Visible = true;
            btnThuMenu.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        // ================== SẮP XẾP MENU ==================

        public void XapSepListMenu()
        {
            panelMenu.Controls.SetChildIndex(pnlTrangChu, 3);
            panelMenu.Controls.SetChildIndex(pnllist_KH, 1);
            panelMenu.Controls.SetChildIndex(pnlTrangChu, 3);
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
            pnllist_NV.Height = 60;
            pnlMenuList_NV_TK.Visible = false;

            labNutTha_TK_KH.Text = "▶";
            pnllist_KH.Height = 60;
            pnlMenuList_KH_KV.Visible = false;
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

        private void label6_Click(object sender, EventArgs e)
        {
            ToggleMenu(pnllist_NV, pnlMenuList_NV_TK, labNutTha_TK, ref menuNV_TK, 150, 60);
        }

        private void labNutTha_TK_KH_Click(object sender, EventArgs e)
        {
            ToggleMenu(pnllist_KH, pnlMenuList_KH_KV, labNutTha_TK_KH, ref menuKH_KV, 150, 60);
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


    }
}
