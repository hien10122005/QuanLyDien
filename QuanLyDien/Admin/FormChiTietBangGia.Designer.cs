namespace QuanLyDien.Admin
{
    partial class FormChiTietBangGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.palThongTin = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.lblMaBG = new System.Windows.Forms.Label();
            this.cmbBangGiaCha = new System.Windows.Forms.ComboBox();
            this.lblBac = new System.Windows.Forms.Label();
            this.nudBac = new System.Windows.Forms.NumericUpDown();
            this.lblTuSo = new System.Windows.Forms.Label();
            this.txtTuSo = new System.Windows.Forms.TextBox();
            this.lblDenSo = new System.Windows.Forms.Label();
            this.txtDenSo = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.palThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBac)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
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
            // 
            // palThongTin
            // 
            this.palThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.palThongTin.Controls.Add(this.labelTitle);
            this.palThongTin.Controls.Add(this.lblMaBG);
            this.palThongTin.Controls.Add(this.cmbBangGiaCha);
            this.palThongTin.Controls.Add(this.lblBac);
            this.palThongTin.Controls.Add(this.nudBac);
            this.palThongTin.Controls.Add(this.lblTuSo);
            this.palThongTin.Controls.Add(this.txtTuSo);
            this.palThongTin.Controls.Add(this.lblDenSo);
            this.palThongTin.Controls.Add(this.txtDenSo);
            this.palThongTin.Controls.Add(this.lblGia);
            this.palThongTin.Controls.Add(this.txtDonGia);
            this.palThongTin.Location = new System.Drawing.Point(40, 12);
            this.palThongTin.Name = "palThongTin";
            this.palThongTin.Size = new System.Drawing.Size(920, 220);
            this.palThongTin.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(390, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "THIẾT LẬP ĐƠN GIÁ BẬC THANG";
            // 
            // lblMaBG
            // 
            this.lblMaBG.AutoSize = true;
            this.lblMaBG.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblMaBG.ForeColor = System.Drawing.Color.Silver;
            this.lblMaBG.Location = new System.Drawing.Point(30, 65);
            this.lblMaBG.Name = "lblMaBG";
            this.lblMaBG.Size = new System.Drawing.Size(109, 20);
            this.lblMaBG.TabIndex = 1;
            this.lblMaBG.Text = "Chọn Biểu Giá:";
            // 
            // cmbBangGiaCha
            // 
            this.cmbBangGiaCha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.cmbBangGiaCha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBangGiaCha.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbBangGiaCha.ForeColor = System.Drawing.Color.White;
            this.cmbBangGiaCha.FormattingEnabled = true;
            this.cmbBangGiaCha.Location = new System.Drawing.Point(150, 62);
            this.cmbBangGiaCha.Name = "cmbBangGiaCha";
            this.cmbBangGiaCha.Size = new System.Drawing.Size(300, 28);
            this.cmbBangGiaCha.TabIndex = 2;
            this.cmbBangGiaCha.SelectedIndexChanged += new System.EventHandler(this.cmbBangGiaCha_SelectedIndexChanged);
            // 
            // lblBac
            // 
            this.lblBac.AutoSize = true;
            this.lblBac.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblBac.ForeColor = System.Drawing.Color.Silver;
            this.lblBac.Location = new System.Drawing.Point(30, 115);
            this.lblBac.Name = "lblBac";
            this.lblBac.Size = new System.Drawing.Size(67, 20);
            this.lblBac.TabIndex = 3;
            this.lblBac.Text = "Bậc Thứ:";
            // 
            // nudBac
            // 
            this.nudBac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.nudBac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudBac.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudBac.ForeColor = System.Drawing.Color.White;
            this.nudBac.Location = new System.Drawing.Point(150, 112);
            this.nudBac.Name = "nudBac";
            this.nudBac.Size = new System.Drawing.Size(100, 27);
            this.nudBac.TabIndex = 4;
            // 
            // lblTuSo
            // 
            this.lblTuSo.AutoSize = true;
            this.lblTuSo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTuSo.ForeColor = System.Drawing.Color.Silver;
            this.lblTuSo.Location = new System.Drawing.Point(500, 65);
            this.lblTuSo.Name = "lblTuSo";
            this.lblTuSo.Size = new System.Drawing.Size(96, 20);
            this.lblTuSo.TabIndex = 5;
            this.lblTuSo.Text = "Từ Số (kWh):";
            // 
            // txtTuSo
            // 
            this.txtTuSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtTuSo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTuSo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTuSo.ForeColor = System.Drawing.Color.White;
            this.txtTuSo.Location = new System.Drawing.Point(620, 62);
            this.txtTuSo.Name = "txtTuSo";
            this.txtTuSo.Size = new System.Drawing.Size(250, 27);
            this.txtTuSo.TabIndex = 6;
            // 
            // lblDenSo
            // 
            this.lblDenSo.AutoSize = true;
            this.lblDenSo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblDenSo.ForeColor = System.Drawing.Color.Silver;
            this.lblDenSo.Location = new System.Drawing.Point(500, 115);
            this.lblDenSo.Name = "lblDenSo";
            this.lblDenSo.Size = new System.Drawing.Size(107, 20);
            this.lblDenSo.TabIndex = 7;
            this.lblDenSo.Text = "Đến Số (kWh):";
            // 
            // txtDenSo
            // 
            this.txtDenSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtDenSo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDenSo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDenSo.ForeColor = System.Drawing.Color.White;
            this.txtDenSo.Location = new System.Drawing.Point(620, 112);
            this.txtDenSo.Name = "txtDenSo";
            this.txtDenSo.Size = new System.Drawing.Size(250, 27);
            this.txtDenSo.TabIndex = 8;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblGia.ForeColor = System.Drawing.Color.Yellow;
            this.lblGia.Location = new System.Drawing.Point(30, 165);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(115, 20);
            this.lblGia.TabIndex = 9;
            this.lblGia.Text = "Đơn Giá (VNĐ):";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDonGia.ForeColor = System.Drawing.Color.White;
            this.txtDonGia.Location = new System.Drawing.Point(150, 162);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(300, 27);
            this.txtDonGia.TabIndex = 10;
            // 
            // pnlSearch
            // 
            this.pnlSearch.ColumnCount = 4;
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSearch.Controls.Add(this.btnThem, 0, 0);
            this.pnlSearch.Controls.Add(this.btnCapNhat, 1, 0);
            this.pnlSearch.Controls.Add(this.btnXoa, 2, 0);
            this.pnlSearch.Controls.Add(this.btnLamMoi, 3, 0);
            this.pnlSearch.Location = new System.Drawing.Point(40, 245);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.RowCount = 1;
            this.pnlSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSearch.Size = new System.Drawing.Size(920, 50);
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
            this.btnThem.Location = new System.Drawing.Point(10, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(210, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM BẬC GIÁ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Location = new System.Drawing.Point(240, 5);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(210, 40);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(470, 5);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(210, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA BẬC";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(700, 5);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(210, 40);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.panelBottom.Controls.Add(this.dgvChiTiet);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 320);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(20);
            this.panelBottom.Size = new System.Drawing.Size(1000, 280);
            this.panelBottom.TabIndex = 2;
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.dgvChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTiet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiTiet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiTiet.ColumnHeadersHeight = 40;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.EnableHeadersVisualStyles = false;
            this.dgvChiTiet.Location = new System.Drawing.Point(20, 20);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.RowTemplate.Height = 35;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(960, 240);
            this.dgvChiTiet.TabIndex = 0;
            this.dgvChiTiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellContentClick);
            // 
            // FormChiTietBangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChiTietBangGia";
            this.Text = "Chi Tiết Bậc Thang Điện";
            this.Load += new System.EventHandler(this.FormChiTietBangGia_Load);
            this.panelTop.ResumeLayout(false);
            this.palThongTin.ResumeLayout(false);
            this.palThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBac)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel palThongTin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lblMaBG;
        private System.Windows.Forms.ComboBox cmbBangGiaCha;
        private System.Windows.Forms.Label lblBac;
        private System.Windows.Forms.NumericUpDown nudBac;
        private System.Windows.Forms.Label lblTuSo;
        private System.Windows.Forms.TextBox txtTuSo;
        private System.Windows.Forms.Label lblDenSo;
        private System.Windows.Forms.TextBox txtDenSo;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TableLayoutPanel pnlSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dgvChiTiet;
    }
}