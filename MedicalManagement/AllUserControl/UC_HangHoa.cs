using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace MedicalManagement.AllUserControl
{
    public partial class UC_HangHoa : UserControl
    {
        function func = new function();
        String query;
        public UC_HangHoa()
        {
            InitializeComponent();
        }

        private void UC_HangHoa_Load(object sender, EventArgs e)
        {
            LoadDataTable();
            string query = "select * from LoaiHang";
            func.comboboxLoading(cbLoaiHang, query, "tenLoaiHang", "maLoaiHang");

            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            panelBarcode.Visible = false;
        }

        private void LoadDataTable()
        {
            query = "select * from Hang";
            func.getDataTable(query, dgvHangHoa);
        }

        private void ResetInput()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtGia.Clear();
            txtDvt.Clear();
            txtGhiChu.Clear();
            cbLoaiHang.SelectedItem = null;
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtTenHang.Text = dgvHangHoa.Rows[row].Cells[1].Value.ToString();
                txtGia.Text = dgvHangHoa.Rows[row].Cells[3].Value.ToString();
                txtDvt.Text = dgvHangHoa.Rows[row].Cells[5].Value.ToString();
                txtGhiChu.Text = dgvHangHoa.Rows[row].Cells[6].Value.ToString();
                cbLoaiHang.SelectedValue = dgvHangHoa.Rows[row].Cells[2].Value.ToString();
                txtMaHang.Text = dgvHangHoa.Rows[row].Cells[0].Value.ToString();
            }
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            String tenHang = txtTenHang.Text.Trim();
            String gia = txtGia.Text.Trim();
            String dvt = txtDvt.Text.Trim();
            String ghiChu = txtGhiChu.Text.Trim();

            DialogResult d = MessageBox.Show("Bạn có muốn xóa mặt hàng: " + tenHang + " khỏi danh sách Hàng Hóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (tenHang == null || tenHang == "")
                {
                    txtTenHang.Focus();
                    MessageBox.Show("Hãy nhập tên hàng hóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (gia == null || gia == "")
                {
                    txtGia.Focus();
                    MessageBox.Show("Hãy nhập giá bán!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "delete from Hang where maHang = '" + txtMaHang.Text + "'";
                    func.setData(query);
                    MessageBox.Show("Xóa thành mặt hàng: " + tenHang, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataTable();
                    ResetInput();

                    btnXoa.Enabled = false;
                    btnLuu.Enabled = false;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                String tenHang = txtTenHang.Text.Trim();
                float gia = float.Parse(txtGia.Text.Trim());
                String dvt = txtDvt.Text.Trim();
                String ghiChu = txtGhiChu.Text.Trim();

                DialogResult d = MessageBox.Show("Bạn có muốn cập nhật thông tin mặt hàng: " + tenHang + " không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (tenHang == null || tenHang == "")
                    {
                        txtTenHang.Focus();
                        MessageBox.Show("Hãy nhập tên hàng hóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (gia <= 0 || txtGia.Text == null)
                    {
                        txtGia.Focus();
                        MessageBox.Show("Hãy nhập giá bán!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        query = "update Hang set tenHang = N'" + tenHang + "', maLoaiHang = '" + cbLoaiHang.SelectedValue.ToString() + "' , giaBan = '" + gia + "', dvt = N'" + dvt + "', ghiChu = N'" + ghiChu + "' where maHang = '" + txtMaHang.Text + "'";
                        func.setData(query);
                        MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataTable();
                        ResetInput();

                        btnXoa.Enabled = false;
                        btnLuu.Enabled = false;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvHangHoa.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvHangHoa.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvHangHoa.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvHangHoa.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvHangHoa.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvHangHoa.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Hang where tenHang like N'%" + txtSearch.Text.Trim() + "%'";
            func.getDataTable(query, dgvHangHoa);
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            panelBarcode.Visible = true;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtMaHang.Text))
            {
                MessageBox.Show("Hãy chọn 1 mặt hàng để tạo mã!");
            }
            else
            {
                BarcodeWriter barcode = new BarcodeWriter()
                {
                    Format = BarcodeFormat.CODE_128
                };
                pictureBox.Image = barcode.Write(txtMaHang.Text);
            }
            
        }

        private void btnLuuBarcode_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "JPG|*.jpg|PNG|*.png" })
            {
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            panelBarcode.Visible = false;
            pictureBox.Image = null;
        }
    }
}
