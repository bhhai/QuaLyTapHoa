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
    public partial class UC_LoaiHang : UserControl
    {
        function func = new function();
        String query;
        public UC_LoaiHang()
        {
            InitializeComponent();
        }

        private void LoadDataTable()
        {
            query = "select * from LoaiHang";
            func.getDataTable(query, dgvLoaiHang);
        }

        private void ResetInput()
        {
            txtTenLoai.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String ten = txtTenLoai.Text.Trim();

            if (ten == null || ten == "")
            {
                txtTenLoai.Focus();
                MessageBox.Show("Hãy nhập tên loại hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = "insert into LoaiHang(tenLoaiHang) values(N'" + ten + "')";
                func.setData(query);
                LoadDataTable();
                ResetInput();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String ten = txtTenLoai.Text.Trim();

            DialogResult d = MessageBox.Show("Bạn có muốn cập nhật thông tin danh mục: " + ten + " không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (ten == null || ten == "")
                {
                    txtTenLoai.Focus();
                    MessageBox.Show("Hãy nhập tên loại hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "update LoaiHang set tenLoaiHang = N'"+ten+"' where maLoaiHang = '" + idLoaiHang + "'";
                    func.setData(query);
                    MessageBox.Show("Cập nhật thành công: " + ten, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataTable();
                    ResetInput();

                    btnXoa.Enabled = false;
                    btnLuu.Enabled = false;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String ten = txtTenLoai.Text.Trim();

            DialogResult d = MessageBox.Show("Bạn có muốn xóa: " + ten + " khỏi danh sách Danh mục sản phẩm không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (ten == null || ten == "")
                {
                    txtTenLoai.Focus();
                    MessageBox.Show("Hãy nhập tên khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "delete from LoaiHang where maLoaiHang = '" + idLoaiHang + "'";
                    func.setData(query);
                    MessageBox.Show("Xóa thành danh mục: " + ten, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataTable();
                    ResetInput();

                    btnXoa.Enabled = false;
                    btnLuu.Enabled = false;
                }
            }
        }

        private void UC_LoaiHang_Load(object sender, EventArgs e)
        {
            LoadDataTable();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }

        int idLoaiHang = 0;
        private void dgvLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtTenLoai.Text = dgvLoaiHang.Rows[row].Cells[1].Value.ToString();
                idLoaiHang = Convert.ToInt32(dgvLoaiHang.Rows[row].Cells[0].Value.ToString());
            }
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from LoaiHang where tenLoaiHang like N'%" + txtSearch.Text.Trim() + "%'";
            func.getDataTable(query, dgvLoaiHang);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvLoaiHang.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvLoaiHang.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvLoaiHang.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvLoaiHang.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvLoaiHang.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvLoaiHang.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
