namespace QuanLyDien.NhanVienThu
{
    partial class FormQuanLyCongNo
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTongNo = new System.Windows.Forms.Label();
            this.lblSoHoNo = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnThucHienXuLy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvCongNo = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.panelTop.Controls.Add(this.lblTongNo);
            this.panelTop.Controls.Add(this.lblSoHoNo);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 100);
            this.panelTop.TabIndex = 2;
            // 
            // lblTongNo
            // 
            this.lblTongNo.AutoSize = true;
            this.lblTongNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongNo.ForeColor = System.Drawing.Color.Yellow;
            this.lblTongNo.Location = new System.Drawing.Point(700, 40);
            this.lblTongNo.Name = "lblTongNo";
            this.lblTongNo.Size = new System.Drawing.Size(130, 21);
            this.lblTongNo.TabIndex = 0;
            this.lblTongNo.Text = "Tổng nợ: 0 VNĐ";
            // 
            // lblSoHoNo
            // 
            this.lblSoHoNo.AutoSize = true;
            this.lblSoHoNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoHoNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSoHoNo.Location = new System.Drawing.Point(450, 40);
            this.lblSoHoNo.Name = "lblSoHoNo";
            this.lblSoHoNo.Size = new System.Drawing.Size(156, 21);
            this.lblSoHoNo.TabIndex = 1;
            this.lblSoHoNo.Text = "Số hộ chưa đóng: 0";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(248, 32);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "THEO DÕI CÔNG NỢ";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnThucHienXuLy);
            this.panelControl.Controls.Add(this.btnLamMoi);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 520);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1000, 80);
            this.panelControl.TabIndex = 1;
            // 
            // btnThucHienXuLy
            // 
            this.btnThucHienXuLy.BackColor = System.Drawing.Color.Crimson;
            this.btnThucHienXuLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucHienXuLy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThucHienXuLy.ForeColor = System.Drawing.Color.White;
            this.btnThucHienXuLy.Location = new System.Drawing.Point(25, 20);
            this.btnThucHienXuLy.Name = "btnThucHienXuLy";
            this.btnThucHienXuLy.Size = new System.Drawing.Size(250, 40);
            this.btnThucHienXuLy.TabIndex = 0;
            this.btnThucHienXuLy.Text = "GHI NHẬN BIỆN PHÁP XỬ LÝ";
            this.btnThucHienXuLy.UseVisualStyleBackColor = false;
            this.btnThucHienXuLy.Click += new System.EventHandler(this.btnThucHienXuLy_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(300, 20);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 40);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvCongNo
            // 
            this.dgvCongNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongNo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.dgvCongNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan;
            this.dgvCongNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCongNo.ColumnHeadersHeight = 40;
            this.dgvCongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCongNo.EnableHeadersVisualStyles = false;
            this.dgvCongNo.Location = new System.Drawing.Point(0, 100);
            this.dgvCongNo.Name = "dgvCongNo";
            this.dgvCongNo.RowHeadersVisible = false;
            this.dgvCongNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongNo.Size = new System.Drawing.Size(1000, 420);
            this.dgvCongNo.TabIndex = 3;
            // 
            // FormQuanLyCongNo
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dgvCongNo);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyCongNo";
            this.Text = "Quản Lý Công Nợ";
            this.Load += new System.EventHandler(this.FormQuanLyCongNo_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop, panelControl;
        private System.Windows.Forms.Label labelTitle, lblSoHoNo, lblTongNo;
        private System.Windows.Forms.Button btnThucHienXuLy, btnLamMoi;
        private System.Windows.Forms.DataGridView dgvCongNo;
    }
}