using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement.AllUserControl
{
    public partial class UC_ThongKe : UserControl
    {
        function func = new function();
        String query;
        public UC_ThongKe()
        {
            InitializeComponent();
        }

        

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvThongKe.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvThongKe.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvThongKe.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvThongKe.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvThongKe.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvThongKe.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UC_ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            query = "select maHoaDonBan, ngayBan, tenNV ,tongTien, maKH from HoaDonBan where ngayBan between '" + dateFrom.Value + "' and '" + dateTo.Value + "'";
            func.getDataTable(query, dgvThongKe);
        }

        private void btnThongKeNhap_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from HoaDonNhap where ngayNhap between '" + dateFrom2.Value + "' and '" + dateTo2.Value + "'";
                func.getDataTable(query, dgvHoaDonNhap);
            }
            catch
            {

            }
        }

        private void btnExcelNhap_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonNhap.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvHoaDonNhap.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvHoaDonNhap.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvHoaDonNhap.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvHoaDonNhap.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvHoaDonNhap.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
