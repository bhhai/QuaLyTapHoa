using ClosedXML.Excel;
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
    public partial class UC_NCC : UserControl
    {
        function func = new function();
        String query;
        public UC_NCC()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadDataTable()
        {
            query = "select * from NCC";
            func.getDataTable(query, dgvNCC);
        }

        private void ResetInput()
        {
            txtTenNCC.Clear();
            txtSdt.Clear();
            txtDiaChi.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String ten = txtTenNCC.Text.Trim();
            String diaChi = txtDiaChi.Text.Trim();
            String sdt = txtSdt.Text.Trim();

            if (ten == null || ten == "")
            {
                txtTenNCC.Focus();
                MessageBox.Show("Hãy nhập tên nhà cung cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sdt == null || sdt == "")
            {
                txtTenNCC.Focus();
                MessageBox.Show("Hãy nhập số điện thoại nhà cung cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (diaChi == null || diaChi == "")
            {
                txtTenNCC.Focus();
                MessageBox.Show("Hãy nhập địa chỉ nhà cung cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = "insert into NCC(tenNCC, diaChi, sdt) values(N'" + ten + "', N'" + diaChi + "', '" + sdt + "')";
                func.setData(query);
                LoadDataTable();
                ResetInput();
            }
        }

        private void UC_NCC_Load(object sender, EventArgs e)
        {
            LoadDataTable();

            //bool result = IronBarCode.License.IsValidLicense("IRONBARCODE.HOANGHAI.20327-4A924043FC-AL7G62-BD2CB4NV2DPL-35UYXZFNL3JC-E2VXX5VOMJJ4-PVXWEYTGMMRU-SDSCNIS6LPRF-3JZDT6-TPSYARSAAJGCUA-DEPLOYMENT.TRIAL-DRUBWG.TRIAL.EXPIRES.12.NOV.2021");
            //MessageBox.Show("" + result);

            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            //this.nCCTableAdapter.Fill(this.appData1.NCC);
        }

        int idNCC = 0;
        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtTenNCC.Text = dgvNCC.Rows[row].Cells[1].Value.ToString();
                txtSdt.Text = dgvNCC.Rows[row].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNCC.Rows[row].Cells[2].Value.ToString();
                idNCC = Convert.ToInt32(dgvNCC.Rows[row].Cells[0].Value.ToString());
            }
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String ten = txtTenNCC.Text.Trim();
            String diaChi = txtDiaChi.Text.Trim();
            String sdt = txtSdt.Text.Trim();

            DialogResult d = MessageBox.Show("Bạn có muốn xóa nhà cung cấp: " + ten + " khỏi danh sách KHTT không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (ten == null || ten == "")
                {
                    txtTenNCC.Focus();
                    MessageBox.Show("Hãy nhập tên nhà cung cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sdt == null || sdt == "")
                {
                    txtTenNCC.Focus();
                    MessageBox.Show("Hãy nhập số điện thoại nhà cung cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (diaChi == null || diaChi == "")
                {
                    txtTenNCC.Focus();
                    MessageBox.Show("Hãy nhập địa chỉ nhà cung cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "delete from NCC where maNCC = '" + idNCC + "'";
                    func.setData(query);
                    MessageBox.Show("Xóa thành công nhà cung cấp: " + ten, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataTable();
                    ResetInput();

                    btnXoa.Enabled = false;
                    btnLuu.Enabled = false;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String ten = txtTenNCC.Text.Trim();
            String diaChi = txtDiaChi.Text.Trim();
            String sdt = txtSdt.Text.Trim();

            DialogResult d = MessageBox.Show("Bạn có muốn cập nhật mới thông tin nhà cung cấp: " + ten + " không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (ten == null || ten == "")
                {
                    txtTenNCC.Focus();
                    MessageBox.Show("Hãy nhập tên nhà cung cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sdt == null || sdt == "")
                {
                    txtTenNCC.Focus();
                    MessageBox.Show("Hãy nhập số điện thoại nhà cung cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (diaChi == null || diaChi == "")
                {
                    txtTenNCC.Focus();
                    MessageBox.Show("Hãy nhập địa chỉ nhà cung cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "update NCC set tenNCC = N'"+ten+ "', diaChi = N'" + diaChi + "', sdt = '" + sdt + "' where maNCC = '" + idNCC + "'";
                    func.setData(query);
                    MessageBox.Show("Cập nhật thành công nhà cung cấp: " + ten, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataTable();
                    ResetInput();

                    btnXoa.Enabled = false;
                    btnLuu.Enabled = false;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from NCC where tenNCC like N'%" + txtSearch.Text.Trim() + "%'";
            func.getDataTable(query, dgvNCC);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dgvNCC.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvNCC.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvNCC.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvNCC.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvNCC.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvNCC.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
