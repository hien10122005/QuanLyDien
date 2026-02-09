namespace QuanLyDien.NhanVienThu
{
    partial class FormQuanLyHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudThang = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.pnlSearch = new System.Windows.Forms.TableLayoutPanel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.palThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(1000, 320);
            this.panelTop.TabIndex = 0;
            this.panelTop.Resize += new System.EventHandler(this.panelTop_Resize);
            // 
            // palThongTin
            // 
            this.palThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.palThongTin.Controls.Add(this.labelTitle);
            this.palThongTin.Controls.Add(this.label1);
            this.palThongTin.Controls.Add(this.txtMaHD);
            this.palThongTin.Controls.Add(this.label2);
            this.palThongTin.Controls.Add(this.txtTenKH);
            this.palThongTin.Controls.Add(this.label3);
            this.palThongTin.Controls.Add(this.nudThang);
            this.palThongTin.Controls.Add(this.label7);
            this.palThongTin.Controls.Add(this.nudNam);
            this.palThongTin.Controls.Add(this.label4);
            this.palThongTin.Controls.Add(this.txtTongTien);
            this.palThongTin.Controls.Add(this.label5);
            this.palThongTin.Controls.Add(this.cmbTrangThai);
            this.palThongTin.Controls.Add(this.label6);
            this.palThongTin.Controls.Add(this.dtpNgayThanhToan);
            this.palThongTin.Location = new System.Drawing.Point(41, 12);
            this.palThongTin.Name = "palThongTin";
            this.palThongTin.Size = new System.Drawing.Size(939, 230);
            this.palThongTin.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(495, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "THÔNG TIN HÓA ĐƠN TIỀN ĐIỆN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtMaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtMaHD.ForeColor = System.Drawing.Color.White;
            this.txtMaHD.Location = new System.Drawing.Point(145, 63);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(250, 32);
            this.txtMaHD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khách Hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtTenKH.ForeColor = System.Drawing.Color.White;
            this.txtTenKH.Location = new System.Drawing.Point(145, 112);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(250, 32);
            this.txtTenKH.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(35, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tháng/Năm:";
            // 
            // nudThang
            // 
            this.nudThang.Location = new System.Drawing.Point(145, 161);
            this.nudThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThang.Name = "nudThang";
            this.nudThang.Size = new System.Drawing.Size(80, 29);
            this.nudThang.TabIndex = 6;
            this.nudThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(231, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "/";
            // 
            // nudNam
            // 
            this.nudNam.Location = new System.Drawing.Point(256, 161);
            this.nudNam.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(139, 29);
            this.nudNam.TabIndex = 8;
            this.nudNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(500, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng Tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.txtTongTien.Location = new System.Drawing.Point(630, 63);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(250, 32);
            this.txtTongTien.TabIndex = 10;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(500, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Trạng Thái:";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.cmbTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTrangThai.ForeColor = System.Drawing.Color.White;
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(630, 112);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(250, 29);
            this.cmbTrangThai.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(500, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày Thu:";
            // 
            // dtpNgayThanhToan
            // 
            this.dtpNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThanhToan.Location = new System.Drawing.Point(630, 161);
            this.dtpNgayThanhToan.Name = "dtpNgayThanhToan";
            this.dtpNgayThanhToan.Size = new System.Drawing.Size(250, 29);
            this.dtpNgayThanhToan.TabIndex = 14;
            // 
            // pnlSearch
            // 
            this.pnlSearch.ColumnCount = 5;
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSearch.Controls.Add(this.btnThanhToan, 0, 0);
            this.pnlSearch.Controls.Add(this.btnInHoaDon, 2, 0);
            this.pnlSearch.Controls.Add(this.btnTimKiem, 3, 0);
            this.pnlSearch.Controls.Add(this.btnLamMoi, 4, 0);
            this.pnlSearch.Location = new System.Drawing.Point(41, 255);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.RowCount = 1;
            this.pnlSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSearch.Size = new System.Drawing.Size(918, 51);
            this.pnlSearch.TabIndex = 1;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(3, 3);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(162, 45);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(0)))), ((int)(((byte)(167)))));
            this.btnInHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInHoaDon.FlatAppearance.BorderSize = 0;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnInHoaDon.Location = new System.Drawing.Point(171, 3);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(244, 45);
            this.btnInHoaDon.TabIndex = 2;
            this.btnInHoaDon.Text = "IN HÓA ĐƠN";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(421, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(244, 45);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(671, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(244, 45);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.dgvHoaDon);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 320);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(20);
            this.panelBottom.Size = new System.Drawing.Size(1000, 280);
            this.panelBottom.TabIndex = 2;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.Location = new System.Drawing.Point(20, 20);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(960, 240);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            this.dgvHoaDon.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvHoaDon_DataBindingComplete);
            // 
            // FormQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyHoaDon";
            this.Text = "Quản Lý Hóa Đơn";
            this.Load += new System.EventHandler(this.FormQuanLyHoaDon_Load);
            this.panelTop.ResumeLayout(false);
            this.palThongTin.ResumeLayout(false);
            this.palThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop, palThongTin;
        private System.Windows.Forms.Label labelTitle, label1, label2, label3, label4, label5, label6, label7;
        private System.Windows.Forms.TextBox txtMaHD, txtTenKH, txtTongTien;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.NumericUpDown nudThang, nudNam;
        private System.Windows.Forms.DateTimePicker dtpNgayThanhToan;
        private System.Windows.Forms.TableLayoutPanel pnlSearch;
        private System.Windows.Forms.Button btnThanhToan, btnInHoaDon, btnTimKiem, btnLamMoi;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dgvHoaDon;
    }
}