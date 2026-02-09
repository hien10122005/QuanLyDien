namespace QuanLyDien.ChucNangChung
{
    partial class FormNhatKyHeThong
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvNhatKy = new System.Windows.Forms.DataGridView();
            this.cmbVaiTro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKy)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1140, 60);
            this.panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1140, 60);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "NHẬT KÝ HOẠT ĐỘNG HỆ THỐNG";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.panelFilter.Controls.Add(this.label4);
            this.panelFilter.Controls.Add(this.cmbVaiTro);
            this.panelFilter.Controls.Add(this.btnLamMoi);
            this.panelFilter.Controls.Add(this.btnTim);
            this.panelFilter.Controls.Add(this.label3);
            this.panelFilter.Controls.Add(this.label2);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Controls.Add(this.dtpToDate);
            this.panelFilter.Controls.Add(this.dtpFromDate);
            this.panelFilter.Controls.Add(this.txtSearchUser);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 60);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1140, 80);
            this.panelFilter.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(1028, 25);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 30);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(896, 25);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 30);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(463, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đến:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(243, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Từ ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tài khoản:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(503, 28);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(130, 25);
            this.dtpToDate.TabIndex = 11;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(303, 28);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(130, 25);
            this.dtpFromDate.TabIndex = 12;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtSearchUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchUser.ForeColor = System.Drawing.Color.White;
            this.txtSearchUser.Location = new System.Drawing.Point(90, 28);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(130, 25);
            this.txtSearchUser.TabIndex = 13;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.dgvNhatKy);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 140);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Size = new System.Drawing.Size(1140, 368);
            this.panelContent.TabIndex = 5;
            // 
            // dgvNhatKy
            // 
            this.dgvNhatKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhatKy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.dgvNhatKy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvNhatKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhatKy.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhatKy.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhatKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhatKy.EnableHeadersVisualStyles = false;
            this.dgvNhatKy.Location = new System.Drawing.Point(10, 10);
            this.dgvNhatKy.Name = "dgvNhatKy";
            this.dgvNhatKy.RowHeadersVisible = false;
            this.dgvNhatKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhatKy.Size = new System.Drawing.Size(1120, 348);
            this.dgvNhatKy.TabIndex = 0;
            // 
            // cmbVaiTro
            // 
            this.cmbVaiTro.FormattingEnabled = true;
            this.cmbVaiTro.Location = new System.Drawing.Point(739, 29);
            this.cmbVaiTro.Name = "cmbVaiTro";
            this.cmbVaiTro.Size = new System.Drawing.Size(121, 25);
            this.cmbVaiTro.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(664, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Vai Trò :";
            // 
            // FormNhatKyHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1140, 508);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhatKyHeThong";
            this.Text = "Nhật Ký Hệ Thống";
            this.Load += new System.EventHandler(this.FormNhatKyHeThong_Load);
            this.panelTop.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop, panelFilter;
        private System.Windows.Forms.Label labelTitle, label1, label2, label3;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.DateTimePicker dtpFromDate, dtpToDate;
        private System.Windows.Forms.Button btnTim, btnLamMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVaiTro;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dgvNhatKy;
    }
}