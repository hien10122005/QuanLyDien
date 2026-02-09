using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDien.Class
{
    public static class DataGridViewStyle
    {
        public static void ApplyModernStyle(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(45, 45, 48);

            // Header
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Cell
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Dòng xen kẽ
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);

            // Căn chỉnh
            dgv.RowTemplate.Height = 35;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;

            // Ẩn mấy thứ xấu
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
        }
    }
}
