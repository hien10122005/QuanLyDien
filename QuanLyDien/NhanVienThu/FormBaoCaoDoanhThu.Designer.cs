namespace QuanLyDien.NhanVienThu
{
    partial class FormBaoCaoDoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudThang = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panelKPI = new System.Windows.Forms.TableLayoutPanel();
            this.palKPI3 = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.palKPI2 = new System.Windows.Forms.Panel();
            this.lblSanLuongNam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.palKPI1 = new System.Windows.Forms.Panel();
            this.lblSanLuongThang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkXemCaNam = new System.Windows.Forms.CheckBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).BeginInit();
            this.panelKPI.SuspendLayout();
            this.palKPI3.SuspendLayout();
            this.palKPI2.SuspendLayout();
            this.palKPI1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.groupBoxFilter);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1179, 100);
            this.panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(308, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "BÁO CÁO DOANH THU";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.chkXemCaNam);
            this.groupBoxFilter.Controls.Add(this.btnThongKe);
            this.groupBoxFilter.Controls.Add(this.btnInBaoCao);
            this.groupBoxFilter.Controls.Add(this.nudNam);
            this.groupBoxFilter.Controls.Add(this.label2);
            this.groupBoxFilter.Controls.Add(this.nudThang);
            this.groupBoxFilter.Controls.Add(this.label1);
            this.groupBoxFilter.ForeColor = System.Drawing.Color.Silver;
            this.groupBoxFilter.Location = new System.Drawing.Point(400, 12);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(759, 75);
            this.groupBoxFilter.TabIndex = 1;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Bộ lọc báo cáo";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(478, 25);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(130, 35);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "XEM THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(0)))), ((int)(((byte)(167)))));
            this.btnInBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnInBaoCao.Location = new System.Drawing.Point(618, 25);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(130, 35);
            this.btnInBaoCao.TabIndex = 1;
            this.btnInBaoCao.Text = "XUẤT BÁO CÁO";
            this.btnInBaoCao.UseVisualStyleBackColor = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // nudNam
            // 
            this.nudNam.Location = new System.Drawing.Point(200, 32);
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
            this.nudNam.Size = new System.Drawing.Size(80, 25);
            this.nudNam.TabIndex = 2;
            this.nudNam.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(150, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm:";
            // 
            // nudThang
            // 
            this.nudThang.Location = new System.Drawing.Point(70, 32);
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
            this.nudThang.Size = new System.Drawing.Size(60, 25);
            this.nudThang.TabIndex = 4;
            this.nudThang.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tháng:";
            // 
            // panelKPI
            // 
            this.panelKPI.ColumnCount = 3;
            this.panelKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.panelKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.panelKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.panelKPI.Controls.Add(this.palKPI3, 2, 0);
            this.panelKPI.Controls.Add(this.palKPI2, 1, 0);
            this.panelKPI.Controls.Add(this.palKPI1, 0, 0);
            this.panelKPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKPI.Location = new System.Drawing.Point(0, 100);
            this.panelKPI.Name = "panelKPI";
            this.panelKPI.Padding = new System.Windows.Forms.Padding(10);
            this.panelKPI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.panelKPI.Size = new System.Drawing.Size(1179, 130);
            this.panelKPI.TabIndex = 1;
            // 
            // palKPI3
            // 
            this.palKPI3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.palKPI3.Controls.Add(this.lblDoanhThu);
            this.palKPI3.Controls.Add(this.label6);
            this.palKPI3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palKPI3.Location = new System.Drawing.Point(785, 13);
            this.palKPI3.Name = "palKPI3";
            this.palKPI3.Size = new System.Drawing.Size(381, 104);
            this.palKPI3.TabIndex = 0;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThu.ForeColor = System.Drawing.Color.Yellow;
            this.lblDoanhThu.Location = new System.Drawing.Point(0, 23);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(381, 81);
            this.lblDoanhThu.TabIndex = 0;
            this.lblDoanhThu.Text = "0 VNĐ";
            this.lblDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(381, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "TỔNG DOANH THU THÁNG";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // palKPI2
            // 
            this.palKPI2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.palKPI2.Controls.Add(this.lblSanLuongNam);
            this.palKPI2.Controls.Add(this.label5);
            this.palKPI2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palKPI2.Location = new System.Drawing.Point(399, 13);
            this.palKPI2.Name = "palKPI2";
            this.palKPI2.Size = new System.Drawing.Size(380, 104);
            this.palKPI2.TabIndex = 1;
            // 
            // lblSanLuongNam
            // 
            this.lblSanLuongNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSanLuongNam.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSanLuongNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSanLuongNam.Location = new System.Drawing.Point(0, 23);
            this.lblSanLuongNam.Name = "lblSanLuongNam";
            this.lblSanLuongNam.Size = new System.Drawing.Size(380, 81);
            this.lblSanLuongNam.TabIndex = 0;
            this.lblSanLuongNam.Text = "0 kWh";
            this.lblSanLuongNam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "TỔNG SẢN LƯỢNG NĂM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // palKPI1
            // 
            this.palKPI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.palKPI1.Controls.Add(this.lblSanLuongThang);
            this.palKPI1.Controls.Add(this.label4);
            this.palKPI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palKPI1.Location = new System.Drawing.Point(13, 13);
            this.palKPI1.Name = "palKPI1";
            this.palKPI1.Size = new System.Drawing.Size(380, 104);
            this.palKPI1.TabIndex = 2;
            // 
            // lblSanLuongThang
            // 
            this.lblSanLuongThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSanLuongThang.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSanLuongThang.ForeColor = System.Drawing.Color.Lime;
            this.lblSanLuongThang.Location = new System.Drawing.Point(0, 23);
            this.lblSanLuongThang.Name = "lblSanLuongThang";
            this.lblSanLuongThang.Size = new System.Drawing.Size(380, 81);
            this.lblSanLuongThang.TabIndex = 0;
            this.lblSanLuongThang.Text = "0 kWh";
            this.lblSanLuongThang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "TỔNG SẢN LƯỢNG THÁNG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkXemCaNam
            // 
            this.chkXemCaNam.AutoSize = true;
            this.chkXemCaNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkXemCaNam.Location = new System.Drawing.Point(305, 35);
            this.chkXemCaNam.Name = "chkXemCaNam";
            this.chkXemCaNam.Size = new System.Drawing.Size(154, 25);
            this.chkXemCaNam.TabIndex = 6;
            this.chkXemCaNam.Text = "Thống Kê Cả Năm";
            this.chkXemCaNam.UseVisualStyleBackColor = true;
            this.chkXemCaNam.CheckedChanged += new System.EventHandler(this.chkXemCaNam_CheckedChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.dgvBaoCao);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 230);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(20);
            this.panelBottom.Size = new System.Drawing.Size(1179, 349);
            this.panelBottom.TabIndex = 4;
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.dgvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Cyan;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaoCao.ColumnHeadersHeight = 40;
            this.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCao.EnableHeadersVisualStyles = false;
            this.dgvBaoCao.Location = new System.Drawing.Point(20, 20);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersVisible = false;
            this.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCao.Size = new System.Drawing.Size(1139, 309);
            this.dgvBaoCao.TabIndex = 0;
            // 
            // FormBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1179, 579);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelKPI);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaoCaoDoanhThu";
            this.Text = "Báo Cáo Doanh Thu";
            this.Load += new System.EventHandler(this.FormBaoCaoDoanhThu_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).EndInit();
            this.panelKPI.ResumeLayout(false);
            this.palKPI3.ResumeLayout(false);
            this.palKPI2.ResumeLayout(false);
            this.palKPI1.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop, palKPI1, palKPI2, palKPI3;
        private System.Windows.Forms.TableLayoutPanel panelKPI;
        private System.Windows.Forms.Label labelTitle, label1, label2, label4, label5, label6;
        private System.Windows.Forms.Label lblSanLuongThang, lblSanLuongNam, lblDoanhThu;
        private System.Windows.Forms.NumericUpDown nudThang, nudNam;
        private System.Windows.Forms.Button btnThongKe, btnInBaoCao;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.CheckBox chkXemCaNam;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dgvBaoCao;
    }
}