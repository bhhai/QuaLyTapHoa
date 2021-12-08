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
    public partial class UC__KhachHang : UserControl
    {
        function func = new function();
        String query;
        int idKH = 0;

        public UC__KhachHang()
        {
            InitializeComponent();
        }

        private void UC__KhachHang_Load(object sender, EventArgs e)
        {
            LoadDataTable();

            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void LoadDataTable()
        {
            query = "select * from KhachHang";
            func.getDataTable(query, dgvKhachHang);
        }

        private void ResetInput()
        {
            txtTenKH.Clear();
            txtSdt.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String tenKH = txtTenKH.Text.Trim();
            String sdt = txtSdt.Text.Trim();

            if(tenKH == null || tenKH == "")
            {
                txtTenKH.Focus();
                MessageBox.Show("Hãy nhập tên khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(sdt == null || sdt == "")
            {
                txtTenKH.Focus();
                MessageBox.Show("Hãy nhập số điện thoại khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                query = "insert into KhachHang(tenKH, sdt, role) values(N'"+tenKH+ "', '" + sdt + "', '" + 1 + "')";
                func.setData(query);
                LoadDataTable();
                ResetInput();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String tenKH = txtTenKH.Text.Trim();
            String sdt = txtSdt.Text.Trim();

            if (tenKH == null || tenKH == "")
            {
                txtTenKH.Focus();
                MessageBox.Show("Hãy nhập tên khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sdt == null || sdt == "")
            {
                txtTenKH.Focus();
                MessageBox.Show("Hãy nhập số điện thoại khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = "insert into KhachHang(tenKH, sdt, role) values(N'" + tenKH + "', '" + sdt + "', '" + 1 + "')";
                func.setData(query);
                LoadDataTable();
                ResetInput();
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtTenKH.Text = dgvKhachHang.Rows[row].Cells[1].Value.ToString();
                txtSdt.Text = dgvKhachHang.Rows[row].Cells[4].Value.ToString();
                idKH = Convert.ToInt32(dgvKhachHang.Rows[row].Cells[0].Value.ToString());
            }
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            String tenKH = txtTenKH.Text.Trim();
            String sdt = txtSdt.Text.Trim();

            DialogResult d = MessageBox.Show("Bạn có muốn xóa khách hàng: " + tenKH + " khỏi danh sách KHTT không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(d == DialogResult.Yes)
            {
                if (tenKH == null || tenKH == "")
                {
                    txtTenKH.Focus();
                    MessageBox.Show("Hãy nhập tên khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sdt == null || sdt == "")
                {
                    txtTenKH.Focus();
                    MessageBox.Show("Hãy nhập số điện thoại khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "delete from KhachHang where maKH = '" + idKH + "'";
                    func.setData(query);
                    MessageBox.Show("Xóa thành công khách hàng: " + tenKH, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataTable();
                    ResetInput();

                    btnXoa.Enabled = false;
                    btnLuu.Enabled = false;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String tenKH = txtTenKH.Text.Trim();
            String sdt = txtSdt.Text.Trim();

            if (tenKH == null || tenKH == "")
            {
                txtTenKH.Focus();
                MessageBox.Show("Hãy nhập tên khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sdt == null || sdt == "")
            {
                txtTenKH.Focus();
                MessageBox.Show("Hãy nhập số điện thoại khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = "update KhachHang set tenKH = N'"+tenKH+ "', sdt = '" + sdt + "'  where maKH = '" + idKH + "'";
                func.setData(query);
                MessageBox.Show("Cập nhật thành công thông tin khách hàng: " + tenKH, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataTable();
                ResetInput();

                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from KhachHang where tenKH like N'%" +txtSearch.Text.Trim() +"%'";
            func.getDataTable(query, dgvKhachHang);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvKhachHang.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvKhachHang.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvKhachHang.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvKhachHang.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvKhachHang.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
