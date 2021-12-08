using AForge.Video.DirectShow;
using IronBarCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement.AllUserControl
{
    public partial class UC_BanHang : UserControl
    {
        function func = new function();
        String query;
        public UC_BanHang()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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



        //Thêm mới sản phẩm vào giỏ hàng
        protected int n;
        public int total = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            String sqlMaHang = "select maHang from Hang where tenHang = N'" + txtTenHang.Text + "'";
            DataSet ds = func.getData(sqlMaHang);
            String maHang = ds.Tables[0].Rows[0][0].ToString();
            if (txtSoLuong.Value > 0)
            {
                string sqlSoLuong = "SELECT soLuong FROM Hang WHERE maHang = N'" + maHang + "'";

                DataSet dset = func.getData(sqlSoLuong);
                int sl = Convert.ToInt32(dset.Tables[0].Rows[0][0].ToString());
                if (Convert.ToInt32(txtSoLuong.Value) > sl)
                {
                    MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Value = 0;
                    txtSoLuong.Focus();
                    return;
                }
                n = tableThanhToan.Rows.Add();
                tableThanhToan.Rows[n].Cells[0].Value = maHang;
                tableThanhToan.Rows[n].Cells[1].Value = txtTenHang.Text;
                tableThanhToan.Rows[n].Cells[2].Value = txtGia.Text;
                tableThanhToan.Rows[n].Cells[3].Value = txtSoLuong.Value;
                tableThanhToan.Rows[n].Cells[4].Value = txtDVT.Text;
                tableThanhToan.Rows[n].Cells[5].Value = txtThanhTien.Text;
                total = total + Convert.ToInt32(txtThanhTien.Text);

                query = "insert into CTHoaDonBan(maHoaDonBan, maHang, soLuong, thanhTien, donGia) values('" + txtMaHoaDon.Text + "', '" + maHang + "', '" + txtSoLuong.Value + "', '" + Convert.ToInt32(txtThanhTien.Text) + "', '" + txtGia.Text + "')";
                func.setData(query);
                lbTongTien.Text = total + "";
                MessageBox.Show("Thêm vào giỏ thành công!", "Thông Báo");

                // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
                int SLcon = sl - Convert.ToInt32(txtSoLuong.Value);
                string sqlSLCon = "UPDATE Hang SET soLuong =" + SLcon + " WHERE MaHang= N'" + maHang + "'";
                func.setData(sqlSLCon);

                resetValue();
            }
            else
            {
                MessageBox.Show("Hãy nhập số lượng sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        //Reset ô input
        public void resetValue()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtSoLuong.Value = 0;
            txtDVT.Clear();
            txtThanhTien.Clear();
        }

        //Hàm tạo khóa có dạng: TientoNgaythangnam_giophutgiay
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


        int amount;


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void UC_BanHang_Load(object sender, EventArgs e)
        {

            dateNgayBan.Value = DateTime.Now;

            //Load combobox LoaiHang
            query = "select * from LoaiHang";
            func.comboboxLoading(comboLoaiHang, query, "tenLoaiHang", "maLoaiHang");

            //Load combobox ds KHTT
            String queryKHTT = "select * from KhachHang";
            func.comboboxLoading(cbKhachHang, queryKHTT, "tenKH", "maKH");

            btnThem.Enabled = false;
            btnBarcode.Enabled = false;
            btnXoa.Enabled = false;
            btnThanhToan.Enabled = false;
            dialogThanhToan.Visible = false;
            btnPrint.Enabled = false;
            panelBarcode.Visible = false;
            btnHuyHoaDon.Enabled = false;
            btnDungDiem.Enabled = false;

            //input khach hang
            cbKhachHang.Enabled = false;
            cbKhachHang.SelectedValue = 6;
            comboLoaiHang.SelectedIndex = -1;
        }



        //Filter theo loai hang
        private void comboLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = comboLoaiHang.Text;
            query = "select tenHang from Hang, LoaiHang where LoaiHang.tenLoaiHang = N'" + category + "' and Hang.maLoaiHang = LoaiHang.maLoaiHang";
            showItemList(query);
        }



        //Search theo ten
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String category = comboLoaiHang.Text;
            query = "select tenHang from Hang, LoaiHang where LoaiHang.tenLoaiHang = N'" + category + "' and tenHang like N'%" + txtSearch.Text + "%' and Hang.maLoaiHang = LoaiHang.maLoaiHang";
            showItemList(query);
        }


        //chon 1 san pham sau khi search
        private void listItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtSoLuong.ResetText();

                String text = listItem.GetItemText(listItem.SelectedItem);
                txtTenHang.Text = text;
                query = "select giaBan, dvt, maHang from Hang where tenHang = N'" + text + "'";
                DataSet ds = func.getData(query);

                txtGia.Text = ds.Tables[0].Rows[0][0].ToString();
                txtDVT.Text = ds.Tables[0].Rows[0][1].ToString();
                txtMaHang.Text = ds.Tables[0].Rows[0][2].ToString();
            }
            catch
            {
                MessageBox.Show("Hãy chọn đúng dòng có sản phẩm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Nhap so luong => gia tien
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

        //Tạo mới hóa đơn khi bán hàng
        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = CreateKey("HDB");


            if (rbMoi.Checked)
            {
                query = "insert into HoaDonBan(maHoaDonBan, tenNV, maKH, ngayBan) values('" + txtMaHoaDon.Text + "', N'" + txtNhanVien.Text + "', '" + 6 + "', '" + dateNgayBan.Value + "')";
            }
            else
            {
                query = "insert into HoaDonBan(maHoaDonBan, tenNV, maKH, ngayBan) values('" + txtMaHoaDon.Text + "', N'" + txtNhanVien.Text + "', '" + cbKhachHang.SelectedValue + "', '" + dateNgayBan.Value + "')";
            }

            func.setData(query);
            DialogResult d;
            d = MessageBox.Show("Tạo thành công hóa đơn mới! Mã: " + txtMaHoaDon.Text, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (d == DialogResult.OK)
            {
                btnBarcode.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnThanhToan.Enabled = true;
                btnTaoHoaDon.Enabled = false;
                btnHuyHoaDon.Enabled = true;
            }
        }

        //Xóa sản phẩm khỏi giỏ hàng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tableThanhToan.SelectedCells.Count > 0)
            {
                DialogResult d;
                d = MessageBox.Show("Bạn có muốn xóa sản phẩm này khỏi giỏ hàng?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    query = "delete from CTHoaDonBan where maHang = '" + tableThanhToan.SelectedRows[0].Cells[0].Value.ToString() + "' and maHoaDonBan = '" + txtMaHoaDon.Text + "'";


                    String sqlUpdate = "select soLuong from Hang where maHang = '" + tableThanhToan.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    DataSet ds = func.getData(sqlUpdate);
                    String sl = ds.Tables[0].Rows[0][0].ToString();
                    // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
                    int SLcon = Convert.ToInt32(sl) + Convert.ToInt32(tableThanhToan.SelectedRows[0].Cells[3].Value.ToString());
                    string sqlSLCon = "UPDATE Hang SET soLuong =" + SLcon + " WHERE MaHang= N'" + tableThanhToan.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    func.setData(sqlSLCon);


                    func.setData(query);
                    tableThanhToan.Rows.RemoveAt(tableThanhToan.SelectedRows[0].Index);
                    total -= amount;
                    lbTongTien.Text = total + "";
                    MessageBox.Show("Xóa thành công sản phẩm khỏi giỏ hàng.", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Giỏ hàng trống hoặc bạn chưa chọn dòng để xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(tableThanhToan.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
            catch { }
        }

        private void rbKHTT_CheckedChanged(object sender, EventArgs e)
        {
            cbKhachHang.Enabled = true;
            cbKhachHang.SelectedIndex = 0;
        }

        private void rbMoi_CheckedChanged(object sender, EventArgs e)
        {
            cbKhachHang.SelectedValue = 6;
            cbKhachHang.Enabled = false;
        }

        //Thanh toán hóa đơn bán hàng
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                dialogThanhToan.Visible = true;
                dialogThanhToan.BringToFront();
                btnTaoHoaDon.Enabled = false;
                btnXoa.Enabled = false;
                btnThanhToan.Enabled = false;
                btnThem.Enabled = false;

                // Fill value vào dialog thanh toán
                txtMaHoaDonTT.Text = txtMaHoaDon.Text;
                txtThanhToan.Value = Convert.ToInt32(lbTongTien.Text);
                if (!cbKhachHang.SelectedValue.ToString().Equals("6"))
                {
                    double diem = double.Parse(lbTongTien.Text) * 0.02;
                    txtDiem.Text = diem + "";

                    //Lấy điểm hiện có của KHTT
                    query = "select diem from KhachHang where maKH = '" + cbKhachHang.SelectedValue + "'";
                    DataSet ds = func.getData(query);
                    string diemHienCo = ds.Tables[0].Rows[0][0].ToString();
                    txtDiemHienCo.Text = diemHienCo;
                    if (int.Parse(diemHienCo) > 10000)
                    {
                        btnDungDiem.Enabled = true;
                    }
                    else
                    {
                        btnDungDiem.Enabled = false;
                    }
                }
            }
            catch
            {

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "HÓA ĐƠN BÁN HÀNG";
            printer.SubTitle = string.Format("Ngày bán: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
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
            rbMoi.Checked = true;
            comboLoaiHang.SelectedIndex = -1;
            btnHuyHoaDon.Enabled = false;
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

        private void updateDiem()
        {
            String getDiem = "select diem from KhachHang where maKH = '" + cbKhachHang.SelectedValue + "'";
            DataSet ds = func.getData(getDiem);
            String diemHienTai = ds.Tables[0].Rows[0][0].ToString();
            double diemUpdate = double.Parse(diemHienTai) + double.Parse(txtDiem.Text);
            String queryDiemThuong = "update KhachHang set diem = '" + diemUpdate + "' where maKH = '" + cbKhachHang.SelectedValue.ToString() + "'";
            func.setData(queryDiemThuong);
        }

        private void thanhToan()
        {
            //Nếu ko phải KHTT => ko update điểm thưởng
            if (String.IsNullOrEmpty(txtDiem.Text))
            {
                DialogResult d;
                d = MessageBox.Show("Bạn có muốn thanh toán hóa đơn: " + txtMaHoaDon.Text, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (d == DialogResult.OK)
                {
                    query = "update HoaDonBan set tongTien = '" + txtThanhToan.Value + "' where maHoaDonBan = '" + txtMaHoaDonTT.Text + "'";
                    func.setData(query);

                    //updateDiem();
                    MessageBox.Show("Thanh toán thành công!" + Environment.NewLine + "Tổng hóa đơn:" + lbTongTien.Text, "Thông Báo");

                    txtMaHoaDonTT.Clear();
                    txtKhachDua.Clear();
                    txtKhachTra.Clear();
                    txtDiem.Clear();
                    dialogThanhToan.Visible = false;
                    btnPrint.Enabled = true;
                    btnThanhToan.Enabled = false;
                }
            }
            //Update điểm thưởng cho KHTT
            else
            {
                DialogResult d;
                d = MessageBox.Show("Bạn có muốn thanh toán hóa đơn: " + txtMaHoaDon.Text, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (d == DialogResult.OK)
                {
                    query = "update HoaDonBan set tongTien = '" + txtThanhToan.Value + "' where maHoaDonBan = '" + txtMaHoaDonTT.Text + "'";
                    func.setData(query);

                    updateDiem();
                    MessageBox.Show("Thanh toán thành công!" + Environment.NewLine + "Tổng hóa đơn:" + lbTongTien.Text + ". Điểm thưởng: " + txtDiem.Text, "Thông Báo");

                    txtMaHoaDonTT.Clear();
                    txtKhachDua.Clear();
                    txtKhachTra.Clear();
                    txtDiem.Clear();
                    dialogThanhToan.Visible = false;
                    btnPrint.Enabled = true;
                    btnThanhToan.Enabled = false;
                }
            }
        }
        private void btnThanhToanDialog_Click(object sender, EventArgs e)
        {
            try
            {
                //Nếu nhập tiền khách hàng đưa
                if (!String.IsNullOrEmpty(txtKhachDua.Text))
                {
                    int traLaiKhach = Convert.ToInt32(txtKhachTra.Text);
                    if (traLaiKhach <= 0)
                    {
                        MessageBox.Show("Số tiền khách trả phải lớn hơn giá trị hóa đơn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtKhachDua.ResetText();
                        txtKhachTra.ResetText();
                    }
                    else
                    {
                        thanhToan();
                    }
                }
                //Nếu input khách hàng đưa trống
                else
                {

                    thanhToan();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //event nhập tiền khách hàng đưa
        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtKhachDua.Text))
                {
                    int nextMoney = 0;
                    int preMoney = Convert.ToInt32(txtKhachDua.Text);
                    int value = Convert.ToInt32(txtThanhToan.Value.ToString());
                    nextMoney = preMoney - value;

                    txtKhachTra.Text = nextMoney.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReturnDialog_Click(object sender, EventArgs e)
        {
            dialogThanhToan.Visible = false;
            btnThanhToan.Enabled = true;
            btnThem.Enabled = true;
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
                    BarcodeResult result = BarcodeReader.QuicklyReadOneBarcode(panelCamera.Image, BarcodeEncoding.QRCode
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
                query = "select tenHang, giaBan, dvt from Hang where maHang = '" + txtMaHang.Text + "'";
                DataSet ds = func.getData(query);
                string tenHang = ds.Tables[0].Rows[0][0].ToString();
                string giaBan = ds.Tables[0].Rows[0][1].ToString();
                string dvt = ds.Tables[0].Rows[0][2].ToString();

                txtTenHang.Text = tenHang;
                txtGia.Text = giaBan;
                txtDVT.Text = dvt;
            }
            catch
            {

            }
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            query = "delete from HoaDonBan where maHoaDonBan = '" + txtMaHoaDon.Text + "'";
            DialogResult d;
            d = MessageBox.Show("Bạn có muốn hủy hóa đơn Mã: " + txtMaHoaDon.Text, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                func.setData(query);
                MessageBox.Show("Hủy thành công hóa đơn " + txtMaHoaDon.Text);
                txtMaHoaDon.Clear();
                txtNhanVien.Clear();
                rbMoi.Checked = true;
                btnHuyHoaDon.Enabled = false;
                btnTaoHoaDon.Enabled = true;
            }

        }

        private void btnDungDiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tThanhToan = txtThanhToan.Value.ToString();
                string tDiemHienCo = txtDiemHienCo.Text;

                txtDiemHienCo.Text = "0";
                query = "update KhachHang set diem = 0 where maKH = '" + cbKhachHang.SelectedValue + "'";
                func.setData(query);
                int thanhToan = int.Parse(tThanhToan) - int.Parse(tDiemHienCo);
                txtThanhToan.Value = thanhToan;
                btnDungDiem.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

    }
}
