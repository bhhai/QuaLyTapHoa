using IronBarCode;
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
    public partial class UC_NhapHang : UserControl
    {
        function func = new function();
        String query;
        public UC_NhapHang()
        {
            InitializeComponent();
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = CreateKey("HDN");
            query = "insert into HoaDonNhap(maHoaDonNhap, nguoiNhap, maNCC, ngayNhap) values('" + txtMaHoaDon.Text + "', N'" + txtNhanVien.Text + "', '" + cbNCC.SelectedValue + "', '" + dateNgayBan.Value + "')";

            func.setData(query);
            DialogResult d;
            d = MessageBox.Show("Tạo thành công hóa đơn nhập! Mã: " + txtMaHoaDon.Text, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (d == DialogResult.OK)
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnThanhToan.Enabled = true;
                btnTaoHoaDon.Enabled = false;
            }
        }

        private void UC_NhapHang_Load(object sender, EventArgs e)
        {
            //Load combobox ds KHTT
            String queryKHTT = "select * from NCC";
            func.comboboxLoading(cbNCC, queryKHTT, "tenNCC", "maNCC");

            dateNgayBan.Value = DateTime.Now;

            //Load combobox LoaiHang
            query = "select * from LoaiHang";
            func.comboboxLoading(comboLoaiHang, query, "tenLoaiHang", "maLoaiHang");

            comboLoaiHang.SelectedItem = null;

            panelBarcode.Visible = false;
            btnHuyHoaDon.Enabled = false;
        }

        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2021
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }

        //Chuyển đổi từ PM sang dạng 24h
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }

        private void comboLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = comboLoaiHang.Text;
            query = "select tenHang from Hang, LoaiHang where LoaiHang.tenLoaiHang = N'" + category + "' and Hang.maLoaiHang = LoaiHang.maLoaiHang";
            showItemList(query);
        }

        public void showItemList(String query)
        {
            listItem.Items.Clear();
            DataSet ds = func.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listItem.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String category = comboLoaiHang.Text;
            query = "select tenHang from Hang, LoaiHang where LoaiHang.tenLoaiHang = N'" + category + "' or tenHang like N'%" + txtSearch.Text + "%' and Hang.maLoaiHang = LoaiHang.maLoaiHang";
            showItemList(query);
        }

        private void listItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtSoLuong.ResetText();

                String text = listItem.GetItemText(listItem.SelectedItem);
                txtTenHang.Text = text;
                query = "select dvt from Hang where tenHang = N'" + text + "'";
                DataSet ds = func.getData(query);

                txtDVT.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                MessageBox.Show("Hãy chọn đúng dòng có sản phẩm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected int n, total = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            float giaNhap = float.Parse(txtGia.Text);
            int soLuong = int.Parse(txtSoLuong.Value.ToString());

            String sqlMaHang = "select maHang from Hang where tenHang = N'" + txtTenHang.Text + "'";
            DataSet ds = func.getData(sqlMaHang);
            String maHang = ds.Tables[0].Rows[0][0].ToString();

            if (String.IsNullOrEmpty(txtGia.Text) || giaNhap <= 0)
            {
                MessageBox.Show("Giá nhập hàng không được bỏ trống và phải > 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGia.Focus();
            }
            else if (soLuong <= 0)
            {
                MessageBox.Show("Hãy nhập số lượng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
            }
            else
            {
                n = tableThanhToan.Rows.Add();
                tableThanhToan.Rows[n].Cells[0].Value = maHang;
                tableThanhToan.Rows[n].Cells[1].Value = txtTenHang.Text;
                tableThanhToan.Rows[n].Cells[2].Value = txtGia.Text;
                tableThanhToan.Rows[n].Cells[3].Value = txtSoLuong.Value;
                tableThanhToan.Rows[n].Cells[4].Value = txtDVT.Text;
                tableThanhToan.Rows[n].Cells[5].Value = txtThanhTien.Text;
                tableThanhToan.Rows[n].Cells[6].Value = cbNCC.SelectedText;
                total = total + Convert.ToInt32(txtThanhTien.Text);

                query = "insert into CTHoaDonNhap(maHoaDonNhap, maHang, soLuong, thanhTien, giaNhap) values('" + txtMaHoaDon.Text + "', '" + maHang + "', '" + soLuong + "', '" + Convert.ToInt32(txtThanhTien.Text) + "', '" + giaNhap + "')";
                func.setData(query);
                lbTongTien.Text = total + "";
                MessageBox.Show("Thêm vào giỏ thành công!", "Thông Báo");

                // Lấy số lượng còn lại có mã hàng = maHang hiện đang có tại cửa hàng
                string sqlSoLuong = "SELECT soLuong FROM Hang WHERE maHang = N'" + maHang + "'";
                DataSet dset = func.getData(sqlSoLuong);
                int sl = Convert.ToInt32(dset.Tables[0].Rows[0][0].ToString());

                // Thêm mới số lượng của mặt hàng vừa nhập vào bảng tblHang
                int SLcon = sl + Convert.ToInt32(txtSoLuong.Value);
                string sqlSLCon = "UPDATE Hang SET soLuong =" + SLcon + " WHERE MaHang= N'" + maHang + "'";
                func.setData(sqlSLCon);

                resetValue();
            }
        }

        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int soLuong = Convert.ToInt32(txtSoLuong.Value);
                int gia = Convert.ToInt32(txtGia.Text);
                int thanhTien = soLuong * gia;

                txtThanhTien.Text = "" + thanhTien;
            }
            catch
            {
                MessageBox.Show("Hãy thêm đầy đủ thông tin sản phẩm!", "Thông Báo");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "HÓA ĐƠN NHẬP HÀNG";
            printer.SubTitle = string.Format("Ngày nhập: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Tổng hóa đơn: " + lbTongTien.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(tableThanhToan);

            //reset dgv
            tableThanhToan.Rows.Clear();
            lbTongTien.Text = "";
            total = 0;
            btnPrint.Enabled = false;
            comboLoaiHang.SelectedItem = -1;
            listItem.Items.Clear();
            btnTaoHoaDon.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtMaHoaDon.Clear();
            txtGia.Clear();
            comboLoaiHang.SelectedIndex = -1;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Bạn có muốn thanh toán hóa đơn: " + txtMaHoaDon.Text, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (d == DialogResult.OK)
                {
                    query = "update HoaDonNhap set tongTien = '" + lbTongTien.Text + "' where maHoaDonNhap = '" + txtMaHoaDon.Text + "'";
                    func.setData(query);

                    //updateDiem();
                    MessageBox.Show("Thanh toán thành công!" + Environment.NewLine + "Tổng hóa đơn:" + lbTongTien.Text, "Thông Báo");

                    btnPrint.Enabled = true;
                    btnThanhToan.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            panelBarcode.Visible = true;
            panelBarcode.BringToFront();
        }

        private void btnScanner_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "JPG|*.jpg|PNG|*.png" })
            {
                // If the image has been selected
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    panelCamera.Image = Image.FromFile(openFileDialog.FileName); // Put the image in the picture box
                    panelCamera.SizeMode = PictureBoxSizeMode.AutoSize; // Change size property of picturebox
                    BarcodeResult result = IronBarCode.BarcodeReader.QuicklyReadOneBarcode(panelCamera.Image, BarcodeEncoding.QRCode
                        | BarcodeEncoding.Code128, true);

                    if (result != null)
                        txtMaHang.Text = result.ToString(); // Put the result text in the text box
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelBarcode.Visible = false;
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                panelBarcode.Visible = false;
                query = "select tenHang, dvt from Hang where maHang = '" + txtMaHang.Text + "'";
                DataSet ds = func.getData(query);
                string tenHang = ds.Tables[0].Rows[0][0].ToString();
                string dvt = ds.Tables[0].Rows[0][1].ToString();

                txtTenHang.Text = tenHang;
                txtDVT.Text = dvt;
            }
            catch
            {

            }
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            query = "delete from HoaDonNhap where maHoaDonNhap = '" + txtMaHoaDon.Text + "'";
            DialogResult d;
            d = MessageBox.Show("Bạn có muốn hủy hóa đơn Mã: " + txtMaHoaDon.Text, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                func.setData(query);
                MessageBox.Show("Hủy thành công hóa đơn " + txtMaHoaDon.Text);
                txtMaHoaDon.Clear();
                txtNhanVien.Clear();
                btnHuyHoaDon.Enabled = false;
                btnTaoHoaDon.Enabled = true;
            }
        }

        //Reset ô input
        public void resetValue()
        {
            txtTenHang.Clear();
            txtSoLuong.Value = 0;
            txtDVT.Clear();
            txtThanhTien.Clear();
        }
    }
}
