namespace QuanLyDien.Admin
{
    partial class FormQuanLyDongHo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.palThongTin = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLocKhuVuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDongHo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.pnlSearch = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dgvDongHo = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.palThongTin.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongHo)).BeginInit();
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
            this.palThongTin.Controls.Add(this.label5);
            this.palThongTin.Controls.Add(this.cmbLocKhuVuc);
            this.palThongTin.Controls.Add(this.label1);
            this.palThongTin.Controls.Add(this.txtMaDongHo);
            this.palThongTin.Controls.Add(this.label2);
            this.palThongTin.Controls.Add(this.cmbKhachHang);
            this.palThongTin.Controls.Add(this.label3);
            this.palThongTin.Controls.Add(this.dtpNgayLap);
            this.palThongTin.Controls.Add(this.label4);
            this.palThongTin.Controls.Add(this.cmbTrangThai);
            this.palThongTin.Location = new System.Drawing.Point(41, 12);
            this.palThongTin.Name = "palThongTin";
            this.palThongTin.Size = new System.Drawing.Size(918, 230);
            this.palThongTin.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(305, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ ĐỒNG HỒ ĐIỆN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(520, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "LỌC THEO KHU VỰC:";
            // 
            // cmbLocKhuVuc
            // 
            this.cmbLocKhuVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.cmbLocKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocKhuVuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLocKhuVuc.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmbLocKhuVuc.ForeColor = System.Drawing.Color.White;
            this.cmbLocKhuVuc.Location = new System.Drawing.Point(677, 16);
            this.cmbLocKhuVuc.Name = "cmbLocKhuVuc";
            this.cmbLocKhuVuc.Size = new System.Drawing.Size(210, 28);
            this.cmbLocKhuVuc.TabIndex = 10;
            this.cmbLocKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cmbLocKhuVuc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(35, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Đồng Hồ:";
            // 
            // txtMaDongHo
            // 
            this.txtMaDongHo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtMaDongHo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDongHo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtMaDongHo.ForeColor = System.Drawing.Color.White;
            this.txtMaDongHo.Location = new System.Drawing.Point(145, 67);
            this.txtMaDongHo.Name = "txtMaDongHo";
            this.txtMaDongHo.Size = new System.Drawing.Size(250, 27);
            this.txtMaDongHo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(35, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khách Hàng:";
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.cmbKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKhachHang.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmbKhachHang.ForeColor = System.Drawing.Color.White;
            this.cmbKhachHang.Location = new System.Drawing.Point(145, 117);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(250, 28);
            this.cmbKhachHang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(500, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Lắp:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(620, 67);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(250, 27);
            this.dtpNgayLap.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(500, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trạng Thái:";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTrangThai.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmbTrangThai.ForeColor = System.Drawing.Color.White;
            this.cmbTrangThai.Location = new System.Drawing.Point(620, 117);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(250, 28);
            this.cmbTrangThai.TabIndex = 8;
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
            this.pnlSearch.Controls.Add(this.btnKhoa, 2, 0);
            this.pnlSearch.Controls.Add(this.btnLamMoi, 3, 0);
            this.pnlSearch.Location = new System.Drawing.Point(41, 255);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.RowCount = 1;
            this.pnlSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSearch.Size = new System.Drawing.Size(918, 50);
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
            this.btnThem.Size = new System.Drawing.Size(219, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "LẮP ĐẶT MỚI";
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
            this.btnSua.Location = new System.Drawing.Point(234, 5);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(219, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "CẬP NHẬT";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKhoa.FlatAppearance.BorderSize = 0;
            this.btnKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKhoa.ForeColor = System.Drawing.Color.White;
            this.btnKhoa.Location = new System.Drawing.Point(463, 5);
            this.btnKhoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(219, 40);
            this.btnKhoa.TabIndex = 2;
            this.btnKhoa.Text = "NGỪNG CẤP";
            this.btnKhoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(692, 5);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(221, 40);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.dgvDongHo);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 320);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(20);
            this.panelBottom.Size = new System.Drawing.Size(1000, 280);
            this.panelBottom.TabIndex = 2;
            // 
            // dgvDongHo
            // 
            this.dgvDongHo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDongHo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.dgvDongHo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDongHo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDongHo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDongHo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDongHo.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDongHo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDongHo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDongHo.EnableHeadersVisualStyles = false;
            this.dgvDongHo.Location = new System.Drawing.Point(20, 20);
            this.dgvDongHo.Name = "dgvDongHo";
            this.dgvDongHo.RowHeadersVisible = false;
            this.dgvDongHo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDongHo.Size = new System.Drawing.Size(960, 240);
            this.dgvDongHo.TabIndex = 0;
            this.dgvDongHo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDongHo_CellClick);
            // 
            // FormQuanLyDongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyDongHo";
            this.Text = "Quản Lý Đồng Hồ";
            this.Load += new System.EventHandler(this.FormQuanLyDongHo_Load);
            this.panelTop.ResumeLayout(false);
            this.palThongTin.ResumeLayout(false);
            this.palThongTin.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongHo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel palThongTin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDongHo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLocKhuVuc;
        private System.Windows.Forms.TableLayoutPanel pnlSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dgvDongHo;
    }
}