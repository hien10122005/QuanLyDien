namespace QuanLyDien.NhanVienGhi
{
    partial class FormGhiSoDien
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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.palThongTin = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaGhi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaDongHo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudThang = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChiSoCu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChiSoMoi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSanLuong = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dgvGhiChiSo = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.palThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiChiSo)).BeginInit();
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
            this.panelTop.Resize += new System.EventHandler(this.panelTop_Resize_1);
            // 
            // palThongTin
            // 
            this.palThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.palThongTin.Controls.Add(this.labelTitle);
            this.palThongTin.Controls.Add(this.label1);
            this.palThongTin.Controls.Add(this.txtMaGhi);
            this.palThongTin.Controls.Add(this.label2);
            this.palThongTin.Controls.Add(this.cmbMaDongHo);
            this.palThongTin.Controls.Add(this.label3);
            this.palThongTin.Controls.Add(this.nudThang);
            this.palThongTin.Controls.Add(this.label7);
            this.palThongTin.Controls.Add(this.nudNam);
            this.palThongTin.Controls.Add(this.label4);
            this.palThongTin.Controls.Add(this.txtChiSoCu);
            this.palThongTin.Controls.Add(this.label5);
            this.palThongTin.Controls.Add(this.txtChiSoMoi);
            this.palThongTin.Controls.Add(this.label6);
            this.palThongTin.Controls.Add(this.txtSanLuong);
            this.palThongTin.Location = new System.Drawing.Point(41, 12);
            this.palThongTin.Name = "palThongTin";
            this.palThongTin.Size = new System.Drawing.Size(918, 231);
            this.palThongTin.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(378, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "GHI CHỈ SỐ ĐIỆN HÀNG THÁNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Ghi:";
            // 
            // txtMaGhi
            // 
            this.txtMaGhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtMaGhi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaGhi.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtMaGhi.ForeColor = System.Drawing.Color.White;
            this.txtMaGhi.Location = new System.Drawing.Point(145, 63);
            this.txtMaGhi.Name = "txtMaGhi";
            this.txtMaGhi.Size = new System.Drawing.Size(250, 27);
            this.txtMaGhi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đồng Hồ:";
            // 
            // cmbMaDongHo
            // 
            this.cmbMaDongHo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.cmbMaDongHo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaDongHo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmbMaDongHo.ForeColor = System.Drawing.Color.White;
            this.cmbMaDongHo.FormattingEnabled = true;
            this.cmbMaDongHo.Location = new System.Drawing.Point(145, 112);
            this.cmbMaDongHo.Name = "cmbMaDongHo";
            this.cmbMaDongHo.Size = new System.Drawing.Size(250, 28);
            this.cmbMaDongHo.TabIndex = 4;
            this.cmbMaDongHo.SelectedIndexChanged += new System.EventHandler(this.cmbMaDongHo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(35, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tháng/Năm:";
            // 
            // nudThang
            // 
            this.nudThang.Font = new System.Drawing.Font("Segoe UI", 11.25F);
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
            this.nudThang.Size = new System.Drawing.Size(80, 27);
            this.nudThang.TabIndex = 6;
            this.nudThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThang.ValueChanged += new System.EventHandler(this.nudThang_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(231, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "/";
            // 
            // nudNam
            // 
            this.nudNam.Font = new System.Drawing.Font("Segoe UI", 11.25F);
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
            this.nudNam.Size = new System.Drawing.Size(139, 27);
            this.nudNam.TabIndex = 8;
            this.nudNam.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.nudNam.ValueChanged += new System.EventHandler(this.nudNam_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(500, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chỉ Số Cũ:";
            // 
            // txtChiSoCu
            // 
            this.txtChiSoCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtChiSoCu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChiSoCu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtChiSoCu.ForeColor = System.Drawing.Color.Yellow;
            this.txtChiSoCu.Location = new System.Drawing.Point(620, 63);
            this.txtChiSoCu.Name = "txtChiSoCu";
            this.txtChiSoCu.ReadOnly = true;
            this.txtChiSoCu.Size = new System.Drawing.Size(250, 27);
            this.txtChiSoCu.TabIndex = 10;
            this.txtChiSoCu.Text = "0";
            this.txtChiSoCu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(500, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chỉ Số Mới:";
            // 
            // txtChiSoMoi
            // 
            this.txtChiSoMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtChiSoMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChiSoMoi.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtChiSoMoi.ForeColor = System.Drawing.Color.White;
            this.txtChiSoMoi.Location = new System.Drawing.Point(620, 112);
            this.txtChiSoMoi.Name = "txtChiSoMoi";
            this.txtChiSoMoi.Size = new System.Drawing.Size(250, 27);
            this.txtChiSoMoi.TabIndex = 12;
            this.txtChiSoMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(500, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sản Lượng:";
            // 
            // txtSanLuong
            // 
            this.txtSanLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtSanLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSanLuong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtSanLuong.ForeColor = System.Drawing.Color.Lime;
            this.txtSanLuong.Location = new System.Drawing.Point(620, 161);
            this.txtSanLuong.Name = "txtSanLuong";
            this.txtSanLuong.ReadOnly = true;
            this.txtSanLuong.Size = new System.Drawing.Size(250, 27);
            this.txtSanLuong.TabIndex = 14;
            this.txtSanLuong.Text = "0";
            this.txtSanLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlSearch
            // 
            this.pnlSearch.ColumnCount = 5;
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSearch.Controls.Add(this.btnThem, 0, 0);
            this.pnlSearch.Controls.Add(this.btnSua, 1, 0);
            this.pnlSearch.Controls.Add(this.btnXoa, 2, 0);
            this.pnlSearch.Controls.Add(this.btnTimKiem, 3, 0);
            this.pnlSearch.Controls.Add(this.btnLamMoi, 4, 0);
            this.pnlSearch.Location = new System.Drawing.Point(41, 255);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.RowCount = 1;
            this.pnlSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSearch.Size = new System.Drawing.Size(918, 51);
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
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(177, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "LƯU CHỈ SỐ";
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
            this.btnSua.Location = new System.Drawing.Point(186, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(177, 45);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(369, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(177, 45);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(552, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(177, 45);
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
            this.btnLamMoi.Location = new System.Drawing.Point(735, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(180, 45);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.panelBottom.Controls.Add(this.dgvGhiChiSo);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 320);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(20);
            this.panelBottom.Size = new System.Drawing.Size(1000, 280);
            this.panelBottom.TabIndex = 2;
            // 
            // dgvGhiChiSo
            // 
            this.dgvGhiChiSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGhiChiSo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.dgvGhiChiSo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGhiChiSo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGhiChiSo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvGhiChiSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvGhiChiSo.ColumnHeadersHeight = 40;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGhiChiSo.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvGhiChiSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGhiChiSo.EnableHeadersVisualStyles = false;
            this.dgvGhiChiSo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.dgvGhiChiSo.Location = new System.Drawing.Point(20, 20);
            this.dgvGhiChiSo.Name = "dgvGhiChiSo";
            this.dgvGhiChiSo.RowHeadersVisible = false;
            this.dgvGhiChiSo.RowTemplate.Height = 35;
            this.dgvGhiChiSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGhiChiSo.Size = new System.Drawing.Size(960, 240);
            this.dgvGhiChiSo.TabIndex = 0;
            this.dgvGhiChiSo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGhiChiSo_CellClick);
            this.dgvGhiChiSo.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvGhiChiSo_DataBindingComplete);
            // 
            // FormGhiSoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGhiSoDien";
            this.Text = "Ghi Chỉ Số Điện";
            this.Load += new System.EventHandler(this.FormGhiSoDien_Load);
            this.panelTop.ResumeLayout(false);
            this.palThongTin.ResumeLayout(false);
            this.palThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiChiSo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel palThongTin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaGhi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaDongHo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudThang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChiSoCu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChiSoMoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSanLuong;
        private System.Windows.Forms.TableLayoutPanel pnlSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dgvGhiChiSo;
    }
}