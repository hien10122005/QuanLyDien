namespace QuanLyDien.Admin
{
    partial class FormQuanLyTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.palThongTin = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.cmbVaiTro = new System.Windows.Forms.ComboBox();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.pnlSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btbClea = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.palThongTin.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.panelTop.Controls.Add(this.palThongTin);
            this.panelTop.Controls.Add(this.pnlSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20);
            this.panelTop.Size = new System.Drawing.Size(950, 300);
            this.panelTop.TabIndex = 0;
            this.panelTop.Resize += new System.EventHandler(this.panelTop_Resize);
            // 
            // palThongTin
            // 
            this.palThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.palThongTin.Controls.Add(this.label5);
            this.palThongTin.Controls.Add(this.label4);
            this.palThongTin.Controls.Add(this.label3);
            this.palThongTin.Controls.Add(this.label2);
            this.palThongTin.Controls.Add(this.label1);
            this.palThongTin.Controls.Add(this.label6);
            this.palThongTin.Controls.Add(this.txtTenDangNhap);
            this.palThongTin.Controls.Add(this.txtMatKhau);
            this.palThongTin.Controls.Add(this.cmbMaNV);
            this.palThongTin.Controls.Add(this.cmbVaiTro);
            this.palThongTin.Controls.Add(this.cmbTrangThai);
            this.palThongTin.Location = new System.Drawing.Point(23, 15);
            this.palThongTin.Name = "palThongTin";
            this.palThongTin.Size = new System.Drawing.Size(900, 210);
            this.palThongTin.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(480, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vai trò:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(30, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(30, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(480, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Trạng thái:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.White;
            this.txtTenDangNhap.Location = new System.Drawing.Point(140, 67);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(250, 25);
            this.txtTenDangNhap.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.ForeColor = System.Drawing.Color.White;
            this.txtMatKhau.Location = new System.Drawing.Point(140, 157);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(250, 25);
            this.txtMatKhau.TabIndex = 7;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.cmbMaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaNV.ForeColor = System.Drawing.Color.White;
            this.cmbMaNV.Location = new System.Drawing.Point(140, 112);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(250, 25);
            this.cmbMaNV.TabIndex = 8;
            this.cmbMaNV.SelectedIndexChanged += new System.EventHandler(this.cmbMaNV_SelectedIndexChanged);
            // 
            // cmbVaiTro
            // 
            this.cmbVaiTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.cmbVaiTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVaiTro.ForeColor = System.Drawing.Color.White;
            this.cmbVaiTro.Location = new System.Drawing.Point(580, 67);
            this.cmbVaiTro.Name = "cmbVaiTro";
            this.cmbVaiTro.Size = new System.Drawing.Size(250, 25);
            this.cmbVaiTro.TabIndex = 9;
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.cmbTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTrangThai.ForeColor = System.Drawing.Color.White;
            this.cmbTrangThai.Location = new System.Drawing.Point(580, 112);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(250, 25);
            this.cmbTrangThai.TabIndex = 10;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnThem);
            this.pnlSearch.Controls.Add(this.btnSua);
            this.pnlSearch.Controls.Add(this.btnXoa);
            this.pnlSearch.Controls.Add(this.btnTim);
            this.pnlSearch.Controls.Add(this.btbClea);
            this.pnlSearch.Location = new System.Drawing.Point(23, 235);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(900, 50);
            this.pnlSearch.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(25, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(205, 5);
            this.btnSua.Margin = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "CẬP NHẬT";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(385, 5);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "KHÓA / MỞ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(565, 5);
            this.btnTim.Margin = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(130, 40);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "TÌM KIẾM";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btbClea
            // 
            this.btbClea.BackColor = System.Drawing.Color.Gray;
            this.btbClea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbClea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btbClea.ForeColor = System.Drawing.Color.White;
            this.btbClea.Location = new System.Drawing.Point(745, 5);
            this.btbClea.Margin = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.btbClea.Name = "btbClea";
            this.btbClea.Size = new System.Drawing.Size(130, 40);
            this.btbClea.TabIndex = 4;
            this.btbClea.Text = "LÀM MỚI";
            this.btbClea.UseVisualStyleBackColor = false;
            this.btbClea.Click += new System.EventHandler(this.btbClea_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.panelBottom.Controls.Add(this.dgvTaiKhoan);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 300);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(20);
            this.panelBottom.Size = new System.Drawing.Size(950, 300);
            this.panelBottom.TabIndex = 1;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaiKhoan.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(20, 20);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(910, 260);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            this.dgvTaiKhoan.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTaiKhoan_DataBindingComplete);
            // 
            // FormQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyTaiKhoan";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.FormQuanLyTaiKhoan_Load);
            this.panelTop.ResumeLayout(false);
            this.palThongTin.ResumeLayout(false);
            this.palThongTin.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel palThongTin;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6;
        private System.Windows.Forms.TextBox txtTenDangNhap, txtMatKhau;
        private System.Windows.Forms.ComboBox cmbMaNV, cmbVaiTro, cmbTrangThai;
        private System.Windows.Forms.FlowLayoutPanel pnlSearch;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnTim, btbClea;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
    }
}