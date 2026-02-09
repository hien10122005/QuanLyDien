namespace QuanLyDien.Admin
{
    partial class FormQuanLyKhuVuc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKhuVuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKhuVuc = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dgvKhuVuc = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.palThongTin.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuVuc)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(1000, 280);
            this.panelTop.TabIndex = 0;
            this.panelTop.Resize += new System.EventHandler(this.panelTop_Resize);
            // 
            // palThongTin
            // 
            this.palThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.palThongTin.Controls.Add(this.labelTitle);
            this.palThongTin.Controls.Add(this.label1);
            this.palThongTin.Controls.Add(this.txtMaKhuVuc);
            this.palThongTin.Controls.Add(this.label2);
            this.palThongTin.Controls.Add(this.txtTenKhuVuc);
            this.palThongTin.Location = new System.Drawing.Point(82, 12);
            this.palThongTin.Name = "palThongTin";
            this.palThongTin.Size = new System.Drawing.Size(833, 185);
            this.palThongTin.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(374, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ DANH MỤC KHU VỰC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(55, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khu Vực:";
            // 
            // txtMaKhuVuc
            // 
            this.txtMaKhuVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtMaKhuVuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKhuVuc.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtMaKhuVuc.ForeColor = System.Drawing.Color.White;
            this.txtMaKhuVuc.Location = new System.Drawing.Point(175, 68);
            this.txtMaKhuVuc.Name = "txtMaKhuVuc";
            this.txtMaKhuVuc.Size = new System.Drawing.Size(600, 27);
            this.txtMaKhuVuc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(55, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Khu Vực:";
            // 
            // txtTenKhuVuc
            // 
            this.txtTenKhuVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtTenKhuVuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKhuVuc.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtTenKhuVuc.ForeColor = System.Drawing.Color.White;
            this.txtTenKhuVuc.Location = new System.Drawing.Point(175, 118);
            this.txtTenKhuVuc.Name = "txtTenKhuVuc";
            this.txtTenKhuVuc.Size = new System.Drawing.Size(600, 27);
            this.txtTenKhuVuc.TabIndex = 4;
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
            this.pnlSearch.Controls.Add(this.btnXoa, 2, 0);
            this.pnlSearch.Controls.Add(this.btnLamMoi, 3, 0);
            this.pnlSearch.Location = new System.Drawing.Point(82, 210);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.RowCount = 1;
            this.pnlSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSearch.Size = new System.Drawing.Size(833, 50);
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
            this.btnThem.Size = new System.Drawing.Size(198, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM KHU VỰC";
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
            this.btnSua.Location = new System.Drawing.Point(213, 5);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(198, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "CẬP NHẬT";
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
            this.btnXoa.Location = new System.Drawing.Point(421, 5);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(198, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA";
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
            this.btnLamMoi.Location = new System.Drawing.Point(629, 5);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(199, 40);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.panelBottom.Controls.Add(this.dgvKhuVuc);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 280);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(20);
            this.panelBottom.Size = new System.Drawing.Size(1000, 320);
            this.panelBottom.TabIndex = 2;
            // 
            // dgvKhuVuc
            // 
            this.dgvKhuVuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhuVuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.dgvKhuVuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhuVuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhuVuc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvKhuVuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhuVuc.ColumnHeadersHeight = 40;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhuVuc.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKhuVuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhuVuc.EnableHeadersVisualStyles = false;
            this.dgvKhuVuc.Location = new System.Drawing.Point(20, 20);
            this.dgvKhuVuc.Name = "dgvKhuVuc";
            this.dgvKhuVuc.RowHeadersVisible = false;
            this.dgvKhuVuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhuVuc.Size = new System.Drawing.Size(960, 280);
            this.dgvKhuVuc.TabIndex = 0;
            this.dgvKhuVuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhuVuc_CellClick);
            // 
            // FormQuanLyKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyKhuVuc";
            this.Text = "Quản Lý Khu Vực";
            this.Load += new System.EventHandler(this.FormQuanLyKhuVuc_Load);
            this.panelTop.ResumeLayout(false);
            this.palThongTin.ResumeLayout(false);
            this.palThongTin.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuVuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel palThongTin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKhuVuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKhuVuc;
        private System.Windows.Forms.TableLayoutPanel pnlSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dgvKhuVuc;
    }
}