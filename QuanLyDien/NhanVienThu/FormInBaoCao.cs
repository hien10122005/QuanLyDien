using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms; // Đảm bảo đã cài NuGet WinForms

namespace QuanLyDien.NhanVienThu
{
    public partial class FormInBaoCao : Form
    {
        private DataTable _dt;
        private string _thoiGian;

        public FormInBaoCao(DataTable dt, string thoiGian)
        {
            InitializeComponent();
            this._dt = dt;
            this._thoiGian = thoiGian;
        }

        private void FormInBaoCao_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Khai báo tài nguyên báo cáo (Đảm bảo Build Action là Embedded Resource)
                reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyDien.RDLC.rptDoanhThuTongHop.rdlc";

                // 2. Nạp dữ liệu vào DataSet "dsThongKe" (Phải khớp tên trong Report Data)
                ReportDataSource rds = new ReportDataSource("dsThongKe", _dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                // 3. Nạp tham số paThoiGian để hiện dòng "Tháng ... Năm ..." lên tiêu đề
                // Bước này giúp bạn bỏ cột Tháng ở bảng mà vẫn xem được thời gian ở trên đầu
                ReportParameter p = new ReportParameter("paThoiGian", _thoiGian);
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p });

                // 4. Vẽ báo cáo
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị báo cáo: " + ex.Message);
            }
        }
    }
}