namespace QuanLyDien.Admin
{
    partial class FormQuanLyLapDatDongHo
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.lblMaYC = new System.Windows.Forms.Label();
            this.txtMaYeuCau = new System.Windows.Forms.TextBox();
            this.lblKH = new System.Windows.Forms.Label();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtpNgayYeuCau = new System.Windows.Forms.DateTimePicker();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuyYeuCau = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dgvYeuCau = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.palThongTin.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(1084, 380);
            this.panelTop.TabIndex = 0;
            this.panelTop.Resize += new System.EventHandler(this.panelTop_Resize);
            // 
            // palThongTin
            // 
            this.palThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.palThongTin.Controls.Add(this.labelTitle);
            this.palThongTin.Controls.Add(this.lblMaYC);
            this.palThongTin.Controls.Add(this.txtMaYeuCau);
            this.palThongTin.Controls.Add(this.lblKH);
            this.palThongTin.Controls.Add(this.cmbKhachHang);
            this.palThongTin.Controls.Add(this.lblNV);
            this.palThongTin.Controls.Add(this.cmbNhanVien);
            this.palThongTin.Controls.Add(this.lblNgay);
            this.palThongTin.Controls.Add(this.dtpNgayYeuCau);
            this.palThongTin.Controls.Add(this.lblDiaDiem);
            this.palThongTin.Controls.Add(this.txtDiaDiem);
            this.palThongTin.Controls.Add(this.lblTrangThai);
            this.palThongTin.Controls.Add(this.cmbTrangThai);
            this.palThongTin.Controls.Add(this.lblGhiChu);
            this.palThongTin.Controls.Add(this.txtGhiChu);
            this.palThongTin.Location = new System.Drawing.Point(42, 12);
            this.palThongTin.Name = "palThongTin";
            this.palThongTin.Size = new System.Drawing.Size(1000, 290);
            this.palThongTin.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(359, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "TIẾP NHẬN YÊU CẦU LẮP ĐẶT";
            // 
            // lblMaYC
            // 
            this.lblMaYC.AutoSize = true;
            this.lblMaYC.ForeColor = System.Drawing.Color.Silver;
            this.lblMaYC.Location = new System.Drawing.Point(35, 70);
            this.lblMaYC.Name = "lblMaYC";
            this.lblMaYC.Size = new System.Drawing.Size(80, 17);
            this.lblMaYC.TabIndex = 1;
            this.lblMaYC.Text = "Mã Yêu Cầu:";
            // 
            // txtMaYeuCau
            // 
            this.txtMaYeuCau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtMaYeuCau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaYeuCau.ForeColor = System.Drawing.Color.White;
            this.txtMaYeuCau.Location = new System.Drawing.Point(155, 67);
            this.txtMaYeuCau.Name = "txtMaYeuCau";
            this.txtMaYeuCau.Size = new System.Drawing.Size(300, 25);
            this.txtMaYeuCau.TabIndex = 2;
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.ForeColor = System.Drawing.Color.Silver;
            this.lblKH.Location = new System.Drawing.Point(35, 120);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(81, 17);
            this.lblKH.TabIndex = 3;
            this.lblKH.Text = "Khách Hàng:";
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.cmbKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKhachHang.ForeColor = System.Drawing.Color.White;
            this.cmbKhachHang.Location = new System.Drawing.Point(155, 117);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(300, 25);
            this.cmbKhachHang.TabIndex = 4;
            this.cmbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cmbKhachHang_SelectedIndexChanged);
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.ForeColor = System.Drawing.Color.Silver;
            this.lblNV.Location = new System.Drawing.Point(35, 170);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(90, 17);
            this.lblNV.TabIndex = 5;
            this.lblNV.Text = "Nhân Viên KT:";
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.cmbNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNhanVien.ForeColor = System.Drawing.Color.White;
            this.cmbNhanVien.Location = new System.Drawing.Point(155, 167);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(300, 25);
            this.cmbNhanVien.TabIndex = 6;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.ForeColor = System.Drawing.Color.Silver;
            this.lblNgay.Location = new System.Drawing.Point(35, 220);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(92, 17);
            this.lblNgay.TabIndex = 7;
            this.lblNgay.Text = "Ngày Yêu Cầu:";
            // 
            // dtpNgayYeuCau
            // 
            this.dtpNgayYeuCau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayYeuCau.Location = new System.Drawing.Point(155, 217);
            this.dtpNgayYeuCau.Name = "dtpNgayYeuCau";
            this.dtpNgayYeuCau.Size = new System.Drawing.Size(300, 25);
            this.dtpNgayYeuCau.TabIndex = 8;
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.ForeColor = System.Drawing.Color.Silver;
            this.lblDiaDiem.Location = new System.Drawing.Point(520, 70);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(89, 17);
            this.lblDiaDiem.TabIndex = 9;
            this.lblDiaDiem.Text = "Địa Điểm Lắp:";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtDiaDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaDiem.ForeColor = System.Drawing.Color.White;
            this.txtDiaDiem.Location = new System.Drawing.Point(650, 67);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(315, 25);
            this.txtDiaDiem.TabIndex = 10;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.ForeColor = System.Drawing.Color.Silver;
            this.lblTrangThai.Location = new System.Drawing.Point(520, 120);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(72, 17);
            this.lblTrangThai.TabIndex = 11;
            this.lblTrangThai.Text = "Trạng Thái:";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTrangThai.ForeColor = System.Drawing.Color.White;
            this.cmbTrangThai.Location = new System.Drawing.Point(650, 117);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(315, 25);
            this.cmbTrangThai.TabIndex = 12;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.ForeColor = System.Drawing.Color.Silver;
            this.lblGhiChu.Location = new System.Drawing.Point(520, 170);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(56, 17);
            this.lblGhiChu.TabIndex = 13;
            this.lblGhiChu.Text = "Ghi Chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.ForeColor = System.Drawing.Color.White;
            this.txtGhiChu.Location = new System.Drawing.Point(650, 167);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(315, 77);
            this.txtGhiChu.TabIndex = 14;
            // 
            // pnlSearch
            // 
            this.pnlSearch.ColumnCount = 4;
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSearch.Controls.Add(this.btnThem, 0, 0);
            this.pnlSearch.Controls.Add(this.btnSua, 1, 0);
            this.pnlSearch.Controls.Add(this.btnHuyYeuCau, 2, 0);
            this.pnlSearch.Controls.Add(this.btnLamMoi, 3, 0);
            this.pnlSearch.Location = new System.Drawing.Point(42, 315);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.RowCount = 1;
            this.pnlSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSearch.Size = new System.Drawing.Size(1000, 50);
            this.pnlSearch.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(5, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(240, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "TIẾP NHẬN";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(255, 5);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(240, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "CẬP NHẬT";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnHuyYeuCau
            // 
            this.btnHuyYeuCau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnHuyYeuCau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuyYeuCau.FlatAppearance.BorderSize = 0;
            this.btnHuyYeuCau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyYeuCau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuyYeuCau.ForeColor = System.Drawing.Color.White;
            this.btnHuyYeuCau.Location = new System.Drawing.Point(505, 5);
            this.btnHuyYeuCau.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuyYeuCau.Name = "btnHuyYeuCau";
            this.btnHuyYeuCau.Size = new System.Drawing.Size(240, 40);
            this.btnHuyYeuCau.TabIndex = 2;
            this.btnHuyYeuCau.Text = "HỦY YÊU CẦU";
            this.btnHuyYeuCau.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(755, 5);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(240, 40);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.dgvYeuCau);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 380);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(20);
            this.panelBottom.Size = new System.Drawing.Size(1084, 271);
            this.panelBottom.TabIndex = 2;
            // 
            // dgvYeuCau
            // 
            this.dgvYeuCau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYeuCau.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.dgvYeuCau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvYeuCau.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvYeuCau.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan;
            this.dgvYeuCau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvYeuCau.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvYeuCau.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvYeuCau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYeuCau.EnableHeadersVisualStyles = false;
            this.dgvYeuCau.Location = new System.Drawing.Point(20, 20);
            this.dgvYeuCau.Name = "dgvYeuCau";
            this.dgvYeuCau.RowHeadersVisible = false;
            this.dgvYeuCau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYeuCau.Size = new System.Drawing.Size(1044, 231);
            this.dgvYeuCau.TabIndex = 0;
            this.dgvYeuCau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYeuCau_CellClick);
            // 
            // FormQuanLyLapDatDongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1084, 651);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyLapDatDongHo";
            this.Text = "Quản Lý Lắp Đặt Đồng Hồ";
            this.Load += new System.EventHandler(this.FormQuanLyLapDatDongHo_Load);
            this.panelTop.ResumeLayout(false);
            this.palThongTin.ResumeLayout(false);
            this.palThongTin.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel palThongTin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lblMaYC, lblKH, lblNV, lblNgay, lblDiaDiem, lblTrangThai, lblGhiChu;
        private System.Windows.Forms.TextBox txtMaYeuCau, txtDiaDiem, txtGhiChu;
        private System.Windows.Forms.ComboBox cmbKhachHang, cmbNhanVien, cmbTrangThai;
        private System.Windows.Forms.DateTimePicker dtpNgayYeuCau;
        private System.Windows.Forms.TableLayoutPanel pnlSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuyYeuCau;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dgvYeuCau;
    }
}