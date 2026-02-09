namespace QuanLyDien.NhanVienThu
{
    partial class FormInHoaDonDien
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
            this.rptHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptHoaDon
            // 
            this.rptHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptHoaDon.LocalReport.ReportEmbeddedResource = "QuanLyDien.RDLC.rptInHoaDon.rdlc";
            this.rptHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rptHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rptHoaDon.Name = "rptHoaDon";
            this.rptHoaDon.ServerReport.BearerToken = null;
            this.rptHoaDon.Size = new System.Drawing.Size(989, 620);
            this.rptHoaDon.TabIndex = 0;
            // 
            // FormInHoaDonDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(989, 620);
            this.Controls.Add(this.rptHoaDon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormInHoaDonDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn Tiền Điện - Xem Trước Khi In";
            this.Load += new System.EventHandler(this.FormInHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptHoaDon;
    }
}