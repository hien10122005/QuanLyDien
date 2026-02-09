using System.Windows.Forms;

namespace QuanLyDien.Admin
{
    partial class FormQuanLyNhanVien
    {
        private System.ComponentModel.IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.palThongTin = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btbClea = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.palThongTin.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.palThongTin);
            this.panel1.Controls.Add(this.pnlSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(901, 260);
            this.panel1.TabIndex = 0;
            this.panel1.Resize += new System.EventHandler(this.panel6_Resize);
            // 
            // palThongTin
            // 
            this.palThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.palThongTin.Controls.Add(this.label8);
            this.palThongTin.Controls.Add(this.cmbTrangThai);
            this.palThongTin.Controls.Add(this.label7);
            this.palThongTin.Controls.Add(this.label6);
            this.palThongTin.Controls.Add(this.label2);
            this.palThongTin.Controls.Add(this.label5);
            this.palThongTin.Controls.Add(this.label4);
            this.palThongTin.Controls.Add(this.txtHoTen);
            this.palThongTin.Controls.Add(this.label3);
            this.palThongTin.Controls.Add(this.txtDienThoai);
            this.palThongTin.Controls.Add(this.txtMaNV);
            this.palThongTin.Controls.Add(this.label1);
            this.palThongTin.Location = new System.Drawing.Point(23, 12);
            this.palThongTin.Name = "palThongTin";
            this.palThongTin.Size = new System.Drawing.Size(855, 163);
            this.palThongTin.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(445, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Trạng Thái :";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.cmbTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTrangThai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbTrangThai.ForeColor = System.Drawing.Color.White;
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(560, 110);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(250, 28);
            this.cmbTrangThai.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(445, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Số Điện Thoại :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Họ Tên NV :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã NV :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 16;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHoTen.ForeColor = System.Drawing.Color.White;
            this.txtHoTen.Location = new System.Drawing.Point(140, 105);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(250, 27);
            this.txtHoTen.TabIndex = 12;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 17;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDienThoai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDienThoai.ForeColor = System.Drawing.Color.White;
            this.txtDienThoai.Location = new System.Drawing.Point(560, 57);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(250, 27);
            this.txtDienThoai.TabIndex = 13;
            this.txtDienThoai.TextChanged += new System.EventHandler(this.txtDienThoai_TextChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaNV.ForeColor = System.Drawing.Color.White;
            this.txtMaNV.Location = new System.Drawing.Point(140, 57);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(250, 27);
            this.txtMaNV.TabIndex = 9;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 18;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnThem);
            this.pnlSearch.Controls.Add(this.btnSua);
            this.pnlSearch.Controls.Add(this.btnXoa);
            this.pnlSearch.Controls.Add(this.btnTim);
            this.pnlSearch.Controls.Add(this.btbClea);
            this.pnlSearch.Location = new System.Drawing.Point(23, 190);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(855, 50);
            this.pnlSearch.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(25, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(195, 5);
            this.btnSua.Margin = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btbSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(365, 5);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "KHÓA ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btbXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(535, 5);
            this.btnTim.Margin = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 40);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "TÌM KIẾM";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btbClea
            // 
            this.btbClea.BackColor = System.Drawing.Color.Gray;
            this.btbClea.FlatAppearance.BorderSize = 0;
            this.btbClea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbClea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btbClea.ForeColor = System.Drawing.Color.White;
            this.btbClea.Location = new System.Drawing.Point(705, 5);
            this.btbClea.Margin = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.btbClea.Name = "btbClea";
            this.btbClea.Size = new System.Drawing.Size(120, 40);
            this.btbClea.TabIndex = 4;
            this.btbClea.Text = "LÀM MỚI";
            this.btbClea.UseVisualStyleBackColor = false;
            this.btbClea.Click += new System.EventHandler(this.btbClea_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.dgvNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 260);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(901, 341);
            this.panel2.TabIndex = 1;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(20, 20);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(861, 301);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvNhanVien_DataBindingComplete);
            // 
            // FormQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyNhanVien";
            this.Load += new System.EventHandler(this.FormQuanLyNhanVien_Load_1);
            this.panel1.ResumeLayout(false);
            this.palThongTin.ResumeLayout(false);
            this.palThongTin.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel palThongTin;
        private System.Windows.Forms.Label label5; 
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btbClea;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dgvNhanVien;
        private Label label7;
        private Label label6;
        private Label label2;
        private ComboBox cmbTrangThai;
        private Label label8;
    }
}